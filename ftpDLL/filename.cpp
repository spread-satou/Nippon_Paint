#include "pch.h"
#include "filename.h"
#include "ecode.h"
#include "util_mktime.h"
#include <sstream>
#include <string>

using namespace utility;

/*
    string          strl;
    string          strr;
    string          strtm;
    vector<string>  vstr;
    filename str = "RFORDER2009091500017.ORD";  // 2009.09.15 00017

    strl = str.left(".");
    strr = str.right(".");
    str.splitter(vstr);                         // [0] RFORDER
                                                // [1] 20090915
                                                // [2] 00017
                                                // [3] ORD
*/
filename::filename()
{
    valiables();
}

filename::filename(const char* pTarget, const char* pSepa)
{
    int rc = this->initialize(pTarget, pSepa);
    if (rc < 0) {
        throw rc;
    }
}

filename::~filename()
{
    mstrTarget.clear();
    mstrSepa.clear();
}

int filename::initialize(const char* pTarget, const char* pSepa)
{
    int     rc  = RET_SUCCESS;
	ecode*	pec = (ecode*)0;

    if (pTarget == (const char*)0) {
		pec = new ecode(ecode::eVALUE::eARG_NULL, __FUNCTION__, "pTarget == 0");
		pec->output();
		rc = pec->rc();						            // 戻り値に変換
        delete pec;
        return /*throw*/ rc;                            // コンストラクタは戻り値がないので。
    }

    if (pSepa == (const char*)0) {
		pec = new ecode(ecode::eVALUE::eARG_NULL, __FUNCTION__, "pSepa == 0");
		pec->output();
		rc = pec->rc();						            // 戻り値に変換
        delete pec;
        return /*throw*/ rc;                            // コンストラクタは戻り値がないので。
    }

    valiables();
    mstrTarget  = pTarget;
    mstrSepa    = pSepa;

    return rc;
}

void filename::valiables()
{
    mstrTarget.clear(); // = "";
    mstrSepa.clear();   // = "";
}

//filename& filename::operator=(const filename& rTarget)
//{
//	return *this;
//}

/*!
 * @file		filename.cpp
 * @fn			int filename::splitter(std::vector<std::string>& vString)
 * @brief		文字列分割
 * @details		文字列分割
 * @return		0 <  Return value: エラーコード
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @param[out]  vString         分割文字列配列
 * @date		2022/3/18
 * @note        [0] RFORDER
 *              [1] YYYYMMDD
 *              [2] 通番5桁
 *              [3] .
 *              [4] 拡張子(ORD等)
 */
int filename::splitter(std::vector<std::string>& vString)
{
    int     rc = RET_SUCCESS;
    size_t  si_pos;
    size_t  sisize;
    char*   pletters = (char*)"!#$%&'()+;=@[]^_`~{}";   // 混入NG
    char*   palphabet= (char*)"abcdefghijklmnopqrstuvwxyz";
    char*   pnumeric = (char*)"0123456789";
    std::string str[5];
    // new, delete
    ecode*  pec = (ecode*)0;

    sisize = mstrTarget.size();
    if (sisize != (size_t)FN_LENGTH) {                  // 固定長のはず
		pec = new ecode(ecode::eVALUE::eSTRSIZE, __FUNCTION__, "size() != FN_LENGTH");
		pec->output();
		rc = pec->rc();									// 戻り値に変換
        goto EXIT_FUNCTION;
    }

    si_pos = mstrTarget.find(mstrSepa);                 // 拡張子直前に区切り文字があるはず
    if (si_pos == std::string::npos) {
		pec = new ecode(ecode::eVALUE::eSTRNPOS, __FUNCTION__, "find(mstrSepa) == npos");
		pec->output();
		rc = pec->rc();									// 戻り値に変換
        goto EXIT_FUNCTION;
    }
    //区切り文字を拡張子に限定してはNG
    //else if (si_pos == (FN_PREFIX+FN_DATE+FN_SEQNO)) {
    //    ;                                               // プレフィックス+日付+通番の次に区切り文字があるはず
    //}
    //else {
    //    return RET_FAILED;
    //}

    si_pos = mstrTarget.find(pletters);                 // 半角記号混入はNG
    if (si_pos != std::string::npos) {
		pec = new ecode(ecode::eVALUE::eSTRNPOS, __FUNCTION__, "find(pletters) != npos");
		pec->output();
		rc = pec->rc();									// 戻り値に変換
        goto EXIT_FUNCTION;
    }

    str[0] = mstrTarget.substr(0, FN_PREFIX);           // RFORDER
    str[1] = mstrTarget.substr(FN_PREFIX, FN_DATE);     // 20090915
    str[2] = mstrTarget.substr((FN_PREFIX+FN_DATE), FN_SEQNO);
                                                        // 00017
    str[3] = mstrTarget.substr((FN_PREFIX+FN_DATE+FN_SEQNO), 1);
    str[4] = mstrTarget.substr((FN_PREFIX+FN_DATE+FN_SEQNO+1), FN_EXT);

    // プレフィックスに数値文字が混入してもOK
    //si_pos = str[0].find(pnumeric);
    //if (si_pos != std::string::npos) {                  // プレフィックスに数値文字列はNG
    //    return RET_FAILED;
    //}

    // 日付と通番はORDERファイル取得時に更新されているか、参照するため、数値であることをチェック
    si_pos = str[1].find(palphabet);                    // 日付にアルファベットNG
    if (si_pos != std::string::npos) {
		pec = new ecode(ecode::eVALUE::eSTRNPOS, __FUNCTION__, "str[1].find(palphabet) != npos");
		pec->output();
		rc = pec->rc();									// 戻り値に変換
        goto EXIT_FUNCTION;
    }

    si_pos = str[2].find(palphabet);                    // 通番にアルファベットNG
    if (si_pos != std::string::npos) {
		pec = new ecode(ecode::eVALUE::eSTRNPOS, __FUNCTION__, "str[2].find(palphabet) != npos");
		pec->output();
		rc = pec->rc();									// 戻り値に変換
        goto EXIT_FUNCTION;
    }

    if (str[3] != ".") {
		pec = new ecode(ecode::eVALUE::eSTRNPOS, __FUNCTION__, "str[3] != .");
		pec->output();
		rc = pec->rc();									// 戻り値に変換
        goto EXIT_FUNCTION;
    }

    // str[4]は拡張子に数値文字が混入してもOK

    // 検査完
    vString.clear();
    vString.push_back(str[0]);
    vString.push_back(str[1]);
    vString.push_back(str[2]);
    vString.push_back(str[3]);
    vString.push_back(str[4]);

EXIT_FUNCTION:
	if (pec) {delete pec;} 

    return rc;
}

/*!
 * @file		filename.cpp
 * @fn			bool filename::operator==(const char* pCmp) const
 * @brief		文字列比較
 * @details		文字列比較
 * @return		true : 一致
 * 				false: 不一致
 * @param[in]	const char* pCmp    比較文字列
 * @date		1970/1/1
 * @note        ***
 */
bool filename::operator==(const char* pCmp) const
{
    std::string strcmp = pCmp;
    return mstrTarget == strcmp ? true: false;
}

bool filename::operator==(std::string& rCmp) const
{
    return mstrTarget == rCmp ? true: false;
}

/*!
 * @file		filename.cpp
 * @fn			int filename::left(std::string& rString, const char* pSepa)
 * @brief		区切り文字の左側文字列を取得
 * @details		区切り文字の左側文字列を取得
 * @return		0 <  Return value: TBD
 * 				0 == Return value: 失敗・区切り文字列見つからない等
 * 				0 >  Return value: 文字列長
 * @param[out]	rString			左側文字列
 * @date		2022/3/18
 * @note        RFORDER2009091500017.ORDに対して、区切り文字列2009を指定すると、プレフィックスが取得できる
 */
int filename::left(std::string& rString)
{
    if (mstrSepa.size() == 0) {
        return 0;                                       // 0byte
    }
    if (mstrTarget.size() == 0) {
        return 0;                                       // 0byte
    }

    std::string str;
    size_t      sipos;

    sipos = mstrTarget.find(mstrSepa);
    if (sipos == std::string::npos) {
        return 0;                                       // 0byte
    }

    str = mstrTarget.substr(0, sipos);
    if (str.size() == 0) {
        return 0;                                       // 0byte
    }

    rString = str;

    return (int)rString.size();                         //※ size_t->int
}

int filename::left(std::string& rString, const char* pTarget, const char* pSepa)
{
    int rc = this->initialize(pTarget, pSepa);
    if (rc < 0) {
        return rc;
    }

    return this->left(rString);
}

/*!
 * @file		filename.cpp
 * @fn			int filename::right(std::string& rString, const char* pSepa)
 * @brief		区切り文字の右側文字列を取得
 * @details		区切り文字の右側文字列を取得
 * @return		0 <  Return value: TBD
 * 				0 == Return value: 失敗・区切り文字列見つからない等
 * 				0 >  Return value: 文字列長
 * @param[out]	rString			右側文字列
 * @date		2022/3/18
 * @note        RFORDER2009091500017.ORDに対して、区切り文字列RFORDERを指定すると、日付,通番,拡張子が取得できる
 */
int filename::right(std::string& rString)
{
    if (mstrSepa.size() == 0) {
        return 0;                                       // 0byte
    }
    if (mstrTarget.size() == 0) {
        return 0;                                       // 0byte
    }

    std::string str;
    size_t      sipos;
    size_t      silen;
    size_t      silen_left;

    sipos = mstrTarget.find(mstrSepa);
    if (sipos == std::string::npos) {
        return 0;                                       // 0byte
    }
    sipos++;                                            // 区切り文字の右隣から取得

    silen_left = sipos;
    silen = mstrTarget.size();

    str = mstrTarget.substr(sipos, silen - silen_left);
    if (str.size() == 0) {
        return 0;                                       // 0byte
    }

    rString = str;
    return (int)rString.size();                         //※size_t->int
}

/*!
 * @file		filename.cpp
 * @fn			int filename::cmp_time(const char* pDate1, const char* pDate2)
 * @brief		時刻比較
 * @details		時刻比較
 * @return		-1 <  Return value: エラーコード
 * 				-1 == Return value: rF2は過去
 * 		         0 == Return value: 同時刻
 * 				 1 == Return value: rF2は未来
 * @param[in]	pDate1              ファイル名日付
 * @param[in]	pDate2              ファイル名日付
 * @date		1970/3/18
 * @note        ***
 */
int filename::cmp_time(const char* pDate1, const char* pDate2)
{
    int         rc = RET_FAILED;
    __time64_t  result[2];                              // [0]: rF1, [1]: rF2

    result[0] = mktime::conv(pDate1);
    result[1] = mktime::conv(pDate2);

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

/*!
 * @file		filename.cpp
 * @fn			int filename::cmp_seqno(const char* pSeqNo1, const char* pSeqNo2)
 * @brief		シーケンスNo比較
 * @details		シーケンスNo比較
 * @return		-1 == Return value: pSeqNo1 >  pSeqNo2
 * 		         0 == Return value: pSeqNo1 == pSeqNo2
 * 				 1 == Return value: pSeqNo1 <  pSeqNo2
 * @param[in]	pSeqNo1			通番
 * @param[in]	pSeqNo2			通番
 * @date		2022/4/11
 * @note        
 */
int filename::cmp_seqno(const char* pSeqNo1, const char* pSeqNo2)
{
    using namespace std;

    int                 rc = RET_FAILED;
    string              str[2];
    string              str_tmp[2];
    string::size_type   szlen[2];
    string::size_type   sz_pos[2];
    string::size_type   sz_copy[2];

    std::stringstream   ss[2];
    int                 seqno[2];

    str[0] = pSeqNo1;
    str[1] = pSeqNo2;

    szlen[0] = str[0].size();
    szlen[1] = str[1].size();

    // 有効数値文字列の左側0文字列は不要
    sz_pos[0] = str[0].find_first_not_of("0");          // Ex. 00001
    sz_pos[1] = str[1].find_first_not_of("0");          // Ex. 00001

    sz_copy[0] = szlen[0] - sz_pos[0];
    sz_copy[1] = szlen[1] - sz_pos[1];

    // 有効数値文字列
    str_tmp[0] = str[0].substr(sz_pos[0], sz_copy[0]);
    str_tmp[1] = str[1].substr(sz_pos[1], sz_copy[1]);

    ss[0] << str_tmp[0];
    ss[1] << str_tmp[1];

    ss[0] >> seqno[0];                                  // 文字列=>整数
    ss[1] >> seqno[1];                                  // 文字列=>整数

    if (seqno[0] < seqno[1]) {
        rc = 1;
    }
    else if  (seqno[0] > seqno[1]) {
        rc = -1;
    }
    else {
        rc = 0;
    }

    return rc;
}

int filename::make(std::string& rFullpath, int siSeqNo)
{

    return RET_SUCCESS;
}