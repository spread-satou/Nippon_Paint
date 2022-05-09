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
		eSIM_PARAM_NUMERR,								// シミュレータ・パラメータ個数異常

		// システム異常
		eNEW,											// メモリ確保失敗

		// Cライブラリ/STL失敗
		eGETCWD,
		eMBRLEN,

		// 以下、ポートの初期化が必要
		// Winライブラリ失敗
        eCREATEFILE,
        eGETCOMMSTATE,
        eSETCOMMSTATE,
		eWAITCOMMEVENT,
		eREADFILE,
		eSETCOMMBREAK,
		eCLEARCOMMBREAK,
		ePURGECOMM,

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

