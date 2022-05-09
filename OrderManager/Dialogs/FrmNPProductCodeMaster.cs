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
using System.Data.SqlClient;
using NipponPaint.NpCommon;
using NipponPaint.NpCommon.Database;
using NipponPaint.NpCommon.FormControls;
using NipponPaint.NpCommon.Settings;
using Sql = NipponPaint.NpCommon.Database.Sql;
#endregion

namespace NipponPaint.OrderManager.Dialogs
{
    /// <summary>
    /// NPP商品コードマスタダイアログ
    /// </summary>
    public partial class FrmNPProductCodeMaster : BaseForm
    {
        #region DataGridViewの列定義
        private List<GridViewSetting> ViewSettings = new List<GridViewSetting>()
        {
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.Numeric, ColumnName = "VAR_ID", DisplayName = "NP商品コードID", Visible = false, Width = 80, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = "Variety_Code_OLD", DisplayName = "NP商品コードマスターOLD", Visible = true, Width =120, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = "Package_OLD", DisplayName = "容量OLD", Visible = true, Width = 120, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = "Variety_Code_NEW", DisplayName = "NP商品コードマスターNEW", Visible = true, Width = 120, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = "Package_NEW", DisplayName = "容量NEW", Visible = true, Width = 120, alignment = DataGridViewContentAlignment.MiddleLeft } },
        };
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="vm"></param>
        public FrmNPProductCodeMaster(ViewModels.NPProductCodeMasterData vm)
        {
            InitializeComponent();
            InitializeForm();
            TxtNPProductCodeID.Value = vm.NPProductCodeID;
            TxtNPProductCodeMasterFront.Value = vm.NPProductCodeMasterFront;
            TxtVolumeFront.Value = vm.VolumeFront;
            TxtNPProductCodeMasterBack.Value = vm.NPProductCodeMasterBack;
            TxtVolumeBack.Value = vm.VolumeBack;
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
        private void FrmNPProductCodeMasterShown(object sender, EventArgs e)
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
            var columnIndex = ViewSettings.FindIndex(x => x.ColumnName == "VAR_ID");
            var dgv = (DataGridView)sender;
            if (dgv.SelectedRows.Count > 0)
            {
                // 選択している行を取得
                var selectedRow = dgv.SelectedRows[0];
                int.TryParse(selectedRow.Cells[columnIndex].Value.ToString(), out int varId);
                using (var db = new SqlBase(SqlBase.DatabaseKind.NPMAIN, SqlBase.TransactionUse.No, Log.ApplicationType.OrderManager))
                {
                    // 行取得のSQLを作成
                    var parameters = new List<ParameterItem>()
                    {
                        new ParameterItem("varId", varId),
                    };
                    var rec = db.Select(Sql.NpMain.VarietyCode.GetDetail(), parameters);
                    // フォームで定義された、取得値設定先のコントロールを抽出する
                    db.ToLabelTextBox(this.Controls, rec.Rows);
                    // 編集用コントロールにUpdate文の条件式用にIDをセットする
                    var controls = new List<Control>();
                    Funcs.FindControls(this.Controls, controls);
                    foreach (var control in controls)
                    {
                        switch (control)
                        {
                            case LabelTextBox labelTextBox:
                                ((LabelTextBox)control).Id = varId.ToString();
                                break;
                            default:
                                break;
                        }
                    }
                    TxtNPProductCodeID.Id = "";
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
            catch (Exception ex)
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
                VisibleSetting();
                ValueSetting();
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
                DialogResult result =  MessageBox.Show("[Selected Product No will be deleted, continue?]", "Confirm", MessageBoxButtons.YesNo);
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
            catch(Exception ex)
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
            // イベントの追加
            this.Shown += new System.EventHandler(this.FrmNPProductCodeMasterShown);
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(this.FormKeyDown);
            this.dialogEditButtons.Create.Click += new EventHandler(this.BtnCreateClick);
            this.dialogEditButtons.Modify.Click += new EventHandler(this.BtnModifyClick);
            this.dialogEditButtons.Delete.Click += new EventHandler(this.BtnDeleteClick);
            this.dialogEditButtons.Exit.Click += new EventHandler(this.BtnExitClick);
            this.dialogEditButtons.Regist.Click += new EventHandler(this.BtnRegistClick);
            this.dialogEditButtons.Cancel.Click += new EventHandler(this.BtnCancelClick);
            this.DgvList.SelectionChanged += new System.EventHandler(this.DgvListSelectionChanged);
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
            using (var db = new SqlBase(SqlBase.DatabaseKind.NPMAIN, SqlBase.TransactionUse.No, Log.ApplicationType.OrderManager))
            {
                var result = db.Select(Sql.NpMain.VarietyCode.GetPreview(ViewSettings));
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
                    //表示用コントロール
                    TxtNPProductCodeID.Visible = false;
                    //編集用コントロール
                    TxtNPProductCodeMasterFront.DataReadOnly = false;
                    TxtVolumeFront.DataReadOnly = false;
                    TxtNPProductCodeMasterBack.DataReadOnly = false;
                    TxtVolumeBack.DataReadOnly = false;
                    TxtNPProductCodeMasterFront.Value = "";
                    TxtVolumeFront.Value = "";
                    TxtNPProductCodeMasterBack.Value = "";
                    TxtVolumeBack.Value = "";
                    break;
                    //
                //更新
                case DialogEditButtons.Mode.Modify:
                    //表示用コントロール
                    TxtNPProductCodeID.Visible = false;
                    //編集用コントロール
                    TxtNPProductCodeMasterFront.DataReadOnly = false;
                    TxtVolumeFront.DataReadOnly = false;
                    TxtNPProductCodeMasterBack.DataReadOnly = false;
                    TxtVolumeBack.DataReadOnly = false;
                    break;
                    //
                default:
                    // 表示用コントロール
                    TxtNPProductCodeID.Visible = true;
                    //
                    //編集用コントロール
                    TxtNPProductCodeMasterFront.DataReadOnly = true;
                    TxtVolumeFront.DataReadOnly = true;
                    TxtNPProductCodeMasterBack.DataReadOnly = true;
                    TxtVolumeBack.DataReadOnly = true;
                    break;
            }
        }
        #endregion

        #region 編集用コントロールの初期値制御
        /// <summary>
        /// 編集用コントロールの初期値制御
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValueSetting()
        {
            var columnIndex = ViewSettings.FindIndex(x => x.ColumnName == "VAR_ID");
            if (DgvList.SelectedRows.Count > 0)
            {
                // 選択している行を取得
                var selectedRow = DgvList.SelectedRows[0];
                int.TryParse(selectedRow.Cells[columnIndex].Value.ToString(), out int varId);
                using (var db = new SqlBase(SqlBase.DatabaseKind.NPMAIN, SqlBase.TransactionUse.No, Log.ApplicationType.OrderManager))
                {
                    // 行取得のSQLを作成
                    var parameters = new List<ParameterItem>()
                    {
                        new ParameterItem("varId", varId),
                    };
                    var rec = db.Select(Sql.NpMain.VarietyCode.GetDetail(), parameters);
                    switch (dialogEditButtons.EditMode)
                    {
                        //表示
                        case DialogEditButtons.Mode.View:
                            db.ToLabelTextBox(this.Controls, rec.Rows);
                            break;
                        //新規作成
                        case DialogEditButtons.Mode.Create:
                            TxtNPProductCodeMasterFront.Value = "";
                            TxtVolumeFront.Value = "";
                            TxtNPProductCodeMasterBack.Value = "";
                            TxtVolumeBack.Value = "";
                            break;
                        //更新
                        case DialogEditButtons.Mode.Modify:
                            db.ToLabelTextBox(this.Controls, rec.Rows);
                            break;
                        default:
                            TxtNPProductCodeMasterFront.Value = "";
                            TxtVolumeFront.Value = "";
                            TxtNPProductCodeMasterBack.Value = "";
                            TxtVolumeBack.Value = "";
                            break;
                    }
                }
            }
        }
        #endregion

        #region 画面コントロールからデータベースへの反映処理

        #region 新規作成処理
        private void ExecuteInsert()
        {
            using (var db = new SqlBase(SqlBase.DatabaseKind.NPMAIN, SqlBase.TransactionUse.Yes, Log.ApplicationType.OrderManager))
            {
                try
                {
                    //入力したフォームの内容をデータベースに新規登録する
                    db.Insert(this.Controls, "Variety_Code");
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
        private void ExecuteUpdate()
        {
            using (var db = new SqlBase(SqlBase.DatabaseKind.NPMAIN, SqlBase.TransactionUse.Yes, Log.ApplicationType.OrderManager))
            {
                try
                {
                    // フォームで定義された、指定LOT設定先のコントロールを抽出する
                    db.FromLabelTextBox(this.Controls, "Variety_Code", "VAR_ID");

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
        private void ExecuteDelete()
        {
            using (var db = new SqlBase(SqlBase.DatabaseKind.NPMAIN, SqlBase.TransactionUse.Yes, Log.ApplicationType.OrderManager))
            {
                if (!string.IsNullOrEmpty(TxtNPProductCodeID.Value))
                {
                    try
                    {
                        //指定した1行のデータをデータベースから物理削除する
                        db.Delete(TxtNPProductCodeID.Value, "Variety_Code", "VAR_ID");
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
            if (!string.IsNullOrEmpty(TxtNPProductCodeMasterFront.Value))
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
