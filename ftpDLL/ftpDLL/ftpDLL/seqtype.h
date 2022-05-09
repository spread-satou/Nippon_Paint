#pragma once
#include "ftpseq.h"
#include "ftpsocket.h"

/*!
 * @brief REPRESENTATION TYPE (TYPE) コマンドシーケンス
 * @note  RFC959 TRANSFER PARAMETER COMMANDS
 */
class seqtype :
    public ftpseq
{
public:
    seqtype();
    seqtype(ftpsocket* pSOCKET);
    virtual ~seqtype();

    int initialize(void);
    virtual int enter(void* pArgs);
    virtual int exec(void* pArgs);
    virtual int exit(void* pArgs);

protected:
    virtual int variables(void);

    //実験
    //int command_pasiv(ftpsocket** pSOCKET, int *psiIP, int* psiPORT);
};

