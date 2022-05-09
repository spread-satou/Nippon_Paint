#include "pch.h"
#include "seqlist.h"
#include "ecode.h"
#include "reply.h"
#include "ftpcmd.h"

seqlist::seqlist()
{
    this->initialize();
}

seqlist::seqlist(ftpsocket* pSOCKET, const char* pPath)
{
    this->initialize();

    if (pSOCKET) {
        mpSOCKET[ESOCK::eCTRL] = pSOCKET;
    }

    if (pPath) {
        mPath = pPath;
    }
    else {
        mPath = "";
    }
}

seqlist::~seqlist()
{
    mPath.clear();
}

/*!
 * @file		seqlist.cpp
 * @fn			int seqlist::initialize(void)
 * @brief		メンバ変数初期化
 * @details		デフォルト値設定
 * @return		0 <  Return value: TBD
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @param[in]	void
 * @date		2022/4/8
 * @note		initialize()は制御系の初期化
 */
int seqlist::initialize(void)
{
    this->variables();

	this->mmyState = ESTATE::eLIST;
    if (mPath.empty() == false) {
        mPath.clear();
    }
    return RET_SUCCESS;
}

/*!
 * @file        seqlist.cpp
 * @fn          int seqlist::variables(void)
 * @brief		メンバ変数初期化
 * @details		無効値(INVALID)をセット
 * @return      0 <  VALUE: TBD
 *              0 == VALUE: 成功
 *              0 >  VALUE: TBD
 * @date        2022/3/16
 * @note		initialize()は制御系の初期化
 */
int seqlist::variables(void)
{
    //ftpseq::variables();                              // コンストラクタでcall済
    mPath.clear();
	return RET_SUCCESS;
}

/*!
 * @file            seqlist.cpp
 * @fn              seqlist::enter(void* pArgs)
 * @brief           シーケンスまえ処理
 * @details         TBD
 * @return          0 <  VALUE: TBD
 *                  0 == VALUE: TBD
 *                  0 >  VALUE: 状態遷移コード
 * @date            1970/3/3
 * @note            ***
 */
int seqlist::enter(void* pArgs)
{
	int rc = (int)this->mmyState;
	return rc;
}

/*!
 * @file          seqlist.cpp
 * @fn            seqlist::exec(void* pArgs)
 * @brief         コマンド処理
 * @details       LISTコマンド送信
 * @return        0 <  VALUE: 異常終了(再起動シーケンス??)
 *                0 >= VALUE: 状態遷移コード(0～n)
 * @date          1970/3/4
 * @note          ***
 */
int seqlist::exec(void* pArgs)
{
    int         rc;
    std::string str_cmd = "List " + mPath + "\x0d\x0a";
    std::string str_rsp;
	// new. delete
	ftpcmd*		pcmd = (ftpcmd*)0;

    //LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eLIST, ">>>\n");

    pcmd = new ftpcmd(mpSOCKET, str_cmd.c_str());
	if (pcmd == (ftpcmd*)0) {
		ecode	retobj(ecode::eVALUE::eNEW, __FUNCTION__, "0 = new ftpcmd(mpSOCKET, str_cmd.c_str())");
		retobj.output();
		rc = retobj.rc();								// 戻り値に変換
		goto EXIT_FUNCTION;
	}

	/*
	 *	LIST (LIST)
	 */
	rc = pcmd->group2(str_rsp, (void*)0);
    if (rc < 0) {
		goto EXIT_FUNCTION;
    }

EXIT_FUNCTION:
	if (pcmd) {delete pcmd;} 

    //LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eLIST, ">>>\n");
    if (rc < 0) {throw rc;}
    return (int)this->mmyState;
}

/*!
 * @file          seqlist.cpp
 * @fn            int seqlist::exec(void* pArgs)
 * @brief         シーケンスあと処理
 * @details       TBD
 * @return        0 <  VALUE: シーケンス中断(TBD)
 *                0 == VALUE: 状態遷移コード(TBD)
 *                0 >  VALUE: 状態遷移コード
 * @date          1970/3/4
 * @note          ***
 */
int seqlist::exit(void* pArgs)
{
	return ESTATE::eWAITING;                             // TBD
}
