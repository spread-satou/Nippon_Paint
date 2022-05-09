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
    public static class MainSet
    {
        /// <summary>
        /// メイン設定の一覧を表示
        /// </summary>
        /// <returns></returns>
        public static string GetPreview()
        {
            var sql = new StringBuilder();
            sql.Append($"SELECT ");
            sql.Append($" Main_Set_Id ");
            sql.Append($",Color_Station_Area_Code ");
            sql.Append($",TRK_Current_First ");
            sql.Append($",TRK_Current_Last ");
            sql.Append($",TRK_Latest_Used ");
            sql.Append($",TRK_Next_First ");
            sql.Append($",TRK_Next_Last ");
            sql.Append($",TRK_Departure_Code ");
            sql.Append($",TRK_Departure_Name ");
            sql.Append($",FTP_Delay_Check ");
            sql.Append($",Auto_Close_Orders ");
            sql.Append($",Archive_Permanence ");
            sql.Append($",CSV_Path ");
            sql.Append($",CSV_Day ");
            sql.Append($",CSV_Time ");
            sql.Append($",BCK_Daily_Time ");
            sql.Append($",BCK_Weekly_Time ");
            sql.Append($"FROM Main_Set ");

            return sql.ToString();
        }
    }
}
