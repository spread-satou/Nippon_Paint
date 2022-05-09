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
    /// NP商品コードマスタダイアログ
    /// </summary>
    public class NPProductCodeMasterData
    {
        /// <summary>
        /// NP商品コードID
        /// </summary>
        public string NPProductCodeID { get; set; }
        /// <summary>
        /// NP商品コードマスタ(前選択)
        /// </summary>
        public string NPProductCodeMasterFront { get; set; }
        /// <summary>
        /// 容量(前選択)
        /// </summary>
        public string VolumeFront { get; set; }
        /// <summary>
        /// NP商品コードマスタ(後選択)
        /// </summary>
        public string NPProductCodeMasterBack { get; set; }
        /// <summary>
        /// 容量(後選択)
        /// </summary>
        public string VolumeBack { get; set; }

        public NPProductCodeMasterData()
        {
            NPProductCodeID = "2131";
            NPProductCodeMasterFront = "0AB02";
            VolumeFront = "15K";
            NPProductCodeMasterBack = "YZZ01202";
            VolumeBack = "15K";
        }
    }
}
