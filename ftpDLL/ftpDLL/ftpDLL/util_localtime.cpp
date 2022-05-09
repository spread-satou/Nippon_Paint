#include "pch.h"
#include "util_localtime.h"
#include "ecode.h"
#include <time.h>

namespace utility {
localtime::localtime()
{

}

localtime::~localtime()
{

}

/*!
 * @file		util_localtime.cpp
 * @fn			int localtime::getstring(std::string& rString, const char* pFmt)
 * @brief		ローカルタイム文字列取得(yyyy/mm/dd HH:MM:SS)
 * @details		time_t 時刻値を tm 構造体に変換し、ローカル タイム ゾーンに合わせて、日時を取得する
 * @return		-1 <  Return value: エラーコード
 * 		         0 == Return value: 成功
 * 				 1 == Return value: TBD
 * @param[out]	pString			日時文字列
 * @param[in]	pFmt			書式設定文字列
 * @date		2022/3/30
 * @note        https://docs.microsoft.com/ja-jp/cpp/c-runtime-library/reference/localtime-s-localtime32-s-localtime64-s?view=msvc-170
 */
int localtime::getstring(std::string& rString, const char* pFmt)
{
	int rc = RET_SUCCESS;

	struct tm	newtime;
	__int64		ltime;
	errno_t		err;
	char		tmpbuff[256] = { 0x00 };			// rep stos命令で初期化
	char		fmtmsg[256] = { 0x00 };				// rep stos命令で初期化
	char*		pmsg = (char*)0;

	::_time64(&ltime);
	err = ::_localtime64_s(&newtime, &ltime);
	if (err) {
		rc = err;
	}
	else {
		::snprintf(&tmpbuff[0], sizeof(tmpbuff),
								"%d/%02d/%02d %02d:%02d:%02d",
								(newtime.tm_year + 1900),
								(newtime.tm_mon + 1),
								newtime.tm_mday,
								newtime.tm_hour,
								newtime.tm_min,
								newtime.tm_sec);
		if (pFmt) {
			snprintf(&fmtmsg[0], sizeof(fmtmsg), pFmt, &tmpbuff[0]);
			pmsg = &fmtmsg[0];
		}
		else {
			pmsg = &tmpbuff[0];
		}
		rString = pmsg;
	}
	return rc;
}
}	// namespace utility
