#include "pch.h"
#include "seqpwd.h"
#include "ftplog.h"
#include "winec.h"
#include "ecode.h"
#include "reply.h"
#include "ftpcmd.h"

seqpwd::seqpwd()
{
    this->initialize();
}

seqpwd::seqpwd(ftpsocket* pSOCKET)
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

seqpwd::~seqpwd()
{

}

/*!
 * @file		seqpwd.cpp
 * @fn			int seqpwd::initialize(void)
 * @brief		メンバ変数初期化
 * @details		デフォルト値設定
 * @return		0 <  Return value: TBD
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @param[in]	void
 * @date		2022/4/8
 * @note		initialize()は制御系の初期化
 */
int seqpwd::initialize(void)
{
    this->variables();
    this->mmyState = ESTATE::ePWD;
    return RET_SUCCESS;
}

/*!
 * @file        seqpwd.cpp
 * @fn          int seqpwd::variables(void)
 * @brief       パラメータ初期化
 * @details     パラメータ初期化
 * @return      0 <  VALUE: TBD
 *              0 == VALUE: 成功
 *              0 >  VALUE: TBD
 * @date        2022/3/9
 * @note		initialize()は制御系の初期化
 */
int seqpwd::variables(void)
{
    //ftpseq::variables();                              // コンストラクタでcall済
    return RET_SUCCESS;
}

/*!
 * @file        seqpwd.cpp
 * @fn          seqpwd::enter(void* pArgs)
 * @brief       シーケンスまえ処理
 * @details     TBD
 * @return      0 <  VALUE: TBD
 *              0 == VALUE: TBD
 *              0 >  VALUE: 状態遷移コード
 * @date        2022/3/16
 * @note		initialize()は制御系の初期化
 */
int seqpwd::enter(void* pArgs)
{
	int rc = (int)this->mmyState;
	return rc;
}

/*!
 * @file          seqpwd.cpp
 * @fn            seqpwd::exec(void* pArgs)
 * @brief         コマンド処理
 * @details       CDUPコマンド送信
 * @return        0 <  VALUE: 異常終了(再起動シーケンス??)
 *                0 >= VALUE: 状態遷移コード(0～n)
 * @date          2022/3/14
 * @note          ***
 */
int seqpwd::exec(void* pArgs)
{
	int			rc;
	std::string str_rsp;
	// new. delete
	ftpcmd*		pcmd = (ftpcmd*)0;

    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::ePWD_, ">>>\n");
    pcmd = new ftpcmd(mpSOCKET, "PWD\x0d\x0a");
	if (pcmd == (ftpcmd*)0) {
		ecode	retobj(ecode::eVALUE::eNEW, __FUNCTION__, "0 = new ftpcmd(mpSOCKET, PWD)");
		retobj.output();
		rc = retobj.rc();								// 戻り値に変換
		goto EXIT_FUNCTION;
	}

	rc = pcmd->group1(str_rsp, (void*)0);
	if (rc < 0) {
		goto EXIT_FUNCTION;
	}

EXIT_FUNCTION:
	if (pcmd) {delete pcmd;} 

    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::ePWD_, "<<< %d\n", rc);
    if (rc < 0) {throw rc;}
	return (int)this->mmyState;							// 自分自身のexit()へ
}

/*!
 * @file          seqpwd.cpp
 * @fn            int seqpwd::exec(void* pArgs)
 * @brief         シーケンスあと処理
 * @details       TBD
 * @return        0 <  VALUE: シーケンス中断(TBD)
 *                0 == VALUE: 状態遷移コード(TBD)
 *                0 >  VALUE: 状態遷移コード
 * @date          1070/3/9
 * @note          ***
 */
int seqpwd::exit(void* pArgs)
{
	return ESTATE::ePWD;
}
