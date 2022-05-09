#include "pch.h"
#include "winec.h"
#include "ecode.h"
#include "def_buffer.h"

#include <Windows.h>
#include <tchar.h>
#include <sstream>

winec::winec()
{

}

winec::~winec()
{

}

/*!
 * @file			winec.cpp
 * @fn              winec::get_emsg(std::wstring& rMsg)
 * @brief           エラーメッセージ取得
 * @details         WSAGetLastError()で取得したエラーコードに紐づく、エラーメッセージを取得する。
 * @return          0 <  VALUE: エラーコード
 *                  0 == VALUE: 成功
 *                  0 >  VALUE: TBD
 * @param[out]      rMsg: エラーメッセージ
 * @date            2022/4/18
 * @note            エラー直後にget_emsg()をcallすること。
 *                  なにかWinAPIをcallすると、エラーコードが0、あるいは、他のエラーコードで上書きされるため。
 *                  GetLastError()は不正なエラーコードを返す。
 */
unsigned long winec::get_emsg(std::wstring& rMsg)
{
    //LPVOID	lpDisplayBuf;
	DWORD	dw = GetLastError();
	LPVOID				lpMsgBuf;
	std::wstringstream	wss;

    FormatMessage(	FORMAT_MESSAGE_ALLOCATE_BUFFER |
					FORMAT_MESSAGE_FROM_SYSTEM |
					FORMAT_MESSAGE_IGNORE_INSERTS,
					NULL,
					dw,
					MAKELANGID(LANG_NEUTRAL, SUBLANG_DEFAULT),
					(LPTSTR)&lpMsgBuf,
					0, 
					NULL);
	// DWORD len_msg = lstrlen((LPCTSTR)lpMsgBuf);

	// swprintf_s(), _snwprintf_s()を使用するとlpMsgBufバッファを壊すので、STLで文字列を。
	wss << (wchar_t*)lpMsgBuf;
	rMsg = wss.str();

	//TCHAR* pbuff;
	//DWORD	len_msg;
	//pbuff = new TCHAR[ERRMSG_BUFFSIZE];
	//::memset(pbuff, 0x00, ERRMSG_BUFFSIZE *sizeof(TCHAR));
	////::swprintf_s(pbuff, ERRMSG_BUFFSIZE * sizeof(TCHAR), _T("%d\n"), dw);
	//::swprintf_s(pbuff, ERRMSG_BUFFSIZE * sizeof(TCHAR), _T("%s\n"), (wchar_t*)lpMsgBuf);
	//// _snwprintf_s(pbuff, ERRMSG_BUFFSIZE * sizeof(TCHAR), ERRMSG_BUFFSIZE, (const wchar_t*)"%s\n", lpMsgBuf);
	//rMsg = pbuff;

#if 0
	len_msg = lstrlen((LPCTSTR)lpMsgBuf);
	len_function = lstrlen((LPCTSTR)lpszFunction);

    lpDisplayBuf = (LPVOID)LocalAlloc(
							LMEM_ZEROINIT, 
							(len_msg + len_function + 40) * sizeof(TCHAR));
    
    if (FAILED(StringCchPrintf(
							(LPTSTR)lpDisplayBuf, 
                     		LocalSize(lpDisplayBuf) / sizeof(TCHAR),
                     		TEXT("%s failed with error code %d as follows:\n%s"), 
                     		lpszFunction, 
                     		dw, 
                     		lpMsgBuf)))
	{
        printf("FATAL ERROR: Unable to output error code.\n");
    }
    _tprintf(TEXT("ERROR: %s\n"), (LPCTSTR)lpDisplayBuf);
#endif

    LocalFree(lpMsgBuf);
    //LocalFree(lpDisplayBuf);
	return dw;
}

unsigned long winec::get_emsg(std::string& rMsg)
{
	/*TBD*/return (unsigned long)RET_FAILED;
}
