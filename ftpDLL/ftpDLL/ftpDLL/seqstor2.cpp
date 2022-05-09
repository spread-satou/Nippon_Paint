#include "pch.h"
#include "seqstor2.h"
#include "ftplog.h"
//#include "def_dbg.h"
#include "thr_launcher.h"
#include "thr_semaphore.h"
#include "winec.h"
#include "ecode.h"
#include "reply.h"
#include "params.h"
#include "ftpcmd.h"

#include <sstream>
#include <iostream>

extern params   sharedObj;

//! 外部宣言
extern HANDLE create_thr(int siNAME, void* pArgs);
extern int wait_hthr_release(HANDLE hThread);
extern int sem_init(int siSEMID, LONG lInitialCount, LONG lMaximumCount);
extern int sem_post(int siSEMID);
extern int sem_wait(int siSEMID, DWORD dwMaxms, DWORD dwMilliseconds);

seqstor2::seqstor2()
{
    this->initialize();
}

seqstor2::seqstor2(ftpsocket* ptranSOCKET, ftpsocket* pSOCKET)
{
	int                 rc = RET_SUCCESS;
	// new. delete
	ecode*              pec= (ecode*)0;

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

seqstor2::~seqstor2()
{
    mstrPathname.clear();
}

/*!
 * @file		seqstor2.cpp
 * @fn			int seqstor2::initialize(void)
 * @brief		メンバ変数初期化
 * @details		デフォルト値設定
 * @return		0 <  Return value: TBD
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @param[in]	void
 * @date		2022/4/8
 * @note		initialize()は制御系の初期化
 */
int seqstor2::initialize(void)
{
    this->variables();
    this->mmyState = ESTATE::eUPLNTY;                   // RCV/NOTIFY
    return RET_SUCCESS;
}

/*!
 * @file		seqstor2.cpp
 * @fn			int seqstor2::variables(void)
 * @brief		メンバ変数を初期化する
 * @details		無効値(INVALID)をセット
 * @return		0 <  Return value: TBD
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @param[in]	void
 * @date		2022/3/16
 * @note		initialize()は制御系の初期化
 */
int seqstor2::variables(void)
{
    //ftpseq::variables();                              // コンストラクタでcall済
    mstrPathname.clear();
    return RET_SUCCESS;
}

/*!
 * @file        seqstor2.cpp
 * @fn          seqstor2::enter(void* pArgs)
 * @brief       シーケンスまえ処理
 * @details     TBD
 * @return      0 <  VALUE: TBD
 *              0 == VALUE: TBD
 *              0 >  VALUE: 状態遷移コード
 * @date        2022/3/16
 * @note		initialize()は制御系の初期化
 */
int seqstor2::enter(void* pArgs)
{
	int                 rc = (int)this->mmyState;
    std::string         str_cmd = "";
    std::string         str_rsp = "";
    // new, delete
	ftpcmd*             pcdup = (ftpcmd*)0;
	ftpcmd*             pcwd  = (ftpcmd*)0;

	pcdup = new ftpcmd(mpSOCKET, "CDUP\x0d\x0a");
	if (pcdup == (ftpcmd*)0) {
		ecode	retobj(ecode::eVALUE::eNEW, __FUNCTION__, "0 = new ftpcmd(mpSOCKET, CDUP)");
		retobj.output();
		rc = retobj.rc();								// 戻り値に変換
		goto EXIT_FUNCTION;
	}

    rc = pcdup->group1(str_rsp, (void*)0);              // CDUP
    if (rc < 0) {
		goto EXIT_FUNCTION;
    }

    rc = pcdup->group1(str_rsp, (void*)0);              // CDUP
    if (rc < 0) {
		goto EXIT_FUNCTION;
    }

#ifdef DBGPRT
    {   //DEBUG
        std::string     str_rsp = "";
        ftpcmd*         pcmd = (ftpcmd*)0;

        pcmd = new ftpcmd(mpSOCKET, "PWD\x0d\x0a");
        if (pcmd == (ftpcmd*)0) {
            ecode	retobj(ecode::eVALUE::eNEW, __FUNCTION__, "0 = new ftpcmd(mpSOCKET, PWD)");
            retobj.output();
            rc = retobj.rc();							// 戻り値に変換
        }
        rc = pcmd->group1(str_rsp, (void*)0);
        delete pcmd;
    }
#endif

    pcwd = new ftpcmd(mpSOCKET, "CWD RCV/NOTIFY\x0d\x0a");
	if (pcwd == (ftpcmd*)0) {
		ecode	retobj(ecode::eVALUE::eNEW, __FUNCTION__, "0 = new ftpcmd(mpSOCKET, CWD RCV/NOTIFY)");
		retobj.output();
		rc = retobj.rc();								// 戻り値に変換
		goto EXIT_FUNCTION;
	}

    /*
     * CHANGE WORKING DIRECTORY (CWD)
     */
    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eSTOR, "CWD RCV/NOTIFY\n");
	rc = pcwd->group1(str_rsp, (void*)0);               // CWD
	if (rc < 0) {
		goto EXIT_FUNCTION;
	}

EXIT_FUNCTION:
    if (pcdup) {delete pcdup;}
    if (pcwd) {delete pcwd;}

    if (rc < 0) {throw rc;}
    return (int)this->mmyState;
}

/*!
 * @file          seqstor2.cpp
 * @fn            seqstor2::exec(void* pArgs)
 * @brief         コマンド処理
 * @details       STORコマンド送信
 * @return        0 <  VALUE: 異常終了(再起動シーケンス)
 *                0 >= VALUE: 状態遷移コード(0～n)
 * @date          2022/3/28
 * @note          TBD: RFC959 failure時のリトライ処理
 */
int seqstor2::exec(void* pArgs)
{
	int				    rc	= RET_SUCCESS;
    HANDLE              hthr= (HANDLE)(-1L);
    int                 ret_sem = 0;

    std::string         str_cmd;
    //unsigned short      u16port;
    std::string         str_rsp = "";
    // new, delete
	ftpcmd*             pstor = (ftpcmd*)0;
	ecode*			    pec = (ecode*)0;

    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eSTOR, ">>>\n");
    /*
     * まえ処理
     */
    sharedObj.sync_wait();
    sharedObj.mOrder.getfn(EFOLDER::eNTY, mstrPathname);
    sharedObj.sync_post();

    str_cmd = "STOR " + mstrPathname + "\x0d\x0a";
    pstor = new ftpcmd(mpSOCKET, str_cmd.c_str());
	if (pstor == (ftpcmd*)0) {
		ecode	retobj(ecode::eVALUE::eNEW, __FUNCTION__, "0 = new ftpcmd(mpSOCKET, STOR)");
		retobj.output();
		rc = retobj.rc();								// 戻り値に変換
		goto EXIT_FUNCTION;
	}

    //
    // ■ STORコマンド   RCV/NOTIFY
    //
    //u16port = mpSOCKET[ESOCK::eTRAN]->mu16PORT;         // 現在値参照
    //u16port++;
    //if (u16port == 0) {                                 // オーバーフローしたなら、
    //    u16port = SOCPORT_LOCAL;                        // プライベートポート番号の初期値をセット
    //}

    // 直前に通信障害が発生して、セマフォがカーネルに返却済かもしれないので、ここで獲得しておく。
    // 次のセマフォ待ちでは、バックグラウンドでpostするまで、待たされるはず。
    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eSTOR, "sem_wait(100,1)\n");
                                                        // DBGCOUT("sem_wait(100,1)\n");
    ::sem_wait(ESEMID::eFGBG, 100, 1);                  // max100ms待ち。1msだとセマフォ獲得できずにreturnされるかも。
    hthr = ::create_thr(ETHRNAME::eSTOR_NTY, mpSOCKET[ESOCK::eTRAN]);

    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eSTOR, "sem_wait(%d,%d,1)\n", ESEMID::eFGBG, SEM_TIMEOUT);
                                                        // DBGCOUT("sem_wait()\n");
    ret_sem = ::sem_wait(ESEMID::eFGBG, SEM_TIMEOUT, 1);// サーバーからのlisten()待ち
    if (ret_sem < 0) {                                  // バックグラウンドでフリーズしている
        //mpSOCKET[ESOCK::eTRAN]->disconnect(SOCTRAN::eLISTEN);
        mpSOCKET[ESOCK::eTRAN]->release(SOCTRAN::eLISTEN);

		pec = new ecode(ecode::eVALUE::eSEM_TMO, __FUNCTION__, "0 > sem_wait(ESEMID::eFGBG, SEM_TIMEOUT, 1)");
		pec->output();
		rc = pec->rc();						            // 戻り値に変換
        goto EXIT_FUNCTION;
    }

    // backgroundでは、更新前のPORT番号が必要
    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eSTOR, "%s\n", str_cmd.c_str());
	rc = pstor->group2(str_rsp, (void*)0);              // STOR

    // サーバーaccept()完了待ち
    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eSTOR, "STOR->sem_wait(%d,%d,1)\n", ESEMID::eFGBG, SEM_TIMEOUT);
                                                        // DBGCOUT("sem_wait()\n");
    ret_sem = ::sem_wait(ESEMID::eFGBG, SEM_TIMEOUT, 1);// 1msecポーリング
    if (ret_sem < 0) {                                  // バックグラウンドでフリーズしている
        //mpSOCKET[ESOCK::eTRAN]->disconnect(SOCTRAN::eLISTEN);
        mpSOCKET[ESOCK::eTRAN]->release(SOCTRAN::eLISTEN);

		pec = new ecode(ecode::eVALUE::eSEM_TMO, __FUNCTION__, "0 > sem_wait(ESEMID::eFGBG, SEM_TIMEOUT, 1)");
		pec->output();
		rc = pec->rc();						            // 戻り値に変換
        goto EXIT_FUNCTION;
    }

    // STOR結果判定 sem_wait()成功時のgroup2()失敗。原因不明。
	if (rc < 0) {
		goto EXIT_FUNCTION;
	}
    // 2022.3.30 PORT番号更新はバックグラウンドで行う(通信異常時にも更新)
    // STOR送信が終わったので、ローカルPORT更新
    //mpSOCKET[ESOCK::eTRAN]->mu16PORT = u16port;

    // backgroundからforegroundへディスパッチせず、スレッドが終了してしまう。
    // ここで、thread exit待ちはしない。
    //DBGCOUT("sem_wait()->wait_hthr_release()\n");
    //::sem_wait(ESEMID::eFGBG, SEM_TIMEOUT, 1);          // thread exit待ち(1msecポーリング)

EXIT_FUNCTION:
    // バックグラウンドのスレッドが終了している保証がない。。
    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eSTOR, "sem_wait->wait_hthr_release(%lld)\n", (long long int)hthr);
    if (hthr != (HANDLE)(-1L)) { ::wait_hthr_release(hthr); }
                                                        // THREADリソース解放
	if (pec)   {delete pec;}
	if (pstor) {delete pstor;} 

    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eSTOR, "<<< %d\n", rc);
    if (rc < 0) {throw rc;}
    return (int)this->mmyState;
}

/*!
 * @file          seqstor2.cpp
 * @fn            int seqstor2::exit(void* pArgs)
 * @brief         シーケンスあと処理
 * @details       TBD
 * @return        0 <  VALUE: シーケンス中断(TBD)
 *                0 == VALUE: 状態遷移コード(TBD)
 *                0 >  VALUE: 状態遷移コード
 * @date          2022/3/16
 * @note          ***
 */
int seqstor2::exit(void* pArgs)
{
    return ESTATE::ePORT;
}
