#pragma once
#include "ftpseq.h"
#include "ftpsocket.h"

/*!
 * @brief SYSTEM (SYST) コマンドシーケンス
 * @note  RFC959 Informational commands
 */
class seqsyst :
    public ftpseq
{
public:
    seqsyst();
    seqsyst(ftpsocket* pSOCKET);
    virtual ~seqsyst();

    int initialize(void);
    virtual int enter(void* pArgs);
    virtual int exec(void* pArgs);
    virtual int exit(void* pArgs);

protected:
    virtual int variables(void);
};

