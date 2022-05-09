#pragma once
#include "ftpseq.h"

/*!
 * @brief イベント待ち シーケンス
 * @note  RFC959 なし
 */
class seqwaiting :
    public ftpseq
{
public:
    seqwaiting();
    seqwaiting(ftpsocket* pSOCKET);
    virtual ~seqwaiting();

    int initialize(void);
    virtual int enter(void* pArgs);
    virtual int exec(void* pArgs);
    virtual int exit(void* pArgs);

protected:
    virtual int variables(void);
};

