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
    /// 配達設定
    /// </summary>
    public partial class FrmDeliverySetting : Form
    {
        static string title = "information";
        static string msg = "クローズ前に設定を保存してください";

        #region コンストラクタ
        public FrmDeliverySetting()
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
                // 画面上で変更された配達設定をDBへ反映する
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
                //配送区分マスターを全件取得して画面に表示する
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
            //配送区分マスターを全件取得して画面に表示する
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

        #region 配送区分マスターを全件取得して画面に表示する
        /// <summary>
        /// 配送区分マスターを全件取得して画面に表示する
        /// </summary>
        private void PreviewData()
        {
            using (var db = new SqlBase(SqlBase.DatabaseKind.NPMAIN, SqlBase.TransactionUse.No, Log.ApplicationType.Databasemanager))
            {
                // 行取得のSQLを作成
                var recs = db.Select(Sql.NpMain.Delivery.GetPreview());
                // フォームで定義された、取得値設定先のコントロールを抽出する
                var controls = new List<Control>();
                Funcs.FindControls(this.Controls, controls);
                foreach (var control in controls)
                {
                    switch (control)
                    {
                        case  DeliveryClassification deliveryClassfication:
                            // DeliveryClassificationコントロールへの設定
                            if (!string.IsNullOrEmpty(deliveryClassfication.PanelNumber.ToString()))
                            {
                                var rows = recs.Select($"HG_Delivery_Code = '{deliveryClassfication.PanelNumber}'");
                                //配送モードのTextBoxへ設定
                                if (!string.IsNullOrEmpty(deliveryClassfication.LblTxtBoxDBColumnName))
                                {
                                    deliveryClassfication.LblTxtBoxValue = rows[0][deliveryClassfication.LblTxtBoxDBColumnName].ToString();
                                }

                                //出荷時間のDateTimePickerに設定
                                if (!string.IsNullOrEmpty(deliveryClassfication.LblDTPDBColumnName))
                                {
                                    bool resultDateTime = DateTime.TryParse(rows[0][deliveryClassfication.LblDTPDBColumnName].ToString(), out DateTime default_Delivery_Time);
                                    if (resultDateTime)
                                    {
                                        deliveryClassfication.LblDTPValue = default_Delivery_Time;
                                    }
                                }

                                //ソート順のラジオボタンに設定
                                if (!string.IsNullOrEmpty(deliveryClassfication.LblRbtsDBColumnName))
                                {
                                    bool resultSortOrder = int.TryParse(rows[0][deliveryClassfication.LblRbtsDBColumnName].ToString(), out int sortOrder);
                                    if (resultSortOrder)
                                    {
                                        RadioButtonCheck(control, sortOrder);
                                    }
                                }

                                //ASK対象のチェックボックスに設定
                                if (!string.IsNullOrEmpty(deliveryClassfication.LblChkDBColumnName))
                                {
                                    if (Convert.ToByte(rows[0][deliveryClassfication.LblChkDBColumnName]) == 1)
                                    {
                                        deliveryClassfication.CheckState.Checked = true;
                                    }
                                    else
                                    {
                                        deliveryClassfication.CheckState.Checked = false;
                                    }
                                }                                    
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        /// <summary>
        /// 取得した配送区分マスターのSortOrderから、チェックを入れるラジオボタンを選ぶ
        /// </summary>
        /// <param name="control"></param>
        /// <param name="sortOrder"></param>
        private void RadioButtonCheck(Control control,int sortOrder)
        {
            switch (sortOrder)
            {
                case 1:
                    ((DeliveryClassification)control).Rbt1CheckState.Checked = true;
                    break;
                case 2:
                    ((DeliveryClassification)control).Rbt2CheckState.Checked = true;
                    break;
                case 3:
                    ((DeliveryClassification)control).Rbt3CheckState.Checked = true;
                    break;
                case 4:
                    ((DeliveryClassification)control).Rbt4CheckState.Checked = true;
                    break;
                case 5:
                    ((DeliveryClassification)control).Rbt5CheckState.Checked = true;
                    break;
                case 6:
                    ((DeliveryClassification)control).Rbt6CheckState.Checked = true;
                    break;
                case 7:
                    ((DeliveryClassification)control).Rbt7CheckState.Checked = true;
                    break;
                case 8:
                    ((DeliveryClassification)control).Rbt8CheckState.Checked = true;
                    break;
                case 9:
                    ((DeliveryClassification)control).Rbt9CheckState.Checked = true;
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region 画面上で変更された配達設定をDBへ反映する
        /// <summary>
        /// 画面上で変更された配達設定をDBへ反映する
        /// </summary>
        private void RegistData()
        {
            using (var db = new SqlBase(SqlBase.DatabaseKind.NPMAIN, SqlBase.TransactionUse.Yes, Log.ApplicationType.Databasemanager))
            {
                try
                {
                    // フォームで定義された、取得値設定先のコントロールを抽出する
                    db.FromDeliveryClassification(this.Controls, "Delivery", "HG_Delivery_Kanji", "Default_Delivery_Time", "Sort_Order", "Must_Notify", "HG_Delivery_Code");
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

        #region DeliveryClassificationにTextOrValueChangedイベントハンドラーをセットする
        /// <summary>
        /// DeliveryClassificationにTextOrValueChangedのTextOrValueChangedイベントハンドラーをセットする
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
                    case DeliveryClassification deliveryClassfication:
                        ((DeliveryClassification)control).ValueTextBox.TextChanged += new System.EventHandler(TextOrValueChanged);
                        ((DeliveryClassification)control).ValueDateTimePicker.TextChanged += new System.EventHandler(TextOrValueChanged);
                        #region ラジオボタンの選択状態変化について　修正する予定
                        ((DeliveryClassification)control).Rbt1CheckState.CheckedChanged += new System.EventHandler(TextOrValueChanged);
                        ((DeliveryClassification)control).Rbt2CheckState.CheckedChanged += new System.EventHandler(TextOrValueChanged);
                        ((DeliveryClassification)control).Rbt3CheckState.CheckedChanged += new System.EventHandler(TextOrValueChanged);
                        ((DeliveryClassification)control).Rbt4CheckState.CheckedChanged += new System.EventHandler(TextOrValueChanged);
                        ((DeliveryClassification)control).Rbt5CheckState.CheckedChanged += new System.EventHandler(TextOrValueChanged);
                        ((DeliveryClassification)control).Rbt6CheckState.CheckedChanged += new System.EventHandler(TextOrValueChanged);
                        ((DeliveryClassification)control).Rbt7CheckState.CheckedChanged += new System.EventHandler(TextOrValueChanged);
                        ((DeliveryClassification)control).Rbt8CheckState.CheckedChanged += new System.EventHandler(TextOrValueChanged);
                        ((DeliveryClassification)control).Rbt9CheckState.CheckedChanged += new System.EventHandler(TextOrValueChanged);
                        #endregion
                        ((DeliveryClassification)control).CheckState.CheckStateChanged += new System.EventHandler(TextOrValueChanged);
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

    }
}
