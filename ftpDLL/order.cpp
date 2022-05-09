#include "pch.h"
#include "order.h"
#include "ecode.h"
#include "util_orderstr.h"
#include <fstream>
#include <iostream>
#include <sstream>

using namespace utility;

/*  データフロー
       
        ord_property配列  ← mpBufferポインタ(mydata構造体ポインタ)  ← ダウンロードデータ
            ┏━━━━━━━━━━┓     ┏━━━━━━━━━━┓                 std::string
        ┏━━━━━━━━━━┓  ┃  ← ┃                    ┃ <============== ┏━━━━━━━━━━┓
    ┏━━━━━━━━━━┓  ┃  ┃     ┃                    ┃                 ┗━━━━━━━━━━┛
    ┃                    ┃  ┃━┛     ┃                    ┃
    ┃                    ┃━┛         ┃                    ┃
    ┗━━━━━━━━━━┛             ┃                    ┃
        ↓                               ┃                    ┃
        ↓                               ┗━━━━━━━━━━┛   
        ↓
     C#へは
     std::string配列で通知する　getall(std::vector<std::string>& evString)
    ┏━━━━━━━━━━┓ 
    ┃----------          ┃
    ┃----------          ┃
    ┃----------          ┃
    ┃----------          ┃
    ┃----------          ┃
    ┃----------          ┃
    ┗━━━━━━━━━━┛
 */

// 基本仕様書に記載されているアルファベット文字列
const char* pORD_NameTBL[EMEMBER::eNUMB] = {
    //1-5
    "AREA_CODE",
    "SLIP_NUMBER",
    "DETAIL_NUMBER",
    "REPLY_INSTALLMENT_NUMBER",
    "ACTUAL_INSTALLMENT_NUMBER",
    //6-10
    "SS_CODE",
    "DUE_DATE",
    "ITEM_CODE",
    "ITEM_NAME",
    "PACKAGE_CODE",
    //11-15
    "QUANTITY",
    "PROOFING_STANDARD_SAMPLE",
    "SAMPLE_RETURN_METHOD",
    "REQUIRED_LOT_NUMBER",
    "SUMMARY_FOR_PROOFING",
    //16-20
    "WEIGHT",
    "WATER_SOLVENT_TYPE",
    "SLIP_TYPE",
    "CANCELLATION_TYPE",
    "SUMMARY",
    //21-25
    "PROOFING_TYPE_CODE",
    "DEALER_CODE",
    "DEALER_NAME_KANA",
    "DEALER_NAME",
    "BLOCK_NAME",
    //26-30
    "DESTINATION_CODE",
    "POINT_AREA_TYPE",
    "DESTINATION_TELEPHONE_NUMBER",
    "DESTINATION_NAME_KANJI",
    "DESTINATION_ADDRESS_KANJI",
    //31-35
    "INPUT_DATE",
    "INPUT_TIME",
    "RANK_CODE",
    "HG_CARRIER_TYPE",
    "HG_CARRIER_TYPE_NAME_LABEL",
    //36-40
    "IS_AUTO_LINE_OUT",
    "SS_DELIVERY_TYPE_NAME",
    "ITEM_ORDER_CODE",
    "RF_TOTAL_VARIETY",
    "SAMPLE_PLATE_QUANTITY",
    //41-45
    "SS_SITE_OUT_PLAN_DATE",
    "PERSON_IN_CHARGE_NAME",
    "SITE_OUT_PLAN_DATE",
    "NP_VARIETY_CODE",
    "NP_PACKAGE_CODE",
    //46-50
    "HG_CARRIER_TYPE_NAME",
    "ASK_OUTPUT_TYPE",
    "CARRIER_NAME",
    "COMMON_ITEM_CODE",
    "RESERVE",
    //51-55
    "GLOSS_TYPE_CODE",
    "ADDITIONAL_PROOF_TYPE_CODE",
    "RF_DISPLAY_COLOR_TYPE",
    "GLOSS_TYPE_NAME",
    "ADDITIONAL_PROOF_TYPE_NAME",
    //56-57
    "COURSE_NAME",
    "RESERVE2"
};

///////////////////////////////////////////////////////////////////////////////
ord_buffer::ord_buffer()
{
    this->initialize();
}

ord_buffer::~ord_buffer()
{
    if (mpBuffer != (unsigned char*)0) {
        delete[] mpBuffer;
        mpBuffer = (unsigned char*)0;
    }

    std::vector<ord_property*>::iterator iter;
    for (iter = mvData.begin(); iter != mvData.end(); iter++) {
        if (*iter != 0) {
            delete *iter;
        }
    }
}

int ord_buffer::initialize(void)
{
    this->valiables();
#if 1
    mvData[EMEMBER::eHG]->setter(PROPERTY_SIZE_HG, PROPERTY_ATTR_X);                        //! HG区分
    mvData[EMEMBER::ePROC_NO]->setter(PROPERTY_SIZE_PROC_NO, PROPERTY_ATTR_X);              //! 処理NO   proceed
    mvData[EMEMBER::eLINE_NO]->setter(PROPERTY_SIZE_LINE_NO, PROPERTY_ATTR_X);              //! 行NO
    mvData[EMEMBER::eDEVI_ANS]->setter(PROPERTY_SIZE_DEVI_ANS, PROPERTY_ATTR_X);            //! 分割回答 devision
    mvData[EMEMBER::eDEVI_DELI]->setter(PROPERTY_SIZE_DEVI_DELI, PROPERTY_ATTR_X);          //! 分割出荷 delivery

    mvData[EMEMBER::eSS]->setter(PROPERTY_SIZE_SS, PROPERTY_ATTR_X);                        //! SSコード
    mvData[EMEMBER::eDELI_DATE]->setter(PROPERTY_SIZE_DELI_DATE, PROPERTY_ATTR_X);          //! 納期 delivery
    mvData[EMEMBER::ePROD_CODE]->setter(PROPERTY_SIZE_PROD_CODE, PROPERTY_ATTR_X);          //! 商品コード product
    mvData[EMEMBER::ePROD_NAME]->setter(PROPERTY_SIZE_PROD_NAME, PROPERTY_ATTR_N);          //! 商品名 product
    mvData[EMEMBER::eCAPA]->setter(PROPERTY_SIZE_CAPA, PROPERTY_ATTR_X);                    //! 容量 capacity

    mvData[EMEMBER::eQUAN]->setter(PROPERTY_SIZE_QUAN, PROPERTY_ATTR_9);                    //! 数量 quantity
    mvData[EMEMBER::eSAMPLE]->setter(PROPERTY_SIZE_SAMPLE, PROPERTY_ATTR_N);                //! 標準見本
    mvData[EMEMBER::eRET_METHOD]->setter(PROPERTY_SIZE_RET_METHOD, PROPERTY_ATTR_N);        //! 返却方法
    mvData[EMEMBER::eCOL_MANAGE]->setter(PROPERTY_SIZE_COL_MANAGE, PROPERTY_ATTR_X);        //! 調色精度
    mvData[EMEMBER::eOTHER_NOTE]->setter(PROPERTY_SIZE_OTHER_NOTE, PROPERTY_ATTR_N);        //! その他特記事項

    mvData[EMEMBER::eKG]->setter(PROPERTY_SIZE_KG, PROPERTY_ATTR_9);                        //! Kg換算値
    mvData[EMEMBER::eWATER]->setter(PROPERTY_SIZE_WATER, PROPERTY_ATTR_X);                  //! 水性区分
    mvData[EMEMBER::eRECEIPT]->setter(PROPERTY_SIZE_RECEIPT, PROPERTY_ATTR_X);              //! 伝票区分
    mvData[EMEMBER::eCANCEL]->setter(PROPERTY_SIZE_CANCEL, PROPERTY_ATTR_X);                //! 取消区分
    mvData[EMEMBER::eSUMMARY]->setter(PROPERTY_SIZE_SUMMARY, PROPERTY_ATTR_N);              //! 概要

    mvData[EMEMBER::eGROUP]->setter(PROPERTY_SIZE_GROUP, PROPERTY_ATTR_X);                  //! 分類
    mvData[EMEMBER::eCLI_CODE]->setter(PROPERTY_SIZE_CLI_CODE, PROPERTY_ATTR_X);            //! 得意先コード clinet
    mvData[EMEMBER::eCLI_NAME]->setter(PROPERTY_SIZE_CLI_NAME, PROPERTY_ATTR_X);            //! 得意先名
    mvData[EMEMBER::eCLI_KANJI]->setter(PROPERTY_SIZE_CLI_KANJI, PROPERTY_ATTR_N);          //! 得意先漢字
    mvData[EMEMBER::eOFFICE_NAME]->setter(PROPERTY_SIZE_OFFICE_NAME, PROPERTY_ATTR_N);      //! 営業所名

    mvData[EMEMBER::eCHAKUCHI]->setter(PROPERTY_SIZE_CHAKUCHI, PROPERTY_ATTR_X);            //! 着地コード
    mvData[EMEMBER::ePOI_AREA]->setter(PROPERTY_SIZE_POI_AREA, PROPERTY_ATTR_X);            //! ポイントエリア区分
    mvData[EMEMBER::eDELI_TEL]->setter(PROPERTY_SIZE_DELI_TEL, PROPERTY_ATTR_X);            //! 納入先TEL delivery
    mvData[EMEMBER::eDELI_KANJI]->setter(PROPERTY_SIZE_DELI_KANJI, PROPERTY_ATTR_N);        //! 納入先名漢字
    mvData[EMEMBER::eDELI_ADDR]->setter(PROPERTY_SIZE_DELI_ADDR, PROPERTY_ATTR_N);          //! 納入先住所

    mvData[EMEMBER::eACT_DATE]->setter(PROPERTY_SIZE_ACT_DATE, PROPERTY_ATTR_X);            //! 投入日 activation
    mvData[EMEMBER::eACT_TIME]->setter(PROPERTY_SIZE_ACT_TIME, PROPERTY_ATTR_X);            //! 投入時間 activation
    mvData[EMEMBER::eORD_RANK]->setter(PROPERTY_SIZE_ORD_RANK, PROPERTY_ATTR_X);            //! 発注時ランク
    mvData[EMEMBER::eHGTRANS_GRP]->setter(PROPERTY_SIZE_HGTRANS_GRP, PROPERTY_ATTR_X);      //! 運送区分
    mvData[EMEMBER::eHGTRANS_LABEL]->setter(PROPERTY_SIZE_HGTRANS_LABEL, PROPERTY_ATTR_N);  //! 運送区分名(ラベル)

    mvData[EMEMBER::eSSTRANS_GRP]->setter(PROPERTY_SIZE_SSTRANS_GRP, PROPERTY_ATTR_X);      //! 運送区分
    mvData[EMEMBER::eSSTRANS_LABEL]->setter(PROPERTY_SIZE_SSTRANS_LABEL, PROPERTY_ATTR_N);  //! 運送区分名
    mvData[EMEMBER::eRANKING_CODE]->setter(PROPERTY_SIZE_RANKING_CODE, PROPERTY_ATTR_X);    //! 順位コード
    mvData[EMEMBER::eRF_AGGRE_KIND]->setter(PROPERTY_SIZE_RF_AGGRE_KIND, PROPERTY_ATTR_X);  //! RF集計用品種 aggregation
    mvData[EMEMBER::ePLATE_ATTQUAN]->setter(PROPERTY_SIZE_PLATE_ATTQUAN, PROPERTY_ATTR_9);  //! 塗板添付枚数 plate attachment quantity

    mvData[EMEMBER::eSSDELI_SCHE]->setter(PROPERTY_SIZE_SSDELI_SCHE, PROPERTY_ATTR_X);      //! SS出荷予定日　delivery scheduled date
    mvData[EMEMBER::ePERSON_NAME]->setter(PROPERTY_SIZE_PERSON_NAME, PROPERTY_ATTR_N);      //! 担当者名漢字
    mvData[EMEMBER::eDELI_SCHE]->setter(PROPERTY_SIZE_DELI_SCHE, PROPERTY_ATTR_X);          //! 出荷予定日　delivery scheduled date
    mvData[EMEMBER::eNPITEM_CODE]->setter(PROPERTY_SIZE_NPITEM_CODE, PROPERTY_ATTR_X);      //! NP商品コード
    mvData[EMEMBER::eNP_CAPA]->setter(PROPERTY_SIZE_NP_CAPA, PROPERTY_ATTR_X);              //! NP容量

    mvData[EMEMBER::eHGTRANS_NAME]->setter(PROPERTY_SIZE_HGTRANS_NAME, PROPERTY_ATTR_N);    //! 運送区分名
    mvData[EMEMBER::eASK_OUT_GRP]->setter(PROPERTY_SIZE_ASK_OUT_GRP, PROPERTY_ATTR_X);      //! ASK出荷区分
    mvData[EMEMBER::eDELI_CO]->setter(PROPERTY_SIZE_DELI_CO, PROPERTY_ATTR_N);              //! 配送業者 company
    mvData[EMEMBER::eINT_ITEM_CODE]->setter(PROPERTY_SIZE_INT_ITEM_CODE, PROPERTY_ATTR_X);  //! 統合商品コード integration
    mvData[EMEMBER::eRESERVE]->setter(PROPERTY_SIZE_RESERVE1, PROPERTY_ATTR_X);             //! 予備

    mvData[EMEMBER::eGLOSS_GRP]->setter(PROPERTY_SIZE_GLOSS_GRP, PROPERTY_ATTR_X);          //! ツヤ区分
    mvData[EMEMBER::eCOL_FUNCGRP]->setter(PROPERTY_SIZE_COL_FUNCGRP, PROPERTY_ATTR_X);      //! 調色機能区分
    mvData[EMEMBER::eRFDISP_GRP]->setter(PROPERTY_SIZE_RFDISP_GRP, PROPERTY_ATTR_X);        //! RF表示区分 display?
    mvData[EMEMBER::eGLOSS_GRPNAME]->setter(PROPERTY_SIZE_GLOSS_GRPNAME, PROPERTY_ATTR_N);  //! ツヤ区分名
    mvData[EMEMBER::eCOL_FUNCNAME]->setter(PROPERTY_SIZE_COL_FUNCNAME, PROPERTY_ATTR_N);    //! 調色機能名称

    mvData[EMEMBER::eCOURCE_NAME]->setter(PROPERTY_SIZE_COURCE_NAME, PROPERTY_ATTR_N);      //! コース名称
    mvData[EMEMBER::eRESERVE2]->setter(PROPERTY_SIZE_RESERVE2, PROPERTY_ATTR_N);            //! 予備2

    int sisize = 0;
    std::vector<ord_property*>::iterator  iter;
    for (iter = mvData.begin(); iter != mvData.end(); iter++) {
        sisize += (*iter)->get_size();
    }

    mpBuffer = new unsigned char[sisize];
    if (mpBuffer > (unsigned char*)0) {
        ::memset(mpBuffer, 0x00, sisize);
        msiDataSize = sisize;
    }
    else {
        return RET_FAILED;
    }

    ord_fmt::mydata* ptmp = (ord_fmt::mydata*)mpBuffer;

    mvData[EMEMBER::eHG]->set_addr(&ptmp->u8HG[0]);                         //! HG区分
    mvData[EMEMBER::ePROC_NO]->set_addr(&ptmp->u8PROC_NO[0]);               //! 処理NO   proceed
    mvData[EMEMBER::eLINE_NO]->set_addr(&ptmp->u8LINE_NO[0]);               //! 行NO
    mvData[EMEMBER::eDEVI_ANS]->set_addr(&ptmp->u8DEVI_ANS[0]);             //! 分割回答 devision
    mvData[EMEMBER::eDEVI_DELI]->set_addr(&ptmp->u8DEVI_DELI[0]);           //! 分割出荷 delivery

    mvData[EMEMBER::eSS]->set_addr(&ptmp->u8SS[0]);                         //! SSコード
    mvData[EMEMBER::eDELI_DATE]->set_addr(&ptmp->u8DELI_DATE[0]);           //! 納期 delivery
    mvData[EMEMBER::ePROD_CODE]->set_addr(&ptmp->u8PROD_CODE[0]);           //! 商品コード product
    mvData[EMEMBER::ePROD_NAME]->set_addr(&ptmp->u8PROD_NAME[0]);           //! 商品名 product
    mvData[EMEMBER::eCAPA]->set_addr(&ptmp->u8CAPA[0]);                     //! 容量 capacity

    mvData[EMEMBER::eQUAN]->set_addr(&ptmp->u8QUAN[0]);                     //! 数量 quantity
    mvData[EMEMBER::eSAMPLE]->set_addr(&ptmp->u8SAMPLE[0]);                 //! 標準見本
    mvData[EMEMBER::eRET_METHOD]->set_addr(&ptmp->u8RET_METHOD[0]);         //! 返却方法
    mvData[EMEMBER::eCOL_MANAGE]->set_addr(&ptmp->u8COL_MANAGE[0]);         //! 調色精度
    mvData[EMEMBER::eOTHER_NOTE]->set_addr(&ptmp->u8OTHER_NOTE[0]);         //! その他特記事項
 
    mvData[EMEMBER::eKG]->set_addr(&ptmp->u8KG[0]);                         //! Kg換算値
    mvData[EMEMBER::eWATER]->set_addr(&ptmp->u8WATER[0]);                   //! 水性区分
    mvData[EMEMBER::eRECEIPT]->set_addr(&ptmp->u8RECEIPT[0]);               //! 伝票区分
    mvData[EMEMBER::eCANCEL]->set_addr(&ptmp->u8CANCEL[0]);                 //! 取消区分
    mvData[EMEMBER::eSUMMARY]->set_addr(&ptmp->u8SUMMARY[0]);               //! 概要

    mvData[EMEMBER::eGROUP]->set_addr(&ptmp->u8GROUP[0]);                   //! 分類
    mvData[EMEMBER::eCLI_CODE]->set_addr(&ptmp->u8CLI_CODE[0]);             //! 得意先コード clinet
    mvData[EMEMBER::eCLI_NAME]->set_addr(&ptmp->u8CLI_NAME[0]);             //! 得意先名
    mvData[EMEMBER::eCLI_KANJI]->set_addr(&ptmp->u8CLI_KANJI[0]);           //! 得意先漢字
    mvData[EMEMBER::eOFFICE_NAME]->set_addr(&ptmp->u8OFFICE_NAME[0]);       //! 営業所名

    mvData[EMEMBER::eCHAKUCHI]->set_addr(&ptmp->u8CHAKUCHI[0]);             //! 着地コード
    mvData[EMEMBER::ePOI_AREA]->set_addr(&ptmp->u8POI_AREA[0]);             //! ポイントエリア区分
    mvData[EMEMBER::eDELI_TEL]->set_addr(&ptmp->u8DELI_TEL[0]);             //! 納入先TEL delivery
    mvData[EMEMBER::eDELI_KANJI]->set_addr(&ptmp->u8DELI_KANJI[0]);         //! 納入先名漢字
    mvData[EMEMBER::eDELI_ADDR]->set_addr(&ptmp->u8DELI_ADDR[0]);           //! 納入先住所

    mvData[EMEMBER::eACT_DATE]->set_addr(&ptmp->u8ACT_DATE[0]);             //! 投入日 activation
    mvData[EMEMBER::eACT_TIME]->set_addr(&ptmp->u8ACT_TIME[0]);             //! 投入時間 activation
    mvData[EMEMBER::eORD_RANK]->set_addr(&ptmp->u8ORD_RANK[0]);             //! 発注時ランク
    mvData[EMEMBER::eHGTRANS_GRP]->set_addr(&ptmp->u8HGTRANS_GRP[0]);       //! 運送区分
    mvData[EMEMBER::eHGTRANS_LABEL]->set_addr(&ptmp->u8HGTRANS_LABEL[0]);   //! 運送区分名(ラベル)

    mvData[EMEMBER::eSSTRANS_GRP]->set_addr(&ptmp->u8SSTRANS_GRP[0]);       //! 運送区分
    mvData[EMEMBER::eSSTRANS_LABEL]->set_addr(&ptmp->u8SSTRANS_LABEL[0]);   //! 運送区分名
    mvData[EMEMBER::eRANKING_CODE]->set_addr(&ptmp->u8RANKING_CODE[0]);     //! 順位コード
    mvData[EMEMBER::eRF_AGGRE_KIND]->set_addr(&ptmp->u8RF_AGGRE_KIND[0]);   //! RF集計用品種 aggregation
    mvData[EMEMBER::ePLATE_ATTQUAN]->set_addr(&ptmp->u8PLATE_ATTQUAN[0]);   //! 塗板添付枚数 plate attachment quantity

    mvData[EMEMBER::eSSDELI_SCHE]->set_addr(&ptmp->u8SSDELI_SCHE[0]);       //! SS出荷予定日　delivery scheduled date
    mvData[EMEMBER::ePERSON_NAME]->set_addr(&ptmp->u8PERSON_NAME[0]);       //! 担当者名漢字
    mvData[EMEMBER::eDELI_SCHE]->set_addr(&ptmp->u8DELI_SCHE[0]);           //! 出荷予定日　delivery scheduled date
    mvData[EMEMBER::eNPITEM_CODE]->set_addr(&ptmp->u8NPITEM_CODE[0]);       //! NP商品コード
    mvData[EMEMBER::eNP_CAPA]->set_addr(&ptmp->u8NP_CAPA[0]);               //! NP容量

    mvData[EMEMBER::eHGTRANS_NAME]->set_addr(&ptmp->u8HGTRANS_NAME[0]);     //! 運送区分名
    mvData[EMEMBER::eASK_OUT_GRP]->set_addr(&ptmp->u8ASK_OUT_GRP[0]);       //! ASK出荷区分
    mvData[EMEMBER::eDELI_CO]->set_addr(&ptmp->u8DELI_CO[0]);               //! 配送業者 company
    mvData[EMEMBER::eINT_ITEM_CODE]->set_addr(&ptmp->u8INT_ITEM_CODE[0]);   //! 統合商品コード integration
    mvData[EMEMBER::eRESERVE]->set_addr(&ptmp->u8RESERVE1[0]);              //! 予備

    mvData[EMEMBER::eGLOSS_GRP]->set_addr(&ptmp->u8GLOSS_GRP[0]);           //! ツヤ区分
    mvData[EMEMBER::eCOL_FUNCGRP]->set_addr(&ptmp->u8COL_FUNCGRP[0]);       //! 調色機能区分
    mvData[EMEMBER::eRFDISP_GRP]->set_addr(&ptmp->u8RFDISP_GRP[0]);         //! RF表示区分 display?
    mvData[EMEMBER::eGLOSS_GRPNAME]->set_addr(&ptmp->u8GLOSS_GRPNAME[0]);   //! ツヤ区分名
    mvData[EMEMBER::eCOL_FUNCNAME]->set_addr(&ptmp->u8COL_FUNCNAME[0]);     //! 調色機能名称

    mvData[EMEMBER::eCOURCE_NAME]->set_addr(&ptmp->u8COURCE_NAME[0]);       //! コース名称
    mvData[EMEMBER::eRESERVE2]->set_addr(&ptmp->u8RESERVE2[0]);             //! 予備2
#endif
    return RET_SUCCESS;
}

int ord_buffer::valiables(void)
{
    int ii;
    for (ii = 0; ii < EMEMBER::eNUMB; ii++) {
        mvData.push_back(new ord_property(PROPERTY_INIT, PROPERTY_SIZE_UNKNOWN, PROPERTY_ATTR_X));
    }

    mpBuffer = (unsigned char*)0;
    msiDataSize = 0;
    mstrOKYERR.clear();

    // 初期値はUNKNOWNでなく、NLST。
    // ここで、NLSTにしておけば、初回のPORTコマンド終了時にNLSTが実行できる。
    // 実行が確定したら、UNKNOWNにして、バックグラウンドからのeCMDを待つ。
    // バックグラウンドの処理が遅延したなら、PORTのexit()で、1sec待つ。
    // 1sec待てば、バックグラウンド処理は終わっていると思う(暫定処置)
    // ただし、バックグラウンドで接続待ち等、20secも遅延した場合の処置には未対応
    meCMD = eCMD::eNLST;
    return RET_SUCCESS;
}

/*!
 * @file		oerder.cpp
 * @fn			void ord_buffer::setcmd(ord_buffer::eCMD eCommand)
 * @brief		NLST/RETR/STOR実行後コマンド設定
 * @details		NLST/RETR/STOR実行後コマンド設定
 * @return		void
 * @param[in]	eCommand        コマンド名
 * @date		2022/3/23
 * @note        排他要(必須)
 */
void ord_buffer::setcmd(ord_buffer::eCMD eCommand)
{
    meCMD = eCommand;
}

/*!
 * @file		oerder.cpp
 * @fn			void ord_buffer::setcmd(ord_buffer::eCMD eCommand)
 * @brief		ファイル名 ord_fmt～notifyファイル名設定
 * @details		ファイル名 ord_fmt～notifyファイル名設定
 * @return		void
 * @param[in]	siIndex         配列要素番号(enum class eFOLDER)
 * @param[in]	rStrFn          ファイル名
 * @date		2022/3/23
 * @note        排他要(必須)
 */
void ord_buffer::setfn(int siIndex, std::string& rStrFn)
{
    mstrTargetFN[siIndex] = rStrFn;
}

/*!
 * @file		oerder.cpp
 * @fn			void ord_buffer::getfn(ord_buffer::eCMD eCommand)
 * @brief		ファイル名 ord_fmt～notifyファイル名取得
 * @details		ファイル名 ord_fmt～notifyファイル名取得
 * @return		ファイル名文字列長
 * @param[in]	siIndex         配列要素番号(enum class eFOLDER)
 * @param[out]	rStrFn          ファイル名
 * @date		2022/3/23
 * @note        排他要(必須)
 */
size_t ord_buffer::getfn(int siIndex, std::string& rStrFn)
{
    rStrFn = mstrTargetFN[siIndex];
    return mstrTargetFN[siIndex].size();
}

/*!
 * @file		oerder.cpp
 * @fn			void ord_buffer::getOKYERRString(std::string &rString)
 * @brief		OKY/ERR文字列(ORD解析結果)取得
 * @details		OKY/ERR文字列(ORD解析結果)取得
 * @return		void
 * @param[out]	rString         OKY/ERR文字列
 * @date		2022/3/23
 * @note        排他不要(バックグラウンド限定のため)
 */
void ord_buffer::getOKYERRString(std::string &rString)
{
    rString = mstrOKYERR;
}

/*!
 * @file		    oerder.cpp
 * @fn			    void ord_buffer::good()
 * @brief		    OKY文字列判定
 * @details		    ERR文字が混入していれば、no good(NG)
 * @return		    bool
 * @param[in/out]	void
 * @date		    2022/4/26
 * @note            
 */
bool ord_buffer::good(void)
{
    bool    rc = true;
    std::string::size_type st;

    st = mstrOKYERR.find('0');                          // ERRあり
    if (st != std::string::npos) {
        rc = false;
    }
    return rc;
}

/*!
 * @file		oerder.cpp
 * @fn			int ord_buffer::inspector(std::string& rstrResult)
 * @brief		ORDファイル検査
 * @details		ORDファイル検査
 * @return		0 >  Return value: 失敗(TBD)
 * 				0 == Return value: 成功・NGあり
 * 				0 <  Return value: 成功・オールOK
 * @param[out]	rstrResult      結果データ(OKY/ERR)
 * @date		2022/3/24
 * @note        ***
 */
int ord_buffer::inspector(std::string& rstrResult)
{
    int rc = RET_GOOD;                                  // OKY
    int okyerr;
    std::vector<ord_property*>::iterator  iter;
    std::stringstream ss;

    for (iter = mvData.begin(); iter != mvData.end(); iter++) {
        okyerr = (*iter)->inspector();
        if (okyerr == RET_NOGOOD) {
            rc = RET_NOGOOD;
        }
        ss << okyerr;
    }
    ss >> rstrResult;

    mstrOKYERR.clear();
    mstrOKYERR = ss.str();
    return rc;
}

int ord_buffer::make_allerr(std::string& rstrResult)
{
    int rc = RET_GOOD;                                  // OKY
    int err_value = 0;
    std::stringstream ss;
    size_t  sz = mvData.size();
    int     ii;

    for (ii = 0; ii < sz; ii++) {
        ss << err_value;
    }
    ss >> rstrResult;

    mstrOKYERR.clear();
    mstrOKYERR = ss.str();
    return rc;
}

size_t ord_buffer::getall(std::vector<std::string>& evString)
{
    using namespace std;

    int rc = RET_SUCCESS;
    vector<ord_property*>::iterator iter;
    vector<string>                  vtmp;
    size_t  vsize;
    string  str_value;

    evString.clear();

    for (iter = mvData.begin(); iter != mvData.end(); iter++) {
        rc = (*iter)->get_string(str_value);
        if (rc <= 0) {
            str_value = "";
        }
        vtmp.push_back(str_value);
    }

    // vectorをコピー
    vsize = vtmp.size();
    evString.resize(vsize);
    copy(vtmp.begin(), vtmp.end(), evString.begin());

    return evString.size();
}

int ord_buffer::bufclear(void)
{
    ::memset(mpBuffer, 0x00, msiDataSize);
    return RET_SUCCESS;
}

/*!
 * @file		    oerder.cpp
 * @fn			    int ord_buffer::reader(const char* pFullpath, unsigned char* pRcvmsg, size_t siLength)
 * @brief		    ファイルリード(差異判定あり)
 * @details		    ファイルリード(差異判定あり)
 * @return		    0 >  Return value: エラーコード
 * 				    0 == Return value: 成功・差異なし
 * 				    0 <  Return value: 成功・差異あり
 * @param[in]	    pFullpath       ORDファイルフルパス
 * @param[in]	    pRcvmsg         ORDファイルメッセージ
 * @param[in]	    siLength        ORDファイルメッセージ長
 * @date		    1970/3/24
 * @note            ***
 */
int ord_buffer::reader(const char* pFullpath, unsigned char* pRcvmsg, size_t siLength)
{
    using namespace std;

    int         rc = RET_SUCCESS;
    streampos   pos_cur;
    int         fsize;
    int         ii;
    int         diff;
    string      str_buff;                               // リードバッファ
    // new, delete
    ecode*      pec = (ecode*)0;

    ifstream ifs(pFullpath, ios::in | ios::binary);
    if (!ifs.good()) {
        pec = new ecode(ecode::eVALUE::eIFSTREAM, __FUNCTION__, "Failed ifs()");
        pec->output();
        rc = pec->rc();						            // 戻り値に変換
        goto EXIT_FUNCTION;
    }

    // ファイルサイズ取得
    pos_cur = ifs.tellg();                              // 現在位置
    ifs.seekg(0, ios::end);                             // 終端移動
    fsize = ifs.tellg();                                // 終端位置取得
    ifs.seekg(pos_cur);                                 // もとに戻す

    if (fsize != siLength) {
        return 1;                                       // 差異あり
    }

    // ファイルリード
    if (mpBuffer == (unsigned char*)0) {            // メモリ未確保
        pec = new ecode(ecode::eVALUE::eMEM_NOALLOC, __FUNCTION__, "mpBuffer == 0");
        pec->output();
        rc = pec->rc();						            // 戻り値に変換
        goto EXIT_FUNCTION;
    }

    str_buff.resize(fsize);                             // 読み取りバッファ確保
    copy(istreambuf_iterator<char>(ifs), istreambuf_iterator<char>(), str_buff.begin());

    // char[] <= string
    ::memcpy(mpBuffer, str_buff.c_str(), fsize);

    diff = 0;                                           // 差異なし
    for (ii = 0; ii < siLength; ii++) {
        if (*(mpBuffer + ii) != *(pRcvmsg + ii)) {
            diff = 1;                                   // 差異あり
            memcpy(mpBuffer, pRcvmsg, siLength);
            break;
        }
    }
    rc = diff;

EXIT_FUNCTION:
    if (pec) { delete pec; }
    return rc;
}

/*!
 * @file		oerder.cpp
 * @fn			int ord_buffer::memupdate(char* pRcvmsg, int siLength)
 * @brief		ORDファイルメモリ比較(バイナリ比較)
 * @details		ORDファイルメモリ比較
 * @return		0 >  Return value: 失敗
 * 				0 == Return value: updateなし
 * 				0 <  Return value: updateあり
 * @param[in]	pRcvmsg         受信データ
 * @param[in]	siLength        受信データサイズ
 * @date		2022/3/23
 * @note        ***
 */
int ord_buffer::memupdate(unsigned char* pRcvmsg, size_t siLength)
{
    int rc  = 0;
    int upd = 0;                                        // updateなし
    int ii;
    // new, delete
	ecode*	pec = (ecode*)0;

    if (pRcvmsg == (unsigned char*)0) {
		pec = new ecode(ecode::eVALUE::eARG_NULL, __FUNCTION__, "pRcvmsg == 0");
		pec->output();
		rc = pec->rc();						            // 戻り値に変換
		goto EXIT_FUNCTION;
    }

    if (msiDataSize < siLength) {
        pec = new ecode(ecode::eVALUE::eBUFSIZE_NOENOUGH, __FUNCTION__, "msiDataSize < siLength");
        pec->output();
        rc = pec->rc();						            // 戻り値に変換
        goto EXIT_FUNCTION;
    }

    rc = 0;                                             // updateなし
    for (ii = 0; ii < siLength; ii++) {
        if (*(mpBuffer + ii) != *(pRcvmsg + ii)) {
            upd = 1;                                    // updateあり
            memcpy(mpBuffer, pRcvmsg, siLength);
            break;
        }
    }
    rc = upd;

EXIT_FUNCTION:
    if (pec) {delete pec;}

    return rc;
}

////////////////////////////////////////////////////////////////////////////////
ord_property::ord_property()
{
    msiCheck = -1;
    msiSize  = 0;                        
    msiAttr  = 0;
    mpBinary = (unsigned char*)0;                        
}

ord_property::ord_property(int siCheck, int siSize, int siAttr, unsigned char* pBinary)
{
    setter(siCheck, siSize, siAttr, pBinary);
}

ord_property::~ord_property()
{
}

void ord_property::setter(int siCheck, int siSize, int siAttr, unsigned char* pBinary)
{
    msiCheck = siCheck;
    msiSize  = siSize;
    msiAttr  = siAttr;
    mpBinary = pBinary;
}

void ord_property::setter(int siSize, int siAttr)
{
    msiSize  = siSize;
    msiAttr  = siAttr;
}

void ord_property::set_addr(unsigned char* pBinary)
{
    mpBinary = pBinary;

    // ここで固まることがある  std::cout << std::hex << (long long)mpBinary << "\n";
}

int ord_property::get_size(void)
{
    return msiSize;
}

int ord_property::get_string(std::string& strValue)
{
    int rc = RET_FAILED;

    if (mpBinary) {
        std::string str_work((char*)mpBinary, msiSize);
        strValue = str_work;
        rc = (int)str_work.size();
    }
    return rc;
}

/*!
 * @file		order.cpp
 * @fn			int ord_property::inspector(char* pBuffer)
 * @brief		文字列適正検査
 * @details		文字列検査
 * @return		0 >  Return value: エラーコード
 * 				0 == Return value: 属性NG
 * 				0 <  Return value: 属性OK
 * @param[in]   pBuffer         文字列バッファ
 * @date		1970/3/18
 * @note        ***
 */
int ord_property::inspector(unsigned char* pBuffer)
{
    int rc = RET_NOGOOD;

    // パラメータ毎の実際のサイズチェックは不可
    // mpBinaryが示すテキストデータの終端は962byteメッセージの終端まで、つながっている。
 
    //std::string str_wk = (char*)mpBinary;
    //size_t      szmax  = ORD_EXPECTED_SIZE;
    //size_t      szlen  = ::strnlen(str_wk.c_str(), szmax);;
    //if (szlen != msiSize) {                             // 固定長なので、
    //    return RET_NOGOOD;                              // msiSize(期待値)と差異があるのは異常
    //}

    switch(msiAttr) {
    case PROPERTY_ATTR_X:                               // 半角
        rc = ankstr::good(mpBinary, msiSize, msiSize);
        break;
    case PROPERTY_ATTR_9:                               // 数値文字列
        rc = digitstr::good(mpBinary, msiSize, msiSize);
        break;
    case PROPERTY_ATTR_N:                               // 全角文字列
        rc = mbstr::good(mpBinary, msiSize, msiSize);
        break;
    default:
        break;
    }

    if (rc < 0) {                                       // エラー発生
        rc = RET_NOGOOD;                                // 属性NGとする。
    }
    return rc;
}

