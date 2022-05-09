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
    /// 商品コードマスタダイアログ
    /// </summary>
    public class ProductCodeMasterData
    {
        /// <summary>
        /// 品名コード
        /// </summary>
        public int ProductCode { get; set; }

        /// <summary>
        /// 品名コードID
        /// </summary>
        public int ProductCodeID { get; set; }

        public ProductCodeMasterData()
        {
            ProductCode = 1061244;
            ProductCodeID = 150;
        }
    }
}
