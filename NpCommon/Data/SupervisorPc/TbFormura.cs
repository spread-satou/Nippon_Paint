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
    public class TbFormura
    {
        /// <summary>
        /// 缶のバーコード
        /// </summary>
        [DatabaseField("PRD_BARCODE")]
        public string PrdBarcode { get; set; }

        /// <summary>
        /// プロセスコード
        /// COROB が TB_BARCODE に書き込んだものにリンク
        /// </summary>
        [DatabaseField("PROCESS_CODE")]
        public string ProcessCode { get; set; }

        /// <summary>
        /// データベーステーブルに行を挿入した日時
        /// </summary>
        [DatabaseField("PRD_TIME_INSERTED")]
        public DateTime PrdTimeInserted { get; set; }

        /// <summary>
        /// ステータス
        /// 0：未吐出
        /// 1：吐出完了
        /// -1：吐出中にエラー中断
        /// </summary>
        [DatabaseField("PRD_STATUS")]
        public int PrdStatus { get; set; }

        /// <summary>
        /// 製品コード
        /// </summary>
        [DatabaseField("PRD_CODE")]
        public string PrdCode { get; set; }

        /// <summary>
        /// 製品名
        /// </summary>
        [DatabaseField("PRD_DESC")]
        public string PrdDesc { get; set; }

        /// <summary>
        /// 要求量と吐出量を表示する測定単位
        /// 1：グラム
        /// 2：cc
        /// </summary>
        [DatabaseField("UM")]
        public int Um { get; set; }

        /// <summary>
        /// 製品の比重
        /// </summary>
        [DatabaseField("PRD_SPECIFIC_GRAVITY")]
        public int PrdSpecificGravity { get; set; }

        /// <summary>
        /// 吐出要求量
        /// </summary>
        [DatabaseField("PRD_QTY_REQ")]
        public float PrdQtyReq { get; set; }

        /// <summary>
        /// 吐出された量
        /// </summary>
        [DatabaseField("PRD_QTY_DISP")]
        public float PrdQtyDisp { get; set; } = 0;

        /// <summary>
        /// 吐出開始日時
        /// </summary>
        [DatabaseField("PRD_START_DISP")]
        public DateTime PrdStartDisp { get; set; }

        /// <summary>
        /// 吐出終了日時
        /// </summary>
        [DatabaseField("PRD_END_DISP")]
        public DateTime PrdEndDisp { get; set; }

        /// <summary>
        /// 特別な機能
        /// </summary>
        [DatabaseField("PRD_PRIORITY")]
        public int PrdPriority { get; set; }

        /// <summary>
        /// 配合処方内の製品の累進番号
        /// </summary>
        [DatabaseField("PRD_NUM")]
        public int PrdNum { get; set; }

        /// <summary>
        /// 充填済製品が既に容器内に存在するかどうかを示す(充填缶製造のみ)
        /// 0：FALSE
        /// 1：TRUE
        /// </summary>
        [DatabaseField("PRD_ISPREFILLED")]
        public int PrdIsprefilled { get; set; }

        /// <summary>
        /// 容器内に既に存在する充填済製品のグラム単位数量を示す(充填缶製造のみ)
        /// </summary>
        [DatabaseField("PRD_PREFILLED_QTY")]
        public float PrdPrefilledQty { get; set; }
    }
}
