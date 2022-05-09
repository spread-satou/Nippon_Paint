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
    public class SelectDataNumber
    {
        /// <summary>
        /// 処理No.
        /// </summary>
        public int DataNumber { get; set; }
        /// <summary>
        /// 製品コード
        /// </summary>
        public string SelectedProductCode { get; set; }

        public SelectDataNumber()
        {
            DataNumber = 0;
            SelectedProductCode = "";
        }
    }
}
