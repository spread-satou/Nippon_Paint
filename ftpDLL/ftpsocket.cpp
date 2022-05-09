#include "pch.h"
#include "ftpsocket.h"
#include "winec.h"
#include "ecode.h"
#include "reply.h"
#include <iostream>

/*!
 * @note		制御SOCKET
 * 					[0] (接続まえ準備～切断)
 * 					[1] 未使用
 * 				転送SOCKET
 * 					[0] Listen用(接続まえ準備)
 * 					[1] accept以降(接続～切断)
*/

#define							DBGPRT

ftpsocket::ftpsocket()
{
	this->initialize();
}

ftpsocket::~ftpsocket()
{

}

/*!
 * @file		ftpsocket.cpp
 * @fn			void ftpsocket::addrinfo(ADDRINFOA* pINFO, int isPORT)
 * @brief		pINFO引数を初期化(IPv4)する
 * @details		host address informationを初期化する
 * @return		void
 * @param[out]	pINFO			Structure used in getaddrinfo() call
 * @param[in]	isPORT			ポート番号(未使用)
 * @date		2022/3/3
 * @note		static
 */
void ftpsocket::addrinfo(ADDRINFOA* pINFO, int isPORT)
{
	u_short usport = ::htons(isPORT);					// DEBUG

	// ADDRINFOA	// the getaddrinfo function(input引数) to hold host address information.
	memset(pINFO, 0, sizeof(ADDRINFOA));
	pINFO->ai_family   = AF_INET;						// AF_UNSPEC;
	pINFO->ai_socktype = SOCK_STREAM;					// SOCK_STREAM;
	pINFO->ai_protocol = IPPROTO_TCP;					// IPPROTO_TCP; 	

#if 0
	// DEBUG
    struct sockaddr_in* paddr;
    paddr = (struct sockaddr_in*)pINFO->ai_addr;		// ADDRINFOA mParams
	if (paddr) {
		paddr->sin_family = AF_INET;
		paddr->sin_port = ::htons(isPORT);
		paddr->sin_addr.S_un.S_addr = INADDR_ANY;
	}
#endif
}

int ftpsocket::initialize()
{
	ftpsocket::variables();
	return RET_SUCCESS;
}

int ftpsocket::initialize(ADDRINFOA& rAI, void* pArgs)
{
	ftpsocket::variables();

	return RET_SUCCESS;
}

/*!
 * @file		ftpsocket.cpp
 * @fn			int ftpsocket::variables(void)
 * @brief		メンバ変数を初期化する
 * @details		メンバ変数を初期化する
 * @return		0 <  Return value: TBD
 * 				0 == Return value: 成功
 * 				0 >  Return value: TBD
 * @param[in]	void
 * @date		2022/3/3
 * @note		initialize()は制御系の初期化
 */
int ftpsocket::variables(void)
{
	mu16PORT = SOCPORT_LOCAL;

	mvSD.clear();
	if (mvSD.empty() == true) {
		mvSD.push_back(INVALID_SOCKET);
		mvSD.push_back(INVALID_SOCKET);
	}
	return RET_SUCCESS;
}

/*!
 * @file		ftpsocket_ctrl.cpp
 * @fn			operator SOCKET() const
 * @brief		SOCKETキャスト
 * @details		SOCKETディスクブリタを返却
 * @return		SOCKETディスクブリタ
 * @date		2022/3/3
 */
//ftpsocket::operator SOCKET() const
//{
//	return mSD;
//}

/*!
 * @file		ftpsocket_ctrl.cpp
 * @fn			ftpsocket_ctrl& ftpsocket_ctrl::operator=(SOCKET& rSOCKET)
 * @brief		ソケットコピー
 * @details		引数のソケットをメンバ変数のソケットに代入
 * @return		ftpsocket_ctrl
 * @param[in]	rSOCKET			ソケット
 * @date		1970/1/1
 */
//ftpsocket& ftpsocket::operator=(SOCKET& rSOCKET)
//{
//	mSD = rSOCKET;
//	return *this;
//}

/*!
 * @file		ftpsocket.cpp
 * @fn			int sender(const char* pMsg, int siLeng, int siFlags)
 * @brief		メッセージ送信
 * @details		If no error occurs,
 * 				 send returns the total number of bytes sent,
 * 				 which can be less than the number requested to be sent in the len parameter(siLeng).
 * @return		0 <  Return value: エラーコード
 * 				0 == Return value: TBD
 * 				0 >  Return value: 送信バイト数
 * @param[in]	pMsg			A pointer to a buffer containing the data to be transmitted.
 * @param[in]	siLeng			The length, in bytes, of the data in buffer pointed to by the pMsg parameter.
 * @param[in]	siFlags		    A set of flags that specify the way in which the call is made.
 * 								URL参照								
 * @date		2022/3/4
 * @note		send function (winsock2.h)	https://docs.microsoft.com/en-us/windows/win32/api/winsock2/nf-winsock2-send
 */
int ftpsocket::sender(int siName, int siWait, const char* pMsg, size_t siLeng, int siFlags)
{
	int				rc  = RET_SUCCESS;
	int				ret_wlib;
	int				ret_ec;
	std::wstring	wstr_emsg = L"";
	// new, delete
	ecode*			pec = (ecode*)0;

	/* Return value.
		If no error occurs,
		 send returns the total number of bytes sent,
		 which can be less than the number requested to be sent in the len parameter.
		Otherwise, a value of SOCKET_ERROR is returned,
		 and a specific error code can be retrieved by calling WSAGetLastError.
	*/

	if (mvSD[siName] == INVALID_SOCKET) {
		pec = new ecode(ecode::eVALUE::eINVALID_SOCKET, __FUNCTION__, "mvSD[siName] == INVALID_SOCKET");
		pec->output();
		rc = pec->rc();									// 戻り値に変換
		goto EXIT_FUNCTION;
	}

	::Sleep(siWait);

	ret_wlib = ::send(mvSD[siName], pMsg, (int)siLeng, siFlags);
	if (ret_wlib < 0) {
		ret_ec = winec::get_sock_emsg(wstr_emsg);		// Winエラーコード取得

		std::wstring wstr_tmp = L"Failed send()..,";
		wstr_tmp += wstr_emsg;

		pec = new ecode(ecode::eVALUE::eSEND, __FUNCTIONW__, wstr_tmp);
		pec->output();
		rc = pec->rc();
		goto EXIT_FUNCTION;
	}
	else {
		rc = ret_wlib;
	}

EXIT_FUNCTION:
	if (pec) { delete pec; }

	return rc;
}

/*!
 * @file		ftpsocket.cpp
 * @fn			int ftpsocket::receiver(int isName, int siWait, char* pBuffer, size_t siLeng, int siFlags)
 * @brief		メッセージ受信
 * @details		The recv function receives data from a connected socket
 * 				 or a bound connectionless socket.
 * @return		0 <  Return value: エラーコード
 * 				0 == Return value: TBD
 * 				0 >  Return value: FTPリプライコード(整数)
 * @param[in]	isName			ソケット名
 * @param[in]	siWait			送受信インターバル時間[msec] (最大値20秒, FTP_TIMEOUTが20秒)
 * @param[out]	pBuffer			A pointer to the buffer to receive the incoming data.
 * @param[in]	siLeng			The length, in bytes, of the buffer pointed to by the pBuffer parameter.
 * @param[in]	siFlags		    A set of flags that influences the behavior of this function.
 * 								URL参照								
 * @date		2022/3/4
 * @note		send function (winsock2.h)	https://docs.microsoft.com/en-us/windows/win32/api/winsock2/nf-winsock2-send
 */
int ftpsocket::receiver(int isName, int siWait, char* pBuffer, size_t siLeng, int siFlags)
{
	/* recv() Return value
		https://docs.microsoft.com/en-us/windows/win32/api/winsock/nf-winsock-recv

		If no error occurs,
		 recv returns the number of bytes received and the buffer pointed to by the pBuffer parameter will contain this data received.
		If the connection has been gracefully closed, the return value is zero.
		Otherwise, a value of SOCKET_ERROR is returned,
		 and a specific error code can be retrieved by calling WSAGetLastError.
	*/

	int				rc = RET_SUCCESS;
	int				ret_wlib;
	int				ret_ec;
	std::wstring	wstr_emsg = L"";
	int				max_wtime = FTP_TIMEOUT;			// 最大20sec
	int				cnt_retry = 0;						// リトライ回数

	// new, delete
	ecode*			pec = (ecode*)0;
	reply*			preply = (reply*)0;					// CONNECT()リプライ

	if (mvSD[isName] == INVALID_SOCKET) {
		pec = new ecode(ecode::eVALUE::eINVALID_SOCKET, __FUNCTION__, "mvSD[isName] == INVALID_SOCKET");
		pec->output();
		rc = pec->rc();									// 戻り値に変換
		goto EXIT_FUNCTION;
	}

	// ※　リプライ受信タイミングと切断エラー
	//	通常、送信直後にリプライを受信済(recv()を呼び出す前にすでに受信済)。
	//	デバッグ操作時、送信後にLANケーブルを抜き取った場合、すでに受信済なので、recv()の戻り値zeroを期待してはだめ。
	//	送信直前にケーブルを抜き取っておく。

	cnt_retry = max_wtime / siWait;
	do {												// recv()無限待ち対策ループ
		::Sleep(siWait);
		ret_wlib = ::recv(mvSD[isName], pBuffer, (int)siLeng, siFlags);
		if (ret_wlib < 0) {
			ret_ec = winec::get_sock_emsg(wstr_emsg);	// Winエラーコード取得

			std::wstring wstr_tmp = L"Failed recv()..,";
			wstr_tmp += wstr_emsg;

			pec = new ecode(ecode::eVALUE::eRECV, __FUNCTIONW__, wstr_tmp);
			pec->output();
			rc = pec->rc();
			goto EXIT_FUNCTION;
		}
		else if (ret_wlib == 0) {						// ソケット切断
			if (WSAEWOULDBLOCK == ::WSAGetLastError()) {
				std::cout << "0 = recv(mvSD[isName]): WSAEWOULDBLOCK" << std::endl;
				cnt_retry--;
			}
			else if (ret_wlib == 0) {					// エラーなし・send()せずにrecv()をcallした?
				std::cout << "0 = recv(mvSD[isName])" << std::endl;
				cnt_retry--;
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
		else {
			break;
			//std::cout << pBuffer;
		}
	} while(cnt_retry > 0);

	// 非ブロッキング時のrecv()戻り値ゼロ対策
	if (cnt_retry <= 0) {
		pec = new ecode(ecode::eVALUE::eRECV, __FUNCTION__, (const char*)"cnt_retry <= 0, 0=recv()");
		pec->output();
		rc = pec->rc();
		goto EXIT_FUNCTION;
	}

	// データ転送時のメッセージには、replyコードは付加されない。
	preply = new reply(pBuffer, DBG_FLAG);				// 受信メッセージをオブジェクト化
	if (preply == (reply*)0) {
		ecode	retobj(ecode::eVALUE::eNEW, __FUNCTION__, "0 = new reply(pBuffer, DBG_FLAG)");
		retobj.output();
		rc = retobj.rc();								// 戻り値に変換
		goto EXIT_FUNCTION;
	}

	// ※ リプライコード取得失敗
	//	get_code()は3桁の10進数、あるいは、エラーコードを返却。0が返却されるはずはない。
	//	0以下判定はフェイルセーフ
	rc = preply->get_code();							// FTPリプライ取得
	if (rc == 0) {										// コード取得失敗
		rc = RET_FAILED;								// 0はRET_SUCCESSと同等なので、エラーにする。
		goto EXIT_FUNCTION;
	}
	else if (rc < 0) {
		goto EXIT_FUNCTION;
	}
	else {
		/*リプライ3桁*/
		if (reply::range(rc, 400, 500) == true) {
#ifdef DBGPRT
			// 暫定
			std::cout << pBuffer;
#endif
		}
	}

EXIT_FUNCTION:
	if (pec) { delete pec; }
	if (preply) { delete preply; }

	return rc;
}
