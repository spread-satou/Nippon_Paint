#include "pch.h"
#include "winec.h"
#include "ecode.h"


winec::winec()
{

}

winec::~winec()
{

}

/*!
 * @file			winec.cpp
 * @fn              winec::get_sock_emsg(std::wstring& rMsg)
 * @brief           エラーメッセージ取得
 * @details         WSAGetLastError()で取得したエラーコードに紐づく、エラーメッセージを取得する。
 * @return          0 <  VALUE: エラーコード
 *                  0 == VALUE: 成功
 *                  0 >  VALUE: TBD
 * @param[out]      rMsg: エラーメッセージ
 * @date            2022/3/2
 * @note            エラー直後にget_sock_emsg()をcallすること。
 *                  なにかWinAPIをcallすると、エラーコードが0、あるいは、他のエラーコードで上書きされるため。
 *                  WSAGetLastError()は不正なエラーコードを返す。
 */
int winec::get_sock_emsg(std::wstring& rMsg)
{
	int			ret_ec = 0;
	wchar_t*	pmsg   = (wchar_t*)0;

	// https://docs.microsoft.com/ja-jp/windows/win32/api/winsock/nf-winsock-wsagetlasterror
	// The return value indicates the error code for this thread's last Windows Sockets operation that failed.
	// ※ソケット固有のエラーコードを取得
	ret_ec = ::WSAGetLastError();						// errnoのかわり

#if 1
	if (ret_ec != 0) {									// エラーあり
		pmsg = new wchar_t[EMSG_BUFFSIZE];
		if (pmsg == (wchar_t*)0) {						// メモリ確保失敗・システムに異常あり
			return ret_ec;								// エラーコード返却
		}
		memset(pmsg, 0x00, EMSG_BUFFSIZE);

		// https://docs.microsoft.com/en-us/windows/win32/api/winbase/nf-winbase-formatmessage
		/*
		DWORD FormatMessage(
					[in]           DWORD   dwFlags,		// The formatting options, and how to interpret the lpSource parameter.
					[in, optional] LPCVOID lpSource,	// The location of the message definition.
					[in]           DWORD   dwMessageId,	// The message identifier for the requested message.
					[in]           DWORD   dwLanguageId,// The language identifier for the requested message.
					[out]          LPTSTR  lpBuffer,	// A pointer to a buffer that receives the null-terminated string that specifies the formatted message.
					[in]           DWORD   nSize,		// f the FORMAT_MESSAGE_ALLOCATE_BUFFER flag is not set, this parameter specifies the size of the output buffer, in TCHARs.
					[in, optional] va_list *Arguments	// An array of values that are used as insert values in the formatted message.
		);
		*/

		// https://docs.microsoft.com/ja-jp/windows/win32/seccrypto/retrieving-error-messages
		/* Return value
			If the function succeeds,
			the return value is the number of TCHARs stored in the output buffer, excluding the terminating null character.
		*/

		// Try to get the message from the system errors.
		DWORD chars = FormatMessage(FORMAT_MESSAGE_FROM_SYSTEM | FORMAT_MESSAGE_IGNORE_INSERTS,
									NULL,				// The location of the message definition. 
									(DWORD)ret_ec,
									0,					// The language identifier for the requested message.
									pmsg,
									EMSG_BUFFSIZE,
									NULL);

		if (chars == 0) {
			// The error code did not exist in the system errors.
			// URLを参考にして、↓エラーメッセージを作成。→ https://docs.microsoft.com/ja-jp/windows/win32/seccrypto/retrieving-error-messages
			swprintf_s(pmsg, EMSG_BUFFSIZE, L"EC %d: Failed FormatMessage(). The error code did not exist in the system errors.", ret_ec);
		}
		rMsg = pmsg;
	}
#else
	// https://docs.microsoft.com/ja-jp/windows/win32/devnotes/-loadlibrary
	//	↑参照 この関数は 、LoadLibrary 関数のラッパー です。 この関数は、将来変更または使用できなくなる可能性があります。
	if (chars == 0) {
		// The error code did not exist in the system errors.
		// Try Ntdsbmsg.dll for the error code.

		HINSTANCE hInst;

		// Load the library.
		hInst = LoadLibrary(L"Ntdsbmsg.dll");
		if (NULL == hInst) {
			printf("cannot load Ntdsbmsg.dll\n");
			exit(1);  // Could 'return' instead of 'exit'.
		}

		// Try getting message text from ntdsbmsg.
		chars = FormatMessage(FORMAT_MESSAGE_FROM_HMODULE | FORMAT_MESSAGE_IGNORE_INSERTS,
							hInst,
							(DWORD)ret_ec,
							0,
							pmsg,
							EMSG_BUFFSIZE,
							NULL);
		// Free the library.
		FreeLibrary(hInst);
	}
#endif

	if (pmsg) { delete[] pmsg; }
	return ret_ec;
}

int winec::get_sock_emsg(std::string& rMsg)
{
	/*TBD*/return RET_FAILED;
}

int winec::get_emsg(std::wstring& rMsg)
{
	/*TBD*/return RET_FAILED;
}

int winec::get_emsg(std::string& rMsg)
{
	/*TBD*/return RET_FAILED;
}

