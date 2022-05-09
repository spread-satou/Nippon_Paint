// dllmain.cpp : DLL アプリケーションのエントリ ポイントを定義します。
#include "pch.h"
#include <process.h>
#include <synchapi.h>
#include <iostream>
#include <stdio.h>
#include <string.h>
#include <vector>
#include <stdio.h>
#include <memory>
#include <sstream>

// debug>>>
#include <direct.h>     // _getcwd
#include <string>
#include "util_fullpath.h"
// debug<<<

#include "ecode.h"
#include "ftpParams.h"
#include "def_buffer.h"
#include "ftplog.h"
#include "params.h"
#include "csInterface.h"
#include "thr_semaphore.h"
#include "ftpsocket_ctrl.h"
#include "ftpsocket_tran.h"
// コマンドシーケンス
#include "seqwaiting.h"
#include "seqrestart.h"
#include "seqlogin.h"
#include "seqlogout.h"
#include "seqtype.h"
#include "seqsyst.h"
#include "seqcwd.h"
#include "seqpasv.h"
#include "seqport.h"
#include "seqnlst.h"
#include "seqcdup.h"
#include "seqretr.h"
#include "seqstor.h"
#include "seqstor2.h"
#include "seqpwd.h"
// utility
#include "filename.h"
#include "util_mktime.h"
#include "util_localtime.h"
#include "util_findfile.h"
#include "util_file.h"

//! グローバル変数
csInterface                 csIfObj;                    // C#/C++共有パラメータ(ORD情報配列)
params                      sharedObj;                  // C++内部共有パラメータ
ftplog*                     pSharedLog = (ftplog*)0;
int                         gLogCtrl = 1;               // コンソールアウトあり

//! プロトタイプ宣言
static  unsigned __cdecl file_transfer(void* pArguments);
void    make_subdir(std::string& rRootPath, const char* pRoot);
void    dbg_function(void);

//! 外部宣言
extern int sem_init(int siSEMID, LONG lInitialCount, LONG lMaximumCount);
extern int sem_close(int siSEMID);

/*!
 * @file        dllmain.cpp
 * @fn          BOOL APIENTRY DllMain(HMODULE hModule, DWORD ul_reason_for_call, LPVOID lpReserved)
 * @brief       DLLメイン
 * @details     DLLメイン
 * @return      TRUE
 * @date        2022/4/7
 * @note		***
 */
BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
                     )
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}

__declspec(dllexport) void native_simulator(ordParams* pORD)
{
    extern const char* pORD_NameTBL[EMEMBER::eNUMB];

    int err_length = 0;
    size_t              sz = 0;
    std::stringstream   ss;
    std::string         str_ord;

    // 
    if (ord_fmt::sscpy(ss, sz, pORD->pHG, PROPERTY_SIZE_HG) != 0) {
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eHG], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pPROC_NO, PROPERTY_SIZE_PROC_NO) != 0) {
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s % zd\n", pORD_NameTBL[EMEMBER::ePROC_NO], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pLINE_NO, PROPERTY_SIZE_LINE_NO) != 0) {
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eLINE_NO], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pDEVI_ANS, PROPERTY_SIZE_DEVI_ANS) != 0) {
        //! 分割回答 devision
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eDEVI_ANS], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pDEVI_DELI, PROPERTY_SIZE_DEVI_DELI) != 0) {
        //! 分割出荷 delivery
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eDEVI_DELI], sz);
        err_length += (int)sz;
    }
    //
    if (ord_fmt::sscpy(ss, sz, pORD->pSS, PROPERTY_SIZE_SS) != 0) {
        //! SSコード
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eSS], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pDELI_DATE, PROPERTY_SIZE_DELI_DATE) != 0) {
        //! 納期 delivery
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eDELI_DATE], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pPROD_CODE, PROPERTY_SIZE_PROD_CODE) != 0) {
        //! 商品コード product
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::ePROD_CODE], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pPROD_NAME, PROPERTY_SIZE_PROD_NAME) != 0) {
        //! 商品名 product
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::ePROD_NAME], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pCAPA, PROPERTY_SIZE_CAPA) != 0) {
        //! 容量 capacity
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eCAPA], sz);
        err_length += (int)sz;
    }
    //
    if (ord_fmt::sscpy(ss, sz, pORD->pQUAN, PROPERTY_SIZE_QUAN) != 0) {
        //! 数量 quantity
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eQUAN], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pSAMPLE, PROPERTY_SIZE_SAMPLE) != 0) {
        //! 標準見本
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eSAMPLE], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pRET_METHOD, PROPERTY_SIZE_RET_METHOD) != 0) {
        //! 返却方法
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eRET_METHOD], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pCOL_MANAGE, PROPERTY_SIZE_COL_MANAGE) != 0) {
        //! 調色精度
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eCOL_MANAGE], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pOTHER_NOTE, PROPERTY_SIZE_OTHER_NOTE) != 0) {
        //! その他特記事項
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eOTHER_NOTE], sz);
        err_length += (int)sz;
    }
    //
    if (ord_fmt::sscpy(ss, sz, pORD->pKG, PROPERTY_SIZE_KG) != 0) {
        //! Kg換算値
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eKG], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pWATER, PROPERTY_SIZE_WATER) != 0) {
        //! 水性区分
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eWATER], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pRECEIPT, PROPERTY_SIZE_RECEIPT) != 0) {
        //! 伝票区分
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eRECEIPT], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pCANCEL, PROPERTY_SIZE_CANCEL) != 0) {
        //! 取消区分
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eCANCEL], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pSUMMARY, PROPERTY_SIZE_SUMMARY) != 0) {
        //! 概要
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eSUMMARY], sz);
        err_length += (int)sz;
    }
    //
    if (ord_fmt::sscpy(ss, sz, pORD->pGROUP, PROPERTY_SIZE_GROUP) != 0) {
        //! 分類
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eGROUP], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pCLI_CODE, PROPERTY_SIZE_CLI_CODE) != 0) {
        //! 得意先コード clinet
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eCLI_CODE], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pCLI_NAME, PROPERTY_SIZE_CLI_NAME) != 0) {
        //! 得意先名
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eCLI_NAME], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pCLI_KANJI, PROPERTY_SIZE_CLI_KANJI) != 0) {
        //! 得意先漢字
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eCLI_KANJI], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pOFFICE_NAME, PROPERTY_SIZE_OFFICE_NAME) != 0) {
        //! 営業所名
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eOFFICE_NAME], sz);
        err_length += (int)sz;
    }
    //
    if (ord_fmt::sscpy(ss, sz, pORD->pCHAKUCHI, PROPERTY_SIZE_CHAKUCHI) != 0) {
        //! 着地コード
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eCHAKUCHI], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pPOI_AREA, PROPERTY_SIZE_POI_AREA) != 0) {
        //! ポイントエリア区分
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::ePOI_AREA], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pDELI_TEL, PROPERTY_SIZE_DELI_TEL) != 0) {
        //! 納入先TEL delivery
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eDELI_TEL], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pDELI_KANJI, PROPERTY_SIZE_DELI_KANJI) != 0) {
        //! 納入先名漢字
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eDELI_KANJI], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pDELI_ADDR, PROPERTY_SIZE_DELI_ADDR) != 0) {
        //! 納入先住所
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eDELI_ADDR], sz);
        err_length += (int)sz;
    }
    //
    if (ord_fmt::sscpy(ss, sz, pORD->pACT_DATE, PROPERTY_SIZE_ACT_DATE) != 0) {
        //! 投入日 activation
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eACT_DATE], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pACT_TIME, PROPERTY_SIZE_ACT_TIME) != 0) {
        //! 投入時間 activation
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eACT_TIME], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pORD_RANK, PROPERTY_SIZE_ORD_RANK) != 0) {
        //! 発注時ランク
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eORD_RANK], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pHGTRANS_GRP, PROPERTY_SIZE_HGTRANS_GRP) != 0) {
        //! 運送区分
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eHGTRANS_GRP], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pHGTRANS_LABEL, PROPERTY_SIZE_HGTRANS_LABEL) != 0) {
        //! 運送区分名(ラベル), 20bytes
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eHGTRANS_LABEL], sz);
        err_length += (int)sz;
    }
    //
    if (ord_fmt::sscpy(ss, sz, pORD->pSSTRANS_GRP, PROPERTY_SIZE_SSTRANS_GRP) != 0) {
        //! 運送区分
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eSSTRANS_GRP], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pSSTRANS_LABEL, PROPERTY_SIZE_SSTRANS_LABEL) != 0) {
        //! 運送区分名
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eSSTRANS_LABEL], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pRANKING_CODE, PROPERTY_SIZE_RANKING_CODE) != 0) {
        //! 順位コード
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                     "%s %zd\n", pORD_NameTBL[EMEMBER::eRANKING_CODE], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pRF_AGGRE_KIND, PROPERTY_SIZE_RF_AGGRE_KIND) != 0) {
        //! RF集計用品種 aggregation
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eRF_AGGRE_KIND], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pPLATE_ATTQUAN, PROPERTY_SIZE_PLATE_ATTQUAN) != 0) {
        //! 塗板添付枚数 plate attachment quantity
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::ePLATE_ATTQUAN], sz);
        err_length += (int)sz;
    }
    //
    if (ord_fmt::sscpy(ss, sz, pORD->pSSDELI_SCHE, PROPERTY_SIZE_SSDELI_SCHE) != 0) {
        //! SS出荷予定日　delivery scheduled date
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eSSDELI_SCHE], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pPERSON_NAME, PROPERTY_SIZE_PERSON_NAME) != 0) {
        //! 担当者名漢字
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::ePERSON_NAME], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pDELI_SCHE, PROPERTY_SIZE_DELI_SCHE) != 0) {
        //! 出荷予定日　delivery scheduled date
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eDELI_SCHE], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pNPITEM_CODE, PROPERTY_SIZE_NPITEM_CODE) != 0) {
        //! NP商品コード
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eNPITEM_CODE], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pNP_CAPA, PROPERTY_SIZE_NP_CAPA) != 0) {
        //! NP容量
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eNP_CAPA], sz);
        err_length += (int)sz;
    }
    //
    if (ord_fmt::sscpy(ss, sz, pORD->pHGTRANS_NAME, PROPERTY_SIZE_HGTRANS_NAME) != 0) {
        //! 運送区分名, 16bytes
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eHGTRANS_NAME], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pASK_OUT_GRP, PROPERTY_SIZE_ASK_OUT_GRP) != 0) {
        //! ASK出荷区分
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eASK_OUT_GRP], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pDELI_CO, PROPERTY_SIZE_DELI_CO) != 0) {
        //! 配送業者 company
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eDELI_CO], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pINT_ITEM_CODE, PROPERTY_SIZE_INT_ITEM_CODE) != 0) {
        //! 統合商品コード integration
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eINT_ITEM_CODE], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pRESERVE1, PROPERTY_SIZE_RESERVE1) != 0) {
        //! 予備
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eRESERVE], sz);
        err_length += (int)sz;
    }
    //
    if (ord_fmt::sscpy(ss, sz, pORD->pGLOSS_GRP, PROPERTY_SIZE_GLOSS_GRP) != 0) {
        //! ツヤ区分
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eGLOSS_GRP], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pCOL_FUNCGRP, PROPERTY_SIZE_COL_FUNCGRP) != 0) {
        //! 調色機能区分
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eCOL_FUNCGRP], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pRFDISP_GRP, PROPERTY_SIZE_RFDISP_GRP) != 0) {
        //! RF表示区分 display?
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eRFDISP_GRP], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pGLOSS_GRPNAME, PROPERTY_SIZE_GLOSS_GRPNAME) != 0) {
        //! ツヤ区分名
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eGLOSS_GRPNAME], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pCOL_FUNCNAME, PROPERTY_SIZE_COL_FUNCNAME) != 0) {
        //! 調色機能名称
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eCOL_FUNCNAME], sz);
        err_length += (int)sz;
    }
    //
    if (ord_fmt::sscpy(ss, sz, pORD->pCOURCE_NAME, PROPERTY_SIZE_COURCE_NAME) != 0) {
        //! コース名称
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eCOURCE_NAME], sz);
        err_length += (int)sz;
    }
    if (ord_fmt::sscpy(ss, sz, pORD->pRESERVE2, PROPERTY_SIZE_RESERVE2) != 0) {
        //! 予備2
        LOGTRACE(ECTRL::eYE, ERANK::eERR, ENAME::eSIM,
                    "%s %zd\n", pORD_NameTBL[EMEMBER::eRESERVE2], sz);
        err_length += (int)sz;
    }

    if (err_length > 0) {
        // 固定長を期待しているので、レングス異常があるとメモリアクセス違反が発生する。
        return;
    }

    str_ord = ss.str();                                 // テキスト1行取得

    int rc = 0;
    const char* psubd[4] = { "Incomming", "Completed", "OrderLogs", "Processed" };
    const char* pokyerr[2] = {"OKY", "ERR"};

    std::vector<std::string>    vfname;
    std::string                 str_root;
    std::string                 str_fullpath;
    std::stringstream           ss_tmp;
    const char*     pext;
    unsigned char*  pbuff;
    size_t          dtsize;
    std::string     str_okyerr;
    // new,delete
    filename*       pfn = (filename*)0;
    ord_buffer*     pord = (ord_buffer*)0;

    pord = new ord_buffer();
    pord->memupdate((unsigned char*)str_ord.c_str(), str_ord.size());
    rc = pord->inspector(str_okyerr);
    pext = (rc > 0) ? pokyerr[0] : pokyerr[1];

    // ORDファイル保存
    make_subdir(str_root, "HGSimulator");
    ss_tmp << str_root << "\\" << psubd[0/*Incomming*/] << "\\" << pORD->pfilename;
    str_fullpath = ss_tmp.str();

    pbuff = pord->get_pointer();
    dtsize= pord->get_datasize();
    utility::file::writer(str_fullpath.c_str(), (const char*)pbuff, dtsize);

    // OKY/ERRファイル保存
    pfn = new filename(pORD->pfilename, ".");
    pfn->splitter(vfname);

    str_fullpath.clear();
    ss_tmp.str("");
    ss_tmp << str_root << "\\" << psubd[3/*Processed*/] << "\\";
    ss_tmp << vfname[0] << vfname[1] << vfname[2] << "." << pext;
    str_fullpath = ss_tmp.str();

    pbuff = (unsigned char*)str_okyerr.c_str();
    dtsize= str_okyerr.size();
    utility::file::writer(str_fullpath.c_str(), (const char*)pbuff, dtsize);

    delete pord;
    delete pfn;
    return;
}

/*!
 * @file        dllmain.cpp
 * @fn          HANDLE native_thread_launcher(void)
 * @brief       FTPスレッド起動
 * @details     FTPスレッド起動
 * @return      0 <  VALUE: TBD
 * @date        1970/3/16
 * @note		***
 */
__declspec(dllexport) void native_thread_launcher(ftpParams* pFTP, ordArray* pORD)
{
    // [jp] https://docs.microsoft.com/ja-jp/cpp/c-runtime-library/reference/beginthread-beginthreadex?view=msvc-170
    // [us] https://docs.microsoft.com/en-us/cpp/c-runtime-library/reference/beginthread-beginthreadex?view=msvc-170

    HANDLE          hthr;
    unsigned int    thid;
    int             sverr = 0;
    int             svdoserr = 0;
    char*           pbuff = (char*)0;
    ftpParams*      pfp = (ftpParams*)0;
    size_t          szlen = 0;

#if 0
    //{
        ordParams   dbg;
        ordParams* pord = &pORD->op_array[0];

        dbg.pfullpath = new char[128];
        dbg.ptest = new char[128];
        dbg.ptest1 = new char[128];

        memcpy(dbg.pfullpath, (pord + 0)->pfullpath, 3);
        memcpy(dbg.ptest, (pord + 0)->ptest,   3);
        memcpy(dbg.ptest1, (pord + 0)->ptest1, 3);

        *(dbg.pfullpath + 4) = 0x00;
        *(dbg.ptest + 4) = 0x00;
        *(dbg.ptest1 + 4) = 0x00;

        //memcpy((pORD + 1)->pfullpath, "aaa\x0", 4);
        //memcpy((pORD + 1)->ptest, "bbb\x0", 6);
        //memcpy((pORD + 1)->ptest1, "ccc\x0", 6);

        //memcpy((pORD + 1)->pfullpath, "111\x0", 4);
        //memcpy((pORD + 1)->ptest, "222\x0", 6);
        //memcpy((pORD + 1)->ptest1, "333\x0", 6);
    //}
#endif

    pbuff = new char[DMSG_BUFFSIZE];
    memset(pbuff, 0x00, DMSG_BUFFSIZE);

    // ガベージコレクタにメモリ配置をかえられたら、不正アクセスが発生するので、
    // ネイティブコード内のメモリにコピーしておく。
    // 2005年頃のvisual studioはPinでメモリ配置を固定していたと思う。
    pfp = new ftpParams;
    memset(pfp, 0x00, sizeof(ftpParams));

    // 接続情報
    pfp->rfno = pFTP->rfno;

    // c#の実装でNULL終端になっていないと対応不能
    szlen = ::strnlen(pFTP->pip, 16);                // IPアドレス
    pfp->pip = new char[szlen+1];
    memcpy(pfp->pip, pFTP->pip, szlen);
    pfp->pip[szlen] = 0;                                // NULL終端

    szlen = ::strnlen(pFTP->pport, 8);               // PORT番号
    pfp->pport = new char[szlen + 1];
    memcpy(pfp->pport, pFTP->pport, szlen);
    pfp->pport[szlen] = 0;                              // NULL終端

    // アカウント情報
    szlen = ::strnlen(pFTP->puser, 255);             // ユーザー名
    pfp->puser = new char[szlen + 1];
    memcpy(pfp->puser, pFTP->puser, szlen);
    pfp->puser[szlen] = 0;

    szlen = ::strnlen(pFTP->ppass, 255);             // パスワード
    pfp->ppass = new char[szlen + 1];
    memcpy(pfp->ppass, pFTP->ppass, szlen);
    pfp->ppass[szlen] = 0;

    // download/uploadディレクトリ
    szlen = ::strnlen(pFTP->porders, 255);           // SND/ord_fmt
    pfp->porders = new char[szlen + 1];
    memcpy(pfp->porders, pFTP->porders, szlen);
    pfp->porders[szlen] = 0;

    szlen = ::strnlen(pFTP->pfeedback, 255);         // SND/ANSWER
    pfp->pfeedback = new char[szlen + 1];
    memcpy(pfp->pfeedback, pFTP->pfeedback, szlen);
    pfp->pfeedback[szlen] = 0;

    szlen = ::strnlen(pFTP->pnotify, 255);           // RCV/NOTIFY
    pfp->pnotify = new char[szlen + 1];
    memcpy(pfp->pnotify, pFTP->pnotify, szlen);
    pfp->pnotify[szlen] = 0;

    // イタリア製アプリは1起動1シーケンス
    hthr = (HANDLE)::_beginthreadex(
                            NULL,                       // Security: 子プロセスにハンドル継承しない
                            0,                          // stack_size: デフォルト
                            &file_transfer,             // スレッド開始アドレス
                            (void*)pfp,                 // arglist: スレッドに渡す引数
                            0,                          // initflag: 0は即時実行、CREATE_SUSPENDED は一時停止 
                            &thid);                     // スレッド識別子

    if (hthr == (HANDLE) - 1) {                         // -1エラー発生
        // https://docs.microsoft.com/ja-jp/cpp/c-runtime-library/errno-constants?view=msvc-170
        sverr = errno;
        std::cerr << ::strerror_s(pbuff, DMSG_BUFFSIZE, sverr) << std::endl;

#if 0
        // debug
        switch (errsv) {
        case EAGAIN:
            // これ以上プロセスを生成できないか、メモリが不足している
            printf("There are too many threads.\n");
            break;
        case EINVAL:
            // 引数が無効。関数の引数のいずれかに無効な値が指定されている
            printf("The argument is invalid or the stack size is incorrect.\n");
            break;
        case EACCES:
            // アクセス拒否
            printf("There are insufficient resources (such as memory).\n");
            break;
        }
#endif
    }
    else if (hthr == (HANDLE)0) {
        // https://docs.microsoft.com/ja-jp/cpp/c-runtime-library/errno-constants?view=msvc-170
        // マニュアル通りの実装
        sverr = errno;
        svdoserr = _doserrno;                           // 重要度が不明
        std::cerr << ::strerror_s(pbuff, DMSG_BUFFSIZE, sverr) << std::endl;

        std::cerr << "_doserrno: " << svdoserr << std::endl;
    }
    else {
        ::WaitForSingleObject(hthr, INFINITE);

        // Destroy the thread object.
        ::CloseHandle(hthr);

        delete[] pfp->pip;
        delete[] pfp->puser;
        delete[] pfp->ppass;
        delete[] pfp->porders;
        delete[] pfp->pfeedback;
        delete[] pfp->pnotify;

        // DEBUG
        dbg_function();
    }
}

void make_subdir(std::string& rRootPath, const char* pRoot)
{
    // https://docs.microsoft.com/ja-jp/cpp/c-runtime-library/reference/getcwd-wgetcwd?view=msvc-170
    char* pwork = (char*)0;
    const char* proot = pRoot;
    const char* psubd[4] = { "Incomming", "Completed", "OrderLogs", "Processed" };

    std::string str_root;
    std::string str_dir;
    int ii;

    pwork = ::_getcwd(0, 0);                            // カレントディレクトリ取得
    if (pwork == (char*)0) {
        return;
    }
    str_root = pwork;
    str_root = str_root + "\\" + proot;
    ::_mkdir(str_root.c_str());

    for (ii = 0; ii < 4; ii++) {
        str_dir = str_root + "\\" + psubd[ii];
        ::_mkdir(str_dir.c_str());
    }

    rRootPath = str_root;
}

void dbg_function(void)
{
    std::string str_root;
    std::string str_dir;

    make_subdir(str_root, "LOCAL");

    // Incomming/*.ORD削除
    str_dir.clear();
    str_dir = str_root + "\\" + "Incomming";
    utility::findfile::eraser(str_dir.c_str(), "*.ORD");

    // ファイル名作成
    using namespace utility;

    // LOCAL/IncomingへORDファイル保存
    std::vector<std::string> vpath;
    std::string str_fullpath[2];
    std::vector<ord_struct>::iterator iter;

    for (iter = csIfObj.vORD.begin(); iter != csIfObj.vORD.end(); iter++) {
        str_fullpath[0] = (*iter).mstrFullpath;

        fullpath::sepa(vpath, str_fullpath[0]);

        // C#へはOKYなORDしか渡さないので、OKY/ERRファイルは不要
        // OrderLogs/Processedも、C#は参照しないので、不要
        // LOCAL + \\ + Incoming + \\ + RFORDERyyyymmdd + "." + "ORD"
        str_fullpath[1] = str_root + "\\Incomming\\" + vpath[1] + "." + vpath[2];
        csIfObj.dbg_save((const char*)str_fullpath[1].c_str());
    }
}

/*!
 * @file        dllmain.cpp
 * @fn          static unsigned __cdecl file_transfer(void* pArguments)
 * @brief       FTPスレッド
 * @details     FTPスレッド
 * @return      0 <  VALUE: TBD
 * @date        1970/3/16
 * @note		***
 */
// https://docs.microsoft.com/en-us/windows/win32/sync/using-event-objects
static unsigned __cdecl file_transfer(void* pArguments)
{
    ftpParams* pfp = (ftpParams*)pArguments;

#if 0
    std::cout << pfp->rfno << std::endl;
    std::cout << pfp->pip << std::endl;
    std::cout << pfp->pport << std::endl;
    std::cout << pfp->puser << std::endl;
    std::cout << pfp->ppass << std::endl;
    std::cout << pfp->porders << std::endl;
    std::cout << pfp->pfeedback << std::endl;
    std::cout << pfp->pnotify << std::endl;

    char* buf[2048];
    utility::findfile f;
    f.finder("C:\\share\\nipponpaint\\3.pg\\ftpDLL\\ftpApp\\ftpApp\\bin\\Debug\\net6.0\\RF7\\Incomming", "*.ORD");

    int i = f.getindex();
    memset(&buf[0], 0x00, sizeof(buf));
    f.read_newfile("RFORDER1970100700382.ORD", (const char*)&buf[0], sizeof(buf));
#endif

    ///////////////////////////////////////////////////////////////////////////
    using namespace utility;

    int         ret_local= RET_SUCCESS;
    int         ret_clib = RET_SUCCESS;
    std::string str_fullpath_logf;
    std::string str_ltime;                              // local time
    stringstream ss_rfno;

    // ■ グローバルパラメータ(C#から通知されたパラメータ)
    sharedObj.mstrSrvPort[EPRM_PORT::eCTRL] = pfp->pport;   // SRV<---CLI: 制御用ポート(送信のみ)
    sharedObj.mstrSrvPort[EPRM_PORT::eTRNS] = "20";     // SRV<-->CLI: データ転送ポート(送受信)

    sharedObj.mstrSrvAcct[EPRM_ACCT::eIPv4] = pfp->pip;
    sharedObj.mstrSrvAcct[EPRM_ACCT::eUSER] = pfp->puser;
    sharedObj.mstrSrvAcct[EPRM_ACCT::ePASS] = pfp->ppass;

    sharedObj.mstrSrvDir[EPRM_SRVDIR::eORDER]   = pfp->porders;
    sharedObj.mstrSrvDir[EPRM_SRVDIR::eFEEDBACK]= pfp->pfeedback;
    sharedObj.mstrSrvDir[EPRM_SRVDIR::eNOTIFY]  = pfp->pnotify;

    sharedObj.msiSite = pfp->rfno;                      // EPRM_SITE::eRF7;

    ss_rfno << "\\RF" << pfp->rfno;
    sharedObj.mstrCurDir[EPRM_CLIDIR::eINCOM]   += ss_rfno.str() + "\\Incomming";
    sharedObj.mstrCurDir[EPRM_CLIDIR::eORDLOGS] += ss_rfno.str() + "\\OrderLogs";
    sharedObj.mstrCurDir[EPRM_CLIDIR::ePROC]    += ss_rfno.str() + "\\Processed";
    sharedObj.mstrCurDir[EPRM_CLIDIR::eCOMP]    += ss_rfno.str() + "\\Completed";

    // ORDERファイルオブジェクト初期化
    sharedObj.sync_init();
    sharedObj.mOrder.setcmd(ord_buffer::eCMD::eNLST);

    // FTPlog.txt初期化
    str_fullpath_logf = sharedObj.mstrFullPath[EPRM_PATH::eFTPLOG];
    pSharedLog = new ftplog(str_fullpath_logf.c_str());
    pSharedLog->sync_init();

    // コマンドシーケンスオブジェクト初期化
    ::sem_init(ESEMID::eFGBG, 0, 1);

    //■ 通信パラメータ初期化
    const char* psrv_ai[2] = {(const char*)0/*IPv4*/, (const char*)0/*PORT*/};
    const char* pacct[2]   = {(const char*)0/*user*/, (const char*)0/*pass*/};
                                                        // server address informaion
	ADDRINFOA	ai_ctrl;								// the getaddrinfo function(input引数) to hold host address information.
	ADDRINFOA	ai_tran;								// the getaddrinfo function(input引数) to hold host address information.

    // new, delete
    ftpsocket*  pctrl = (ftpsocket_ctrl*)0;             // 制御用ソケット
    ftpsocket*  ptran = (ftpsocket_tran*)0;             // 転送用ソケット

    psrv_ai[0] = sharedObj.mstrSrvAcct[EPRM_ACCT::eIPv4].c_str();
    psrv_ai[1] = sharedObj.mstrSrvPort[EPRM_PORT::eCTRL].c_str();
    pacct[0]   = sharedObj.mstrSrvAcct[EPRM_ACCT::eUSER].c_str();
    pacct[1]   = sharedObj.mstrSrvAcct[EPRM_ACCT::ePASS].c_str();

    //■ ローカルリソース初期化
    ftpsocket::addrinfo(&ai_ctrl, SOCPORT_CTRL);
    ftpsocket::addrinfo(&ai_tran, SOCPORT_TRAN);

    pctrl = new ftpsocket_ctrl();                       // 制御ポートソケット
    if (pctrl == (ftpsocket_ctrl*)0) {
        return RET_FAILED;
    }

    ptran = new ftpsocket_tran();                       // 転送ポートソケット
    if (ptran == (ftpsocket_tran*)0) {
        return RET_FAILED;
    }

    //
    // ■ 起動時のログ削除
    //
    ret_clib = std::remove(str_fullpath_logf.c_str());
    if (ret_clib == 0) {
    }
    else {
        // 削除ファイルがなければ、異常が返る
    }

    //
    // ■ ログ出力
    //
    params* pp = &sharedObj;                            // ショートカット
    std::string logf = str_fullpath_logf.c_str();       // ショートカット
    std::vector<logmsg*>& vlog = pSharedLog->mvElement; // ショートカット

    localtime::getstring(str_ltime, (const char*)0);
    vlog[EMSG::eSTA_PERFORMED]->writer(&gLogCtrl, logf.c_str(), str_ltime.c_str());

    vlog[EMSG::eSTA_CLEANING]->writer(&gLogCtrl,logf.c_str());

    vlog[EMSG::eSTA_RF]->writer(&gLogCtrl,      logf.c_str(), sharedObj.msiSite);
    vlog[EMSG::eJOB_STARTED]->writer(&gLogCtrl, logf.c_str(), str_ltime.c_str());

    // FTP connection parameters
    vlog[EMSG::eSTAT_TITLE]->writer(&gLogCtrl,logf.c_str());
    vlog[EMSG::eSTAT_HOST]->writer(&gLogCtrl, logf.c_str(), pp->mstrSrvAcct[EPRM_ACCT::eIPv4].c_str());
    vlog[EMSG::eSTAT_PORT]->writer(&gLogCtrl, logf.c_str(), pp->mstrSrvPort[EPRM_PORT::eCTRL].c_str());
    vlog[EMSG::eSTAT_USER]->writer(&gLogCtrl, logf.c_str(), pp->mstrSrvAcct[EPRM_ACCT::eUSER].c_str());
    vlog[EMSG::eSTAT_PASS]->writer(&gLogCtrl, logf.c_str(), pp->mstrSrvAcct[EPRM_ACCT::ePASS].c_str());

    vlog[EMSG::eSTAT_ORDDIR]->writer(&gLogCtrl,logf.c_str(), pp->mstrSrvDir[EPRM_SRVDIR::eORDER].c_str());
    vlog[EMSG::eSTAT_FBDIR]->writer(&gLogCtrl, logf.c_str(), pp->mstrSrvDir[EPRM_SRVDIR::eFEEDBACK].c_str());
    vlog[EMSG::eSTAT_NTYDIR]->writer(&gLogCtrl,logf.c_str(), pp->mstrSrvDir[EPRM_SRVDIR::eNOTIFY].c_str());

    // Connecting to IPv4
    vlog[EMSG::eSTAT_CONNECT]->writer(&gLogCtrl, logf.c_str(), pp->mstrSrvAcct[EPRM_ACCT::eIPv4].c_str());

    //
    // ■ 制御ポート接続(データポートは常時接続不可・実行時に都度接続する)
    //
    ret_local = pctrl->initialize(ai_ctrl, &psrv_ai[0]/*IPv4とPORT*/);
    ret_local = pctrl->connect(SOCCTRL::eMAIN);
    if (ret_local == RET_SUCCESS) {
        vlog[EMSG::eSTATUS]->writer(&gLogCtrl,       logf.c_str(), "Connected.");
        vlog[EMSG::eSTAT_SUCCESS]->writer(&gLogCtrl, logf.c_str());
        vlog[EMSG::eSTATUS]->writer(&gLogCtrl,       logf.c_str(), "Connection established");
    }
    else {
        ;//TBD
    }

    //
    //  ■ シーケンス処理まえ処理
    //
    std::vector<ftpseq*>            vstate;             // シーケンスオブジェクト配列
    std::vector<ftpseq*>::iterator  iter;               // シーケンスオブジェクト配列イテレータ

    vstate.push_back(new seqwaiting(pctrl));            // eWAITING
    vstate.push_back(new seqrestart(pctrl));            // eRESTART(RESTコマンドではない)

    // 制御ラインのみ
    //vstate.push_back(new seqlogin(pctrl, "spread", "spread", (const char*)0));
    //vstate.push_back(new seqlogin(pctrl, pacct[0], pacct[1], (const char*)0));
    vstate.push_back(new seqlogin(pctrl, pfp->puser, pfp->ppass, (const char*)0));
    vstate.push_back(new seqlogout(pctrl));             // eLOGOUT
    vstate.push_back(new seqtype(pctrl));               // eTYPE
    vstate.push_back(new seqsyst(pctrl));               // eSYST
    vstate.push_back(new seqcwd (pctrl, (const char*)0, pfp->porders));
                                                        // eCWD snd/ord_fmt
    vstate.push_back(new seqcdup(pctrl));               // eCDUP
    // データ転送併用
    vstate.push_back(new seqpasv(ptran, pctrl));        // ePASV
    vstate.push_back(new seqport(ptran, pctrl));        // ePORT
    vstate.push_back(new seqnlst(ptran, pctrl));        // eNLST
    vstate.push_back(new seqretr(ptran, pctrl));        // eDOWNLOAD
    vstate.push_back(new seqstor(ptran, pctrl));        // eUPLANS  SND/ANSWER
    vstate.push_back(new seqstor2(ptran, pctrl));       // eUPLNTY  RCV/NOTIFY
    // デバッグ用
    vstate.push_back(new seqpwd(pctrl));                // ePWD

    // 固有の初期化
    ((seqrestart*)vstate[ESTATE::eRESTART])->setai(psrv_ai[0], psrv_ai[1]);
                                                        // RESTART時にもIPv4とPORTが必要
    int index = ESTATE::eLOGIN;
    int status_next = ESTATE::eLOGIN;                   // new status
    int status_curr = ESTATE::eLOGIN;
    bool bloop = true;

    // 基本シーケンス
    //  eLOGIN => eTYPE => eSYST => eCWD
    //  ePORT => eCDUP => eCDUP => eCWD => eNLST         ファイル検索
    //  ePORT => eCDUP => eCDUP => eCWD => eDOWNLOAD     ORDダウンロード
    //  ePORT => eCDUP => eCDUP => eCWD => eUPLANS       OKY/ERRアップロード
    //  ePORT => eCDUP => eCDUP => eCWD => eUPLNTY       NTYアップロード
    while(bloop == true) {
        // 通常時、LISTコマンドで監視する。
        // 異常発生時、エラーコードをthrow

        try {
            // ■まえ処理
            status_next = vstate[index]->enter((void*)0);
            if (status_next != status_curr) {
                index = status_next;
                status_curr = status_next;
                continue;
            }

            // ■コマンド送受信
            status_next = vstate[index]->exec((void*)0);
            if (status_next != status_curr) {
                index = status_next;
                status_curr = status_next;
                continue;
            }

            // ■あと処理
            status_next = vstate[index]->exit((void*)0);
            if (status_next != status_curr) {
                if (status_next < 0) {                  // 中断
                    bloop = false;
                }
                else {
                    index = status_next;
                    status_curr = status_next;
                    continue;                           // いらんけど
                }
            }
        }
        catch(int e) {                                  // 1階層下でthrow
            std::cout << "[FATAL][ERR]Exception EC " << e << "\n";
#if 0
            bloop = false;
#else
            // LANケーブル未接続時、ESTATE::eRESTARTシーケンスとcatch()を繰り返す
            index = ESTATE::eLOGOUT;
            status_next = ESTATE::eLOGOUT;
            status_curr = ESTATE::eLOGOUT;
#endif
        }
    }

    // あと処理 メモリ&リソース解放
    str_ltime.clear();
    localtime::getstring(str_ltime, (const char*)0);
    vlog[EMSG::eJOB_TERMINATED]->writer(&gLogCtrl, logf.c_str(), str_ltime.c_str());

    for (iter = vstate.begin(); iter != vstate.end(); iter++) {
        if (*iter != (ftpseq*)0) {
            delete *iter;
            *iter = (ftpseq*)0;
        }
    }
    delete pctrl;
    delete ptran;

    // グローバルオブジェクト
    ::sem_close(ESEMID::eFGBG);                         // eSEM_ID::eFGBG
    sharedObj.sync_close();                             // eSEM_ID::ePARAMS
    pSharedLog->sync_close();                           // eSEM_ID::eLOGFILE
    delete pSharedLog;

    ///////////////////////////////////////////////////////////////////////////
    ::_endthreadex(0);
    return 0;
}
