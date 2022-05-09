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
    /// 注文開始ダイアログ
    /// </summary>
    public class OrderStartData
    {
        /// <summary>
        /// 注文番号
        /// </summary>
        public string OrderNumber { get; set; }
        /// <summary>
        /// 色名
        /// </summary>
        public string ColorName { get; set; }
        /// <summary>
        /// 製品コード
        /// </summary>
        public string ProductCode { get; set; }
        /// <summary>
        /// 缶数
        /// </summary>
        public int NumberOfCan { get; set; }
        /// <summary>
        /// 品名
        /// </summary>
        public string ItemName { get; set; }
        /// <summary>
        /// 正式品種名
        /// </summary>
        public string FormalItemName { get; set; }
        /// <summary>
        /// 白コード
        /// </summary>
        public string WhiteCode { get; set; }
        /// <summary>
        /// 補正
        /// </summary>
        public int Revision { get; set; }
        /// <summary>
        /// 合計重量[g]
        /// </summary>
        public double TotalWeight { get; set; }
        /// <summary>
        /// 超過[%]
        /// </summary>
        public double Overfilling { get; set; }
        /// <summary>
        /// 充填済み重量(g)
        /// </summary>
        public int FilledWeight { get; set; }
        /// <summary>
        /// 重量誤差[%](下限)
        /// </summary>
        public double WeightToleranceMin { get; set; }
        /// <summary>
        /// 重量誤差[%](上限)
        /// </summary>
        public double WeightToleranceMax { get; set; }
        /// <summary>
        /// クオリティサンプル[g]
        /// </summary>
        public int QualitySample { get; set; }
        /// <summary>
        /// ミキシングタイム[s]
        /// </summary>
        public int MixingTime { get; set; }
        /// <summary>
        /// ミキシングスピード(回/分)
        /// </summary>
        public int MixingSpeed { get; set; }

        public OrderStartData()
        {
            OrderNumber = "51F0011000059";
            ColorName = "596-1910-00447 K19-90A";
            ProductCode = "JL";
            NumberOfCan = 10;
            ItemName = "ﾘｼﾝﾍﾞｰｽ";
            FormalItemName = "ﾘｼﾝﾍﾞｰｽ";
            WhiteCode = "NLB";
            Revision = 0;
            TotalWeight = 3.2;
            Overfilling = 0.0;
            FilledWeight = 20000;
            WeightToleranceMin = +2.0;
            WeightToleranceMax = -2.0;
            QualitySample = 0;
            MixingTime = 120;
            MixingSpeed = 100;
        }
    }
}
