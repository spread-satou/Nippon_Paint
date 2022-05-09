#include "pch.h"
#include "ccm.h"
#include "ecode.h"
#include "util_ccmstr.h"
#include "util_strtok.h"
#include <sstream>

////////////////////////////////////////////////////////
ccm_property::ccm_property()
{
    this->initialize();
}

ccm_property::ccm_property(int siCheck, int siSize, bool bFix, unsigned char* pBinary)
{
    this->initialize();
}

ccm_property::~ccm_property()
{

}

int ccm_property::initialize(void)
{
    this->variables();
    return RET_SUCCESS;
}

int ccm_property::variables(void)
{
    //msiCheck = -1;
    mbFix    = false;
    msiAttr  = -1;
    msiSize  = -1;
    mString.clear();                                    // (unsigned char*)0;

    return RET_SUCCESS;
}

void ccm_property::setter(int siSize, int siAttr, bool bFix, unsigned char* pBinary)
{
    mbFix   = bFix;
    msiSize = siSize;
    msiAttr = siAttr;
}

void ccm_property::set_string(std::string& rValue)
{
    mString = rValue;
}

int ccm_property::get_string(std::string& rValue)
{
    //std::stringstream ss;
    //ss << mpBinary;
    //rValue = ss.str();

    rValue = mString;
    return RET_SUCCESS;
}

/*!
 * @file		    ccm.cpp
 * @fn			    int ccm_property::inspector(void)
 * @brief		    CCMデータ検査
 * @details		    CCMデータ検査
 * @return		    0 >  Return value: TBD
 * 				    0 == Return value: NG (no good)
 * 				    0 <  Return value: OK (good)
 * @param[in, out]	void
 * @date		    1970/5/4
 * @note        
 */
int ccm_property::inspector(unsigned char* pBuffer)
{
    using namespace utility;

    int     rc = RET_NOGOOD;
    size_t  szmax = 255;                                // 暫定
    size_t  szlen = 0;

    szlen = ::strnlen(mString.c_str(), szmax);
    if (mbFix == true) {                                // 固定長
        if (szlen != msiSize) {                         // 実レングスと期待値に差異があれば
            return RET_NOGOOD;                          // 異常
        }
    }
    else {                                              // 可変長
        // 可変長文字列の文字列長ゼロは許容
        if (szlen == 0) {
            return RET_GOOD;                            // 正常
        }

        if (msiSize == -1) {                            // 最大長不明の可変長
            ;                                           // チェック不要(不可)
        }
        else {                                          // 最大長が確定している可変長
            if (szlen > msiSize) {                      // 実レングスのほうが大きい
                return RET_NOGOOD;                      // 異常
            }
        }
    }

    // TBD: good()の引数に固定長/可変長が必要なのか
    switch (msiAttr) {
    case PROPERTY_ATTR_KAN:                             // 缶種(固定長)
        rc = canstr::good((unsigned char*)mString.c_str(), szlen, msiSize, mbFix);
        break;
    case PROPERTY_ATTR_PROCODE:                         // 製品コード(固定長)
        rc = productstr::good((unsigned char*)mString.c_str(), szlen, msiSize, mbFix);
        break;
    case PROPERTY_ATTR_3POINT:                          // 小数点3桁未満
        rc = pointstr::good((unsigned char*)mString.c_str(), szlen, msiSize, mbFix);
        break;
    case PROPERTY_ATTR_END:                             // END(固定長)
        rc = endstr::good((unsigned char*)mString.c_str(), szlen, msiSize, mbFix);
        break;
    case PROPERTY_ATTR_ALPHA:                           // 半角英数
        rc = ankstr::good((unsigned char*)mString.c_str(), szlen, msiSize, mbFix);
        break;
    case PROPERTY_ATTR_NUMERIC:                         // 数値文字列
        rc = digitstr::good((unsigned char*)mString.c_str(), szlen, msiSize, mbFix);
        break;
    case PROPERTY_ATTR_UNKNOWN:                         // チェック不要
        rc = RET_GOOD;
    default:
        break;
    }

    return rc;
}

////////////////////////////////////////////////////////
ccm_buffer::ccm_buffer()
{
    this->initialize();
}

ccm_buffer::ccm_buffer(int siMsgFmt)
{
    this->initialize(siMsgFmt);
}

ccm_buffer::~ccm_buffer()
{
    if (mpBuffer) {
        delete[] mpBuffer;
        mpBuffer = (unsigned char*)0;
    }
}

int ccm_buffer::initialize(int siMsgFmt)
{
    int rc;

    rc = this->variables(siMsgFmt);

    mvData[EMEMBER::eKan]->setter(PROPERTY_SIZE_KAN, PROPERTY_ATTR_KAN, true);                  //! 缶種
    mvData[EMEMBER::eRev]->setter(PROPERTY_SIZE_REV, PROPERTY_ATTR_NUMERIC, false/*最大2byte*/);//! 改訂
    mvData[EMEMBER::eProdName]->setter(PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_UNKNOWN, false);    //! 製品名
    mvData[EMEMBER::eProdCode]->setter(PROPERTY_SIZE_PROCODE, PROPERTY_ATTR_PROCODE, true);     //! 製品コード
    mvData[EMEMBER::ePainName]->setter(PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_UNKNOWN, false);    //! 塗料名
    // 6-7
    mvData[EMEMBER::eWHCode]->setter(   PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_UNKNOWN, false);   //! ホワイトコード
    mvData[EMEMBER::eWHWeight]->setter( PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_3POINT, false);    //! ホワイト重量
    // 8-17
    mvData[EMEMBER::eColorant01]->setter(PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_UNKNOWN, false);  //! 着色剤コード1
    mvData[EMEMBER::eWeghit01]->setter(  PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_3POINT, false);   //! 重量1
    mvData[EMEMBER::eColorant02]->setter(PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_UNKNOWN, false);  //! 着色剤コード
    mvData[EMEMBER::eWeghit02]->setter(  PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_3POINT, false);   //! 重量
    mvData[EMEMBER::eColorant03]->setter(PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_UNKNOWN, false);  //! 着色剤コード
    mvData[EMEMBER::eWeghit03]->setter(  PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_3POINT, false);   //! 重量
    mvData[EMEMBER::eColorant04]->setter(PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_UNKNOWN, false);  //! 着色剤コード
    mvData[EMEMBER::eWeghit04]->setter(  PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_3POINT, false);   //! 重量
    mvData[EMEMBER::eColorant05]->setter(PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_UNKNOWN, false);  //! 着色剤コード
    mvData[EMEMBER::eWeghit05]->setter(  PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_3POINT, false);   //! 重量
    // 18-27
    mvData[EMEMBER::eColorant06]->setter(PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_UNKNOWN, false);  //! 着色剤コード
    mvData[EMEMBER::eWeghit06]->setter(  PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_3POINT, false);   //! 重量
    mvData[EMEMBER::eColorant07]->setter(PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_UNKNOWN, false);  //! 着色剤コード
    mvData[EMEMBER::eWeghit07]->setter(  PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_3POINT, false);   //! 重量
    mvData[EMEMBER::eColorant08]->setter(PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_UNKNOWN, false);  //! 着色剤コード
    mvData[EMEMBER::eWeghit08]->setter(  PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_3POINT, false);   //! 重量
    mvData[EMEMBER::eColorant09]->setter(PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_UNKNOWN, false);  //! 着色剤コード
    mvData[EMEMBER::eWeghit09]->setter(  PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_3POINT, false);   //! 重量
    mvData[EMEMBER::eColorant10]->setter(PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_UNKNOWN, false);  //! 着色剤コード
    mvData[EMEMBER::eWeghit10]->setter(  PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_3POINT, false);   //! 重量
    // 28-37
    mvData[EMEMBER::eColorant11]->setter(PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_UNKNOWN, false);  //! 着色剤コード
    mvData[EMEMBER::eWeghit11]->setter(  PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_3POINT, false);   //! 重量
    mvData[EMEMBER::eColorant12]->setter(PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_UNKNOWN, false);  //! 着色剤コード
    mvData[EMEMBER::eWeghit12]->setter(  PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_3POINT, false);   //! 重量
    mvData[EMEMBER::eColorant13]->setter(PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_UNKNOWN, false);  //! 着色剤コード
    mvData[EMEMBER::eWeghit13]->setter(  PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_3POINT, false);   //! 重量
    mvData[EMEMBER::eColorant14]->setter(PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_UNKNOWN, false);  //! 着色剤コード
    mvData[EMEMBER::eWeghit14]->setter(  PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_3POINT, false);   //! 重量
    mvData[EMEMBER::eColorant15]->setter(PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_UNKNOWN, false);  //! 着色剤コード
    mvData[EMEMBER::eWeghit15]->setter(  PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_3POINT, false);   //! 重量
    // 38-45
    mvData[EMEMBER::eColorant16]->setter(PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_UNKNOWN, false);  //! 着色剤コード
    mvData[EMEMBER::eWeghit16]->setter(  PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_3POINT, false);   //! 重量
    mvData[EMEMBER::eColorant17]->setter(PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_UNKNOWN, false);  //! 着色剤コード
    mvData[EMEMBER::eWeghit17]->setter(  PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_3POINT, false);   //! 重量
    mvData[EMEMBER::eColorant18]->setter(PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_UNKNOWN, false);  //! 着色剤コード
    mvData[EMEMBER::eWeghit18]->setter(  PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_3POINT, false);   //! 重量
    mvData[EMEMBER::eColorant19]->setter(PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_UNKNOWN, false);  //! 着色剤コード
    mvData[EMEMBER::eWeghit19]->setter(  PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_3POINT, false);   //! 重量
    // 46-50
    mvData[EMEMBER::eGrossWeight]->setter(PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_3POINT, false);  //! 総重量
    mvData[EMEMBER::eTerm]->setter(     PROPERTY_SIZE_END, PROPERTY_ATTR_END, true);            //! ターミネータ

    if (siMsgFmt) {
        mvData[EMEMBER::eFilename]->setter(PROPERTY_SIZE_FNAME, PROPERTY_ATTR_ALPHA, true);     //! 既調色ファイル名
        mvData[EMEMBER::eIndex]->setter(PROPERTY_SIZE_INDEX, PROPERTY_ATTR_NUMERIC, false);     //! 目次番号
        mvData[EMEMBER::eLineName]->setter(PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_ALPHA, false);  //! ライン名
    }

    return rc;
}

int ccm_buffer::variables(int siMsgFmt)
{
    mpBuffer = (unsigned char*)0;
    msiDataSize = 0;

    int ii;
    int loop_num = (siMsgFmt != 0)? PARAM_OOSAKA_NUM : PARAM_DEFAULT_NUM;

    mvData.clear();
    for (ii = 0; ii < loop_num; ii++) {
        mvData.push_back(new ccm_property(PROPERTY_INIT, PROPERTY_SIZE_UNKNOWN, false));
    }
   
    return RET_SUCCESS;
}

int ccm_buffer::bufclear(void)
{
    ::memset(mpBuffer, 0x00, msiDataSize);
    return RET_SUCCESS;
}

/*!
 * @file		    ccm.cpp
 * @fn			    int ccm_buffer::memupdate(unsigned char* pRcvmsg, int siLength)
 * @brief		    CCMデータ更新
 * @details		    CCMデータ更新
 * @return		    0 >  Return value: 失敗
 * 				    0 == Return value: updateなし
 * 				    0 <  Return value: updateあり
 * @param[in]	    pRcvmsg         受信データ
 * @param[in]	    siLength        受信データサイズ
 * @date		    2022/5/4
 * @note            ORD(FTP)は取り込み済のORDは取り込まない。
 *                  ORDのmemupdate()では、取り込み済判定のため、サーバー内のORDファイルとローカルPCのORDファイルを比較する。
 *                  CCMは受信したメッセージを必ず、取り込むため、比較しない。
 */
int ccm_buffer::memupdate(unsigned char* pRcvmsg, size_t siLength)
{
    using namespace utility;

    int rc  = RET_SUCCESS;
    int ret = RET_SUCCESS;
    int ii = 0;
    std::vector<ccm_property*>::iterator iter;
    std::vector<std::string>    vparams;
    std::string                 str;
    // new, delete
	ecode*	pec = (ecode*)0;

    if (pRcvmsg == (unsigned char*)0) {
		pec = new ecode(ecode::eVALUE::eARG_NULL, __FUNCTION__, "pRcvmsg == 0");
		pec->output();
		rc = pec->rc();						            // 戻り値に変換
		goto EXIT_FUNCTION;
    }

    if (mpBuffer != (unsigned char*)0) {
        delete[] mpBuffer;
    }

    mpBuffer = new unsigned char[siLength];
    ::memcpy(mpBuffer, pRcvmsg, siLength);
    msiDataSize = siLength;

    // カンマ区切りのmpBufferをvparamsへ
    // パラメータ未指定の"" は無視 → strtok::splitter(vparams, (const char*)mpBuffer, msiDataSize, ",");
    strparam::splitter(vparams, (const char*)mpBuffer, msiDataSize, ",");

    // mvData更新
    // カンマで区切られたパラメータの順と
    // mvData[]の要素の順が一致していることが大前提
    if (vparams.size() != mvData.size()) {
        pec = new ecode(ecode::eVALUE::eSIM_PARAM_NUMERR, __FUNCTION__, "vparams.size() != mvData.size()");
        pec->output();
        rc = pec->rc();						            // 戻り値に変換
        goto EXIT_FUNCTION;
    }

    // カンマで区切られたパラメータは仕様書に記載されている
    // 仕様書とmvData[]は一致しているはずなので、大前提は保証されている(はず)
    for (iter = mvData.begin(); iter != mvData.end(); iter++) {
        (*iter)->set_string(vparams[ii]);
        ii++;
    }

EXIT_FUNCTION:
    if (pec) {delete pec;}

    return rc;
}

/*!
 * @file		    ccm.cpp
 * @fn			    int ccm_buffer::inspector(void)
 * @brief		    CCMデータ検査
 * @details		    CCMデータ検査
 * @return		    0 >  Return value: 失敗
 * 				    0 == Return value: 成功
 * 				    0 <  Return value: TBD
 * @param[in, out]	void
 * @date		    2022/5/5
 * @note        
 */
int ccm_buffer::inspector(void)
{
    int rc = RET_SUCCESS;
    int ret_wk = RET_SUCCESS;
    int dbg_no = 0;

    std::vector<ccm_property*>::iterator iter;

    for (iter = mvData.begin(); iter != mvData.end(); iter++) {
        dbg_no++;
        ret_wk = (*iter)->inspector();
        if (ret_wk == RET_NOGOOD) {                     // NGなら
            rc = RET_FAILED;
        }
    }

    return rc;
}