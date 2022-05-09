#include "pch.h"
#include "seqlogout.h"
#include "ftplog.h"

#include "winec.h"
#include "ecode.h"
#include "reply.h"
#include "ftpcmd.h"

seqlogout::seqlogout()
{
	this->initialize();
}

seqlogout::seqlogout(ftpsocket* pSOCKET)
{
	int		rc = RET_SUCCESS;
	// new. delete
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
}

seqlogout::~seqlogout()
{

}

/*!
 * @file		seqlogout.cpp
 * @fn			int seqlogout::initialize(void)
 * @brief		メンバ変数初期化
 * @details		デフォルト値設定
 * @return		0 <  Return value: TBD
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @param[in]	void
 * @date		2022/4/8
 * @note		initialize()は制御系の初期化
 */
int seqlogout::initialize(void)
{
	this->variables();
    this->mmyState = ESTATE::eLOGOUT;
	return RET_SUCCESS;
}

/*!
 * @file        seqlogout.cpp
 * @fn          int seqlogout::variables(void)
 * @brief		メンバ変数初期化
 * @details		無効値(INVALID)をセット
 * @return      0 <  VALUE: TBD
 *              0 == VALUE: 成功
 *              0 >  VALUE: TBD
 * @date        2022/3/16
 * @note		initialize()は制御系の初期化
 */
int seqlogout::variables(void)
{
    //ftpseq::variables();                              // コンストラクタでcall済
    return RET_SUCCESS;
}

/*!
 * @file        seqlogout.cpp
 * @fn          seqlogout::enter(void* pArgs)
 * @brief       シーケンスまえ処理
 * @details     TBD
 * @return      0 <  VALUE: TBD
 *              0 == VALUE: TBD
 *              0 >  VALUE: 状態遷移コード
 * @date        2022/3/9
 * @note		initialize()は制御系の初期化
 */
int seqlogout::enter(void* pArgs)
{
	int rc = (int)this->mmyState;
	return rc;
}

/*!
 * @file          seqlogout.cpp
 * @fn            seqlogout::exec(void* pArgs)
 * @brief         コマンド処理
 * @details       TYPEコマンド送信
 * @return        0 <  VALUE: 異常終了(再起動シーケンス)
 *                0 >= VALUE: 状態遷移コード(0～n)
 * @date          2022/3/15
 * @note          TBD: RFC959 failure時のリトライ処理
 */
int seqlogout::exec(void* pArgs)
{
	int			rc;
	std::string str_rsp;
	// new. delete
	ftpcmd*		pcmd = (ftpcmd*)0;

    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eQUIT, ">>>\n");

    pcmd = new ftpcmd(mpSOCKET, "QUIT\x0d\x0a");
	if (pcmd == (ftpcmd*)0) {
		ecode	retobj(ecode::eVALUE::eNEW, __FUNCTION__, "0 = new ftpcmd(mpSOCKET, QUIT)");
		retobj.output();
		rc = retobj.rc();								// 戻り値に変換
		goto EXIT_FUNCTION;								// メモリ解放
	}

	/*
	 *	LOGOUT (QUIT)
	 */
	rc = pcmd->group1(str_rsp, (void*)0);
	if (rc < 0) {
		goto EXIT_FUNCTION;								// メモリ解放
	}

EXIT_FUNCTION:
	if (pcmd) {delete pcmd;} 

    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eQUIT, "<<< %d\n", rc);
    //if (rc < 0) {throw rc;}                           // QUIT失敗後、例外処理で再度、QUITすると無限ループとなってしまう
    return (int)this->mmyState;							// 自分自身のexit()へ
}

/*!
 * @file          seqlogout.cpp
 * @fn            int seqlogout::exec(void* pArgs)
 * @brief         シーケンスあと処理
 * @details       TBD
 * @return        0 <  VALUE: シーケンス中断(TBD)
 *                0 == VALUE: 状態遷移コード(TBD)
 *                0 >  VALUE: 状態遷移コード
 * @date          2022/3/9
 * @note          ***
 */
int seqlogout::exit(void* pArgs)
{
	return ESTATE::eRESTART;
}
