using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/builtin-types/built-in-types
namespace ftpSim
{
    internal class order
    {
        // 変数名は仕様書と一致
        // アルファベット大文字は略語

        // private field
        // https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/classes-and-structs/fields

        public string? _Area_Code;                      //! HG区分
        public string? _Slip_NUM;                       //! 処理NO   proceed
        public string? _Detail_NUM;                     //! 行NO
        public string? _Replay_INST_NUM;                //! 分割回答 devision
        public string? _Actual_INST_NUM;                //! 分割出荷 delivery

        public string? _SS_Code;                        //! SSコード
        public string? _Due_Date;                       //! 納期 delivery
        public string? _Item_Code;                      //! 商品コード product
        public string? _Item_Name;                      //! 商品名 product
        public string? _Package_Code;                   //! 容量 capacity

        public string? _Quantity;                       //! 数量 quantity
        public string? _Proofing_STD_Sample;            //! 標準見本
        public string? _Sample_RET_Method;              //! 返却方法
        public string? _REQ_LOT_NUM;                    //! 調色精度
        public string? _Summary_for_NUM;                //! その他特記事項

        public string? _Weight;                         //! Kg換算値
        public string? _Water_Solvent_Type;             //! 水性区分
        public string? _Slip_Type;                      //! 伝票区分
        public string? _CANCEL_Type;                    //! 取消区分
        public string? _Summary;                        //! 概要

        public string? _Proofing_Type_Code;             //! 分類
        public string? _Dealer_Code;                    //! 得意先コード clinet
        public string? _Dealer_Name_KANA;               //! 得意先名
        public string? _Dealer_Name;                    //! 得意先漢字
        public string? _Block_Name;                     //! 営業所名

        public string? _DEST_Code;                      //! 着地コード
        public string? _Point_Area_Type;                //! ポイントエリア区分
        public string? _DEST_TEL;                       //! 納入先TEL delivery
        public string? _DEST_Name_KANJI;                //! 納入先名漢字
        public string? _DEST_ADDR_KANJI;                //! 納入先住所

        public string? _Input_Date;                     //! 投入日 activation
        public string? _Input_time;                     //! 投入時間 activation
        public string? _Rank_Code;                      //! 発注時ランク
        public string? _HG_Carrier_Type;                //! 運送区分
        public string? _HG_Carrier_Type_Name_Label;     //! 運送区分名(ラベル), 20bytes

        public string? _SS_Auto_Line_out;               //! 運送区分
        public string? _SS_Delivery_Type_Name;          //! 運送区分名
        public string? _Item_ORD_Code;                  //! 順位コード
        public string? _RF_Total_Variety;               //! RF集計用品種 aggregation
        public string? _Sample_Plate_Quantity;          //! 塗板添付枚数 plate attachment quantity

        public string? _SS_site_out_Plan_Date;          //! SS出荷予定日　delivery scheduled date
        public string? _Person_In_Charge_Name;          //! 担当者名漢字
        public string? _Site_Out_Plan_Date;             //! 出荷予定日　delivery scheduled date
        public string? _NP_Variety_Code;                //! NP商品コード
        public string? _NP_Pacage_Code;                 //! NP容量

        public string? _HG_Carrier_Type_Name;           //! 運送区分名, 16bytes
        public string? _ASK_OUT_Type;                   //! ASK出荷区分
        public string? _Carrier_Name;                   //! 配送業者 company
        public string? _Common_Item_Code;               //! 統合商品コード integration
        public string? _Reserve;                        //! 予備

        public string? _Gloss_Type_Code;                //! ツヤ区分
        public string? _ADD_Proof_Type_Code;            //! 調色機能区分
        public string? _RF_Display_Color_Type;          //! RF表示区分 display?
        public string? _Gloss_Type_Name;                //! ツヤ区分名
        public string? _ADD_Proof_Type_Name;            //! 調色機能名称

        public string? _Cource_Name;                    //! コース名称
        public string? _Reserve2;                       //! 予備2


        order()
        {
            this.initialize();
        }

        ~order()
        {

        }

        int initialize()
        {
            int rc = this.variables();
            return 0;
        }

        int variables()
        {
            _Area_Code = null;                      //! HG区分
            _Slip_NUM = null;                       //! 処理NO   proceed
            _Detail_NUM = null;                     //! 行NO
            _Replay_INST_NUM = null;                //! 分割回答 devision
            _Actual_INST_NUM = null;                //! 分割出荷 delivery
            _SS_Code = null;                        //! SSコード
            _Due_Date = null;                       //! 納期 delivery
            _Item_Code = null;                      //! 商品コード product
            _Item_Name = null;                      //! 商品名 product
            _Package_Code = null;                   //! 容量 capacity
            _Quantity = null;                       //! 数量 quantity
            _Proofing_STD_Sample = null;            //! 標準見本
            _Sample_RET_Method = null;              //! 返却方法
            _REQ_LOT_NUM = null;                    //! 調色精度
            _Summary_for_NUM = null;                //! その他特記事項
            _Weight = null;                         //! Kg換算値
            _Water_Solvent_Type = null;             //! 水性区分
            _Slip_Type = null;                      //! 伝票区分
            _CANCEL_Type = null;                    //! 取消区分
            _Summary = null;                        //! 概要
            _Proofing_Type_Code = null;             //! 分類
            _Dealer_Code = null;                    //! 得意先コード clinet
            _Dealer_Name_KANA = null;               //! 得意先名
            _Dealer_Name = null;                    //! 得意先漢字
            _Block_Name = null;                     //! 営業所名
            _DEST_Code = null;                      //! 着地コード
            _Point_Area_Type = null;                //! ポイントエリア区分
            _DEST_TEL = null;                       //! 納入先TEL delivery
            _DEST_Name_KANJI = null;                //! 納入先名漢字
            _DEST_ADDR_KANJI = null;                //! 納入先住所
            _Input_Date = null;                     //! 投入日 activation
            _Input_time = null;                     //! 投入時間 activation
            _Rank_Code = null;                      //! 発注時ランク
            _HG_Carrier_Type = null;                //! 運送区分
            _HG_Carrier_Type_Name_Label = null;     //! 運送区分名(ラベル), 20bytes
            _SS_Auto_Line_out = null;               //! 運送区分
            _SS_Delivery_Type_Name = null;          //! 運送区分名
            _Item_ORD_Code = null;                  //! 順位コード
            _RF_Total_Variety = null;               //! RF集計用品種 aggregation
            _Sample_Plate_Quantity = null;          //! 塗板添付枚数 plate attachment quantity
            _SS_site_out_Plan_Date = null;          //! SS出荷予定日　delivery scheduled date
            _Person_In_Charge_Name = null;          //! 担当者名漢字
            _Site_Out_Plan_Date = null;             //! 出荷予定日　delivery scheduled date
            _NP_Variety_Code = null;                //! NP商品コード
            _NP_Pacage_Code = null;                 //! NP容量
            _HG_Carrier_Type_Name = null;           //! 運送区分名, 16bytes
            _ASK_OUT_Type = null;                   //! ASK出荷区分
            _Carrier_Name = null;                   //! 配送業者 company
            _Common_Item_Code = null;               //! 統合商品コード integration
            _Reserve = null;                        //! 予備
            _Gloss_Type_Code = null;                //! ツヤ区分
            _ADD_Proof_Type_Code = null;            //! 調色機能区分
            _RF_Display_Color_Type = null;          //! RF表示区分 display?
            _Gloss_Type_Name = null;                //! ツヤ区分名
            _ADD_Proof_Type_Name = null;            //! 調色機能名称
            _Cource_Name = null;                    //! コース名称
            _Reserve2 = null;                       //! 予備2
            return 1;
        }
    }
}
