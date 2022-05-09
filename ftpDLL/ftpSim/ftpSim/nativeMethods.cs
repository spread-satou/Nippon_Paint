using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices; // DLL Import

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
public struct ordParams
{
    public string filename;

    public string strHG;                                //! HG区分
    public string strPROC_NO;                           //! 処理NO   proceed
    public string strLINE_NO;                           //! 行NO
    public string strDEVI_ANS;                          //! 分割回答 devision
    public string strDEVI_DELI;                         //! 分割出荷 delivery
    public string strSS;                                //! SSコード
    public string strDELI_DATE;                         //! 納期 delivery
    public string strPROD_CODE;                         //! 商品コード product
    public string strPROD_NAME;                         //! 商品名 product
    public string strCAPA;                              //! 容量 capacity
    public string strQUAN;                              //! 数量 quantity
    public string strSAMPLE;                            //! 標準見本
    public string strRET_METHOD;                        //! 返却方法
    public string strCOL_MANAGE;                        //! 調色精度
    public string strOTHER_NOTE;                        //! その他特記事項
    public string strKG;                                //! Kg換算値
    public string strWATER;                             //! 水性区分
    public string strRECEIPT;                           //! 伝票区分
    public string strCANCEL;                            //! 取消区分
    public string strSUMMARY;                           //! 概要
    public string strGROUP;                             //! 分類
    public string strCLI_CODE;                          //! 得意先コード clinet
    public string strCLI_NAME;                          //! 得意先名
    public string strCLI_KANJI;                         //! 得意先漢字
    public string strOFFICE_NAME;                       //! 営業所名
    public string strCHAKUCHI;                          //! 着地コード
    public string strPOI_AREA;                          //! ポイントエリア区分
    public string strDELI_TEL;                          //! 納入先TEL delivery
    public string strDELI_KANJI;                        //! 納入先名漢字
    public string strDELI_ADDR;                         //! 納入先住所
    public string strACT_DATE;                          //! 投入日 activation
    public string strACT_TIME;                          //! 投入時間 activation
    public string strORD_RANK;                          //! 発注時ランク
    public string strHGTRANS_GRP;                       //! 運送区分
    public string strHGTRANS_LABEL;                     //! 運送区分名(ラベル), 20bytes
    public string strSSTRANS_GRP;                       //! 運送区分
    public string strSSTRANS_LABEL;                     //! 運送区分名
    public string strRANKING_CODE;                      //! 順位コード
    public string strRF_AGGRE_KIND;                     //! RF集計用品種 aggregation
    public string strPLATE_ATTQUAN;                     //! 塗板添付枚数 plate attachment quantity
    public string strSSDELI_SCHE;                       //! SS出荷予定日　delivery scheduled date
    public string strPERSON_NAME;                       //! 担当者名漢字
    public string strDELI_SCHE;                         //! 出荷予定日　delivery scheduled date
    public string strNPITEM_CODE;                       //! NP商品コード
    public string strNP_CAPA;                           //! NP容量
    public string strHGTRANS_NAME;                      //! 運送区分名, 16bytes
    public string strASK_OUT_GRP;                       //! ASK出荷区分
    public string strDELI_CO;                           //! 配送業者 company
    public string strINT_ITEM_CODE;                     //! 統合商品コード integration
    public string strRESERVE1;                          //! 予備
    public string strGLOSS_GRP;                         //! ツヤ区分
    public string strCOL_FUNCGRP;                       //! 調色機能区分
    public string strRFDISP_GRP;                        //! RF表示区分 display?
    public string strGLOSS_GRPNAME;                     //! ツヤ区分名
    public string strCOL_FUNCNAME;                      //! 調色機能名称
    public string strCOURCE_NAME;                       //! コース名称
    public string strRESERVE2;                          //! 予備2
}

namespace ftpSim
{
    internal class nativeMethods
    {
        [DllImport("ftpDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int native_simulator(ref ordParams rOp);
    }
}
