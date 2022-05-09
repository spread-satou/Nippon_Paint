#include "pch.h"
#include "seqcdup.h"
#include "ftplog.h"

#include "winec.h"
#include "ecode.h"
#include "reply.h"
#include "ftpcmd.h"

seqcdup::seqcdup()
{
    this->initialize();
}

seqcdup::seqcdup(ftpsocket* pSOCKET)
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
	this->mpSOCKET[ESOCK::eCTRL] = pSOCKET;
}

seqcdup::~seqcdup()
{

}

/*!
 * @file		seqnlst.cpp
 * @fn			int seqcdup::initialize(void)
 * @brief		メンバ変数初期化
 * @details		デフォルト値設定
 * @return		0 <  Return value: TBD
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @param[in]	void
 * @date		2022/4/8
 * @note		initialize()は制御系の初期化
 */
int seqcdup::initialize(void)
{
    this->variables();

    this->mmyState = ESTATE::eCDUP;
    return RET_SUCCESS;
}

/*!
 * @file        seqcdup.cpp
 * @fn          int seqcdup::variables(void)
 * @brief		メンバ変数初期化
 * @details		無効値(INVALID)をセット
 * @return      0 <  VALUE: TBD
 *              0 == VALUE: 成功
 *              0 >  VALUE: TBD
 * @date        2022/3/9
 * @note		initialize()は制御系の初期化
 */
int seqcdup::variables(void)
{
    //ftpseq::variables();                              // コンストラクタでcall済
    return RET_SUCCESS;
}

/*!
 * @file            seqcdup.cpp
 * @fn              seqcdup::enter(void* pArgs)
 * @brief           シーケンスまえ処理
 * @details         TBD
 * @return          0 <  VALUE: TBD
 *                  0 == VALUE: TBD
 *                  0 >  VALUE: 状態遷移コード
 * @date            1970/3/9
 * @note            ***
 */
int seqcdup::enter(void* pArgs)
{
	int rc = (int)this->mmyState;
	return rc;
}

/*!
 * @file          seqcdup.cpp
 * @fn            seqcdup::exec(void* pArgs)
 * @brief         コマンド処理
 * @details       CDUPコマンド送信
 * @return        0 <  VALUE: 異常終了(再起動シーケンス??)
 *                0 >= VALUE: 状態遷移コード(0～n)
 * @date          1970/3/4
 * @note          ***
 */
int seqcdup::exec(void* pArgs)
{
	int			rc;
	std::string str_rsp;
	// new. delete
	ftpcmd*		pcmd = (ftpcmd*)0;

    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eCDUP, ">>>\n");

	// まえ処理
	pcmd = new ftpcmd(this->mpSOCKET, "CDUP\x0d\x0a");
	if (pcmd == (ftpcmd*)0) {
		ecode	retobj(ecode::eVALUE::eNEW, __FUNCTION__, "0 = new ftpcmd(mpSOCKET, CDUP)");
		retobj.output();
		rc = retobj.rc();								// 戻り値に変換
		goto EXIT_FUNCTION;
	}

	/*
	 *	CHANGE TO PARENT DIRECTORY (CDUP)
	 */
	rc = pcmd->group1(str_rsp, (void*)0);
	if (rc < 0) {
		goto EXIT_FUNCTION;
	}

	// reply 150が返ってきて、RESTARTとなる
	//rc = this->cmd1(*ps, str_cmd, str_rsp, (void*)0);
	rc = pcmd->group1(str_rsp, (void*)0);
	if (rc < 0) {
		goto EXIT_FUNCTION;
	}

EXIT_FUNCTION:
	if (pcmd) {delete pcmd;} 

    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eCDUP, "<<< %d\n", rc);
	if (rc < 0) {throw rc;}
	return (int)this->mmyState;
}

/*!
 * @file          seqcdup.cpp
 * @fn            int seqcdup::exec(void* pArgs)
 * @brief         シーケンスあと処理
 * @details       TBD
 * @return        0 <  VALUE: シーケンス中断(TBD)
 *                0 == VALUE: 状態遷移コード(TBD)
 *                0 >  VALUE: 状態遷移コード
 * @date          1070/3/9
 * @note          ***
 */
int seqcdup::exit(void* pArgs)
{
	return ESTATE::ePORT;
}
