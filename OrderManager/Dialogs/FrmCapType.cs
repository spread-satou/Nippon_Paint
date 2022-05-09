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
using System.Windows.Forms;
using System.Collections.Generic;
using NipponPaint.NpCommon;
using NipponPaint.NpCommon.Database;
using NipponPaint.NpCommon.FormControls;
using NipponPaint.NpCommon.Settings;
using Sql = NipponPaint.NpCommon.Database.Sql;
#endregion

namespace NipponPaint.OrderManager.Dialogs
{
    /// <summary>
    /// キャップタイプダイアログ
    /// </summary>
    public partial class FrmCapType : BaseForm
    {
        #region DataGridViewの列定義
        private List<GridViewSetting> ViewSettings = new List<GridViewSetting>()
        {
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.Numeric, ColumnName = "Cap_Type", DisplayName = "キャップタイプ", Visible = true, Width = 130, alignment = DataGridViewContentAlignment.MiddleCenter } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = "Cap_Description", DisplayName = "キャップ詳細", Visible = true, Width = 200, alignment = DataGridViewContentAlignment.MiddleLeft } },
        };
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="vm"></param>
        public FrmCapType(ViewModels.CapTypeData vm)
        {
            InitializeComponent();
            TxtCapType.Value = vm.CapType.ToString();
            TxtCapDescription.Value = vm.CapDescription;
            TxtCapSize.Value = vm.CapSize.ToString();
            TxtCapWeight.Value = vm.CapWeight.ToString();
            TxtCappingMachine.Value = vm.CappingMachine.ToString();
            dialogEditButtons.InsertMethod = ExecuteInsert;
            dialogEditButtons.UpdateMethod = ExecuteUpdate;
            dialogEditButtons.ValidationMethod = Validation;
            dialogEditButtons.MsgMethod = InvalidMeg;
            InitializeForm();
        }
        #endregion

        #region イベント
        /// <summary>
        /// ダイアログ表示後
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCapTypeShown(object sender, EventArgs e)
        {
            PutLog(Sentence.Messages.OpenMainForm);
        }
        /// <summary>
        /// 一覧の行選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvListSelectionChanged(object sender, EventArgs e)
        {
            var columnIndex = ViewSettings.FindIndex(x => x.ColumnName == "Cap_Type");           
            var dgv = (DataGridView)sender;
            if (dgv.SelectedRows.Count > 0)
            {
                // 選択している行を取得
                var selectedRow = dgv.SelectedRows[0];
                int.TryParse(selectedRow.Cells[columnIndex].Value.ToString(), out int capType);
                using (var db = new SqlBase(SqlBase.DatabaseKind.ORDER, SqlBase.TransactionUse.No, Log.ApplicationType.OrderManager))
                {
                    // 行取得のSQLを作成
                    var parameter = new List<ParameterItem>()
                    {
                        new ParameterItem("capType", capType),
                    };
                    var rec = db.Select(Sql.Order.CapTypes.GetDetail(), parameter);
                    // フォームで定義された、取得値設定先のコントロールを抽出する
                    db.ToLabelTextBox(this.Controls, rec.Rows);
                    // 編集用コントロールにUpdate文の条件式用にIDをセットする
                    var controls = new List<Control>();
                    Funcs.FindControls(this.Controls, controls);
                    foreach (var control in controls)
                    {
                        switch (control)
                        {
                            case LabelNumericUpDown labelNumericUpDown:
                                ((LabelNumericUpDown)control).Id = capType.ToString();
                                break;
                            case LabelDropDown labelDropDown:
                                ((LabelDropDown)control).Id = capType.ToString();
                                break;
                            default:
                                break;
                        }
                    }
                    //キャップ詳細の保持動作
                    TxtCapDescription.Id = capType.ToString();
                    //手動キャッピング(1のとき（キャッパー)のときはチェックあり、1以外のとき（手動）はチェックなし）の保持動作
                    int.TryParse(rec.Rows[0]["Capping_Machine"].ToString(), out int capping_Machine);
                    if (capping_Machine != 1)
                    {
                        ChkManualCapping.Visible = true;
                        ChkManualCapping.Checked = true;
                        ChkManualCapping.Enabled = false;
                    }
                    else
                    {
                        ChkManualCapping.Visible = false;
                        ChkManualCapping.Checked = false;
                        ChkManualCapping.Enabled = true;
                    }
                }
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
                    case Keys.F5:
                        // 新規
                        dialogEditButtons.Create.PerformClick();
                        break;
                    case Keys.F2:
                        // 修正
                        dialogEditButtons.Modify.PerformClick();
                        break;
                    case Keys.F4:
                        // 削除
                        dialogEditButtons.Delete.PerformClick();
                        break;
                }
            }
            catch(Exception ex)
            {
                PutLog(ex);
            }
        }
        /// <summary>
        /// 新規作成ボタン(F5)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCreateClick(object sender, EventArgs e)
        {
            try
            {
                ValueSetting();
                VisibleSetting();
                
                DataGridViewEnabled();
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
            }
            catch(Exception ex)
            {
                PutLog(ex);
            }
        }
        /// <summary>
        /// 更新ボタン(F2)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BtnModifyClick(object sender, EventArgs e)
        {
            try
            {
                ValueSetting();
                VisibleSetting();
                DataGridViewEnabled();
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
            }
            catch(Exception ex)
            {
                PutLog(ex);
            }
        }
        /// <summary>
        /// 削除ボタン(F4)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDeleteClick(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("選択されたキャップタイプは削除されます。続けますか？", "Confirm", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes:
                        ExecuteDelete();
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }
                InitializeGridViewLayout();
                ValueSetting();
                VisibleSetting();
                DataGridViewEnabled();
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }
        /// <summary>
        /// 終了ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExitClick(object sender, EventArgs e)
        {
            try
            {
                ValueSetting();
                VisibleSetting();
                DataGridViewEnabled();
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                this.Close();
            }
            catch(Exception ex)
            {
                PutLog(ex);
            }
        }
        /// <summary>
        /// OK（登録）ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRegistClick(object sender, EventArgs e)
        {
            try
            {
                InitializeGridViewLayout();
                ValueSetting();
                VisibleSetting();
                DataGridViewEnabled();
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }
        /// <summary>
        /// キャンセルボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancelClick(object sender, EventArgs e)
        {
            try
            {
                ValueSetting();
                VisibleSetting();
                DataGridViewEnabled();
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
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
            // コントロールの配置
            DrpCapSize.Location = TxtCapSize.Location;
            NumCapWeight.Location = TxtCapWeight.Location;
            DrpCappingMachine.Location = TxtCappingMachine.Location;
            // イベントの追加
            this.Shown += new System. EventHandler(this.FrmCapTypeShown);
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(this.FormKeyDown);
            this.dialogEditButtons.Create.Click += new EventHandler(this.BtnCreateClick);
            this.dialogEditButtons.Modify.Click += new EventHandler(this.BtnModifyClick);
            this.dialogEditButtons.Delete.Click += new EventHandler(this.BtnDeleteClick);
            this.dialogEditButtons.Exit.Click += new EventHandler(this.BtnExitClick);
            this.dialogEditButtons.Regist.Click += new EventHandler(this.BtnRegistClick);
            this.dialogEditButtons.Cancel.Click += new EventHandler(this.BtnCancelClick);
            this.DgvList.SelectionChanged += new EventHandler(this.DgvListSelectionChanged);
            this.ChkManualCapping.CheckedChanged += new System.EventHandler(this.ChkManualCapping_CheckedChanged);
            // DataGridViewの初期設定
            InitializeGridView(DgvList);
            // 一覧表示
            PreviewData();
            // 一覧レイアウトの設定
            var cnt = 0;
            foreach (var item in ViewSettings)
            {
                DgvList.Columns[cnt].Width = item.Width;
                DgvList.Columns[cnt].Visible = item.Visible;
                DgvList.Columns[cnt].DefaultCellStyle.Alignment = item.alignment;
                cnt++;
            }
            // データ表示部の設定
            DrpCapSize.DropDown.Items.AddRange(new string[] { "50", "70" });
            DrpCapSize.DropDown.SelectedIndex = 0;
            DrpCappingMachine.DropDown.Items.AddRange(new string[] { "1" });
            DrpCappingMachine.DropDown.SelectedIndex = 0;
            VisibleSetting();
            Funcs.SetControlEnabled(this.Controls, true);
        }
        #endregion

        #region DataGridView初期化 
        /// <summary>
        /// DataGridView初期化 
        /// </summary>
        private void InitializeGridViewLayout()
        {
            // DataGridViewの初期設定
            InitializeGridView(DgvList);
            // 一覧表示
            PreviewData();
            // 一覧レイアウトの設定
            var cnt = 0;
            foreach (var item in ViewSettings)
            {
                DgvList.Columns[cnt].Width = item.Width;
                DgvList.Columns[cnt].Visible = item.Visible;
                DgvList.Columns[cnt].DefaultCellStyle.Alignment = item.alignment;
                cnt++;
            }
        }
        #endregion

        #region 一覧表示
        /// <summary>
        /// 一覧表示
        /// </summary>
        private void PreviewData()
        {
            // DataGridViewの表示
            using (var db = new SqlBase(SqlBase.DatabaseKind.ORDER, SqlBase.TransactionUse.No, Log.ApplicationType.OrderManager))
            {
                var result = db.Select(Sql.Order.CapTypes.GetPreview(ViewSettings));
                DgvList.DataSource = result;
            }
        }
        #endregion

        #region DataGridView選択制御
        /// <summary>
        /// DataGridView選択制御
        /// </summary>
        private void DataGridViewEnabled()
        {
            switch (dialogEditButtons.EditMode)
            {
                //新規作成
                case DialogEditButtons.Mode.Create:
                    DgvList.Enabled = false;
                    break;
                //更新
                case DialogEditButtons.Mode.Modify:
                    DgvList.Enabled = false;
                    break;
                default:
                    DgvList.Enabled = true;
                    break;
            }
        }
        #endregion

        #region 編集状況による入力コントロールの可視制御
        /// <summary>
        /// 編集状況による入力コントロールの可視制御
        /// </summary>
        private void VisibleSetting()
        {
            switch (dialogEditButtons.EditMode)
            {
                //新規作成
                case DialogEditButtons.Mode.Create:
                    // 表示用コントロール
                    TxtCapType.Visible = false;
                    TxtCapSize.Visible = false;
                    TxtCapWeight.Visible = false;
                    TxtCappingMachine.Visible = false;
                    ChkManualCapping.Checked = false;
                    ChkManualCapping.Visible = true;
                    ChkManualCapping.Enabled = true;
                    // 編集用コントロール
                    TxtCapDescription.DataReadOnly = false;
                    TxtCapDescription.Value = "";
                    DrpCapSize.Visible = true;
                    NumCapWeight.Visible = true;
                    DrpCappingMachine.Visible = true;
                    break;
                    //
                  //更新
                case DialogEditButtons.Mode.Modify:
                    // 表示用コントロール
                    TxtCapSize.Visible = false;
                    TxtCapWeight.Visible = false;
                    TxtCappingMachine.Visible = false;
                    ChkManualCapping.Visible = true;
                    ChkManualCapping.Enabled = true;
                    // 編集用コントロール
                    TxtCapDescription.DataReadOnly = false;
                    DrpCapSize.Visible = true;
                    NumCapWeight.Visible = true;
                    if (TxtCappingMachine.Value != "1")
                    {
                        DrpCappingMachine.Visible = false;
                    }
                    else
                    {
                        DrpCappingMachine.Visible = true;
                    }
                    break;
                    //
                default:
                    // 表示用コントロール
                    TxtCapType.Visible = true;
                    TxtCapSize.Visible = true;
                    TxtCapWeight.Visible = true;
                    if (TxtCappingMachine.Value != "1")
                    {
                        TxtCappingMachine.Visible = false;
                        ChkManualCapping.Visible = true;
                        ChkManualCapping.Checked = true;
                        ChkManualCapping.Enabled = false;
                    }
                    else
                    {
                        TxtCappingMachine.Visible = true;
                        ChkManualCapping.Visible = false;
                        ChkManualCapping.Checked = false;
                        ChkManualCapping.Enabled = true;
                    }
                    // 編集用コントロール
                    DrpCapSize.Visible = false;
                    TxtCapType.DataReadOnly = true;
                    TxtCapDescription.DataReadOnly = true;
                    NumCapWeight.Visible = false;
                    DrpCappingMachine.Visible = false;
                    break;
            }
        }
        #endregion

        #region 編集用コントロールの初期値制御
        /// <summary>
        /// 編集用コントロールの初期値制御
        /// </summary>
        private void ValueSetting()
        {
            var columnIndex = ViewSettings.FindIndex(x => x.ColumnName == "Cap_Type");
            if (DgvList.SelectedRows.Count > 0)
            {
                // 選択している行を取得
                var selectedRow = DgvList.SelectedRows[0];
                int.TryParse(selectedRow.Cells[columnIndex].Value.ToString(), out int capType);
                using (var db = new SqlBase(SqlBase.DatabaseKind.ORDER, SqlBase.TransactionUse.No, Log.ApplicationType.OrderManager))
                {
                    // 行取得のSQLを作成
                    var parameter = new List<ParameterItem>()
                    {
                        new ParameterItem("capType", capType),
                    };
                    var rec = db.Select(Sql.Order.CapTypes.GetDetail(), parameter);
                    switch (dialogEditButtons.EditMode)
                    {
                        //表示
                        case DialogEditButtons.Mode.View:
                            TxtCapDescription.Value = rec.Rows[0][TxtCapDescription.DatabaseColumnName].ToString().Trim();
                            break;
                        //新規作成
                        case DialogEditButtons.Mode.Create:
                            TxtCapDescription.Value = "";
                            DrpCapSize.DropDown.Text = "50";
                            NumCapWeight.Value = 1000;
                            DrpCappingMachine.DropDown.Text = "1";
                            break;
                        //更新
                        case DialogEditButtons.Mode.Modify:
                            // フォームで定義された、取得値設定先のコントロールを抽出する
                            TxtCapDescription.Value = rec.Rows[0][TxtCapDescription.DatabaseColumnName].ToString().Trim();
                            db.ToLabelDropDown(this.Controls, rec.Rows);
                            db.ToLabelNumericUpDown(this.Controls, rec.Rows);
                            break;
                        default:
                            TxtCapDescription.Value = "";
                            DrpCapSize.DropDown.Text = "50";
                            NumCapWeight.Value = 1000;
                            DrpCappingMachine.DropDown.Text = "1";
                            break;
                    }
                }
            }
        }
        #endregion

        #region　画面コントロールからデータベースへの反映処理

        #region 新規作成処理
        /// <summary>
        /// 新規作成処理
        /// </summary>
        private void ExecuteInsert()
        {
            using (var db = new SqlBase(SqlBase.DatabaseKind.ORDER, SqlBase.TransactionUse.Yes, Log.ApplicationType.OrderManager))
            {             
                try
                {
                    //入力したフォームの内容をデータベースに新規登録する
                    db.Insert(this.Controls, "Cap_types");
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

        #region 更新処理
        /// <summary>
        /// 更新処理
        /// </summary>
        private void ExecuteUpdate()
        {
            using (var db = new SqlBase(SqlBase.DatabaseKind.ORDER, SqlBase.TransactionUse.Yes, Log.ApplicationType.OrderManager))
            {
                try
                {
                    // フォームで定義された、指定LOT設定先のコントロールを抽出する
                    db.FromLabelTextBox(this.Controls, "Cap_Types", "Cap_Type");
                    db.FromLabelDropDown(this.Controls, "Cap_Types", "Cap_Type");
                    db.FromLabelNumericUpDown(this.Controls, "Cap_Types", "Cap_Type");

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

        #region 削除処理
        /// <summary>
        /// 削除処理
        /// </summary>
        private void ExecuteDelete()
        {
            using (var db = new SqlBase(SqlBase.DatabaseKind.ORDER, SqlBase.TransactionUse.Yes, Log.ApplicationType.OrderManager))
            {
                if (!string.IsNullOrEmpty(TxtCapType.Value))
                {                    
                    try
                    {
                        //指定した1行のデータをデータベースから物理削除する
                        db.Delete(TxtCapType.Value, "Cap_types", "Cap_Type");
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
        }
        #endregion

        /// <summary>
        /// 手動キャッピングにチェックを入れたとき、キャッパーが表示しなくなる処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChkManualCapping_CheckedChanged(object sender, EventArgs e)
        {
            switch (dialogEditButtons.EditMode)
            {
                //表示
                case DialogEditButtons.Mode.View:
                    if (ChkManualCapping.Checked)
                    {
                        TxtCappingMachine.Visible = false;
                    }
                    else
                    {
                        TxtCappingMachine.Visible = true;
                    }
                    break;
                //新規作成 or 更新
                default:
                    DrpCappingMachine.DropDown.Items.Clear();
                    if (ChkManualCapping.Checked)
                    {
                        DrpCappingMachine.Visible = false;
                        DrpCappingMachine.DropDown.Items.Add("128");
                        DrpCappingMachine.DropDown.SelectedItem = "128";
                    }
                    else
                    {
                        DrpCappingMachine.Visible = true;
                        DrpCappingMachine.DropDown.Items.Add("1");
                        DrpCappingMachine.DropDown.SelectedItem = "1";
                    }
                    break;
            }
        }
        #endregion

        #region 検証
        //OKボタン押下時の正常動作
        private bool Validation()
        {
            bool result = false;
            if (!string.IsNullOrEmpty(TxtCapDescription.Value))
            {
                result = true;
            }
            return result;
        }
        //OKボタン押下時の不完全動作
        private bool InvalidMeg()
        {
            bool modeChangeFlg = true;
            MessageBox.Show("不完全データ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return modeChangeFlg;
        }
        #endregion

        #endregion
    }
}