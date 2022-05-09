#include "pch.h"
#include "util_findfile.h"
#include "ecode.h"
#include "filename.h"
#include "util_mktime.h"

#include <stdio.h>
#include <stdlib.h>
#include <io.h>
#include <time.h>
#include <fstream>
#include <iostream>
#include <algorithm>
#include <string>
#include <vector>

// https://docs.microsoft.com/en-us/cpp/c-runtime-library/filename-search-functions?view=msvc-170
namespace utility {
findfile::findfile()
{
    this->initialize();
}

findfile::~findfile()
{
    this->variables();
}

int findfile::initialize(void)
{
    this->variables();
    return RET_SUCCESS;
}

int findfile::variables(void)
{
    vFound.clear();
    vSize.clear();
    return RET_SUCCESS;
}

/*!
 * @file		util_findfile.cpp
 * @fn			int findfile::eraser(const char* pDir, const char* pName)
 * @brief		ファイル検索 & 削除
 * @details		ファイル削除に失敗しても、中断せず、次に見つかるファイルを削除する。
 * @return		0 >  Return value: 失敗あり
 * 				0 == Return value: 削除成功
 * 				0 >  Return value: TBD
 * @param[in]   pDir            検索対象ディレクトリ名
 * @param[in]   pName           検索対象ファイル名(ワイルドカード可)
 * @date		2022/4/12
 * @note
 */
int findfile::eraser(const char* pDir, const char* pName)
{
    int                 rc = RET_FAILED;
    int                 ret_clib = RET_FAILED;
    struct _finddata_t  c_file;
    intptr_t            hfile;
    std::string         str_fullpath;
    std::string         str_dir;
    std::string         str_name;
    std::string         str_find;

    int                 eno = 0;
    wchar_t             werrmsg[94+1];
    std::wstring        wstr_emsg = L"";
    // new, delete
    ecode*              pec = (ecode*)0;

    ::memset(&c_file, 0x00, sizeof(c_file));
    hfile = (intptr_t)- 1;

    str_dir = pDir;
    str_name = pName;
    str_find = str_dir + "\\" + str_name;

    // Find first .c file in current directory
    hfile = ::_findfirst(str_find.c_str()/*"*.c"*/, &c_file);

    if (hfile == -1L) {                                 // not found
        return RET_FAILED;                              // printf("No *.c files in current directory!\n");
    }
    else {
        rc = RET_SUCCESS;                               // 検索成功したファイルなら、成功するはず
        do {
            str_fullpath = str_dir + "\\";
            str_fullpath += &c_file.name[0];

            ret_clib = ::remove(str_fullpath.c_str());
            if (ret_clib == -1) {
                eno = errno;
                _wcserror_s(&werrmsg[0], sizeof(werrmsg)/sizeof(wchar_t), eno);
                wstr_emsg = L"Failed remove()..,";
                wstr_emsg += &werrmsg[0];

                pec = new ecode(ecode::eVALUE::eREMOVE, __FUNCTIONW__, wstr_emsg);
                pec->output();
                rc = pec->rc();                         // 戻り値に変換
                delete pec;
            }
        } while(::_findnext(hfile, &c_file) == 0);
        ::_findclose(hfile);
    }

	return rc;
}

/*!
 * @file		util_findfile.cpp
 * @fn			int findfile::finder(const char* pDir, const char* pName)
 * @brief		ファイル検索
 * @details		ファイル検索
 * @return		0 >  Return value: ファイル見つからない
 * 				0 == Return value: TBD
 * 				0 >  Return value: ファイル数
 * @param[in]   pDir            検索対象ディレクトリ名
 * @param[in]   pName           検索対象ファイル名(ワイルドカード可)
 * @date		2022/4/12
 * @note        
 */
int findfile::finder(const char* pDir, const char* pName)
{
    struct _finddata_t  c_file;
    intptr_t            hfile;
    std::string         str_name;
    std::string         str_find;
    std::string         str_fn;

    ::memset(&c_file, 0x00, sizeof(c_file));
    hfile = (intptr_t)- 1;

    mstrTargetDir.clear();
    mstrTargetDir = pDir;
    str_name = pName;
    str_find = mstrTargetDir + "\\" + str_name;

    // Find first .c file in current directory
    hfile = ::_findfirst(str_find.c_str()/*"*.c"*/, &c_file);

    if (hfile == -1L) {                                 // not found
        return RET_FAILED;                              // printf("No *.c files in current directory!\n");
    }
    else {
        //printf("Listing of .c files\n\n");
        //printf("RDO HID SYS ARC  FILE         DATE %25c SIZE\n", ' ');
        //printf("--- --- --- ---  ----         ---- %25c ----\n", ' ');

        vFound.clear();
        vSize.clear();
        do {
            //char buffer[30];
            //printf((c_file.attrib & _A_RDONLY) ? " Y  " : " N  ");
            //printf((c_file.attrib & _A_HIDDEN) ? " Y  " : " N  ");
            //printf((c_file.attrib & _A_SYSTEM) ? " Y  " : " N  ");
            //printf((c_file.attrib & _A_ARCH) ? " Y  " : " N  ");
            //ctime_s(buffer, _countof(buffer), &c_file.time_write);
            //printf(" %-12s %.24s  %9ld\n", c_file.name, buffer, c_file.size);

            str_fn = &c_file.name[0];
            vFound.push_back(str_fn);                   // ファイル名
            vSize.push_back(c_file.size);               // ファイルサイズ
        } while (::_findnext(hfile, &c_file) == 0);
        ::_findclose(hfile);
    }

	return (int)vFound.size();
}

/*!
 * @file		util_findfile.cpp
 * @fn			int findfile::newfile()
 * @brief		最新ファイルへのインデックスを返す
 * @details		最新ファイルへのインデックスを返す
 * @return		0 >  Return value: 失敗(検索未実施)
 * 				0 <= Return value: ファイルインデックス
 *                  すべて同日なら、インデックス0を返す
 *                  見つかったファイルが1ファイルなら、インデックス0
 * @param[out]  void
 * @param[in]   void
 * @date		2022/4/12
 * @note        ***
 */
int findfile::getindex(void)
{
    int     rc  = RET_SUCCESS;

    // ファイル名日付から最新ファイルを絞り込む
    // もし、同日のファイルが複数あれば、通番の大きいファイルを選択
    if (vFound.empty()) {
		return RET_FAILED;
    }
    else if (vFound.size() == 1) {                      // 1フィルのみ
        return 0;                                       // 先頭インデックスを返す
    }

    // 2ファイル以上あれば、比較する
    filename* pf1  = (filename*)0;
    filename* pf2  = (filename*)0;

    std::vector<std::string> vstr1;
    std::vector<std::string> vstr2;

    std::string str_new;
    std::string str_tmp;
    int index_last = (int)vFound.size();
    int cmp;
    int ii;
    int max;
    int cnt = 0;

#if 0
    // 降順
    vFound[0] = "RFORDER1970120900384.ORD";
    vFound[1] = "RFORDER1970120800384.ORD";
    vFound[2] = "RFORDER1970120700384.ORD";

    // 旧新旧
    //vFound[0] = "RFORDER1970120800384.ORD";
    //vFound[1] = "RFORDER1970120900384.ORD";
    //vFound[2] = "RFORDER1970120700384.ORD";

    // 新旧新
    //vFound[0] = "RFORDER1970120800384.ORD";
    //vFound[1] = "RFORDER1970120700384.ORD";
    //vFound[2] = "RFORDER1970120900384.ORD";


    //vFound.clear();
    //vFound.push_back("RFORDER1970120800005.ORD");
    //vFound.push_back("RFORDER1970120800004.ORD");
    //vFound.push_back("RFORDER1970120800003.ORD");
    //vFound.push_back("RFORDER1970120800002.ORD");
    //vFound.push_back("RFORDER1970120800001.ORD");
    //index_last = vFound.size();
#endif

    cnt = 0;
    max = 0;
    str_new = vFound[0];                                // 初回は仮決め
    for (ii = 1/*2つ目から*/; ii < index_last; ii++) {
        str_tmp = vFound[ii];

        pf1 = new filename(str_tmp.c_str(), (const char*)".");
        pf2 = new filename(str_new.c_str(), (const char*)".");

        cmp = utility::mktime::cmp(*pf1, *pf2);
        if (cmp < 0) {                                  // 負: 2が過去(1がnew)
            str_new = vFound[ii];
            max = ii;
        }
        else if (cmp == 0) {                            // 同日
            cnt++;
        }
        else {

        }

        delete pf1;
        delete pf2; 
    }

    if (vFound.size() - 1 == cnt) {
        // 見つかったファイルはすべて同じ日付だった
        // 通番を比較・通番最大値を含むファイル名を選ぶ
        max = 0;
        str_new = vFound[0];                            // 初回は仮決め
        for (ii = 1/*2つ目から*/; ii < index_last; ii++) {
            str_tmp = vFound[ii];

            pf1 = new filename(str_tmp.c_str(), (const char*)".");
            pf2 = new filename(str_new.c_str(), (const char*)".");

            pf1->splitter(vstr1);
            pf2->splitter(vstr2);

            cmp = filename::cmp_seqno(vstr1[EFN_ID::eSEQNO].c_str(), vstr2[EFN_ID::eSEQNO].c_str());
            if (cmp < 0) {                              // 負: 2が過去(1がnew)
                str_new = vFound[ii];
                max = ii;
            }

            vstr1.clear();
            vstr2.clear();
            delete pf1;
            delete pf2;
        }
    }

    return max;
}

/*!
 * @file		util_findfile.cpp
 * @fn			_fsize_t findfile::getsize(const char* pName)
 * @brief		ファイルサイズ取得
 * @details		finder()で検索して見つかったファイルサイズを取得する
 * @return		0 <  Return value: エラーコード
 * 				0 == Return value: TBD
 * 				0 >  Return value: ファイルサイズ
 * @param[in]	pName               ファイル名(フルパスでない)
 * @date		1970/4/8
 * @note		
 */
_fsize_t findfile::getsize(const char* pName)
{
    using namespace std;

    int         rc  = RET_SUCCESS;
    string      str_fullpath;
    streampos   pos_cur;
    int         fsize;
    // new, delete
    ecode*      pec = (ecode*)0;

    if (pName == (const char*)0) {
		pec = new ecode(ecode::eVALUE::eARG_NULL, __FUNCTION__, "pName == 0");
		pec->output();
		rc = pec->rc();						            // 戻り値に変換
        delete pec;
        return rc;
    }
    str_fullpath = mstrTargetDir + "\\" + pName;

    ifstream ifs(str_fullpath.c_str(), ios::in | ios::binary);
    if (!ifs.good()) {
		pec = new ecode(ecode::eVALUE::eIFSTREAM, __FUNCTION__, "Failed ifs()");
		pec->output();
		rc = pec->rc();						            // 戻り値に変換
		goto EXIT_FUNCTION;
    }

    pos_cur = ifs.tellg();                              // 現在位置
    ifs.seekg(0, ios::end);                             // 終端移動
    fsize = ifs.tellg();                                // 終端位置取得
    ifs.seekg(pos_cur);                                 // もとに戻す

EXIT_FUNCTION:
    if (pec) {delete pec;}

    return (_fsize_t)fsize;
}

/*!
 * @file		util_findfile.cpp
 * @fn			int findfile::reader(const char* pName, char* pBuffer, int bufSize)
 * @brief		ファイルリード
 * @details		finder()で検索したディレクトリ内のファイルをリードする
 * @return		0 <  Return value: TBD
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @param[in]	pName               ファイル名(フルパスでない)
 * @param[in]	pBuffer             読み込みバッファ
 * @param[in]	bufSize             バッファサイズ
 * @date		1970/4/8
 * @note		
 */
int findfile::reader(const char* pName, char* pBuffer, int bufSize)
{
    using namespace std;

    int     rc  = RET_SUCCESS;
    string  str_fullpath;
    string  str;
    // new, delete
    ecode* pec = (ecode*)0;

    if (pName == (const char*)0) {
		pec = new ecode(ecode::eVALUE::eARG_NULL, __FUNCTION__, "pName == 0");
		pec->output();
		rc = pec->rc();						            // 戻り値に変換
        delete pec;
        return rc;
    }
    str_fullpath = mstrTargetDir + "\\" + pName;

    ifstream ifs(str_fullpath.c_str(), ios::in | ios::binary);
    if (!ifs.good()) {
		pec = new ecode(ecode::eVALUE::eIFSTREAM, __FUNCTION__, "Failed ifs()");
		pec->output();
		rc = pec->rc();						            // 戻り値に変換
		goto EXIT_FUNCTION;
    }

    str.resize(bufSize);                                // 読み取りバッファ確保
    copy(istreambuf_iterator<char>(ifs), istreambuf_iterator<char>(), str.begin());
    ::memcpy(pBuffer, str.c_str(), bufSize);

EXIT_FUNCTION:
    if (pec) {delete pec;}
    return RET_SUCCESS;
}
};
