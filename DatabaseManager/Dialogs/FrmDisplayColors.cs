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
using NipponPaint.NpCommon;
using NipponPaint.NpCommon.Database;
using NipponPaint.NpCommon.FormControls;
using Sql = NipponPaint.NpCommon.Database.Sql;

namespace DatabaseManager.Dialogs
{
    /// <summary>
    /// 表示色
    /// </summary>
    public partial class FrmDisplayColors : Form
    {
        static string title = "information";
        static string msg = "クローズ前に設定を保存してください";

        #region コンストラクタ
        public FrmDisplayColors()
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
                //画面上で変更された色をDBへ反映する
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
                //色マスターを全件取得して画面に表示する
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
            this.BtnSettingSave.Click += new System.EventHandler(this.BtnSettingSaveClick);
            this.BtnSettingInitialize.Click += new System.EventHandler(this.BtnSettingInitializeClick);
            this.BtnClose.Click += new System.EventHandler(this.BtnCloseClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmKeyDown);
            //色マスターを全件取得して画面に表示する
            PreviewData();
            //保存/元に戻すボタンをEnabled = false にする
            ButtonEnabledFalse();
            //LabelColorDialogにTextOrValueChangedイベントハンドラーをセットする
            SetEvent(this.Controls);
        }
        #endregion

        #region 保存/元に戻すボタンをEnabled = false にする
        /// <summary>
        /// 保存/元に戻すボタンをEnabled = false にする
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

        #region 色マスターを全件取得して画面に表示する
        /// <summary>
        /// 色マスターを全件取得して画面に表示する
        /// </summary>
        private void PreviewData()
        {
            using (var db = new SqlBase(SqlBase.DatabaseKind.NPMAIN, SqlBase.TransactionUse.No, Log.ApplicationType.Databasemanager))
            {
                // 行取得のSQLを作成
                var recs = db.Select(Sql.NpMain.Colors.GetPreview());
                // フォームで定義された、取得値設定先のコントロールを抽出する
                var controls = new List<Control>();
                Funcs.FindControls(this.Controls, controls);
                foreach (var control in controls)
                {
                    switch (control)
                    {
                        case LabelColorDiaLog labelColorDiaLog:
                            // LabelColorDialogコントロールへの設定
                            if (!string.IsNullOrEmpty(labelColorDiaLog.Code))
                            {
                                var rows = recs.Select($"RF_Display_Colors = '{labelColorDiaLog.Code}'");

                                if (!string.IsNullOrEmpty(labelColorDiaLog.DatabaseColumnName))
                                { 
                                    //LblColorCodeへ設定
                                    labelColorDiaLog.ColorCode = rows[0][labelColorDiaLog.DatabaseColumnName].ToString();
                                    //LblBtnColorへ設定
                                    labelColorDiaLog.ButtonColor = Funcs.RgbFromInt(rows[0][labelColorDiaLog.DatabaseColumnName]);
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

        #region 画面上で変更された色をDBへ反映する
        /// <summary>
        /// 画面上で変更された色をDBへ反映する
        /// </summary>
        private void RegistData()
        {
            using (var db = new SqlBase(SqlBase.DatabaseKind.NPMAIN, SqlBase.TransactionUse.Yes, Log.ApplicationType.Databasemanager))
            {
                try
                {
                    // フォームで定義された、取得値設定先のコントロールを抽出する
                    db.FromLabelColorsDiaLog(this.Controls, "Colors", "RGB", "RF_Display_Colors");
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

        #region LabelColorDialogにTextOrValueChangedイベントハンドラーをセットする
        /// <summary>
        /// LabelColorDialogにTextOrValueChangedのTextOrValueChangedイベントハンドラーをセットする
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
                    case LabelColorDiaLog labelColorDiaLog:
                        ((LabelColorDiaLog)control).ValueColorCode.TextChanged += new System.EventHandler(TextOrValueChanged);
                        break;
                }
            }
        }
        #endregion
    }
}
