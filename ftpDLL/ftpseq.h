#pragma once
extern "C" {
#include <winsock2.h>
#pragma comment(lib, "Ws2_32.lib")
#include <ws2tcpip.h>
};

#include <string>
#include "ftpsocket_ctrl.h"

#define ESTATE					(int)ftpseq::eSTATE

class ftpseq
{
public:
	enum class eSTATE {									//! シーケンスSTATUS
		eWAITING,										// シーケンス開始待ちSTATUS
		eRESTART,										// コマンドなし

		// 制御ラインのみ
		eLOGIN,											// "USER (GUI)" & "PASS (GUI)"
		eLOGOUT,										// "QUIT"

		eTYPE,											// "TYPE I", I:固定値
		eSYST,											// "SYST"
		eCWD,											// "CWD (GUI)"
		eCDUP,											// "CDUP"

		// データ転送ライン併用
		ePASV,											// 未使用
		ePORT,											// "PORT (クライアントIP, サーバーPORT)"
		eNLST,											// "NLST *.*"
		eDOWNLOAD,										// "RETR (ファイル名)"	SND/ORDER
		eUPLANS,										// "STOR (ファイル名)"	SND/ANSWER
		eUPLNTY,										// "STOR (ファイル名)"	RCV/NOTIFY

		// デバッグ用
		ePWD,											// "PWD"
		// 以下、未確認
		eLIST,											// "LIST"

		// 終端
		eNUMB
	};

protected:
	int			mmyState;								//! カレントSTATUS
	ftpsocket*	mpSOCKET[2];							//! SOCKETオブジェクト
														//	[0]制御ライン
														//	[1]データ転送ライン
public:
	ftpseq();
	virtual ~ftpseq();

	virtual int enter(void* pArgs) = 0;
	virtual int exec(void* pArgs)  = 0;
	virtual int exit(void* pArgs)  = 0;

protected:
	virtual int variables(void);

	int	newBuffer(char** pBuffer, int bufSize);
    int up(ftpsocket& rSD, std::string& rCommand, void* pArgs);
    int cmd1(ftpsocket& rSD, std::string& rCmd, std::string& rRsp, void* pArgs);
    int cmd2(ftpsocket& rSD, std::string& rCmd, std::string& rRsp, void* pArgs);
};

