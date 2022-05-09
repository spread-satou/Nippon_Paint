#pragma once
#include "ftpseq.h"
#include "ftpsocket.h"

/*!
 * @brief PASSIVE (PASV) コマンドシーケンス
 * @note  RFC959 TRANSFER PARAMETER COMMANDS
 */
class seqpasv :
    public ftpseq
{
public:
    int msiIP[4];
    int msiPORT[2];

public:
    seqpasv();
    seqpasv(ftpsocket* ptranSOCKET, ftpsocket* pSOCKET);
    virtual ~seqpasv();

    int initialize(void);

    virtual int enter(void* pArgs);
    virtual int exec(void* pArgs);
    virtual int exit(void* pArgs);

protected:
    virtual int variables(void);
};

