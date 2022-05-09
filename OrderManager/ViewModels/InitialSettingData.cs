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
    /// 初期設定ダイアログ
    /// </summary>
    public class InitialSettingData
    {
        /// <summary>
        /// 白コード
        /// </summary>
        public string WhiteCode { get; set; }
        /// <summary>
        /// 缶タイプ
        /// </summary>
        public int CanType { get; set; }
        /// <summary>
        /// 缶詳細
        /// </summary>
        public string CanDescription { get; set; }
        /// <summary>
        /// キャップタイプ
        /// </summary>
        public int CapType { get; set; }
        /// <summary>
        /// キャップ詳細
        /// </summary>
        public string CapDescription { get; set; }
        /// <summary>
        /// 超過[%]
        /// </summary>
        public int OverFilling { get; set; }
        /// <summary>
        /// 充填済み重量(g)
        /// </summary>
        public int FilledWeight { get; set; }
        /// <summary>
        /// ミキシングタイム[S]
        /// </summary>
        public int MixingTime { get; set; }
        /// <summary>
        /// ミキシングスピード(回/分)
        /// </summary>
        public int MixingSpeed { get; set; }

        public InitialSettingData()
        {
            WhiteCode = "3OFS";
            CanType = 4;
            CapType = 2;
            CanDescription = "70mm bunghole can";
            CapDescription = "70mm metal cap";
            OverFilling = 0;
            FilledWeight = 15000;
            MixingTime = 120;
            MixingSpeed = 100;
        }
            
}
}
