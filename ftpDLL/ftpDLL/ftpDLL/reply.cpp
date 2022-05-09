#include "pch.h"
#include "reply.h"
#include "ecode.h"
#include <sstream>
#include <iostream>

reply::reply()
{
	initialize();
}

reply::reply(char* ps8Reply, bool bOutput)
{
	initialize();

	mString = ps8Reply;

	if (bOutput == true) { std::cout << mString; }
}

reply::~reply()
{
	mString.clear();
}
#if 1
reply& reply::operator=(const reply& rSrc)
{
	mString = rSrc.mString;
	return *this;
}

/*!
 @file          reply.cpp
 @fn            reply::initialize()
 @brief         初期化
 @details       メンバ変数初期化
 @return        0 <  VALUE:	失敗
				0 == VALUE: TBD
				0 >  VALUE: 成功
 @date          2022/3/3
 @note			***
 */
int reply::initialize(void)
{
	mString.clear();
	return RET_SUCCESS;
}

/*!
 * @file          reply.cpp
 * @fn            reply::get_code()
 * @brief         3桁コード取得
 * @details       replyメッセージの先頭3byteを取得する。
 * @return        0 <  VALUE: 失敗
 *                0 == VALUE: 返却しない・RET_SUCCESSが0なので、呼び出し元で区別がつかなくなる
 *                0 >  VALUE: replyコード(1～99は欠番)
 * @date          2022/3/1
 * @note          4.2. FTP REPLIES
 *                An FTP reply consists of a three digit number.
 *                A reply is defined to contain the 3-digit code, followed by Space <SP>,  followed by one line of text 
 */
int reply::get_code(void)
{
	ecode				retobj = RET_NOERR;
	ecode*				ptmp_ec;
	int					code3  = -1;
	std::stringstream	ss_tmp;
	std::string			str_tmp;

	// ※ A reply is defined to contain the 3-digit code, followed by Space <SP>,  followed by one line of text 
	//	数値文字列 3byteにつづく文字列にもSPが含まれる。
#if 0
	// 実験
	ss_tmp.str("abc");
	ss_tmp >> code3;									// code3 = 0
	code3 = -1;

	ss_tmp.clear();
	ss_tmp.str("123");									// 数値文字列のみ
	ss_tmp >> code3;
	code3 = -1;
#endif

	ss_tmp.clear();
	ss_tmp.str(mString);
	ss_tmp >> code3;									// 3digits code
	if (code3 <= 0) {									// リダイレクト失敗
		ptmp_ec = new ecode(ecode::eVALUE::eREDIRECT, __FUNCTION__, "(code3 <= 0)");
		ptmp_ec->output();
		code3 = ptmp_ec->rc();							// return-code変換
		delete ptmp_ec;
	}

	return code3;
}

/*!
 * @file          reply.cpp
 * @fn            reply::get_msg()
 * @brief         replyメッセージ取得
 * @details       replyコードに続くメッセージを取得する。
 * @return        0 <  VALUE:	失敗
 *                0 == VALUE: TBD
 *                0 >  VALUE: リプライコード(1～99は欠番) 
 * @date          2022/3/1
 * @note          4.2. FTP REPLIES準拠
 */
int reply::get_msg(std::string& rMessage)
{
	size_t				index_ws;
	int					leng;

	leng = (int)mString.size();
	index_ws = mString.find(" ");
	rMessage = mString.substr(index_ws+1, leng - (index_ws+1));

	return RET_SUCCESS;
}

/*!
 * @file			reply.cpp
 * @fn				bool reply::range(int s32Value, int s32min)
 * @brief			整数範囲判定(100の位)
 * @details			例えば、s32minが100なら、s32Valueが100～199の範囲の数値なのか、判定する
 * @return			true: 範囲内
 *					false:範囲外
 * @date			2022/3/3
 * @note			10進数3桁に対応。2桁等、対象外。
 *					
 */
bool reply::range(int s32Value, int s32min)
{
	// Ex: min～(min+99) → 200～299
	return ((s32Value >= s32min) && (s32Value <= (s32min+99))) ? true: false;
}

bool reply::range(int s32Value, int s32min, int s32max)
{
	// Ex: min～(max+99) → 400～599
	return ((s32Value >= s32min) && (s32Value <= (s32max+99))) ? true: false;
}
#endif