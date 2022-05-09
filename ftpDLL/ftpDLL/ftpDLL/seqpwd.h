#pragma once
#include "ftpseq.h"

/*!
 * @brief PRINT WORKING DIRECTORY (PWD) コマンドシーケンス
 * @note  RFC959 FTP SERVICE COMMANDS
 */
class seqpwd :
    public ftpseq
{
public:
    seqpwd();
    seqpwd(ftpsocket* pSOCKET);
    virtual ~seqpwd();

    int initialize(void);

    virtual int enter(void* pArgs);
    virtual int exec(void* pArgs);
    virtual int exit(void* pArgs);

protected:
    virtual int variables(void);
};

