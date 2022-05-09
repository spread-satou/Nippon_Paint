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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NipponPaint.NpCommon;
using NipponPaint.NpCommon.Settings;
using NipponPaint.NpCommon.Database;
using NipponPaint.NpCommon.Database.Sql.SupervisorPc;
#endregion

namespace SupervisorIfSim.Dialogs
{
    public partial class FrmEdit : BaseForm
    {
        #region メンバ変数
        List<Data.TextBoxItem> _headerTextBoxList;
        List<Data.TextBoxItem> _barcodeTextBoxList;
        List<Data.TextBoxItem> _FormulaTextBoxList;
        List<Data.TextBoxItem> _jobTextBoxList;
        #endregion

        #region 定数
        // BRC_STATUSラジオボタン
        private const int BRD_STATUS_COROB = 0;
        private const int BRD_STATUS_ERP = 1;
        // PRD_STATUSラジオボタン
        private const int PRD_STATUS_UNDISCHARGED = 0;
        private const int PRD_STATUS_COMPLATED = 1;
        private const int PRD_STATUS_ERROR = -1;
        // PRD_UMラジオボタン
        private const int PRD_UM_GRAM = 1;
        private const int PRD_UM_CC = 2;
        // YES/NOのラジオボタン
        private const int JOB_NO = 0;
        private const int JOB_YES = 1;
        // JOB_EXIT_POSITIONラジオボタン
        private const int JOB_EXIT_POSITION_MAIN = 1;
        private const int JOB_EXIT_POSITION_TEST = 2;
        private static List<Data.DropDownRow> DrpJobStatusDefines = new List<Data.DropDownRow>()
        {
            { new Data.DropDownRow() { Value = 0, Text = "ライン挿入" } },
            { new Data.DropDownRow() { Value = 1, Text = "缶は良好にライン終了" } },
            { new Data.DropDownRow() { Value = 99, Text = "缶がライン上に存在" } },
            { new Data.DropDownRow() { Value = -1, Text = "缶はラインでエラー発生" } },
        };
        public enum DialogMode
        {
            Merge,
            Update,
        }
        public enum SaveMode
        {
            All,
            Barcode,
            Formula,
            Job
        }
        #endregion

        #region プロパティ
        #region BRC_STATUSラジオボタン
        /// <summary>
        /// BRC_STATUSラジオボタン
        /// </summary>
        private int RdbBrcStatus
        {
            get
            {
                if (RdbBrcStatusCorob.Checked)
                {
                    return BRD_STATUS_COROB;
                }
                if (RdbBrcStatusErp.Checked)
                {
                    return BRD_STATUS_ERP;
                }
                return 0;
            }
            set
            {

                RdbBrcStatusCorob.Checked = false;
                RdbBrcStatusErp.Checked = false;
                RdbBrcStatusCorob.ForeColor = Color.Black;
                RdbBrcStatusErp.ForeColor = Color.Black;
                Color color = Color.Black;
                if (PnlBrcStatus.Tag != null && PnlBrcStatus.Tag.ToString() != value.ToString())
                {
                    color = Color.Red;
                }
                switch (value)
                {
                    case BRD_STATUS_COROB:
                        RdbBrcStatusCorob.Checked = true;
                        RdbBrcStatusCorob.ForeColor = color;
                        break;
                    case BRD_STATUS_ERP:
                        RdbBrcStatusErp.Checked = true;
                        RdbBrcStatusErp.ForeColor = color;
                        break;
                    default:
                        break;
                }
                PnlBrcStatus.Tag = value.ToString();
            }
        }
        #endregion
        #region PRD_STATUSラジオボタン
        /// <summary>
        /// PRD_STATUSラジオボタン
        /// </summary>
        private int RdbPrdStatus
        {
            get
            {
                if (RdbPrdStatusUndischarged.Checked)
                {
                    return PRD_STATUS_UNDISCHARGED;
                }
                if (RdbPrdStatusCompleted.Checked)
                {
                    return PRD_STATUS_COMPLATED;
                }
                if (RdbPrdStatusError.Checked)
                {
                    return PRD_STATUS_ERROR;
                }
                return 0;
            }
            set
            {
                RdbPrdStatusUndischarged.Checked = false;
                RdbPrdStatusCompleted.Checked = false;
                RdbPrdStatusError.Checked = false;
                RdbPrdStatusUndischarged.ForeColor = Color.Black;
                RdbPrdStatusCompleted.ForeColor = Color.Black;
                RdbPrdStatusError.ForeColor = Color.Black;
                Color color = Color.Black;
                if (PnlPrdStatus.Tag != null && PnlPrdStatus.Tag.ToString() != value.ToString())
                {
                    color = Color.Red;
                }
                switch (value)
                {
                    case PRD_STATUS_UNDISCHARGED:
                        RdbPrdStatusUndischarged.Checked = true;
                        RdbPrdStatusUndischarged.ForeColor = color;
                        break;
                    case PRD_STATUS_COMPLATED:
                        RdbPrdStatusCompleted.Checked = true;
                        RdbPrdStatusCompleted.ForeColor = color;
                        break;
                    case PRD_STATUS_ERROR:
                        RdbPrdStatusError.Checked = true;
                        RdbPrdStatusError.ForeColor = color;
                        break;
                    default:
                        break;
                }
                PnlPrdStatus.Tag = value.ToString();
            }
        }
        #endregion
        #region PRD_UMラジオボタン
        /// <summary>
        /// PRD_UMラジオボタン
        /// </summary>
        private int RdbPrdUm
        {
            get
            {
                if (RdbPrdUmGram.Checked)
                {
                    return PRD_UM_GRAM;
                }
                if (RdbPrdUmCc.Checked)
                {
                    return PRD_UM_CC;
                }
                return 0;
            }
            set
            {
                RdbPrdUmGram.Checked = false;
                RdbPrdUmCc.Checked = false;
                RdbPrdUmGram.ForeColor = Color.Black;
                RdbPrdUmCc.ForeColor = Color.Black;
                Color color = Color.Black;
                if (PnlPrdUm.Tag != null && PnlPrdUm.Tag.ToString() != value.ToString())
                {
                    color = Color.Red;
                }
                switch (value)
                {
                    case PRD_UM_GRAM:
                        RdbPrdUmGram.Checked = true;
                        RdbPrdUmGram.ForeColor = color;
                        break;
                    case PRD_UM_CC:
                        RdbPrdUmCc.Checked = true;
                        RdbPrdUmCc.ForeColor = color;
                        break;
                    default:
                        break;
                }
                PnlPrdUm.Tag = value.ToString();
            }
        }
        #endregion
        #region PRD_ISPREFILLEDラジオボタン
        /// <summary>
        /// PRD_ISPREFILLEDラジオボタン
        /// </summary>
        private bool RdbPrdIsprefilled
        {
            get
            {
                if (RdbPrdIsprefilledTrue.Checked)
                {
                    return true;
                }
                if (RdbPrdIsprefilledFalse.Checked)
                {
                    return false;
                }
                return true;
            }
            set
            {
                RdbPrdIsprefilledTrue.Checked = false;
                RdbPrdIsprefilledFalse.Checked = false;
                RdbPrdIsprefilledTrue.ForeColor = Color.Black;
                RdbPrdIsprefilledFalse.ForeColor = Color.Black;
                Color color = Color.Black;
                if (PnlPrdIsprefilled.Tag != null && PnlPrdIsprefilled.Tag.ToString() != value.ToString())
                {
                    color = Color.Red;
                }
                switch (value)
                {
                    case true:
                        RdbPrdIsprefilledTrue.Checked = true;
                        RdbPrdIsprefilledTrue.ForeColor = color;
                        break;
                    case false:
                        RdbPrdIsprefilledFalse.Checked = true;
                        RdbPrdIsprefilledFalse.ForeColor = color;
                        break;
                    default:
                        break;
                }
                PnlPrdIsprefilled.Tag = value.ToString();
            }
        }
        #endregion
        #region JOB_MIXINGラジオボタン
        /// <summary>
        /// JOB_MIXINGラジオボタン
        /// </summary>
        private int RdbJobMixing
        {
            get
            {
                if (RdbJobMixingYes.Checked)
                {
                    return JOB_YES;
                }
                if (RdbJobMixingNo.Checked)
                {
                    return JOB_NO;
                }
                return JOB_NO;
            }
            set
            {
                RdbJobMixingYes.Checked = false;
                RdbJobMixingNo.Checked = false;
                RdbJobMixingYes.ForeColor = Color.Black;
                RdbJobMixingNo.ForeColor = Color.Black;
                Color color = Color.Black;
                if (PnlJobMixing.Tag != null && PnlJobMixing.Tag.ToString() != value.ToString())
                {
                    color = Color.Red;
                }
                switch (value)
                {
                    case JOB_YES:
                        RdbJobMixingYes.Checked = true;
                        RdbJobMixingYes.ForeColor = color;
                        break;
                    case JOB_NO:
                        RdbJobMixingNo.Checked = true;
                        RdbJobMixingNo.ForeColor = color;
                        break;
                    default:
                        break;
                }
                PnlJobMixing.Tag = value.ToString();
            }
        }
        #endregion
        #region JOB_CAPPINGラジオボタン
        /// <summary>
        /// JOB_CAPPINGラジオボタン
        /// </summary>
        private int RdbJobCapping
        {
            get
            {
                if (RdbJobCappingYes.Checked)
                {
                    return JOB_YES;
                }
                if (RdbJobCappingNo.Checked)
                {
                    return JOB_NO;
                }
                return JOB_NO;
            }
            set
            {
                RdbJobCappingYes.Checked = false;
                RdbJobCappingNo.Checked = false;
                RdbJobCappingYes.ForeColor = Color.Black;
                RdbJobCappingNo.ForeColor = Color.Black;
                Color color = Color.Black;
                if (PnlJobCapping.Tag != null && PnlJobCapping.Tag.ToString() != value.ToString())
                {
                    color = Color.Red;
                }
                switch (value)
                {
                    case JOB_YES:
                        RdbJobCappingYes.Checked = true;
                        RdbJobCappingYes.ForeColor = color;
                        break;
                    case JOB_NO:
                        RdbJobCappingNo.Checked = true;
                        RdbJobCappingNo.ForeColor = color;
                        break;
                    default:
                        break;
                }
                PnlJobCapping.Tag = value.ToString();
            }
        }
        #endregion
        #region JOB_LID_PLACINGラジオボタン
        /// <summary>
        /// JOB_LID_PLACINGラジオボタン
        /// </summary>
        private int RdbJobLidPlacing
        {
            get
            {
                if (RdbJobLidPlacingYes.Checked)
                {
                    return JOB_YES;
                }
                if (RdbJobLidPlacingNo.Checked)
                {
                    return JOB_NO;
                }
                return JOB_NO;
            }
            set
            {
                RdbJobLidPlacingYes.Checked = false;
                RdbJobLidPlacingNo.Checked = false;
                RdbJobLidPlacingYes.ForeColor = Color.Black;
                RdbJobLidPlacingNo.ForeColor = Color.Black;
                Color color = Color.Black;
                if (PnlJobLidPlacing.Tag != null && PnlJobLidPlacing.Tag.ToString() != value.ToString())
                {
                    color = Color.Red;
                }
                switch (value)
                {
                    case JOB_YES:
                        RdbJobLidPlacingYes.Checked = true;
                        RdbJobLidPlacingYes.ForeColor = color;
                        break;
                    case JOB_NO:
                        RdbJobLidPlacingNo.Checked = true;
                        RdbJobLidPlacingNo.ForeColor = color;
                        break;
                    default:
                        break;
                }
                PnlJobLidPlacing.Tag = value.ToString();
            }
        }
        #endregion
        #region JOB_LID_CHECKラジオボタン
        /// <summary>
        /// JOB_LID_CHECKラジオボタン
        /// </summary>
        private int RdbJobLidCheck
        {
            get
            {
                if (RdbJobLidCheckYes.Checked)
                {
                    return JOB_YES;
                }
                if (RdbJobLidCheckNo.Checked)
                {
                    return JOB_NO;
                }
                return JOB_NO;
            }
            set
            {
                RdbJobLidCheckYes.Checked = false;
                RdbJobLidCheckNo.Checked = false;
                RdbJobLidCheckYes.ForeColor = Color.Black;
                RdbJobLidCheckNo.ForeColor = Color.Black;
                Color color = Color.Black;
                if (PnlJobLidCheck.Tag != null && PnlJobLidCheck.Tag.ToString() != value.ToString())
                {
                    color = Color.Red;
                }
                switch (value)
                {
                    case JOB_YES:
                        RdbJobLidCheckYes.Checked = true;
                        RdbJobLidCheckYes.ForeColor = color;
                        break;
                    case JOB_NO:
                        RdbJobLidCheckNo.Checked = true;
                        RdbJobLidCheckNo.ForeColor = color;
                        break;
                    default:
                        break;
                }
                PnlJobLidCheck.Tag = value.ToString();
            }
        }
        #endregion
        #region JOB_PRINTING_1ラジオボタン
        /// <summary>
        /// JOB_PRINTING_1ラジオボタン
        /// </summary>
        private int RdbJobPrinting1
        {
            get
            {
                if (RdbJobPrinting1Yes.Checked)
                {
                    return JOB_YES;
                }
                if (RdbJobPrinting1No.Checked)
                {
                    return JOB_NO;
                }
                return JOB_NO;
            }
            set
            {
                RdbJobPrinting1Yes.Checked = false;
                RdbJobPrinting1No.Checked = false;
                RdbJobPrinting1Yes.ForeColor = Color.Black;
                RdbJobPrinting1No.ForeColor = Color.Black;
                Color color = Color.Black;
                if (PnlJobPrinting1.Tag != null && PnlJobPrinting1.Tag.ToString() != value.ToString())
                {
                    color = Color.Red;
                }
                switch (value)
                {
                    case JOB_YES:
                        RdbJobPrinting1Yes.Checked = true;
                        RdbJobPrinting1Yes.ForeColor = color;
                        break;
                    case JOB_NO:
                        RdbJobPrinting1No.Checked = true;
                        RdbJobPrinting1No.ForeColor = color;
                        break;
                    default:
                        break;
                }
                PnlJobPrinting1.Tag = value.ToString();
            }
        }
        #endregion
        #region JOB_PRINTING_2ラジオボタン
        /// <summary>
        /// JOB_PRINTING_2ラジオボタン
        /// </summary>
        private int RdbJobPrinting2
        {
            get
            {
                if (RdbJobPrinting2Yes.Checked)
                {
                    return JOB_YES;
                }
                if (RdbJobPrinting2No.Checked)
                {
                    return JOB_NO;
                }
                return JOB_NO;
            }
            set
            {
                RdbJobPrinting2Yes.Checked = false;
                RdbJobPrinting2No.Checked = false;
                RdbJobPrinting2Yes.ForeColor = Color.Black;
                RdbJobPrinting2No.ForeColor = Color.Black;
                Color color = Color.Black;
                if (PnlJobPrinting2.Tag != null && PnlJobPrinting2.Tag.ToString() != value.ToString())
                {
                    color = Color.Red;
                }
                switch (value)
                {
                    case JOB_YES:
                        RdbJobPrinting2Yes.Checked = true;
                        RdbJobPrinting2Yes.ForeColor = color;
                        break;
                    case JOB_NO:
                        RdbJobPrinting2No.Checked = true;
                        RdbJobPrinting2No.ForeColor = color;
                        break;
                    default:
                        break;
                }
                PnlJobPrinting2.Tag = value.ToString();
            }
        }
        #endregion
        #region JOB_PRINTING_3ラジオボタン
        /// <summary>
        /// JOB_PRINTING_3ラジオボタン
        /// </summary>
        private int RdbJobPrinting3
        {
            get
            {
                if (RdbJobPrinting3Yes.Checked)
                {
                    return JOB_YES;
                }
                if (RdbJobPrinting3No.Checked)
                {
                    return JOB_NO;
                }
                return JOB_NO;
            }
            set
            {
                RdbJobPrinting3Yes.Checked = false;
                RdbJobPrinting3No.Checked = false;
                RdbJobPrinting3Yes.ForeColor = Color.Black;
                RdbJobPrinting3No.ForeColor = Color.Black;
                Color color = Color.Black;
                if (PnlJobPrinting3.Tag != null && PnlJobPrinting3.Tag.ToString() != value.ToString())
                {
                    color = Color.Red;
                }
                switch (value)
                {
                    case JOB_YES:
                        RdbJobPrinting3Yes.Checked = true;
                        RdbJobPrinting3Yes.ForeColor = color;
                        break;
                    case JOB_NO:
                        RdbJobPrinting3No.Checked = true;
                        RdbJobPrinting3No.ForeColor = color;
                        break;
                    default:
                        break;
                }
                PnlJobPrinting3.Tag = value.ToString();
            }
        }
        #endregion
        #region JOB_EXIT_POSITIONラジオボタン
        /// <summary>
        /// JOB_EXIT_POSITIONラジオボタン
        /// </summary>
        private int RdbJobExitPosition
        {
            get
            {
                if (RdbJobExitPositionMain.Checked)
                {
                    return JOB_EXIT_POSITION_MAIN;
                }
                if (RdbJobExitPositionTest.Checked)
                {
                    return JOB_EXIT_POSITION_TEST;
                }
                return JOB_EXIT_POSITION_MAIN;
            }
            set
            {
                RdbJobExitPositionMain.Checked = false;
                RdbJobExitPositionTest.Checked = false;
                RdbJobExitPositionMain.ForeColor = Color.Black;
                RdbJobExitPositionTest.ForeColor = Color.Black;
                Color color = Color.Black;
                if (PnlJobExitPosition.Tag != null && PnlJobExitPosition.Tag.ToString() != value.ToString())
                {
                    color = Color.Red;
                }
                switch (value)
                {
                    case JOB_EXIT_POSITION_MAIN:
                        RdbJobExitPositionMain.Checked = true;
                        RdbJobExitPositionMain.ForeColor = color;
                        break;
                    case JOB_EXIT_POSITION_TEST:
                        RdbJobExitPositionTest.Checked = true;
                        RdbJobExitPositionTest.ForeColor = color;
                        break;
                    default:
                        break;
                }
                PnlJobExitPosition.Tag = value.ToString();
            }
        }
        #endregion
        #endregion

        #region コンストラクタ
        public FrmEdit(string barCode, string processCode, DialogMode mode)
        {
            InitializeComponent();
            _headerTextBoxList = new List<Data.TextBoxItem>()
            {
                { new Data.TextBoxItem() { TextBox = TxtBarcode, FieldName = TbBarcode.BARCODE, FieldType = typeof(string) } },
                { new Data.TextBoxItem() { TextBox = TxtProcessCode, FieldName = TbBarcode.PROCESS_CODE, FieldType = typeof(int)} },
            };
            _barcodeTextBoxList = new List<Data.TextBoxItem>() {
                { new Data.TextBoxItem() { TextBox = TxtBrcTimeInserted, FieldName = TbBarcode.BRC_TIME_INSERTED, FieldType = typeof(DateTime) } },
                { new Data.TextBoxItem() { TextBox = TxtBrcTimeProcessed, FieldName = TbBarcode.BRC_TIME_PROCESSED, FieldType = typeof(DateTime) } },
                { new Data.TextBoxItem() { TextBox = TxtBrcErr1, FieldName = TbBarcode.BRC_ERR_1, FieldType = typeof(string) } },
                { new Data.TextBoxItem() { TextBox = TxtBrcErr2, FieldName = TbBarcode.BRC_ERR_2, FieldType = typeof(string) } },
                { new Data.TextBoxItem() { TextBox = TxtBrcErr3, FieldName = TbBarcode.BRC_ERR_3, FieldType = typeof(string) } },
            };
            _FormulaTextBoxList = new List<Data.TextBoxItem>()
            {
                { new Data.TextBoxItem() { TextBox = TxtPrdTimeInserted, FieldName = "PRD_TIME_INSERTED", FieldType = typeof(DateTime) } },
                { new Data.TextBoxItem() { TextBox = TxtPrdCode, FieldName = "PRD_CODE", FieldType = typeof(string) } },
                { new Data.TextBoxItem() { TextBox = TxtPrdDesc, FieldName = "PRD_DESC", FieldType = typeof(string) } },
                { new Data.TextBoxItem() { TextBox = TxtPrdSpecificGravity, FieldName = "PRD_SPECIFIC_GRAVITY", FieldType = typeof(string) } },
                { new Data.TextBoxItem() { TextBox = TxtPrdQtyReq, FieldName = "PRD_QTY_REQ", FieldType = typeof(float) } },
                { new Data.TextBoxItem() { TextBox = TxtPrdQtyDisp, FieldName = "PRD_QTY_DISP", FieldType = typeof(float) } },
                { new Data.TextBoxItem() { TextBox = TxtPrdStartDisp, FieldName = "PRD_START_DISP", FieldType = typeof(DateTime) } },
                { new Data.TextBoxItem() { TextBox = TxtPrdEndDisp, FieldName = "PRD_END_DISP", FieldType = typeof(DateTime) } },
                { new Data.TextBoxItem() { TextBox = TxtPrdPriority, FieldName = "PRD_PRIORITY", FieldType = typeof(int) } },
                { new Data.TextBoxItem() { TextBox = TxtPrdNum, FieldName = "PRD_NUM", FieldType = typeof(int) } },
                { new Data.TextBoxItem() { TextBox = TxtPrdPrefilledQty, FieldName = "PRD_PREFILLED_QTY", FieldType = typeof(float) } },
            };
            _jobTextBoxList = new List<Data.TextBoxItem>()
            {
                { new Data.TextBoxItem() { TextBox = TxtJobTimeInserted, FieldName = "JOB_TIME_INSERTED", FieldType = typeof(DateTime) } },
                { new Data.TextBoxItem() { TextBox = TxtJobTareWeightExpected, FieldName = "JOB_TARE_WEIGHT_EXPECTED", FieldType = typeof(float) } },
                { new Data.TextBoxItem() { TextBox = TxtJobTareWeightDetected, FieldName = "JOB_TARE_WEIGHT_DETECTED", FieldType = typeof(float) } },
                { new Data.TextBoxItem() { TextBox = TxtJobTareWeightPercErrAdmitted, FieldName = "JOB_TARE_WEIGHT_PERC_ERR_ADMITTED", FieldType = typeof(int) } },
                { new Data.TextBoxItem() { TextBox = TxtJobGrossWeightExpected, FieldName = "JOB_GROSS_WEIGHT_EXPECTED", FieldType = typeof(float) } },
                { new Data.TextBoxItem() { TextBox = TxtJobGrossWeightDetected, FieldName = "JOB_GROSS_WEIGHT_DETECTED", FieldType = typeof(float) } },
                { new Data.TextBoxItem() { TextBox = TxtJobGrossWeightPercErrAdmitted, FieldName = "JOB_GROSS_WEIGHT_PERC_ERR_ADMITTED", FieldType = typeof(int) } },
                { new Data.TextBoxItem() { TextBox = TxtJobNetWeightExpected, FieldName = "JOB_NET_WEIGHT_EXPECTED", FieldType = typeof(float) } },
                { new Data.TextBoxItem() { TextBox = TxtJobNetWeightDetected, FieldName = "JOB_NET_WEIGHT_DETECTED", FieldType = typeof(float) } },
                { new Data.TextBoxItem() { TextBox = TxtJobNetWeightPercErrAdmitted, FieldName = "JOB_NET_WEIGHT_PERC_ERR_ADMITTED", FieldType = typeof(int) } },
                { new Data.TextBoxItem() { TextBox = TxtJobTotColorantWeightExpected, FieldName = "JOB_TOT_COLORANT_WEIGHT_EXPECTED", FieldType = typeof(float) } },
                { new Data.TextBoxItem() { TextBox = TxtJobTotColorantWeightDetected, FieldName = "JOB_TOT_COLORANT_WEIGHT_DETECTED", FieldType = typeof(float) } },
                { new Data.TextBoxItem() { TextBox = TxtJobTotColorantWeightPercErrAdmitted, FieldName = "JOB_TOT_COLORANT_WEIGHT_PERC_ERR_ADMITTED", FieldType = typeof(int) } },
                { new Data.TextBoxItem() { TextBox = TxtJobTotGravimetricWeightExpected, FieldName = "JOB_TOT_GRAVIMETRIC_WEIGHT_EXPECTED", FieldType = typeof(float) } },
                { new Data.TextBoxItem() { TextBox = TxtJobTotGravimetricWeightDetected, FieldName = "JOB_TOT_GRAVIMETRIC_WEIGHT_DETECTED", FieldType = typeof(float) } },
                { new Data.TextBoxItem() { TextBox = TxtJobTotGravimetricWeightPercErrAdmitted, FieldName = "JOB_TOT_GRAVIMETRIC_WEIGHT_PERC_ERR_ADMITTED", FieldType = typeof(int) } },
                { new Data.TextBoxItem() { TextBox = TxtJobMixingTime, FieldName = "JOB_MIXING_TIME", FieldType = typeof(int) } },
                { new Data.TextBoxItem() { TextBox = TxtJobMixingSpeed, FieldName = "JOB_MIXING_SPEED", FieldType = typeof(int) } },
                { new Data.TextBoxItem() { TextBox = TxtJobTag1, FieldName = "JOB_TAG_1", FieldType = typeof(int) } },
                { new Data.TextBoxItem() { TextBox = TxtJobTag2, FieldName = "JOB_TAG_2", FieldType = typeof(int) } },
                { new Data.TextBoxItem() { TextBox = TxtJobTag3, FieldName = "JOB_TAG_3", FieldType = typeof(int) } },
                { new Data.TextBoxItem() { TextBox = TxtJobTag4, FieldName = "JOB_TAG_4", FieldType = typeof(int) } },
                { new Data.TextBoxItem() { TextBox = TxtJobTag5, FieldName = "JOB_TAG_5", FieldType = typeof(int) } },
                { new Data.TextBoxItem() { TextBox = TxtJobErr1, FieldName = "JOB_ERR_1", FieldType = typeof(string) } },
                { new Data.TextBoxItem() { TextBox = TxtJobErr2, FieldName = "JOB_ERR_2", FieldType = typeof(string) } },
                { new Data.TextBoxItem() { TextBox = TxtJobErr3, FieldName = "JOB_ERR_3", FieldType = typeof(string) } },
                { new Data.TextBoxItem() { TextBox = TxtJobErr4, FieldName = "JOB_ERR_4", FieldType = typeof(string) } },
                { new Data.TextBoxItem() { TextBox = TxtJobErr5, FieldName = "JOB_ERR_5", FieldType = typeof(string) } },
            };
            InitializeForm(barCode, processCode);
            switch (mode)
            {
                case DialogMode.Update:
                    TxtBarcode.Enabled = false;
                    TxtProcessCode.Enabled = false;
                    break;
            }
        }
        #endregion

        #region イベント

        /// <summary>
        /// ボタン押下時のショートカット動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.F2:
                        // TB_BARCODE
                        BtnSaveBarcode.PerformClick();
                        break;
                    case Keys.F3:
                        // TB_FORMULA
                        BtnSaveFormula.PerformClick();
                        break;
                    case Keys.F4:
                        // TB_JOB
                        BtnSaveJob.PerformClick();
                        break;
                    case Keys.F8:
                        // すべて
                        BtnSaveAll.PerformClick();
                        break;
                }
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }

        #region すべて更新
        /// <summary>
        /// すべて更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSaveAll_Click(object sender, EventArgs e)
        {
            using (var db = new SqlBase(SqlBase.DatabaseKind.SUPERVISION, SqlBase.TransactionUse.Yes, Log.ApplicationType.SupervisorInterfaceSim))
            {
                try
                {
                    if (Save(SaveMode.All, db))
                    {
                        db.Commit();
                        this.Close();
                    }
                    else
                    {
                        db.Rollback();
                    }
                }
                catch (Exception ex)
                {
                    db.Rollback();
                    PutLog(ex, true);
                }
            }
        }
        #endregion

        #region TB_BARCODE更新
        /// <summary>
        /// TB_BARCODE更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSaveBarcode_Click(object sender, EventArgs e)
        {
            using (var db = new SqlBase(SqlBase.DatabaseKind.SUPERVISION, SqlBase.TransactionUse.Yes, Log.ApplicationType.SupervisorInterfaceSim))
            {
                try
                {
                    if (Save(SaveMode.Barcode, db))
                    {
                        db.Commit();
                        this.Close();
                    }
                    else
                    {
                        db.Rollback();
                    }
                }
                catch (Exception ex)
                {
                    db.Rollback();
                    PutLog(ex, true);
                }
            }
        }
        #endregion

        #region TB_FORMULA更新
        /// <summary>
        /// TB_FORMULA更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSaveFormula_Click(object sender, EventArgs e)
        {
            using (var db = new SqlBase(SqlBase.DatabaseKind.SUPERVISION, SqlBase.TransactionUse.Yes, Log.ApplicationType.SupervisorInterfaceSim))
            {
                try
                {
                    if (Save(SaveMode.Formula, db))
                    {
                        db.Commit();
                        this.Close();
                    }
                    else
                    {
                        db.Rollback();
                    }
                }
                catch (Exception ex)
                {
                    db.Rollback();
                    PutLog(ex, true);
                }
            }
        }
        #endregion

        #region TB_JOB更新
        /// <summary>
        /// TB_JOB更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSaveJob_Click(object sender, EventArgs e)
        {
            using (var db = new SqlBase(SqlBase.DatabaseKind.SUPERVISION, SqlBase.TransactionUse.Yes, Log.ApplicationType.SupervisorInterfaceSim))
            {
                try
                {
                    if (Save(SaveMode.Job, db))
                    {
                        db.Commit();
                        this.Close();
                    }
                    else
                    {
                        db.Rollback();
                    }
                }
                catch (Exception ex)
                {
                    db.Rollback();
                    PutLog(ex, true);
                }
            }
        }
        #endregion
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnTimer_Click(object sender, EventArgs e)
        {
            try
            {
                TimerReset(!TimerPreview.Enabled);
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                PreviewData(TxtBarcode.Text, TxtProcessCode.Text);
                PutLog(Sentence.Messages.PreviewData, ((Button)sender).Text);
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerPreview_Tick(object sender, EventArgs e)
        {
            try
            {
                PreviewData(TxtBarcode.Text, TxtProcessCode.Text);
                PutLog(Sentence.Messages.PreviewData, ((Button)sender).Text);
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }

        #endregion

        #region private functions

        #region ダイアログ初期化
        /// <summary>
        /// ダイアログ初期化
        /// </summary>
        /// <param name="barCode"></param>
        /// <param name="processCode"></param>
        private void InitializeForm(string barCode, string processCode)
        {
            //this.Shown += new EventHandler(this.FrmMainShown);
            //this.BtnEdit.Click += new EventHandler(this.BtnEdit_Click);
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(this.FormKeyDown);
            this.BtnSaveAll.Click += new EventHandler(this.BtnSaveAll_Click);
            this.BtnSaveBarcode.Click += new System.EventHandler(this.BtnSaveBarcode_Click);
            this.BtnSaveFormula.Click += new System.EventHandler(this.BtnSaveFormula_Click);
            this.BtnSaveJob.Click += new System.EventHandler(this.BtnSaveJob_Click);
            this.BtnTimer.Click += new EventHandler(this.BtnTimer_Click);
            this.BtnPreview.Click += new EventHandler(this.BtnPreview_Click);
            this.TimerPreview.Tick += new EventHandler(this.TimerPreview_Tick);
            // ドロップダウン要素の生成
            CreateDropDownItems();
            // タイマーの周期を設定
            TimerPreview.Interval = int.Parse(LblCycle.Text) * 1000;
            // データ表示
            PreviewData(barCode, processCode);
        }
        #endregion

        #region ドロップダウンの要素を生成する
        /// <summary>
        /// ドロップダウンの要素を生成する
        /// </summary>
        private void CreateDropDownItems()
        {
            var list = new DataTable();
            list.Columns.Add(nameof(Data.DropDownRow.Value), typeof(int));
            list.Columns.Add(nameof(Data.DropDownRow.Text), typeof(string));
            foreach (var item in DrpJobStatusDefines)
            {
                var row = list.NewRow();
                row[nameof(Data.DropDownRow.Value)] = item.Value;
                row[nameof(Data.DropDownRow.Text)] = item.Text;
                list.Rows.Add(row);
            }
            DrpJobStatus.DataSource = list;
            DrpJobStatus.ValueMember = nameof(Data.DropDownRow.Value);
            DrpJobStatus.DisplayMember = nameof(Data.DropDownRow.Text);
        }
        #endregion

        #region TB_BARCODEの更新
        /// <summary>
        /// TB_BARCODEの更新
        /// </summary>
        /// <param name="db"></param>
        private void SaveBarcode(SqlBase db, DateTime entryTime)
        {
            //
            // SQL文生成＋SQLパラメータ作成
            //
            string sql = TbBarcode.Merge(out List<ParameterItem> parameters, entryTime);
            // キー
            SetParameter(parameters, TbBarcode.BARCODE, TxtBarcode.Text);
            SetParameter(parameters, TbBarcode.PROCESS_CODE, TxtProcessCode.Text);
            // テキストボックス
            foreach (var item in _barcodeTextBoxList)
            {
                SetParameter(parameters, item.FieldName, item.TextBox.Text, item.FieldType, entryTime);
            }
            // ラジオボタン
            SetParameter(parameters, TbBarcode.BRC_STATUS, RdbBrcStatus);
            //
            // 更新実行
            //
            db.Execute(sql, parameters);
        }
        #endregion

        #region TB_BARCODEの更新
        // TB_BARCODEの更新
        private void SaveFormula(SqlBase db, DateTime entryTime)
        {
            //
            // SQL文生成＋SQLパラメータ作成
            //
            string sql = TbFormula.Merge(out List<ParameterItem> parameters, entryTime);
            // キー
            SetParameter(parameters, TbFormula.PRD_BARCODE, TxtBarcode.Text);
            SetParameter(parameters, TbFormula.PRD_PROCESS_CODE, TxtProcessCode.Text);
            // テキストボックス
            foreach (var item in _FormulaTextBoxList)
            {
                SetParameter(parameters, item.FieldName, item.TextBox.Text, item.FieldType, entryTime);
            }
            // ラジオボタン
            SetParameter(parameters, TbFormula.PRD_STATUS, RdbPrdStatus);
            SetParameter(parameters, TbFormula.PRD_UM, RdbPrdUm);
            SetParameter(parameters, TbFormula.PRD_ISPREFILLED, RdbPrdIsprefilled);
            //
            // 更新実行
            //
            db.Execute(sql, parameters);
        }
        #endregion

        #region TB_JOBの更新
        /// <summary>
        /// TB_JOBの更新
        /// </summary>
        /// <param name="db"></param>
        private void SaveJob(SqlBase db, DateTime entryTime)
        {
            //
            // SQL文生成＋SQLパラメータ作成
            //
            string sql = TbJob.Merge(out List<ParameterItem> parameters, entryTime);
            // キー
            SetParameter(parameters, TbJob.JOB_BARCODE, TxtBarcode.Text);
            SetParameter(parameters, TbJob.JOB_PROCESS_CODE, TxtProcessCode.Text);
            // テキストボックス
            foreach (var item in _jobTextBoxList)
            {
                SetParameter(parameters, item.FieldName, item.TextBox.Text, item.FieldType, entryTime);
            }
            // ドロップダウン
            SetParameter(parameters, TbJob.JOB_STATUS, DrpJobStatus.SelectedValue);
            // ラジオボタン
            SetParameter(parameters, TbJob.JOB_MIXING, RdbJobMixing);
            SetParameter(parameters, TbJob.JOB_CAPPING, RdbJobCapping);
            SetParameter(parameters, TbJob.JOB_LID_PLACING, RdbJobLidPlacing);
            SetParameter(parameters, TbJob.JOB_LID_CHECK, RdbJobLidCheck);
            SetParameter(parameters, TbJob.JOB_PRINTING_1, RdbJobPrinting1);
            SetParameter(parameters, TbJob.JOB_PRINTING_2, RdbJobPrinting2);
            SetParameter(parameters, TbJob.JOB_PRINTING_3, RdbJobPrinting3);
            SetParameter(parameters, TbJob.JOB_EXIT_POSITION, RdbJobExitPosition);
            //
            // 更新実行
            //
            db.Execute(sql, parameters);
        }
        #endregion

        #region SQLパラメータ値の設定
        /// <summary>
        /// SQLパラメータ値の設定
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        private void SetParameter(List<ParameterItem> parameters, string key, object value)
        {
            foreach (var item in parameters)
            {
                if (item.Key == key)
                {
                    item.Value = value;
                    return;
                }
            }
        }
        /// <summary>
        /// SQLパラメータ値の設定
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        private void SetParameter(List<ParameterItem> parameters, string key, object value, Type fieldType, DateTime entryTime)
        {
            foreach (var item in parameters)
            {
                if (item.Key == key)
                {
                    if (fieldType == typeof(DateTime))
                    {
                        item.Value = entryTime;
                    }
                    else
                    {
                        item.Value = value;
                    }
                    return;
                }
            }
        }
        #endregion

        #region データベースのカラム名からインデクスを取得
        /// <summary>
        /// データベースのカラム名からインデクスを取得
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="columns"></param>
        /// <returns></returns>
        private int GetColumnIndex(string columnName, DataColumnCollection columns)
        {
            int index = 0;
            foreach (DataColumn column in columns)
            {
                if (column.ColumnName == columnName)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }
        #endregion

        #region データベースの値をテキストボックスに反映
        /// <summary>
        /// データベースの値をテキストボックスに反映
        /// </summary>
        /// <param name="items"></param>
        /// <param name="dt"></param>
        private void DbToTextBox(List<Data.TextBoxItem> items, DataTable dt)
        {
            foreach (var item in items)
            {
                var index = GetColumnIndex(item.FieldName, dt.Columns);
                if (!(index < 0))
                {
                    item.TextBox.Text = dt.Rows[0][index].ToString();
                    if (item.FieldType == typeof(int) || item.FieldType == typeof(float))
                    {
                        item.TextBox.TextAlign = HorizontalAlignment.Right;
                    }
                    if (item.TextBox.Tag != null && item.TextBox.Tag.ToString() != item.TextBox.Text.ToString())
                    {
                        item.TextBox.ForeColor = Color.Red;
                    }
                    else
                    {
                        item.TextBox.ForeColor = Color.Black;
                    }
                    item.TextBox.Tag = item.TextBox.Text.ToString();
                }
            }
        }
        #endregion

        #region ＤＢ更新
        /// <summary>
        /// ＤＢ更新
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        private bool Save(SaveMode mode, SqlBase db)
        {
            if (string.IsNullOrEmpty(TxtBarcode.Text.Trim()))
            {
                Messages.ShowDialog(Sentence.Messages.NotEntryData, "BARCODE");
                return false;
            }
            if (string.IsNullOrEmpty(TxtProcessCode.Text.Trim()))
            {
                Messages.ShowDialog(Sentence.Messages.NotEntryData, "PROCESS_CODE");
                return false;
            }
            var entryTime = DateTime.Now;
            switch (mode)
            {
                case SaveMode.All:
                    SaveBarcode(db, entryTime);
                    SaveFormula(db, entryTime);
                    SaveJob(db, entryTime);
                    break;
                case SaveMode.Barcode:
                    SaveBarcode(db, entryTime);
                    break;
                case SaveMode.Formula:
                    SaveFormula(db, entryTime);
                    break;
                case SaveMode.Job:
                    SaveJob(db, entryTime);
                    break;
            }
            return true;
        }
        #endregion

        #region 画面表示
        /// <summary>
        /// 画面表示
        /// </summary>
        private void PreviewData(string barCode, string processCode)
        {
            using (var db = new SqlBase(SqlBase.DatabaseKind.SUPERVISION, SqlBase.TransactionUse.No, Log.ApplicationType.SupervisorInterfaceSim))
            {
                var result = db.Select(TbBarcode.GetPreviewAll(barCode, processCode));
                if (result.Rows.Count > 0)
                {
                    DbToTextBox(_headerTextBoxList, result);
                    DbToTextBox(_barcodeTextBoxList, result);
                    DbToTextBox(_FormulaTextBoxList, result);
                    DbToTextBox(_jobTextBoxList, result);
                    RdbBrcStatus = int.Parse(result.Rows[0][GetColumnIndex(TbBarcode.BRC_STATUS, result.Columns)].ToString());
                    RdbPrdStatus = int.Parse(result.Rows[0][GetColumnIndex(TbFormula.PRD_STATUS, result.Columns)].ToString());
                    RdbPrdUm = int.Parse(result.Rows[0][GetColumnIndex(TbFormula.PRD_UM, result.Columns)].ToString());
                    RdbPrdIsprefilled = result.Rows[0][GetColumnIndex(TbFormula.PRD_ISPREFILLED, result.Columns)].ToString() == "1";
                    RdbJobMixing = int.Parse(result.Rows[0][GetColumnIndex(TbJob.JOB_MIXING, result.Columns)].ToString());
                    RdbJobCapping = int.Parse(result.Rows[0][GetColumnIndex(TbJob.JOB_CAPPING, result.Columns)].ToString());
                    RdbJobLidPlacing = int.Parse(result.Rows[0][GetColumnIndex(TbJob.JOB_LID_PLACING, result.Columns)].ToString());
                    RdbJobLidCheck = int.Parse(result.Rows[0][GetColumnIndex(TbJob.JOB_LID_CHECK, result.Columns)].ToString());
                    RdbJobPrinting1 = int.Parse(result.Rows[0][GetColumnIndex(TbJob.JOB_PRINTING_1, result.Columns)].ToString());
                    RdbJobPrinting2 = int.Parse(result.Rows[0][GetColumnIndex(TbJob.JOB_PRINTING_2, result.Columns)].ToString());
                    RdbJobPrinting3 = int.Parse(result.Rows[0][GetColumnIndex(TbJob.JOB_PRINTING_3, result.Columns)].ToString());
                    RdbJobExitPosition = int.Parse(result.Rows[0][GetColumnIndex(TbJob.JOB_EXIT_POSITION, result.Columns)].ToString());
                    DrpJobStatus.SelectedValue = result.Rows[0][GetColumnIndex(TbJob.JOB_STATUS, result.Columns)].ToString();
                }
                else
                {
                    foreach (var item in _headerTextBoxList)
                    {
                        item.TextBox.Text = string.Empty;
                    }
                    foreach (var item in _barcodeTextBoxList)
                    {
                        item.TextBox.Text = string.Empty;
                    }
                    foreach (var item in _FormulaTextBoxList)
                    {
                        item.TextBox.Text = string.Empty;
                    }
                    foreach (var item in _jobTextBoxList)
                    {
                        item.TextBox.Text = string.Empty;
                    }
                    RdbBrcStatus = BRD_STATUS_COROB;
                    RdbPrdStatus = PRD_STATUS_UNDISCHARGED;
                    RdbPrdUm = PRD_UM_CC;
                    RdbPrdIsprefilled = false;
                    RdbJobMixing = JOB_YES;
                    RdbJobCapping = JOB_YES;
                    RdbJobLidPlacing = JOB_YES;
                    RdbJobLidCheck = JOB_YES;
                    RdbJobPrinting1 = JOB_NO;
                    RdbJobPrinting2 = JOB_NO;
                    RdbJobPrinting3 = JOB_NO;
                    RdbJobExitPosition = JOB_EXIT_POSITION_MAIN;
                    DrpJobStatus.SelectedValue = DrpJobStatusDefines[0].Value;
                }
            }
            LblPreviewTime.Text = $"秒周期で更新（最終更新時刻：{DateTime.Now.ToString("HH:mm:ss")}）";
        }
        #endregion

        #region タイマーリセット
        /// <summary>
        /// タイマーリセット
        /// </summary>
        /// <param name="timerEnabled"></param>
        private void TimerReset(bool timerEnabled)
        {
            if (timerEnabled)
            {
                BtnTimer.Text = "停止";
            }
            else
            {
                BtnTimer.Text = "開始";
            }
            BtnPreview.Enabled = !timerEnabled;
            BtnSaveBarcode.Enabled = !timerEnabled;
            BtnSaveFormula.Enabled = !timerEnabled;
            BtnSaveJob.Enabled = !timerEnabled;
            BtnSaveAll.Enabled = !timerEnabled;
            TimerPreview.Enabled = timerEnabled;
        }
        #endregion

        #endregion
    }
}
