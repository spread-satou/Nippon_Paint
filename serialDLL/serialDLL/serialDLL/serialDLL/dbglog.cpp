#include "pch.h"
#include "dbglog.h"
#include "ecode.h"
#include "def_buffer.h"
#include <iostream>
#include <fstream>

using namespace std;

//! RANK
static const int tEnaRank[ERANK::eNUMB] = {
    1,                              // FATAL
    1,                              // DEBUG
    0                               // MEMO
};

//! RANK文字列
static const char* ptRank[ERANK::eNUMB] = {
    "FATAL",
    "DEBUG",
    "MEMO#",
};

//! 機能名
static const int tEnaName[ENAME::eNUMB] = {
    1,                              // main
    1,                              // xxxx

    1,                              // CCM
    0                               // T.B.D
};

//! 機能名文字列
static const char* ptName[ENAME::eNUMB] = {
    "MAIN",
    "****",

    "CCM",
    "TBD#"
};

dbglog::dbglog()
{

}

dbglog::~dbglog()
{

}

int dbglog::initialize(void)
{
    this->variables();
    return RET_SUCCESS;
}

int dbglog::variables(void)
{
    return RET_SUCCESS;
}

//static
int dbglog::output(int siCtrl, int siRank, int siName, const char* pDetailmsg)
{
    const char* pcolor[ECTRL::eNUMB] = {
        "\033[37m",                 // 使用禁止
        "\033[37m",                 // white
        "\033[31m",                 // red
        "\033[32m",                 // green
        "\033[33m",                 // yellow
        "\033[36m"                  // TBD(使用禁止)
    };

    const char* pr = ptRank[siRank];
    const char* pn = ptName[siName];

    char* pbuff = new char[DMSG_BUFFSIZE];
    memset(pbuff, 0x00, DMSG_BUFFSIZE);

    if  ((tEnaRank[siRank]) && (tEnaName[siName])) {
        snprintf(pbuff, DMSG_BUFFSIZE, "[%s][%s]%s", pr, pn, pDetailmsg);
        //std::cout << pcolor[siCtrl] << pbuff << "\033[39m";
        printf("%s\n", pbuff);
    }

    delete[] pbuff;
    return RET_SUCCESS;
}

int dbglog::text_writer(const char* pFullpath, std::string& strData)
{
//    ofstream ofs(pFullpath);
    ofstream ofs(pFullpath, ios_base::binary | ios_base::out);
    ofs << strData;
    ofs.close();
    return RET_SUCCESS;
}

int dbglog::append_writer(const char* pFullpath, std::string& strData)
{
    // 最新仕様では、CRLFがメッセージ終端に含まれるので、不要
    ofstream ofs(pFullpath, ios_base::binary | ios_base::out | ios_base::app);
    ofs << strData;
    //ofs << strData << std::endl;                        // CRLF
    ofs.close();
    return RET_SUCCESS;
}
