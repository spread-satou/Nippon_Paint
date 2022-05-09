#include "pch.h"
#include "thr_launcher.h"
#include "ftplog.h"
#include "def_dbg.h"
#include "ecode.h"

#include <windows.h>
#include <process.h>
#include <string>
#include <iostream>

// _beginthread, _beginthreadex https://docs.microsoft.com/ja-jp/cpp/c-runtime-library/reference/beginthread-beginthreadex?view=msvc-170
/*  
    uintptr_t _beginthreadex( // NATIVE CODE
                    void        *security,
                    unsigned    stack_size,
                    unsigned    ( __stdcall *start_address )( void * ),
                    void*       arglist,
                    unsigned    initflag,
                    unsigned    *thrdaddr
                    );

    hthr = (HANDLE)_beginthreadex(
                    NULL,       // security             // SECURITY_ATTRIBUTES返されたハンドルを子プロセスが継承できるかどうかを決定する構造体へのポインター
                    0,          // stack_size           // 新しいスレッドのスタック サイズまたは 0。
                    &dataTrnasfer,                      // 新しいスレッドの実行を開始するルーチンの開始アドレス
                    NULL,       // arglist              // 新しいスレッドに渡す引数リスト、または NULL 
                    0,          // initflag             // 新しいスレッドの初期状態を制御するフラグ。 initflag直ちに実行する場合は0に設定
                    &thid);     // thrdaddr             // スレッド識別子を受け取る 32 ビット変数へのポインター。 の場合は NULL 、使用されません。
*/

/*
 *  外部宣言
 */
extern void nlst_receiver(void* pArguments);
extern void retr_receiver(void* pArguments);
extern void stor_ans_sender(void* pArguments);
extern void stor_nty_sender(void* pArguments);

/*
 * background thread本体
 */
static unsigned __cdecl dataTrnasfer( void* pArguments );      //unsigned __stdcall dataTrnasfer( void* pArguments );
static unsigned __cdecl downloader(void* pArguments);
static unsigned __cdecl ans_uploader(void* pArguments);
static unsigned __cdecl nty_uploader(void* pArguments);

HANDLE create_thr(int siNAME, void* pArgs)
{
    int         rc = RET_SUCCESS;
    HANDLE      hthr;
    unsigned    thid;

    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eXXXX, ">>>([%d],..)\n", siNAME);
    /*
     * Create the second thread.
     */
    switch(siNAME) {
    case ETHRNAME::eNLST:                               // nlst *.*
        hthr = (HANDLE)_beginthreadex(NULL, 0, &dataTrnasfer, pArgs, 0, &thid);
        break;
    case ETHRNAME::eRETR:                               // retr SND/ORDER
        hthr = (HANDLE)_beginthreadex(NULL, 0, &downloader, pArgs, 0, &thid);
        break;
    case ETHRNAME::eSTOR_ANS:                           // stor SND/ANSWER
        hthr = (HANDLE)_beginthreadex(NULL, 0, &ans_uploader, pArgs, 0, &thid);
        break;
    case ETHRNAME::eSTOR_NTY:                           // stor RCV/NOTIFY
        hthr = (HANDLE)_beginthreadex(NULL, 0, &nty_uploader, pArgs, 0, &thid);
        break;
    default:
        hthr = (HANDLE)-1;
    }

    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eXXXX, "<<< %lld\n", (long long int)hthr);
    return hthr;
}

int wait_hthr_release(HANDLE hThread)
{
    DWORD   dwmsec = 20 * 1000;                         // 20sec
    /*
     * Destroy the thread object.
     */
    WaitForSingleObject(hThread, dwmsec);               // connect()のタイムアウトが20secなので、こちらも20。
    CloseHandle( hThread );                             // accept()が無限待ちになったら、強制終了

    return RET_SUCCESS;
}

static unsigned __cdecl dataTrnasfer( void* pArguments )
{
    //DBGCOUT( "[FTP][BGT]In DataTransfer thread...\n" );
    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eXXXX, ">>>\n");

    nlst_receiver(pArguments);

    //DBGCOUT("[FTP][BGT]_endthreadex(0)...\n");
    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eXXXX, "<<<\n");
    _endthreadex( 0 );
    return 0;
}

static unsigned __cdecl downloader( void* pArguments )
{
    //DBGCOUT( "[FTP][BGT]In downloader thread...\n" );
    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eXXXX, ">>>\n");

    retr_receiver(pArguments);

    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eXXXX, "<<<\n");
    //DBGCOUT("[FTP][BGT]_endthreadex(0)...\n");
    _endthreadex( 0 );
    return 0;
}

static unsigned __cdecl ans_uploader(void* pArguments)
{
    //DBGCOUT("[FTP][BGT]In ans_uploader thread...\n");
    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eXXXX, ">>>\n");

    stor_ans_sender(pArguments);

    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eXXXX, "<<<\n");
    //DBGCOUT("[FTP][BGT]_endthreadex(0)...\n");
    _endthreadex(0);
    return 0;
}

static unsigned __cdecl nty_uploader(void* pArguments)
{
    //DBGCOUT("[FTP][BGT]In nty_uploader thread...\n");
    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eXXXX, ">>>\n");

    stor_nty_sender(pArguments);

    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eXXXX, "<<<\n");
    //DBGCOUT("[FTP][BGT]_endthreadex(0)...\n");
    _endthreadex(0);
    return 0;
}
