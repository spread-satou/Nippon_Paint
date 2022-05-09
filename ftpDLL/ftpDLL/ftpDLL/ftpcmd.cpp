#include "pch.h"
#include "ftpcmd.h"
#include "params.h"
#include "ftplog.h"
#include "ecode.h"
#include "reply.h"
#include "util_strtok.h"

#include <string>

//! グローバルオブジェクト
extern params              sharedObj;
extern ftplog*             pSharedLog;
extern int                 gLogCtrl;

ftpcmd::ftpcmd()
{
	this->variables();
}

ftpcmd::~ftpcmd(void)
{
	mstrCmd.clear();
}

ftpcmd::ftpcmd(ftpsocket** pSocket, const char* pCommand)
{
	ftpsocket*	pctrl = *(pSocket+0);
	ftpsocket*	ptran = *(pSocket+1);

	this->variables();
	mstrCmd   = pCommand;
	mpSocCtlr = (ftpsocket_ctrl*)pctrl;
	mpSocTran = (ftpsocket_tran*)ptran;
}

int ftpcmd::variables(void)
{
	mstrCmd.clear();	// = "";
	mu32Wait  = FTP_WAITTIME;
	mpSocCtlr = (ftpsocket_ctrl*)0;
	mpSocTran = (ftpsocket_tran*)0;
    return RET_SUCCESS;
}

/*!
 * @file		ftpcmd.cpp
 * @fn			int ftpcmd::newBuffer(char* pBuffer, int bufSize)
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
int ftpcmd::newBuffer(char** pBuffer, int bufSize)
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
 * @file		ftpcmd.cpp
 * @fn			int ftpcmd::groupup(ftpsocket& rSD, std::string& rCmd, void* pArgs)
 * @brief		ユーザー名/パスワード入力
 * @details		ユーザー名/パスワード入力
 * @return		0 <  VALUE:		エラーコード
 *				0 == VALUE:		成功・シーケンス完了
 *				0 >  VALUE:		成功・シーケンス継続
 * @param[in]	rSD				SOCKETディスクブリタ
 * @param[in]	rCmd			コマンド文字列
 * @param[in]	pArgs			未使用
 * @date		2022/3/4
 * @note		TBD: RFC959 failure時のリトライ処理
 */
int ftpcmd::groupup(void* pArgs)
{
	using namespace std;

	int		ret_socket;
	char*	prcvbuf = (char*)0;
	string	str_fullpath;
	string	str_cmd = mstrCmd;
	string::size_type  pos;

	// ログ出力
	pos = str_cmd.rfind("\x0d");
	str_cmd.erase(pos, 2);								// CRLF削除

    str_fullpath = sharedObj.mstrFullPath[EPRM_PATH::eFTPLOG];
    pSharedLog->sync_wait();
	pSharedLog->mvElement[EMSG::eCOMMAND]->writer(&gLogCtrl, str_fullpath.c_str(), str_cmd.c_str());
    pSharedLog->sync_post();

	/*
	 * コマンド送信
	 */
	ret_socket = mpSocCtlr->sender(SOCCTRL::eMAIN, FTP_WAITTIME, mstrCmd.c_str(), mstrCmd.size());
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

	ret_socket = mpSocCtlr->receiver(SOCCTRL::eMAIN, FTP_WAITTIME, prcvbuf, SOCRECV_MAX_SIZE);
	if (ret_socket < 0) {
		goto EXIT_FUNCTION;								// メモリ解放
	}
	else {
		if (reply::range(ret_socket, 200) == true) {	// TBD: パスワードなしでログイン成功してよいか?
			ret_socket = ERESULT::eSUCCESS;				// RFC959: success
		}
		else if (reply::range(ret_socket, 100) == true) {
			ret_socket = ERESULT::eERROR;				// RFC959: error
		}
		else if (reply::range(ret_socket, 300) == true) {
			ret_socket = ERESULT::eCONTINUE;            // 次コマンド実行
		}
		else if (reply::range(ret_socket, 400, 500) == true) {
			ret_socket = ERESULT::eFAILURE;				// RFC959: failure
		}
		else {
			ret_socket = ERESULT::eFAILED;
		}
	}

EXIT_FUNCTION:
	if (prcvbuf) { delete[] prcvbuf; }

	return ret_socket;
}

/*!
 * @file		ftpcmd.cpp
 * @fn			int ftpcmd::cmd1(ftpsocket& rSD, std::string& mstrCmd, void* pArgs)
 * @brief		コマンドシーケンス1
 * @details		cmd1に分類したコマンドを実行する。
 * @return		0 <  VALUE:		エラーコード
 *				0 == VALUE:		成功・シーケンス完了
 *				0 >  VALUE:		成功・シーケンス継続(TBD)
 * @param[in]	rSD				SOCKETディスクブリタ
 * @param[in]	mstrCmd			コマンド文字列
 * @param[in]	pArgs			未使用
 * @date		1970/3/4
 * @note		リプライコード判定はRF959に準拠
 * 				以下のコマンドがgroup1
 * 				ABOR, ALLO, DELE, CWD, CDUP, SMNT, HELP, MODE, NOOP, PASV
 * 				QUIT, SITE, PORT, SYST, STAT, RMD, MKD, PWD, STRU, and TYPE.
 */
int ftpcmd::group1(std::string& rRsp, void* pArgs)
{
	using namespace std;

	int		ret_socket;
	char*	prcvbuf = (char*)0;
	string	str_fullpath;
	string	str_cmd = mstrCmd;
	string::size_type  pos;

	// ログ出力
	pos = str_cmd.rfind("\x0d");
	str_cmd.erase(pos, 2);								// CRLF削除

    str_fullpath = sharedObj.mstrFullPath[EPRM_PATH::eFTPLOG];
    pSharedLog->sync_wait();
	pSharedLog->mvElement[EMSG::eCOMMAND]->writer(&gLogCtrl, str_fullpath.c_str(), str_cmd.c_str());
    pSharedLog->sync_post();

	/*
	 * コマンド送信
	 */
	ret_socket = mpSocCtlr->sender(SOCCTRL::eMAIN, FTP_WAITTIME, mstrCmd.c_str(), mstrCmd.size());
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

	ret_socket = mpSocCtlr->receiver(SOCCTRL::eMAIN, FTP_WAITTIME, prcvbuf, SOCRECV_MAX_SIZE);
	if (ret_socket < 0) {
		goto EXIT_FUNCTION;								// メモリ解放
	}
	else {
		if (reply::range(ret_socket, 200) == true) {	// 成功
			ret_socket = ERESULT::eSUCCESS;
		}
		else if (reply::range(ret_socket, 100) == true) {
            ret_socket = ERESULT::eERROR;               // RFC959: error
			printf("[DBG]reply: 1xx..");
// PORTコマンド後のコマンドのreplyは150..
		}
		else if (reply::range(ret_socket, 300) == true) {
            ret_socket = ERESULT::eERROR;               // RFC959: error
		}
		else if (reply::range(ret_socket, 400, 500) == true) {
			ret_socket = ERESULT::eFAILURE;				// RFC959: failure
		}
		else {											// 想定外は無視(FTPサーバーのバージョンアップが原因かも)
			ret_socket = ERESULT::eFAILED;
		}
	}
	rRsp = prcvbuf;

EXIT_FUNCTION:
	if (prcvbuf) { delete[] prcvbuf; }

	return ret_socket;
}

/*!
 * @file		ftpcmd.cpp
 * @fn			int ftpcmd::cmd(ftpsocket& rSD, std::string& mstrCmd, void* pArgs)
 * @brief		コマンドシーケンス2
 * @details		LISTコマンドを実行する
 * @return		0 <  VALUE:		エラーコード
 *				0 == VALUE:		成功・シーケンス完了
 *				0 >  VALUE:		成功・シーケンス継続
 * @param[in]	rSD				SOCKETディスクブリタ
 * @param[in]	mstrCmd			コマンド文字列
 * @param[in]	pArgs			未使用
 * @date		2022/3/4
 * 				以下のコマンドがgroup2
 * 				APPE, LIST, NLST, REIN, RETR, STOR, and STOU.
 */
int ftpcmd::group2(std::string& rRsp, void* pArgs)
{
	using namespace std;

	int		ret_socket;
	int		ret_reply = ERESULT::eFAILED;
	char*	prcvbuf = (char*)0;
	string	str_reply;
	size_t	rcvleng;
	string	str_fullpath;
	string	str_cmd = mstrCmd;
	string::size_type  pos;

	// ログ出力
	pos = str_cmd.rfind("\x0d");
	str_cmd.erase(pos, 2);								// CRLF削除

    str_fullpath = sharedObj.mstrFullPath[EPRM_PATH::eFTPLOG];
    pSharedLog->sync_wait();
	pSharedLog->mvElement[EMSG::eCOMMAND]->writer(&gLogCtrl, str_fullpath.c_str(), str_cmd.c_str());
    pSharedLog->sync_post();

	/*
	 * コマンド送信
	 */
	ret_socket = mpSocCtlr->sender(SOCCTRL::eMAIN, FTP_WAITTIME, mstrCmd.c_str(), mstrCmd.size());
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
	do {
		ret_socket = mpSocCtlr->receiver(SOCCTRL::eMAIN, FTP_WAITTIME/*wait(msec)*/, prcvbuf, SOCRECV_MAX_SIZE);
		if (ret_socket < 0) {
			goto EXIT_FUNCTION;							// メモリ解放
		}
		else {

			#if 0
			{	//以下、splitter()テスト
				std::string	str_test;
				size_t		sz ;

				//str_test = "RFORDER2021100700382.ORD\x0aRFORDER2021100700382.ORD";	// 2分割
				//str_test = "RFORDER2021100700382.ORDRFORDER2021100700382.ORD";		// 区切り文字なし	丸ごと取得
				//str_test = "RFORDER2021100700382.ORD\x0d";							// 区切り文字なし	丸ごと取得
				//str_test = "RFORDER2021100700382.ORD\x0a";							// 区切り文字が終端	区切り文字除くファイル名取得
				str_test = "RFORDER2021100700382.ORD\x0d\x0a";							// 通常				\x0d付きのファイル名取得
				sz = str_test.size();

				memset(prcvbuf, 0x00, sz+1);
				memcpy(prcvbuf, str_test.c_str(), sz);
			}
			#endif
			rcvleng = ::strlen(prcvbuf);
			ret_reply = this->splitter(str_reply, prcvbuf, rcvleng);
														// 連結最後のメッセージ取得
			if (ret_reply < 0) {
				ret_socket = ret_reply;
				goto EXIT_FUNCTION;						// メモリ解放
			}

			// splitter()戻り値判定
			if (reply::range(ret_reply, 200) == true) {	// 成功
				ret_socket = ERESULT::eSUCCESS;			// 自分自身(exit())へ遷移
			}
			else if (reply::range(ret_reply, 100) == true) {
				ret_socket = ERESULT::eCONTINUE;		// 再受信
				memset(prcvbuf, 0x00, SOCRECV_MAX_SIZE);
			}
			else if (reply::range(ret_reply, 300) == true) {
				ret_socket = ERESULT::eERROR;			// RFC959: error
			}
			else if (reply::range(ret_reply, 400, 500) == true) {
				ret_socket = ERESULT::eFAILURE;			// RFC959: failure
			}
			else {										// 想定外は無視(FTPサーバーのバージョンアップが原因かも)
				ret_socket = ERESULT::eFAILED;
			}
		}
	} while(ret_socket == ERESULT::eCONTINUE);

	rRsp = str_reply;

EXIT_FUNCTION:
	if (prcvbuf) { delete[] prcvbuf; }

	return ret_socket;
}

/*!
 * @file          ftpcmd.cpp
 * @fn            int ftpcmd::splitter(char* pBuffer)
 * @brief         リプライメッセージ分割
 * @details       連結したリプライメッセージを分割して、最後のメッセージのリプライコードを返す
 * @return        0 <  VALUE: 分割失敗
 *                0 >= VALUE: リプライコード(1xx～5xx)
 * @date          2022/3/14
 * @note          ***
 */
int ftpcmd::splitter(std::string& strDest, char* pBuffer, size_t siLength)
{
	int				rc = ERESULT::eSUCCESS;
	reply*			preply = (reply*)0;					// CONNECT()リプライ
	const char*		psepa = "\x0d\x0a";					// CRLF
	//const char* psepa = "\x0b";						// DEBUG TAB
	size_t			num;

	std::vector<std::string>	vmsg;
	std::string					str_lastmsg;

	num = utility::strtok::splitter(vmsg, pBuffer, siLength, psepa);
	if (num > 0) {										// 2こ以上あれば
		str_lastmsg = vmsg[num - 1];					// 最後のメッセージ取得
	}
	else {
		return ERESULT::eFAILED;						// \x0aで分割失敗
	}

	preply = new reply((char*)str_lastmsg.c_str(), DBG_FLAG);
	if (preply == (reply*)0) {
		ecode	retobj(ecode::eVALUE::eNEW, __FUNCTION__, "0 = new reply()");
		retobj.output();
		rc = retobj.rc();								// 戻り値に変換
		goto EXIT_FUNCTION;
	}

	// ※ リプライコード取得失敗
	//	get_code()は3桁の10進数、あるいは、エラーコードを返却。0が返却されるはずはない。
	//	0以下判定はフェイルセーフ
	rc = preply->get_code();							// FTPリプライ取得
	if (rc == 0) {										// コード取得失敗
		rc = ERESULT::eFAILED;
		goto EXIT_FUNCTION;
	}
	else if (rc < 0) {
		goto EXIT_FUNCTION;
	}
	else {/*リプライ3桁*/}

EXIT_FUNCTION:
	if (preply) {delete preply;}
	if (rc > 0) {
		strDest = str_lastmsg;
	}
	return rc;
}

//	以下、削除予定	//////////////////////////////////////////////////////////////
/*!
 * @file		ftpcmd.cpp
 * @fn			int ftpcmd::up(ftpsocket& rSD, std::string& rCmd, void* pArgs)
 * @brief		ユーザー名/パスワード入力
 * @details		ユーザー名/パスワード入力
 * @return		0 <  VALUE:		エラーコード
 *				0 == VALUE:		TBD
 *				0 >  VALUE:		状態遷移コード
 * @param[in]	rSD				SOCKETディスクブリタ
 * @param[in]	rCmd			コマンド文字列
 * @param[in]	pArgs			未使用
 * @date		2022/3/4
 * @note		リプライコード判定はRF959に準拠
 */
#if 0
int ftpcmd::up(std::string& rCmd, void* pArgs)
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
	ret_socket = mpSocCtlr->sender(SOCCTRL::eMAIN, FTP_WAITTIME, rCmd.c_str(), rCmd.size());
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

	ret_socket = mpSocCtlr->receiver(SOCCTRL::eMAIN, FTP_WAITTIME, prcvbuf, SOCRECV_MAX_SIZE);
	if (ret_socket < 0) {
		goto EXIT_FUNCTION;								// メモリ解放
	}
	else {
		if (reply::range(ret_socket, 200) == true) {	// TBD: パスワードなしでログイン成功してよいか?
			ret_socket = ERESULT::eSUCCESS;				// RFC959: success
		}
		else if (reply::range(ret_socket, 100) == true) {
			ret_socket = ERESULT::eERROR;				// RFC959: error
		}
		else if (reply::range(ret_socket, 300) == true) {
			ret_socket = ERESULT::eCONTINUE;            // 次コマンド実行
		}
		else if (reply::range(ret_socket, 400, 500) == true) {
			ret_socket = ERESULT::eFAILURE;				// RFC959: failure
		}
		else {
			ret_socket = ERESULT::eFAILED;
		}
	}

EXIT_FUNCTION:
	if (prcvbuf) { delete[] prcvbuf; }

	return ret_socket;
}
#endif
/*!
 * @file		ftpcmd.cpp
 * @fn			int ftpcmd::cmd1(ftpsocket& rSD, std::string& rCmd, void* pArgs)
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
#if 0
int ftpcmd::cmd1(std::string& rCmd, std::string& rRsp, void* pArgs)
{
	int				ret_socket;
	char*			prcvbuf = (char*)0;

	/*
	 * コマンド送信
	 */
	ret_socket = mpSocCtlr->sender(SOCTRAN::eLISTEN/*暫定*/, FTP_WAITTIME, rCmd.c_str(), rCmd.size());
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

	ret_socket = mpSocCtlr->receiver(SOCTRAN::eLISTEN/*暫定*/, FTP_WAITTIME, prcvbuf, SOCRECV_MAX_SIZE);
	if (ret_socket < 0) {
		goto EXIT_FUNCTION;								// メモリ解放
	}
	else {
		if (reply::range(ret_socket, 200) == true) {	// 成功
			ret_socket = ERESULT::eSUCCESS;
		}
		else if (reply::range(ret_socket, 100) == true) {
            ret_socket = ERESULT::eERROR;               // RFC959: error
			printf("[DBG]reply: 1xx..");
// PORTコマンド後のコマンドのreplyは150..
		}
		else if (reply::range(ret_socket, 300) == true) {
            ret_socket = ERESULT::eERROR;               // RFC959: error
		}
		else if (reply::range(ret_socket, 400, 500) == true) {
			ret_socket = ERESULT::eFAILURE;				// RFC959: failure
		}
		else {											// 想定外は無視(FTPサーバーのバージョンアップが原因かも)
			ret_socket = ERESULT::eFAILED;
		}
	}
	rRsp = prcvbuf;

EXIT_FUNCTION:
	if (prcvbuf) { delete[] prcvbuf; }

	return ret_socket;
}
#endif
/*!
 * @file		ftpcmd.cpp
 * @fn			int ftpcmd::cmd(ftpsocket& rSD, std::string& rCmd, void* pArgs)
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
#if 0
int ftpcmd::cmd2(std::string& rCmd, std::string& rRsp, void* pArgs)
{
	int				ret_socket;
	char*			prcvbuf = (char*)0;

	/*
	 * コマンド送信
	 */
	ret_socket = mpSocCtlr->sender(SOCCTRL::eMAIN, FTP_WAITTIME, rCmd.c_str(), rCmd.size());
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

	ret_socket = mpSocCtlr->receiver(SOCCTRL::eMAIN, FTP_WAITTIME, prcvbuf, SOCRECV_MAX_SIZE);
	if (ret_socket < 0) {
		goto EXIT_FUNCTION;								// メモリ解放
	}
	else {
		if (reply::range(ret_socket, 200) == true) {	// 成功
			ret_socket = ERESULT::eSUCCESS;             // 自分自身(exit())へ遷移
		}
		else if (reply::range(ret_socket, 100) == true) {
			ret_socket = ERESULT::eCONTINUE;            // TBD: コマンド完了待ち??
		}
		else if (reply::range(ret_socket, 300) == true) {
			ret_socket = ERESULT::eERROR;				// RFC959: error
		}
		else if (reply::range(ret_socket, 400, 500) == true) {
			ret_socket = ERESULT::eFAILURE;				// RFC959: failure
		}
		else {											// 想定外は無視(FTPサーバーのバージョンアップが原因かも)
			ret_socket = ERESULT::eFAILED;
		}
	}
	rRsp = prcvbuf;

EXIT_FUNCTION:
	if (prcvbuf) { delete[] prcvbuf; }

	return ret_socket;
}
#endif
