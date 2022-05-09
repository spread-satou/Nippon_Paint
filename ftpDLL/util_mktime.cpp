#include "pch.h"
#include "util_mktime.h"
#include "ecode.h"

#include <string>
#include <sstream>
#include <vector>

namespace utility {
mktime::mktime()
{

}

mktime::~mktime()
{

}

/*
struct tm
{
    int tm_sec;   // seconds after the minute - [0, 60] including leap second
    int tm_min;   // minutes after the hour - [0, 59]
    int tm_hour;  // hours since midnight - [0, 23]
    int tm_mday;  // day of the month - [1, 31]
    int tm_mon;   // months since January - [0, 11]
    int tm_year;  // years since 1900
    int tm_wday;  // days since Sunday - [0, 6]
    int tm_yday;  // days since January 1 - [0, 365]
    int tm_isdst; // daylight savings time flag
};
*/
/*!
 * @file		mktime.cpp
 * @fn			int mktime::conv(const char* pString)
 * @brief		UTC経過秒変換
 * @details		UTC経過秒変換
 * @return		0 <  Return value: 失敗
 * 				0 == Return value: TBD
 * 				0 >  Return value: 経過秒
 * @param[in]	pString			YYYYMMDD文字列
 * @date		2022/3/17
 * @note        ***
 */
__time64_t mktime::conv(const char* pString)
{
    __time64_t          result;
    struct tm           when;

    std::string         str;
    std::string         strdate[3];
    std::stringstream   ss[3];

    str = pString;
    strdate[0] = str.substr(0, 4);
    strdate[1] = str.substr(4, 2);
    strdate[2] = str.substr(6, 2);

    ss[0] << strdate[0];
    ss[1] << strdate[1];
    ss[2] << strdate[2];

    memset(&when, 0x00, sizeof(when));
    ss[0] >> when.tm_year;
    ss[1] >> when.tm_mon;
    ss[2] >> when.tm_mday;

    // https://docs.microsoft.com/en-us/cpp/c-runtime-library/reference/asctime-s-wasctime-s?view=msvc-170
    when.tm_year -= 1900;                           // tm_year	Year (current year minus 1900)
    when.tm_mon  -= 1;                              // tm_mon	Month (0-11; January = 0)
    //when.tm_mday                                  // tm_mday	Day of month (1-31)
    result = _mktime64(&when);

    return result;
}

/*!
 * @file		mktime.cpp
 * @fn			int mktime::cmp(filename& rF1, filename& rF2)
 * @brief		時刻比較
 * @details		時刻比較
 * @return		-1 <  Return value: エラーコード
 * 				-1 == Return value: rF2は過去
 * 		         0 == Return value: 同時刻
 * 				 1 == Return value: rF2は未来
 * @param[in]	pString			ファイル名文字列(RFORDER+YYYYMMDD+通番.拡張子)
 * @date		2022/3/18
 * @note        RFORDER2009091500017.ORDに対して、区切り文字列RFORDERを指定すると、日付,通番,拡張子が取得できる
 */
int mktime::cmp(filename& rF1, filename& rF2)
{
    int                         rc = RET_FAILED;
    __time64_t                  result[2];              // [0]: rF1, [1]: rF2
    const char*                 pyyyymmdd[2];           // [0]: rF1, [1]: rF2
    std::vector<std::string>    vstr1;                  // rF1
    std::vector<std::string>    vstr2;                  // rF2

    rc = rF1.splitter(vstr1);
    if (rc == RET_SUCCESS) {
        pyyyymmdd[0] = vstr1[EFN_ID::eDATE].c_str();
        result[0] = mktime::conv(pyyyymmdd[0]);
    }
    else {
        return rc;
    }

    rc = rF2.splitter(vstr2);
    if (rc == RET_SUCCESS) {
        pyyyymmdd[1] = vstr2[EFN_ID::eDATE].c_str();
        result[1] = mktime::conv(pyyyymmdd[1]);
    }
    else {
        return rc;
    }

    if (result[0] < result[1]) {                        // 未来
        rc = 1;
    }
    else if (result[0] > result[1]) {                   // 過去
        rc = -1;
    }
    else {                                              // 同日
        rc = 0;
    }

    return rc;
}
}   // namespace utility {