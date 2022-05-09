#pragma once
#include "ftpseq.h"
#include "ftpsocket.h"
#include <string>

/*!
 * @brief DATA PORT (PORT) コマンドシーケンス
 * @note  RFC959 TRANSFER PARAMETER COMMANDS
 */
class seqport :
    public ftpseq
{
protected:

public:
    seqport();
    seqport(ftpsocket* ptranSOCKET, ftpsocket* pSOCKET);
    virtual ~seqport();

    int initialize(void);

    virtual int enter(void* pArgs);
    virtual int exec(void* pArgs);
    virtual int exit(void* pArgs);

protected:
    virtual int variables(void);

    //int command_pasiv(ftpsocket* pSOCKET, int *psiIP, int* psiPORT);
};

