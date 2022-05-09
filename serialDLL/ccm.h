#pragma once
#include <string>
#include <vector>
#include "ecode.h"

#define PROPERTY_INIT               -1
#define PARAM_DEFAULT_NUM           47
#define PARAM_OOSAKA_NUM            50

#define PROPERTY_ATTR_UNKNOWN       -1                  // チェック不要
#define PROPERTY_ATTR_KAN           0                   // 缶種
#define PROPERTY_ATTR_PROCODE       2                   // 製品コード
#define PROPERTY_ATTR_3POINT        3                   // 小数点3桁未満
#define PROPERTY_ATTR_END           4                   // END
#define PROPERTY_ATTR_ALPHA         5                   // 半角英数
#define PROPERTY_ATTR_NUMERIC       6                   // 数値

#define PROPERTY_SIZE_UNKNOWN       -1                  //! 最大長不明
#define PROPERTY_SIZE_KAN           1                   //! 缶種
#define PROPERTY_SIZE_REV           2                   //! 改訂
#define PROPERTY_SIZE_PROCODE       2                   //! 製品コード
#define PROPERTY_SIZE_END           3                   //! END文字列
#define PROPERTY_SIZE_FNAME         2                   //! CCMファイル名
#define PROPERTY_SIZE_INDEX         4                   //! 目次番号


#define EMEMBER         (int)ccm_fmt::eMEMBERS

struct ccm_property {                                   //! 属性構造体
public:
    //int     msiCheck;                                   //! -1:未チェック(初期値)

    // -1:属性チェック不要
    //  0:缶種チェック
    //  1:欠番
    //  2:製品コード
    //  3:小数点3桁未満文字列
    //  4:END文字列
    //  5:半角英数
    //  6:数値文字列
    int     msiAttr;                                    //! 属性
    int     msiSize;                                    //! -1: 最大長不明, チェックサイズ(期待値)
    bool    mbFix;                                      //! true: 固定長, false: 可変長

    // ORDはポインタ変数, CCMはstring
    std::string mString;                                //unsigned char* mpBinary;

    ccm_property();
    ccm_property(int siCheck, int siSize, bool bFix, unsigned char* pBinary = 0);
    ~ccm_property();

    int initialize(void);

    void setter(int siSize, int siAttr, bool bFix, unsigned char* pBinary = 0);
    //void setter(int siSize, int siAttr);
    //void set_addr(unsigned char* pBinary);

    void set_string(std::string& rString);
    int  get_string(std::string& rValue);
    int  get_size(void) {
        if (!mString.empty()) {
            return (int)mString.size();
        }
        return msiSize;
    };
    int  inspector(unsigned char* pBuffer = 0);

protected:
    int variables(void);
};

struct ccm_fmt {
    static int strcpy(std::string& rDst, size_t& rSize, const char* pData, size_t szMax)
    {
        size_t  szlen;
        char*   pwork = (char*)0;

        szlen = ::strnlen(pData, szMax);
        pwork = new char[szlen + 1];
        ::memcpy(pwork, pData, szlen);
        *(pwork + szlen) = 0x00;

        rDst.clear();
        rDst = pwork;
        return RET_SUCCESS;
    }
public:
    enum class eMEMBERS {                               //! 項目名構造体
        // 1-5
        eKan,                                           //! 缶種
        eRev,                                           //! 改訂
        eProdName,                                      //! 製品名
        eProdCode,                                      //! 製品コード
        ePainName,                                      //! 塗料名
        // 6-7
        eWHCode,                                        //! ホワイトコード
        eWHWeight,                                      //! ホワイト重量
        // 8-17
        eColorant01,                                    //! 着色剤コード1
        eWeghit01,                                      //! 重量1
        eColorant02,                                    //! 着色剤コード
        eWeghit02,                                      //! 重量
        eColorant03,                                    //! 着色剤コード
        eWeghit03,                                      //! 重量
        eColorant04,                                    //! 着色剤コード
        eWeghit04,                                      //! 重量
        eColorant05,                                    //! 着色剤コード
        eWeghit05,                                      //! 重量
        // 18-27
        eColorant06,                                    //! 着色剤コード
        eWeghit06,                                      //! 重量
        eColorant07,                                    //! 着色剤コード
        eWeghit07,                                      //! 重量
        eColorant08,                                    //! 着色剤コード
        eWeghit08,                                      //! 重量
        eColorant09,                                    //! 着色剤コード
        eWeghit09,                                      //! 重量
        eColorant10,                                    //! 着色剤コード
        eWeghit10,                                      //! 重量
        // 28-37
        eColorant11,                                    //! 着色剤コード
        eWeghit11,                                      //! 重量
        eColorant12,                                    //! 着色剤コード
        eWeghit12,                                      //! 重量
        eColorant13,                                    //! 着色剤コード
        eWeghit13,                                      //! 重量
        eColorant14,                                    //! 着色剤コード
        eWeghit14,                                      //! 重量
        eColorant15,                                    //! 着色剤コード
        eWeghit15,                                      //! 重量
        // 38-45
        eColorant16,                                    //! 着色剤コード
        eWeghit16,                                      //! 重量
        eColorant17,                                    //! 着色剤コード
        eWeghit17,                                      //! 重量
        eColorant18,                                    //! 着色剤コード
        eWeghit18,                                      //! 重量
        eColorant19,                                    //! 着色剤コード
        eWeghit19,                                      //! 重量
        // 46-50
        eGrossWeight,                                   //! 総重量
        eTerm,                                          //! ターミネータ
        eFilename,                                      //! 既調色ファイル名
        eIndex,                                         //! 目次番号
        eLineName,                                      //! ライン名
        eNUMB
    };
};

class ccm_buffer
{
protected:
    unsigned char*  mpBuffer;                           //! 最新ダウンロードデータ
    size_t          msiDataSize;                        //! 最新ダウンロードデータバッファサイズ

    // CCMファイル(mpLatestData)の各パラメータを検査する
    // mpLatestDataをdeleteしたなら、initialize()をcallしすること。
    // ord_property::inspector()実行時、mpLatestDataへの不正アクセスが発生するため。
    std::vector<ccm_property*>      mvData;             //! チェックデータ

public:
    ccm_buffer();
    ccm_buffer(int siMsgFmt);
    ~ccm_buffer();

    int initialize(int siMsgFmt = 0/*ENDまで*/);

    // データフロー
    // 1. 1行テキスト
    // 2. vevtor<string>        カンマで分割して、vevtor<string>にpush
    // 3. vector<ccm_property*> 2のvevtor<string>をvector<ccm_property*>にpush

    int bufclear(void);
    int memupdate(unsigned char* pRcvmsg, size_t siLength);
    int inspector(void);

//    int splitter(std::vector<std::string>& rParams, const char* pParameters, size_t szLength);
protected:
    int variables(int siMsgFmt = 0/*ENDまで*/);
};

