#pragma once
#include "ftpseq.h"

/*!
 * @brief NAME LIST (NLST) コマンドシーケンス
 * @note  RFC959 FTP SERVICE COMMANDS
 */
class seqnlst :
    public ftpseq
{
protected:

public:
    seqnlst();
    seqnlst(ftpsocket* ptranSOCKET, ftpsocket* pSOCKET);
    virtual ~seqnlst();

    int initialize(void);

    virtual int enter(void* pArgs);
    virtual int exec(void* pArgs);
    virtual int exit(void* pArgs);

protected:
    virtual int variables(void);
};

