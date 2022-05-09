#pragma once
#include "ftpseq.h"
#include "ftpsocket.h"
#include <string>

/*!
 * @brief DOWNLOAD(RETRIEVE (RETR)) コマンドシーケンス
 * @note  RFC959 FTP SERVICE COMMANDS
 */
class seqretr :
    public ftpseq
{
protected:
    std::string mstrPathname;                           //! パス名文字列

public:
    seqretr();
    seqretr(ftpsocket* ptranSOCKET, ftpsocket* pSOCKET);
    virtual ~seqretr();

    int initialize(void);

    virtual int enter(void* pArgs);
    virtual int exec(void* pArgs);
    virtual int exit(void* pArgs);

protected:
    virtual int variables(void);
};

