#include "pch.h"
#include "comport.h"
#include "ecode.h"
#include "winec.h"
#include "dbglog.h"

//#define DBG_RCV_ZEROBYTE

comport::comport()
{
    int rc = this->initialize("COM1");
    if (rc < 0) {
        throw rc;
    }
}

comport::comport(const char* pPort)
{
    int rc = this->initialize(pPort);
    if (rc < 0) {
        throw rc;
    }
}

comport::~comport()
{
    if (mHandle != INVALID_HANDLE_VALUE) {              // フェイルセーフ
        ::CloseHandle(mHandle);
        mHandle = INVALID_HANDLE_VALUE;
    }

    if  (mpBuffer) {
        delete[] mpBuffer;
        mpBuffer = 0;
    }
}

//https://cpp.hotexamples.com/examples/-/-/SetCommBreak/cpp-setcommbreak-function-examples.html
int comport::clear()
{
    int             rc = RET_SUCCESS;
    int             ret_ec = RET_FAILED;
    BOOL            ret_wlib;
    std::wstring	wstr_emsg;
    // new, delete
    ecode* pec = (ecode*)0;

    // CCMメッセージ約150byte
    // 150byte => 1200bit
    // 9600bps(bit/sec)の場合、
    // 1200/9600 = 0.125秒 = 約0.2秒

    // Suspends character transmission for a specified communications device
    //  and places the transmission line in a break state
    //  until the ClearCommBreak function is called.
    ret_wlib = ::SetCommBreak(mHandle);                 // 通信サスペンド
    if (ret_wlib == FALSE) {
        ret_ec = winec::get_emsg(wstr_emsg);            // Winエラーコード取得

        std::wstring wstr_tmp = L"Failed SetCommBreak()..,";
        wstr_tmp += wstr_emsg;

        pec = new ecode(ecode::eVALUE::eSETCOMMBREAK, __FUNCTIONW__, wstr_tmp);
        pec->output();
        rc = pec->rc();
        goto EXIT_METHOD;
    }
    ::Sleep(200);                                       // sleep 200 ms

    ret_wlib = ::ClearCommBreak(mHandle);               // ブレイク状態解除
    if (ret_wlib == FALSE) {
        ret_ec = winec::get_emsg(wstr_emsg);            // Winエラーコード取得

        std::wstring wstr_tmp = L"Failed ClearCommBreak()..,";
        wstr_tmp += wstr_emsg;

        pec = new ecode(ecode::eVALUE::eCLEARCOMMBREAK, __FUNCTIONW__, wstr_tmp);
        pec->output();
        rc = pec->rc();
        goto EXIT_METHOD;
    }
    ::Sleep(100);                                       // sleep 100 ms

    // Discards all characters from the output or input buffer of a specified communications resource.
    // It can also terminate pending read or write operations on the resource.
    ret_wlib = ::PurgeComm(mHandle, PURGE_RXCLEAR);
    if (ret_wlib == FALSE) {
        ret_ec = winec::get_emsg(wstr_emsg);            // Winエラーコード取得

        std::wstring wstr_tmp = L"Failed PurgeComm()..,";
        wstr_tmp += wstr_emsg;

        pec = new ecode(ecode::eVALUE::ePURGECOMM, __FUNCTIONW__, wstr_tmp);
        pec->output();
        rc = pec->rc();
        goto EXIT_METHOD;
    }

EXIT_METHOD:
    if (pec) { delete pec; }

    return rc;
}

/*!
 * @file			comport.cpp
 * @fn              int comport::initialize(const char* pPort)
 * @brief           初期化
 * @details         リソース初期化
 * @return          0 <  VALUE: TBD
 *                  0 == VALUE: 成功
 *                  0 >  VALUE: TBD
 * @param[in]       pPort       ポート文字列
 * @date            2022/4/18
 * @note
 */
int comport::initialize(const char* pPort)
{
    this->variables();

    int             rc = RET_SUCCESS;
    BOOL            ret_wlib;
    int             ret_ec = 0;
    std::wstring	wstr_emsg;
    // PORT
    size_t          converted_chars = 0;                // byte数でなく、文字数
    size_t          szlen = 0;
    // new, delete
    ecode* pec = (ecode*)0;
    TCHAR* ptch_port = (TCHAR*)0;

    //
    // まえ処理
    //
    mpBuffer = new char[DMSG_BUFFSIZE];
    if (mpBuffer == (char*)0) {
        ecode	retobj(ecode::eVALUE::eNEW, __FUNCTION__, "0 = new char[DMSG_BUFFSIZE]");
        retobj.output();
        rc = retobj.rc();								// 戻り値に変換
        return rc;
    }
    ::memset(mpBuffer, 0x00, DMSG_BUFFSIZE);

    szlen = ::strnlen(pPort, 8);                        // デフォルトはCOM1
    szlen *= 2;
    ptch_port = new TCHAR[szlen + 1];

    // https://docs.microsoft.com/ja-jp/cpp/c-runtime-library/reference/mbstowcs-s-mbstowcs-s-l?view=msvc-170
    // 変換後の文字列は、常に null で終わります (エラーの場合も同様)。
    ::mbstowcs_s(&converted_chars, ptch_port, szlen + 1, pPort, _TRUNCATE);

    // Open a handle to the specified com port.
    // 非同期では使用しない(第６引数にFILE_FLAG_OVERLAPPEDを指定しない)
    mHandle = ::CreateFile(ptch_port,                   // _T("COM1"),
                    GENERIC_READ/*| GENERIC_WRITE*/,
                    0,                                  // must be opened with exclusive-access
                    NULL,                               // default security attributes
                    OPEN_EXISTING,                      // must use OPEN_EXISTING
                    0,                                  // not overlapped I/O
                    NULL);                              // hTemplate must be NULL for comm devices

    if (mHandle == INVALID_HANDLE_VALUE) {
        // Handle the error.
        // printf("CreateFile failed with error %d.\n", GetLastError());
        ret_ec = winec::get_emsg(wstr_emsg);            // Winエラーコード取得

        std::wstring wstr_tmp = L"Failed CreateFile()..,";
        wstr_tmp += wstr_emsg;

        pec = new ecode(ecode::eVALUE::eCREATEFILE, __FUNCTIONW__, wstr_tmp);
        pec->output();
        rc = pec->rc();
        goto EXIT_METHOD;
    }

    // Discards all characters from the output or input buffer of a specified communications resource.
    // It can also terminate pending read or write operations on the resource.
    ret_wlib = ::PurgeComm(mHandle, PURGE_RXCLEAR);
    if (ret_wlib == FALSE) {
        ret_ec = winec::get_emsg(wstr_emsg);            // Winエラーコード取得

        std::wstring wstr_tmp = L"Failed PurgeComm()..,";
        wstr_tmp += wstr_emsg;

        pec = new ecode(ecode::eVALUE::ePURGECOMM, __FUNCTIONW__, wstr_tmp);
        pec->output();
        rc = pec->rc();
        goto EXIT_METHOD;
    }

EXIT_METHOD:
    if (pec) { delete pec; }
    if (ptch_port) {delete[] ptch_port;}
    return rc;
}

/*!
 * @file			comport.cpp
 * @fn              int comport::variables()
 * @brief           初期化
 * @details         無効値設定
 * @return          0 <  VALUE: TBD
 *                  0 == VALUE: 成功
 *                  0 >  VALUE: TBD
 * @param[in,out]   void
 * @date            2022/4/18
 * @note
 */
int comport::variables()
{
    mstrPort.clear();
    mpBuffer   = (char*)0;
    msiMsgSize = 0;
    mHandle    = INVALID_HANDLE_VALUE;
    ::memset(&mDCB, 0x00, sizeof(mDCB));
    return RET_SUCCESS;
}

/*!
 * @file			comport.cpp
 * @fn              int comport::initdcb(DCB& rDCB)
 * @brief           device control block初期化
 * @details         device control block初期化
 * @return          0 <  VALUE: エラーコード
 *                  0 == VALUE: 成功
 *                  0 >  VALUE: TBD
 * @param[in,out]   void
 * @date            2022/4/18
 * @note
 */
int comport::initdcb(DCB& rDCB)
{
    int     rc = RET_SUCCESS;
    int     ret_ec;
    BOOL    ret_wlib;
    std::wstring	wstr_emsg = L"";
    // new, delete
    ecode* pec = (ecode*)0;

    // Initialize the DCB structure.
    ::memset(&rDCB, 0x00, sizeof(DCB));                 // SecureZeroMemory(&mDCB, sizeof(DCB));
    ::memset(&mDCB, 0x00, sizeof(DCB));                 // setdcb()で上書きされるが、念のために初期化
    rDCB.DCBlength = sizeof(DCB);
    mDCB.DCBlength = sizeof(DCB);

    // Build on the current configuration by first retrieving all current settings.
    ret_wlib = ::GetCommState(mHandle, &rDCB);
    if (!ret_wlib) {
        // Handle the error.
        // printf("GetCommState failed with error %d.\n", GetLastError());

        ret_ec = winec::get_emsg(wstr_emsg);            // Winエラーコード取得
        std::wstring wstr_tmp = L"Failed GetCommState()..,";
        wstr_tmp += wstr_emsg;

        pec = new ecode(ecode::eVALUE::eGETCOMMSTATE, __FUNCTIONW__, wstr_tmp);
        pec->output();
        rc = pec->rc();
    }

    return rc;
}

/*!
 * @file			comport.cpp
 * @fn              int comport::initport(DCB& rDCB)
 * @brief           DCB(Device control block)初期化
 * @details         COMポート初期化
 * @return          0 <  VALUE: エラーコード
 *                  0 == VALUE: 成功
 *                  0 >  VALUE: TBD
 * @param[in]       rDCB: Device control block
 * @date            2022/4/18
 * @note
 */
int comport::setdcb(DCB& rDCB)
{
    // https://docs.microsoft.com/ja-jp/windows/win32/devio/configuring-a-communications-resource
    // https://docs.microsoft.com/en-us/windows/win32/api/winbase/nf-winbase-setcommstate

    int             rc = RET_SUCCESS;
    int             ret_ec;
    std::wstring	wstr_emsg = L"";

    BOOL    ret_wlib;
    //TCHAR*  pcCommPort = TEXT("COM1");                // Most systems have a COM1 port
    // new, delete
    ecode* pec = (ecode*)0;

#ifdef DEBUG
    //  Fill in some DCB values and set the com state: 
    //  9,600 bps, 8 data bits, no parity, and 1 stop bit.
    mDCB.BaudRate = CBR_9600;                           // baud rate
    mDCB.ByteSize = 8;                                  // data size, xmit and rcv
    mDCB.StopBits = ONESTOPBIT;                         // stop bit
    mDCB.Parity = NOPARITY;                           // parity bit

    // ビットフィールド
    mDCB.fOutxCtsFlow = 0;                              // CTS handshaking on output
    mDCB.fOutxDsrFlow = 0;                              // DSR handshaking on output
    mDCB.fDtrControl = DTR_CONTROL_DISABLE;            // DTR Flow control
    mDCB.fRtsControl = RTS_CONTROL_DISABLE;            // Rts Flow control
#else
    ::memcpy(&mDCB, &rDCB, sizeof(DCB));
#endif

    ret_wlib = ::SetCommState(mHandle, &mDCB);
    if (!ret_wlib) {
        // Handle the error.
        // printf("SetCommState failed with error %d.\n", GetLastError());

        ret_ec = winec::get_emsg(wstr_emsg);            // Winエラーコード取得
        std::wstring wstr_tmp = L"Failed SetCommState()..,";
        wstr_tmp += wstr_emsg;

        pec = new ecode(ecode::eVALUE::eSETCOMMSTATE, __FUNCTIONW__, wstr_tmp);
        pec->output();
        rc = pec->rc();
        goto EXIT_METHOD;
    }

#ifdef DEBUG
    // Get the comm config again.
    ret_wlib = ::GetCommState(mHandle, &mDCB);
    if (!ret_wlib) {
        // Handle the error.
        printf("GetCommState failed with error %d.\n", GetLastError());
        return (2);
    }
#endif  /* #ifdef DEBUG */

EXIT_METHOD:
    if (pec) { delete pec; }
    return rc;
}

/*!
 * @file			comport.cpp
 * @fn              int comport::receiver(int siMsgFmt, const char* pStopper)
 * @brief           シリアル受信(バイナリモード)
 * @details         シリアル受信(バイナリモード)
 * @return          0 <  VALUE: エラーコード(ポート初期化要)
 *                  0 == VALUE: 受信レングス
 *                  0 >  VALUE: TBD
 * @param[int]      siMsgFmt: メッセージフォーマット
 *                  0: END文字列後に可変長メッセージなし(大阪以外)
 *                  1: END文字列後に可変長メッセージあり(大阪)
 * @param[int]      pStopper: メッセージ終端文字列
 * @date            2022/4/19
 * @note            https://docs.microsoft.com/en-us/windows/win32/api/fileapi/nf-fileapi-readfile
 *                  ReadFile()の戻り値
 *                  If the function succeeds, the return value is nonzero (TRUE).
 *                  If the function fails, or is completing asynchronously, the return value is zero (FALSE).
 *                  To get extended error information, call the GetLastError function.
 *                  Note
 *                  The GetLastError code ERROR_IO_PENDING is not a failure;
 *                   it designates the read operation is pending completion asynchronously.
 */
int comport::receiver(int siMsgFmt, const char* pStopper)
{
    int             rc = RET_FAILED;
    int             ret_ec;
    std::wstring	wstr_emsg = L"";
    bool            flg_recv = true;

    BOOL    ret_wlib;
    DWORD   rdbytes = 0;
    DWORD   evt = 0x00000000;

    const char*     pfound = (char*)0;
    int             offset_cur = 0;
    int             status = 0;
    int             zero_byte = 0;

    // new, delete
    ecode* pec = (ecode*)0;
    unsigned char* ptmpbuff = (unsigned char*)0;

    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eCCM, "receiver(%d,..)>>>", siMsgFmt);

    ptmpbuff = new unsigned char[DMSG_BUFFSIZE];
    if (ptmpbuff == (unsigned char*)0) {
        ecode	retobj(ecode::eVALUE::eNEW, __FUNCTION__, "0 = new unsigned char[DMSG_BUFFSIZE]");
        retobj.output();
        rc = retobj.rc();								// 戻り値に変換
        return rc;
    }

#if 1
    // 以下の設定があれば、USBシリアル抜き差し直後のReadFile()がフリーズしない
    COMMTIMEOUTS    tmo;

    ::GetCommTimeouts(mHandle, &tmo);
    tmo.ReadIntervalTimeout = 10;                       // 9600bps/1000msec
    tmo.ReadTotalTimeoutMultiplier = 3;                 // タイムアウト 3 * 100
    tmo.ReadTotalTimeoutConstant = 100;                 // タイムアウト 3 * 100
    ::SetCommTimeouts(mHandle, &tmo);
#endif

    // #define EV_RXCHAR           0x0001  // Any Character received
    // #define EV_ERR              0x0080  // Line status error occurred

    ret_wlib = ::SetCommMask(mHandle, EV_ERR | EV_RXCHAR | EV_RXFLAG);
    if (ret_wlib == FALSE) {
        // If the function succeeds, the return value is nonzero.
        // If the function fails, the return value is zero. To get extended error information, call GetLastError.

        ret_ec = winec::get_emsg(wstr_emsg);            // Winエラーコード取得
        std::wstring wstr_tmp = L"Failed SetCommMask()..,";
        wstr_tmp += wstr_emsg;

        pec = new ecode(ecode::eVALUE::eSETCOMMSTATE, __FUNCTIONW__, wstr_tmp);
        pec->output();
        rc = pec->rc();
        goto EXIT_METHOD;
    }

    //
    // メッセージ待ち  https://docs.microsoft.com/en-us/windows/win32/devio/monitoring-communications-events
    //
    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eCCM, "WaitCommEvent(%p, %#x)", mHandle, evt);

    ret_wlib = ::WaitCommEvent(mHandle, &evt, (LPOVERLAPPED)0);
    if (ret_wlib == FALSE) {
        // If the function succeeds, the return value is nonzero.
        // If the function fails, the return value is zero. To get extended error information, call GetLastError.

        ret_ec = winec::get_emsg(wstr_emsg);        // Winエラーコード取得
        std::wstring wstr_tmp = L"Failed WaitCommEvent()..,";
        wstr_tmp += wstr_emsg;

        pec = new ecode(ecode::eVALUE::eSETCOMMSTATE, __FUNCTIONW__, wstr_tmp);
        pec->output();
        rc = pec->rc();
        goto EXIT_METHOD;
    }

    if ((evt & EV_ERR) != 0x00000000) {                 // シリアル通信異常検知
        pec = new ecode(ecode::eVALUE::eWAITCOMMEVENT, __FUNCTION__, "(evt & EV_ERR) != 0x00000000");
        pec->output();
        rc = pec->rc();                                 // 戻り値に変換
        goto EXIT_METHOD;
    }

    //
    // 1回目受信処理
    //  ESTATUS::eWait => eRecv => eFailSafe
    //  あるいは、ESTATUS::eWait => eFailSafe
    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eCCM, "ReadFile(%p,..)", mHandle);

    status = ESTATUS::eWait;
    ::memset(mpBuffer, 0x00, DMSG_BUFFSIZE);
    while ((status == ESTATUS::eWait) || (status == ESTATUS::eRecv)) {
        // 一度、受信するとCPUを占有して、ループする(ReadFile()とsleep()を併用しない)
        ::memset(ptmpbuff, 0x00, DMSG_BUFFSIZE);
        rdbytes = 0;
        ret_wlib = ::ReadFile(mHandle,                  // [in]  A handle to the device
                                ptmpbuff,               // [out] A pointer to the buffer that receives the data read from a file or device.
                                DMSG_BUFFSIZE,          // [in]  The maximum number of bytes to be read.
                                &rdbytes,               // [out, optional]     A pointer to the variable that receives the number of bytes read when using a synchronous hFile parameter.
                                (LPOVERLAPPED)0);       // [in, out, optional] A pointer to an OVERLAPPED structure
        if (ret_wlib == FALSE) {
            // ERROR_IO_PENDING
            // ReadFile may return before the read operation is complete.
            // In this scenario, ReadFile returns FALSE and the GetLastError function returns ERROR_IO_PENDING,
            //  which allows the calling process to continue while the system completes the read operation.

            ret_ec = winec::get_emsg(wstr_emsg);        // Winエラーコード取得

            if (ret_ec != ERROR_IO_PENDING) {
                std::wstring wstr_tmp = L"Failed ReadFile()..,";
                wstr_tmp += wstr_emsg;

                pec = new ecode(ecode::eVALUE::eREADFILE, __FUNCTIONW__, wstr_tmp);
                pec->output();
                rc = pec->rc();
                break;                                  // ポート初期化要
            }
        }
        else {
            LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eCCM, "%d = ReadFile1(.., %d)", ret_wlib, rdbytes);
            if (rdbytes > 0) {                          // メッセージ受信あり
                // strstr()をcallするので、NULL終端(念のため)
                // ptmpbuff + rdbytesはバッファオーバーランしない
                // メッセージ長は2KiB
                *(ptmpbuff + rdbytes) = 0x00;
                ::memcpy((void*)(mpBuffer + offset_cur), (void*)ptmpbuff, (size_t)rdbytes);
                offset_cur += rdbytes;                  // ローカルバッファにコピー

                // END文字列検索
                pfound = ::strstr((const char*)ptmpbuff, (const char*)pStopper);
                if (pfound) {                           // 最終ブロック(暫定)
#ifdef DBG_RCV_ZEROBYTE
                    // メッセージフォーマット
                    //  0: 大阪以外 END文字列がメッセージ終端
                    //  1: 大阪     END文字列後に可変長メッセージが付加される
                    //  2～TBD
                    if (siMsgFmt == 0) {
                        status = ESTATUS::eEXIT;
                    }
                    else {
                        status = ESTATUS::eFailSafe;
                    }
#else
                    // 最新仕様書では、メッセージ終端にCRLFがつく。CRLF検知時、受信処理終了
                    status = ESTATUS::eEXIT;
#endif
                }
                else {                                  // 1ブロック目～nブロック目
                    status = ESTATUS::eRecv;            // 受信中
                }
            }
            else {                                      // メッセージ受信なし
                zero_byte++;
                if (zero_byte >= ERR_ZEROBYTE) {
                    status = ESTATUS::eERROR;
                    msiMsgSize = 0;
                    break;
                }
                continue;                               // フェイルセーフ
            }
        }   // if (ret_wlib == FALSE)
    }       // while(status != ESTATUS::eFailSafe)

    if (status == ESTATUS::eERROR) {
        pec = new ecode(ecode::eVALUE::eREADFILE, __FUNCTION__, "status == ESTATUS::eERROR");
        pec->output();
        rc = pec->rc();                                 // 戻り値に変換
        goto EXIT_METHOD;
    }
    else if (status == ESTATUS::eEXIT) {
        // 誤ってsiMsgFmt = 0を指定後、実際に受信したメッセージが大阪仕様で、
        // 受信バッファ内にEND以降の文字列が混入していても、メッセージ異常とはしない。
        rc = offset_cur;
        msiMsgSize = rc;
    }

#ifdef DBG_RCV_ZEROBYTE
    // フェイルセーフ
    //  eFailSafeステータスで、受信レングス0byteを3回検知したなら、受信処理終了
    //  日本ペイントメッセージはEND文字列直後にパラメータが3項目継続する。
    //  全体長が不明なので、まずはEND文字列を待つ。END文字列受信後は受信なしを3回検知。

    //  もし、END文字列検知後、受信なしを1回検知
    //  2回目の受信なしを期待したところで、新規メッセージを受信した場合は結合してしまう。
    zero_byte = 0;
    while (status == ESTATUS::eFailSafe) {
        ::memset(ptmpbuff, 0x00, DMSG_BUFFSIZE);
        rdbytes  = 0;
        ret_wlib = ::ReadFile(mHandle, ptmpbuff, DMSG_BUFFSIZE, &rdbytes, (LPOVERLAPPED)0);
        if (ret_wlib == FALSE) {
            ret_ec = winec::get_emsg(wstr_emsg);        // Winエラーコード取得
            if (ret_ec != ERROR_IO_PENDING) {
                std::wstring wstr_tmp = L"Failed ReadFile2()..,";
                wstr_tmp += wstr_emsg;

                pec = new ecode(ecode::eVALUE::eREADFILE, __FUNCTIONW__, wstr_tmp);
                pec->output();
                rc = pec->rc();
                break;                                  // ポート初期化要
            }
        }
        else {
            LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eCCM, "%d = ReadFile2(.., %d)", ret_wlib, rdbytes);
            if (rdbytes > 0) {                          // メッセージ受信あり
                ::memcpy((void*)(mpBuffer + offset_cur), (void*)ptmpbuff, (size_t)rdbytes);
                offset_cur += rdbytes;                  // ローカルバッファにコピー
            }
            else {                                      // メッセージ受信なし
                zero_byte++;
                if (zero_byte >= CNT_ZEROBYTE) {
                    status = ESTATUS::eEXIT;
                    rc = offset_cur;
                    msiMsgSize = rc;
                }
                continue;
            }
        }
    }   // while(status == ESTATUS::eFailSafe)
#endif  /* #ifdef DBG_RCV_ZEROBYTE */

EXIT_METHOD:
    if (ptmpbuff) { delete[] ptmpbuff; }
    if (pec) { delete pec; }

    if (mHandle != INVALID_HANDLE_VALUE) {
        ::CloseHandle(mHandle);
        mHandle = INVALID_HANDLE_VALUE;
    }
    LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eCCM, "receiver()<<< %d bytes/EC", rc);
    return rc;
}

/*!
 * @file			comport.cpp
 * @fn              int comport::getmsg(std::string& rString)
 * @brief           受信メッセージ取得
 * @details         受信メッセージ取得
 * @return          0 <  VALUE: TBD
 *                  0 == VALUE: TBD
 *                  0 >  VALUE: 受信メッセージ長
 * @param[out]      rString: 受信メッセージ
 * @date            2022/4/19
 * @note            ***
 */
size_t comport::getmsg(std::string& rString)
{
    std::string str_work;
    str_work.resize(msiMsgSize);
    str_work = mpBuffer;
    rString  = str_work;

    return rString.size();
}
