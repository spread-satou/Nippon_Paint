#include "pch.h"
#include "params.h"
#include "ecode.h"
#include "thr_semaphore.h"

#include <windows.h>
#include <direct.h>             // _getcwd

//! 外部宣言
extern int sem_init(int siSEMID, LONG lInitialCount, LONG lMaximumCount);
extern int sem_wait(int siSEMID, DWORD dwMaxms, DWORD dwMilliseconds);
extern int sem_post(int siSEMID);
extern int sem_close(int siSEMID);

//! パラメータ定義
static const char* pLogfilename = (const char*)"dbgFTPlog.txt";

params::params()
{
    this->initialize();
}

params::~params()
{
    this->variables();
}

/*!
 * @file		params.cpp
 * @fn			int params::initialize(void)
 * @brief		パラメータ初期化
 * @details		パラメータ初期化
 * @return		-1 <  Return value: エラーコード
 * 		         0 == Return value: 成功
 * 				 1 == Return value: TBD
 * @param[in]	void
 * @param[out]	void
 * @date		2022/3/30
 * @note        
 */
int params::initialize(void)
{
    int     rc = RET_SUCCESS;
    char*   pwork = (char*)0;
    std::string str_dir;

    variables();

    // 以下、デフォルト値設定
    mstrSrvDir[EPRM_SRVDIR::eORDER]    = "SND/ORDER";
    mstrSrvDir[EPRM_SRVDIR::eFEEDBACK] = "SND/ANSWER";
    mstrSrvDir[EPRM_SRVDIR::eNOTIFY]   = "RCV/NOTIFY";

    // https://docs.microsoft.com/ja-jp/cpp/c-runtime-library/reference/getcwd-wgetcwd?view=msvc-170
    pwork = ::_getcwd(0, 0);                            // カレントディレクトリ取得
    if (pwork == (char*)0) {
        // ↑メモリ確保に失敗してそうなので、newせずにインスタンス↓
        ecode retobj(ecode::eVALUE::eGETCWD, __FUNCTION__, "0=_getcwd(0, 0)");
        retobj.output();
		rc = retobj.rc();								// 戻り値に変換
        return rc;
    }
    str_dir = pwork;

    mstrFullPath[EPRM_PATH::eFTPLOG] = str_dir;
    mstrFullPath[EPRM_PATH::eFTPLOG] += "\\";
    mstrFullPath[EPRM_PATH::eFTPLOG] += pLogfilename;

    mstrCurDir[EPRM_CLIDIR::eINCOM]   = str_dir;
    mstrCurDir[EPRM_CLIDIR::eORDLOGS] = str_dir;
    mstrCurDir[EPRM_CLIDIR::ePROC]    = str_dir;
    mstrCurDir[EPRM_CLIDIR::eCOMP]    = str_dir;

    ::free(pwork);
    return rc;
}

int params::variables(void)
{
    int iii;

    //mstrSrvAcct[EPRM_ACCT::eIPv4].clear();
    //mstrSrvAcct[EPRM_ACCT::eUSER].clear();
    //mstrSrvAcct[EPRM_ACCT::ePASS].clear();

    for (iii = 0; iii < EPRM_PORT::eNUMB; iii++) {
        mstrSrvPort[iii].clear();    
    }

    for (iii = 0; iii < EPRM_ACCT::eNUMB; iii++) {
        mstrSrvAcct[iii].clear();    
    }

    for (iii = 0; iii < EPRM_SRVDIR::eNUMB; iii++) {
        mstrSrvDir[iii].clear();
    }

    for (iii = 0; iii < EPRM_CLIDIR::eNUMB; iii++) {
        mstrCurDir[iii].clear();
    }

    for (iii = 0; iii < EPRM_PATH::eNUMB; iii++) {
        mstrFullPath[iii].clear();
    }

    msiSite = EPRM_SITE::eUNKNOWN;
    return RET_SUCCESS;
}

int params::sync_init(void)
{
    return ::sem_init(ESEMID::ePARAMS, 1/*initial*/, 1/*max*/);
}

int params::sync_wait(void)
{
    return ::sem_wait(ESEMID::ePARAMS, SEM_TIMEOUT, 1);
}

int params::sync_post(void)
{
    return ::sem_post(ESEMID::ePARAMS);
}

int params::sync_close(void)
{
    return ::sem_close(ESEMID::ePARAMS);
}

