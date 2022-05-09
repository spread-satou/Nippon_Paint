#pragma once
//class serialParams
//{
//};

struct serialParams {									//! 通信パラメータ
	// 仕様
	//  0: END文字列後に可変長メッセージなし(大阪以外)
	//  1: END文字列後に可変長メッセージあり(大阪)
	//  2～TBD
	int		msgfmt;										// メッセージフォーマット

	// シリアルパラメータ
	char*	pport;										// ポート番号
	int		baudrate;									// 通信速度
	int		databites;									// データビット
	char*	pstopbits;									// ストップビット
	char*	pparity;									// パリティ
	int		dtrFlow;									// DTR Control Flow
	int		rtsFlow;									// RTS Control Flow
	char	xon;										// 0固定
	char	xoff;										// 0固定
};

struct comParams {										//! Windows用COMポート
	int		msgFmt;										// メッセージフォーマット

	char*	pport;										// ポート番号
	DCB		commstate;									// SetCommState()パラメータ
};

struct ccmParams {
    // 1-5
    char*	pKan;                               //! 缶種
    char*	pRev;                               //! 改訂
    char*	pProdName;                          //! 製品名
    char*	pProdCode;                          //! 製品コード
    char*	pPainName;                          //! 塗料名
    // 6-7
    char*	pWHCode;                            //! ホワイトコード
    char*	pWHWeight;                          //! ホワイト重量
    // 8-17
    char*	pColorant01;                        //! 着色剤コード1
    char*	pWeghit01;                          //! 重量1
    char*	pColorant02;                        //! 着色剤コード
    char*	pWeghit02;                          //! 重量
    char*	pColorant03;                        //! 着色剤コード
    char*	pWeghit03;                          //! 重量
    char*	pColorant04;                        //! 着色剤コード
    char*	pWeghit04;                          //! 重量
    char*	pColorant05;                        //! 着色剤コード
    char*	pWeghit05;                          //! 重量
    // 18-27
    char*	pColorant06;                        //! 着色剤コード
    char*	pWeghit06;                          //! 重量
    char*	pColorant07;                        //! 着色剤コード
    char*	pWeghit07;                          //! 重量
    char*	pColorant08;                        //! 着色剤コード
    char*	pWeghit08;                          //! 重量
    char*	pColorant09;                        //! 着色剤コード
    char*	pWeghit09;                          //! 重量
    char*	pColorant10;                        //! 着色剤コード
    char*	pWeghit10;                          //! 重量
    // 28-37
    char*	pColorant11;                        //! 着色剤コード
    char*	pWeghit11;                          //! 重量
    char*	pColorant12;                        //! 着色剤コード
    char*	pWeghit12;                          //! 重量
    char*	pColorant13;                        //! 着色剤コード
    char*	pWeghit13;                          //! 重量
    char*	pColorant14;                        //! 着色剤コード
    char*	pWeghit14;                          //! 重量
    char*	pColorant15;                        //! 着色剤コード
    char*	pWeghit15;                          //! 重量
    // 38-45
    char*	pColorant16;                        //! 着色剤コード
    char*	pWeghit16;                          //! 重量
    char*	pColorant17;                        //! 着色剤コード
    char*	pWeghit17;                          //! 重量
    char*	pColorant18;                        //! 着色剤コード
    char*	pWeghit18;                          //! 重量
    char*	pColorant19;                        //! 着色剤コード
    char*	pWeghit19;                          //! 重量
    // 46-50
    char*	pGrossWeight;                       //! 総重量
    char*	pTerm;                              //! ターミネータ
    char*	pFilename;                          //! 既調色ファイル名
    char*	pIndex;                             //! 目次番号
    char*	pLineName;                          //! ライン名
};

class win_serial {
public:
	win_serial();
	virtual ~win_serial();

	// C#から通知されたパラメータ(ユーザー目線の数値)をWinAPIに渡す数値に変換
	static int baudrate(int siCSValue);
	static int databites(int siCSValue);
	static int stopbits(char* pCSValue, size_t szSize);
	static int parity(char* pCSValue, size_t szSize);

	// DTR/DSR モデム制御用記号 (terminal ready/ terminal set)
	static int dtrFlow(int siCSValue);

	// ハードウェアFLOW	RTS/CTS	(要求/許可) 
	static int rtsFlow(int siCSValue);
};


// Exports for serialDLL.dll

#ifdef __cplusplus
extern "C"
{
#endif
	__declspec(dllexport) int native_simulator(ccmParams* pParams);
	__declspec(dllexport) int native_thread_launcher(serialParams* pParams);
	__declspec(dllexport) int native_release();
#ifdef __cplusplus
}
#endif
