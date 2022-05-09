#pragma once
#include <vector>
#include <string>

//! C#/C++共有パラメータ
// Csharpへ通知するパラメータ定義
struct ord_struct
{
public:
	std::string					mstrFullpath;			//! ファイル名
	// downloadした1件分57パラメータのORD情報
	std::vector<std::string>	mvParams;				//! ORD情報(57パラメータ)
};

class csInterface
{
public:
	std::vector<ord_struct>	vORD;						//! ORD構造体配列

public:
	csInterface();
	virtual ~csInterface();

	int initialize(void);

	void dbg_save(const char* pFullpath);
protected:
	int variables(void);
};
