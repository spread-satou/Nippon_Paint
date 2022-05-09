#pragma once
#include "ftpsocket_ctrl.h"
#include "ftpsocket_tran.h"
#include <string>

#define ERESULT                 (int)ftpcmd::eRESULT

class ftpcmd
{
protected:
    ftpsocket_ctrl* mpSocCtlr;
    ftpsocket_tran* mpSocTran;
    std::string     mstrCmd;
    unsigned long   mu32Wait;                           // [msec]

public:
    enum class eRESULT {
        eFAILURE= -3,                                   // RFC959 failure
        eERROR  = -2,                                   // RFC959 error
        eFAILED = -1,                                   // eVALUE::eFAILEDと一致

        eSUCCESS= 0,                                    // eVALUE::eSUCCESSと一致
        eCONTINUE,

        eNUMB
    };

public:
    ftpcmd();
    ftpcmd(ftpsocket** pSocket, const char* pCommand);
    virtual ~ftpcmd();

    int variables(void);

    int groupup(void* pArgs);
    int group1(std::string& rRsp, void* pArgs);
    int group2(std::string& rRsp, void* pArgs);

    // 削除予定
    //int up(std::string& rCommand, void* pArgs);
    //int cmd1(std::string& rCmd, std::string& rRsp, void* pArgs);
    //int cmd2(std::string& rCmd, std::string& rRsp, void* pArgs);

protected:
    int newBuffer(char** pBuffer, int bufSize);
    int splitter(std::string& strDest, char* pBuffer, size_t siLength);
};

