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
    /// 初期設定ダイアログ
    /// </summary>
    public partial class FrmInitialSetting : BaseForm
    {
        #region DataGridViewの列定義
        private List<GridViewSetting> ViewSettings = new List<GridViewSetting>()
        {
             { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = "White_Code", DisplayName = "白コード", Visible = true, Width = 200, alignment = DataGridViewContentAlignment.MiddleLeft } },
        };
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="vm"></param>
        public FrmInitialSetting(ViewModels.InitialSettingData vm)
        {
            InitializeComponent();
            InitializeForm();
            TxtWhiteCode.Value = vm.WhiteCode;
            TxtCanType.Code.Text = vm.CanType.ToString();
            TxtCanType.Data.Text = vm.CanDescription;
            TxtCapType.Code.Text = vm.CapType.ToString();
            TxtCapType.Data.Text = vm.CapDescription;
            TxtOverFilling.Value = vm.OverFilling.ToString();
            TxtFilledWeight.Value = vm.FilledWeight.ToString();
            TxtMixingTime.Value = vm.MixingTime.ToString();
            TxtMixingSpeed.Value = vm.MixingSpeed.ToString();
            DrpCan_Type.InitializeDropdownItems(SqlBase.DatabaseKind.ORDER, Log.ApplicationType.OrderManager);
            DrpCap_Type.InitializeDropdownItems(SqlBase.DatabaseKind.ORDER, Log.ApplicationType.OrderManager);
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
        private void FrmInitialSettingShown(object sender, EventArgs e)
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
            var columnIndex = ViewSettings.FindIndex(x => x.ColumnName == "White_Code");
            var dgv = (DataGridView)sender;
            if (dgv.SelectedRows.Count > 0)
            {
                // 選択している行を取得
                var selectedRow = dgv.SelectedRows[0];
                using (var db = new SqlBase(SqlBase.DatabaseKind.ORDER, SqlBase.TransactionUse.No, Log.ApplicationType.OrderManager))
                {
                    // 行取得のSQLを作成
                    var parameters = new List<ParameterItem>()
                    {
                        new ParameterItem("whiteCode", selectedRow.Cells[columnIndex].Value)
                    };
                    var rec = db.Select(Sql.Order.Defaults.GetDetail(), parameters);
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
                                ((LabelNumericUpDown)control).Id = selectedRow.Cells[columnIndex].Value.ToString();
                                break;
                            case LabelDropDown labelDropDown:
                                ((LabelDropDown)control).Id = selectedRow.Cells[columnIndex].Value.ToString();
                                break;
                            default:
                                break;
                        }
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
                        this.dialogEditButtons.Modify.PerformClick();
                        break;
                    case Keys.F4:
                        // 削除
                        this.dialogEditButtons.Delete.PerformClick();
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
        /// 
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
                DialogResult result = MessageBox.Show("白コードを削除します。処理を続けますか？", "Confirm", MessageBoxButtons.YesNo);
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
        /// <param nam="e"></param>
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
                switch (dialogEditButtons.EditMode)
                {
                    //新規作成
                    case DialogEditButtons.Mode.Create:
                        DgvList.Enabled = true;
                        //新規作成時、エラーの場合はDataGridViewで既に存在する白コードを選択状態にしてユーザーに明示する
                        foreach (DataGridViewRow row in DgvList.Rows)
                        {
                            if (DrpWhiteCode.DropDown.Text == row.Cells["白コード"].Value.ToString())
                            {
                                DgvList.CurrentCell = row.Cells["白コード"];
                            }
                        }
                        DgvList.Enabled = false;
                        break;
                    default:
                        VisibleSetting();
                        InitializeGridViewLayout();
                        ValueSetting();
                        DataGridViewEnabled();
                        break;
                }
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
            DrpWhiteCode.Location = TxtWhiteCode.Location;
            DrpCan_Type.Location = TxtCanType.Location;
            DrpCap_Type.Location = TxtCapType.Location;
            NumOverFilling.Location = TxtOverFilling.Location;
            NumFilledWeight.Location = TxtFilledWeight.Location;
            NumMixingTime.Location = TxtMixingTime.Location;
            NumMixingSpeed.Location = TxtMixingSpeed.Location;
            // イベントの追加
            this.Shown += new System.EventHandler(this.FrmInitialSettingShown);
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
            DrpWhiteCode.DropDown.Items.AddRange(new object[] {
                "EMPTY",
                "3OFSK",
                "993OFS",
                "WELMｵｰｶｰ",
                "WEｵｰｶｰ",
                "WEﾌﾞﾗｯｸ",
                "WEｲﾝﾃﾞｱﾝ",
                "WEﾊﾟｰﾏﾈY",
                "WEシャニンBシ",
                "WEｼﾝｶRN",
                "WEｸﾞﾘｰﾝ",
                "WEｼｬﾆﾝBN",
                "OFS",
                "OFU",
                "TW1",
                "SSSU",
                "HVE",
                "EF6",
                "EF7",
                "WKEN",
                "DFR",
                "OFUC",
                "OFSC",
                "HV3",
                "OS3",
                "OS5",
                "OS0",
                "OG",
                "IDALE",
                "IDANE",
                "NV70E",
                "OFF",
                "OFS5S",
                "EFC",
                "OU3",
                "SOFS",
                "NLB",
                "OFS5C",
                "WEU0",
                "EF10",
                "OU0",
                "OFS50",
                "OU5",
                "HV7",
                "SCHD",
                "OG3",
                "SCHL",
                "OG0",
                "FBRE",
                "DFR0",
                "DFRC",
                "WKENC",
                "SSSUC",
                "DSR",
                "DSR0",
                "APSN",
                "DSRC",
                "OCGE0",
                "DTW",
                "SSSU5",
                "SSSU3",
                "SSSU0",
                "OCGEC",
                "OCGE3",
                "OCGE",
                "WH3E",
                "ONT3",
                "OFA",
                "OCGE5",
                "OFS5N",
                "OFMC",
                "SOFC",
                "DAEU",
                "WFU5",
                "WFU3",
                "HV3N",
                "OFSN",
                "OFUN",
                "OFSN0",
                "OFSN3",
                "OFUN0",
                "OFSN5",
                "3OFS",
                "ALCT",
                "WFU",
                "3OFSC",
                "3OFS0",
                "3OFS3",
                "3ОＦＳ5",
                "OFUN3",
                "OFUN5",
                "HVE6",
                "ONT5",
                "DAESI",
                "PT",
                "PTC",
                "PT3",
                "PT5",
                "PT0",
                "TEW",
                "EFN7",
                "EFN6",
                "EFN10",
                "PT3N",
                "WTWS",
                "WTWSC",
                "WTWS3",
                "WTWF",
                "SOFSN",
                "SOFSN3",
                "OCGEN",
                "OCGENC",
                "OCGEN0",
                "OCGEN3",
                "OCGEN5",
                "TW1N",
                "WWS",
                "TW1N3",
                "TW1N5",
                "TW1NC",
                "HVE7",
                "DAEF",
                "DAEFM",
                "ALCT5",
                "IDFC",
                "IDFCM",
                "IDFCD",
                "JSR",
                "SOFF",
                "WFSI",
                "WFSI3",
                "HVF",
                "DFRN",
                "DERNC",
                "DERN0",
                "DERN5",
                "NOKR",
                "DSRN0",
                "ALCF",
                "POS",
                "POS5",
                "POS3",
                "POS0",
                "POF",
                "POF5",
                "POF3",
                "POF0",
                "WKENG",
                "WKEN3",
                "OGN3",
                "OGN5",
                "OGN0",
                "WFSIC",
                "EP",
                "PCTGM",
                "NDTW",
                "GPW",
                "GPW3",
                "GPW5",
                "GPW0",
                "FBRE0",
                "OFF3",
                "EFCN",
                "PTCN",
                "DTSI",
                "DTSC",
                "EPN",
                "APS2",
                "3OFS7",
                "DSRNN",
                "ALCTN",
                "DSRN5",
                "NK",
                "NOK",
                "PCTG",
                "DSRNC" });
            //DrpWhiteCode.DropDown.SelectedIndex = 0;
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
                var result = db.Select(Sql.Order.Defaults.GetPreview(ViewSettings));
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
                    TxtWhiteCode.Visible = false;
                    TxtCanType.Visible = false;
                    TxtCapType.Visible = false;
                    TxtOverFilling.Visible = false;
                    TxtFilledWeight.Visible = false;
                    TxtMixingTime.Visible = false;
                    TxtMixingSpeed.Visible = false;
                    // 編集用コントロール
                    DrpWhiteCode.Visible = true;
                    DrpWhiteCode.Enabled = true;
                    DrpCan_Type.Visible = true;
                    DrpCap_Type.Visible = true;
                    NumOverFilling.Visible = true;
                    NumFilledWeight.Visible = true;
                    NumMixingTime.Visible = true;
                    NumMixingSpeed.Visible = true;
                    TxtWhiteCode.Value = "";
                    break;
                    //
                //更新
                case DialogEditButtons.Mode.Modify:
                    // 表示用コントロール
                    TxtWhiteCode.Visible = true;
                    TxtCanType.Visible = false;
                    TxtCapType.Visible = false;
                    TxtOverFilling.Visible = false;
                    TxtFilledWeight.Visible = false;
                    TxtMixingTime.Visible = false;
                    TxtMixingSpeed.Visible = false;

                    // 編集用コントロール
                    DrpWhiteCode.Visible = false;
                    DrpWhiteCode.Enabled = false;
                    DrpCan_Type.Visible = true;
                    DrpCap_Type.Visible = true;
                    NumOverFilling.Visible = true;
                    NumFilledWeight.Visible = true;
                    NumMixingTime.Visible = true;
                    NumMixingSpeed.Visible = true;
                    break;
                    //
                default:
                    // 表示用コントロール
                    TxtWhiteCode.Visible = true;
                    TxtCanType.Visible = true;
                    TxtCapType.Visible = true;
                    TxtOverFilling.Visible = true;
                    TxtFilledWeight.Visible = true;
                    TxtMixingTime.Visible = true;
                    TxtMixingSpeed.Visible = true;
                    // 編集用コントロール
                    DrpWhiteCode.Visible = false;
                    DrpWhiteCode.Enabled = false;
                    DrpCan_Type.Visible = false;
                    DrpCap_Type.Visible = false;
                    NumOverFilling.Visible = false;
                    NumFilledWeight.Visible = false;
                    NumMixingTime.Visible = false;
                    NumMixingSpeed.Visible = false;
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
            var columnIndex = ViewSettings.FindIndex(x => x.ColumnName == "White_Code");
            if (DgvList.SelectedRows.Count > 0)
            {
                // 選択している行を取得
                var selectedRow = DgvList.SelectedRows[0];
                
                using (var db = new SqlBase(SqlBase.DatabaseKind.ORDER, SqlBase.TransactionUse.No, Log.ApplicationType.OrderManager))
                {
                    // 行取得のSQLを作成
                    var parameter = new List<ParameterItem>()
                    {
                        new ParameterItem("whiteCode", selectedRow.Cells[columnIndex].Value),
                    };
                    var rec = db.Select(Sql.Order.Defaults.GetDetail(), parameter);
                    switch (dialogEditButtons.EditMode)
                    {
                        //表示
                        case DialogEditButtons.Mode.View:
                            db.ToLabelTextBox(this.Controls, rec.Rows);
                            break;
                        //新規作成
                        case DialogEditButtons.Mode.Create:
                            DrpWhiteCode.DropDown.SelectedIndex = 0;
                            DrpCan_Type.DropDown.SelectedIndex = 0;
                            DrpCap_Type.DropDown.SelectedIndex = 0;
                            NumOverFilling.Value = 0;
                            NumFilledWeight.Value = 0;
                            NumMixingTime.Value = 180;
                            NumMixingSpeed.Value = 100;
                            break;
                        //更新
                        case DialogEditButtons.Mode.Modify:
                            // フォームで定義された、取得値設定先のコントロールを抽出する
                            db.ToLabelDropDown(this.Controls, rec.Rows);
                            db.ToLabelNumericUpDown(this.Controls, rec.Rows);
                            break;
                        default:
                            DrpWhiteCode.DropDown.SelectedIndex = 0;
                            DrpCan_Type.DropDown.SelectedIndex = 0;
                            DrpCap_Type.DropDown.SelectedIndex = 0;
                            NumOverFilling.Value = 0;
                            NumFilledWeight.Value = 0;
                            NumMixingTime.Value = 180;
                            NumMixingSpeed.Value = 100;
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
                    db.Insert(this.Controls, "Defaults");
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
                    DrpWhiteCode.Id = "";
                    // フォームで定義された、指定LOT設定先のコントロールを抽出する
                    db.FromLabelDropDown(this.Controls, "Defaults", "White_Code");
                    db.FromLabelNumericUpDown(this.Controls, "Defaults", "White_Code");
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
                if (!string.IsNullOrEmpty(TxtWhiteCode.Value))
                {
                    try
                    {
                        //指定した1行のデータをデータベースから物理削除する
                        db.Delete(TxtWhiteCode.Value, "Defaults", "White_Code");
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
            int cnt = 0;
            foreach (DataGridViewRow row in DgvList.Rows)
            {
                //DefaultsテーブルにてDrpWhiteCodeコントロールで選択中の白コードの行数をカウントする
                if (DrpWhiteCode.DropDown.Text == row.Cells["白コード"].Value.ToString())
                {
                    cnt++;
                }
            }
            //Deaultsテーブルに選択中の白コードが存在する場合　result = falseとする
            if(cnt <= 0)
            {
                result = true;
            }
            return result;
        }
        //OKボタン押下時の不完全動作
        private bool InvalidMeg()
        {
            bool modeChangeFlg = false;
            MessageBox.Show("白コードを複写", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return modeChangeFlg;
        }
        #endregion

        #endregion
    }
}
