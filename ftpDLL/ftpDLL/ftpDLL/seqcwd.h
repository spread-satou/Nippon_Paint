#pragma once
#include <string>
#include "ftpseq.h"

/*!
 * @brief CHANGE WORKING DIRECTORY (CWD) コマンドシーケンス
 * @note  RFC959 ACCESS CONTROL COMMANDS
 */
class seqcwd :
    public ftpseq
{
protected:
    std::string mstrSubd;
    std::string mstrRoot;

public:
    seqcwd();
    seqcwd(ftpsocket* pSOCKET, const char* pRoot, const char* pSubdir);                            // 絶対パス
    virtual ~seqcwd();

    int initialize(void);

    virtual int enter(void* pArgs);
    virtual int exec(void* pArgs);
    virtual int exit(void* pArgs);

protected:
    virtual int variables(void);
};

