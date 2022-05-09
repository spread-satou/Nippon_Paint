#pragma once

extern "C" {
#include <winsock2.h>
#pragma comment(lib, "Ws2_32.lib")
#include <ws2tcpip.h>
};

#include "reply.h"
#include <vector>

//! プリプロセッサ
//#define DBG_FLAG				true
#define DBG_FLAG				false

#define SOCPORT_LOCAL			0xc000					// ローカルPC
#define SOCPORT_CTRL			21						// サーバー 21:制御
#define SOCPORT_TRAN        	20						// サーバー 20:データ転送
#define SOCRECV_MAX_SIZE		1024
#define FTP_TIMEOUT				(20 * (1000))			// 20秒(LANケーブル未接続時、connect()から制御が戻ってくる時間が20秒)
#define FTP_WAITTIME            500                     // 仮の値

// eSOCKET_NAMEの定義場所をeNAME_CTRL, eNAME_TRANの定義場所から離すとわかりにくくなると思う
enum class eSOCKET_NAME {
	eCTRL,
	eTRAN,
	eNUMB
};

#define ESOCK					(int)eSOCKET_NAME
#define SOCCTRL					(int)ftpsocket::eNAME_CTRL
#define SOCTRAN					(int)ftpsocket::eNAME_TRAN

/*!
 * @brief SOCKET基本クラス
 */
class ftpsocket
{
public:
	//! 制御SOCKET名
	enum class eNAME_CTRL {
		eMAIN,
		eRESV,					// 予約
		eNUMB
	};

	//! 転送SOCKET名
	enum class eNAME_TRAN {
		eLISTEN,
		eACCEPT,
		eNUMB
	};

	unsigned short mu16PORT;							//! クライアントポート番号

protected:
	/*
	 * データ転送PORTでは、listen()用のSOCKETとaccept()用のSOCKETが分かれている
	 */
	std::vector<SOCKET>	mvSD;							//! 1ポート複数SOCKET対応
														//	[0] eMAIN/eLISTEN
														//	[1] eRESV/eACCEPT
public:
    ftpsocket();
    virtual ~ftpsocket();

	// 初期化
	virtual int initialize(void);
	virtual int initialize(ADDRINFOA& rAI, void* pArgs);
	virtual int	release(int siName) = 0;

	// 接続, 切断
	virtual int	connect(int siName) = 0;
	virtual int	disconnect(int siName) = 0;

	// 送受信
	virtual int sender(int isName, int siWait, const char* pMsg, size_t siLeng, int siFlags = 0);
	virtual int receiver(int isName, int siWait, char* pBuffer, size_t siLeng, int siFlags = 0);

	// 派生クラスで。
	//ftpsocket& operator=(SOCKET& rSOCKET);
	//operator SOCKET() const;
	virtual SOCKET getter(void) = 0;

	// static
	static void addrinfo(ADDRINFOA* pINFO, int isPORT);

protected:
	virtual int variables(void);

};

