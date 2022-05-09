// https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/keywords/using
using ftpSim;

/*
    57パラメータ
    => 1行テキスト
    => ord_file インスタンス(メモリ配置実施)
    => ord_file::memupdate(unsigned char* pRcvmsg, size_t siLength);
    => ord_file::inspector(std::string& rstrResult)
    => 受け取った57パラメータ&OKY/ERRファイル保存
*/


// https://docs.microsoft.com/ja-jp/dotnet/csharp/fundamentals/types/classes
// https://docs.microsoft.com/ja-jp/dotnet/api/system.collections.generic.list-1?view=net-6.0
//myElement e = new myElement("AREA_CODE", elementSize.HG, elementType.SINGLE);

// Create a list of parts.
List<myElement> elelist = new List<myElement>();

// Add parts to the list.
elelist.Add(new myElement("AREA_CODE", elementSize.HG, elementType.SINGLE));
elelist.Add(new myElement("SLIP_NUMBER", elementSize.PROC_NO, elementType.SINGLE));
elelist.Add(new myElement("DETAIL_NUMBER", elementSize.LINE_NO, elementType.SINGLE));
elelist.Add(new myElement("REPLY_INSTALLMENT_NUMBER", elementSize.DEVI_ANS, elementType.SINGLE));
elelist.Add(new myElement("ACTUAL_INSTALLMENT_NUMBER", elementSize.DEVI_DELI, elementType.SINGLE));

elelist.Add(new myElement("SS_CODE", elementSize.SS, elementType.SINGLE));
elelist.Add(new myElement("DUE_DATE", elementSize.DELI_DATE, elementType.SINGLE));
elelist.Add(new myElement("ITEM_CODE", elementSize.PROD_CODE, elementType.SINGLE));
elelist.Add(new myElement("ITEM_NAME", elementSize.PROD_NAME, elementType.MULTI));
elelist.Add(new myElement("PACKAGE_CODE", elementSize.CAPA, elementType.SINGLE));

elelist.Add(new myElement("QUANTITY", elementSize.QUAN, elementType.NUMERIC));
elelist.Add(new myElement("PROOFING_STANDARD_SAMPLE", elementSize.SAMPLE, elementType.MULTI));
elelist.Add(new myElement("SAMPLE_RETURN_METHOD", elementSize.RET_METHOD, elementType.MULTI));
elelist.Add(new myElement("REQUIRED_LOT_NUMBER", elementSize.COL_MANAGE, elementType.SINGLE));
elelist.Add(new myElement("SUMMARY_FOR_PROOFING", elementSize.OTHER_NOTE, elementType.MULTI));

elelist.Add(new myElement("WEIGHT", elementSize.KG, elementType.NUMERIC));
elelist.Add(new myElement("WATER_SOLVENT_TYPE", elementSize.WATER, elementType.SINGLE));
elelist.Add(new myElement("SLIP_TYPE", elementSize.RECEIPT, elementType.SINGLE));
elelist.Add(new myElement("CANCELLATION_TYPE", elementSize.CANCEL, elementType.SINGLE));
elelist.Add(new myElement("SUMMARY", elementSize.SUMMARY, elementType.MULTI));

elelist.Add(new myElement("PROOFING_TYPE_CODE", elementSize.GROUP, elementType.SINGLE));
elelist.Add(new myElement("DEALER_CODE", elementSize.CLI_CODE, elementType.SINGLE));
elelist.Add(new myElement("DEALER_NAME_KANA", elementSize.CLI_NAME, elementType.SINGLE));
elelist.Add(new myElement("DEALER_NAME", elementSize.CLI_KANJI, elementType.MULTI));
elelist.Add(new myElement("BLOCK_NAME", elementSize.OFFICE_NAME, elementType.MULTI));

elelist.Add(new myElement("DESTINATION_CODE", elementSize.CHAKUCHI, elementType.SINGLE));
elelist.Add(new myElement("POINT_AREA_TYPE", elementSize.POI_AREA, elementType.SINGLE));
elelist.Add(new myElement("DESTINATION_TELEPHONE_NUMBER", elementSize.DELI_TEL, elementType.SINGLE));
elelist.Add(new myElement("DESTINATION_NAME_KANJI", elementSize.DELI_KANJI, elementType.MULTI));
elelist.Add(new myElement("DESTINATION_ADDRESS_KANJI", elementSize.DELI_ADDR, elementType.MULTI));

elelist.Add(new myElement("INPUT_DATE", elementSize.ACT_DATE, elementType.SINGLE));
elelist.Add(new myElement("INPUT_TIME", elementSize.ACT_TIME, elementType.SINGLE));
elelist.Add(new myElement("RANK_CODE", elementSize.ORD_RANK, elementType.SINGLE));
elelist.Add(new myElement("HG_CARRIER_TYPE", elementSize.HGTRANS_GRP, elementType.SINGLE));
elelist.Add(new myElement("HG_CARRIER_TYPE_NAME_LABEL", elementSize.HGTRANS_LABEL, elementType.MULTI));

elelist.Add(new myElement("IS_AUTO_LINE_OUT", elementSize.SSTRANS_GRP, elementType.SINGLE));
elelist.Add(new myElement("SS_DELIVERY_TYPE_NAME", elementSize.SSTRANS_LABEL, elementType.MULTI));
elelist.Add(new myElement("ITEM_ORDER_CODE", elementSize.RANKING_CODE, elementType.SINGLE));
elelist.Add(new myElement("RF_TOTAL_VARIETY", elementSize.RF_AGGRE_KIND, elementType.SINGLE));
elelist.Add(new myElement("SAMPLE_PLATE_QUANTITY", elementSize.PLATE_ATTQUAN, elementType.NUMERIC));

elelist.Add(new myElement("SS_SITE_OUT_PLAN_DATE", elementSize.SSDELI_SCHE, elementType.SINGLE));
elelist.Add(new myElement("PERSON_IN_CHARGE_NAME", elementSize.PERSON_NAME, elementType.MULTI));
elelist.Add(new myElement("SITE_OUT_PLAN_DATE", elementSize.DELI_SCHE, elementType.SINGLE));
elelist.Add(new myElement("NP_VARIETY_CODE", elementSize.NPITEM_CODE, elementType.SINGLE));
elelist.Add(new myElement("NP_PACKAGE_CODE", elementSize.NP_CAPA, elementType.SINGLE));

elelist.Add(new myElement("HG_CARRIER_TYPE_NAME", elementSize.HGTRANS_NAME, elementType.MULTI));
elelist.Add(new myElement("ASK_OUTPUT_TYPE", elementSize.ASK_OUT_GRP, elementType.SINGLE));
elelist.Add(new myElement("CARRIER_NAME", elementSize.DELI_CO, elementType.MULTI));
elelist.Add(new myElement("COMMON_ITEM_CODE", elementSize.INT_ITEM_CODE, elementType.SINGLE));
elelist.Add(new myElement("RESERVE", elementSize.RESERVE1, elementType.SINGLE));

elelist.Add(new myElement("GLOSS_TYPE_CODE", elementSize.GLOSS_GRP, elementType.SINGLE));
elelist.Add(new myElement("ADDITIONAL_PROOF_TYPE_CODE", elementSize.COL_FUNCGRP, elementType.SINGLE));
elelist.Add(new myElement("RF_DISPLAY_COLOR_TYPE", elementSize.RFDISP_GRP, elementType.SINGLE));
elelist.Add(new myElement("GLOSS_TYPE_NAME", elementSize.GLOSS_GRPNAME, elementType.MULTI));
elelist.Add(new myElement("ADDITIONAL_PROOF_TYPE_NAME", elementSize.COL_FUNCNAME, elementType.MULTI));

elelist.Add(new myElement("COURSE_NAME", elementSize.COURCE_NAME, elementType.MULTI));
elelist.Add(new myElement("RESERVE2", elementSize.RESERVE2, elementType.MULTI));

ordParams op = new ordParams();
op.filename = "RFORDER" + "20220428" + "00001" + ".ORD";
//
op.strHG ="ABC";                                        //! HG区分
op.strPROC_NO   = "abcdefghi";                          //! 処理NO   proceed
op.strLINE_NO   = "ab";                                 //! 行NO
op.strDEVI_ANS  = "cd";                                 //! 分割回答 devision
op.strDEVI_DELI = "ef";                                 //! 分割出荷 delivery
//
op.strSS = "ABC";                                       //! SSコード
op.strDELI_DATE = "abcdefgh";                           //! 納期 delivery
op.strPROD_CODE = "hgfedcba";                           //! 商品コード product
op.strPROD_NAME = "商品名４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８"; 
                                                        //! 商品名 product
op.strCAPA  = "abcdefgh";                               //! 容量 capacity
//
op.strQUAN  = "1234567";                                //! 数量 quantity
op.strSAMPLE= "標準見本５６７８９０１２３４５６７８９０１２３４５６７８９０";
                                                        //! 標準見本
op.strRET_METHOD = "見本返却方法７８９０１２３４５６７８９０";
                                                        //! 返却方法
op.strCOL_MANAGE = "abcdefghijklmnop";                  //! 調色精度
op.strOTHER_NOTE = "その他特記事項８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０";
                                                        //! その他特記事項
//
op.strKG    = "12345678901";                            //! Kg換算値
op.strWATER = "a";                                      //! 水性区分
op.strRECEIPT= "bc";                                    //! 伝票区分
op.strCANCEL = "d";                                     //! 取消区分
op.strSUMMARY= "摘要３４５６７８９０１２３４５６７８９０"; //! 概要
//
op.strGROUP     = "abcdefg";                            //! 分類
op.strCLI_CODE  = "ABCDEFG";                            //! 得意先コード clinet
op.strCLI_NAME  = "abcdefghijABCDEFGHIJ";               //! 得意先名
op.strCLI_KANJI = "得意先名漢字７８９０１２３４５６７８９０";//! 得意先名漢字
op.strOFFICE_NAME = "営業所名５６７８９０１２３４５";   //! 営業所名
//
op.strCHAKUCHI = "abcd-ef-ghijklm";                     //! 着地コード
op.strPOI_AREA = "Z";                                   //! ポイントエリア区分
op.strDELI_TEL = "1234-5678-90123";                     //! 納入先TEL delivery
op.strDELI_KANJI= "納入先名漢字７８９０１２３４５６７８９０１２３４５６７８９０";
                                                        //! 納入先名漢字
op.strDELI_ADDR = "納入先住所漢字８９０１２３４５６７８９０１２３４５６７８９０１２３４５";
                                                        //! 納入先住所
//
op.strACT_DATE = "yy/mm/dd";                            //! 投入日 activation
op.strACT_TIME = "ab::cd";                              //! 投入時間 activation
op.strORD_RANK = "AB";                                  //! 発注時ランク
op.strHGTRANS_GRP   = "a";                              //! 運送区分
op.strHGTRANS_LABEL = "ＨＧ運送区分名８９０";           //! 運送区分名(ラベル), 20bytes
//
op.strSSTRANS_GRP   = "a";                              //! 運送区分
op.strSSTRANS_LABEL = "１２３４";                       //! 運送区分名
op.strRANKING_CODE  = "abcedf";                         //! 順位コード
op.strRF_AGGRE_KIND = "AB";                             //! RF集計用品種 aggregation
op.strPLATE_ATTQUAN = "12";                             //! 塗板添付枚数 plate attachment quantity
//
op.strSSDELI_SCHE   = "abcdefgh";                       //! SS出荷予定日　delivery scheduled date
op.strPERSON_NAME   = "１２３４５";                     //! 担当者名漢字
op.strDELI_SCHE     = "abcdefgh";                       //! 出荷予定日　delivery scheduled date
op.strNPITEM_CODE   = "ABCDEFGH";                       //! NP商品コード
op.strNP_CAPA       = "hgfedcba";                       //! NP容量
//
op.strHGTRANS_NAME  = "ＨＧ運送区分名０";               //! 運送区分名, 16bytes
op.strASK_OUT_GRP   = "A";                              //! ASK出荷区分
op.strDELI_CO = "配送業者名６７８９０１２３４５６７８９０１２３４５";
                                                        //! 配送業者 company
op.strINT_ITEM_CODE = "abcdefg";                        //! 統合商品コード integration
op.strRESERVE1      = "a";                              //! 予備
//
op.strGLOSS_GRP     = "ab";                             //! ツヤ区分
op.strCOL_FUNCGRP   = "cd";                             //! 調色機能区分
op.strRFDISP_GRP    = "e";                              //! RF表示区分 display?
op.strGLOSS_GRPNAME = "艶区分名称";                     //! ツヤ区分名
op.strCOL_FUNCNAME  = "調色機能名称７８９０";           //! 調色機能名称
//
op.strCOURCE_NAME   = "コース名称";                     //! コース名称
op.strRESERVE2 = "１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０";
                                                        //! 予備2
ftpSim.nativeMethods.native_simulator(ref op);

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
