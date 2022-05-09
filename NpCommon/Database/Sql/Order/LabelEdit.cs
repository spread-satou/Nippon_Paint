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

#region using defines
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace NipponPaint.NpCommon.Database.Sql.Order
{
    public static class LabelEdit
    {
        #region 参照系

        #region 一覧データの取得
        /// <summary>
        /// 一覧データの取得
        /// </summary>
        /// <returns></returns>
        public static string GetPreview()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine($"select ");
            sql.AppendLine($" Ls.* ");
            sql.AppendLine($",Lis.* ");
            sql.AppendLine($"From ");
            sql.AppendLine($"Labels as Ls ");
            sql.AppendLine($"Left Join ");
            sql.AppendLine($"Label_Items as Lis ");
            sql.AppendLine($"On ");
            sql.AppendLine($"Ls.Label_Type = Lis.Label_Type ");
            sql.AppendLine($"Where  ");
            sql.AppendFormat($"Ls.Label_Type = @labelType ");
            return sql.ToString();
        }
        #endregion

        #region 詳細データの取得
        #endregion

        #endregion

        #region 更新系
        #endregion
    }
}
