#pragma once
#include <string>
#include <Windows.h>

#define ESTATUS         (int)comport::eSTATUS
#define CNT_ZEROBYTE    3
#define ERR_ZEROBYTE    5

class comport
{
protected:
	enum class eSTATUS {
		eWait,
		eRecv,
		eFailSafe,
		eEXIT,
		eERROR,
		eNUMB
	};

protected:
	std::string	mstrPort;
	HANDLE		mHandle;
	DCB			mDCB;									//! device control block
	char*		mpBuffer;								//! 受信メッセージ
	int			msiMsgSize;

public:
	comport();
	comport(const char* pPort);
	virtual ~comport();

	int initdcb(DCB& rDCB);
	int	clear(void);
	int setdcb(DCB& rDCB);

	int receiver(int siMsgFmt, const char* pStopper);

	const char* get_pointer(void) { return (const char*)mpBuffer; }
	int		getsize() {return msiMsgSize;}
	size_t	getmsg(std::string& rString);

	//void test_comm() {
	//	BOOL    ret_wlib;
	//	ret_wlib = ::SetCommMask(mHandle, EV_ERR);
	//}

protected:
	int initialize(const char* pPort);
	int variables(void);
};

