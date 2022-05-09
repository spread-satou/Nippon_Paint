#pragma once
extern "C" {
#include <winsock2.h>
#pragma comment(lib, "Ws2_32.lib")
};

#include <string>

// https://docs.microsoft.com/ja-jp/windows/win32/winsock/error-codes-errno-h-errno-and-wsagetlasterror-2
// https://docs.microsoft.com/ja-jp/windows/win32/winsock/windows-sockets-error-codes-2
// https://docs.microsoft.com/ja-jp/windows/win32/winsock/winsock-functions

class winec
{
public:
	winec();
	virtual ~winec();

	// Windowsソケットエラーコード
	static int get_sock_emsg(std::wstring& rMsg);
	static int get_sock_emsg(std::string& rMsg);

	// Windowsソケット以外エラーコード
	static int get_emsg(std::wstring& rMsg);
	static int get_emsg(std::string& rMsg);
};

