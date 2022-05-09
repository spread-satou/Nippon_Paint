#include "pch.h"
#include "seqwaiting.h"

#include "winec.h"
#include "ecode.h"
#include "reply.h"
#include "ftpcmd.h"

seqwaiting::seqwaiting()
{
    this->initialize();
}

seqwaiting::seqwaiting(ftpsocket* pSOCKET)
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

seqwaiting::~seqwaiting()
{

}

/*!
 * @file		seqwaiting.cpp
 * @fn			int seqwaiting::initialize(void)
 * @brief		メンバ変数初期化
 * @details		デフォルト値設定
 * @return		0 <  Return value: TBD
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @param[in]	void
 * @date		2022/4/8
 * @note		initialize()は制御系の初期化
 */
int seqwaiting::initialize(void)
{
    this->variables();
    this->mmyState = ESTATE::eWAITING;
    return RET_SUCCESS;
}

/*!
 * @file        seqwaiting.cpp
 * @fn          int seqwaiting::variables(void)
 * @brief       パラメータ初期化
 * @details		無効値(INVALID)をセット
 * @return      0 <  VALUE: TBD
 *              0 == VALUE: 成功
 *              0 >  VALUE: TBD
 * @date        1970/3/9
 * @note		initialize()は制御系の初期化
 */
int seqwaiting::variables(void)
{
    //ftpseq::variables();                              // コンストラクタでcall済
    return RET_SUCCESS;
}

/*!
 * @file        seqwaiting.cpp
 * @fn          seqwaiting::enter(void* pArgs)
 * @brief       シーケンスまえ処理
 * @details     TBD
 * @return      0 <  VALUE: TBD
 *              0 == VALUE: TBD
 *              0 >  VALUE: 状態遷移コード
 * @date        1970/3/16
 * @note		initialize()は制御系の初期化
 */
int seqwaiting::enter(void* pArgs)
{
	int rc = (int)this->mmyState;
	return rc;
}

/*!
 * @file          seqwaiting.cpp
 * @fn            seqwaiting::exec(void* pArgs)
 * @brief         コマンド処理
 * @details       CDUPコマンド送信
 * @return        0 <  VALUE: 異常終了(再起動シーケンス??)
 *                0 >= VALUE: 状態遷移コード(0～n)
 * @date          1970/3/14
 * @note          ***
 */
int seqwaiting::exec(void* pArgs)
{
    ::Sleep((5 * 1000) * 60);							// 5分待ち
	return (int)this->mmyState;							// 自分自身のexit()へ
}

/*!
 * @file          seqwaiting.cpp
 * @fn            int seqwaiting::exec(void* pArgs)
 * @brief         シーケンスあと処理
 * @details       TBD
 * @return        0 <  VALUE: シーケンス中断(TBD)
 *                0 == VALUE: 状態遷移コード(TBD)
 *                0 >  VALUE: 状態遷移コード
 * @date          1970/3/9
 * @note          ***
 */
int seqwaiting::exit(void* pArgs)
{
	return ESTATE::eLOGIN;
}
