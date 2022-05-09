#include "pch.h"
#include "params.h"
#include "ecode.h"

#include <windows.h>
#include <direct.h>             // _getcwd

//! パラメータ定義
static const char* pLogfilename  = (const char*)"CCMLog.txt";
const char* pDatafilename = (const char*)"ccmdata.DAT";

params::params()
{
    int rc = this->initialize();
    if (rc < 0) {
        //throw rc;     グローバルオブジェクトとして、宣言(インスタンス)したので、try catch()できない 
    }
}

params::~params()
{
    this->variables();
}

/*!
 * @file		params.cpp
 * @fn			int params::initialize(void)
 * @brief		パラメータ初期化
 * @details		デフォルト値設定
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

    // ORManager\CCMLog\CCMLog.txt
    mstrFullPath[EPRM_PATH::eLOG] = str_dir;
    mstrFullPath[EPRM_PATH::eLOG] += "\\CCMLog\\";
    mstrFullPath[EPRM_PATH::eLOG] += pLogfilename;

    // ORManager\CCMdata\ccmdata.DAT
    mstrCurDir[EPRM_CLIDIR::eDATA] = str_dir;
    mstrCurDir[EPRM_CLIDIR::eDATA] += "\\CCMdata\\";;

    ::free(pwork);
    return rc;
}

int params::variables(void)
{
    int ii;

    for (ii = 0; ii < EPRM_CLIDIR::eNUMB; ii++) {
        mstrCurDir[ii].clear();
    }

    for (ii = 0; ii < EPRM_PATH::eNUMB; ii++) {
        mstrFullPath[ii].clear();
    }

    return RET_SUCCESS;
}

//int params::sync_init(void)
//{
//    return ::sem_init(ESEMID::ePARAMS, 1/*initial*/, 1/*max*/);
//}
//
//int params::sync_wait(void)
//{
//    return ::sem_wait(ESEMID::ePARAMS, SEM_TIMEOUT, 1);
//}
//
//int params::sync_post(void)
//{
//    return ::sem_post(ESEMID::ePARAMS);
//}
//
//int params::sync_close(void)
//{
//    return ::sem_close(ESEMID::ePARAMS);
//}

