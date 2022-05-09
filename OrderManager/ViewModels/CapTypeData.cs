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
    /// キャップタイプダイアログ
    /// </summary>
    public class CapTypeData
    {
        /// <summary>
        /// キャップタイプ
        /// </summary>
        public int CapType { get; set; }
        /// <summary>
        /// キャップ詳細
        /// </summary>
        public string CapDescription { get; set; }
        /// <summary>
        /// キャップサイズ[mm]
        /// </summary>
        public int CapSize { get; set; }
        /// <summary>
        /// キャップ重量[g]
        /// </summary>
        public int CapWeight { get; set; }
        /// <summary>
        /// キャッパー
        /// </summary>
        public int CappingMachine { get; set; }
        /// <summary>
        /// 手動キャッピング
        /// </summary>
        public int ManualCapping { get; set; }
        public object ChkManualCapping { get; internal set; }

        public CapTypeData()
        {
            CapType = 2;
            CapDescription = "70mm metal Cap";
            CapSize = 70;
            CapWeight = 21;
            CappingMachine = 1;
        }
    }
}
