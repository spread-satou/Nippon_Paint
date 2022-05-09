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
    /// 缶タイプダイアログ
    /// </summary>
    public class CanTypeData
    {
        /// <summary>
        /// 缶タイプ
        /// </summary>
        public int CanType { get; set; }
        /// <summary>
        /// 缶詳細
        /// </summary>
        public string CanDescription { get; set; }
        /// <summary>
        /// 穴サイズ[mm]
        /// </summary>
        public int HoleSize { get; set; }
        /// <summary>
        /// 空缶重量[g]
        /// </summary>
        public int EmptyCanWeight { get; set; }
        /// <summary>
        /// 通常容量[ml]
        /// </summary>
        public int NormalVolume { get; set; }
        /// <summary>
        /// 最大容量[ml]
        /// </summary>
        public int MaxVolume { get; set; }

        public CanTypeData()
        {
            CanType = 3;
            CanDescription = "50mm bunghole cann";
            HoleSize = 50;
            EmptyCanWeight = 1145;
            NormalVolume = 18000;
            MaxVolume = 18000;
        }
    }
}
