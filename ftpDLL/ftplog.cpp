#include "pch.h"
#include "ftplog.h"
#include "ecode.h"
#include <iostream>
#include <fstream>
#include <string>
#include <windows.h>

#include "thr_semaphore.h"
#include "util_fullpath.h"

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
    1,                              // sim

    1,                              // socket
    1,                              // BG nlst
    1,                              // BG retr
    1,                              // BG stor1
    1,                              // BG stor2

    1,                              // cdup

    1,                              // cwd
    1,                              // user
    1,                              // pass
    1,                              // quit

    1,                              // port
    1,                              // pwd

    1,                              // nlst
    1,                              // rstart
    1,                              // retr
    1,                              // stor

    1,                              // syst
    1,                              // type

    0                               // T.B.D
};

//! 機能名文字列
static const char* ptName[ENAME::eNUMB] = {
    "MAIN",
    "****",
    "SIMU",

    "SCKT",
    "bNLS",
    "bDWN",
    "bUP1",
    "bUP2",

    // SEQ
    "CDUP",
    "CWD#",
    "USER",
    "PASS",
    "QUIT",

    "PORT",
    "PWD#",
    "NLST",
    "RSTA",
    "RETR",
    "STOR",
    "SYST",
    "TYPE",
    "TBD#"
};

//! ログメッセージ
static const char* ptlogMsg[EMSG::eNUMB] = {
    // startup
    "Data communication task performed on: %s", // %s: yyyy/mm/dd HH:MM:SS
    "Cleaning old logs.",                       // TBD どこをclearning??
    "Orders automatically closed: %d",          // TBD %d: ナニコレ??
    "FTP on site :RF %d",                       // %d: 

    // job xxx message
    "FTP job started on: %s",                   // %s: YYYY/MM/DD HH:MM:SS
    "FTP job aborted upon operator request",
    "FTP job terminated on: %s",                // %s: YYYY/MM/DD HH:MM:SS

    // 接続ステータス
    //  Status:Connecting to 192.168.11.47.
    //  Status:Connected.
    //  Status:Connection established
    //  Status:Starting FTP transfer
    //  Status:Transfer complete
    "FTP connection parameters:",
    "- Host          : %s",
    "- Port          : %s",
    "- User          : %s",
    "- Password      : %s",
    "- Orders dir    : %s",
    "- Feedback dir  : %s",
    "- Notify dir    : %s",
    "Status:%s",
    "Status:Connecting to %s.",
    "Connection successful",
    "Disconnecting from FTP server",

    // コマンド
    "%s",                                       // command name. List
    "%s %s",                                    // Chdir SND/ORDER等

    // コマンド実行結果
    // NLST
    "Found %d order files to be processed",
    "No files in the orders directory",

    // RETR
    "Found %d files int the feedback directory",        // TBD まさか。。SND/ANSWERを検索??
    "Cross-checking order files with feedback files",   // TBD まさか。。SND/ORDER/*.ORDと比較??
    "Downloading order files to be processed",
    "Processing order files",

    // STOR OKY/ERR, NTY
    "Upload completed",

    // TBD
    "TBD %s"
};

//! 外部宣言
extern int sem_init(int siSEMID, LONG lInitialCount, LONG lMaximumCount);
extern int sem_wait(int siSEMID, DWORD dwMaxms, DWORD dwMilliseconds);
extern int sem_post(int siSEMID);
extern int sem_close(int siSEMID);

ftplog::ftplog()
{
    this->initialize();
}

ftplog::ftplog(const char* pFullpath)
{
    using namespace utility;

    string          str_fullpath;
    vector<string>  vstr_path;
    int             ii;

    this->initialize();

    // ■加工
    str_fullpath = pFullpath;
    fullpath::sepa(vstr_path, str_fullpath);

    // ログメッセージ配列
    for (ii = 0; ii < EMSG::eNUMB; ii++) {
        mvElement.push_back(new logmsg(ptlogMsg[ii]));
    }
}

ftplog::ftplog(const char* pDir, const char* pFn, const char* pExt)
{

}

ftplog::~ftplog()
{
    std::vector<logmsg*>::iterator iter;

    for (iter = mvElement.begin(); iter != mvElement.end(); iter++) {
        if (*iter != 0x00000000) {
            delete *iter;
        }
    }
    //mvElement.clear();
    this->variables();
}

int ftplog::initialize(void)
{
    this->variables();

    return RET_SUCCESS;
}

int ftplog::variables(void)
{
    int ii = 0;
    for(ii = 0; ii < EPATH::eNUMB; ii++) {
        mstrPath[ii].clear();
    }

    mvElement.clear();

    return RET_SUCCESS;
}

int ftplog::sync_init(void)
{
    return ::sem_init(ESEMID::eLOGFILE, 1/*initial*/, 1/*max*/);
}

int ftplog::sync_wait(void)
{
    return ::sem_wait(ESEMID::eLOGFILE, SEM_TIMEOUT, 1);
}

int ftplog::sync_post(void)
{
    return ::sem_post(ESEMID::eLOGFILE);
}

int ftplog::sync_close(void)
{
    return ::sem_close(ESEMID::eLOGFILE);
}

//static
int ftplog::output(int siCtrl, int siRank, int siName, const char* pDetailmsg)
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
        std::cout << pcolor[siCtrl] << pbuff << "\033[39m";
    }

    delete[] pbuff;
    return RET_SUCCESS;
}

int ftplog::text_writer(const char* pFullpath, std::string& strData)
{
    ofstream ofs(pFullpath);
    ofs << strData;
    ofs.close();
    return RET_SUCCESS;
}

//int ftplog::get_sta_performed(const char*pAdditional, int siFileFlg)
//{
//    std::string str_fullpath;
//    std::string str_1line;
//
//    char* pbuff = new char[DMSG_BUFFSIZE];
//    memset(pbuff, 0x00, DMSG_BUFFSIZE);
//
//    ::snprintf(pbuff, DMSG_BUFFSIZE, ptMsg[0], pAdditional);
//    str_1line = pbuff;
//
//    str_fullpath =  mstrPath[EPATH::eDIR] + "\\" +
//                    mstrPath[EPATH::eFN]  + "\\" +
//                    mstrPath[EPATH::eEXT];
//
//    ofstream ofs(str_fullpath.c_str(), ios_base::out|ios_base::app);
//    ofs << str_1line;
//    ofs.close();
//
//    delete[] pbuff;
//    return RET_SUCCESS;
//}
