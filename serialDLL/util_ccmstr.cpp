#include "pch.h"
#include "util_ccmstr.h"
#include "ecode.h"
#include <cctype>
#include <errno.h>
#include <string.h>
#include <iostream>
#include <mbctype.h>


namespace utility {
////////////////////////////////////////////////////////////////////////////////
canstr::canstr()
{

}

canstr::~canstr()
{

}

/*!
 * @file		    util_ccmstr.cpp
 * @fn			    int canstr::good(char* pBuffer, int szMsgLength, int siChkSize, bool bFixSize)
 * @brief		    缶種文字列検査(固定長1byte)
 * @details		    0＝空缶；1＝白入缶；9＝修正缶
 * @return		    0 >  Return value: TBD
 * 				    0 == Return value: 缶種文字列でない
 * 				    0 <  Return value: 缶種文字列
 * @param[in]       pBuffer         文字列バッファ
 * @param[in]       szMsgLength     文字列長
 * @param[in]       siChkSize       文字列長(期待値)
 * @date		    2022/5/4
 * @note            ***         
 */
int canstr::good(unsigned char* pBuffer, size_t szMsgLength, int siChkSize, bool bFixSize)
{
    int     rc = RET_GOOD;

    if (szMsgLength != siChkSize) {
        return RET_NOGOOD;                              // NG
    }

    switch(*pBuffer) {
    case '0':
    case '1':
    case '9':
        break;
    default:
        rc = RET_NOGOOD;                                // NG
    }

    return rc;
}

////////////////////////////////////////////////////////////////////////////////
productstr::productstr()
{

}

productstr::~productstr()
{

}

/*!
 * @file		    util_ccmstr.cpp
 * @fn			    int productstr::good(char* pBuffer, size_t szMsgLength, int siChkSize, bool bFixSize)
 * @brief		    製品コード文字列検査
 * @details		    1 文字目は “A～W”の範囲,2 文字目は “A～Z”,“1～9”の範囲
 * @return		    0 >  Return value: TBD
 * 				    0 == Return value: 数値文字列でない
 * 				    0 <  Return value: 数値文字列
 * @param[in]       pBuffer         文字列バッファ
 * @param[in]       szMsgLength     文字列長
 * @param[in]       siChkSize       文字列長(期待値)
 * @date		    2022/5/5
 * @note            小文字アルファベットはNG        
 */
int productstr::good(unsigned char* pBuffer, size_t szMsgLength, int siChkSize, bool bFixSize)
{
    int     rc = RET_GOOD;
    int     index = 0;
    char    wk;

    if (szMsgLength != siChkSize) {
        return RET_NOGOOD;                              // NG
    }

    // 1文字目
    index = 0;
    wk    = *(pBuffer + index);
    if ((wk >= 'A') && (wk <= 'W')) {
        rc = RET_GOOD;
    }
    else {
        return RET_NOGOOD;                              // NG
    }

    // 2文字目
    rc = RET_NOGOOD;
    index = 1;
    wk    = *(pBuffer + index);
    if ((wk >= 'A') && (wk <= 'Z')) {
        rc = RET_GOOD;
    }
    else {
        if ((wk >= '1') && (wk <= '9')) {
            rc = RET_GOOD;
        }
    }

    return rc;
}

////////////////////////////////////////////////////////////////////////////////
pointstr::pointstr()
{

}

pointstr::~pointstr()
{

}

/*!
 * @file		util_ccmstr.cpp
 * @fn			int pointstr::good(char* pBuffer, size_t szMsgLength, int siChkSize, bool bFixSize)
 * @brief		小数点3桁未満チェック検査
 * @details		小数点3桁未満チェック検査
 * @return		0 >  Return value: TBD
 * 				0 == Return value: 数値文字列でない
 * 				0 <  Return value: 数値文字列
 * @param[in]   pBuffer         文字列バッファ
 * @param[in]   szMsgLength     文字列長
 * @param[in]   siChkSize       文字列長(期待値)
 * @date		2022/5/5
 * @note        
 */
int pointstr::good(unsigned char* pBuffer, size_t szMsgLength, int siChkSize, bool bFixSize)
{
    const int   max = 3;

    int         rc  = RET_GOOD;
    size_t      num;
    size_t      pos_found;

    std::string str_wk = (char*)pBuffer;
    unsigned char* ptarget;

    if (szMsgLength == 0) {
        return RET_GOOD;                                // ゼロバイト許容
    }

    /*
        ■ 5.678の場合
        [0][1][2][3][4]
         5  .  6  7  8

        文字列長        5byte
        小数点以下桁数 3桁
                        後方から4byte目
        桁数算出        (全体長 - 1) - 見つかった位置
                        3桁 = (5-1)-1

        ■ 567.8の場合
        [0][1][2][3][4]
         5  6  7  .  8

        文字列長        5byte
        小数点以下桁数  1桁
                        後方から2byte目
        桁数算出        (全体長 - 1) - 見つかった位置
                        1桁 = (5-1)-3

                        
        ■ 5.6789の場合
        [0][1][2][3][4][5]
         5  .  6  7  8  9

        文字列長        6byte
        桁数算出        (全体長 - 1) - 見つかった位置
                        4桁 = (6-1)-1         
    */
    pos_found = str_wk.find('.');
    if (pos_found == std::string::npos) {
        rc = digitstr::good(pBuffer, szMsgLength, siChkSize, false/*可変長*/);
        return rc;
    }

    /*
     * 小数点あり
     */
    num = (szMsgLength - 1) - pos_found;
    if (num > max) {
        return RET_NOGOOD;
    }

    // 整数部(先頭～小数点直前)
    rc = digitstr::good(pBuffer, pos_found, (int)pos_found, false/*可変長*/);
    if (rc == RET_NOGOOD) {
        return RET_NOGOOD;
    }

    // 小数部(小数点直後～文字列終端)
    ptarget = pBuffer + pos_found + 1;
    num = szMsgLength - 1 - pos_found;

    rc = digitstr::good(ptarget, num, (int)num, false/*可変長*/);
    if (rc == RET_NOGOOD) {
        return RET_NOGOOD;
    }

    return rc;
}

////////////////////////////////////////////////////////////////////////////////
endstr::endstr()
{

}

endstr::~endstr()
{

}

/*!
 * @file		util_ccmstr.cpp
 * @fn			int endstr::good(char* pBuffer, size_t szMsgLength, int siChkSize, bool bFixSize)
 * @brief		END文字列チェック検査
 * @details		END文字列チェック検査
 * @return		0 >  Return value: TBD
 * 				0 == Return value: END文字列でない
 * 				0 <  Return value: END文字列
 * @param[in]   pBuffer         文字列バッファ
 * @param[in]   szMsgLength     文字列長
 * @param[in]   siChkSize       文字列長(期待値)
 * @date		2022/5/5
 * @note        
 */
int endstr::good(unsigned char* pBuffer, size_t szMsgLength, int siChkSize, bool bFixSize)
{
    int rc = RET_GOOD;
    std::string str_wk;

    if (szMsgLength != siChkSize) {
        return RET_NOGOOD;                              // NG
    }

    str_wk = (char*)pBuffer;
    if (str_wk != "END") {
        return RET_NOGOOD;                              // NG
    }

    return rc;
}

////////////////////////////////////////////////////////////////////////////////
digitstr::digitstr()
{
}

digitstr::~digitstr()
{
}

/*!
 * @file		util_ccmstr.cpp
 * @fn			int digitstr::good(char* pBuffer, size_t szMsgLength, int siChkSize, bool bFixSize)
 * @brief		数値文字列検査
 * @details		数値文字列検査
 * @return		0 >  Return value: TBD
 * 				0 == Return value: 数値文字列でない
 * 				0 <  Return value: 数値文字列
 * @param[in]   pBuffer         文字列バッファ
 * @param[in]   szMsgLength     文字列長
 * @param[in]   siChkSize       文字列長(期待値)
 * @date		2022/5/5
 * @note        szMsgLengthはpBufferが示すバッファサイズ
 *              siChkSizeはpBufferが示すバッファの先頭アドレスから検査するサイズ
 *              szMsgLength <= siChkSize
 *              TBD ゼロ始まりの数値文字列をNGとするのか。
 */
int digitstr::good(unsigned char* pBuffer, size_t szMsgLength, int siChkSize, bool bFixSize)
{
    int         rc = RET_GOOD;
    const char* pcurrent = (const char*)pBuffer;
    int         ii;
    int         iscntrl;
    int         isdigit;

    #ifdef DBGPRT
    {   // debug
        char* pbuff = new char[szMsgLength + 1];
        memset(pbuff, 0x00, szMsgLength + 1);
        memcpy(pbuff, pBuffer, siChkSize);
        std::cout << pbuff << std::endl;
        delete pbuff;
    }
    #endif

    if (siChkSize != -1) {                              // 最大長不明以外なら
        if (szMsgLength > siChkSize) {                  // サイズ判定
            return RET_NOGOOD;                          // NG
        }
    }

    for (ii = 0; ii < szMsgLength; ii++) {
        // 制御文字評価
        iscntrl = std::iscntrl(*pcurrent);              // 0x00～0x1F, 0x7F
        if (iscntrl != 0) {
            rc = RET_NOGOOD;                            // 制御文字はNo good
            break;
        }

        // 数字評価
        isdigit = std::isdigit(*pcurrent);              // '0'～'9'
        if (isdigit == 0) {
            rc = RET_NOGOOD;                            // 数値文字以外(アルファベット)はNo good
            break;
        }

        pcurrent++;
        // FTP(ORD)のdigitstr::good()実装にあわせて、以下の判定分追加
        if (ii >= (szMsgLength - 1)) {                  // iiは検査文字列終端
            break;
        }
    }

    return rc;
}

////////////////////////////////////////////////////////////////////////////////
ankstr::ankstr()
{
}

ankstr::~ankstr()
{
}

/*!
 * @file		util_ccmstr.cpp
 * @fn			int ankstr::good(char* pBuffer, size_t szMsgLength, int siChkSize, bool bFixSize)
 * @brief		alphabet numeric kana文字列検査
 * @details		alphabet numeric kana文字列検査
 * @return		0 >  Return value: TBD
 * 				0 == Return value: 数値文字列でない
 * 				0 <  Return value: 数値文字列
 * @param[in]   pBuffer         文字列バッファ
 * @param[in]   siChkSize       文字列長(期待値)
 * @date		2022/5/5
 * @note        szMsgLengthはpBufferが示すバッファサイズ
 *              siChkSizeはpBufferが示すバッファの先頭アドレスから検査するサイズ
 */
int ankstr::good(unsigned char* pBuffer, size_t szMsgLength, int siChkSize, bool bFixSize)
{
    int         rc = RET_GOOD;
    int         cp;                                     // コードページ
    const char* pcurrent = (const char*)pBuffer;
    int         ii;
    int         iscntrl;
    int         isank;
    //int isdigit;

    // ■ Cロケール -> japan
    cp = ::_getmbcp();
    ::setlocale(LC_ALL, "ja-JP");                       // Set Japanese locale
    _setmbcp(932);                                      // and Japanese multibyte code page

    #ifdef DBGPRT
    {   // debug
        char* pbuff = new char[szMsgLength+1];
        memset(pbuff, 0x00, szMsgLength+1);
        memcpy(pbuff, pBuffer, siChkSize);
        std::cout << pbuff << std::endl;
        delete[] pbuff;
    }
    #endif

    if (bFixSize == true) {                             // 固定長
        if (szMsgLength != siChkSize) {                 // サイズ判定
            return RET_NOGOOD;                          // NG
        }
    }

    for (ii = 0; ii < szMsgLength; ii++) {
        // 制御文字評価
        iscntrl = std::iscntrl(*pcurrent);              // 0x00～0x1F, 0x7F
        if (iscntrl != 0) {
            rc = RET_NOGOOD;                            // 制御文字はNo good
            break;
        }

#if 1
        isank = std::isprint(*pcurrent);
        if (isank == 0) {
            rc = RET_NOGOOD;                            // ディスプレイ表示不可文字はNo good
            break;
        }
#else
        // 半角英数評価
        isalpha = std::isalpha(*(pBuffer+ii));          // 'a'～'z', 'A'～'Z'
        isdigit = std::isdigit(*(pBuffer+ii));          // '0'～'9'
        if ((isdigit != 0) || (isalpha != 0)) {
            ;                                           // 半角英数はgood
        }
        else {
            rc = RET_FAILED;                            // 半角英数以外はNo good
            break;
        }
#endif

        pcurrent++;
        if (ii >= (szMsgLength - 1)) {                  // iiは検査文字列終端
            break;
        }
    }

    // ■ Cロケール -> japan
    _setmbcp(cp);                                       // もとに戻す
    ::setlocale(LC_ALL, "C");                           // Set Japanese locale
    cp = ::_getmbcp();

    return rc;
}

////////////////////////////////////////////////////////////////////////////////
mbstr::mbstr()
{
}

mbstr::~mbstr()
{
}

/*!
 * @file		util_ccmstr.cpp
 * @fn			int mbstr::good(char* pBuffer, size_t szMsgLength, int siChkSize, bool bFixSize)
 * @brief		マルチバイト文字列検査
 * @details		マルチバイト文字列検査
 * @return		0 >  Return value: エラーコード
 * 				0 == Return value: マルチバイト文字列でない
 * 				0 <  Return value: マルチバイト文字列
 * @param[in]   pBuffer         文字列バッファ
 * @param[in]   szMsgLength     文字列長
 * @param[in]   siChkSize       文字列長(期待値)
 * @date		2022/3/24
 * @note        szMsgLengthはpBufferが示すバッファサイズ
 *              siChkSizeはpBufferが示すバッファの先頭アドレスから検査するサイズ
 *              siChkSize <= szMsgLength
 */
int mbstr::good(unsigned char* pBuffer, size_t szMsgLength, int siChkSize, bool bFixSize)
{
    // https://docs.microsoft.com/ja-jp/cpp/c-runtime-library/code-pages?view=msvc-170
    // https://docs.microsoft.com/ja-jp/cpp/c-runtime-library/reference/ismbblead-ismbblead-l?view=msvc-170

    // https://docs.microsoft.com/ja-jp/cpp/c-runtime-library/reference/mbrlen?view=msvc-170
    int             rc = RET_GOOD;
    int             cp;                                 // コードページ
    int             eno = 0;
    size_t          ret_wlib;
    mbstate_t       mbstate = { 0 };                    // TBD
    int             ii;
    const char*     pcurrent = (const char*)pBuffer;

    wchar_t         werrmsg[94+1];
    std::wstring    wstr_emsg = L"";
    // new, delete
    ecode*          pec = (ecode*)0;

    // ■ Cロケール -> japan
    cp = ::_getmbcp();
    ::setlocale(LC_ALL, "ja-JP");                       // Set Japanese locale
    _setmbcp(932);                                      // and Japanese multibyte code page

    memset(&werrmsg[0], 0x00, sizeof(werrmsg));

    for (ii = 0; ii < siChkSize; ii++) {
        ret_wlib = mbrlen(pcurrent, 1, &mbstate);
        if (ret_wlib == (size_t)-2) {
            // 次の count バイトから、不完全ながら有効になり得るマルチバイト文字が形成され、すべての count バイトが処理されます。
            pcurrent++;
        }
        else if (ret_wlib == 2) {
            // pcurrentが示す1byteはマルチバイトの2byteバイト目
            // 次の1byteはマルチバイトのはず
            pcurrent++;
        }
        else if (ret_wlib == 0) {                       // 中断せず、バッファ終端(次はNULL文字)までチェック完了
            rc = RET_GOOD;
            break;                                      // 終了(マルチバイトだった)
        }
        else {
            rc = RET_NOGOOD;
            if (ret_wlib == 1) {                        // 半角byteなら、mbrlen()は1を返す
                ;// Winライブラリとしては異常ではないので、_wcserror_s()は不要
                ;// RFORDER2009091500017.ORDファイルを使用すると、ここにくる
                ;// 全角に半角が混入しているため。
            }
            else {
                // このelse文で想定している数値は-1のみ。-1以外であっても、errnoを保持してみる。
                // 

                //  (size_t)(-1)
                //  エンコーディング エラーが発生しました。 
                //  次の count 以下のバイトでは、完全かつ有効なマルチバイト文字は形成されません。 
                //  この場合、errno が EILSEQ に設定され、mbstate の変換状態は指定されません
                eno = errno;
                _wcserror_s(&werrmsg[0], sizeof(werrmsg)/sizeof(wchar_t), eno);
                wstr_emsg = L"Failed mbrlen()..,";
                wstr_emsg += &werrmsg[0];

                pec = new ecode(ecode::eVALUE::eMBRLEN, __FUNCTIONW__, wstr_emsg);
                pec->output();
                rc = pec->rc();                         // 戻り値に変換
            }
            break;
        }

        if (ii >= (siChkSize -1)) {                     // iiは検査文字列終端
            break;
        }
    }

    // ■ Cロケール -> japan
    _setmbcp(cp);                                       // もとに戻す
    ::setlocale(LC_ALL, "C");                           // Set Japanese locale
    cp = ::_getmbcp();

    if (pec) {delete pec;}
    return rc;
}
};
