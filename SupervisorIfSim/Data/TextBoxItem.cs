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
using System.Windows.Forms;
#endregion

namespace SupervisorIfSim.Data
{
    public class TextBoxItem
    {
        /// <summary>
        /// テキストボックス
        /// </summary>
        public TextBox TextBox { get; set; }
        /// <summary>
        /// データベースのフィールド名
        /// </summary>
        public string FieldName { get; set; }
        /// <summary>
        /// 列のタイプ
        /// </summary>
        public Type FieldType { get; set; }
    }
}
