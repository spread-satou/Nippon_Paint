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

namespace NipponPaint.NpCommon.Database
{
    public class ParameterItem
    {
        /// <summary>
        /// キー
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// 値
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public ParameterItem(string key, object value)
        {
            Key = key;
            Value = value;
        }
    }
}
