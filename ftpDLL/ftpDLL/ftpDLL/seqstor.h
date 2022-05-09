#pragma once
#include "ftpseq.h"

/*!
 * @brief UPLOAD(STORE (STOR)) コマンドシーケンス
 * @note  RFC959 FTP SERVICE COMMANDS
 */
class seqstor :
    public ftpseq
{
protected:
    std::string mstrPathname;                           //! パス名文字列

public:
    seqstor();
    seqstor(ftpsocket* ptranSOCKET, ftpsocket* pSOCKET);
    virtual ~seqstor();

    int initialize(void);

    virtual int enter(void* pArgs);
    virtual int exec(void* pArgs);
    virtual int exit(void* pArgs);

protected:
    virtual int variables(void);
};

