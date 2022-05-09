#include "pch.h"
#include <string>
#include <sstream>

#include "seqlogin.h"
#include "ftplog.h"
#include "ecode.h"
#include "reply.h"
#include "ftpcmd.h"

/*
	USERコマンド
		SUCCESS: PASS
		FAILED:  Waiting
	PASSコマンド
		SUCCESS: ACCT
		FAILED:  Waiting
	ACCTコマンド
		SUCCESS: Waiting→LIST
		FAILED:  Waiting

*/
seqlogin::seqlogin()
{
	this->initialize();
}

seqlogin::seqlogin(ftpsocket* pSOCKET, const char* pUSER, const char* pPASS, const char* pACCT)
{
	this->initialize();
	this->setter(pSOCKET, pUSER, pPASS, pACCT);
}

seqlogin::~seqlogin()
{
	this->mUsername.clear();
	this->mPassword.clear();
	this->mAccount.clear();
}

/*!
 * @file		seqlogin.cpp
 * @fn			int seqlogin::initialize(void)
 * @brief		メンバ変数初期化
 * @details		デフォルト値設定
 * @return		0 <  Return value: TBD
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @param[in]	void
 * @date		2022/4/8
 * @note		initialize()は制御系の初期化
 */
int seqlogin::initialize(void)
{
	this->variables();
	this->mmyState  = ESTATE::eLOGIN;

	return RET_SUCCESS;
}

/*!
 * @file        seqlogin.cpp
 * @fn          int seqlogin::initialize(void)
 * @brief		メンバ変数初期化
 * @details		無効値(INVALID)をセット
 * @return      0 <  VALUE: TBD
 *              0 == VALUE: 成功
 *              0 >  VALUE: TBD
 * @date        2022/3/3
 * @note		initialize()は制御系の初期化
 */
int seqlogin::variables(void)
{
    //ftpseq::variables();                              // コンストラクタでcall済

	this->mUsername.clear();
	this->mPassword.clear();
	this->mAccount.clear();
	return RET_SUCCESS;
}

/*!
 * @file          seqlogin.cpp
 * @fn            seqlogin::setter(const char* pUSER, const char* pPASS, const char* pACCT)
 * @brief         パラメータ設定
 * @details       ユーザー名, パスワード, アカウントを保持する
 * @return        0 <  VALUE: エラーコード
 *                0 == VALUE: 成功
 *                0 >  VALUE: TBD
 * @date          2022/3/3
 * @note          ***
 */
int seqlogin::setter(ftpsocket* pSOCKET, const char* pUSER, const char* pPASS, const char* pACCT)
{
	int		rc = RET_SUCCESS;
	// new. delete
	ecode*	pec  = (ecode*)0;

	if (pSOCKET == (ftpsocket*)0) {
		pec = new ecode(ecode::eVALUE::eARG_NULL, __FUNCTION__, "pSOCKET == 0");
		goto EXIT_FUNCTION;
	}

	if (pUSER == (const char*)0) {
		pec = new ecode(ecode::eVALUE::eARG_NULL, __FUNCTION__, "pUSER == 0");
		goto EXIT_FUNCTION;
	}

	if (pPASS == (const char*)0) {
		pec = new ecode(ecode::eVALUE::eARG_NULL, __FUNCTION__, "pPASS == 0");
		goto EXIT_FUNCTION;
	}

	//if (pACCT == (char*)0) {
	//	pec = new ecode(ecode::eVALUE::eARG_NULL, __FUNCTION__, "pACCT == 0");
	//	pec->output();
	//	goto EXIT_FUNCTION;
	//}

	mpSOCKET[ESOCK::eCTRL] = pSOCKET;

	// すべてそろっているので、保持
	// 1つでも不足していれば、ログインできない
	mUsername	= pUSER;
	mPassword	= pPASS;
	if (pACCT) {
		mAccount = pACCT;
	}

EXIT_FUNCTION:
	if (pec != (ecode*)0) {								// エラーあり
		pec->output();
		rc = pec->rc();									// 戻り値に変換
		delete pec;
		throw rc;
	}
	return (int)this->mmyState;							// 自分自身のexit()へ
}

/*!
 * @file            seqlogin.cpp
 * @fn              seqlogin::enter(void* pArgs)
 * @brief           ログインシーケンスまえ処理
 * @details         TBD
 * @return          0 <  VALUE: TBD
 *                  0 == VALUE: TBD
 *                  0 >  VALUE: 状態遷移コード
 * @date            2022/3/3
 * @note            ***
 */
int seqlogin::enter(void* pArgs)
{
	int rc = (int)this->mmyState;
	return rc;
}

/*!
 * @file          seqlogin.cpp
 * @fn            seqlogin::exec(void* pArgs)
 * @brief         ログインシーケンス
 * @details       USER→PASS→ACCT
 * @return        0 <  VALUE: ログイン異常終了(再起動シーケンス)
 *                0 >= VALUE: 状態遷移コード(0～n)
 * @date          2022/3/4
 * @note          TBD: RFC959 failure時のリトライ処理
 */
int seqlogin::exec(void* pArgs)
{
	int rc;
	std::string		str_rsp;
	std::string		str_u = "USER " + mUsername + "\x0d\x0a";
	std::string		str_p = "PASS " + mPassword + "\x0d\x0a";
	std::string		str_a = "";
	// new. delete
	ftpcmd*			puser = (ftpcmd*)0;
	ftpcmd*			ppass = (ftpcmd*)0;
	ftpcmd*			pacct = (ftpcmd*)0;

	LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eUSER, ">>>\n");

    puser = new ftpcmd(mpSOCKET, str_u.c_str());
	if (puser == (ftpcmd*)0) {
		ecode	retobj(ecode::eVALUE::eNEW, __FUNCTION__, "0 = new ftpcmd(mpSOCKET, str_u.c_str())");
		retobj.output();
		rc = retobj.rc();								// 戻り値に変換
		throw  rc;										// newしてないので、ここで
	}

	ppass = new ftpcmd(mpSOCKET, str_p.c_str());
	if (ppass == (ftpcmd*)0) {
		ecode	retobj(ecode::eVALUE::eNEW, __FUNCTION__, "0 = new ftpcmd(mpSOCKET, str_p.c_str())");
		retobj.output();
		rc = retobj.rc();								// 戻り値に変換
		throw  rc;										// newしてないので、ここで
	}

	/*
	 * ユーザー名入力 & パスワード	ログインミス時、reply 5xxが返ってくる
	 */
    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eUSER, "USER\n");
	rc = puser->groupup((void*)0);						// ユーザー入力
	if  (rc < 0) {										// エラー発生
		goto EXIT_FUNCTION;
	}
	else if (rc == ERESULT::eCONTINUE) {
	    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::ePASS, "PASS\n");
		rc = ppass->groupup(pArgs);						// パスワード入力
	}
	else {												// ERESULT::eSUCCESS
		;												// 処理完了
	}

	/*
	 * アカウント入力
	 *	https://www.ibm.com/docs/ja/i/7.2?topic=ssw_ibm_i_72/rzaiq/rzaiqacct.htm
	 *	アカウント情報は、 ホスト・システムが特権を認可するために使用するパスワードの形を取ることが あります。
	 *	このパスワードは、ユーザーのユーザー・パスワードではなく、 リモート・システム上のパスワードです。
	 */
	if  (rc < 0) {										// パスワード結果判定
		goto EXIT_FUNCTION;
	}
	else if (rc == ERESULT::eCONTINUE) {
		if (this->mAccount.empty() == false) {
			str_a = "ACCT" + mAccount + "\x0d\x0a";
			pacct = new ftpcmd(mpSOCKET, str_a.c_str());

			if (pacct == (ftpcmd*)0) {
				ecode	retobj(ecode::eVALUE::eNEW, __FUNCTION__, "0 = new ftpcmd(mpSOCKET, str_a.c_str())");
				retobj.output();
				rc = retobj.rc();						// 戻り値に変換
				goto EXIT_FUNCTION;
			}

			rc = pacct->group1(str_rsp, (void*)0);
			if (rc < 0) {								// エラー発生
				goto EXIT_FUNCTION;
			}
		}
		else {
			rc = ERESULT::eSUCCESS;						// ACCT不要だったので、完了
		}
	}
	else {												// ERESULT::eSUCCESS
		;												// 処理完了
	}

EXIT_FUNCTION:
	if (puser) {delete puser;}
	if (ppass) {delete ppass;}
	if (pacct) {delete pacct;}

	if (rc < 0) {
		if (rc == ERESULT::eFAILURE) {					// ログイン失敗
			return ESTATE::eWAITING;
		}
		else {
			throw rc;
		}
	}

	LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eUSER, "<<< %d\n", rc);
	return (int)this->mmyState;							// 自分自身のexit()へ
}

/*!
 * @file          seqlogin.cpp
 * @fn            int seqlogin::exit(void* pArgs)
 * @brief         ログインシーケンスあと処理
 * @details       TBD
 * @return        0 <  VALUE: シーケンス中断(TBD)
 *                0 == VALUE: 状態遷移コード(TBD)
 *                0 >  VALUE: 状態遷移コード
 * @date          2022/3/4
 * @note          ***
 */
int seqlogin::exit(void* pArgs)
{
	return ESTATE::eTYPE;
}

/*!
 * @file		seqlogin.cpp
 * @fn			int seqlogin::acct(ftpsocket_ctrl& rSD, void* pArgs)
 * @brief		アカウント入力
 * @details		アカウント入力
 * @return		0 <  VALUE:		エラーコード
 *				0 == VALUE:		TBD
 *				0 >  VALUE:		状態遷移コード
 * @param[in]	rSD				SOCKETディスクブリタ
 * @param[in]	rCommand		コマンド文字列
 * @param[in]	pArgs			未使用
 * @date		1970/1/1
 * @note		リプライコード判定はRF959に準拠
 */
int seqlogin::acct(ftpsocket& rSD, void* pArgs)
{
	int				ret_socket;
	int				ret_local;
	std::string		str = "ACCT " + mAccount + "\n";

	/*
	 * コマンド送信
	 */
	ret_socket = rSD.sender(SOCCTRL::eMAIN, FTP_WAITTIME, str.c_str(), str.size());
	if (ret_socket < 0) {
		return ret_socket;								// エラーコード返却
	}

	/*
	 *	リプライ確認
	 */
	ecode*			pec = (ecode*)0;
	int				bufsize = SOCRECV_MAX_SIZE;
	char*			prcvbuf = (char*)0;

	ret_local = this->newBuffer(&prcvbuf, SOCRECV_MAX_SIZE);
	if (ret_local < 0) {								// メモリ確保失敗
		goto EXIT_FUNCTION;
	}

	ret_socket = rSD.receiver(SOCCTRL::eMAIN, FTP_WAITTIME, prcvbuf, bufsize);
	if (ret_socket < 0) {
		return ret_socket;								// エラーコード返却
	}
	else {
		if (reply::range(ret_socket, 200) == true) {	// TBD: アカウントなしでログイン成功してよいか?
			ret_socket = ESTATE::eWAITING;				// RFC959: success
		}
		else if (reply::range(ret_socket, 100) == true) {
			ret_socket = ESTATE::eRESTART;				// RFC959: error 再起動シーケンス
		}
		else if (reply::range(ret_socket, 300) == true) {
			ret_socket = ESTATE::eRESTART;				// RFC959: error 再起動シーケンス
		}
		else if (reply::range(ret_socket, 400, 500) == true) {
			ret_socket = ESTATE::eWAITING;				// RFC959: failure
		}
	}

EXIT_FUNCTION:
	if (prcvbuf) { delete[] prcvbuf; }

	return ret_socket;
}

