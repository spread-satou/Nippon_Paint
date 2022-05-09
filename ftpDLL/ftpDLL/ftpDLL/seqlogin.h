#pragma once
#include <string>

#include "ftpseq.h"
#include "ftpsocket.h"

/*!
 * @brief ログイン(USER～PASS～ACCT) コマンドシーケンス
 * @note  RFC959 ACCESS CONTROL COMMANDS
 */
class seqlogin :
    public ftpseq
{
protected:
    std::string mUsername;
    std::string mPassword;
    std::string mAccount;

public:
    seqlogin();
    seqlogin(ftpsocket* pSOCKET, const char* pUSER, const char* pPASS, const char* pACCT=0);
    virtual ~seqlogin();

    int initialize(void);
    int setter(ftpsocket* pSOCKET, const char* pUSER, const char* pPASS, const char* pACCT);

    virtual int enter(void* pArgs);
    virtual int exec(void* pArgs);
    virtual int exit(void* pArgs);

protected:
    virtual int variables(void);

private:
    //int user(ftpsocket_ctrl& rSD, void* pArgs);
    //int pass(ftpsocket_ctrl& rSD, void* pArgs);
    int acct(ftpsocket& rSD, void* pArgs);
};

