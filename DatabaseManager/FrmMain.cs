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
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseManager.Dialogs;
using NipponPaint.NpCommon;
using NipponPaint.NpCommon.Database;
using NipponPaint.NpCommon.Settings;
using Sql = NipponPaint.NpCommon.Database.Sql;


#endregion

namespace DatabaseManager
{
    public partial class FrmMain : BaseForm
    {
        #region DataGridViewの列定義
        private List<GridViewSetting> ViewSettings = new List<GridViewSetting>()
        {
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = "Notify_Msg", DisplayName = "メッセージ", Visible = true, Width = 730, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.DateTime, ColumnName = "Receive_Time", DisplayName = "'時間(Time)'", Visible = true, Width = 200, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.DateTime, ColumnName = "Rejected", DisplayName = "'拒否'", Visible = false, Width = 50, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.DateTime, ColumnName = "Acknowledged", DisplayName = "'認識'", Visible = false, Width = 50, alignment = DataGridViewContentAlignment.MiddleLeft } },
        };
        #endregion

        #region コンストラクタ
        public FrmMain()
        {
            InitializeComponent();
            InitializeForm();
        }
        #endregion

        #region イベント

        private void FrmKeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyData)
            {
                case Keys.S | Keys.Alt:
                    BtnHGServerStart.PerformClick();
                    break;
                case Keys.A | Keys.Alt:
                    BtnHGServerStop.PerformClick();
                    break;
                case Keys.R | Keys.Alt:
                    BtnHGLogRecognition.PerformClick();
                    break;
                case Keys.C | Keys.Alt:
                    BtnHGLogClear.PerformClick();
                    break;
                case Keys.E | Keys.Alt:
                    BtnChangeENG.PerformClick();
                    break;
                case Keys.J | Keys.Alt:
                    BtnChangeJPN.PerformClick();
                    break;
                case Keys.I | Keys.Alt:
                    BtnSetting.PerformClick();
                    break;
                case Keys.D | Keys.Alt:
                    BtnDBMaintenance.PerformClick();
                    break;
                case Keys.Escape:
                    BtnClose.PerformClick();
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// HGサーバー作動
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnHGServerStartClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }

        /// <summary>
        /// HGサーバー停止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnHGServerStopClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }

        /// <summary>
        /// 認識
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnHGLogRecognitionClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }

        /// <summary>
        /// Clear
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnHGLogClearClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }

        /// <summary>
        /// 英語
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnChangeENGClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }

        /// <summary>
        /// 日本語
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnChangeJPNClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }

        /// <summary>
        /// 設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSettingClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                FrmSetting frmSetting = new FrmSetting();
                frmSetting.ShowDialog();
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }

        /// <summary>
        /// データベースメンテナンス
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDBMaintenanceClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                FrmDBMaintenance frmDBMaintenance = new FrmDBMaintenance();
                frmDBMaintenance.ShowDialog();

            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }

        /// <summary>
        /// 閉じる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCloseClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                this.Close();
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }
        #endregion

        #region private functions

        #region 画面の初期化
        /// <summary>
        /// 画面の初期化
        /// </summary>
        private void InitializeForm()
        {
            //イベントを追加
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmKeyDown);
            this.BtnClose.Click += new System.EventHandler(this.BtnCloseClick);
            this.BtnSetting.Click += new System.EventHandler(this.BtnSettingClick);
            this.BtnDBMaintenance.Click += new System.EventHandler(this.BtnDBMaintenanceClick);
            this.BtnChangeENG.Click += new System.EventHandler(this.BtnChangeENGClick);
            this.BtnChangeJPN.Click += new System.EventHandler(this.BtnChangeJPNClick);
            this.BtnHGLogRecognition.Click += new System.EventHandler(this.BtnHGLogRecognitionClick);
            this.BtnHGLogClear.Click += new System.EventHandler(this.BtnHGLogClearClick);
            this.BtnHGServerStart.Click += new System.EventHandler(this.BtnHGServerStartClick);
            this.BtnHGServerStop.Click += new System.EventHandler(this.BtnHGServerStopClick);
            this.DgvList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvList_DataBindingComplete);
            // DataGridViewの初期設定
            InitializeGridView(DgvList);
            // 一覧表示
            PreviewData();
            // 一覧レイアウトの設定
            var cnt = 0;            
                        
            foreach (var item in ViewSettings)
            {
                DgvList.Columns[cnt].Width = item.Width;
                DgvList.Columns[cnt].SortMode = DataGridViewColumnSortMode.NotSortable;
                DgvList.Columns[cnt].Visible = item.Visible;
                DgvList.Columns[cnt].DefaultCellStyle.Alignment = item.alignment;
                cnt++;
            }
        }
        #endregion

        #endregion

        #region 一覧表示
        /// <summary>
        /// 一覧表示
        /// </summary>
        private void PreviewData()
        {
            // DataGridViewの表示
            using (var db = new SqlBase(SqlBase.DatabaseKind.NPMAIN, SqlBase.TransactionUse.No, Log.ApplicationType.Databasemanager))
            {
                var result = db.Select(Sql.NpMain.HgLog.GetPreview(ViewSettings));
                DgvList.DataSource = result;
            }
        }
        #endregion

        #region Datagridviewをバインドする
        /// <summary>
        /// Datagridviewをバインドする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in DgvList.Rows)
            {
                Console.Write(row.Cells["メッセージ"].Value);
                Console.Write(row.Cells["時間(Time)"].Value);
                Console.Write(row.Cells["拒否"].Value);
                Console.Write(row.Cells["認識"].Value);

                int rejectedCell = Convert.ToInt32(row.Cells["拒否"].Value);
                int acknowledgedCell = Convert.ToInt32(row.Cells["認識"].Value);
                switch (rejectedCell)
                {
                    case 0:
                        row.DefaultCellStyle.ForeColor = Color.LimeGreen;
                        row.DefaultCellStyle.SelectionForeColor = Color.LimeGreen;
                        break;
                    case 1:
                        if (acknowledgedCell == 0)
                        {
                            row.DefaultCellStyle.ForeColor = Color.FromArgb(250, 250, 0);
                            row.DefaultCellStyle.SelectionForeColor = Color.FromArgb(250, 250, 0);
                        }
                        else
                        {
                            row.DefaultCellStyle.ForeColor = Color.FromArgb(130, 130, 0);
                            row.DefaultCellStyle.SelectionForeColor = Color.FromArgb(130, 130, 0);
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        private void Timer_Tick(object sender, EventArgs e)
        {
            // DataGridViewの初期設定
            InitializeGridView(DgvList);
            // 一覧表示
            PreviewData();
            // 一覧レイアウトの設定
            var cnt = 0;
            DgvList.Rows[0].Frozen = true;

            foreach (var item in ViewSettings)
            {
                DgvList.Columns[cnt].Width = item.Width;
                DgvList.Columns[cnt].SortMode = DataGridViewColumnSortMode.NotSortable;
                DgvList.Columns[cnt].Visible = item.Visible;
                DgvList.Columns[cnt].DefaultCellStyle.Alignment = item.alignment;
                cnt++;
            }
        }
    }
}
