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
    public class TbBarcode
    {
        #region 定数
        public const string MAIN_TABLE = "TB_BARCODE";

        public const string BARCODE = "BARCODE";
        public const string PROCESS_CODE = "PROCESS_CODE";
        public const string BRC_TIME_INSERTED = "BRC_TIME_INSERTED";
        public const string BRC_TIME_PROCESSED = "BRC_TIME_PROCESSED";
        public const string BRC_STATUS = "BRC_STATUS";
        public const string BRC_ERR_1 = "BRC_ERR_1";
        public const string BRC_ERR_2 = "BRC_ERR_2";
        public const string BRC_ERR_3 = "BRC_ERR_3";

        public static List<MergeItemDefine> Fields = new List<MergeItemDefine>()
        {
            new MergeItemDefine(){ Field = BARCODE, IsKey = true, IsInsert = true, IsUpdate = false },
            new MergeItemDefine(){ Field = PROCESS_CODE, IsKey = true, IsInsert = true, IsUpdate = false },
            new MergeItemDefine(){ Field = BRC_TIME_INSERTED, IsKey = false, IsInsert = true, IsUpdate = true },
            new MergeItemDefine(){ Field = BRC_TIME_PROCESSED, IsKey = false, IsInsert = true, IsUpdate = true },
            new MergeItemDefine(){ Field = BRC_STATUS, IsKey = false, IsInsert = true, IsUpdate = true },
            new MergeItemDefine(){ Field = BRC_ERR_1, IsKey = false, IsInsert = true, IsUpdate = true },
            new MergeItemDefine(){ Field = BRC_ERR_2, IsKey = false, IsInsert = true, IsUpdate = true },
            new MergeItemDefine(){ Field = BRC_ERR_3, IsKey = false, IsInsert = true, IsUpdate = true },
        };
        #endregion

        #region メンバ変数
        private Data.SupervisorPc.TbBarcode _tbBarcode;
        #endregion

        #region プロパティ
        private Type ObjectType { get { return _tbBarcode.GetType(); } }
        #endregion

        #region コンストラクタ
        public TbBarcode()
        {
            _tbBarcode = new Data.SupervisorPc.TbBarcode();
        }

        public TbBarcode(Data.SupervisorPc.TbBarcode tbBarcode)
        {
            _tbBarcode = tbBarcode;
        }
        #endregion

        #region 参照系
        /// <summary>
        /// 一覧取得
        /// </summary>
        /// <param name="barCode"></param>
        /// <param name="processCode"></param>
        /// <returns></returns>
        public static string GetPreviewAll(string barCode = "", string processCode = "")
        {
            var sql = new StringBuilder();
            sql.Append($"SELECT ");
            sql.Append($"  BC.{BARCODE} ");
            sql.Append($" ,BC.{PROCESS_CODE} ");
            sql.Append($" ,BC.{BRC_TIME_INSERTED} ");
            sql.Append($" ,BC.{BRC_TIME_PROCESSED} ");
            sql.Append($" ,BC.{BRC_STATUS} ");
            sql.Append($" ,BC.{BRC_ERR_1} ");
            sql.Append($" ,BC.{BRC_ERR_2} ");
            sql.Append($" ,BC.{BRC_ERR_3} ");
            sql.Append($" ,FM.{TbFormula.PRD_TIME_INSERTED} ");
            sql.Append($" ,FM.{TbFormula.PRD_STATUS} ");
            sql.Append($" ,FM.{TbFormula.PRD_CODE} ");
            sql.Append($" ,FM.{TbFormula.PRD_DESC} ");
            sql.Append($" ,FM.{TbFormula.PRD_UM} ");
            sql.Append($" ,FM.{TbFormula.PRD_SPECIFIC_GRAVITY} ");
            sql.Append($" ,FM.{TbFormula.PRD_QTY_REQ} ");
            sql.Append($" ,FM.{TbFormula.PRD_QTY_DISP} ");
            sql.Append($" ,FM.{TbFormula.PRD_START_DISP} ");
            sql.Append($" ,FM.{TbFormula.PRD_END_DISP} ");
            sql.Append($" ,FM.{TbFormula.PRD_PRIORITY} ");
            sql.Append($" ,FM.{TbFormula.PRD_NUM} ");
            sql.Append($" ,FM.{TbFormula.PRD_ISPREFILLED} ");
            sql.Append($" ,FM.{TbFormula.PRD_PREFILLED_QTY} ");
            sql.Append($" ,JB.{TbJob.JOB_TIME_INSERTED} ");
            sql.Append($" ,JB.{TbJob.JOB_STATUS} ");
            sql.Append($" ,JB.{TbJob.JOB_TARE_WEIGHT_EXPECTED} ");
            sql.Append($" ,JB.{TbJob.JOB_TARE_WEIGHT_DETECTED} ");
            sql.Append($" ,JB.{TbJob.JOB_TARE_WEIGHT_PERC_ERR_ADMITTED} ");
            sql.Append($" ,JB.{TbJob.JOB_GROSS_WEIGHT_EXPECTED} ");
            sql.Append($" ,JB.{TbJob.JOB_GROSS_WEIGHT_DETECTED} ");
            sql.Append($" ,JB.{TbJob.JOB_GROSS_WEIGHT_PERC_ERR_ADMITTED} ");
            sql.Append($" ,JB.{TbJob.JOB_NET_WEIGHT_EXPECTED} ");
            sql.Append($" ,JB.{TbJob.JOB_NET_WEIGHT_DETECTED} ");
            sql.Append($" ,JB.{TbJob.JOB_NET_WEIGHT_PERC_ERR_ADMITTED} ");
            sql.Append($" ,JB.{TbJob.JOB_TOT_COLORANT_WEIGHT_EXPECTED} ");
            sql.Append($" ,JB.{TbJob.JOB_TOT_COLORANT_WEIGHT_DETECTED} ");
            sql.Append($" ,JB.{TbJob.JOB_TOT_COLORANT_WEIGHT_PERC_ERR_ADMITTED} ");
            sql.Append($" ,JB.{TbJob.JOB_TOT_GRAVIMETRIC_WEIGHT_EXPECTED} ");
            sql.Append($" ,JB.{TbJob.JOB_TOT_GRAVIMETRIC_WEIGHT_DETECTED} ");
            sql.Append($" ,JB.{TbJob.JOB_TOT_GRAVIMETRIC_WEIGHT_PERC_ERR_ADMITTED} ");
            sql.Append($" ,JB.{TbJob.JOB_MIXING} ");
            sql.Append($" ,JB.{TbJob.JOB_MIXING_TIME} ");
            sql.Append($" ,JB.{TbJob.JOB_MIXING_SPEED} ");
            sql.Append($" ,JB.{TbJob.JOB_CAPPING} ");
            sql.Append($" ,JB.{TbJob.JOB_LID_PLACING} ");
            sql.Append($" ,JB.{TbJob.JOB_LID_CHECK} ");
            sql.Append($" ,JB.{TbJob.JOB_PRINTING_1} ");
            sql.Append($" ,JB.{TbJob.JOB_PRINTING_2} ");
            sql.Append($" ,JB.{TbJob.JOB_PRINTING_3} ");
            sql.Append($" ,JB.{TbJob.JOB_EXIT_POSITION} ");
            sql.Append($" ,JB.{TbJob.JOB_TAG_1} ");
            sql.Append($" ,JB.{TbJob.JOB_TAG_2} ");
            sql.Append($" ,JB.{TbJob.JOB_TAG_3} ");
            sql.Append($" ,JB.{TbJob.JOB_TAG_4} ");
            sql.Append($" ,JB.{TbJob.JOB_TAG_5} ");
            sql.Append($" ,JB.{TbJob.JOB_ERR_1} ");
            sql.Append($" ,JB.{TbJob.JOB_ERR_2} ");
            sql.Append($" ,JB.{TbJob.JOB_ERR_3} ");
            sql.Append($" ,JB.{TbJob.JOB_ERR_4} ");
            sql.Append($" ,JB.{TbJob.JOB_ERR_5} ");
            sql.Append($"FROM {MAIN_TABLE} AS BC ");
            sql.Append($"LEFT JOIN {TbFormula.MAIN_TABLE} AS FM ON FM.{TbFormula.PRD_BARCODE} = BC.{BARCODE} AND FM.{TbFormula.PRD_PROCESS_CODE} = BC.{PROCESS_CODE} ");
            sql.Append($"LEFT JOIN {TbJob.MAIN_TABLE}     AS JB ON JB.{TbJob.JOB_BARCODE}     = BC.{BARCODE} AND JB.{TbJob.JOB_PROCESS_CODE}     = BC.{PROCESS_CODE} ");
            if (barCode != "" || processCode != "")
            {
                sql.Append($"WHERE BC.{BARCODE} ='{barCode}' AND BC.{PROCESS_CODE} ='{processCode}' ");
            }
            return sql.ToString();
        }

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
