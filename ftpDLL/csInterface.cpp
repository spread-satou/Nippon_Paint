#include "pch.h"
#include "csInterface.h"
#include "ecode.h"
#include "util_fullpath.h"
#include "util_file.h"

csInterface::csInterface()
{
	this->initialize();
}

csInterface::~csInterface()
{
	std::vector<ord_struct>::iterator	iter;
	for (iter = vORD.begin(); iter != vORD.end(); iter++) {
		(*iter).mvParams.clear();
	}
}

int csInterface::initialize()
{
	return this->variables();
}

int csInterface::variables()
{
	vORD.clear();
	return RET_SUCCESS;
}

void csInterface::dbg_save(const char* pFullpath)
{
	// std::vector<ord_struct>	vORD;					//! ORD構造体配列
	// std::vector<std::string>	mvParams;				//! ORD情報(57パラメータ)

	using namespace std;

	vector<ord_struct>::iterator	ord_iter;
	vector<string>::iterator		str_iter;
	string str_params;

	for (ord_iter = vORD.begin(); ord_iter != vORD.end(); ord_iter++) {
		vector<string>& wk_params = (*ord_iter).mvParams;
		// ↑↓参照にすれば、読みやすいかも。
		for (str_iter = wk_params.begin(); str_iter != wk_params.end(); str_iter++) {
			str_params += (*str_iter);					// 57パラメータをテキスト1行に戻す
		}
	}

	utility::file::writer(pFullpath, str_params);
}
