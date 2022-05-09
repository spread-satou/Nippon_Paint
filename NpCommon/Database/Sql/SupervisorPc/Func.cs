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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace NipponPaint.NpCommon.Database.Sql.SupervisorPc
{
    public class Func
    {

        public static string CreateMergeStatement(string tableName, List<MergeItemDefine> fields, DateTime entryTime, out List<ParameterItem> parameters)
        {
            var SelectItems = new List<string>();
            var KeyItems = new List<string>();
            var UpdateItems = new List<string>();
            var InsertFields = new List<string>();
            var InsertValues = new List<string>();
            parameters = new List<ParameterItem>();
            foreach (var field in fields)
            {
                SelectItems.Add($" @{field.Field} AS {field.Field} ");
                parameters.Add(new ParameterItem($"{field.Field}", null));
                if (field.IsKey)
                {
                    KeyItems.Add($"{tableName}.{field.Field}=ITEMS.{field.Field}");
                }
                if (field.IsUpdate)
                {
                    UpdateItems.Add($"{field.Field}=ITEMS.{field.Field}");
                }
                if (field.IsInsert)
                {
                    InsertFields.Add($"{field.Field}");
                    InsertValues.Add($"@{field.Field}");
                }
            }
            var sql = new StringBuilder();
            sql.Append($"MERGE INTO {tableName} USING (SELECT {string.Join(",", SelectItems)}) AS ITEMS ");
            sql.Append($"ON ({string.Join(" AND ", KeyItems)}) ");
            sql.Append($"WHEN MATCHED THEN UPDATE SET {string.Join(",", UpdateItems)} ");
            sql.Append($"WHEN NOT MATCHED THEN INSERT ({string.Join(",", InsertFields)}) VALUES ({string.Join(",", InsertValues)}); ");
            return sql.ToString();
        }

       
    }
}
