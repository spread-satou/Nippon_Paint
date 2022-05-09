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
    /// 缶タイプダイアログ
    /// </summary>
    public partial class FrmCanType : BaseForm
    {
        #region DataGridViewの列定義
        private List<GridViewSetting> ViewSettings = new List<GridViewSetting>()
        {
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.Numeric, ColumnName = "Can_Type", DisplayName = "缶タイプ", Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleCenter } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = "Can_Description", DisplayName = "缶詳細", Visible = true, Width = 300, alignment = DataGridViewContentAlignment.MiddleLeft } },
        };
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="vm"></param>
        public FrmCanType(ViewModels.CanTypeData vm)
        {
            InitializeComponent();
            InitializeForm();
            TxtCanType.Value = vm.CanType.ToString();
            TxtCanDescription.Value = vm.CanDescription;
            TxtHoleSize.Value = vm.HoleSize.ToString();
            TxtEmptyCanWeight.Value = vm.EmptyCanWeight.ToString();
            TxtNormalVolume.Value = vm.NormalVolume.ToString();
            TxtMaxVolume.Value = vm.MaxVolume.ToString();
            dialogEditButtons.InsertMethod = ExecuteInsert;
            dialogEditButtons.UpdateMethod = ExecuteUpdate;
            dialogEditButtons.ValidationMethod = Validation;
            dialogEditButtons.MsgMethod = InvalidMeg;
        }
        #endregion

        #region イベント
        /// <summary>
        /// ダイアログ表示後
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCanTypeShown(object sender, EventArgs e)
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
            var columnIndex = ViewSettings.FindIndex(x => x.ColumnName == "Can_Type");
            var dgv = (DataGridView)sender;
            if (dgv.SelectedRows.Count > 0)
            {
                // 選択している行を取得
                var selectedRow = dgv.SelectedRows[0];
                int.TryParse(selectedRow.Cells[columnIndex].Value.ToString(), out int canType);
                using (var db = new SqlBase(SqlBase.DatabaseKind.ORDER, SqlBase.TransactionUse.No, Log.ApplicationType.OrderManager))
                {
                    // 行取得のSQLを作成
                    var parameter = new List<ParameterItem>()
                    {
                        new ParameterItem("canType", canType),
                    };
                    var rec = db.Select(Sql.Order.CanTypes.GetDetail(), parameter);
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
                                ((LabelNumericUpDown)control).Id = canType.ToString();
                                break;
                            case LabelDropDown labelDropDown:
                                ((LabelDropDown)control).Id = canType.ToString();
                                break;
                            default:
                                break;
                        }
                    }
                    // ※特定のLabelTextBoxコントロールのみ指定してIdを付加する。
                    TxtCanDescription.Id = canType.ToString();
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
                VisibleSetting();
                ValueSetting();
                DataGridViewEnabled();
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
            }
            catch (Exception ex)
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
                VisibleSetting();
                ValueSetting();
                DataGridViewEnabled();
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
            }
            catch (Exception ex)
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
                DialogResult result = MessageBox.Show("選択された缶タイプは削除されます。続けますか？", "Confirm", MessageBoxButtons.YesNo);
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
                VisibleSetting();
                InitializeGridViewLayout();
                ValueSetting();
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
                VisibleSetting();
                ValueSetting();
                DataGridViewEnabled();
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                this.Close();
            }
            catch (Exception ex)
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
                VisibleSetting();
                InitializeGridViewLayout();
                ValueSetting();
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
                VisibleSetting();
                ValueSetting();
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
            DrpHoleSize.Location = TxtHoleSize.Location;
            NumEmptyCanWeight.Location = TxtEmptyCanWeight.Location;
            NumNormalVolume.Location = TxtNormalVolume.Location;
            NumMaxVolume.Location = TxtMaxVolume.Location;
            // イベントの追加
            this.Shown += new System. EventHandler(this.FrmCanTypeShown);
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(this.FormKeyDown);
            this.dialogEditButtons.Create.Click += new EventHandler(this.BtnCreateClick);
            this.dialogEditButtons.Modify.Click += new EventHandler(this.BtnModifyClick);
            this.dialogEditButtons.Delete.Click += new EventHandler(this.BtnDeleteClick);
            this.dialogEditButtons.Exit.Click += new EventHandler(this.BtnExitClick);
            this.dialogEditButtons.Regist.Click += new EventHandler(this.BtnRegistClick);
            this.dialogEditButtons.Cancel.Click += new EventHandler(this.BtnCancelClick);
            this.DgvList.SelectionChanged += new EventHandler(this.DgvListSelectionChanged);
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
            DrpHoleSize.DropDown.Items.AddRange(new string[] { "50", "70" });
            DrpHoleSize.DropDown.SelectedIndex = 0;
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
                var result = db.Select(Sql.Order.CanTypes.GetPreview(ViewSettings));
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
                    TxtCanType.Visible = false;
                    TxtHoleSize.Visible = false;
                    TxtEmptyCanWeight.Visible = false;
                    TxtNormalVolume.Visible = false;
                    TxtMaxVolume.Visible = false;
                    // 編集用コントロール
                    TxtCanDescription.DataReadOnly = false;
                    DrpHoleSize.Visible = true;
                    NumEmptyCanWeight.Visible = true;
                    NumNormalVolume.Visible = true;
                    NumMaxVolume.Visible = true;
                    TxtCanDescription.Value = "";
                    break;
                    //
                //更新
                case DialogEditButtons.Mode.Modify:
                    // 表示用コントロール
                    TxtHoleSize.Visible = false;
                    TxtEmptyCanWeight.Visible = false;
                    TxtNormalVolume.Visible = false;
                    TxtMaxVolume.Visible = false;
                    // 編集用コントロール
                    TxtCanDescription.DataReadOnly = false;
                    DrpHoleSize.Visible = true;
                    NumEmptyCanWeight.Visible = true;
                    NumNormalVolume.Visible = true;
                    NumMaxVolume.Visible = true;
                    break;
                    //
                default:
                    // 表示用コントロール
                    TxtCanType.Visible = true;
                    TxtHoleSize.Visible = true;
                    TxtEmptyCanWeight.Visible = true;
                    TxtNormalVolume.Visible = true;
                    //TxtHoleSize.Visible = true;
                    TxtMaxVolume.Visible = true;
                    // 編集用コントロール
                    TxtCanType.DataReadOnly = true;
                    TxtCanDescription.DataReadOnly = true;
                    DrpHoleSize.Visible = false;
                    NumEmptyCanWeight.Visible = false;
                    NumNormalVolume.Visible = false;
                    NumMaxVolume.Visible = false;
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
            var columnIndex = ViewSettings.FindIndex(x => x.ColumnName == "Can_Type");
            if (DgvList.SelectedRows.Count > 0)
            {
                // 選択している行を取得
                var selectedRow = DgvList.SelectedRows[0];
                int.TryParse(selectedRow.Cells[columnIndex].Value.ToString(), out int canType);
                using (var db = new SqlBase(SqlBase.DatabaseKind.ORDER, SqlBase.TransactionUse.No, Log.ApplicationType.OrderManager))
                {
                    // 行取得のSQLを作成
                    var parameter = new List<ParameterItem>()
                    {
                        new ParameterItem("canType", canType),
                    };
                    var rec = db.Select(Sql.Order.CanTypes.GetDetail(), parameter);
                    switch (dialogEditButtons.EditMode)
                    {
                        //表示
                        case DialogEditButtons.Mode.View:
                            TxtCanDescription.Value = rec.Rows[0][TxtCanDescription.DatabaseColumnName].ToString().Trim();
                            break;
                        //新規作成
                        case DialogEditButtons.Mode.Create:
                            TxtCanDescription.Value = "";
                            DrpHoleSize.DropDown.Text = "50";
                            NumEmptyCanWeight.Value = 1000;
                            NumNormalVolume.Value = 15000;
                            NumMaxVolume.Value = 15000;
                            break;
                        //更新
                        case DialogEditButtons.Mode.Modify:
                            // フォームで定義された、取得値設定先のコントロールを抽出する
                            TxtCanDescription.Value = rec.Rows[0][TxtCanDescription.DatabaseColumnName].ToString().Trim();
                            db.ToLabelDropDown(this.Controls, rec.Rows);
                            db.ToLabelNumericUpDown(this.Controls, rec.Rows);
                            break;
                        default:
                            TxtCanDescription.Value = "";
                            DrpHoleSize.DropDown.Text = "50";
                            NumEmptyCanWeight.Value = 1000;
                            NumNormalVolume.Value = 15000;
                            NumMaxVolume.Value = 15000;
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
                    db.Insert(this.Controls, "Can_types");
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
                    db.FromLabelTextBox(this.Controls, "Can_Types", "Can_Type");
                    db.FromLabelDropDown(this.Controls, "Can_Types", "Can_Type");
                    db.FromLabelNumericUpDown(this.Controls, "Can_Types", "Can_Type");
                    
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
                if (!string.IsNullOrEmpty(TxtCanType.Value))
                {                   
                    try
                    {
                        //指定した1行のデータをデータベースから物理削除する
                        db.Delete(TxtCanType.Value, "Can_types", "Can_Type");
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

        #endregion

        #region 検証
        //OKボタン押下時の正常動作
        private bool Validation()
        {
            bool result = false;
            if (!string.IsNullOrEmpty(TxtCanDescription.Value))
            {
                result = true;
            }
            return result;
        }
        //OKボタン押下時の不完全動作
        private bool InvalidMeg()
        {
            bool modeChangeFlg = true;
            MessageBox.Show("不完全データ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            return modeChangeFlg;
        }
        #endregion

        #endregion
    }
}
