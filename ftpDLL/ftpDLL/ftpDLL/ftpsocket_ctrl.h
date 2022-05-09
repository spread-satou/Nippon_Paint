#pragma once
#include "ftpsocket.h"

/*!
 * @brief 制御ラインSOCKET
 */
class ftpsocket_ctrl :
			public ftpsocket
{
protected:
	PADDRINFOA		mPAI;								//! 接続用アドレス情報

public:
	ftpsocket_ctrl();
	ftpsocket_ctrl(SOCKET sDescp);
	virtual ~ftpsocket_ctrl();

	ftpsocket_ctrl& operator=(SOCKET& rSOCKET);
	SOCKET	getter(void) {return this->mvSD[SOCCTRL::eMAIN];}

	// 初期化
	int variables(void);
	int initialize(ADDRINFOA& rAI, void* pArgs);
	int	release(int siName/*PADDRINFOA& rAI*/);

	// 接続, 切断
	int	connect(int siName/*PADDRINFOA pAI*/);
	int	disconnect(int siName/*PADDRINFOA& rAI*/);
};

