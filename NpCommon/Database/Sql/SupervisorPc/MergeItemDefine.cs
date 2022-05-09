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
    public class MergeItemDefine
    {
        /// <summary>
        /// テーブル列名
        /// </summary>
        public string Field { get; set; }
        /// <summary>
        /// 更新のキーとして使用する列か
        /// </summary>
        public bool IsKey { get; set; }
        /// <summary>
        /// Insertで更新する項目か
        /// </summary>
        public bool IsInsert { get; set; }
        /// <summary>
        /// Updateで更新する項目か
        /// </summary>
        public bool IsUpdate { get; set; }
    }
}
