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
using Attr = NipponPaint.NpCommon.Attributes.AttributeUtility;
#endregion

namespace NipponPaint.NpCommon.Database.Sql.SupervisorPc
{
    public class TbFormula
    {
        #region 定数
        public const string MAIN_TABLE = "TB_FORMULA";

        public const string PRD_BARCODE = "PRD_BARCODE";
        public const string PRD_PROCESS_CODE = "PROCESS_CODE";
        public const string PRD_TIME_INSERTED = "PRD_TIME_INSERTED";
        public const string PRD_STATUS = "PRD_STATUS";
        public const string PRD_CODE = "PRD_CODE";
        public const string PRD_DESC = "PRD_DESC";
        public const string PRD_UM = "UM";
        public const string PRD_SPECIFIC_GRAVITY = "PRD_SPECIFIC_GRAVITY";
        public const string PRD_QTY_REQ = "PRD_QTY_REQ";
        public const string PRD_QTY_DISP = "PRD_QTY_DISP";
        public const string PRD_START_DISP = "PRD_START_DISP";
        public const string PRD_END_DISP = "PRD_END_DISP";
        public const string PRD_PRIORITY = "PRD_PRIORITY";
        public const string PRD_NUM = "PRD_NUM";
        public const string PRD_ISPREFILLED = "PRD_ISPREFILLED";
        public const string PRD_PREFILLED_QTY = "PRD_PREFILLED_QTY";

        public static List<MergeItemDefine> Fields = new List<MergeItemDefine>()
        {
            new MergeItemDefine(){ Field = PRD_BARCODE, IsKey = true, IsInsert = true, IsUpdate = false },
            new MergeItemDefine(){ Field = PRD_PROCESS_CODE, IsKey = true, IsInsert = true, IsUpdate = false },
            new MergeItemDefine(){ Field = PRD_TIME_INSERTED, IsKey = false, IsInsert = true, IsUpdate = true },
            new MergeItemDefine(){ Field = PRD_STATUS, IsKey = false, IsInsert = true, IsUpdate = true },
            new MergeItemDefine(){ Field = PRD_CODE, IsKey = false, IsInsert = true, IsUpdate = true },
            new MergeItemDefine(){ Field = PRD_DESC, IsKey = false, IsInsert = true, IsUpdate = true },
            new MergeItemDefine(){ Field = PRD_UM, IsKey = false, IsInsert = true, IsUpdate = true },
            new MergeItemDefine(){ Field = PRD_SPECIFIC_GRAVITY, IsKey = false, IsInsert = true, IsUpdate = true },
            new MergeItemDefine(){ Field = PRD_QTY_REQ, IsKey = false, IsInsert = true, IsUpdate = true },
            new MergeItemDefine(){ Field = PRD_QTY_DISP, IsKey = false, IsInsert = true, IsUpdate = true },
            new MergeItemDefine(){ Field = PRD_START_DISP, IsKey = false, IsInsert = true, IsUpdate = true },
            new MergeItemDefine(){ Field = PRD_END_DISP, IsKey = false, IsInsert = true, IsUpdate = true },
            new MergeItemDefine(){ Field = PRD_PRIORITY, IsKey = false, IsInsert = true, IsUpdate = true },
            new MergeItemDefine(){ Field = PRD_NUM, IsKey = false, IsInsert = true, IsUpdate = true },
            new MergeItemDefine(){ Field = PRD_ISPREFILLED, IsKey = false, IsInsert = true, IsUpdate = true },
            new MergeItemDefine(){ Field = PRD_PREFILLED_QTY, IsKey = false, IsInsert = true, IsUpdate = true },
        };
        #endregion

        #region 更新系

        #region マージ
        /// <summary>
        /// Merge
        /// </summary>
        /// <param name="Parameters"></param>
        /// <returns></returns>
        public static string Merge(out List<ParameterItem> parameters, DateTime entryTime)
        {
            return Func.CreateMergeStatement(MAIN_TABLE, Fields, entryTime, out parameters);
        }
        #endregion

        #endregion
    }
}
