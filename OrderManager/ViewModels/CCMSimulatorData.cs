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
    /// CCMシミュレータ
    public class CCMSimulatorData
    {
        /// <summary>
        /// 色名(漢字)
        /// </summary>
        public string KanjiColorName { get; set; }
        /// <summary>
        /// 品名
        /// </summary>
        public string PaintName { get; set; }
        /// <summary>
        /// 既調色ファイル名
        /// </summary>
        public string ColorFileName { get; set; }
        /// <summary>
        /// 目次番号
        /// </summary>
        public int IndexNumber { get; set; }
        /// <summary>
        /// ライン
        /// </summary>
        public string Line { get; set; }
        /// <summary>
        /// 補正
        /// </summary>
        public int Correction { get; set; }
        /// <summary>
        /// ベース値
        /// </summary>
        public double BaseValue { get; set; }
        /// <summary>
        /// ラベル
        /// </summary>
        public int Label { get; set; }
        /// <summary>
        /// CSエリアコード
        /// </summary>
        public string CSAreaCode { get; set; }
        /// <summary>
        /// 着色剤設定値1
        /// </summary>
        public double ColoarantValue1 { get; set; }
        /// <summary>
        /// 着色剤設定値2
        /// </summary>
        public double ColoarantValue2 { get; set; }
        /// <summary>
        /// 着色剤設定値3
        /// </summary>
        public double ColoarantValue3 { get; set; }
        /// <summary>
        /// 着色剤設定値4
        /// </summary>
        public double ColoarantValue4 { get; set; }
        /// <summary>
        /// 着色剤設定値5
        /// </summary>
        public double ColoarantValue5 { get; set; }
        /// <summary>
        /// 着色剤設定値6
        /// </summary>
        public double ColoarantValue6 { get; set; }
        /// <summary>
        /// 着色剤設定値7
        /// </summary>
        public double ColoarantValue7 { get; set; }
        /// <summary>
        /// 着色剤設定値8
        /// </summary>
        public double ColoarantValue8 { get; set; }
        /// <summary>
        /// 着色剤設定値9
        /// </summary>
        public double ColoarantValue9 { get; set; }
        /// <summary>
        /// 着色剤設定値10
        /// </summary>
        public double ColoarantValue10 { get; set; }

        public CCMSimulatorData()
        {
            KanjiColorName = "";
            PaintName = "";
            ColorFileName = "";
            Line = "";
            Correction = 0;
            BaseValue = 0.000;
            Label = 1;
            CSAreaCode = "SO-81";
            ColoarantValue1 = 0.000;
            ColoarantValue2 = 0.000;
            ColoarantValue3 = 0.000;
            ColoarantValue4 = 0.000;
            ColoarantValue5 = 0.000;
            ColoarantValue6 = 0.000;
            ColoarantValue7 = 0.000;
            ColoarantValue8 = 0.000;
            ColoarantValue9 = 0.000;
            ColoarantValue10 = 0.000;
        }
    }
}
