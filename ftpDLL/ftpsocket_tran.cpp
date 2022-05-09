#include "pch.h"
#include "ftpsocket_tran.h"
#include "ftplog.h"
#include "winec.h"
#include "ecode.h"
#include "reply.h"
#include "sstream"

#include <iostream>

ftpsocket_tran::ftpsocket_tran()
{
	this->variables();
}

ftpsocket_tran::~ftpsocket_tran()
{

}

/*!
 * @file		ftpsocket_tran.cpp
 * @fn			int ftpsocket_tran::variables
 * @brief		クラス変数初期化
 * @details		クラス変数初期化
 * @return		0 <  Return value: TBD
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @date		1970/1/1
 */
int ftpsocket_tran::variables(void)
{
    //mvSD[NAME::eACCEPT] = INVALID_SOCKET;
    //mvSD[NAME::eLISTEN] = INVALID_SOCKET;
	//mu16PORT = (unsigned short)0x0000;

    return RET_SUCCESS;
}

/*!
 * @file		ftpsocket.cpp
 * @fn			int ftpsocket_tran::initialize(SOCKET& rSD, PADDRINFOA& rAI, PCSTR pNodename, PCSTR pServicename)
 * @brief		SOCKET初期化
 * @details		ポートをopen
 * @return		0 <  Return value: エラーコード
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @param[in]	pArgs		    未使用
 * @date		2022/3/25
 * @note		socket()～listen()が成功すると、制御SOCKET(ここはデータSOCKET)へFTPサーバーから応答通知される。
 *              データSOCKETには、接続要求が通知される。
 */
int ftpsocket_tran::initialize(ADDRINFOA& rAI, void* pArgs)
{
    // Sockaddr //https://docs.microsoft.com/ja-jp/windows/win32/winsock/sockaddr-2

    // Declare variables
	int				    rc	= RET_SUCCESS;
	int				    ret_ec = RET_SUCCESS;
	int				    ret_wlib;                       // Winライブり用戻り値
	std::wstring	    wstr_emsg = L"";

	const char**		pparams;
	const char*			pport;
	std::stringstream	ss_port;
	unsigned short		u16port;

    SOCKET              listens;                        // listens ocket
    struct sockaddr_in  sa_srv;
    struct sockaddr_in* parg;

	// new, delete
	ecode* pec = (ecode*)0;
#if 0
	//hostent*            phentry;                        // Hostエントリー
	//char*               pipadrr;                        // IPアドレス
	//char*				host_name;
#endif

    /*
     * ■ Create a listening socket
     */
    listens = ::socket(AF_INET, SOCK_STREAM, IPPROTO_TCP);
	if (listens == INVALID_SOCKET) {
		ret_ec = winec::get_sock_emsg(wstr_emsg);

		std::wstring wstr_tmp = L"Failed socket()..,";
		wstr_tmp += wstr_emsg;

		pec = new ecode(ecode::eVALUE::eRECV, __FUNCTIONW__, wstr_tmp);
		pec->output();
		rc = pec->rc();
		goto EXIT_FUNCTION;
	}

    /*
     * ■ Bind the listening socket using the information in the sockaddr structure
     */
	// getaddrinfo() <- gethostbyname()	// https://docs.microsoft.com/en-us/windows/win32/api/wsipv6ok/nf-wsipv6ok-gethostbyname
	// inet_ntop() <- inet_ntoa()		// https://docs.microsoft.com/en-us/windows/win32/api/ws2tcpip/nf-ws2tcpip-inet_ntop
#if 1
	pparams = (const char**)pArgs;						// 呼び出し元ではpname[2]の先頭アドレスを渡している。
	pport	= (*(pparams + 1));							// "5348" 0xD000
	ss_port << pport;
	ss_port >> u16port;									// clientポート

	parg = (struct sockaddr_in*)rAI.ai_addr;
	if (parg) {
		sa_srv.sin_family = parg->sin_family;
		sa_srv.sin_port = parg->sin_port;
		sa_srv.sin_addr.S_un.S_addr = parg->sin_addr.S_un.S_addr;
	}
	else {
		sa_srv.sin_family = AF_INET;
		sa_srv.sin_port	  = ::htons(u16port);			// NETWORK BYTE ORDER変換
		sa_srv.sin_addr.S_un.S_addr = INADDR_ANY;
		// なんで、コンパイルとおったん?? sa_srv.sin_addr.s_addr = INADDR_ANY;
		//sa_srv.sin_addr.s_addr = addr.S_un.S_addr;	// S_addrはULONH型 4byte
	}
#else
    // Get the local host information
    phentry = ::gethostbyname((const char*)"");                      // ホスト名を解決
	pipadrr = ::inet_ntoa(*(struct in_addr*)*phentry->h_addr_list);

	// Set up the sockaddr structure
	sa_srv.sin_family = AF_INET;
	sa_srv.sin_addr.s_addr = ::inet_addr(pipadrr);      // INTERNET HOSTアドレス取得
	sa_srv.sin_port = ::htons(SOCPORT_DATA);        // NETWORK BYTE ORDER変換
#endif

    ret_wlib = ::bind(listens, (SOCKADDR*)&sa_srv, sizeof(sa_srv));
    if (ret_wlib == SOCKET_ERROR) {
		ret_ec = winec::get_sock_emsg(wstr_emsg);

		std::wstring wstr_tmp = L"Failed bind()..,";
		wstr_tmp += wstr_emsg;

		pec = new ecode(ecode::eVALUE::eBIND, __FUNCTIONW__, wstr_tmp);
		pec->output();
		rc = pec->rc();
		goto EXIT_FUNCTION;
    }

    /*
     *  ■ Listen for incoming connection requests on the created socket.
     */
    // listen function // https://docs.microsoft.com/en-us/windows/win32/api/winsock2/nf-winsock2-listen
    ret_wlib = ::listen(listens, SOMAXCONN);			// サーバーからの接続要求まち
    if (ret_wlib == SOCKET_ERROR) {
		ret_ec = winec::get_sock_emsg(wstr_emsg);

        std::wstring wstr_tmp = L"Failed listen()..,";
        wstr_tmp += wstr_emsg;

		pec = new ecode(ecode::eVALUE::eBIND, __FUNCTIONW__, wstr_tmp);
		pec->output();
		rc = pec->rc();
		goto EXIT_FUNCTION;
    }
	else {
		LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eXXXX, "listens = %llx success!!\n", listens);
	}

	mvSD[SOCTRAN::eLISTEN] = listens;

EXIT_FUNCTION:
	if (pec) {delete pec;}

    return rc;
}

/*!
 * @file		ftpsocket_tran.cpp
 * @fn			int ftpsocket_tran::connect(void)
 * @brief		サーバー接続
 * @details		接続し、リプライメッセージを受信する
 * @return		0 <  Return value: エラーコード
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @date		2022/3/25
 * @note		***
 */
int ftpsocket_tran::connect(int siName)
{
	int				    rc	= RET_SUCCESS;
	int				    ret_ec = RET_SUCCESS;
	std::wstring	    wstr_emsg = L"";

    SOCKET              accepts;                        // accepts ocket
    struct sockaddr_in  sa_srv;
    int                 sa_size = sizeof(sa_srv);

	int				    ret_wlib;                       // Winライブり用戻り値
	u_long				nblock = 1;						// 非ブロッキング

	// new, delete
	ecode* pec = (ecode*)0;

	if (mvSD[siName] == INVALID_SOCKET) {
		pec = new ecode(ecode::eVALUE::eINVALID_SOCKET, __FUNCTION__, "mvSD[siName] == INVALID_SOCKET");
		pec->output();
		rc = pec->rc();									// 戻り値に変換
		goto EXIT_FUNCTION;
	}

    //
    // accept function // https://docs.microsoft.com/en-us/windows/win32/api/winsock2/nf-winsock2-accept
    //
	accepts = ::accept(mvSD[siName], (sockaddr*)&sa_srv, &sa_size);
    if (accepts == INVALID_SOCKET) {					// サーバーへ接続
		ret_ec = winec::get_sock_emsg(wstr_emsg);

        std::wstring wstr_tmp = L"Failed accept()..,";
        wstr_tmp += wstr_emsg;

		pec = new ecode(ecode::eVALUE::eACCEPT, __FUNCTIONW__, wstr_tmp);
		pec->output();
		rc = pec->rc();
		goto EXIT_FUNCTION;
    }

	// ※ 非ブロッキングモード
	//	  ftpsocket_ctrl::initialize()では、socket()の直後にFIONBIOを設定すると、接続(connect())が失敗する。
	//
	//	  ftpsocket_tranはsocket()～listen()までのソケットとaccept()以降のソケットは別。
	//	  accept()が返したソケットを使って、ioctlsocket()をcallする。
	//	  結果的には、ftpsocket_tran でも、接続(accept())後にFIONBIOを設定することになる。

	// https://docs.microsoft.com/en-us/windows/win32/api/winsock/nf-winsock-ioctlsocket
	// Set the socket I/O mode:
	//	In this case FIONBIO enables or disables the blocking mode
	//	for the socket based on the numerical value of nblock.
	//	If nblock = 0, blocking is enabled; 
	//	If nblock != 0, non-blocking mode is enabled.
	ret_wlib = ::ioctlsocket(accepts, FIONBIO, &nblock);
	if (ret_wlib != NO_ERROR) {
		ret_ec = winec::get_sock_emsg(wstr_emsg);

		std::wstring wstr_tmp = L"Failed ioctlsocket()..,";
		wstr_tmp += wstr_emsg;

		pec = new ecode(ecode::eVALUE::eSOCKET, __FUNCTIONW__, wstr_tmp);
		pec->output();
		rc = pec->rc();
		goto EXIT_FUNCTION;
	}


	mvSD[SOCTRAN::eACCEPT] = accepts;
	LOGTRACE(ECTRL::eWH, ERANK::eDBG, ENAME::eXXXX, "mvSD[SOCTRAN::eACCEPT] %d,%d\n", (int)mvSD[SOCTRAN::eACCEPT], (int)accepts);

EXIT_FUNCTION:
	if (pec) {delete pec;}

    return rc;
}

/*!
 * @file		ftpsocket_tran.cpp
 * @fn			int ftpsocket_tran::disconnect(void)
 * @brief		サーバー切断
 * @details		サーバー切断
 * @return		0 <  Return value: エラーコード
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @param[in]	rAI				host address information
 * @date		1970/1/1
 * @note		***
 */
int ftpsocket_tran::disconnect(int siName)
{
	int				    rc	= RET_SUCCESS;
	int				    ret_ec = RET_SUCCESS;
	int				    ret_wlib;                       // Winライブり用戻り値
	std::wstring	    wstr_emsg = L"";
	// new, delete
	ecode*				pec = (ecode*)0;

	if (mvSD[siName] == INVALID_SOCKET) {
		pec = new ecode(ecode::eVALUE::eINVALID_SOCKET, __FUNCTION__, "mvSD[siName] == INVALID_SOCKET");
		pec->output();
		rc = pec->rc();									// 戻り値に変換
		goto EXIT_FUNCTION;
	}

    // shutdown function // https://docs.microsoft.com/en-us/windows/win32/api/winsock/nf-winsock-shutdown
	ret_wlib = ::shutdown(mvSD[siName], SD_RECEIVE/*Shutdown receive operations.*/);
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
	if (pec) {delete pec;}

    return rc;
}

/*!
 * @file		ftpsocket_tran.cpp
 * @fn			int ftpsocket_tran::release(void)
 * @brief		リソース解放
 * @details		リソース解放
 * @return		0 <  Return value: エラーコード
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @param[in]	void			void
 * @date		2022/3/8
 * @note		***
 */
int ftpsocket_tran::release(int siName)
{
	int				rc  = RET_SUCCESS;
	// new,delete
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
		::closesocket(mvSD[siName]);
		mvSD[siName] = INVALID_SOCKET;
	}
    return rc;
}

/*!
 * @file		ftpsocket_tran.cpp
 * @fn			int ftpsocket_tran::sender(int siWait, const char* pMsg, size_t siLeng)
 * @brief		メッセージ送信
 * @details		リプライメッセージを受信する
 * @return		0 <  Return value: エラーコード
 * 				0 == Return value: TBD
 * 				0 >  Return value: 送信バイト数
 * @param[in]	siWait			送信間隔時間(msec)
 * @param[in]	pMsg			送信メッセージ
 * @param[in]	siLeng			送信メッセージ長
 * @date		1970/1/1
 * @note		***
 */
int ftpsocket_tran::sender(int siWait, const char* pMsg, size_t siLeng)
{
	int		rc	  = RET_SUCCESS;
	int		flags = 0;

	rc = ftpsocket::sender(SOCTRAN::eACCEPT,			// accept()で取得したソケットを使用
							siWait,
							pMsg,
							siLeng,
							flags);
	return rc;
}

/*!
 * @file		ftpsocket_tran.cpp
 * @fn			int ftpsocket_tran::dataline_receiver(int siWait, std::string& rMsg)
 * @brief		データ受信
 * @details		データ転送ライン経由でデータ受信する
 * @return		0 <  Return value: エラーコード
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @param[in]	siWait			受信間隔時間(msec)
 * @param[in]	siZero			0バイト受信動作
 *								1: 許可	0バイト受信時、戻り値成功を返す
 *								0: 禁止 0バイト受信時、戻り値成失敗を返す
 * @param[out]	rMsg			受信メッセージ
 * @date		2022/3/25
 * @note		***
 */
int ftpsocket_tran::receiver(int siWait, int siZero, std::string& rMsg)
{
	/* recv() Return value
		https://docs.microsoft.com/en-us/windows/win32/api/winsock/nf-winsock-recv

		If no error occurs,
		 recv returns the number of bytes received and the buffer pointed to by the pBuffer parameter will contain this data received.
		If the connection has been gracefully closed, the return value is zero.
		Otherwise, a value of SOCKET_ERROR is returned,
		 and a specific error code can be retrieved by calling WSAGetLastError.
	*/
	int				rc	= RET_SUCCESS;
	int				ret_wlib;
	int				ret_ec= RET_SUCCESS;
	std::wstring	wstr_emsg = L"";

	int				bufsize = SOCRECV_MAX_SIZE;
	int				flags = 0;
	int				max_wtime = FTP_TIMEOUT;			// 最大20sec
	int				cnt_retry = 0;						// リトライ回数
	//bool			brecv = true;

	// new,delete
	char*			prcvbuf = (char*)0;
	ecode*			pec = (ecode*)0;

	prcvbuf = new char[bufsize];
	if (prcvbuf == (char*)0) {
		ecode	retobj(ecode::eVALUE::eNEW, __FUNCTION__, "0 = new char[bufSize]");
		retobj.output();
		rc = retobj.rc();								// 戻り値に変換
		goto EXIT_FUNCTION;
	}
	memset(prcvbuf, 0x00, bufsize);

	// ※ 受信回数1回を想定・複数回は未対応
	cnt_retry = max_wtime / siWait;
	do {
		::Sleep(siWait);								// 送信=>受信インターバル
		ret_wlib = ::recv(mvSD[SOCTRAN::eACCEPT], prcvbuf, bufsize, 0);
		if (ret_wlib < 0) {
			ret_ec = winec::get_sock_emsg(wstr_emsg);	// Winエラーコード取得

			std::wstring wstr_tmp = L"Failed recv()..,";
			wstr_tmp += wstr_emsg;

			pec = new ecode(ecode::eVALUE::eRECV, __FUNCTIONW__, wstr_tmp);
			pec->output();
			rc = pec->rc();
			goto EXIT_FUNCTION;
		}
		else if (ret_wlib == 0) {						// ソケット切断(Timeout等)
			ret_wlib = ::WSAGetLastError();
			if (ret_wlib == WSAEWOULDBLOCK) {
				std::cout << "0 = recv(mvSD[SOCTRAN::eACCEPT]): WSAEWOULDBLOCK" << std::endl;
				cnt_retry--;
			}
			else if (ret_wlib == 0) {					// 受信データゼロ(空ディレクトリ検索等)
				if (siZero) {
					break;
				}
				else {
					std::cout << "0 = recv(mvSD[SOCTRAN::eACCEPT])\n" << std::endl;
					cnt_retry--;
				}
			}
			else {
				// TBD: ブロッキングモードでrecv()戻り値がゼロなら、以下のエラーメッセージは適切。
				// 非ブロッキングモードで、WSAEWOULDBLOCK異常以外でrecv()戻り値ゼロはありえるのか?
				// そもそも、LANケーブル切断時にrecv()から返ってこないという現象がおかしい。

				// If the connection has been gracefully closed, the return value is zero.
				pec = new ecode(ecode::eVALUE::eRECV, __FUNCTION__, (const char*)"The connection has been gracefully closed.");
				pec->output();
				rc = pec->rc();
				goto EXIT_FUNCTION;
			}
		}
		else {											// 受信成功
			rMsg = prcvbuf;
			break;
		}
	} while(cnt_retry > 0);

	// 非ブロッキング時のrecv()戻り値ゼロ対策
	if (cnt_retry <= 0) {
		pec = new ecode(ecode::eVALUE::eRECV, __FUNCTION__, (const char*)"cnt_retry <= 0, 0=recv()");
		pec->output();
		rc = pec->rc();
		goto EXIT_FUNCTION;
	}


EXIT_FUNCTION:
	if (pec) { delete pec; }
	if (prcvbuf) { delete[] prcvbuf; }

	return rc;
}