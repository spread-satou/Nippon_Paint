#include "pch.h"
#include "seqpasv.h"

#include "winec.h"
#include "ecode.h"
#include "reply.h"

#include <sstream>

seqpasv::seqpasv()
{
    this->initialize();
}

seqpasv::seqpasv(ftpsocket* ptranSOCKET, ftpsocket* pSOCKET)
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
	mpSOCKET[ESOCK::eTRAN] = ptranSOCKET;
}

seqpasv::~seqpasv()
{

}

/*!
 * @file		seqpasv.cpp
 * @fn			int seqpasv::variables(void)
 * @brief		メンバ変数初期化
 * @details		デフォルト値設定
 * @return		0 <  Return value: TBD
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @param[in]	void
 * @date		2022/3/16
 * @note		initialize()は制御系の初期化
 */
int seqpasv::initialize(void)
{
	this->variables();
    this->mmyState = ESTATE::ePASV;
	return RET_SUCCESS;
}

/*!
 * @file        seqpasv.cpp
 * @fn          int seqpasv::variables(void)
 * @brief		メンバ変数初期化
 * @details		無効値(INVALID)をセット
 * @return      0 <  VALUE: TBD
 *              0 == VALUE: 成功
 *              0 >  VALUE: TBD
 * @date        2022/3/9
 * @note		initialize()は制御系の初期化
 */
int seqpasv::variables(void)
{
    //ftpseq::variables();                              // コンストラクタでcall済

	memset(&msiIP[0], 0x00, sizeof(msiIP));
	memset(&msiPORT[0], 0x00, sizeof(msiPORT));
    return RET_SUCCESS;
}

/*!
 * @file            seqpasv.cpp
 * @fn              seqpasv::enter(void* pArgs)
 * @brief           シーケンスまえ処理
 * @details         TBD
 * @return          0 <  VALUE: TBD
 *                  0 == VALUE: TBD
 *                  0 >  VALUE: 状態遷移コード
 * @date            1970/3/9
 * @note            ***
 */
int seqpasv::enter(void* pArgs)
{
	int rc = (int)this->mmyState;

	ADDRINFOA	ai_tran;								// the getaddrinfo function(input引数) to hold host address information.
    ftpsocket::addrinfo(&ai_tran, SOCPORT_TRAN);
	mpSOCKET[ESOCK::eTRAN]->initialize(ai_tran, (void*)0);

	return rc;
}

/*!
 * @file          seqpasv.cpp
 * @fn            seqpasv::exec(void* pArgs)
 * @brief         コマンド処理
 * @details       PASVコマンド送信
 * @return        0 <  VALUE: 異常終了(再起動シーケンス??)
 *                0 >= VALUE: 状態遷移コード(0～n)
 * @date          1970/3/4
 * @note          ***
 */
int seqpasv::exec(void* pArgs)
{
	// ftpport::command_pasiv()へ移動
	return 0;
}

/*!
 * @file          seqpasv.cpp
 * @fn            int seqpasv::exec(void* pArgs)
 * @brief         シーケンスあと処理
 * @details       TBD
 * @return        0 <  VALUE: シーケンス中断(TBD)
 *                0 == VALUE: 状態遷移コード(TBD)
 *                0 >  VALUE: 状態遷移コード
 * @date          1070/3/9
 * @note          ***
 */
int seqpasv::exit(void* pArgs)
{
	return ESTATE::ePORT;
}
