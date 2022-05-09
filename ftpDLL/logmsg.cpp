#include "pch.h"
#include "logmsg.h"
#include "ecode.h"
#include <iostream>
#include <fstream>

using namespace std;

logmsg::logmsg()
{
    this->initialize();
}

logmsg::logmsg(const char* pFmt)
{
    this->initialize();

    mstrFmt = pFmt;
}

logmsg::~logmsg()
{
    this->variables();
}

int logmsg::initialize(void)
{
    return this->variables();
}

int logmsg::variables(void)
{
    mstrFmt.clear();
    return RET_SUCCESS;
}

int logmsg::append_writer(const char* pFullpath, const char* pText)
{
    ofstream ofs(pFullpath, ios_base::out | ios_base::app);
    ofs << pText << std::endl;
    ofs.close();
    return RET_SUCCESS;
}

/*!
 * @file		logmsg.cpp
 * @fn			int logmsg::writer(int* pCtrl, const char* pFullpath)
 * @brief		ファイル出力(append)
 * @details		ファイル出力(append)
 * @return		0 <  Return value: TBD
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @param[in]	pCtrl			出力制御
 *                              1: コンソール出力あり
 *                              0: コンソール出力なし
 * @param[in]	pFullpath		ファイル名
 * @date		2022/3/31
 * @note        
 */
int logmsg::writer(int* pCtrl, const char* pFullpath)
{
    //ofstream ofs(pFullpath, ios_base::out | ios_base::app);
    //ofs << mstrFmt << std::endl;
    //ofs.close();

    this->append_writer(pFullpath, mstrFmt.c_str());
    if (*pCtrl == 1) {
        cout << mstrFmt.c_str() << std::endl;
    }
    return RET_SUCCESS;
}

/*!
 * @file		logmsg.cpp
 * @fn			int logmsg::writer(int* pCtrl, const char* pFullpath, const char* ps8Value)
 * @brief		ファイル出力(append)
 * @details		ファイル出力(append)
 * @return		0 <  Return value: TBD
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @param[in]	pCtrl			出力制御
 *                              1: コンソール出力あり
 *                              0: コンソール出力なし
 * @param[in]	pFullpath		ファイル名
 * @param[in]	ps8Value		書式化に必要な文字列ポインタ
 * @date		2022/3/31
 * @note
 */
int logmsg::writer(int* pCtrl, const char* pFullpath, const char* ps8Value)
{
    int     rc = RET_SUCCESS;
    // new, delete
    char*   pwork = (char*)0;

    pwork = new char[DMSG_BUFFSIZE];
    if (pwork == (char*)0) {
		ecode	retobj(ecode::eVALUE::eNEW, __FUNCTION__, "0 = new char[DMSG_BUFFSIZE]");
		retobj.output();
		rc = retobj.rc();								// 戻り値に変換
        return rc;
    }

    ::memset(pwork, 0x00, DMSG_BUFFSIZE);
    ::snprintf(pwork, DMSG_BUFFSIZE, mstrFmt.c_str(), ps8Value);

    //ofstream ofs(pFullpath, ios_base::out | ios_base::app);
    //ofs << pwork << std::endl;
    //ofs.close();

    this->append_writer(pFullpath, pwork);
    if (*pCtrl == 1) {
        cout << pwork << std::endl;
    }

    delete[] pwork;
    return rc;
}

/*!
 * @file		logmsg.cpp
 * @fn			int logmsg::writer(int* pCtrl, const char* pFullpath, int siValue)
 * @brief		ファイル出力(append)
 * @details		ファイル出力(append)
 * @return		0 <  Return value: TBD
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @param[in]	pCtrl			出力制御
 *                              1: コンソール出力あり
 *                              0: コンソール出力なし
 * @param[in]	pFullpath		ファイル名
 * @param[in]	siValue         書式化に必要な文字列ポインタ
 * @date		2022/3/31
 * @note
 */
int logmsg::writer(int* pCtrl, const char* pFullpath, int siValue)
{
    int     rc = RET_SUCCESS;
    // new, delete
    char*   pwork = (char*)0;

    pwork = new char[DMSG_BUFFSIZE];
    if (pwork == (char*)0) {
		ecode	retobj(ecode::eVALUE::eNEW, __FUNCTION__, "0 = new char[DMSG_BUFFSIZE]");
		retobj.output();
		rc = retobj.rc();								// 戻り値に変換
        return rc;
    }

    ::memset(pwork, 0x00, DMSG_BUFFSIZE);
    ::snprintf(pwork, DMSG_BUFFSIZE, mstrFmt.c_str(), siValue);

    //ofstream ofs(pFullpath, ios_base::out | ios_base::app);
    //ofs << pwork << std::endl;
    //ofs.close();

    this->append_writer(pFullpath, pwork);
    if (*pCtrl == 1) {
        cout << pwork << std::endl;
    }

    delete[] pwork;
    return RET_SUCCESS;
}

