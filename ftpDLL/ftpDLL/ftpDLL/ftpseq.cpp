#include "pch.h"
#include "ftpseq.h"
#include "ftpsocket.h"
#include "ecode.h"
#include "reply.h"

ftpseq::ftpseq()
{
	variables();
}

ftpseq::~ftpseq()
{

}

/*!
 * @file		ftpseq.cpp
 * @fn			int ftpseq::variables(void)
 * @brief		メンバ変数を初期化する
 * @details		メンバ変数を初期化する
 * @return		0 <  Return value: TBD
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @param[in]	void
 * @date		2022/3/3
 * @note		initialize()は制御系の初期化
 */
int ftpseq::variables(void)
{
	mmyState = ESTATE::eWAITING;
	mpSOCKET[ESOCK::eCTRL] = (ftpsocket*)0;
	mpSOCKET[ESOCK::eTRAN] = (ftpsocket*)0;

    return RET_SUCCESS;
}
/*!
 * @file		ftpsocket.cpp
 * @fn			int ftpsocket::getBuffer(char* pBuffer, int bufSize)
 * @brief		ローカルバッファ取得(0x00で初期化済)
 * @details		ヒープ確保
 * @return		0 <  Return value: エラーコード
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @param[out]	pBuffer			バッファアドレス
 * @param[in]	bufSize			バッファサイズ
 * @date		2022/3/4
 * @note        メモリ解放は呼び出し元の責務。必ず、解放すること。
 */
int ftpseq::newBuffer(char** pBuffer, int bufSize)
{
	int		rc = RET_SUCCESS;
	char*	ptmp = (char*)0;

	ptmp = new char[bufSize];
	if (ptmp == (char*)0) {
		ecode	retobj(ecode::eVALUE::eNEW, __FUNCTION__, "0 = new char[bufSize]");
		retobj.output();
		rc = retobj.rc();								// 戻り値に変換
	}
	else {
		memset(ptmp, 0x00, bufSize);
        *pBuffer = ptmp;
	}
	return rc;
}

/*!
 * @file		ftpseq.cpp
 * @fn			int ftpseq::up(ftpsocket& rSD, std::string& rCmd, void* pArgs)
 * @brief		ユーザー名/パスワード入力
 * @details		ユーザー名/パスワード入力
 * @return		0 <  VALUE:		エラーコード
 *				0 == VALUE:		TBD
 *				0 >  VALUE:		状態遷移コード
 * @param[in]	rSD				SOCKETディスクブリタ
 * @param[in]	rCmd		コマンド文字列
 * @param[in]	pArgs			未使用
 * @date		2022/3/4
 * @note		リプライコード判定はRF959に準拠
 */
int ftpseq::up(ftpsocket& rSD, std::string& rCmd, void* pArgs)
{
	int				ret_socket;
	char*			prcvbuf = (char*)0;

	//std::string		strtest = "USER " + mUsername + "\n";
	//std::stringstream ss;
	//ss << "USER " << mUsername << "\n";
	//ss.str(str);

	/*
	 * コマンド送信
	 */
	ret_socket = rSD.sender(SOCCTRL::eMAIN, FTP_WAITTIME, rCmd.c_str(), rCmd.size());
	if (ret_socket < 0) {
		// リプライメッセージにエラーメッセージが含まれるが、
		// 接続エラー時には、recv()をcallしても、リプライメッセージ受信は
		// 期待できないので、ここで終了する
		return ret_socket;								// エラーコード返却
	}

	/*
	 *	リプライ確認
	 */
	ret_socket = this->newBuffer(&prcvbuf, SOCRECV_MAX_SIZE);
	if (ret_socket < 0) {								// メモリ確保失敗
		goto EXIT_FUNCTION;
	}

	ret_socket = rSD.receiver(SOCCTRL::eMAIN, FTP_WAITTIME, prcvbuf, SOCRECV_MAX_SIZE);
	if (ret_socket < 0) {
		goto EXIT_FUNCTION;								// メモリ解放
	}
	else {
		if (reply::range(ret_socket, 200) == true) {	// TBD: パスワードなしでログイン成功してよいか?
			ret_socket = ESTATE::eWAITING;				// RFC959: success
		}
		else if (reply::range(ret_socket, 100) == true) {
			ret_socket = ESTATE::eRESTART;				// RFC959: error 再起動シーケンス
		}
		else if (reply::range(ret_socket, 300) == true) {
			ret_socket = (int)this->mmyState;			// 自分自身へ遷移(パスワード入力へ遷移)
		}
		else if (reply::range(ret_socket, 400, 500) == true) {
			ret_socket = ESTATE::eWAITING;				// RFC959: failure
		}
		else {											// 想定外は無視(FTPサーバーのバージョンアップが原因かも)
			ret_socket = ESTATE::eWAITING;				// アイドル
		}
	}

EXIT_FUNCTION:
	if (prcvbuf) { delete[] prcvbuf; }

	return ret_socket;
}

/*!
 * @file		ftpseq.cpp
 * @fn			int ftpseq::cmd1(ftpsocket& rSD, std::string& rCmd, void* pArgs)
 * @brief		コマンドシーケンス1
 * @details		cmd1に分類したコマンドを実行する。
 * @return		0 <  VALUE:		エラーコード
 *				0 == VALUE:		TBD
 *				0 >  VALUE:		状態遷移コード
 * @param[in]	rSD				SOCKETディスクブリタ
 * @param[in]	rCmd			コマンド文字列
 * @param[in]	pArgs			未使用
 * @date		1970/3/4
 * @note		リプライコード判定はRF959に準拠
 * 				以下のコマンドがコマンドシーケンス1
 * 				ABOR, ALLO, DELE, CWD, CDUP, SMNT, HELP, MODE, NOOP, PASV
 * 				QUIT, SITE, PORT, SYST, STAT, RMD, MKD, PWD, STRU, and TYPE.
 */
int ftpseq::cmd1(ftpsocket& rSD, std::string& rCmd, std::string& rRsp, void* pArgs)
{
	int				ret_socket;
	char*			prcvbuf = (char*)0;

	/*
	 * コマンド送信
	 */
	ret_socket = rSD.sender(SOCTRAN::eLISTEN/*暫定*/, FTP_WAITTIME, rCmd.c_str(), rCmd.size());
	if (ret_socket < 0) {
		// リプライメッセージにエラーメッセージが含まれるが、
		// 接続エラー時には、recv()をcallしても、リプライメッセージ受信は
		// 期待できないので、ここで終了する
		return ret_socket;								// エラーコード返却
	}

	/*
	 *	リプライ確認
	 */
	ret_socket = this->newBuffer(&prcvbuf, SOCRECV_MAX_SIZE);
	if (ret_socket < 0) {								// メモリ確保失敗
		goto EXIT_FUNCTION;
	}

	ret_socket = rSD.receiver(SOCTRAN::eLISTEN/*暫定*/, FTP_WAITTIME, prcvbuf, SOCRECV_MAX_SIZE);
	if (ret_socket < 0) {
		goto EXIT_FUNCTION;								// メモリ解放
	}
	else {
		if (reply::range(ret_socket, 200) == true) {	// 成功
			ret_socket = (int)this->mmyState;			// 自分自身(exit())へ遷移
		}
		else if (reply::range(ret_socket, 100) == true) {
			ret_socket = ESTATE::eRESTART;				// RFC959: error 再起動シーケンス
			printf("[DBG]reply: 1xx..");
// PORTコマンド後のコマンドのreplyは150..
/*暫定*/			ret_socket = (int)this->mmyState;			// 自分自身(exit())へ遷移
		}
		else if (reply::range(ret_socket, 300) == true) {
			ret_socket = ESTATE::eRESTART;				// RFC959: error 再起動シーケンス
		}
		else if (reply::range(ret_socket, 400, 500) == true) {
			ret_socket = ESTATE::eWAITING;				// RFC959: failure
		}
		else {											// 想定外は無視(FTPサーバーのバージョンアップが原因かも)
			ret_socket = ESTATE::eWAITING;				// アイドル
		}
	}
	rRsp = prcvbuf;

EXIT_FUNCTION:
	if (prcvbuf) { delete[] prcvbuf; }

	return ret_socket;
}

/*!
 * @file		ftpseq.cpp
 * @fn			int ftpseq::cmd(ftpsocket& rSD, std::string& rCmd, void* pArgs)
 * @brief		コマンドシーケンス2
 * @details		LISTコマンドを実行する
 * @return		0 <  VALUE:		エラーコード
 *				0 == VALUE:		TBD
 *				0 >  VALUE:		状態遷移コード
 * @param[in]	rSD				SOCKETディスクブリタ
 * @param[in]	rCmd			コマンド文字列
 * @param[in]	pArgs			未使用
 * @date		2022/3/4
 * 				以下のコマンドがコマンドシーケンス2
 * 				APPE, LIST, NLST, REIN, RETR, STOR, and STOU.
 */
int ftpseq::cmd2(ftpsocket& rSD, std::string& rCmd, std::string& rRsp, void* pArgs)
{
	int				ret_socket;
	char*			prcvbuf = (char*)0;

	/*
	 * コマンド送信
	 */
	ret_socket = rSD.sender(SOCCTRL::eMAIN, FTP_WAITTIME, rCmd.c_str(), rCmd.size());
	if (ret_socket < 0) {
		// リプライメッセージにエラーメッセージが含まれるが、
		// 接続エラー時には、recv()をcallしても、リプライメッセージ受信は
		// 期待できないので、ここで終了する
		return ret_socket;								// エラーコード返却
	}

	/*
	 *	リプライ確認
	 */
	ret_socket = this->newBuffer(&prcvbuf, SOCRECV_MAX_SIZE);
	if (ret_socket < 0) {								// メモリ確保失敗
		goto EXIT_FUNCTION;
	}

	ret_socket = rSD.receiver(SOCCTRL::eMAIN, FTP_WAITTIME, prcvbuf, SOCRECV_MAX_SIZE);
	if (ret_socket < 0) {
		goto EXIT_FUNCTION;								// メモリ解放
	}
	else {
		if (reply::range(ret_socket, 200) == true) {	// 成功
			ret_socket = (int)this->mmyState;			// 自分自身(exit())へ遷移
		}
		else if (reply::range(ret_socket, 100) == true) {
			ret_socket = ESTATE::eWAITING;				// TBD: コマンド完了待ち??
		}
		else if (reply::range(ret_socket, 300) == true) {
			ret_socket = ESTATE::eRESTART;				// RFC959: error 再起動シーケンス
		}
		else if (reply::range(ret_socket, 400, 500) == true) {
			ret_socket = ESTATE::eWAITING;				// RFC959: failure
		}
		else {											// 想定外は無視(FTPサーバーのバージョンアップが原因かも)
			ret_socket = ESTATE::eWAITING;				// アイドル
		}
	}
	rRsp = prcvbuf;

EXIT_FUNCTION:
	if (prcvbuf) { delete[] prcvbuf; }

	return ret_socket;
}
