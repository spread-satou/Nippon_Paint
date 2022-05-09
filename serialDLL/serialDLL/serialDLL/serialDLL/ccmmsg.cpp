#include "pch.h"
#include "ccmmsg.h"
#include "ccm.h"
#include "dbglog.h"
#include "ecode.h"
#include "winec.h"
#include "util_strtok.h"
#include <memory.h>

ccmmsg::ccmmsg()
{
    this->initialize();
}

/*!
 * @file			ccmmsg.cpp
 * @fn              ccmmsg::ccmmsg(LPCTSTR lpName)
 * @brief           コンストラクタ
 * @details         リソース初期化
 * @return          エラーコードをthrow
 * @param[in,out]   void
 * @date            2022/4/18
 * @note
 */
//ccmmsg::ccmmsg(LPCTSTR lpName)
ccmmsg::ccmmsg(const char* pPort)
{
    int     rc = RET_FAILED;
    // new, delete
    ecode   *pec = (ecode*)0;

    rc = this->initialize();
    if (rc < 0) {
        throw rc;
    }

    mpCom = new comport(pPort);
    if (mpCom == (comport*)0) {
        ecode	retobj(ecode::eVALUE::eNEW, __FUNCTION__, "0 = new comport(""COM5"")");
        retobj.output();
        rc = retobj.rc();								// 戻り値に変換
        throw rc;
    }
}

ccmmsg::~ccmmsg()
{
    if (mpCom) {
        delete mpCom;
        mpCom = (comport*)0;
    }
}

/*!
 * @file			ccmmsg.cpp
 * @fn              int ccmmsg::initialize()
 * @brief           初期化
 * @details         リソース初期化
 * @return          0 <  VALUE: TBD
 *                  0 == VALUE: 成功
 *                  0 >  VALUE: TBD
 * @param[in,out]   void
 * @date            2022/4/18
 * @note            
 */
int ccmmsg::initialize()
{
    int rc = RET_SUCCESS;

    rc = this->variables();
    return rc;
}

/*!
 * @file			ccmmsg.cpp
 * @fn              int ccmmsg::variables()
 * @brief           初期化
 * @details         無効値設定
 * @return          0 <  VALUE: TBD
 *                  0 == VALUE: 成功
 *                  0 >  VALUE: TBD
 * @param[in,out]   void
 * @date            2022/4/18
 * @note            
 */
int ccmmsg::variables(void)
{
    mpCom = (comport*)0;
    return RET_SUCCESS;
}

/*!
 * @file			ccmmsg.cpp
 * @fn              int ccmmsg::setdcb(DCB& rDCB)
 * @brief           DCB(Device control block)初期化
 * @details         COMポート初期化
 * @return          0 <  VALUE: エラーコード
 *                  0 == VALUE: 成功
 *                  0 >  VALUE: TBD
 * @param[in]       rDCB: Device control block
 * @date            2022/4/18
 * @note            
 */
int ccmmsg::setdcb(DCB& rDCB)
{
    int rc = RET_SUCCESS;
    DCB local_dcb;

    rc = mpCom->initdcb(local_dcb);
    if (rc < 0) {
        return rc;
    }

    local_dcb.BaudRate = rDCB.BaudRate;
    local_dcb.ByteSize = rDCB.ByteSize;
    local_dcb.StopBits = rDCB.StopBits;
    local_dcb.Parity   = rDCB.Parity;
    local_dcb.fOutxCtsFlow = rDCB.fOutxCtsFlow;
    local_dcb.fOutxDsrFlow = rDCB.fOutxDsrFlow;
    local_dcb.fDtrControl  = rDCB.fDtrControl;
    local_dcb.fRtsControl  = rDCB.fRtsControl;

    rc = mpCom->setdcb(local_dcb);
    if (rc < 0) {
        return rc;
    }

    return RET_SUCCESS;
}

/*!
 * @file			ccmmsg.cpp
 * @fn              int ccmmsg::receiver(std::vector<std::string>& rvParams)
 * @brief           CCMメッセージ受信(バイナリモード)
 * @details         CCMメッセージ受信(バイナリモード)
 * @return          0 <  VALUE: エラーコード(ポート初期化要)
 *                  0 == VALUE: 受信レングス
 *                  0 >  VALUE: TBD
 * @param[out]      rvParams: カンマ区切りパラメータ
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
int ccmmsg::receiver(int siMsgFmt, std::vector<std::string>& rvParams)
{
    //int rc = mpCom->receiver(siMsgFmt, "END");
    int rc = mpCom->receiver(siMsgFmt, "\x0d\x0a");
    if (rc > 0) {
        std::vector<std::string> vparams;
        std::size_t sz;
        std::size_t pos_found;
        std::string str_msg;
        int         cmp = 0;
        //const char* pccmmsg = mpCom->get_pointer();

        mpCom->getmsg(str_msg);
        pos_found = str_msg.find("\x0d\x0a");
        if (pos_found == std::string::npos) {
            return RET_FAILED;
        }
        else {
            sz = str_msg.size();
            if ((pos_found + 2) == sz) {
                cmp = str_msg.compare(pos_found, 2, "\x0d\x0a");
                if (cmp != 0) {
                    return RET_FAILED;
                }
                else {
                    str_msg.erase(pos_found, 2);
                }
            }
        }
#if 1
        ccm_buffer* pccm = (ccm_buffer*)0;

        pccm = new ccm_buffer(siMsgFmt);
        rc = pccm->memupdate((unsigned char*)str_msg.c_str(), str_msg.size());
        if (rc != RET_SUCCESS) {
            return rc;
        }

        rc = pccm->inspector();
        if (rc != RET_SUCCESS) {
            return rc;
        }
#endif

        utility::strparam::splitter(vparams, /*pccmmsg*/str_msg.c_str(), rc, ",");
        sz = vparams.size();
        rvParams.resize(sz);
        std::copy(vparams.begin(), vparams.end(), rvParams.begin());
    }
    return rc;
}

size_t ccmmsg::getmsg(std::string& rString)
{
    std::string str_work;

    mpCom->getmsg(str_work);

    //str_work.resize(msiMsgSize);
    //str_work = mpBuffer;

    rString = str_work;
    return rString.size();
}

