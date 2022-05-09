#include "pch.h"
#include "thr_semaphore.h"
#include "dbglog.h"
#include <stdio.h>
#include <sstream>
#include <iostream>

/*  // https://docs.microsoft.com/ja-jp/windows/win32/sync/using-semaphore-objects
    ■posixの場合、
    sem_open()に対して、sem_close()/sem_destroy()   初期化と削除 
    sem_wait()に対して、sem_post()  獲得と解放

    ■windowsの場合、
    CreateSemaphore()に対して、close()がない
    WaitForSingleObject()に対して、ReleaseSemaphore()

    https://docs.microsoft.com/ja-jp/windows/win32/sync/synchronization-functions#semaphore-functions
    セマフォ関数は以下の4つ
    CreateSemaphore()       作成/open
    CreateSemaphoreEx()     作成/open
    OpenSemaphore()         open
    ReleaseSemaphore()      release

    ※close()はないが、リソースリークはしない(Microsoft仕様)

    ■ posixの場合
        プロセス起動時にsem_open()
        プロセス終了時にsem_close()
        プロセス実行中、sem_wait()<-->sem_post()を繰り返す。

    ■windowsの場合、
        close()がない、release()さえしておけば、リソースがリークしないので、
        プロセス起動時、create()/open()しない
        プロセス終了時、なにもすることがない
        プロセス実行中、create()<-->release()   都度、create()するし、都度、release()する

    ※ 違和感あるけど、仕様だから。
*/

HANDLE ghSemaphore[ESEMID::eNUMB];

//! プロトタイプ宣言
int sem_init(int siSEMID, LONG lInitialCount, LONG lMaximumCount);
int sem_wait(int siSEMID, DWORD dwMaxms, DWORD dwMilliseconds);
int sem_post(int siSEMID);
int sem_close(int siSEMID);

//!メソッド
/*!
 * @file		thr_semaphore.cpp
 * @fn			int sem_init(LONG lInitialCount, LONG lMaximumCount)
 * @brief		セマフォ初期化
 * @details		セマフォ初期化
 * @return		0 <  Return value: エラーコード(TBD)
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @param[in]	lInitialCount   The initial count for the semaphore object. 
 * @param[in]	lMaximumCount   The maximum count for the semaphore object. 
 * @date		1970/1/1
 * @note		***
 */
int sem_init(int siSEMID, LONG lInitialCount, LONG lMaximumCount)
{
    // https://docs.microsoft.com/ja-jp/windows/win32/sync/using-semaphore-objects
    // Create a semaphore with initial and max counts of lMaximumCount
    // ※ CloseHandle()でghSemaphoreを解放する

    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eXXXX, ">>>(%d,%d,%d)\n", siSEMID, lInitialCount, lMaximumCount);

    ghSemaphore[siSEMID] = ::CreateSemaphore( 
                                NULL,                   // default security attributes
                                lInitialCount,          // initial count
                                lMaximumCount,          // maximum count
                                NULL);                  // unnamed semaphore
    if (ghSemaphore[siSEMID] == NULL) {
        printf("[FTP][***]CreateSemaphore error: %d\n", GetLastError());
        return -1;
    }

    //printf("[FTP][***]sem_init(%d,%d,%d) HANDLE %lld\n", siSEMID, lInitialCount, lMaximumCount, (unsigned long long)ghSemaphore[siSEMID]);
    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eXXXX, "<<<[%d] %p\n", siSEMID, ghSemaphore[siSEMID]);
    return 0;
}

/*!
 * @file		thr_semaphore.cpp
 * @fn			int sem_wait(LONG dwMilliseconds)
 * @brief		セマフォ獲得待ち
 * @details		セマフォ獲得待ち
 * @return		0 <  Return value: エラーコード(TBD)
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @param[in]	dwMaxms         最大待ち時間
 * @param[in]	dwMilliseconds  The time-out interval, in milliseconds.(ポーリング間隔)
 * @date		1970/1/1
 * @note		***
 */
int sem_wait(int siSEMID, DWORD dwMaxms, DWORD dwMilliseconds)
{
    int     rc = 0;
    DWORD   dwWaitResult;
    BOOL    bContinue = TRUE;
    DWORD   max_wtime = SEM_TIMEOUT;
	int     cnt_retry = 0;						        // リトライ回数

	//cnt_retry = max_wtime / dwMilliseconds;
	cnt_retry = dwMaxms / dwMilliseconds;
    do {                                                //while(bContinue) {
        // Try to enter the semaphore gate.
        dwWaitResult = ::WaitForSingleObject( 
                                ghSemaphore[siSEMID],   // handle to semaphore
                                dwMilliseconds);        // zero-second time-out interval

        switch (dwWaitResult) { 
        case WAIT_OBJECT_0:                             // The semaphore object was signaled.
            //printf("[FTP][***]Thread %d: sem_wait(%d,) succeeded\n", GetCurrentThreadId(), siSEMID);

            LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eXXXX, "Thread %d: sem_wait(%d,%d,%d) succeeded\n", GetCurrentThreadId(), siSEMID, dwMaxms, dwMilliseconds);
            bContinue=FALSE;
            break; 

        case WAIT_TIMEOUT:                              // The semaphore was nonsignaled, so a time-out occurred.
            cnt_retry--;
            if (cnt_retry <= 0) {
                LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eXXXX, "Thread %d: sem_wait(%d,%d,%d) timed out\n", GetCurrentThreadId(), siSEMID, dwMaxms, dwMilliseconds);
                bContinue = FALSE;
                rc = -1;
            }
            break; 
        }
	} while(bContinue == TRUE);

    return rc;
}

/*!
 * @file		thr_semaphore.cpp
 * @fn			int sem_wait(void)
 * @brief		セマフォ返却
 * @details		セマフォ返却
 * @return		0 <  Return value: エラーコード(TBD)
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @param[in]	void
 * @date		1970/1/1
 * @note		***
 */
int sem_post(int siSEMID)
{
    BOOL    bret_sem;

    // Release the semaphore when task is finished
    bret_sem = ::ReleaseSemaphore(ghSemaphore[siSEMID], // handle to semaphore
                                1,                      // increase count by one
                                NULL);                  // not interested in previous count
    if (bret_sem == FALSE) {
        printf("[FTP][***]sem_post(%d)->ReleaseSemaphore(%lld,) error: %d\n",
                                siSEMID,
                                (unsigned long long)ghSemaphore[siSEMID],
                                GetLastError());
    }
    return 0;
}

/*!
 * @file		thr_semaphore.cpp
 * @fn			int sem_close(void)
 * @brief		セマフォハンドルクローズ
 * @details		セマフォハンドルクローズ
 * @return		0 <  Return value: エラーコード(TBD)
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @param[in]	void
 * @date		1970/1/1
 * @note		***
 */
int sem_close(int siSEMID)
{
    // https://docs.microsoft.com/ja-jp/windows/win32/api/handleapi/nf-handleapi-closehandle
    // If the function succeeds, the return value is nonzero.
    // If the function fails, the return value is zero. To get extended error information, call
    // GetLastError.

    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eXXXX, "CloseHandle([%d] %llx)\n", siSEMID, (unsigned long long)ghSemaphore[siSEMID]);
    ::CloseHandle(ghSemaphore[siSEMID]);
    //printf("sem_close(%d)->CloseHandle(%lld)\n", siSEMID, (unsigned long long)ghSemaphore[siSEMID]);

    return 0;
}

