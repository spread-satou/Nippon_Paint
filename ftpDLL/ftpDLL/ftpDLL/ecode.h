#pragma once
#include <string>

/*!
 * @brief エラーコード定義
 * @note  エラーコードはすてべ負の値(POSIX同等)
 */

#define	RET_FAILED				-1
#define	RET_SUCCESS				0
#define	RET_NOERR				0

#define VALUE					(int)ecode::eVALUE
#define	EMSG_BUFFSIZE			512						//! エラーメッセージ編集バッファサイズ

class ecode
{
protected:
	int				msiValue;							//! エラーコード
	std::string		mFunc;								//! 関数名
	std::string		mMsg;								//! エラーメッセージ

	std::wstring	mwFunc;								//! 関数名(ワイド文字)
	std::wstring	mwMsg;								//! エラーメッセージ(ワイド文字)

public:
	enum class eVALUE {									//! エラーコード(逆数)
		eSUCCESS= 0,									// RET_SUCCESSと同等
		eFAILED,										// RET_FAILEDと同等
		eERROR,											// RFC959 error
		eFAILURE,										// RFC959 failure

		// プログラミングエラー
		eARG_NULL,										// 引数異常・NULLポインタ
		eINVALID_SOCKET,								// ハンドル異常
		eINVALID_ADDRINFO,								// ハンドル異常
		ePARAM_STRING,									// パラメータ異常・STRING未設定
		eMEM_NOALLOC,									// メモリ未確保
		eBUFSIZE_NOENOUGH,								// バッファ不足

		// システム異常
		eNEW,											// メモリ確保失敗

		// STL失敗
		eREDIRECT,										// リダイレクト失敗
		eSTRSIZE,										// 文字列長異常
		eSTRNPOS,										// string::find()失敗
		eMBRLEN,										// mbrlen()失敗
		eLOCALTIME,										// _localtime64_s()失敗
		eGETCWD,										// _getcwd()失敗
		eIFSTREAM,										// ifstream()失敗
		eREMOVE,										// remove()失敗

		// REPLYメッセージ
		eREPLYxxx,										// UNKNOWN
		eREPLY1xx,
		eREPLY2xx,
		eREPLY3xx,
		eREPLY4xx,
		eREPLY5xx,

		// Winライブラリ失敗
		// 以下はソケット切断=>接続(リスタート)で、復旧できるかも
		eWSASTARTUP,									// WSAStartup()
		eGETADDRINFO,									// getaddrinfo()
		eSOCKET,										// socket()
		eCONNECT,										// connect()
		eSEND,											// send()
		eRECV,											// recv()
		eSHUTDOWN,										// shutdown()

		eBIND,											// bind()
		eLISTEN,										// listen()
		eACCEPT,										// accept()
		eGETHOSTNAME,									// gethostname()

		eSEM_TMO,										// セマフォタイムアウト
		eNUMB
	};

	ecode();
	ecode(eVALUE e, const char* pFunc);
	ecode(eVALUE e, const char* pFunc, const char* pMsg);
	ecode(eVALUE e, const wchar_t* pFunc, std::wstring& rMsg);
	ecode(int e);
	virtual ~ecode();

	ecode& operator=(const eVALUE& rEC);
	int rc(void) { return (msiValue * -1); }			// リターンコード変換
	bool good(void);
	bool fail(void);

	void output(void);

protected:
	int initialize(void);
};

