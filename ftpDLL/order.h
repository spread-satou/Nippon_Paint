#pragma once
#include <sstream>
#include <string>
#include <vector>

#include "ecode.h"

#define EMEMBER                 (int)ord_fmt::eMEMBERS
#define EFOLDER                 (int)ord_buffer::eFOLDER
#define ECMD                    (int)ord_buffer::eCMD

#define ORD_EXPECTED_SIZE               962
#define PROPERTY_INIT                   -1

#define PROPERTY_ATTR_X                 0   // 半角
#define PROPERTY_ATTR_9                 1   // 数値
#define PROPERTY_ATTR_N                 2   // 全角

#define PROPERTY_SIZE_UNKNOWN           0

#define PROPERTY_SIZE_HG                3   //! HG区分
#define PROPERTY_SIZE_PROC_NO           9   //! 処理NO   proceed
#define PROPERTY_SIZE_LINE_NO           2   //! 行NO
#define PROPERTY_SIZE_DEVI_ANS          2   //! 分割回答 devision
#define PROPERTY_SIZE_DEVI_DELI         2   //! 分割出荷 delivery

#define PROPERTY_SIZE_SS                3   //! SSコード
#define PROPERTY_SIZE_DELI_DATE         8   //! 納期 delivery
#define PROPERTY_SIZE_PROD_CODE         8   //! 商品コード product
#define PROPERTY_SIZE_PROD_NAME         96  //! 商品名 product
#define PROPERTY_SIZE_CAPA              8   //! 容量 capacity

#define PROPERTY_SIZE_QUAN              7   //! 数量 quantity
#define PROPERTY_SIZE_SAMPLE            60  //! 標準見本
#define PROPERTY_SIZE_RET_METHOD        40  //! 返却方法
#define PROPERTY_SIZE_COL_MANAGE        16  //! 調色精度
#define PROPERTY_SIZE_OTHER_NOTE        80  //! その他特記事項

#define PROPERTY_SIZE_KG                11  //! Kg換算値
#define PROPERTY_SIZE_WATER             1   //! 水性区分
#define PROPERTY_SIZE_RECEIPT           2   //! 伝票区分
#define PROPERTY_SIZE_CANCEL            1   //! 取消区分
#define PROPERTY_SIZE_SUMMARY           40  //! 概要

#define PROPERTY_SIZE_GROUP             7   //! 分類
#define PROPERTY_SIZE_CLI_CODE          7   //! 得意先コード clinet
#define PROPERTY_SIZE_CLI_NAME          20  //! 得意先名
#define PROPERTY_SIZE_CLI_KANJI         40  //! 得意先漢字
#define PROPERTY_SIZE_OFFICE_NAME       30  //! 営業所名

#define PROPERTY_SIZE_CHAKUCHI          15  //! 着地コード
#define PROPERTY_SIZE_POI_AREA           1  //! ポイントエリア区分
#define PROPERTY_SIZE_DELI_TEL          15  //! 納入先TEL delivery
#define PROPERTY_SIZE_DELI_KANJI        60  //! 納入先名漢字
#define PROPERTY_SIZE_DELI_ADDR         70  //! 納入先住所

#define PROPERTY_SIZE_ACT_DATE          8   //! 投入日 activation
#define PROPERTY_SIZE_ACT_TIME          6   //! 投入時間 activation
#define PROPERTY_SIZE_ORD_RANK          2   //! 発注時ランク
#define PROPERTY_SIZE_HGTRANS_GRP       1   //! 運送区分
#define PROPERTY_SIZE_HGTRANS_LABEL     20  //! 運送区分名(ラベル), 20bytes

#define PROPERTY_SIZE_SSTRANS_GRP       1   //! 運送区分
#define PROPERTY_SIZE_SSTRANS_LABEL     8   //! 運送区分名
#define PROPERTY_SIZE_RANKING_CODE      6   //! 順位コード
#define PROPERTY_SIZE_RF_AGGRE_KIND     2   //! RF集計用品種 aggregation
#define PROPERTY_SIZE_PLATE_ATTQUAN     2   //! 塗板添付枚数 plate attachment quantity

#define PROPERTY_SIZE_SSDELI_SCHE       8   //! SS出荷予定日　delivery scheduled date
#define PROPERTY_SIZE_PERSON_NAME       10  //! 担当者名漢字
#define PROPERTY_SIZE_DELI_SCHE         8   //! 出荷予定日　delivery scheduled date
#define PROPERTY_SIZE_NPITEM_CODE       8   //! NP商品コード
#define PROPERTY_SIZE_NP_CAPA           8   //! NP容量

#define PROPERTY_SIZE_HGTRANS_NAME      16  //! 運送区分名, 16bytes
#define PROPERTY_SIZE_ASK_OUT_GRP       1   //! ASK出荷区分
#define PROPERTY_SIZE_DELI_CO           50  //! 配送業者 company
#define PROPERTY_SIZE_INT_ITEM_CODE     7   //! 統合商品コード integration
#define PROPERTY_SIZE_RESERVE1          1   //! 予備

#define PROPERTY_SIZE_GLOSS_GRP         2   //! ツヤ区分
#define PROPERTY_SIZE_COL_FUNCGRP       2   //! 調色機能区分
#define PROPERTY_SIZE_RFDISP_GRP        1   //! RF表示区分 display?
#define PROPERTY_SIZE_GLOSS_GRPNAME     10  //! ツヤ区分名
#define PROPERTY_SIZE_COL_FUNCNAME      20  //! 調色機能名称

#define PROPERTY_SIZE_COURCE_NAME       10  //! コース名称
#define PROPERTY_SIZE_RESERVE2          80  //! 予備2

struct ord_property {                                   //! 属性構造体
    int     msiCheck;                                   //! -1:未チェック(初期値), 0:ERR, 1:OKY

    int     msiAttr;                                    //! 属性(0:半角英数字, 1:数値文字列, 2:全角)
    int     msiSize;                                    //! サイズ
    unsigned char* mpBinary;                            //! バイナリデータとして扱う

    ord_property();
    ord_property(int siCheck, int siSize, int siAttr, unsigned char* pBinary = 0);
    ~ord_property();

    void setter(int siCheck, int siSize, int siAttr, unsigned char* pBinary = 0);
    void setter(int siSize, int siAttr);
    void set_addr(unsigned char* pBinary);
    int  get_size(void);
    int  get_string(std::string& strValue);
    int  inspector(unsigned char* pBuffer = 0);
};

struct ord_fmt {
public:
    static int cmpsize(const char* pData, int siSize)
    {
        // もし、pDataをsiSizeサイズのバッファにコピーしようとした場合、
        //　pDataサイズ大だと、コピー先がオーバーランする
        int rc = 0;
        int sz = (int)::strlen(pData);
        if (sz > siSize) { rc = -1; }                   // pDataサイズ大
        else if (sz < siSize) {rc=1;}                   // pDataサイズ小
        else {rc = 0;}                                  // 同サイズ
        return rc;
    }

    static int sscpy(std::stringstream& rSS, size_t& rSize, const char* pData, int siSize)
    {
        // もし、pDataをsiSizeサイズのバッファにコピーしようとした場合、
        //　pDataサイズ大だと、コピー先がオーバーランする
        int rc = 0;
        size_t sz = ::strlen(pData);

        if (sz > siSize) {rc = RET_FAILED;}
        else if (sz < siSize) { rc = 1; }               // pDataサイズ小
        else { rc = RET_SUCCESS; }                      // 同サイズ

        rSize = sz;
        rSS << pData;
        return rc;
    }

public:
    enum class eMEMBERS {                               //! 項目名構造体
        eHG,                    //! HG区分
        ePROC_NO,               //! 処理NO   proceed
        eLINE_NO,               //! 行NO
        eDEVI_ANS,              //! 分割回答 devision
        eDEVI_DELI,             //! 分割出荷 delivery

        eSS,                    //! SSコード
        eDELI_DATE,             //! 納期 delivery
        ePROD_CODE,             //! 商品コード product
        ePROD_NAME,             //! 商品名 product
        eCAPA,                  //! 容量 capacity

        eQUAN,                  //! 数量 quantity
        eSAMPLE,                //! 標準見本
        eRET_METHOD,            //! 返却方法
        eCOL_MANAGE,            //! 調色精度
        eOTHER_NOTE,            //! その他特記事項

        eKG,                    //! Kg換算値
        eWATER,                 //! 水性区分
        eRECEIPT,               //! 伝票区分
        eCANCEL,                //! 取消区分
        eSUMMARY,               //! 概要

        eGROUP,                 //! 分類
        eCLI_CODE,              //! 得意先コード clinet
        eCLI_NAME,              //! 得意先名
        eCLI_KANJI,             //! 得意先漢字
        eOFFICE_NAME,           //! 営業所名

        eCHAKUCHI,              //! 着地コード
        ePOI_AREA,              //! ポイントエリア区分
        eDELI_TEL,              //! 納入先TEL delivery
        eDELI_KANJI,            //! 納入先名漢字
        eDELI_ADDR,             //! 納入先住所

        eACT_DATE,              //! 投入日 activation
        eACT_TIME,              //! 投入時間 activation
        eORD_RANK,              //! 発注時ランク
        eHGTRANS_GRP,           //! 運送区分
        eHGTRANS_LABEL,         //! 運送区分名(ラベル), 20bytes

        eSSTRANS_GRP,           //! 運送区分
        eSSTRANS_LABEL,         //! 運送区分名
        eRANKING_CODE,          //! 順位コード
        eRF_AGGRE_KIND,         //! RF集計用品種 aggregation
        ePLATE_ATTQUAN,         //! 塗板添付枚数 plate attachment quantity

        eSSDELI_SCHE,           //! SS出荷予定日　delivery scheduled date
        ePERSON_NAME,           //! 担当者名漢字
        eDELI_SCHE,             //! 出荷予定日　delivery scheduled date
        eNPITEM_CODE,           //! NP商品コード
        eNP_CAPA,               //! NP容量

        eHGTRANS_NAME,          //! 運送区分名, 16bytes
        eASK_OUT_GRP,           //! ASK出荷区分
        eDELI_CO,               //! 配送業者 company
        eINT_ITEM_CODE,         //! 統合商品コード integration
        eRESERVE,               //! 予備

        eGLOSS_GRP,             //! ツヤ区分
        eCOL_FUNCGRP,           //! 調色機能区分
        eRFDISP_GRP,            //! RF表示区分 display?
        eGLOSS_GRPNAME,         //! ツヤ区分名
        eCOL_FUNCNAME,          //! 調色機能名称

        eCOURCE_NAME,           //! コース名称
        eRESERVE2,              //! 予備2

        eNUMB
    };

    struct mydata {                                     //! 実データ構造体
        unsigned char u8HG[PROPERTY_SIZE_HG];                        //! HG区分
        unsigned char u8PROC_NO[PROPERTY_SIZE_PROC_NO];              //! 処理NO   proceed
        unsigned char u8LINE_NO[PROPERTY_SIZE_LINE_NO];              //! 行NO
        unsigned char u8DEVI_ANS[PROPERTY_SIZE_DEVI_ANS];            //! 分割回答 devision
        unsigned char u8DEVI_DELI[PROPERTY_SIZE_DEVI_DELI];          //! 分割出荷 delivery
        unsigned char u8SS[PROPERTY_SIZE_SS];                        //! SSコード
        unsigned char u8DELI_DATE[PROPERTY_SIZE_DELI_DATE];          //! 納期 delivery
        unsigned char u8PROD_CODE[PROPERTY_SIZE_PROD_CODE];          //! 商品コード product
        unsigned char u8PROD_NAME[PROPERTY_SIZE_PROD_NAME];          //! 商品名 product
        unsigned char u8CAPA[PROPERTY_SIZE_CAPA];                    //! 容量 capacity
        unsigned char u8QUAN[PROPERTY_SIZE_QUAN];                    //! 数量 quantity
        unsigned char u8SAMPLE[PROPERTY_SIZE_SAMPLE];                //! 標準見本
        unsigned char u8RET_METHOD[PROPERTY_SIZE_RET_METHOD];        //! 返却方法
        unsigned char u8COL_MANAGE[PROPERTY_SIZE_COL_MANAGE];        //! 調色精度
        unsigned char u8OTHER_NOTE[PROPERTY_SIZE_OTHER_NOTE];        //! その他特記事項
        unsigned char u8KG[PROPERTY_SIZE_KG];                        //! Kg換算値
        unsigned char u8WATER[PROPERTY_SIZE_WATER];                  //! 水性区分
        unsigned char u8RECEIPT[PROPERTY_SIZE_RECEIPT];              //! 伝票区分
        unsigned char u8CANCEL[PROPERTY_SIZE_CANCEL];                //! 取消区分
        unsigned char u8SUMMARY[PROPERTY_SIZE_SUMMARY];              //! 概要
        unsigned char u8GROUP[PROPERTY_SIZE_GROUP];                  //! 分類
        unsigned char u8CLI_CODE[PROPERTY_SIZE_CLI_CODE];            //! 得意先コード clinet
        unsigned char u8CLI_NAME[PROPERTY_SIZE_CLI_NAME];            //! 得意先名
        unsigned char u8CLI_KANJI[PROPERTY_SIZE_CLI_KANJI];          //! 得意先漢字
        unsigned char u8OFFICE_NAME[PROPERTY_SIZE_OFFICE_NAME];      //! 営業所名
        unsigned char u8CHAKUCHI[PROPERTY_SIZE_CHAKUCHI];            //! 着地コード
        unsigned char u8POI_AREA[PROPERTY_SIZE_POI_AREA];            //! ポイントエリア区分
        unsigned char u8DELI_TEL[PROPERTY_SIZE_DELI_TEL];            //! 納入先TEL delivery
        unsigned char u8DELI_KANJI[PROPERTY_SIZE_DELI_KANJI];        //! 納入先名漢字
        unsigned char u8DELI_ADDR[PROPERTY_SIZE_DELI_ADDR];          //! 納入先住所
        unsigned char u8ACT_DATE[PROPERTY_SIZE_ACT_DATE];            //! 投入日 activation
        unsigned char u8ACT_TIME[PROPERTY_SIZE_ACT_TIME];            //! 投入時間 activation
        unsigned char u8ORD_RANK[PROPERTY_SIZE_ORD_RANK];            //! 発注時ランク
        unsigned char u8HGTRANS_GRP[PROPERTY_SIZE_HGTRANS_GRP];      //! 運送区分
        unsigned char u8HGTRANS_LABEL[PROPERTY_SIZE_HGTRANS_LABEL];  //! 運送区分名(ラベル), 20bytes
        unsigned char u8SSTRANS_GRP[PROPERTY_SIZE_SSTRANS_GRP];      //! 運送区分
        unsigned char u8SSTRANS_LABEL[PROPERTY_SIZE_SSTRANS_LABEL];  //! 運送区分名
        unsigned char u8RANKING_CODE[PROPERTY_SIZE_RANKING_CODE];    //! 順位コード
        unsigned char u8RF_AGGRE_KIND[PROPERTY_SIZE_RF_AGGRE_KIND];  //! RF集計用品種 aggregation
        unsigned char u8PLATE_ATTQUAN[PROPERTY_SIZE_PLATE_ATTQUAN];  //! 塗板添付枚数 plate attachment quantity
        unsigned char u8SSDELI_SCHE[PROPERTY_SIZE_SSDELI_SCHE];      //! SS出荷予定日　delivery scheduled date
        unsigned char u8PERSON_NAME[PROPERTY_SIZE_PERSON_NAME];      //! 担当者名漢字
        unsigned char u8DELI_SCHE[PROPERTY_SIZE_DELI_SCHE];          //! 出荷予定日　delivery scheduled date
        unsigned char u8NPITEM_CODE[PROPERTY_SIZE_NPITEM_CODE];      //! NP商品コード
        unsigned char u8NP_CAPA[PROPERTY_SIZE_NP_CAPA];              //! NP容量
        unsigned char u8HGTRANS_NAME[PROPERTY_SIZE_HGTRANS_NAME];    //! 運送区分名, 16bytes
        unsigned char u8ASK_OUT_GRP[PROPERTY_SIZE_ASK_OUT_GRP];      //! ASK出荷区分
        unsigned char u8DELI_CO[PROPERTY_SIZE_DELI_CO];              //! 配送業者 company
        unsigned char u8INT_ITEM_CODE[PROPERTY_SIZE_INT_ITEM_CODE];  //! 統合商品コード integration
        unsigned char u8RESERVE1[PROPERTY_SIZE_RESERVE1];            //! 予備
        unsigned char u8GLOSS_GRP[PROPERTY_SIZE_GLOSS_GRP];          //! ツヤ区分
        unsigned char u8COL_FUNCGRP[PROPERTY_SIZE_COL_FUNCGRP];      //! 調色機能区分
        unsigned char u8RFDISP_GRP[PROPERTY_SIZE_RFDISP_GRP];        //! RF表示区分 display?
        unsigned char u8GLOSS_GRPNAME[PROPERTY_SIZE_GLOSS_GRPNAME];  //! ツヤ区分名
        unsigned char u8COL_FUNCNAME[PROPERTY_SIZE_COL_FUNCNAME];    //! 調色機能名称
        unsigned char u8COURCE_NAME[PROPERTY_SIZE_COURCE_NAME];      //! コース名称
        unsigned char u8RESERVE2[PROPERTY_SIZE_RESERVE2];            //! 予備2
    };
};

class ord_buffer
{
public:

    enum class eFOLDER {
        eORD,                   //! SND/ORDER
        eANS,                   //! SND/ANSWER
        eNTY,                   //! RCV/NOTIFY
        eNUMB
    };

    // 日本ペイントの場合、1接続 1シーケンス
    // アップロードが正常終了しても、シーケンスを中断する(eABORT)
    enum class eCMD {
        eABORT  = -2,           //! 中断(日本ペイント仕様)
        eFAILED = -1,
        eUNKNOWN= 0,            //! 未確定
        eNLST,                  //! NLST
        eDOWNLOAD,              //! RETR
        eUPLANS,                //! STOR    まずは、SND/ANSWER
        eUPLNTY,                //! STOR    続いて、RCV/NOTIFY
        eNUMB
    };

protected:
    // 以下、同期(排他)必須
    //  (ほぼ、シーケンシャルに動作するので、排他しなくても、安全と思われる)
    //  フォアグラウンドで取得
    //  バックグラウンドでセット
    /*  eCMD
        0: nlst
        1: download
        2: upload
    */
    eCMD            meCMD;                              //! NLST/RETR/STOR実行後コマンド

    // NLST/RETR実行結果
    std::string     mstrTargetFN[EFOLDER::eNUMB];       //! ファイル名 ord_fmt～notifyファイル

protected:
    // 以下、バッグラウンド限定
    // RETR作業データ
    unsigned char*  mpBuffer;                           //! 最新ダウンロードデータ
    size_t          msiDataSize;                        //! 最新ダウンロードデータバッファサイズ

    // ORDファイル(mpBuffer)の各パラメータを検査する
    // mpBufferをdeleteしたなら、initialize()をcallしすること。
    // ord_property::inspector()実行時、mpBufferへの不正アクセスが発生するため。
    std::vector<ord_property*>    mvData;               //! チェックデータ

    // RETR実行結果(STOR送信データ)
    std::string     mstrOKYERR;                         //! OKY/ERR文字列(ORD解析結果)
public:
    ord_buffer();
    virtual ~ord_buffer();

    // 初期化
    int     initialize(void);

    // ORDファイル名
    void    setfn(int siIndex, std::string& rStrFn);    //! ファイル名設定
    size_t  getfn(int siIndex, std::string& rStrFn);    //! ファイル名取得

    // 動作
    int     bufclear(void);
    int     reader(const char* pFullpath, unsigned char* pRcvmsg, size_t siLength);
    int     memupdate(unsigned char* pRcvmsg, size_t siLength);     //! 最新データチェック
    int     inspector(std::string& rstrResult);                     //! 項目適性検査
    int     make_allerr(std::string& rstrResult);                   //! 全項目エラー

    // パラメータ
    size_t          getall(std::vector<std::string>& evString);     //! 全パラメータ取得
    void            getOKYERRString(std::string &rString);          //! 検査結果文字列
    bool            good(void);                                     //! OKY/ERR有無確認

    unsigned char*  get_pointer(void) {return mpBuffer;};       //! ORDファイルポインタ
    size_t          get_datasize() { return msiDataSize; }          //! ORDファイルバッファサイズ

    // 同期(排他)が必要なメソッド(マルチスレッド用)
    //  フォアグラウンドでは、getcmd()でNLST/RETR/STORのいずれかを決定する。
    //  NLST/RETR/STORコマンド送信直前にgetfn()をcallすれば、排他は不要なはず。
    //  (バックグラウンドでは、setfn()後にsetcmd()している)
    void    setcmd(ord_buffer::eCMD eCommand);
    int     getcmd(void) {return (int)meCMD;}

protected:
    int     valiables(void);
};

