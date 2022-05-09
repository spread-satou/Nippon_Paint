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
using NipponPaint.NpCommon.Database;
using Sql = NipponPaint.NpCommon.Database.Sql;
#endregion

namespace DatabaseManager.Dialogs
{
    /// <summary>
    /// データベースメンテナンス
    /// </summary>
    public partial class FrmDBMaintenance : Form
    {
        #region コンストラクタ
        public FrmDBMaintenance()
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
                case Keys.T | Keys.Alt:
                    BtnBackUpStart1.PerformClick();
                    break;
                case Keys.D | Keys.Alt:
                    BtnBackUpStart2.PerformClick();
                    break;
                case Keys.E | Keys.Alt:
                    BtnBackUpStart3.PerformClick();
                    break;
                case Keys.H | Keys.Alt:
                    BtnHistoryDataDelete.PerformClick();
                    break;
                case Keys.R | Keys.Alt:
                    BtnDataReturn.PerformClick();
                    break;
                case Keys.S | Keys.Alt:
                    BtnSaveSettings.PerformClick();
                    break;
                case Keys.O | Keys.Alt:
                    BtnRestoreSettings.PerformClick();
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// 今バックアップ(時間毎のバックアップ)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBackUpStart1Click(object sender, EventArgs e)
        {
            BaseForm baseForm = new BaseForm();
            try
            {                
                baseForm.PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
            }
            catch (Exception ex)
            {
                baseForm.PutLog(ex);
            }
        }

        /// <summary>
        /// 今バックアップ(日毎のバックアップ)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBackUpStart2Click(object sender, EventArgs e)
        {
            BaseForm baseForm = new BaseForm();
            try
            {
                baseForm.PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
            }
            catch (Exception ex)
            {
                baseForm.PutLog(ex);
            }
        }

        /// <summary>
        /// 今バックアップ(トラブル発生時のバックアップ保存)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBackUpStart3Click(object sender, EventArgs e)
        {
            BaseForm baseForm = new BaseForm();
            try
            {
                baseForm.PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
            }
            catch (Exception ex)
            {
                baseForm.PutLog(ex);
            }
        }

        /// <summary>
        /// 履歴データ削除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnHistoryDataDeleteClick(object sender, EventArgs e)
        {
            BaseForm baseForm = new BaseForm();
            try
            {
                baseForm.PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
            }
            catch (Exception ex)
            {
                baseForm.PutLog(ex);
            }
        }

        
        private void BtnFolderBrowserDialogClick(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        }

        /// <summary>
        /// データ復帰
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDataReturnClick(object sender, EventArgs e)
        {
            BaseForm baseForm = new BaseForm();
            try
            {
                baseForm.PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
            }
            catch (Exception ex)
            {
                baseForm.PutLog(ex);
            }
        }

        /// <summary>
        /// Save Settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSaveSettingsClick(object sender, EventArgs e)
        {
            BaseForm baseForm = new BaseForm();
            try
            {
                baseForm.PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                //SaveSettings/RestoreSettingsボタンをEnabled = false にする
                ButtonEnabledFalse();
            }
            catch (Exception ex)
            {
                baseForm.PutLog(ex);
            }
        }

        /// <summary>
        /// Restore Settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRestoreSettingsClick(object sender, EventArgs e)
        {
            BaseForm baseForm = new BaseForm();
            try
            {
                baseForm.PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                //SaveSettings/RestoreSettingsボタンをEnabled = false にする
                ButtonEnabledFalse();
            }
            catch (Exception ex)
            {
                baseForm.PutLog(ex);
            }
        }

        /// <summary>
        /// 閉じる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCloseClick(object sender, EventArgs e)
        {
            BaseForm baseForm = new BaseForm();
            try
            {
                baseForm.PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                this.Close();

                //SaveSettings/RestoreSettingsボタンをEnabled = false にする
                ButtonEnabledFalse();
            }
            catch (Exception ex)
            {
                baseForm.PutLog(ex);
            }
        }

        /// <summary>
        /// 入力値が変更された場合
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>     
        private void TextOrValueChanged(object sender, EventArgs e)
        {
            //保存/元に戻すボタンをEnabled = true にする
            ButtonEnabledTrue();
        }
        #endregion

        #region private functions
        /// <summary>
        /// 画面の初期化
        /// </summary>
        private void InitializeForm()
        {
            // イベントの追加
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmKeyDown);
            this.BtnBackUpStart1.Click += new System.EventHandler(this.BtnBackUpStart1Click);
            this.BtnBackUpStart2.Click += new System.EventHandler(this.BtnBackUpStart2Click);
            this.BtnBackUpStart3.Click += new System.EventHandler(this.BtnBackUpStart3Click);
            this.BtnHistoryDataDelete.Click += new System.EventHandler(this.BtnHistoryDataDeleteClick);
            this.BtnDataReturn.Click += new System.EventHandler(this.BtnDataReturnClick);
            this.BtnClose.Click += new System.EventHandler(this.BtnCloseClick);
            this.BtnRestoreSettings.Click += new System.EventHandler(this.BtnRestoreSettingsClick);
            this.BtnSaveSettings.Click += new System.EventHandler(this.BtnSaveSettingsClick);
            //mainテーブルを取得して画面に表示する
            PreviewData();
            //保存/元に戻すボタンをEnabled = false にする
            ButtonEnabledFalse();
            //すべての入力欄にTextOrValueChangedのイベントハンドラーをセットする
            SetEvent(this.Controls);
        }
        #endregion

        #region //SaveSettings/RestoreSettingsボタンをEnabled = false にする
        /// <summary>
        /// //SaveSettings/RestoreSettingsボタンをEnabled = false にする
        /// </summary>
        private void ButtonEnabledFalse()
        {
            BtnSaveSettings.Enabled = false;
            BtnRestoreSettings.Enabled = false;
        }
        #endregion

        #region //SaveSettings/RestoreSettingsボタンをEnabled = true にする
        /// <summary>
        /// //SaveSettings/RestoreSettingsボタンをEnabled = true にする
        /// </summary>
        private void ButtonEnabledTrue()
        {
            BtnSaveSettings.Enabled = true;
            BtnRestoreSettings.Enabled = true;
        }
        #endregion

        #region mainテーブルを取得して画面に表示する
        /// <summary>
        /// mainテーブルを取得して画面に表示する
        /// </summary>
        private void PreviewData()
        {
            using (var db = new SqlBase(SqlBase.DatabaseKind.NPMAIN, SqlBase.TransactionUse.No, Log.ApplicationType.Databasemanager))
            {
                // 行取得のSQLを作成
                var main = db.Select(Sql.NpMain.MainSet.GetPreview()); 
                // フォームで定義された、取得値設定先のコントロールを抽出する
                var controls = new List<Control>();
                Funcs.FindControls(this.Controls, controls);
                foreach (var control in controls)
                {
                    switch (control)
                    {
                        case NumericUpDown NumericUpDown:
                            //LabelNumericUpDownコントロールへの設定
                            bool nudResult = decimal.TryParse(main.Rows[0]["BCK_Daily_Time"].ToString(), out decimal decResult);
                                if (nudResult)
                                {
                                    NumericUpDown.Value = decResult;
                                }
                            break;                        
                        case DateTimePicker dateTimePicker:
                            //LabelDateTimePickerコントロールへの設定
                            bool dtpResult = DateTime.TryParse(main.Rows[0]["BCK_Weekly_Time"].ToString(), out DateTime dtResult);
                                if (dtpResult)
                                {
                                    dateTimePicker.Value = dtResult;
                                }
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        #endregion

        #region すべての入力欄にTextOrValueChangedイベントハンドラーをセットする
        /// <summary>
        /// すべての入力欄にTextOrValueChangedのTextOrValueChangedイベントハンドラーをセットする
        /// </summary>
        /// <param name="formControls"></param>
        private void SetEvent(Control.ControlCollection formControls)
        {
            var controls = new List<Control>();
            Funcs.FindControls(formControls, controls);
            foreach (var control in controls)
            {
                switch (control)
                {
                    case NumericUpDown numericUpDown:
                        ((NumericUpDown)control).ValueChanged += new System.EventHandler(TextOrValueChanged);
                        break;
                    case DateTimePicker dateTimePicker:
                        ((DateTimePicker)control).ValueChanged += new System.EventHandler(TextOrValueChanged);
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion


    }
}
