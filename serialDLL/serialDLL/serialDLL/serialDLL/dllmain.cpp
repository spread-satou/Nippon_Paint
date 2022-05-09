// dllmain.cpp : DLL アプリケーションのエントリ ポイントを定義します。
#include "pch.h"
#include <process.h>
#include <synchapi.h>
#include <stdio.h>
#include <string.h>
#include <vector>
#include <memory>
#include <iostream>
#include <tchar.h>
#include <stdlib.h>
#include <direct.h>     // _getcwd

#include "def_buffer.h"
#include "ecode.h"
#include "params.h"
#include "serialParams.h"
#include "ccmmsg.h"
#include "dbglog.h"
#include "thr_semaphore.h"

#include "ccm.h"
#include "util_file.h"

ccmmsg* dbg_ccmobj;


// シミュレータが出力するCCMファイルとCCMシリアル通信が出力するCCMファイルは同名
// フォアグラウンドでシミュレータ
// バックグラウンドでCCMシリアル通信
// バックグラウンドはフォアグラウンドの処理時間(5秒もあれば、シミュレータ1シーケンス程度は完了していると想定)
#define TIMER_MAX_CCMSEM       (5*1000)
#define TIMER_MIN_CCMSEM       (1*1000)

#define TIMER_MAX_THREAD       (60*1000)
#define TIMER_MIN_THREAD       (100)

//! 外部宣言
extern const char* pDatafilename;

extern int sem_init(int siSEMID, LONG lInitialCount, LONG lMaximumCount);
extern int sem_close(int siSEMID);
extern int sem_wait(int siSEMID, DWORD dwMaxms, DWORD dwMilliseconds);
extern int sem_post(int siSEMID);

//! グローバル変数
params      sharedObj;
int         gAbortFlg = 0;
HANDLE      thrHandle = (HANDLE)-1;

//! プロトタイプ宣言
static unsigned __cdecl file_transfer(void* pArguments);
//void strcpy(std::string& rDst, const char* pSrc, int siSize);


BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
                     )
{
    // TBD DllMain()がコールされる前にnative_simulator()がcallされてるっぽい


    // https://docs.microsoft.com/ja-jp/windows/win32/dlls/dllmain
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
        ::printf("DLL_PROCESS_ATTACH\n");
        // Initialize once for each new process.
        // Return FALSE to fail DLL load.
        break;
    case DLL_THREAD_ATTACH:
        ::printf("DLL_THREAD_ATTACH\n");
        // Do thread-specific initialization.
        // リソース初期化
        // ::sem_init(ESEMID::eCCMFILE, 1, 1);             // 初回のsem_waitはセマフォが獲得できるので待ちなし
        break;
    case DLL_THREAD_DETACH:
        ::printf("DLL_THREAD_DETACH\n");
        // Do thread-specific cleanup.
        break;
    case DLL_PROCESS_DETACH:
        ::printf("DLL_PROCESS_DETACH\n");
        // Perform any necessary cleanup.
        break;
    }
    return TRUE;
}

__declspec(dllexport) int native_release()
{
    //dbg_ccmobj->mpCom->test_comm();
    
    gAbortFlg = 1;
    // スレッド終了待ち
    ::sem_wait(ESEMID::eTHREADSYNC, TIMER_MAX_THREAD, TIMER_MIN_THREAD);

    ::CloseHandle(thrHandle);
    ::sem_close(ESEMID::eCCMFILE);
    ::sem_close(ESEMID::eTHREADSYNC);
    return 1;
}

__declspec(dllexport) int native_simulator(ccmParams* pParams)
{
    int         rc = RET_FAILED;
    size_t      sz_max  = 128;
    ccm_buffer* pccm    = (ccm_buffer*)0;
    std::stringstream   ss_tmp;

    // まず、シリアル受信と同等の1行テキスト作成
    // 1-5
    ss_tmp << pParams->pKan << ",";                     //! 缶種
    ss_tmp << pParams->pRev << ",";                     //! 改訂
    ss_tmp << pParams->pProdName << ",";                //! 製品名
    ss_tmp << pParams->pProdCode << ",";                //! 製品コード
    ss_tmp << pParams->pPainName << ",";                //! 塗料名
    // 6-7
    ss_tmp << pParams->pWHCode << ",";                  //! ホワイトコード
    ss_tmp << pParams->pWHWeight << ",";                //! ホワイト重量
    // 8-17
    ss_tmp << pParams->pColorant01 << ",";              //! 着色剤コード1
    ss_tmp << pParams->pWeghit01 << ",";                //! 重量1
    ss_tmp << pParams->pColorant02 << ",";              //! 着色剤コード
    ss_tmp << pParams->pWeghit02 << ",";                //! 重量
    ss_tmp << pParams->pColorant03 << ",";              //! 着色剤コード
    ss_tmp << pParams->pWeghit03 << ",";                //! 重量
    ss_tmp << pParams->pColorant04 << ",";              //! 着色剤コード
    ss_tmp << pParams->pWeghit04 << ",";                //! 重量
    ss_tmp << pParams->pColorant05 << ",";              //! 着色剤コード
    ss_tmp << pParams->pWeghit05 << ",";                //! 重量
    // 18-27
    ss_tmp << pParams->pColorant06 << ",";              //! 着色剤コード
    ss_tmp << pParams->pWeghit06 << ",";                //! 重量
    ss_tmp << pParams->pColorant07 << ",";              //! 着色剤コード
    ss_tmp << pParams->pWeghit07 << ",";                //! 重量
    ss_tmp << pParams->pColorant08 << ",";              //! 着色剤コード
    ss_tmp << pParams->pWeghit08 << ",";                //! 重量
    ss_tmp << pParams->pColorant09 << ",";              //! 着色剤コード
    ss_tmp << pParams->pWeghit09 << ",";                //! 重量
    ss_tmp << pParams->pColorant10 << ",";              //! 着色剤コード
    ss_tmp << pParams->pWeghit10 << ",";                //! 重量
    // 28-37
    ss_tmp << pParams->pColorant11 << ",";              //! 着色剤コード
    ss_tmp << pParams->pWeghit11 << ",";                //! 重量
    ss_tmp << pParams->pColorant12 << ",";              //! 着色剤コード
    ss_tmp << pParams->pWeghit12 << ",";                //! 重量
    ss_tmp << pParams->pColorant13 << ",";              //! 着色剤コード
    ss_tmp << pParams->pWeghit13 << ",";                //! 重量
    ss_tmp << pParams->pColorant14 << ",";              //! 着色剤コード
    ss_tmp << pParams->pWeghit14 << ",";                //! 重量
    ss_tmp << pParams->pColorant15 << ",";              //! 着色剤コード
    ss_tmp << pParams->pWeghit15 << ",";                //! 重量
    // 38-45
    ss_tmp << pParams->pColorant16 << ",";              //! 着色剤コード
    ss_tmp << pParams->pWeghit16 << ",";                //! 重量
    ss_tmp << pParams->pColorant17 << ",";              //! 着色剤コード
    ss_tmp << pParams->pWeghit17 << ",";                //! 重量
    ss_tmp << pParams->pColorant18 << ",";              //! 着色剤コード
    ss_tmp << pParams->pWeghit18 << ",";                //! 重量
    ss_tmp << pParams->pColorant19 << ",";              //! 着色剤コード
    ss_tmp << pParams->pWeghit19 << ",";                //! 重量
    // 46-50
    ss_tmp << pParams->pGrossWeight << ",";             //! 総重量
    ss_tmp << pParams->pTerm << ",";                    //! ターミネータ
    ss_tmp << pParams->pFilename << ",";                //! 既調色ファイル名
    ss_tmp << pParams->pIndex << ",";                   //! 目次番号
    ss_tmp << pParams->pLineName;                       //! ライン名

    // 検査
    std::string str_ccm;
    std::string str_fullpath;
    char*       pwork = (char*)0;

    str_ccm = ss_tmp.str();
    pccm = new ccm_buffer(1);
    rc = pccm->memupdate((unsigned char*)str_ccm.c_str(), str_ccm.size());
    if (rc != RET_SUCCESS) {
        return rc;
    }

    rc = pccm->inspector();
    if (rc != RET_SUCCESS) {
        return rc;
    }

    // シミュレータ ccmdata.DAT出力
    pwork = ::_getcwd(0, 0);                            // カレントディレクトリ取得
    if (pwork == (char*)0) {
        return RET_FAILED;
    }

    ss_tmp.str("");                                     // 文字列削除
    ss_tmp << pwork << "\\CCMdata\\ccmdata.DAT";
    str_fullpath = ss_tmp.str();

    ::sem_wait(ESEMID::eCCMFILE, TIMER_MAX_CCMSEM, TIMER_MIN_CCMSEM);
    utility::file::writer(str_fullpath.c_str(), str_ccm);
    ::sem_post(ESEMID::eCCMFILE);

    return RET_SUCCESS;
}

/*!
 * @file        dllmain.cpp
 * @fn          HANDLE native_thread_launcher(void)
 * @brief       FTPスレッド起動
 * @details     FTPスレッド起動
 * @return      0 <  VALUE: TBD
 * @date        1970/3/16
 * @note		***
 */
__declspec(dllexport) int native_thread_launcher(serialParams* pParams)
{
    // [jp] https://docs.microsoft.com/ja-jp/cpp/c-runtime-library/reference/beginthread-beginthreadex?view=msvc-170
    // [us] https://docs.microsoft.com/en-us/cpp/c-runtime-library/reference/beginthread-beginthreadex?view=msvc-170

    HANDLE          hthr;
    unsigned int    thid;
    int             sverr = 0;
    int             svdoserr = 0;
    char*           pbuff = (char*)0;
    size_t          szlen = 0;
    std::string     str_tmp;
    size_t          converted_chars = 0;                // byte数でなく、文字数

    // new, delete
    comParams*      pcp = (comParams*)0;

    pbuff = new char[DMSG_BUFFSIZE];
    memset(pbuff, 0x00, DMSG_BUFFSIZE);

    // リソース初期化
    ::sem_init(ESEMID::eCCMFILE, 1, 1);                 // 初回のsem_waitはセマフォが獲得できるので待ちなし
    ::sem_init(ESEMID::eTHREADSYNC, 0, 1);              // 初回のsem_waitはセマフォが獲得できないので待ちあり

    // ガベージコレクタにメモリ配置をかえられたら、不正アクセスが発生するので、
    // ネイティブコード内のメモリにコピーしておく。
    // 2005年頃のvisual studioはPinでメモリ配置を固定していたと思う。
    pcp = new comParams;

    // メッセージフォーマット
    //  0: 大阪     END文字列後に可変長メッセージが付加される
    //  1: 大阪以外 END文字列がメッセージ終端
    //  2～TBD
    pcp->msgFmt = pParams->msgfmt;

    // シリアルパラメータ
    // c#の実装でNULL終端になっていないと対応不能

    //szlen = ::strnlen(pParams->pport, 8);               // デフォルトはCOM1
    //szlen *= 2;
    //pcp->pport = new TCHAR[szlen + 1];

    //// https://docs.microsoft.com/ja-jp/cpp/c-runtime-library/reference/mbstowcs-s-mbstowcs-s-l?view=msvc-170
    //// 変換後の文字列は、常に null で終わります (エラーの場合も同様)。
    //::mbstowcs_s(&converted_chars, pcp->pport, szlen+1, pParams->pport, _TRUNCATE);

    szlen = ::strnlen(pParams->pport, 8);               // デフォルトはCOM1
    pcp->pport = new char[szlen + 1];
    ::memcpy(pcp->pport, pParams->pport, szlen);
    *(pcp->pport + szlen) = 0x00;

    pcp->commstate.BaudRate = win_serial::baudrate(pParams->baudrate);
    pcp->commstate.ByteSize = win_serial::databites(pParams->databites);

    szlen = ::strnlen(pParams->pstopbits, 3);           // 1.0/2.0/1.5
    pcp->commstate.StopBits = win_serial::stopbits(pParams->pstopbits, szlen);

    szlen = ::strnlen(pParams->pparity, 6);             // none/odd/even/mark/space
    pcp->commstate.Parity = win_serial::parity(pParams->pparity, szlen);

    // ビットフィールド
    pcp->commstate.fOutxCtsFlow = 0;                    // CTS handshaking on output
    pcp->commstate.fOutxDsrFlow = 0;                    // DSR handshaking on output
    pcp->commstate.fDtrControl = pParams->dtrFlow;      // DTR Flow control
    pcp->commstate.fRtsControl = pParams->rtsFlow;      // Rts Flow control

    // イタリア製アプリは1起動1シーケンス
    hthr = (HANDLE)::_beginthreadex(
                            NULL,                       // Security: 子プロセスにハンドル継承しない
                            0,                          // stack_size: デフォルト
                            &file_transfer,             // スレッド開始アドレス
                            (void*)pcp,                 // arglist: スレッドに渡す引数
                            0,                          // initflag: 0は即時実行、CREATE_SUSPENDED は一時停止 
                            &thid);                     // スレッド識別子

    if (hthr == (HANDLE)-1) {                           // -1エラー発生
        // https://docs.microsoft.com/ja-jp/cpp/c-runtime-library/errno-constants?view=msvc-170
        sverr = errno;
        std::cerr << ::strerror_s(pbuff, DMSG_BUFFSIZE, sverr) << std::endl;

#ifdef DEBUG
        // debug
        switch (errsv) {
        case EAGAIN:
            // これ以上プロセスを生成できないか、メモリが不足している
            printf("There are too many threads.\n");
            break;
        case EINVAL:
            // 引数が無効。関数の引数のいずれかに無効な値が指定されている
            printf("The argument is invalid or the stack size is incorrect.\n");
            break;
        case EACCES:
            // アクセス拒否
            printf("There are insufficient resources (such as memory).\n");
            break;
        }
#endif
    }
    else if (hthr == (HANDLE)0) {
        // https://docs.microsoft.com/ja-jp/cpp/c-runtime-library/errno-constants?view=msvc-170
        // マニュアル通りの実装
        sverr = errno;
        svdoserr = _doserrno;                           // 重要度が不明
        std::cerr << ::strerror_s(pbuff, DMSG_BUFFSIZE, sverr) << std::endl;

        std::cerr << "_doserrno: " << svdoserr << std::endl;
    }
    else {
        thrHandle = hthr;

        //::WaitForSingleObject(hthr, INFINITE);
        // Destroy the thread object.
        //::CloseHandle(hthr);

        ::sem_wait(ESEMID::eTHREADSYNC, TIMER_MAX_THREAD, TIMER_MIN_THREAD);
        // セマフォが獲得できたので、delete
        delete[] pcp->pport;
        delete pcp;
    }

    return 1;
}

/*!
 * @file        dllmain.cpp
 * @fn          static unsigned __cdecl file_transfer(void* pArguments)
 * @brief       FTPスレッド
 * @details     FTPスレッド
 * @return      0 <  VALUE: TBD
 * @date        1970/3/16
 * @note		***
 */
 // https://docs.microsoft.com/en-us/windows/win32/sync/using-event-objects
static unsigned __cdecl file_transfer(void* pArguments)
{
    comParams*  ptmp= (comParams*)pArguments;
    comParams*  pcp = (comParams*)0;
    size_t      szlen = 0;

    pcp = new comParams();
    pcp->msgFmt = ptmp->msgFmt;
    ::memcpy(&pcp->commstate, &ptmp->commstate, sizeof(ptmp->commstate));

    szlen = ::strnlen(ptmp->pport, 8);                  // デフォルトはCOM1
    pcp->pport = new char[szlen+1];
    ::memcpy(pcp->pport, ptmp->pport, szlen);
    *(pcp->pport+szlen) = 0x00;

    // copy完了。フォアグラウンドはpArgumentsが示すポインタをdeleteしてOK
    ::sem_post(ESEMID::eTHREADSYNC);

#ifdef DEBUG
    {
        char buf[128];
        ::memset(&buf[0], 0x00, sizeof(buf));
        ::snprintf(&buf[0], sizeof(buf),
                            "%s/%d/%d/%d/%d(PORT/BaudRate/ByteSize/StopBits/Parity)",
                            pcp->pport,
                            pcp->commstate.BaudRate,
                            pcp->commstate.ByteSize,
                            pcp->commstate.StopBits,
                            pcp->commstate.Parity);
        std::cout << &buf[0] << std::endl;
    }
    //std::cout << "PORT: " << pcp->pport << std::endl;
    //std::cout << "BaudRate: " << pcp->commstate.BaudRate << std::endl;
    //std::cout << "ByteSize: " << pcp->commstate.ByteSize << std::endl;
    //std::cout << "StopBits: " << pcp->commstate.StopBits << std::endl;
    //std::cout << "Parity:   " << pcp->commstate.Parity   << std::endl;
    std::cout << "fOutxCtsFlow: " << pcp->commstate.fOutxCtsFlow << std::endl;
    std::cout << "fOutxDsrFlow: " << pcp->commstate.fOutxDsrFlow << std::endl;
    std::cout << "fDtrControl:  " << pcp->commstate.fDtrControl  << std::endl;
    std::cout << "fRtsControl:  " << pcp->commstate.fRtsControl  << std::endl;
#endif

    ///////////////////////////////////////////////////////////////////////////

    int rc = RET_SUCCESS;
    std::vector<std::string> vparams;
    //DCB         dcb_target;
    int         ret_ccm;
    size_t      cnt_expect;                             // 期待値
    size_t      cnt_param;                              // 実際
    ccmmsg*     pcmobj = (ccmmsg*)0;
    std::string str_ccmmsg;
    std::string str_fp_data;
    std::string str_logf;

    str_fp_data = sharedObj.mstrCurDir[EPRM_CLIDIR::eDATA] + "\\" + pDatafilename;
    str_logf    = sharedObj.mstrFullPath[EPRM_PATH::eLOG];

    #if 0
    dcb_target.BaudRate = CBR_9600;                     // baud rate
    dcb_target.ByteSize = 8;                            // data size, xmit and rcv
    dcb_target.StopBits = ONESTOPBIT;                   // stop bit
    dcb_target.Parity = NOPARITY;                       // parity bit

    // ビットフィールド
    dcb_target.fOutxCtsFlow = 0;                        // CTS handshaking on output
    dcb_target.fOutxDsrFlow = 0;                        // DSR handshaking on output
    dcb_target.fDtrControl = DTR_CONTROL_DISABLE;       // DTR Flow control
    dcb_target.fRtsControl = RTS_CONTROL_DISABLE;       // Rts Flow control
    #endif

    ccmmsg* pcm = (ccmmsg*)0;
    pcmobj = (ccmmsg*)0;
    try {
        while (gAbortFlg == 0) {
            // new前にdelete
            if (pcmobj) {
                delete pcmobj;
                pcmobj = (ccmmsg*)0;
            }

            // PORT初期化
            pcmobj = new ccmmsg(pcp->pport/*_T("COM5")*/);     // 不適切なPORTなら、例外発生
            if (pcmobj == (ccmmsg*)0) {
                rc = RET_FAILED;
                break;
            }
dbg_ccmobj = pcmobj;
            //  Fill in some DCB values and set the com state: 
            //  9,600 bps, 8 data bits, no parity, and 1 stop bit.
            ret_ccm = pcmobj->setdcb(pcp->commstate);
            if (ret_ccm < 0) {
                throw ret_ccm;
            }

            ret_ccm = pcmobj->receiver(pcp->msgFmt, vparams);
            if (ret_ccm < 0) {
                throw ret_ccm;
            }
            else {
                // パラメータチェック
                cnt_expect = (pcp->msgFmt != 0) ? PARAM_OOSAKA_NUM : PARAM_DEFAULT_NUM;

                cnt_param = vparams.size();                 // サイズのみ
                if (cnt_param != cnt_expect) {
                    rc = RET_FAILED;
                }
                else {
                    pcmobj->getmsg(str_ccmmsg);

                    ::sem_wait(ESEMID::eCCMFILE, TIMER_MAX_CCMSEM, TIMER_MIN_CCMSEM);
                    //pcmobj->writer(str_fp_data.c_str());
                    dbglog::text_writer(str_fp_data.c_str(), str_ccmmsg);
                    dbglog::append_writer(str_logf.c_str(), str_ccmmsg);
                    ::sem_post(ESEMID::eCCMFILE);
                }
            }
        }
    }
    catch (int ret_ec) {
        int port_err = VALUE::eCREATEFILE;
        int port_cur = ret_ec * -1;                     // エラーコードを正数

        std::cout << "EC: " << ret_ec << std::endl;
        if (port_cur >= port_err) {
            if (pcmobj) {
                pcmobj->getcomobj()->clear();
            }
        }
    }

    if (pcmobj) { delete pcmobj; }

    ///////////////////////////////////////////////////////////////////////////
    ::sem_post(ESEMID::eTHREADSYNC);
    ::_endthreadex(0);
    return 0;
}
