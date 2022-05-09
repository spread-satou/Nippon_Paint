//*****************************************************************************
//
//  システム名：調色工場用自動計量システム NpCommon
//
//  Copyright 三菱電機エンジニアリング株式会社 2022 All rights reserved.
//
//-----------------------------------------------------------------------------
//  変更履歴:
//  Ver      日付        担当       コメント
//  0.0      2022/04/30  A.Satou    新規作成
#region 更新履歴
#endregion
//*****************************************************************************

#region using defines
#endregion

namespace NipponPaint.OrderManager.ViewModels
{
    /// <summary>
    /// ビューモデル
    /// ラベル印刷ダイアログ
    /// </summary>
    public class LabelPrintData
    {
        /// <summary>
        /// 印刷枚数
        /// </summary>
        public int PrintNumber { get; set; }
        /// <summary>
        /// 漢字（高さ）
        /// </summary>
        public int KanjiHeight { get; set; }
        /// <summary>
        /// 漢字（幅）
        /// </summary>
        public int KanjiWidth { get; set; }
        /// <summary>
        /// 通常（高さ）
        /// </summary>
        public int NormalHeight { get; set; }
        /// <summary>
        /// 通常（幅）
        /// </summary>
        public int NormalWidth { get; set; }

        public LabelPrintData()
        {
            PrintNumber = 1;
            KanjiHeight = 100;
            KanjiWidth = 60;
            NormalHeight = 60;
            NormalWidth = 60;
        }
    }
}
