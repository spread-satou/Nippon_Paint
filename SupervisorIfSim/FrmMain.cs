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
using Sql = NipponPaint.NpCommon.Database.Sql;
#endregion

namespace SupervisorIfSim
{
    public partial class FrmMain : BaseForm
    {
        #region DataGridViewの列定義
        private List<GridViewSetting> ViewSettingsMain = new List<GridViewSetting>()
        {
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbBarcode.BARCODE, DisplayName = TbBarcode.BARCODE, Visible = true, Width = 200, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbBarcode.PROCESS_CODE, DisplayName = TbBarcode.PROCESS_CODE, Visible = true, Width = 200, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbBarcode.BRC_TIME_INSERTED, DisplayName = TbBarcode.BRC_TIME_INSERTED, Visible = true, Width = 120, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbBarcode.BRC_TIME_PROCESSED, DisplayName = TbBarcode.BRC_TIME_PROCESSED, Visible = true, Width = 120, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbBarcode.BRC_STATUS, DisplayName = TbBarcode.BRC_STATUS, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbBarcode.BRC_ERR_1, DisplayName = TbBarcode.BRC_ERR_1, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbBarcode.BRC_ERR_2, DisplayName = TbBarcode.BRC_ERR_2, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbBarcode.BRC_ERR_3, DisplayName = TbBarcode.BRC_ERR_3, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbFormula.PRD_TIME_INSERTED, DisplayName = TbFormula.PRD_TIME_INSERTED, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbFormula.PRD_STATUS, DisplayName = TbFormula.PRD_STATUS, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbFormula.PRD_CODE, DisplayName = TbFormula.PRD_CODE, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbFormula.PRD_DESC, DisplayName = TbFormula.PRD_DESC, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbFormula.PRD_UM, DisplayName = TbFormula.PRD_UM, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbFormula.PRD_SPECIFIC_GRAVITY, DisplayName = TbFormula.PRD_SPECIFIC_GRAVITY, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbFormula.PRD_QTY_REQ, DisplayName = TbFormula.PRD_QTY_REQ, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbFormula.PRD_QTY_DISP, DisplayName = TbFormula.PRD_QTY_DISP, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbFormula.PRD_START_DISP, DisplayName = TbFormula.PRD_START_DISP, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbFormula.PRD_END_DISP, DisplayName = TbFormula.PRD_END_DISP, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbFormula.PRD_PRIORITY, DisplayName = TbFormula.PRD_PRIORITY, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbFormula.PRD_NUM, DisplayName = TbFormula.PRD_NUM, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbFormula.PRD_ISPREFILLED, DisplayName = TbFormula.PRD_ISPREFILLED, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbFormula.PRD_PREFILLED_QTY, DisplayName = TbFormula.PRD_PREFILLED_QTY, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_TIME_INSERTED, DisplayName = TbJob.JOB_TIME_INSERTED, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_STATUS, DisplayName = TbJob.JOB_STATUS, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_TARE_WEIGHT_EXPECTED, DisplayName = TbJob.JOB_TARE_WEIGHT_EXPECTED, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_TARE_WEIGHT_DETECTED, DisplayName = TbJob.JOB_TARE_WEIGHT_DETECTED, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_TARE_WEIGHT_PERC_ERR_ADMITTED, DisplayName = TbJob.JOB_TARE_WEIGHT_PERC_ERR_ADMITTED, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_GROSS_WEIGHT_EXPECTED, DisplayName = TbJob.JOB_GROSS_WEIGHT_EXPECTED, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_GROSS_WEIGHT_DETECTED, DisplayName = TbJob.JOB_GROSS_WEIGHT_DETECTED, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_GROSS_WEIGHT_PERC_ERR_ADMITTED, DisplayName = TbJob.JOB_GROSS_WEIGHT_PERC_ERR_ADMITTED, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_NET_WEIGHT_EXPECTED, DisplayName = TbJob.JOB_NET_WEIGHT_EXPECTED, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_NET_WEIGHT_DETECTED, DisplayName = TbJob.JOB_NET_WEIGHT_DETECTED, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_NET_WEIGHT_PERC_ERR_ADMITTED, DisplayName = TbJob.JOB_NET_WEIGHT_PERC_ERR_ADMITTED, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_TOT_COLORANT_WEIGHT_EXPECTED, DisplayName = TbJob.JOB_TOT_COLORANT_WEIGHT_EXPECTED, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_TOT_COLORANT_WEIGHT_DETECTED, DisplayName = TbJob.JOB_TOT_COLORANT_WEIGHT_DETECTED, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_TOT_COLORANT_WEIGHT_PERC_ERR_ADMITTED, DisplayName = TbJob.JOB_TOT_COLORANT_WEIGHT_PERC_ERR_ADMITTED, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_TOT_GRAVIMETRIC_WEIGHT_EXPECTED, DisplayName = TbJob.JOB_TOT_GRAVIMETRIC_WEIGHT_EXPECTED, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_TOT_GRAVIMETRIC_WEIGHT_DETECTED, DisplayName = TbJob.JOB_TOT_GRAVIMETRIC_WEIGHT_DETECTED, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_TOT_GRAVIMETRIC_WEIGHT_PERC_ERR_ADMITTED, DisplayName = TbJob.JOB_TOT_GRAVIMETRIC_WEIGHT_PERC_ERR_ADMITTED, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_MIXING, DisplayName = TbJob.JOB_MIXING, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_MIXING_TIME, DisplayName = TbJob.JOB_MIXING_TIME, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_MIXING_SPEED, DisplayName = TbJob.JOB_MIXING_SPEED, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_CAPPING, DisplayName = TbJob.JOB_CAPPING, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_LID_PLACING, DisplayName = TbJob.JOB_LID_PLACING, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_LID_CHECK, DisplayName = TbJob.JOB_LID_CHECK, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_PRINTING_1, DisplayName = TbJob.JOB_PRINTING_1, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_PRINTING_2, DisplayName = TbJob.JOB_PRINTING_2, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_PRINTING_3, DisplayName = TbJob.JOB_PRINTING_3, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_EXIT_POSITION, DisplayName = TbJob.JOB_EXIT_POSITION, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_TAG_1, DisplayName = TbJob.JOB_TAG_1, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_TAG_2, DisplayName = TbJob.JOB_TAG_2, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_TAG_3, DisplayName = TbJob.JOB_TAG_3, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_TAG_4, DisplayName = TbJob.JOB_TAG_4, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_TAG_5, DisplayName = TbJob.JOB_TAG_5, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_ERR_1, DisplayName = TbJob.JOB_ERR_1, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_ERR_2, DisplayName = TbJob.JOB_ERR_2, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_ERR_3, DisplayName = TbJob.JOB_ERR_3, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_ERR_4, DisplayName = TbJob.JOB_ERR_4, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = TbJob.JOB_ERR_5, DisplayName = TbJob.JOB_ERR_5, Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleLeft } },
        };
        #endregion

        #region 定数
        private const int INDEX_BARCODE = 0;
        private const int INDEX_PROCESS_CODE = 1;
        #endregion

        #region コンストラクタ
        public FrmMain()
        {
            InitializeComponent();
            InitializeForm();
        }
        #endregion

        #region イベント

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMainShown(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.OpenMainForm);
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }

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
                        // 編集
                        BtnEdit.PerformClick();
                        break;
                    case Keys.F5:
                        // 一覧更新
                        BtnPreview.PerformClick();
                        break;
                    case Keys.F9:
                        // 開始／停止
                        BtnTimer.PerformClick();
                        break;
                }
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
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                var barcode = GvMain.SelectedRows[0].Cells[INDEX_BARCODE].Value.ToString();
                var processCode = GvMain.SelectedRows[0].Cells[INDEX_PROCESS_CODE].Value.ToString();
                EditData(barcode, processCode, Dialogs.FrmEdit.DialogMode.Merge);
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
                PreviewData();
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
                PreviewData();
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
        private void GvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var barcode = GvMain.Rows[e.RowIndex].Cells[INDEX_BARCODE].Value.ToString();
                var processCode = GvMain.Rows[e.RowIndex].Cells[INDEX_PROCESS_CODE].Value.ToString();
                EditData(barcode, processCode, Dialogs.FrmEdit.DialogMode.Update);
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }

        private void GvMain_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                DataGridViewFormatting((DataGridView)sender);
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }
        #endregion

        #region private functions

        private void InitializeForm()
        {
            this.Shown += new EventHandler(this.FrmMainShown);
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(this.FormKeyDown);
            this.BtnEdit.Click += new EventHandler(this.BtnEdit_Click);
            this.BtnTimer.Click += new EventHandler(this.BtnTimer_Click);
            this.BtnPreview.Click += new EventHandler(this.BtnPreview_Click);
            this.GvMain.CellDoubleClick += new DataGridViewCellEventHandler(this.GvMain_CellDoubleClick);
            this.GvMain.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(this.GvMain_DataBindingComplete);
            this.TimerPreview.Tick += new EventHandler(this.TimerPreview_Tick);
            // タイマーの周期を設定
            TimerPreview.Interval = int.Parse(LblCycle.Text) * 1000;
            // DataGridViewの表示
            PreviewData();
            var cnt = 0;
            foreach (var item in ViewSettingsMain)
            {
                GvMain.Columns[cnt].Width = item.Width;
                GvMain.Columns[cnt].Visible = item.Visible;
                GvMain.Columns[cnt].DefaultCellStyle.Alignment = item.alignment;
                cnt++;
            }
            GvMain.Columns[INDEX_PROCESS_CODE].Frozen = true;
        }

        #region DataGridViewの書式設定
        /// <summary>
        /// DataGridViewの書式設定
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="e"></param>
        private void DataGridViewFormatting(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Cells[INDEX_BARCODE].Style.BackColor = Color.LightYellow;
                row.Cells[INDEX_PROCESS_CODE].Style.BackColor = Color.LightYellow;
            }
        }
        #endregion

        #region 一覧表示
        /// <summary>
        /// 一覧表示
        /// </summary>
        private void PreviewData()
        {
            using (var db = new SqlBase(SqlBase.DatabaseKind.SUPERVISION, SqlBase.TransactionUse.No, Log.ApplicationType.SupervisorInterfaceSim))
            {
                var selectedIndex = -1;
                if (GvMain.SelectedRows.Count > 0)
                {
                    selectedIndex = GvMain.SelectedRows[0].Index;
                }
                var result = db.Select(TbBarcode.GetPreviewAll());
                GvMain.DataSource = result;
                LblPreviewTime.Text = $"秒周期で更新（最終更新時刻：{DateTime.Now.ToString("HH:mm:ss")}）";
                if (selectedIndex > -1)
                {
                    GvMain.Rows[selectedIndex].Selected = true;
                }
            }
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
            TimerPreview.Enabled = timerEnabled;
        }
        #endregion

        #region 編集画面を開く
        /// <summary>
        /// 編集画面を開く
        /// </summary>
        /// <param name="barcode"></param>
        /// <param name="processCode"></param>
        /// <param name="mode"></param>
        private void EditData(string barcode, string processCode, Dialogs.FrmEdit.DialogMode mode)
        {
            var timerEnabled = TimerPreview.Enabled;
            TimerReset(false);
            var form = new Dialogs.FrmEdit(barcode, processCode, mode);
            form.ShowDialog();
            PreviewData();
            TimerReset(timerEnabled);
        }
        #endregion

        #endregion

    }
}
