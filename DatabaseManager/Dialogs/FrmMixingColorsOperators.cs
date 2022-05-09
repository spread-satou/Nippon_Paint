//*****************************************************************************
//
//  システム名：調色工場用自動計量システム NpCommon
//
//  Copyright 三菱電機エンジニアリング株式会社 2022 All rights reserved.
//
//-----------------------------------------------------------------------------
//  変更履歴:
//  Ver      日付        担当       コメント
//  0.0      2022/04/30  M.Nakai    新規作成
#region 更新履歴
#endregion
//*****************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using NipponPaint.NpCommon;
using NipponPaint.NpCommon.Database;
using NipponPaint.NpCommon.FormControls;
using Sql = NipponPaint.NpCommon.Database.Sql;

namespace DatabaseManager.Dialogs
{
    /// <summary>
    /// 調色担当
    /// </summary>
    public partial class FrmMixingColorsOperators : Form
    {
        static string title = "information";
        static string msg = "クローズ前に設定を保存してください";

        #region コンストラクタ
        public FrmMixingColorsOperators()
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
                case Keys.Enter:
                    BtnSettingSave.PerformClick();
                    break;
                case Keys.F11:
                    BtnSettingInitialize.PerformClick();
                    break;
                case Keys.Escape:
                    BtnClose.PerformClick();
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// 設定を保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSettingSaveClick(object sender, EventArgs e)
        {
            BaseForm baseForm = new BaseForm();
            try
            {
                baseForm.PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                //画面上で変更された担当者をDBへ反映する
                RegistData();
                //保存/元に戻すボタンをEnabled = false にする
                ButtonEnabledFalse();
            }
            catch (Exception ex)
            {
                baseForm.PutLog(ex);
            }
        }

        /// <summary>
        /// 設定を元に戻す
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSettingInitializeClick(object sender, EventArgs e)
        {
            BaseForm baseForm = new BaseForm();
            try
            {
                baseForm.PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                //担当者テーブルを全件取得して画面に表示する
                PreviewData();
                //保存/元に戻すボタンをEnabled = false にする
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
            if (BtnSettingSave.Enabled)
            {
                MessageBox.Show(this, msg, title);
            }
            else
            {
                BaseForm baseForm = new BaseForm();
                try
                {
                    baseForm.PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                    this.Close();
                }
                catch (Exception ex)
                {
                    baseForm.PutLog(ex);
                }
            }           
        }

        /// <summary>
        /// テキストボックスが変更された場合
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtValueTextChanged(object sender, EventArgs e)
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
            this.BtnClose.Click += new System.EventHandler(this.BtnCloseClick);
            this.BtnSettingInitialize.Click += new System.EventHandler(this.BtnSettingInitializeClick);
            this.BtnSettingSave.Click += new System.EventHandler(this.BtnSettingSaveClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmKeyDown);
            //担当者テーブルを全件取得して画面に表示する
            PreviewData();
            //保存/元に戻すボタンをEnabled = false にする
            ButtonEnabledFalse();
            //すべてのlabelTextBoxにTextChangedのイベントハンドラーをセットする
            SetEvent(this.Controls);
        }
        #endregion

        #region 保存/元に戻すボタンをEnabled = false にする
        /// <summary>
        /// //保存/元に戻すボタンをEnabled = false にする
        /// </summary>
        private void ButtonEnabledFalse()
        {
            BtnSettingSave.Enabled = false;
            BtnSettingInitialize.Enabled = false;
        }
        #endregion

        #region 保存/元に戻すボタンをEnabled = true にする
        /// <summary>
        /// 保存/元に戻すボタンをEnabled = true にする
        /// </summary>
        private void ButtonEnabledTrue()
        {
            BtnSettingSave.Enabled = true;
            BtnSettingInitialize.Enabled = true;
        }
        #endregion

        #region 担当者テーブルを全件取得して画面に表示する
        /// <summary>
        /// 担当者テーブルを全件取得して画面に表示する
        /// </summary>
        private void PreviewData()
        {
            using (var db = new SqlBase(SqlBase.DatabaseKind.NPMAIN, SqlBase.TransactionUse.No, Log.ApplicationType.Databasemanager))
            {
                // 行取得のSQLを作成
                var recs = db.Select(Sql.NpMain.Operators.GetPreview());
                // フォームで定義された、取得値設定先のコントロールを抽出する
                var controls = new List<Control>();
                Funcs.FindControls(this.Controls, controls);
                foreach (var control in controls)
                {
                    switch (control)
                    {
                        case LabelTextBoxDb labelTextBoxDb:
                            // LabelTextBoxコントロールへの設定
                            if (!string.IsNullOrEmpty(labelTextBoxDb.Code))
                            {
                                var rows = recs.Select($"Operator_Code = '{labelTextBoxDb.Code}'");
                                if (!string.IsNullOrEmpty(labelTextBoxDb.DatabaseColumnName))
                                {
                                    labelTextBoxDb.Value = rows[0][labelTextBoxDb.DatabaseColumnName].ToString();
                                }
                                
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        #endregion

        #region 画面上で変更された担当者をDBへ反映する
        /// <summary>
        /// 画面上で変更された担当担当者をDBへ反映する
        /// </summary>
        private void RegistData()
        {
            using (var db = new SqlBase(SqlBase.DatabaseKind.NPMAIN, SqlBase.TransactionUse.Yes, Log.ApplicationType.Databasemanager))
            {
                try
                {
                    // フォームで定義された、取得値設定先のコントロールを抽出する
                    db.FromLabelTextBoxDb(this.Controls, "Operators", "Operator_Name", "Operator_Code");
                    db.Commit();
                }
                catch (Exception ex)
                {
                    db.Rollback();
                    // ログ出力とエラーメッセージ
                    BaseForm baseForm = new BaseForm();
                    baseForm.PutLog(ex);
                }
            }
        }
        #endregion

        #region すべてのlabelTextBoxにTextChangedのイベントハンドラーをセットする
        /// <summary>
        /// すべてのlabelTextBoxにTextChangedのイベントハンドラーをセットする
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
                    case LabelTextBoxDb labelTextBoxDb:
                        ((LabelTextBoxDb)control).ValueTextBox.TextChanged += new System.EventHandler(TxtValueTextChanged);
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion
    }
}
