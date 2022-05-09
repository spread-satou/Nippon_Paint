#pragma once
#include <windows.h>
#include <vector>
#include <string>

#include "comport.h"

class ccmmsg
{
protected:
//public:
    comport*    mpCom;

public:
    ccmmsg();                                           //! 未サポート
    ccmmsg(const char* pPort);
    virtual ~ccmmsg();

    comport* getcomobj(void) {return mpCom;}

    int setdcb(DCB& rDCB);
    int receiver(int siMsgFmt, std::vector<std::string>& rvParams);

    size_t getmsg(std::string& rString);
protected:
    //int receiver();
    int initialize(void);
    int variables(void);
};

