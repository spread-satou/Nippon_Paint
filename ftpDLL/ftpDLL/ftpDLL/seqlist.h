#pragma once
#include "ftpseq.h"

/*!
 * @brief LIST コマンドシーケンス
 * @note  RFC959 FTP SERVICE COMMANDS
 */
class seqlist :
    public ftpseq
{
protected:
    std::string mPath;

public:
    seqlist();
    seqlist(ftpsocket* pSOCKET, const char* pPath);
    virtual ~seqlist();

    int initialize(void);
    virtual int enter(void* pArgs);
    virtual int exec(void* pArgs);
    virtual int exit(void* pArgs);

protected:
    virtual int variables(void);
};

