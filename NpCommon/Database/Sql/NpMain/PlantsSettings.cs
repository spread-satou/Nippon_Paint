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
    public static class PlantsSettings
    {
        /// <summary>
        /// 設備設定の一覧を表示
        /// </summary>
        /// <returns></returns>
        public static string GetPreview()
        {
            var sql = new StringBuilder();
            sql.Append($"select　");
            sql.Append($" id　");
            sql.Append($", FTP_Server ");
            sql.Append($", FTP_Port ");
            sql.Append($", FTP_User ");
            sql.Append($", FTP_Password ");
            sql.Append($", FTP_Dir_Receive ");
            sql.Append($", FTP_Dir_Send ");
            sql.Append($", FTP_Dir_Notify ");
            sql.Append($", Enabled ");
            sql.Append($", TRK_Shipper_Code ");
            sql.Append($", TRK_Shipper_Address_1 ");
            sql.Append($", TRK_Shipper_Address_2 ");
            sql.Append($", TRK_Shipper_Company ");
            sql.Append($", TRK_Shipper_Subsidiary ");
            sql.Append($", TRK_Telephone_Number ");
            sql.Append($"from Plants_Settings ");

            return sql.ToString();
        }
    }
}
