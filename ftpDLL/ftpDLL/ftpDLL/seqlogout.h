#pragma once
#include "ftpseq.h"

/*!
 * @brief ログアウト(QUIT) コマンドシーケンス
 * @note  RFC959 ACCESS CONTROL COMMANDS
 */
class seqlogout :
    public ftpseq
{
public:
    seqlogout();
    seqlogout(ftpsocket* pSOCKET);
    virtual ~seqlogout();

    int initialize(void);

    virtual int enter(void* pArgs);
    virtual int exec(void* pArgs);
    virtual int exit(void* pArgs);

protected:
    virtual int variables(void);
};

