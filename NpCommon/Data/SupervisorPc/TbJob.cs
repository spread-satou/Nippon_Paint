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
    public class TbJob
    {
        /// <summary>
        /// 缶のバーコード
        /// </summary>
        [DatabaseField("JOB_BARCODE")]
        public string JobBarcode { get; set; }

        /// <summary>
        /// プロセスコード
        /// COROB が TB_BARCODE に書き込んだものにリンク
        /// </summary>
        [DatabaseField("PROCESS_CODE")]
        public string ProcessCode { get; set; }

        /// <summary>
        /// データベーステーブルに行を挿入した日時
        /// </summary>
        // 
        [DatabaseField("JOB_TIME_INSERTED")]
        public DateTime JobTimeInserted { get; set; }

        /// <summary>
        /// ステータス
        /// 0：テーブルに行挿入（ERP）
        /// 99：缶がライン上にある(COROB)
        /// 1：缶は良好にラインを終了(COROB)
        /// -1：缶はラインでエラー発生(COROB)
        /// </summary>
        [DatabaseField("JOB_STATUS")]
        public int JobStatus { get; set; }

        /// <summary>
        /// 理論上の風袋重量(グラム)
        /// </summary>
        [DatabaseField("JOB_TARE_WEIGHT_EXPECTED")]
        public float JobTareWeightExpected { get; set; }

        /// <summary>
        /// ラインで測定された缶の風袋重量(グラム)
        /// </summary>
        [DatabaseField("JOB_TARE_WEIGHT_DETECTED")]
        public float JobTareWeightDetected { get; set; }

        /// <summary>
        /// 缶の風袋を確認するために許容されるエラー％
        /// </summary>
        [DatabaseField("JOB_TARE_WEIGHT_PERC_ERR_ADMITTED")]
        public int JobTareWeightPercErrAdmitted { get; set; }

        /// <summary>
        /// 理論上の缶のグロス重量(グラム)
        /// </summary>
        [DatabaseField("JOB_GROSS_WEIGHT_EXPECTED")]
        public float JobGrossWeightExpected { get; set; }

        /// <summary>
        /// ラインで測定された缶のグロス重量(グラム)
        /// </summary>
        [DatabaseField("JOB_GROSS_WEIGHT_DETECTED")]
        public float JobGrossWeightDetected { get; set; }

        /// <summary>
        /// 缶のグロス重量を確認するために許容されるエラー％
        /// </summary>
        [DatabaseField("JOB_GROSS_WEIGHT_PERC_ERR_ADMITTED")]
        public int JobGrossWeightPercErrAdmitted { get; set; }

        /// <summary>
        /// 理論上の缶のネット重量(グラム)
        /// </summary>
        [DatabaseField("JOB_NET_WEIGHT_EXPECTED")]
        public float JobNetWeightExpected { get; set; }

        /// <summary>
        /// ラインで測定された缶のネット重量 (グラム)
        /// </summary>
        [DatabaseField("JOB_NET_WEIGHT_DETECTED")]
        public float JobNetWeightDetected { get; set; }

        /// <summary>
        /// 缶のネット重量を確認するために許容されるエラー％
        /// </summary>
        [DatabaseField("JOB_NET_WEIGHT_PERC_ERR_ADMITTED")]
        public int JobNetWeightPercErrAdmitted { get; set; }

        /// <summary>
        /// 吐出されたカララントの理論上の合計重量(グラム)
        /// </summary>
        [DatabaseField("JOB_TOT_COLORANT_WEIGHT_EXPECTED")]
        public float JobColorantWeightExpected { get; set; }

        /// <summary>
        /// ラインで吐出されたカララントの検知された合計重量(グラム)
        /// </summary>
        [DatabaseField("JOB_TOT_COLORANT_WEIGHT_DETECTED")]
        public float JobColorantWeightDetected { get; set; }

        /// <summary>
        /// 缶に吐出されたカララントの合計値を確認するために許容されるエラー％
        /// </summary>
        [DatabaseField("JOB_TOT_COLORANT_WEIGHT_PERC_ERR_ADMITTED")]
        public int JobColorantWeightPercErrAdmitted { get; set; }

        /// <summary>
        /// 吐出するベースの理論上の合計重量(グラム)
        /// </summary>
        [DatabaseField("JOB_TOT_GRAVIMETRIC_WEIGHT_EXPECTED")]
        public float JobGravimetricWeightExpected { get; set; }

        /// <summary>
        /// ラインで吐出されたベースの検知された合計重量（グラム）
        /// </summary>
        [DatabaseField("JOB_TOT_GRAVIMETRIC_WEIGHT_DETECTED")]
        public float JobGravimetricWeightDetected { get; set; }

        /// <summary>
        /// 缶に吐出するベースの合計重量を確認するために許容されるエラー％
        /// </summary>
        [DatabaseField("JOB_TOT_GRAVIMETRIC_WEIGHT_PERC_ERR_ADMITTED")]
        public int JobGravimetricWeightPercErrAdmitted { get; set; }

        /// <summary>
        /// 撹拌有無
        /// 0：操作なし
        /// 1：撹拌する
        /// </summary>
        [DatabaseField("JOB_MIXING")]
        public int JobMixing { get; set; }

        /// <summary>
        /// 撹拌時間（秒）
        /// </summary>
        [DatabaseField("JOB_MIXING_TIME")]
        public int JobMixingTime { get; set; }

        /// <summary>
        /// 撹拌スピード（％）
        /// </summary>
        [DatabaseField("JOB_MIXING_SPEED")]
        public int JobMixingSpeed { get; set; }

        /// <summary>
        /// キャップ要否
        /// 0：操作なし
        /// 1：キャップが必要な缶
        /// </summary>
        [DatabaseField("JOB_CAPPING")]
        public int JobCapping { get; set; }

        /// <summary>
        /// 蓋要否
        /// 0：操作なし
        /// 1：蓋が必要な缶
        /// </summary>
        [DatabaseField("JOB_LID_PLACING")]
        public int JobLidPlacing { get; set; }

        /// <summary>
        /// 蓋確認要否
        /// 0：操作なし
        /// 1：蓋確認を行う
        /// </summary>
        [DatabaseField("JOB_LID_CHECK")]
        public int JobLidCheck { get; set; }

        /// <summary>
        /// プリンタ使用有無(1)
        /// 0：操作なし
        /// 1：プリンターを使用
        /// </summary>
        [DatabaseField("JOB_PRINTING_1")]
        public int JobPrinting1 { get; set; }

        /// <summary>
        /// プリンタ使用有無(2)
        /// 0：操作なし
        /// 1：プリンターを使用
        /// </summary>
        [DatabaseField("JOB_PRINTING_2")]
        public int JobPrinting2 { get; set; }

        /// <summary>
        /// プリンタ使用有無(3)
        /// 0：操作なし
        /// 1：プリンターを使用
        /// </summary>
        [DatabaseField("JOB_PRINTING_3")]
        public int JobPrinting3 { get; set; }

        /// <summary>
        /// 缶出口
        /// 1：メインの出口
        /// 2：横の出口(テスト缶)
        /// </summary>
        [DatabaseField("JOB_EXIT_POSITION")]
        public int JobExitPosition { get; set; }

        /// <summary>
        /// タグ(1)
        /// </summary>
        [DatabaseField("JOB_TAG_1")]
        public int JobTag1 { get; set; }

        /// <summary>
        /// タグ(2)
        /// </summary>
        [DatabaseField("JOB_TAG_2")]
        public int JobTag2 { get; set; }

        /// <summary>
        /// タグ(3)
        /// </summary>
        [DatabaseField("JOB_TAG_3")]
        public int JobTag3 { get; set; }

        /// <summary>
        /// タグ(4)
        /// </summary>
        [DatabaseField("JOB_TAG_4")]
        public int JobTag4 { get; set; }

        /// <summary>
        /// タグ(5)
        /// </summary>
        [DatabaseField("JOB_TAG_5")]
        public int JobTag5 { get; set; }

        /// <summary>
        /// COROBエラー情報(1)
        /// </summary>
        [DatabaseField("JOB_ERR_1")]
        public int JobErr1 { get; set; }

        /// <summary>
        /// COROBエラー情報(2)
        /// </summary>
        [DatabaseField("JOB_ERR_2")]
        public int JobErr2 { get; set; }

        /// <summary>
        /// COROBエラー情報(3)
        /// </summary>
        [DatabaseField("JOB_ERR_3")]
        public int JobErr3 { get; set; }

        /// <summary>
        /// COROBエラー情報(4)
        /// </summary>
        [DatabaseField("JOB_ERR_4")]
        public int JobErr4 { get; set; }

        /// <summary>
        /// COROBエラー情報(5)
        /// </summary>
        [DatabaseField("JOB_ERR_5")]
        public int JobErr5 { get; set; }
    }
}
