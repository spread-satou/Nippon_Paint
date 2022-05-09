//*****************************************************************************
//
//  システム名：調色工場用自動計量システム NpCommon
//
//  Copyright 三菱電機エンジニアリング株式会社 2022 All rights reserved.
//
//-----------------------------------------------------------------------------
//  変更履歴:
//  Ver      日付        担当       コメント
//  0.0      2022/04/30  M.Nakai    新規作成
#region 更新履歴
#endregion
//*****************************************************************************

using NipponPaint.NpCommon.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NipponPaint.NpCommon.Database.Sql.NpMain
{
    public static class HgLog
    {
        #region 一覧データの取得
        /// <summary>
        /// 一覧データの取得
        /// </summary>
        /// <returns></returns>
        public static string GetPreview(List<GridViewSetting> viewSettings)
        {
            var sql = new StringBuilder();
            sql.Append($"SELECT ");
            int cnt = 0;
            foreach (var item in viewSettings)
            {
                if (cnt > 0)
                {
                    sql.Append(",");
                }
                sql.Append(item.SqlSentence);
                cnt++;
            }
            sql.Append($"FROM HG_Log ");
            sql.Append($"ORDER BY HG_Log_Id DESC ");
            return sql.ToString();
        }
        #endregion
    }
}
