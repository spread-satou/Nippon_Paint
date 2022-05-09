#pragma once
#include <string>
#include "order.h"

struct ftpParams {
	// 接続情報
	int		rfno;
	char*	pip;										// Ex.192.168.11.37
	//int 	port;										// ポート番号
	char* 	pport;										// ポート番号

	// アカウント情報
	char* puser;										// ユーザー名
	char* ppass;										// パスワード

	// download/uploadディレクトリ
	char* porders;										// Ex. SND/ORDER
	char* pfeedback;									// Ex. SND/ANSWER
	char* pnotify;										// Ex. RCV/NOTIFY
};

struct ordParams {
	char* pfilename;
#if 0
    char* pparams[EMEMBER::eNUMB];
#else
    char* pHG;                                          //! HG区分
    char* pPROC_NO;                                     //! 処理NO   proceed
    char* pLINE_NO;                                     //! 行NO
    char* pDEVI_ANS;                                    //! 分割回答 devision
    char* pDEVI_DELI;                                   //! 分割出荷 delivery
    char* pSS;                                          //! SSコード
    char* pDELI_DATE;                                   //! 納期 delivery
    char* pPROD_CODE;                                   //! 商品コード product
    char* pPROD_NAME;                                   //! 商品名 product
    char* pCAPA;                                        //! 容量 capacity
    char* pQUAN;                                        //! 数量 quantity
    char* pSAMPLE;                                      //! 標準見本
    char* pRET_METHOD;                                  //! 返却方法
    char* pCOL_MANAGE;                                  //! 調色精度
    char* pOTHER_NOTE;                                  //! その他特記事項
    char* pKG;                                          //! Kg換算値
    char* pWATER;                                       //! 水性区分
    char* pRECEIPT;                                     //! 伝票区分
    char* pCANCEL;                                      //! 取消区分
    char* pSUMMARY;                                     //! 概要
    char* pGROUP;                                       //! 分類
    char* pCLI_CODE;                                    //! 得意先コード clinet
    char* pCLI_NAME;                                    //! 得意先名
    char* pCLI_KANJI;                                   //! 得意先漢字
    char* pOFFICE_NAME;                                 //! 営業所名
    char* pCHAKUCHI;                                    //! 着地コード
    char* pPOI_AREA;                                    //! ポイントエリア区分
    char* pDELI_TEL;                                    //! 納入先TEL delivery
    char* pDELI_KANJI;                                  //! 納入先名漢字
    char* pDELI_ADDR;                                   //! 納入先住所
    char* pACT_DATE;                                    //! 投入日 activation
    char* pACT_TIME;                                    //! 投入時間 activation
    char* pORD_RANK;                                    //! 発注時ランク
    char* pHGTRANS_GRP;                                 //! 運送区分
    char* pHGTRANS_LABEL;                               //! 運送区分名(ラベル), 20bytes
    char* pSSTRANS_GRP;                                 //! 運送区分
    char* pSSTRANS_LABEL;                               //! 運送区分名
    char* pRANKING_CODE;                                //! 順位コード
    char* pRF_AGGRE_KIND;                               //! RF集計用品種 aggregation
    char* pPLATE_ATTQUAN;                               //! 塗板添付枚数 plate attachment quantity
    char* pSSDELI_SCHE;                                 //! SS出荷予定日　delivery scheduled date
    char* pPERSON_NAME;                                 //! 担当者名漢字
    char* pDELI_SCHE;                                   //! 出荷予定日　delivery scheduled date
    char* pNPITEM_CODE;                                 //! NP商品コード
    char* pNP_CAPA;                                     //! NP容量
    char* pHGTRANS_NAME;                                //! 運送区分名, 16bytes
    char* pASK_OUT_GRP;                                 //! ASK出荷区分
    char* pDELI_CO;                                     //! 配送業者 company
    char* pINT_ITEM_CODE;                               //! 統合商品コード integration
    char* pRESERVE1;                                    //! 予備
    char* pGLOSS_GRP;                                   //! ツヤ区分
    char* pCOL_FUNCGRP;                                 //! 調色機能区分
    char* pRFDISP_GRP;                                  //! RF表示区分 display?
    char* pGLOSS_GRPNAME;                               //! ツヤ区分名
    char* pCOL_FUNCNAME;                                //! 調色機能名称
    char* pCOURCE_NAME;                                 //! コース名称
    char* pRESERVE2;                                    //! 予備2
#endif
};

struct ordArray {
	ordParams	op_array[1];
};

// Exports for ftpDLL.dll

#ifdef __cplusplus
extern "C"
{
#endif
	__declspec(dllexport) void native_simulator(ordParams* pORD);
	__declspec(dllexport) void native_thread_launcher(ftpParams* pParams, ordArray* pORD);
#ifdef __cplusplus
}
#endif
