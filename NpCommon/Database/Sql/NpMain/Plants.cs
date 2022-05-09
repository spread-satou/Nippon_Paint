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
using System.Collections.Generic;
using System.Text;
using NipponPaint.NpCommon.Settings;
#endregion

namespace NipponPaint.NpCommon.Database.Sql.NpMain
{
    public static class Plants
    {
        /// <summary>
        /// 工場テーブルの一覧を取得
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static string GetPreview()
        {
            var sql = new StringBuilder();
            sql.Append($"SELECT ");
            sql.Append($" Plant_ID, Plant_Description ");
            sql.Append($",Daily_Capability, Daily_Working_Time, Start_Working_Time ");
            sql.Append($"FROM Plants ");

            return sql.ToString();
        }
    }
}
