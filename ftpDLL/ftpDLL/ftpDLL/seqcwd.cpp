#include "pch.h"
#include "seqcwd.h"
#include "ftplog.h"

#include "winec.h"
#include "ecode.h"
#include "reply.h"
#include "ftpcmd.h"

seqcwd::seqcwd()
{
    this->initialize();
}

seqcwd::seqcwd(ftpsocket* pSOCKET, const char* pRoot, const char* pSubdir)
{
	int		rc = RET_SUCCESS;
	ecode*	pec= (ecode*)0;

    if (pSOCKET == (ftpsocket*)0) {
		pec = new ecode(ecode::eVALUE::eARG_NULL, __FUNCTION__, "pSOCKET == 0");
		pec->output();
		rc = pec->rc();						            // 戻り値に変換
        delete pec;
        throw rc;                                       // コンストラクタは戻り値がないので。
    }

    this->initialize();

	mpSOCKET[ESOCK::eCTRL] = pSOCKET;
    if (pRoot) {
        mstrRoot = pRoot;
    }
    if (pSubdir) {
        mstrSubd = pSubdir;
    }
}

seqcwd::~seqcwd()
{
    mstrRoot.clear();
    mstrSubd.clear();
}

/*!
 * @file		seqcwd.cpp
 * @fn			int seqcwd::initialize(void)
 * @brief		メンバ変数初期化
 * @details		デフォルト値設定
 * @return		0 <  Return value: TBD
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @param[in]	void
 * @date		2022/4/8
 * @note		initialize()は制御系の初期化
 */
int seqcwd::initialize(void)
{
    this->variables();

    this->mmyState = ESTATE::eCWD;
    return RET_SUCCESS;
}

/*!
 * @file        seqcwd.cpp
 * @fn          int seqcwd::variables(void)
 * @brief		メンバ変数初期化
 * @details		無効値(INVALID)をセット
 * @return      0 <  VALUE: TBD
 *              0 == VALUE: 成功
 *              0 >  VALUE: TBD
 * @date        2022/3/16
 * @note		initialize()は制御系の初期化
 */
int seqcwd::variables(void)
{
    //ftpseq::variables();                              // コンストラクタでcall済
    //this->mmyState = ESTATE::eCWD;

    mstrRoot.clear();
    mstrSubd.clear();
    return RET_SUCCESS;
}

/*!
 * @file            seqcwd.cpp
 * @fn              seqcwd::enter(void* pArgs)
 * @brief           シーケンスまえ処理
 * @details         TBD
 * @return          0 <  VALUE: TBD
 *                  0 == VALUE: TBD
 *                  0 >  VALUE: 状態遷移コード
 * @date            2022/3/9
 * @note            ***
 */
int seqcwd::enter(void* pArgs)
{
	int rc = (int)this->mmyState;
	return rc;
}

/*!
 * @file          seqcwd.cpp
 * @fn            seqcwd::exec(void* pArgs)
 * @brief         コマンド処理
 * @details       TYPEコマンド送信
 * @return        0 <  VALUE: 異常終了(再起動シーケンス)
 *                0 >= VALUE: 状態遷移コード(0～n)
 * @date          1970/3/4
 * @note          TBD: RFC959 failure時のリトライ処理
 */
int seqcwd::exec(void* pArgs)
{
    int			rc = RET_SUCCESS;;
	std::string str_cmd;
	std::string str_rsp;
	std::string str_path;
	// new. delete
	ecode*		pec = (ecode*)0;
	ftpcmd*		pcwd  = (ftpcmd*)0;

    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eCWD_, ">>>\n");

    // まえ処理
    if (mstrSubd.empty() == true) {
		pec = new ecode(ecode::eVALUE::ePARAM_STRING, __FUNCTION__, "mstrSubd.empty() == true");
		pec->output();
		goto EXIT_FUNCTION;
    }

    if (mstrRoot.size() > 0) {
        str_path = mstrRoot;
    }
    else {
        str_path = "";
    }

    str_path += mstrSubd;                               // サブディレクトリ
    str_cmd = "CWD " + str_path + "\x0d\x0a";

    // まえ処理
    pcwd = new ftpcmd(mpSOCKET, str_cmd.c_str());
	if (pcwd == (ftpcmd*)0) {
		ecode	retobj(ecode::eVALUE::eNEW, __FUNCTION__, "0 = new ftpcmd(mpSOCKET, str_cmd.c_str())");
		retobj.output();
		rc = retobj.rc();								// 戻り値に変換
		goto EXIT_FUNCTION;
	}

	/*
	 *	CHANGE WORKING DIRECTORY (CWD)
	 */
	rc = pcwd->group1(str_rsp, (void*)0);
	if (rc < 0) {
		goto EXIT_FUNCTION;
	}

EXIT_FUNCTION:
    if (pec) {delete pec;}
	if (pcwd) {delete pcwd;} 

    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eCWD_, "<<< %d\n", rc);
    if (rc < 0) {throw rc;}
	return (int)this->mmyState;
}

/*!
 * @file          seqcwd.cpp
 * @fn            int seqcwd::exec(void* pArgs)
 * @brief         シーケンスあと処理
 * @details       TBD
 * @return        0 <  VALUE: シーケンス中断(TBD)
 *                0 == VALUE: 状態遷移コード(TBD)
 *                0 >  VALUE: 状態遷移コード
 * @date          2022/3/15
 * @note          ***
 */
int seqcwd::exit(void* pArgs)
{
    return ESTATE::ePORT;
}
