#include "pch.h"
#include "seqrestart.h"
#include "ftplog.h"
#include "winec.h"
#include "ecode.h"
#include "reply.h"
#include "ftpcmd.h"

seqrestart::seqrestart()
{
    this->initialize();
}

seqrestart::seqrestart(ftpsocket* pSOCKET)
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
}

seqrestart::~seqrestart()
{
    mstrIPv4.clear();
    mstrPORT.clear();
}

/*!
 * @file		seqrestart.cpp
 * @fn			int seqrestart::initialize(void)
 * @brief		メンバ変数初期化
 * @details		デフォルト値設定
 * @return		0 <  Return value: TBD
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @param[in]	void
 * @date		2022/4/8
 * @note		initialize()は制御系の初期化
 */
int seqrestart::initialize(void)
{
    this->variables();
    this->mmyState = ESTATE::eRESTART;
    return RET_SUCCESS;
}

/*!
 * @file        seqrestart.cpp
 * @fn          int seqrestart::variables(void)
 * @brief       パラメータ初期化
 * @details     パラメータ初期化
 * @return      0 <  VALUE: TBD
 *              0 == VALUE: 成功
 *              0 >  VALUE: TBD
 * @date        2022/3/9
 * @note		initialize()は制御系の初期化
 */
int seqrestart::variables(void)
{
    //ftpseq::variables();                              // コンストラクタでcall済

    mstrIPv4.clear();
    mstrPORT.clear();
    return RET_SUCCESS;
}

/*!
 * @file        seqrestart.cpp
 * @fn          int seqrestart::setai(const char* pIPv4, const char* pPORT))
 * @brief       サーバーアドレス情報設定
 * @details     サーバーアドレス情報設定
 * @return      void
 * 
 * @date        2022/3/9
 * @note		initialize()は制御系の初期化
 */
void seqrestart::setai(const char* pIPv4, const char* pPORT)
{
    mstrIPv4 = pIPv4;
    mstrPORT = pPORT;
}

/*!
 * @file        seqrestart.cpp
 * @fn          seqrestart::enter(void* pArgs)
 * @brief       シーケンスまえ処理
 * @details     TBD
 * @return      0 <  VALUE: TBD
 *              0 == VALUE: TBD
 *              0 >  VALUE: 状態遷移コード
 * @date        2022/3/15
 * @note		initialize()は制御系の初期化
 */
int seqrestart::enter(void* pArgs)
{
	int rc = (int)this->mmyState;
	return rc;
}

/*!
 * @file          seqrestart.cpp
 * @fn            seqrestart::exec(void* pArgs)
 * @brief         切断 → 再接続
 * @details       切断 → 再接続
 * @return        0 <  VALUE: 異常終了(再起動シーケンス)
 *                0 >= VALUE: 状態遷移コード(0～n)
 * @date          2022/3/14
 * @note          ***
 */
int seqrestart::exec(void* pArgs)
{
    //unsigned char*  psrv_ai[2] = {(unsigned char*)"192.168.11.47", (unsigned char*)"21"/*制御*/};    //koko
    int         rc;
	ADDRINFOA	ai_ctrl;
    const char* psrv_ai[2] = {(const char*)0, (const char*)0};

    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eRSTA, ">>>\n");

    ftpsocket::addrinfo(&ai_ctrl, SOCPORT_CTRL);
    psrv_ai[0] = mstrIPv4.c_str();
    psrv_ai[1] = mstrPORT.c_str();

    mpSOCKET[ESOCK::eCTRL]->disconnect(SOCCTRL::eMAIN);
    mpSOCKET[ESOCK::eCTRL]->release(SOCCTRL::eMAIN);
    mpSOCKET[ESOCK::eCTRL]->initialize(ai_ctrl, &psrv_ai[0]/*IPv4とPORT*/);
    rc = mpSOCKET[ESOCK::eCTRL]->connect(SOCCTRL::eMAIN);

    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eRSTA, "<<< %d\n", rc);
    if (rc < 0) {throw rc;}
	return (int)this->mmyState;                         // 最後のメソッドの実行結果を返す
}

/*!
 * @file          seqrestart.cpp
 * @fn            int seqrestart::exec(void* pArgs)
 * @brief         シーケンスあと処理
 * @details       TBD
 * @return        0 <  VALUE: シーケンス中断(TBD)
 *                0 == VALUE: 状態遷移コード(TBD)
 *                0 >  VALUE: 状態遷移コード
 * @date          2022/3/14
 * @note          ***
 */
int seqrestart::exit(void* pArgs)
{
	return ESTATE::eLOGIN;
}
