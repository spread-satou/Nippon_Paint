#include "pch.h"
#include "util_strtok.h"
#include "ecode.h"

namespace utility {
strtok::strtok()
{

}

strtok::~strtok()
{

}

/*
char* strtok_s(
   char* str,
   const char* delimiters,
   char** context
);
*/
/*!
 * @file        strtok.cpp
 * @fn          int strtok::splitter(std::vector<std::string>& rOutput, char* pTarget, const char* pSepa)
 * @brief       文字列分割
 * @details     pTargetが示すバッファ内のメッセージをpSepa文字列で分割する
 * @return      分割メッセージ数
 * @param[out]	rOutput         分割後文字列配列
 * @param[in]	pTarget         分割対象文字列
 * @param[in]	siLength        分割対象文字列長
 * @param[in]	pSepa           区切り文字列
 * @date        2022/3/14
 * @note        分割できない1件分のデータは丸ごと取得
 *              カンマで囲まれた文字列が空(存在しない)の場合、検索をスキップする。
 *              カンマで囲まれた文字列をrOutputにセットする
 */
size_t strtok::splitter(std::vector<std::string>& rOutput,
                        const char* pTarget,
                        size_t siLength,
                        const char* pSepa)
{
    char*       pwork = (char*)0;
    char*       token1 = NULL;
    char*       next_token1 = NULL;
    std::string str;

    pwork = new char[siLength+1];
    if (pwork == (char*)0) {
        return 0;
    }

    // strtok_s()はバッファに見つかった位置に0x00を書き込むので、WORKバッファで区切り作業を実施
    memset(pwork, 0x00, siLength+1);
    memcpy(pwork, pTarget, siLength);
    rOutput.clear();

    // Establish string and get the first token:
    token1 = strtok_s(pwork, pSepa, &next_token1);

    // While there are tokens in "string1" or "string2"
    while (token1 != NULL) {
        str = token1;
        rOutput.push_back(str);

        if (token1 != NULL) {                           // Get next token:
            token1 = strtok_s(NULL, pSepa, &next_token1);
        }
    }
    delete[] pwork;
    return rOutput.size();
}

strparam::strparam()
{
}

strparam::~strparam()
{
}

/*!
 * @file        strtok.cpp
 * @fn          int strparam::splitter(std::vector<std::string>& rOutput, char* pTarget, const char* pSepa)
 * @brief       文字列分割
 * @details     pTargetが示すバッファ内のメッセージをpSepa文字列で分割する
 * @return      分割メッセージ数
 * @param[out]	rOutput         分割後文字列配列
 * @param[in]	pTarget         分割対象文字列
 * @param[in]	siLength        分割対象文字列長
 * @param[in]	pSepa           区切り文字列
 * @date        2022/4/14
 * @note        カンマで囲まれた文字列をrOutputにセットする
 *              カンマで囲まれた文字列が空(存在しない)の場合、検索をスキップする。
 */
size_t strparam::splitter(std::vector<std::string>& rOutput,
                        const char* pTarget,
                        size_t siLength,
                        const char* pSepa)
{
    bool    flg_found = true;
    std::string str_work;
    std::string str_param;
    std::string::size_type pos_found;
    std::string::size_type pos_cur = 0;
    std::string::size_type len;

    rOutput.clear();
    str_work.resize(siLength);
    str_work = pTarget;

    do {
        pos_found = str_work.find(pSepa, pos_cur);
        if (pos_found == std::string::npos) {
            len = siLength - pos_cur;
            flg_found = false;
        }
        else {
            len = pos_found - pos_cur;
        }

        str_param = str_work.substr(pos_cur, len);
        pos_cur = pos_found + 1;

        rOutput.push_back(str_param);
    } while (flg_found == true);
   
    return rOutput.size();
}

}   // namespace utility {


