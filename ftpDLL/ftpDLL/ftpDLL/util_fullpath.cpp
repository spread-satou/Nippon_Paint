#include "pch.h"
#include "util_fullpath.h"
#include "ecode.h"

namespace utility {

#define EPATH                   (int)ePATH
enum class ePATH {
    eDIR,
    eFN,
    eEXT,
    eNUMB
};


fullpath::fullpath()
{

}

fullpath::~fullpath()
{

}

/*!
 * @file		fullpath.cpp
 * @fn			int fullpath::sepa(std::vector<std::string>& rvPath, std::string& rFullpath)
 * @brief		フルパス分割
 * @details		フルパス分割
 * @return		0 <  Return value: 失敗
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @param[out]	rvPath			フルパス配列
 * @param[in]	pFullpath		ファイル名
 * @date		2022/3/31
 * @note
 */
int fullpath::sepa(std::vector<std::string>& rvPath, std::string& rFullpath)
{
    using std::string;
    string str_fullpath;
    string str_fn;

    string::size_type whole;                            // 画像処理経験者なら、わかると思う。
    string::size_type len[EPATH::eNUMB] = {0};
    string::size_type len_tmp;

    string::size_type pos_sepa;                         // ここで区切る
    string::size_type pos_work;                         // 使いまわし
    int ii;

    rvPath.clear();
    for (ii = 0; ii < EPATH::eNUMB; ii++) {
        rvPath.push_back("");
    }
    
    str_fullpath = rFullpath;
    whole = str_fullpath.size();

    //まず、ディレクトリとファイル名を分離
    pos_sepa = str_fullpath.rfind("\\");
    if (pos_sepa == string::npos) {
        return RET_FAILED;                              // Ex.) FTPlog.txt
    }
    len[EPATH::eDIR] = pos_sepa;
    rvPath[EPATH::eDIR] = str_fullpath.substr(0, len[EPATH::eDIR]);
                                                        // ディレクトリ名
    // これがファイル名(拡張子付き)
    len_tmp = whole - len[EPATH::eDIR];
    len_tmp -= 1;                                       // 区切り文字\はいらない
    str_fn  = str_fullpath.substr(pos_sepa + 1, len_tmp);

    // つづいて、拡張子
    len_tmp  = str_fn.size();
    pos_work = str_fn.rfind(".");
    if (pos_work == string::npos) {
        return RET_FAILED;                              // EX.) C:\\FTPlog
    }
    len[EPATH::eEXT] = len_tmp - (pos_work+1);
    rvPath[EPATH::eEXT] = str_fn.substr(pos_work+1, len[EPATH::eEXT]);

    // 最後にファイル名
    len[EPATH::eFN] = pos_work;
    rvPath[EPATH::eFN]  = str_fn.substr(0, len[EPATH::eFN]);

    return RET_SUCCESS;
}
}   // namespace utility
