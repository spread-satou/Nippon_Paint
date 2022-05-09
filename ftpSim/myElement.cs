using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/classes-and-structs/how-to-define-constants
// https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/classes-and-structs/constants
static class elementSize
{
    // sample
    // public const double Pi = 3.14159;
    // public const int SpeedOfLight = 300000; // km per sec.

    // N:全角、9：数値、X：半角
    public const int UNKNOWN = 0;

    public const int HG = 3;                            //! HG区分
    public const int PROC_NO = 9;                       //! 処理NO   proceed
    public const int LINE_NO = 2;                       //! 行NO
    public const int DEVI_ANS = 2;                      //! 分割回答 devision
    public const int DEVI_DELI = 2;                     //! 分割出荷 delivery

    public const int SS = 3;                            //! SSコード
    public const int DELI_DATE = 8;                     //! 納期 delivery
    public const int PROD_CODE = 8;                     //! 商品コード product
    public const int PROD_NAME = 96;                    //! 商品名 product
    public const int CAPA = 8;                          //! 容量 capacity

    public const int QUAN = 7;                          //! 数量 quantity
    public const int SAMPLE = 60;                       //! 標準見本
    public const int RET_METHOD = 40;                   //! 返却方法
    public const int COL_MANAGE = 16;                   //! 調色精度
    public const int OTHER_NOTE = 80;                   //! その他特記事項

    public const int KG = 11;                           //! Kg換算値
    public const int WATER = 1;                         //! 水性区分
    public const int RECEIPT = 2;                       //! 伝票区分
    public const int CANCEL = 1;                        //! 取消区分
    public const int SUMMARY = 40;                      //! 概要

    public const int GROUP = 7;                         //! 分類
    public const int CLI_CODE = 7;                      //! 得意先コード clinet
    public const int CLI_NAME = 20;                     //! 得意先名
    public const int CLI_KANJI = 40;                    //! 得意先漢字
    public const int OFFICE_NAME = 30;                  //! 営業所名

    public const int CHAKUCHI = 15;                     //! 着地コード
    public const int POI_AREA = 1;                      //! ポイントエリア区分
    public const int DELI_TEL = 15;                     //! 納入先TEL delivery
    public const int DELI_KANJI = 60;                   //! 納入先名漢字
    public const int DELI_ADDR = 70;                    //! 納入先住所

    public const int ACT_DATE = 8;                      //! 投入日 activation
    public const int ACT_TIME = 6;                      //! 投入時間 activation
    public const int ORD_RANK = 2;                      //! 発注時ランク
    public const int HGTRANS_GRP = 1;                   //! 運送区分
    public const int HGTRANS_LABEL = 20;                //! 運送区分名(ラベル), 20bytes

    public const int SSTRANS_GRP = 1;                   //! 運送区分
    public const int SSTRANS_LABEL = 8;                 //! 運送区分名
    public const int RANKING_CODE = 6;                  //! 順位コード
    public const int RF_AGGRE_KIND = 2;                 //! RF集計用品種 aggregation
    public const int PLATE_ATTQUAN = 2;                 //! 塗板添付枚数 plate attachment quantity

    public const int SSDELI_SCHE = 8;                   //! SS出荷予定日　delivery scheduled date
    public const int PERSON_NAME = 10;                  //! 担当者名漢字
    public const int DELI_SCHE = 8;                     //! 出荷予定日　delivery scheduled date
    public const int NPITEM_CODE = 8;                   //! NP商品コード
    public const int NP_CAPA = 8;                       //! NP容量

    public const int HGTRANS_NAME = 16;                 //! 運送区分名, 16bytes
    public const int ASK_OUT_GRP = 1;                   //! ASK出荷区分
    public const int DELI_CO = 50;                      //! 配送業者 company
    public const int INT_ITEM_CODE = 7;                 //! 統合商品コード integration
    public const int RESERVE1 = 1;                      //! 予備

    public const int GLOSS_GRP = 2;                     //! ツヤ区分
    public const int COL_FUNCGRP = 2;                   //! 調色機能区分
    public const int RFDISP_GRP = 1;                    //! RF表示区分 display?
    public const int GLOSS_GRPNAME = 10;                //! ツヤ区分名
    public const int COL_FUNCNAME = 20;                 //! 調色機能名称

    public const int COURCE_NAME = 10;                  //! コース名称
    public const int RESERVE2 = 80;                     //! 予備2
}

// 属性(0:半角英数字, 1:数値文字列, 2:全角)
static class elementType
{
    // sample
    public const int SINGLE = 0;                        //! X:半角 single byte
    public const int NUMERIC = 1;                       //! 9:数値 numeric
    public const int MULTI = 2;                         //! N:全角 multi byte
}

namespace ftpSim
{
    internal class myElement
    {
        // private field
        // https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/classes-and-structs/fields
        protected string    _dtName;                    //! パラメータ名(DEBUG用)
        protected int       _dtSize;                    //! データ長
        protected int       _dtType;                    //! 属性(0:半角英数字, 1:数値文字列, 2:全角)
        protected string?   _strValue;                  //! 値

        // https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/classes-and-structs/constructors
        public myElement(string strName, int dtSize, int dtType)
        {
            _dtName = strName;
            _dtSize = dtSize;
            _dtType = dtType;
        }

        // https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/classes-and-structs/methods    
        public void setValue(string strValue)
        {
            _strValue = strValue;
        }

        public int getSize() {return _dtSize;}
    
    }
}
