#include "pch.h"
#include "ecode.h"
#include <iostream>
#include <locale>

ecode::ecode()
{
	initialize();
}

ecode::ecode(int e)
{
	initialize();

	msiValue = (int)e;
}

ecode::ecode(eVALUE e, const char* pFunc)
{
	initialize();

	msiValue = (int)e;
	mFunc = pFunc;
}

ecode::ecode(eVALUE e, const char* pFunc, const char* pMsg)
{
	initialize();

	msiValue = (int)e;
	mFunc = pFunc;
	mMsg  = pMsg;
}

ecode::ecode(eVALUE e, const wchar_t* pFunc, std::wstring& rMsg)
{
	initialize();

	msiValue = (int)e;
	mwFunc= pFunc;
	mwMsg = rMsg;
}

ecode::~ecode()
{
	mFunc.clear();
	mMsg.clear();
	mwFunc.clear();
	mwMsg.clear();
}

/*!
 * @file          ecode.cpp
 * @fn            ecode::initialize()
 * @brief         初期化
 * @details       メンバ変数初期化
 * @return        0 <  VALUE: TBD
 *                0 == VALUE: 成功
 *                0 >  VALUE: TBD
 * @date          2022/3/1
 * @note          ***
 */
int ecode::initialize(void)
{
	msiValue = RET_NOERR;
	mFunc.clear();	// = "";
	mwFunc.clear();	// = L"";

	return RET_NOERR;
}

/*!
 * @file          ecode.cpp
 * @fn            operator=(const eVALUE& rEC)
 * @brief         エラーコードコピー
 * @details       エラーコードをコピーする
 * @return        this
 * @date          2022/3/1
 * @note          ***
 */
ecode& ecode::operator=(const eVALUE& rEC)
{
	msiValue = (int)rEC;
	return *this;
}

/*!
 * @file          ecode.cpp
 * @fn            ecode::good
 * @brief         エラーコード判定
 * @details       正常かを判定する。
 * @return        true:  エラーなし(正常)
 *                false: エラーあり
 * @date          1970/1/1
 * @note          ***
 */
bool ecode::good(void)
{
	return (msiValue == RET_NOERR) ? true : false;
}

/*!
 * @file          ecode.cpp
 * @fn            ecode::fail
 * @brief         エラーコード判定
 * @details       異常かを判定する。
 * @return        true:  エラーあり
 *                false: エラーなし(正常)
 * @date          2022/3/1
 * @note          ***
 */
bool ecode::fail(void)
{
	return (msiValue < RET_NOERR) ? true : false;
}

/*!
 * @file          ecode.cpp
 * @fn            ecode::output
 * @brief         ログ出力(TBD)
 * @details       ログ出力(TBD)
 * @date          2022/3/3
 * @note          ***
 */
void ecode::output(void)
{
#if 0
	// ロケール動作確認
	// locale クラス	//https://docs.microsoft.com/ja-jp/cpp/standard-library/locale-class?view=msvc-170
	std::locale loc("German_germany");

	std::locale loc1;
	std::cout << "The initial locale is: " << loc1.name() << std::endl;

	std::locale loc2 = std::locale::global(loc);
	std::locale loc3;
	std::cout << "The current locale is: " << loc3.name() << std::endl;

	std::cout << "The previous locale was: " << loc2.name() << std::endl;
#endif

    const char* pcolor[6] = {
        "\033[37m",                 // [0]使用禁止
        "\033[37m",                 // [1]white
        "\033[31m",                 // [2]red
        "\033[32m",                 // [3]green
        "\033[33m",                 // [4]yellow
        "\033[36m"                  // [5]TBD(使用禁止)
    };

    const wchar_t* pwcolor[6] = {
       L"\033[37m",                 // [0]使用禁止
       L"\033[37m",                 // [1]white
       L"\033[31m",                 // [2]red
       L"\033[32m",                 // [3]green
       L"\033[33m",                 // [4]yellow
       L"\033[36m"                  // [5]TBD(使用禁止)
    };

	if (mMsg.size() > 0) {
		std::cout << pcolor[2] << "[FATAL][ERR]" << pcolor[1] << mFunc << "()," << mMsg << "\n";
	}

	if (mwMsg.size() > 0) {
		// https://docs.microsoft.com/ja-jp/cpp/c-runtime-library/reference/setlocale-wsetlocale?view=msvc-170
		// https://docs.microsoft.com/ja-jp/openspecs/windows_protocols/ms-lcid/a9eac961-e77d-41a6-90a5-ce1a8b0cdb9c
		//::setlocale(LC_ALL, ".UTF8");					// Win10
		//::setlocale(LC_ALL, "ja-JP");					// これもOK, win10以外もOK?

		std::wcout.imbue(std::locale("ja-JP"));
		std::wcout << pwcolor[2] << L"[FATAL][ERR]" << pwcolor[1] << mwFunc << L"()," << mwMsg << L"\n";
	}
	return;
}