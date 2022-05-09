#pragma once
#include "ftpsocket.h"

/*!
 * @brief データ転送ラインSOCKET
 */
class ftpsocket_tran :
			public ftpsocket
{
protected:

public:
    ftpsocket_tran();
    virtual ~ftpsocket_tran();

	SOCKET	getter(void) {return mvSD[SOCTRAN::eLISTEN];}

	// 初期化
	int variables(void);
	virtual int initialize(ADDRINFOA& rAI, void* pArgs);
	virtual int	release(int siName);

    // 接続(accept)
    virtual int connect(int siName);
    virtual int disconnect(int siName);

    // 受信
    virtual int sender(int siWait, const char* pMsg, size_t siLeng);
    virtual int receiver(int siWait, int siZero, std::string& rMsg);    // データTRANSFERライン用
    //virtual int dataline_receiver(int siWait, std::string& rMsg);     // データTRANSFERライン用
};

