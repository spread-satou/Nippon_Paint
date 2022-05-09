#pragma once
#include "ftpseq.h"

/*!
 * @brief RESTART シーケンス(コマンドなし)
 * @note  切断・再接続シーケンス
 */
class seqrestart :
    public ftpseq
{
protected:
    std::string mstrIPv4;
    std::string mstrPORT;

public:
    seqrestart();
    seqrestart(ftpsocket* pSOCKET);
    virtual ~seqrestart();

    int initialize(void);

    virtual int enter(void* pArgs);
    virtual int exec(void* pArgs);
    virtual int exit(void* pArgs);

    void setai(const char* pIPv4, const char* pPORT);
protected:
    virtual int variables(void);
};

