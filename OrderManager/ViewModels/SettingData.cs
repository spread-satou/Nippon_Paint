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
    /// 設定ダイアログ
    /// </summary>
    public class SettingData
    {
        /// <summary>
        /// CCM品種名
        /// </summary>
        public string CCMPaintName { get; set; }
        /// <summary>
        /// 正式品種名
        /// </summary>
        public string FormalPaintName { get; set; }
        /// <summary>
        /// ラベルタイプ
        /// </summary>
        public int LabelType { get; set; }
        /// <summary>
        /// ラベルタイプ名称
        /// </summary>
        public string LabelDescription { get; set; }

        public SettingData()
        {
            CCMPaintName = "1液ﾌｧｲﾝｳﾚﾀﾝ(RF)";
            FormalPaintName = "1液ﾌｧｲﾝｳﾚﾀﾝ U-100";
            LabelType = 11;
            LabelDescription = "1液ファインウレタン Ｕ100";
        }
    }
}
