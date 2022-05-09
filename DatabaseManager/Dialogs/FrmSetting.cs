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
    /// 設定
    /// </summary>
    public partial class FrmSetting : Form
    {
        static string title = "information";
        static string msg = "クローズ前に設定を保存してください";

        #region コンストラクタ
        public FrmSetting()
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
                case Keys.O | Keys.Alt:
                    BtnMixingColorsOperators.PerformClick();
                    break;
                case Keys.C | Keys.Alt:
                    BtnDisplayColors.PerformClick();
                    break;
                case Keys.D | Keys.Alt:
                    BtnDeliverySetting.PerformClick();
                    break;
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
        /// 調色担当
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMixingColorsOperatorsClick(object sender, EventArgs e)
        {
            BaseForm baseForm = new BaseForm();
            try
            {
                baseForm.PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                FrmMixingColorsOperators frmMixingColorsOperators = new FrmMixingColorsOperators();
                frmMixingColorsOperators.ShowDialog();               
            }
            catch (Exception ex)
            {
                baseForm.PutLog(ex);
            }
        }

        /// <summary>
        /// 表示色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDisplayColorsClick(object sender, EventArgs e)
        {
            BaseForm baseForm = new BaseForm();
            try
            {
                baseForm.PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                FrmDisplayColors frmDisplayColors = new FrmDisplayColors();
                frmDisplayColors.ShowDialog();
            }
            catch (Exception ex)
            {
                baseForm.PutLog(ex);
            }
        }

        /// <summary>
        /// 配達設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDeliverySettingClick(object sender, EventArgs e)
        {
            BaseForm baseForm = new BaseForm();
            try
            {
                baseForm.PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                FrmDeliverySetting frmDeliverySetting = new FrmDeliverySetting();
                frmDeliverySetting.ShowDialog();
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
                //工場テーブルを全件取得して画面に表示する
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
                //画面上で変更された設定をDBへ反映する
                RegistData();
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
            this.BtnClose.Click += new System.EventHandler(this.BtnCloseClick);
            this.BtnSettingSave.Click += new System.EventHandler(this.BtnSettingSaveClick);
            this.BtnSettingInitialize.Click += new System.EventHandler(this.BtnSettingInitializeClick);
            this.BtnDeliverySetting.Click += new System.EventHandler(this.BtnDeliverySettingClick);
            this.BtnDisplayColors.Click += new System.EventHandler(this.BtnDisplayColorsClick);
            this.BtnMixingColorsOperators.Click += new System.EventHandler(this.BtnMixingColorsOperatorsClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmKeyDown);
            //工場テーブルを全件取得して画面に表示する
            PreviewData();
            //保存/元に戻すボタンをEnabled = false にする
            ButtonEnabledFalse();
            //すべての入力欄、チェックボックスにTextOrValueChangedのイベントハンドラーをセットする
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

        #region 工場テーブル、mainテーブル、設備設定テーブルを取得して画面に表示する
        /// <summary>
        /// 工場テーブル、mainテーブル、設備設定テーブルを取得して画面に表示する
        /// </summary>
        private void PreviewData()
        {
            using (var db = new SqlBase(SqlBase.DatabaseKind.NPMAIN, SqlBase.TransactionUse.No, Log.ApplicationType.Databasemanager))
            {
                // 行取得のSQLを作成
                var recs = db.Select(Sql.NpMain.Plants.GetPreview());
                var main = db.Select(Sql.NpMain.MainSet.GetPreview());
                var setting = db.Select(Sql.NpMain.PlantsSettings.GetPreview());
                // フォームで定義された、取得値設定先のコントロールを抽出する
                var controls = new List<Control>();
                Funcs.FindControls(this.Controls, controls);
                foreach (var control in controls)
                {
                    switch (control)
                    {
                        case TabCtrlPagePlants tabCtrlPagePlants:
                            //TabCtrlPagePlantsコントロールへの設定
                            if (!string.IsNullOrEmpty(tabCtrlPagePlants.PanelNumber.ToString()))
                            {
                                var rows = recs.Select($"Plant_ID = '{tabCtrlPagePlants.PanelNumber}'");
                                //工事名のTextBoxへ設定
                                if (!string.IsNullOrEmpty(tabCtrlPagePlants.LblTxtBoxDBColumnName))
                                {
                                    tabCtrlPagePlants.LblTxtBoxValue = rows[0][tabCtrlPagePlants.LblTxtBoxDBColumnName].ToString();
                                }

                                //１日の製造可能缶数(数)のNumericUpDownへ設定
                                if (!string.IsNullOrEmpty(tabCtrlPagePlants.LblNud1DBColumnName))
                                {
                                    bool result = decimal.TryParse(rows[0][tabCtrlPagePlants.LblNud1DBColumnName].ToString(), out decimal decResult);
                                    if (result)
                                    {
                                        tabCtrlPagePlants.LblNud1Value = decResult;
                                    }
                                }

                                //１日の製造時間(分)のNumericUpDownへ設定
                                if (!string.IsNullOrEmpty(tabCtrlPagePlants.LblNud2DBColumnName))
                                {
                                    bool result = decimal.TryParse(rows[0][tabCtrlPagePlants.LblNud2DBColumnName].ToString(), out decimal decResult);
                                    if (result)
                                    {
                                        tabCtrlPagePlants.LblNud2Value = decResult;
                                    }
                                }

                                //開始時間のDateTimePickerへ設定
                                if (!string.IsNullOrEmpty(tabCtrlPagePlants.LblDTPDBColumnName))
                                {
                                    bool result = DateTime.TryParse(rows[0][tabCtrlPagePlants.LblDTPDBColumnName].ToString(), out DateTime decResult);
                                    if (result)
                                    {
                                        tabCtrlPagePlants.LblDTPValue = decResult;
                                    }
                                }                                                          
                            }
                            break;
                        case TabPageEx tabPageEx:
                            //TabPageコンポーネントへの設定
                            if (!string.IsNullOrEmpty(tabPageEx.PanelNumber.ToString()))
                            {
                                if (!string.IsNullOrEmpty(tabPageEx.DatabaseColumnName))
                                {
                                    var rows = recs.Select($"Plant_ID = '{tabPageEx.PanelNumber}'");
                                    tabPageEx.Text = rows[0][tabPageEx.DatabaseColumnName].ToString().Trim();
                                }
                            }
                                break;
                        case TabCtrlPagePlantsSetting tabCtrlPagePlantsSetting:
                            //TabCtrlPagePlantsSettingsコントロールへの設定
                            if (!string.IsNullOrEmpty(tabCtrlPagePlantsSetting.PanelNumber.ToString()))
                            {
                                var rows = setting.Select($"id = '{tabCtrlPagePlantsSetting.PanelNumber}'");
                                //FTPホスト名のTextBoxへ設定
                                if (!string.IsNullOrEmpty(tabCtrlPagePlantsSetting.LblTxtBox1DBColumnName))
                                {
                                    tabCtrlPagePlantsSetting.LblTxtBox1Value = rows[0][tabCtrlPagePlantsSetting.LblTxtBox1DBColumnName].ToString();
                                }

                                //ユーザー名のTextBoxへ設定
                                if (!string.IsNullOrEmpty(tabCtrlPagePlantsSetting.LblTxtBox2DBColumnName))
                                {
                                    tabCtrlPagePlantsSetting.LblTxtBox2Value = rows[0][tabCtrlPagePlantsSetting.LblTxtBox2DBColumnName].ToString();
                                }

                                //パスワードのTextBoxへ設定
                                if (!string.IsNullOrEmpty(tabCtrlPagePlantsSetting.LblTxtBox3DBColumnName))
                                {
                                    tabCtrlPagePlantsSetting.LblTxtBox3Value = rows[0][tabCtrlPagePlantsSetting.LblTxtBox3DBColumnName].ToString();
                                }
                               
                                //送信位置のTextBoxへ設定
                                if (!string.IsNullOrEmpty(tabCtrlPagePlantsSetting.LblTxtBox4DBColumnName))
                                {
                                    tabCtrlPagePlantsSetting.LblTxtBox4Value = rows[0][tabCtrlPagePlantsSetting.LblTxtBox4DBColumnName].ToString();
                                }
                                
                                //Receive PathのTextBoxへ設定
                                if (!string.IsNullOrEmpty(tabCtrlPagePlantsSetting.LblTxtBox5DBColumnName))
                                {
                                    tabCtrlPagePlantsSetting.LblTxtBox5Value = rows[0][tabCtrlPagePlantsSetting.LblTxtBox5DBColumnName].ToString();
                                }
                              
                                //通知パスのTextBoxへ設定
                                if (!string.IsNullOrEmpty(tabCtrlPagePlantsSetting.LblTxtBox6DBColumnName))
                                {
                                    tabCtrlPagePlantsSetting.LblTxtBox6Value = rows[0][tabCtrlPagePlantsSetting.LblTxtBox6DBColumnName].ToString();
                                }
                                
                                //荷送人コードのTextBoxへ設定
                                if (!string.IsNullOrEmpty(tabCtrlPagePlantsSetting.LblTxtBox7DBColumnName))
                                {
                                    tabCtrlPagePlantsSetting.LblTxtBox7Value = rows[0][tabCtrlPagePlantsSetting.LblTxtBox7DBColumnName].ToString();
                                }
                                
                                //荷送人住所1のTextBoxへ設定
                                if (!string.IsNullOrEmpty(tabCtrlPagePlantsSetting.LblTxtBox8DBColumnName))
                                {
                                    tabCtrlPagePlantsSetting.LblTxtBox8Value = rows[0][tabCtrlPagePlantsSetting.LblTxtBox8DBColumnName].ToString();
                                }
                                
                                //荷送人住所2のTextBoxへ設定
                                if (!string.IsNullOrEmpty(tabCtrlPagePlantsSetting.LblTxtBox9DBColumnName))
                                {
                                    tabCtrlPagePlantsSetting.LblTxtBox9Value = rows[0][tabCtrlPagePlantsSetting.LblTxtBox9DBColumnName].ToString();
                                }
                                
                                //荷送人(社名)のTextBoxへ設定
                                if (!string.IsNullOrEmpty(tabCtrlPagePlantsSetting.LblTxtBox10DBColumnName))
                                {
                                    tabCtrlPagePlantsSetting.LblTxtBox10Value = rows[0][tabCtrlPagePlantsSetting.LblTxtBox10DBColumnName].ToString();
                                }
                                

                                //荷送人(支店名)のTextBoxへ設定
                                if (!string.IsNullOrEmpty(tabCtrlPagePlantsSetting.LblTxtBox11DBColumnName))
                                {
                                    tabCtrlPagePlantsSetting.LblTxtBox11Value = rows[0][tabCtrlPagePlantsSetting.LblTxtBox11DBColumnName].ToString();
                                }
                                

                                //TELのTextBoxへ設定
                                if (!string.IsNullOrEmpty(tabCtrlPagePlantsSetting.LblTxtBox12DBColumnName))
                                {
                                    tabCtrlPagePlantsSetting.LblTxtBox12Value = rows[0][tabCtrlPagePlantsSetting.LblTxtBox12DBColumnName].ToString();
                                }


                                //PortのNumericUpDownへ設定
                                if (!string.IsNullOrEmpty(tabCtrlPagePlantsSetting.LblNud1DBColumnName))
                                {
                                    bool result = decimal.TryParse(rows[0][tabCtrlPagePlantsSetting.LblNud1DBColumnName].ToString(), out decimal decResult);
                                    if (result)
                                    {
                                        tabCtrlPagePlantsSetting.LblNud1Value = decResult;
                                    }
                                }

                                //FTP接続有効のチェックボックスに設定
                                if (!string.IsNullOrEmpty(tabCtrlPagePlantsSetting.LblChkDBColumnName))
                                {
                                    //自動完了通知のチェックボックスに設定
                                    if (Convert.ToByte(rows[0][tabCtrlPagePlantsSetting.LblChkDBColumnName]) == 1)
                                    {
                                        tabCtrlPagePlantsSetting.CheckState.Checked = true;
                                    }
                                    else
                                    {
                                        tabCtrlPagePlantsSetting.CheckState.Checked = false;
                                    }
                                }
                            }
                            break;
                        case LabelTextBox labelTextBox:
                            // LabelTextBoxコントロールへの設定
                            if (!string.IsNullOrEmpty(labelTextBox.DatabaseColumnName))
                            {
                                labelTextBox.Value = main.Rows[0][labelTextBox.DatabaseColumnName].ToString().Trim();
                            }
                            break;
                        case LabelNumericUpDown labelNumericUpDown:
                            //LabelNumericUpDownコントロールへの設定
                            if (!string.IsNullOrEmpty(labelNumericUpDown.DatabaseColumnName))
                            {
                                bool result = decimal.TryParse(main.Rows[0][labelNumericUpDown.DatabaseColumnName].ToString(), out decimal decResult);
                                if (result)
                                {
                                    labelNumericUpDown.Value = decResult;
                                }
                            }                               
                            break;
                        case LabelNumericUpDownMulti labelNumericUpDownMulti:
                            //LabelNumericUpDownMultiコントロールへの設定
                            if (!string.IsNullOrEmpty(labelNumericUpDownMulti.DatabaseColumnNameLeft) && !string.IsNullOrEmpty(labelNumericUpDownMulti.DatabaseColumnNameRight))
                            {
                                bool leftResult = decimal.TryParse(main.Rows[0][labelNumericUpDownMulti.DatabaseColumnNameLeft].ToString(), out decimal decLeftResult);
                                bool rightResult = decimal.TryParse(main.Rows[0][labelNumericUpDownMulti.DatabaseColumnNameRight].ToString(), out decimal decrRightResult);
                                if (leftResult)
                                {
                                    ((LabelNumericUpDownMulti)control).ValueLeft = decLeftResult;
                                }
                                if (rightResult)
                                {
                                    ((LabelNumericUpDownMulti)control).ValueRight = decrRightResult;
                                }
                            }
                            break;
                        case LabelCheckBoxSingle labelCheckBoxSingle:
                            //LabelCheckBoxSingleコントロールへの設定
                            if (!string.IsNullOrEmpty(labelCheckBoxSingle.DatabaseColumnName))
                            {
                                //自動完了通知のチェックボックスに設定
                                if (Convert.ToByte(main.Rows[0][labelCheckBoxSingle.DatabaseColumnName]) == 1)
                                {
                                    labelCheckBoxSingle.CheckState.Checked = true;
                                }
                                else
                                {
                                    labelCheckBoxSingle.CheckState.Checked = false;
                                }
                            }
                            break;
                        case TextBox TextBox:
                            //TextBoxコントロールへの設定
                            TextBox.Text = main.Rows[0]["CSV_Path"].ToString();
                            break;                        
                        case LabelDateTimePicker labelDateTimePicker:
                            //LabelDateTimePickerコントロールへの設定
                            if (!string.IsNullOrEmpty(labelDateTimePicker.DatabaseColumnName))
                            {
                                bool result = DateTime.TryParse(main.Rows[0][labelDateTimePicker.DatabaseColumnName].ToString(), out DateTime decResult);
                                if (result)
                                {
                                    labelDateTimePicker.Value = decResult;
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

        #region 画面上で変更された工場をDBへ反映する
        /// <summary>
        /// 画面上で変更された工場をDBへ反映する
        /// </summary>
        private void RegistData()
        {
            using (var db = new SqlBase(SqlBase.DatabaseKind.NPMAIN, SqlBase.TransactionUse.Yes, Log.ApplicationType.Databasemanager))
            {
                try
                {
                    // フォームで定義された、工場の取得値設定先のコントロールを抽出する
                    db.FromTabCtrlPagePlants(this.Controls, "Plants", "Plant_Description", "Daily_Capability", "Daily_Working_Time", "Start_Working_Time", "Plant_ID");
                    db.FromTabCtrlPagePlantsSetting(this.Controls,
                                             "Plants_Settings",
                                             "FTP_Server",
                                             "FTP_User",
                                             "FTP_Password",
                                             "FTP_Port",
                                             "FTP_Dir_Send",
                                             "FTP_Dir_Receive",
                                             "FTP_Dir_Notify",
                                             "Enabled",
                                             "TRK_Shipper_Code",
                                             "TRK_Shipper_Address_1",
                                             "TRK_Shipper_Address_2",
                                             "TRK_Shipper_Company",
                                             "TRK_Shipper_Subsidiary",
                                             "TRK_Telephone_Number",
                                             "id");
                    db.FromLabelTextBox(this.Controls, "Main_Set", "Main_Set_Id");
                    db.FromTextBoxEx(this.Controls, "Main_Set", "Main_Set_Id");
                    db.FromLabelNumericUpDown(this.Controls, "Main_Set", "Main_Set_Id");
                    db.FromLabelNumericUpDownMulti(this.Controls, "Main_Set", "Main_Set_Id");
                    db.FromLabelCheckBoxSingle(this.Controls, "Main_Set", "Main_Set_Id");
                    db.FromLabelDateTimePicker(this.Controls, "Main_Set", "Main_Set_Id");
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

        #region すべての入力欄、チェックボックスにTextOrValueChangedのイベントハンドラーをセットする
        /// <summary>
        /// すべての入力欄、チェックボックスにTextOrValueChangedのイベントハンドラーをセットする
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
                    case LabelTextBox labelTextBox:
                        ((LabelTextBox)control).ValueTextBox.TextChanged += new System.EventHandler(TextOrValueChanged);
                        break;
                    case LabelNumericUpDown labelNumericUpDown:
                        ((LabelNumericUpDown)control).ValueNumericUpDown.ValueChanged += new System.EventHandler(TextOrValueChanged);
                        break;
                    case LabelCheckBoxSingle labelCheckBoxSingle:
                        ((LabelCheckBoxSingle)control).CheckState.CheckStateChanged += new System.EventHandler(TextOrValueChanged);
                        break;
                    case LabelNumericUpDownMulti labelNumericUpDownMulti:
                        ((LabelNumericUpDownMulti)control).LeftSide.ValueChanged += new System.EventHandler(TextOrValueChanged);
                        ((LabelNumericUpDownMulti)control).RightSide.ValueChanged += new System.EventHandler(TextOrValueChanged);
                        break;
                    case TextBox TextBox:
                        ((TextBox)control).TextChanged += new System.EventHandler(TextOrValueChanged);
                        break;
                    case TabCtrlPagePlants tabCtrlPagePlants:
                        ((TabCtrlPagePlants)control).ValueTextBox.TextChanged += new System.EventHandler(TextOrValueChanged);
                        ((TabCtrlPagePlants)control).LblNud1ValueNumericUpDown.TextChanged += new System.EventHandler(TextOrValueChanged);
                        ((TabCtrlPagePlants)control).LblNud2ValueNumericUpDown.TextChanged += new System.EventHandler(TextOrValueChanged);
                        ((TabCtrlPagePlants)control).ValueDateTimePicker.TextChanged += new System.EventHandler(TextOrValueChanged);
                        break;
                    case TabCtrlPagePlantsSetting tabCtrlPagePlantsSetting:
                        ((TabCtrlPagePlantsSetting)control).ValueTextBox1.TextChanged += new System.EventHandler(TextOrValueChanged);
                        ((TabCtrlPagePlantsSetting)control).ValueTextBox2.TextChanged += new System.EventHandler(TextOrValueChanged);
                        ((TabCtrlPagePlantsSetting)control).ValueTextBox3.TextChanged += new System.EventHandler(TextOrValueChanged);
                        ((TabCtrlPagePlantsSetting)control).ValueTextBox4.TextChanged += new System.EventHandler(TextOrValueChanged);
                        ((TabCtrlPagePlantsSetting)control).ValueTextBox5.TextChanged += new System.EventHandler(TextOrValueChanged);
                        ((TabCtrlPagePlantsSetting)control).ValueTextBox6.TextChanged += new System.EventHandler(TextOrValueChanged);
                        ((TabCtrlPagePlantsSetting)control).ValueTextBox7.TextChanged += new System.EventHandler(TextOrValueChanged);
                        ((TabCtrlPagePlantsSetting)control).ValueTextBox8.TextChanged += new System.EventHandler(TextOrValueChanged);
                        ((TabCtrlPagePlantsSetting)control).ValueTextBox9.TextChanged += new System.EventHandler(TextOrValueChanged);
                        ((TabCtrlPagePlantsSetting)control).ValueTextBox10.TextChanged += new System.EventHandler(TextOrValueChanged);
                        ((TabCtrlPagePlantsSetting)control).ValueTextBox11.TextChanged += new System.EventHandler(TextOrValueChanged);
                        ((TabCtrlPagePlantsSetting)control).ValueTextBox12.TextChanged += new System.EventHandler(TextOrValueChanged);
                        ((TabCtrlPagePlantsSetting)control).LblNud1ValueNumericUpDown.TextChanged += new System.EventHandler(TextOrValueChanged);
                        ((TabCtrlPagePlantsSetting)control).CheckState.CheckStateChanged += new System.EventHandler(TextOrValueChanged);

                        break;
                    case LabelDateTimePicker labelDateTimePicker:
                        ((LabelDateTimePicker)control).ValueDateTimePicker.TextChanged += new System.EventHandler(TextOrValueChanged);
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion
    }
}
