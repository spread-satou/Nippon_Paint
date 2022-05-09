#include "pch.h"
#include "util_orderstr.h"
#include "ecode.h"
#include <cctype>
#include <errno.h>
#include <string.h>
#include <iostream>
#include <mbctype.h>

#define DBGPRT

namespace utility {
////////////////////////////////////////////////////////////////////////////////
digitstr::digitstr()
{
}

digitstr::~digitstr()
{
}

/*!
 * @file		util_orderstr.cpp
 * @fn			int digitstr::isdigit(char* pBuffer, int siBuffSize, int siChkSize)
 * @brief		数値文字列検査
 * @details		数値文字列検査
 * @return		0 >  Return value: TBD
 * 				0 == Return value: 数値文字列でない
 * 				0 <  Return value: 数値文字列
 * @param[in]   pBuffer         文字列バッファ
 * @param[in]   siBuffSize      文字列バッファサイズ
 * @param[in]   siChkSize       検査文字列長
 * @date		2022/3/24
 * @note        siBuffSizeはpBufferが示すバッファサイズ
 *              siChkSizeはpBufferが示すバッファの先頭アドレスから検査するサイズ
 *              siChkSize <= siBuffSize
 */
int digitstr::good(unsigned char* pBuffer, int siBuffSize, int siChkSize)
{
    int         rc = RET_GOOD;
    const char* pcurrent = (const char*)pBuffer;
    int         ii;
    int         iscntrl;
    int         isdigit;

    #ifdef DBGPRT
    {   // debug
        char* pbuff = new char[siBuffSize + 1];
        memset(pbuff, 0x00, siBuffSize + 1);
        memcpy(pbuff, pBuffer, siChkSize);
        std::cout << pbuff << std::endl;
        delete pbuff;
    }
    #endif

    for (ii = 0; ii < siBuffSize; ii++) {
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
        if (ii >= (siChkSize - 1)) {                    // iiは検査文字列終端
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
 * @file		util_orderstr.cpp
 * @fn			int ankstr::good(char* pBuffer, int siBuffSize, int siChkSize)
 * @brief		alphabet numeric kana文字列検査
 * @details		alphabet numeric kana文字列検査
 * @return		0 >  Return value: TBD
 * 				0 == Return value: 数値文字列でない
 * 				0 <  Return value: 数値文字列
 * @param[in]   pBuffer         文字列バッファ
 * @param[in]   siChkSize       検査文字列長
 * @date		2022/3/24
 * @note        siBuffSizeはpBufferが示すバッファサイズ
 *              siChkSizeはpBufferが示すバッファの先頭アドレスから検査するサイズ
 *              siChkSize <= siBuffSize
 */
int ankstr::good(unsigned char* pBuffer, int siBuffSize, int siChkSize)
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
        char* pbuff = new char[siBuffSize+1];
        memset(pbuff, 0x00, siBuffSize+1);
        memcpy(pbuff, pBuffer, siChkSize);
        std::cout << pbuff << std::endl;
        delete[] pbuff;
    }
    #endif

    for (ii = 0; ii < siBuffSize; ii++) {
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
        if (ii >= (siChkSize - 1)) {                    // iiは検査文字列終端
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
 * @file		util_orderstr.cpp
 * @fn			int mbstr::good(char* pBuffer, int siBuffSize, int siChkSize)
 * @brief		マルチバイト文字列検査
 * @details		マルチバイト文字列検査
 * @return		0 >  Return value: エラーコード
 * 				0 == Return value: マルチバイト文字列でない
 * 				0 <  Return value: マルチバイト文字列
 * @param[in]   pBuffer         文字列バッファ
 * @param[in]   siBuffSize      文字列バッファサイズ
 * @param[in]   siChkSize       検査文字列長
 * @date		2022/3/24
 * @note        siBuffSizeはpBufferが示すバッファサイズ
 *              siChkSizeはpBufferが示すバッファの先頭アドレスから検査するサイズ
 *              siChkSize <= siBuffSize
 */
int mbstr::good(unsigned char* pBuffer, int siBuffSize, int siChkSize)
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
