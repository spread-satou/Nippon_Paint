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
using NipponPaint.NpCommon.Attributes;
#endregion

namespace NipponPaint.NpCommon.Data.SupervisorPc
{
    /// <summary>
    /// TB_BARCODE
    /// </summary>
    public class TbBarcode
    {
        /// <summary>
        /// 缶のバーコード
        /// </summary>
        [DatabaseField("BARCODE")]
        public string Barcode { get; set; }

        /// <summary>
        /// プロセスコード
        /// </summary>

        [DatabaseField("PROCESS_CODE")]
        public string ProcessCode { get; set; }

        /// <summary>
        /// データベーステーブルに行を挿入した日時
        /// </summary>
        [DatabaseField("BRC_TIME_INSERTED")]
        public DateTime BrcTimeInserted { get; set; }

        /// <summary>
        /// ERP がデータを処理した時の日時
        /// </summary>
        [DatabaseField("BRC_TIME_PROCESSED")]
        public DateTime BrcTimeProcessed { get; set; }

        /// <summary>
        /// ステータス
        /// 0：COROB が挿入した行
        /// 1：顧客 ERP により処理されたライン
        /// </summary>
        [DatabaseField("BRC_STATUS")]
        public int BrcStatus { get; set; }

        /// <summary>
        /// エラー情報(1)
        /// </summary>
        [DatabaseField("BRC_ERR_1")]
        public string BrcErr1 { get; set; }

        /// <summary>
        /// エラー情報(2)
        /// </summary>
        [DatabaseField("BRC_ERR_2")]
        public string BrcErr2 { get; set; }

        /// <summary>
        /// エラー情報(3)
        /// </summary>
        [DatabaseField("BRC_ERR_3")]
        public string BrcErr3 { get; set; }
    }
}
