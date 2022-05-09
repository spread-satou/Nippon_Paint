#pragma once
#include "ftpseq.h"

/*!
 * @brief CHANGE TO PARENT DIRECTORY (CDUP) コマンドシーケンス
 * @note  RFC959 ACCESS CONTROL COMMANDS
 */
class seqcdup :
    public ftpseq
{
public:
    seqcdup();
    seqcdup(ftpsocket* pSOCKET);
    virtual ~seqcdup();

    int initialize(void);

    virtual int enter(void* pArgs);
    virtual int exec(void* pArgs);
    virtual int exit(void* pArgs);

protected:
    virtual int variables(void);
};

