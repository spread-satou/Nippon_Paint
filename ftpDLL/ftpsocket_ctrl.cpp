#include "pch.h"
#include "ftpsocket_ctrl.h"
#include "winec.h"
#include "ecode.h"
#include "reply.h"

/*!
 * @file		ftpsocket_ctrl.cpp
 * @fn			ftpsocket_ctrl::ftpsocket_ctrl()
 * @brief		制御用、転送用ソケット(TBD)の基本クラス
 * @details		mSDはサーバーへアクセスするためのsocket descpritor
 * @date		1970/1/1
 */
ftpsocket_ctrl::ftpsocket_ctrl()
{
	this->variables();
}

ftpsocket_ctrl::ftpsocket_ctrl(SOCKET sDescp)
{
	this->variables();
	this->mvSD[SOCCTRL::eMAIN] = sDescp;				//mCSD = sDescp;
}

ftpsocket_ctrl::~ftpsocket_ctrl()
{

}

/*!
 * @file		ftpsocket_ctrl.cpp
 * @fn			ftpsocket_ctrl& ftpsocket_ctrl::operator=(SOCKET& rSOCKET)
 * @brief		ソケットコピー
 * @details		引数のソケットをメンバ変数のソケットに代入
 * @return		ftpsocket_ctrl
 * @param[in]	rSOCKET			ソケット
 * @date		1970/1/1
 */
ftpsocket_ctrl& ftpsocket_ctrl::operator=(SOCKET& rSOCKET)
{
	mvSD[0] = rSOCKET;									//mCSD = rSOCKET;
	return *this;
}

/*!
 * @file		ftpsocket_ctrl.cpp
 * @fn			int ftpsocket_ctrl::variables
 * @brief		クラス変数初期化
 * @details		クラス変数初期化
 * @return		0 <  Return value: TBD
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @date		2022/3/8
 */
int ftpsocket_ctrl::variables(void)
{
	mPAI = 0;
	return RET_SUCCESS;
}

/*!
 * @file		ftpsocket_ctrl.cpp
 * @fn			int ftpsocket_ctrl::initialize(PCSTR pNodename, PCSTR pServicename)
 * @brief		SOCKET初期化
 * @details		SOCKET初期化
 * @return		0 <  Return value: エラーコード
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @param[in]	rAI				The addrinfo structure is used by the getaddrinfo function to hold host address information.
 * @param[in]	pArgs			IPアドレス(IPv4), ポート番号
 * @date		2022/3/8
 * @note		制御SOCKET
 * 					[0] Main(接続まえ準備～切断)
 * 					[1] 未使用
 * 				転送SOCKET
 * 					[0] Listen用(接続まえ準備)
 * 					[1] accept以降(接続～切断)


 */
///*PCSTR pNodename/*"192.168.11.37"*/, PCSTR pServicename/* "21" */
int ftpsocket_ctrl::initialize(ADDRINFOA& rAI, void* pArgs)
{
	int				rc	= RET_SUCCESS;
	int				ret_ec = RET_SUCCESS;
	int				ret_wlib;							// Winライブり用戻り値
	std::wstring	wstr_emsg = L"";

	WSADATA				wsa_dt;
	struct addrinfo		hints;
	struct addrinfo*	presult = (struct addrinfo*)0;
	struct addrinfo*	ptr = (struct addrinfo*)0;

	const char**	pparams;
	PCSTR			pnode/* = pNodename*/;				// a host (node) name or a numeric host address string.
	PCSTR			pservice/* = pServicename*/;		// a service name or port number represented as a string.
	PADDRINFOA		result = 0;
	SOCKET			sockfd = INVALID_SOCKET;

	// new, delete
	ecode*			pec = (ecode*)0;

	//
	// ■Initialize Winsock
	//
	ret_wlib = ::WSAStartup(MAKEWORD(2, 2)/*version*/, &wsa_dt);
	if (ret_wlib != 0) {
		pec = new ecode(ecode::eVALUE::eWSASTARTUP, __FUNCTION__, "Failed WSAStartup()..");
		pec->output();
		rc = pec->rc();
		goto EXIT_FUNCTION;
	}

	//
	// ■Resolve the server address and port
	// https://docs.microsoft.com/en-us/windows/win32/api/ws2def/ns-ws2def-addrinfoa
	// https://docs.microsoft.com/en-us/windows/win32/api/ws2tcpip/nf-ws2tcpip-getaddrinfo
	//

	// 念のためにコピー(デバッグ後に削除)
	memset(&hints, 0x00, sizeof(hints));
	hints.ai_family   = rAI.ai_family;					// AF_INET;
	hints.ai_socktype = rAI.ai_socktype;				// SOCK_STREAM;
	hints.ai_protocol = rAI.ai_protocol;				// IPPROTO_TCP;

	pparams = (const char**)pArgs;						// 呼び出し元ではpname[2]の先頭アドレスを渡している。
	pnode	= (PCSTR)(*(pparams + 0));					// "192.168.11.37"
	pservice= (PCSTR)(*(pparams + 1));					// "21"

	ret_wlib = ::getaddrinfo(pnode, pservice, &hints, &result);
	if (ret_wlib != 0) {								// サーバーIPアドレス, PORT番号
		::WSACleanup();

		pec = new ecode(ecode::eVALUE::eGETADDRINFO, __FUNCTION__, "Failed getaddrinfo()..");
		pec->output();
		rc = pec->rc();
		goto EXIT_FUNCTION;
	}

	// If no error occurs, socket returns a descriptor referencing the new socket. 
	sockfd = ::socket(result->ai_family, result->ai_socktype, result->ai_protocol);
	if (sockfd == INVALID_SOCKET) {
		ret_ec = winec::get_sock_emsg(wstr_emsg);

		::freeaddrinfo(result);
		::WSACleanup();

		std::wstring wstr_tmp = L"Failed socket()..,";
		wstr_tmp += wstr_emsg;

		pec = new ecode(ecode::eVALUE::eSOCKET, __FUNCTIONW__, wstr_tmp);
		pec->output();
		rc = pec->rc();
		goto EXIT_FUNCTION;
	}

	// 非ブロッキング実験
	// u_long nblock = 1;
	// ret_wlib = ioctlsocket(sockfd, FIONBIO, &nblock);

	mvSD[SOCCTRL::eMAIN] = sockfd;
	mPAI = result;										// connect()で使用

EXIT_FUNCTION:
	if (pec) {delete pec;}

	return rc;
}

/*!
 * @file		ftpsocket_ctrl.cpp
 * @fn			int ftpsocket_ctrl::connect(void)
 * @brief		サーバー接続
 * @details		接続し、リプライメッセージを受信する
 * @return		0 <  Return value: エラーコード
 * 				0 >  Return value: FTPリプライコード(整数)
 * 				0 >  Return value: TBD
 * @param[in]	rSOCKET			ソケット
 * @date		1970/1/1
 * @note		***
 */
int ftpsocket_ctrl::connect(int siName)
{
	//
	// ■Connect to server.
	// https://docs.microsoft.com/ja-jp/windows/win32/winsock/winsock-client-application
	// https://docs.microsoft.com/ja-jp/windows/win32/winsock/complete-client-code
	// https://docs.microsoft.com/en-us/windows/win32/api/winsock/nf-winsock-recv
	//
	int				rc = RET_SUCCESS;
	int				ret_ec;
	int				ret_wlib;							// Winライブり用戻り値

	int				bufsize = SOCRECV_MAX_SIZE;
	int				flags = 0;
	std::wstring	wstr_emsg = L"";
	reply*			preply = (reply*)0;					// CONNECT()リプライ
	u_long			nblock = 1;							// 非ブロッキング

	// new, delete
	ecode*			pec = (ecode*)0;
	char*			prcvbuf = (char*)0;

	/*
	 * まえ処理		接続には、mvSDとmPAIが必要
	 */
	if (mvSD[siName] == INVALID_SOCKET) {
		pec = new ecode(ecode::eVALUE::eINVALID_SOCKET, __FUNCTION__, "mvSD[siName] == INVALID_SOCKET");
		pec->output();
		rc = pec->rc();									// 戻り値に変換
		goto EXIT_FUNCTION;
	}

	if (mPAI == (PADDRINFOA)0) {
		pec = new ecode(ecode::eVALUE::eINVALID_SOCKET, __FUNCTION__, "mPAI == 0");
		pec->output();
		rc = pec->rc();									// 戻り値に変換
		goto EXIT_FUNCTION;
	}

	/*
	 * 接続
	 */
	ret_wlib = ::connect(mvSD[siName], mPAI->ai_addr, (int)mPAI->ai_addrlen);
	if (ret_wlib == SOCKET_ERROR) {
		ret_ec = winec::get_sock_emsg(wstr_emsg);

		std::wstring wstr_tmp = L"Failed connect()..,";
		wstr_tmp += wstr_emsg;

		// Should really try the next address returned by getaddrinfo
		// if the connect call failed
		//::closesocket(mCSD);
		//::freeaddrinfo(mAI);
		//::WSACleanup();
		this->release(siName);							// 接続失敗・ソケット異常かも。リソース解放

		pec = new ecode(ecode::eVALUE::eCONNECT, __FUNCTIONW__, wstr_tmp);
		pec->output();
		rc = pec->rc();
		goto EXIT_FUNCTION;
	}
	// else文でリソース解放すると、次に接続できない
	//else {
	//	::freeaddrinfo(mAI);
	//	mAI = 0;
	//}

	/*	※ faile-safe
		LANケーブル切断時、recv()から戻ってこない現象が1回発生したため、
		非ブロッキング(FIONBIO)に対応。

		以下のsampleコードに従うと、connect()が失敗する。
		=> "ブロック不可のソケット操作をすぐに完了できませんでした。"

		[sample] socket() -> ioctlsocket()
		[対策]　　socket() -> connect() -> ioctlsocket()
	*/

	// https://docs.microsoft.com/en-us/windows/win32/api/winsock/nf-winsock-ioctlsocket
	// Set the socket I/O mode:
	//	In this case FIONBIO enables or disables the blocking mode
	//	for the socket based on the numerical value of nblock.
	//	If nblock = 0, blocking is enabled; 
	//	If nblock != 0, non-blocking mode is enabled.
	ret_wlib = ::ioctlsocket(mvSD[siName], FIONBIO, &nblock);
	if (ret_wlib != NO_ERROR) {
		ret_ec = winec::get_sock_emsg(wstr_emsg);

		std::wstring wstr_tmp = L"Failed ioctlsocket()..,";
		wstr_tmp += wstr_emsg;

		pec = new ecode(ecode::eVALUE::eSOCKET, __FUNCTIONW__, wstr_tmp);
		pec->output();
		rc = pec->rc();
		goto EXIT_FUNCTION;
	}

	/*
	 * 接続あと処理
	 */
	prcvbuf = new char[bufsize];
	if (prcvbuf == (char*)0) {
		ecode	retobj(ecode::eVALUE::eNEW, __FUNCTION__, "0 = new char[bufSize]");
		retobj.output();
		rc = retobj.rc();								// 戻り値に変換
		goto EXIT_FUNCTION;
	}
	memset(prcvbuf, 0x00, bufsize);

#if 1
	rc = this->receiver(siName, FTP_WAITTIME, (LPSTR)prcvbuf, bufsize);
	if (reply::range(rc, 200) == true) {
		pec = (ecode*)0;
		rc = RET_SUCCESS;
	}
	else if (reply::range(rc, 100) == true) {
		pec = new ecode(ecode::eVALUE::eREPLY1xx, __FUNCTION__, "REPLY1xx");
	}
	else if (reply::range(rc, 300) == true) {
		pec = new ecode(ecode::eVALUE::eREPLY3xx, __FUNCTION__, "REPLY3xx");
	}
	else if (reply::range(rc, 400) == true) {
		pec = new ecode(ecode::eVALUE::eREPLY4xx, __FUNCTION__, "REPLY4xx");
	}
	else if (reply::range(rc, 500) == true) {
		pec = new ecode(ecode::eVALUE::eREPLY5xx, __FUNCTION__, "REPLY5xx");
	}
	else {
		pec = new ecode(ecode::eVALUE::eREPLYxxx, __FUNCTION__, "REPLY???");
	}

	if (pec) {
		pec->output();
		rc = pec->rc();									// 戻り値に変換
	}

#else
	ret_wlib = recv(mCSD, (LPSTR)prcvbuf, bufsize, flags);
	if (ret_wlib < 0) {
		// 送受信異常時には、リソース解放はしないでおく。
		ret_ec = winec::get_sock_emsg(wstr_emsg);		// Winエラーコード取得

		pec = new ecode(ecode::eVALUE::eRECV, __FUNCTION__, "Failed recv()..");
		pec->output();
		rc = pec->rc();
		goto EXIT_FUNCTION;
	}
	else {
		*(prcvbuf + ret_wlib) = 0x00;					// 念のため。
	}

	preply = new reply(prcvbuf, DBG_FLAG);
	if (preply == (reply*)0) {
		ecode	retobj(ecode::eVALUE::eNEW, __FUNCTION__, "0 = new reply()");
		retobj.output();
		rc = retobj.rc();								// 戻り値に変換
		goto EXIT_FUNCTION;
	}

	ret_ftp = preply->get_code();						// CONNECT()リプライ取得
	if (ret_ftp <= 0) {									// コード取得失敗
		goto EXIT_FUNCTION;
	}

	//std::string		str_msg;
	//DEBUG ret_local = preply->get_msg(str_msg);
#endif

EXIT_FUNCTION:
	if (pec) { delete pec; }
	if (prcvbuf) { delete[] prcvbuf; }
	return rc;
}

/*!
 * @file		ftpsocket_ctrl.cpp
 * @fn			int ftpsocket_ctrl::disconnect(int siName)
 * @brief		サーバー切断
 * @details		サーバー切断
 * @return		0 <  Return value: エラーコード
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @param[in]	siName			0: Main, 1: 未使用
 * @date		2022/3/8
 * @note		制御SOCKET
 * 					[0] Main(接続まえ準備～切断)
 * 					[1] 未使用
 */
int ftpsocket_ctrl::disconnect(int siName)
{
	// https://docs.microsoft.com/ja-jp/windows/win32/winsock/disconnecting-the-client
	// https://docs.microsoft.com/en-us/windows/win32/api/winsock/nf-winsock-shutdown
	int				rc  = RET_SUCCESS;
	int				ret_wlib = 0;
	int				ret_ec;
	std::wstring	wstr_emsg = L"";

	int				how = SD_BOTH;						// Shutdown both send and receive operations.
//	int				how = SD_SEND;						// Shutdown send operations.
//	int				how = SD_RECEIVE;					// Shutdown receive operations.

	// new, delete
	ecode*			pec = (ecode*)0;

	if (mvSD[siName] == INVALID_SOCKET) {
		pec = new ecode(ecode::eVALUE::eINVALID_SOCKET, __FUNCTION__, "mvSD[SOCCTRL::eMAIN] == INVALID_SOCKET");
		pec->output();
		rc = pec->rc();									// 戻り値に変換
		goto EXIT_FUNCTION;
	}

	/* Return value.
	 *	If no error occurs, shutdown returns zero. 
	 *  Otherwise, a value of SOCKET_ERROR is returned,
		and a specific error code can be retrieved by calling WSAGetLastError.
	 */
	// If no error occurs, shutdown returns zero. 

	ret_wlib = ::shutdown(mvSD[siName], how);
	if (ret_wlib == SOCKET_ERROR) {
		ret_ec = winec::get_sock_emsg(wstr_emsg);		// Winエラーコード取得
		this->release(siName);							// 切断失敗・ソケット異常かも。リソース解放

		std::wstring wstr_tmp = L"Failed shutdown()..,";
		wstr_tmp += wstr_emsg;

		pec = new ecode(ecode::eVALUE::eSHUTDOWN, __FUNCTIONW__, wstr_tmp);
		pec->output();
		rc = pec->rc();
		goto EXIT_FUNCTION;
	}

EXIT_FUNCTION:
	if (pec) { delete pec; }

	return rc;
}

/*!
 * @file		ftpsocket_ctrl.cpp
 * @fn			int ftpsocket_ctrl::release(int siName)
 * @brief		リソース解放
 * @details		リソース解放
 * @return		0 <  Return value: エラーコード
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @param[in]	siName		制御SOCKET名
 * @date		2022/3/8
 * @note		制御SOCKET
 * 					[0] Main(接続まえ準備～切断)
 * 					[1] 未使用
 * 				転送SOCKET
 * 					[0] Listen用(接続まえ準備)
 * 					[1] accept以降(接続～切断)
 */
int ftpsocket_ctrl::release(int siName)
{
	int				rc  = RET_SUCCESS;
	// new, delete
	ecode*			pec = (ecode*)0;

	// https://docs.microsoft.com/ja-jp/windows/win32/winsock/complete-client-code
	if (mvSD[siName] == INVALID_SOCKET) {
		pec = new ecode(ecode::eVALUE::eINVALID_SOCKET, __FUNCTION__, "mvSD[siName] == INVALID_SOCKET");
		pec->output();
		rc = pec->rc();									// 戻り値に変換

		delete pec;
		pec = (ecode*)0;
	}
	else {
		closesocket(mvSD[siName]);
		mvSD[siName] = INVALID_SOCKET;
	}

	if (mPAI == 0) {
		pec = new ecode(ecode::eVALUE::eINVALID_ADDRINFO, __FUNCTION__, "mPAI == 0");
		pec->output();
		rc = pec->rc();									// 戻り値に変換

		delete pec;
		pec = (ecode*)0;
	}
	else {
		::freeaddrinfo(mPAI);
		mPAI = 0;
	}
	::WSACleanup();

	return rc;
}
