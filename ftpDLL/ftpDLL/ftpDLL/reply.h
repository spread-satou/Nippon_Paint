#pragma once
#include <string>

/*
	char*		pmsg;
	reply*		prep_connect;							// CONNECT()応答
	int			s32code;
	std::string	str_msg;

	prep_connect = new reply(pmsg);
	s32code = prep_connect->get_code();
	if  (s32code <= 0) {
		return s32code;
	}

	str_msg = prep_connect->get_msg();
*/

/*!
 * @brief REPLYメッセージ
 */
class reply
{
protected:
	std::string	mString;								//! REPLYメッセージ

public:
	reply();
	reply(char* ps8Reply, bool bOutput = false);
	virtual ~reply();
#if 1
	reply& operator=(const reply& rSrc);

	int get_code(void);
	int get_msg(std::string& rMessage);

	static bool range(int s32Value, int s32min);
	static bool range(int s32Value, int s32min, int s32max);

	// https://docs.microsoft.com/ja-jp/cpp/cpp/copy-constructors-and-copy-assignment-operators-cpp?view=msvc-170
	// https://docs.microsoft.com/ja-jp/cpp/cpp/assignment?view=msvc-170
	// ClassName& operator=(const ClassName& x);
#endif
protected:
	int initialize(void);
};

