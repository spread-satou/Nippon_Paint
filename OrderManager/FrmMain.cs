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
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using NipponPaint.NpCommon;
using NipponPaint.NpCommon.Database;
using NipponPaint.NpCommon.FormControls;
using NipponPaint.OrderManager.Dialogs;
using NipponPaint.NpCommon.Settings;
using Sql = NipponPaint.NpCommon.Database.Sql;
using System.Data;
#endregion

namespace NipponPaint.OrderManager
{
    /// <summary>
    /// メイン画面
    /// </summary>
    public partial class FrmMain : BaseForm
    {
        #region 定数
        private static List<Color> StatusBackColorList = new List<Color>() {
            Color.LightPink,
            Color.Red,
            Color.Lime,
            Color.Cyan,
            Color.Blue,
            Color.White,
            Color.White,
            Color.White,
        };
        private const int COLUMN_STATUS = 0;
        //private int COLUMN_PRODUCT_NAME = 0;
        //private int COLUMN_COLOR_NAME = 0;
        private const int COLUMN_DELIVERY_CODE = 2;
        private const int COLUMN_SHIPPING_ID = 3;
        private const int COLUMN_PRODUCT_CODE = 4;
        private const int COLUMN_PRODUCT_NAME = 5;
        private const int COLUMN_EXTIMED_DATE = 8;
        private const int COLUMN_COLOR_SAMPLE = 11;

        private const int TAB_INDEX_OREDR = 0;
        private const int TAB_INDEX_DETAIL = 1;
        private const int TAB_INDEX_FORMULATION = 2;
        private const int TAB_INDEX_CAN = 3;

        private List<string> ViewGrid = new List<string>();
        //private const Log.ApplicationType MyApp = Log.ApplicationType.OrderManager;

        #endregion

        #region DataGridViewの列定義
        private List<GridViewSetting> ViewSettingsOrders = new List<GridViewSetting>()
        {
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.Numeric, ColumnName = "Status", DisplayName = "Status", Visible = false, Width = 0, alignment = DataGridViewContentAlignment.MiddleCenter } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.Numeric, ColumnName = "Order_id", DisplayName = "Order_id", Visible = false, Width = 0, alignment = DataGridViewContentAlignment.MiddleCenter } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.Numeric, ColumnName = "HG_HG_Delivery_Code", DisplayName = "運送区分", Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleCenter } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = "HG_HG_Shipping_ID", DisplayName = "配送ﾓｰﾄﾞ", Visible = true, Width = 100 } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = "Product_Code", DisplayName = "製品ｺｰﾄﾞ", Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleCenter } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = "HG_Product_Name", DisplayName = "品名", Visible = true, Width = 500 } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = "HG_Volume_Code", DisplayName = "容量ｺｰﾄﾞ", Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleCenter } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.Numeric, ColumnName = "Number_of_cans", DisplayName = "缶数", Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleCenter } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = "FORMAT(Extimated_Date,'MM/dd')", DisplayName = "SS出荷予定日", Visible = true, Width = 130, alignment = DataGridViewContentAlignment.MiddleCenter } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = "Operator_Name", DisplayName = "担当者", Visible = true, Width = 100 } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = "FORMAT(Delivery_Date,'MM/dd')", DisplayName = "納期", Visible = true, Width = 100, alignment = DataGridViewContentAlignment.MiddleCenter } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = "HG_Color_Sample", DisplayName = "標準色見本", Visible = true, Width = 300 } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = "Color_Name", DisplayName = "色名", Visible = false, Width = 0 } },
        };
        private List<GridViewSetting> ViewSettingsWeights = new List<GridViewSetting>()
        {
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = "Code", DisplayName = "コード", Visible = true, Width = 300, alignment = DataGridViewContentAlignment.MiddleLeft } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.Numeric, ColumnName = "Weight", DisplayName = "重量[g]", Visible = true, Width = 200, alignment = DataGridViewContentAlignment.MiddleLeft } },
        };
        private List<GridViewSetting> ViewSettingsOrderNumbers = new List<GridViewSetting>()
        {
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.Numeric, ColumnName = "Status", DisplayName = "Status", Visible = true, Width = 35, alignment = DataGridViewContentAlignment.MiddleCenter } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = "Product_Code", DisplayName = "製品コード", Visible = true, Width = 110, alignment = DataGridViewContentAlignment.MiddleCenter } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.Numeric, ColumnName = "Number_of_cans", DisplayName = "缶数", Visible = true, Width = 95, alignment = DataGridViewContentAlignment.MiddleRight } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = "Order_Number", DisplayName = "注文番号", Visible = true, Width = 175, alignment = DataGridViewContentAlignment.MiddleCenter } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.Numeric, ColumnName = "Revision", DisplayName = "補正", Visible = true, Width = 95, alignment = DataGridViewContentAlignment.MiddleRight } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.Numeric, ColumnName = "Formula_Release", DisplayName = "配合受取", Visible = true, Width = 95, alignment = DataGridViewContentAlignment.MiddleRight } },
        };
        private List<GridViewSetting> ViewSettingsBarcodes = new List<GridViewSetting>()
        {
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = "barcode", DisplayName = "バーコード", Visible = true, Width = 240, alignment = DataGridViewContentAlignment.MiddleCenter } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.Numeric, ColumnName = "can", DisplayName = "缶", Visible = true, Width = 120, alignment = DataGridViewContentAlignment.MiddleCenter } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = "Status", DisplayName = "ステータス", Visible = true, Width = 120, alignment = DataGridViewContentAlignment.MiddleCenter } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.Numeric, ColumnName = "Test", DisplayName = "テスト", Visible = true, Width = 120, alignment = DataGridViewContentAlignment.MiddleCenter } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.Numeric, ColumnName = "Sample", DisplayName = "サンプル", Visible = true, Width = 120, alignment = DataGridViewContentAlignment.MiddleCenter } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.Numeric, ColumnName = "Saishin", DisplayName = "最新配合受取", Visible = true, Width = 120, alignment = DataGridViewContentAlignment.MiddleCenter } },
        };
        private List<GridViewSetting> ViewSettingsDetails = new List<GridViewSetting>()
        {
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = "Code", DisplayName = "コード", Visible = true, Width = 240, alignment = DataGridViewContentAlignment.MiddleCenter } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.Numeric, ColumnName = "Weight", DisplayName = "重量[g]", Visible = true, Width = 150, alignment = DataGridViewContentAlignment.MiddleRight } },
        };
        private List<GridViewSetting> ViewSettingsOutWeights = new List<GridViewSetting>()
        {
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = "Code", DisplayName = "コード", Visible = true, Width = 240, alignment = DataGridViewContentAlignment.MiddleCenter } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.Numeric, ColumnName = "Toshutsu", DisplayName = "吐出(g)", Visible = true, Width = 150, alignment = DataGridViewContentAlignment.MiddleRight } },
            { new GridViewSetting() { ColumnType = GridViewSetting.ColumnModeType.String, ColumnName = "Weight", DisplayName = "重量[g]", Visible = true, Width = 150, alignment = DataGridViewContentAlignment.MiddleRight } },
        };
        #endregion

        #region メンバ変数
        private string selectProductCode = string.Empty;
        #endregion

        #region コンストラクタ
        public FrmMain()
        {
            InitializeComponent();
            InitializeForm();
            lblStatus1.BackColor = StatusBackColorList[0];
            lblStatus2.BackColor = StatusBackColorList[1];
            lblStatus3.BackColor = StatusBackColorList[2];
            lblStatus4.BackColor = StatusBackColorList[3];
            lblStatus5.BackColor = StatusBackColorList[4];
            lblStatus5.ForeColor = Color.White;
        }
        #endregion

        #region イベント

        private void FrmMainShown(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.OpenMainForm);
            }
            catch (Exception ex)
            {
                PutLog(ex);
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
                    case Keys.F1:
                        // 表示選択－全て
                        RdoPreviewAll.Select();
                        break;
                    case Keys.F2:
                        // 表示選択－今日以前
                        RdoTodayBefore.Select();
                        break;
                    case Keys.F3:
                        // 表示選択－明日以降
                        RdoTomorrowAfter.Select();
                        break;
                    case Keys.F4:
                        // ラベル印刷
                        BtnPrint.PerformClick();
                        break;
                    case Keys.F5:
                        // 作業指示書の印刷
                        BtnPrintInstructions.PerformClick();
                        break;
                    case Keys.F6:
                        // 緊急印刷
                        BtnPrintEmergency.PerformClick();
                        break;
                    case Keys.F7:
                        // 注文開始
                        BtnOrderStart.PerformClick();
                        break;
                    case Keys.F8:
                        // ステータスを戻す
                        BtnStatusResume.PerformClick();
                        break;
                    case Keys.F9:
                        // 担当者を決定
                        BtnDecidePerson.PerformClick();
                        break;
                    case Keys.F10:
                        // 注文を閉じる
                        BtnOrderClose.PerformClick();
                        break;
                    case Keys.F11:
                        break;
                    case Keys.F12:
                        // 処理No.詳細
                        BtnProcessDetail.PerformClick();
                        break;
                    default:
                        // KeyCodeを文字列に変換する。
                        // テンキーからの数値入力を想定して"NumPad"は削除する。
                        var keyValue = new KeysConverter().ConvertToString(e.KeyCode).Replace("NumPad", "");
                        // 文字種チェック。
                        // アルファベットは小文字で入力しても、ここでは大文字になる。
                        if (Regex.IsMatch(keyValue, "^[0-9A-Z]+$"))
                        {
                            selectProductCode += keyValue;
                            // 製品コードの桁数に達したら
                            if (selectProductCode.Length == 2)
                            {
                                if (tabMain.SelectedIndex == TAB_INDEX_DETAIL)
                                {
                                    SelectDataGridViewRowByProductCode();
                                }
                                else
                                {
                                    // 「詳細」タブを開く
                                    // タブを開く動作でタイムラグが発生する為、この場合の対象行選択は「詳細」タブのSelectedIndexChangedイベントで行う。
                                    tabMain.SelectedIndex = TAB_INDEX_DETAIL;
                                }
                            }
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }
        private void GvOrderDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((DataGridView)sender).Text);
                DataGridViewFormatting((DataGridView)sender);
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }

        private void GvFormulationDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((DataGridView)sender).Text);
                DataGridViewFormatting((DataGridView)sender);
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }

        private void GvOrderNumberDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((DataGridView)sender).Text);
                DataGridViewFormatting((DataGridView)sender);
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }

        private void GvDetailDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((DataGridView)sender).Text);
                DataGridViewFormatting((DataGridView)sender);
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }

        private void GvOrderCellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((DataGridView)sender).Text);
                var dgv = (DataGridView)sender;
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void GvOrder_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView gv = (DataGridView)sender;
            if(e.RowIndex >= 0)
            {
                gv.Rows[e.RowIndex].Selected = true;
                DataGridViewRow row = gv.SelectedRows[0];
                switch (int.Parse(row.Cells[COLUMN_STATUS].Value.ToString()))
                {
                    case 0:
                        TsmiDecide.Enabled = true;
                        TsmiOperatorDelete.Enabled = false;
                        TsmiOrderStart.Enabled = false;
                        TsmiInstructionPrint.Enabled = false;
                        TsmiProductLabelPrint.Enabled = false;
                        TsmiColorLabelPrint.Enabled = false;
                        TsmiCopyLabelPrint.Enabled = false;
                        TsmiOrderClose.Enabled = true;
                        break;
                    case 1:
                        TsmiDecide.Enabled = false;
                        TsmiOperatorDelete.Enabled = true;
                        TsmiOrderStart.Enabled = false;
                        TsmiInstructionPrint.Enabled = true;
                        TsmiProductLabelPrint.Enabled = false;
                        TsmiColorLabelPrint.Enabled = false;
                        TsmiCopyLabelPrint.Enabled = false;
                        TsmiOrderClose.Enabled = true;
                        break;
                    case 2:
                        TsmiDecide.Enabled = false;
                        TsmiOperatorDelete.Enabled = false;
                        TsmiOrderStart.Enabled = true;
                        TsmiInstructionPrint.Enabled = false;
                        TsmiProductLabelPrint.Enabled = false;
                        TsmiColorLabelPrint.Enabled = false;
                        TsmiCopyLabelPrint.Enabled = false;
                        TsmiOrderClose.Enabled = true;
                        break;
                    case 3:
                        TsmiDecide.Enabled = false;
                        TsmiOperatorDelete.Enabled = false;
                        TsmiOrderStart.Enabled = false;
                        TsmiInstructionPrint.Enabled = false;
                        TsmiProductLabelPrint.Enabled = false;
                        TsmiColorLabelPrint.Enabled = false;
                        TsmiCopyLabelPrint.Enabled = false;
                        TsmiOrderClose.Enabled = false;
                        break;
                    case 4:
                        TsmiDecide.Enabled = false;
                        TsmiOperatorDelete.Enabled = false;
                        TsmiOrderStart.Enabled = false;
                        TsmiInstructionPrint.Enabled = false;
                        TsmiProductLabelPrint.Enabled = true;
                        TsmiColorLabelPrint.Enabled = true;
                        TsmiCopyLabelPrint.Enabled = true;
                        TsmiOrderClose.Enabled = true;
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// ラベル印刷(F4)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPrintClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                tabMain.SelectedIndex = TAB_INDEX_DETAIL;
                var vm = new ViewModels.LabelPrintData();
                FrmLabelPrint frmLabelPrint = new FrmLabelPrint(vm);
                frmLabelPrint.ShowDialog();
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }
        /// <summary>
        /// 作業指示書の印刷(F5)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPrintInstructionsClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                MessageBox.Show("作業指示書印刷がクリックされました");
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }
        /// <summary>
        /// 緊急印刷(F6)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPrintEmergencyClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                MessageBox.Show("緊急印刷がクリックされました");
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }
        /// <summary>
        /// 注文開始(F7)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOrderStartClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                var vm = new ViewModels.OrderStartData();
                FrmOrderStart frmOrderStart = new FrmOrderStart(vm);
                frmOrderStart.ShowDialog();
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }
        /// <summary>
        /// 注文を閉じる(F10)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOrderCloseClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                FrmOrderClose frmOrderClose = new FrmOrderClose();
                frmOrderClose.ShowDialog();
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }
        /// <summary>
        /// メニューバーのファイルで「閉じる」を選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemCloseFormClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((ToolStripMenuItem)sender).Text);
                Application.Exit();
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }
        /// <summary>
        /// メニューバーの管理ツールで「缶タイプ」を選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemCanTypeClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((ToolStripMenuItem)sender).Text);
                var vm = new ViewModels.CanTypeData();
                FrmCanType frmCanType = new FrmCanType(vm);
                frmCanType.ShowDialog();
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }
        /// <summary>
        /// メニューバーの管理ツールで「キャップタイプ」を選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemCapTypeClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((ToolStripMenuItem)sender).Text);
                var vm = new ViewModels.CapTypeData();
                FrmCapType frmCapType = new FrmCapType(vm);
                frmCapType.ShowDialog();
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }
        /// <summary>
        /// メニューバーの管理ツールで「商品コードマスタ」を選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemProductCodeMasterClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((ToolStripMenuItem)sender).Text);
                var vm = new ViewModels.ProductCodeMasterData();
                FrmProductCodeMaster frmProductCodeMaster = new FrmProductCodeMaster(vm);
                frmProductCodeMaster.ShowDialog();
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }
        /// <summary>
        /// メニューバーの管理ツールで「NP商品コードマスタ」を選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemNPProductCodeMasterClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((ToolStripMenuItem)sender).Text);
                var vm = new ViewModels.NPProductCodeMasterData();
                FrmNPProductCodeMaster frmNPProductCodeMaster = new FrmNPProductCodeMaster(vm);
                frmNPProductCodeMaster.ShowDialog();
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }
        /// <summary>
        /// メニューバーの管理ツールで「初期設定」を選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemInitialSettingClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((ToolStripMenuItem)sender).Text);
                var vm = new ViewModels.InitialSettingData();
                FrmInitialSetting frmInitialSetting = new FrmInitialSetting(vm);
                frmInitialSetting.ShowDialog();
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }
        /// <summary>
        /// メニューバーの管理ツールで「設定」を選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemSettingClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((ToolStripMenuItem)sender).Text);
                var vm = new ViewModels.SettingData();
                FrmSetting frmSetting = new FrmSetting(vm);
                frmSetting.ShowDialog();
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }
        /// <summary>
        /// メニューバーの管理ツールで「ラベル」を選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemSelectLabelClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((ToolStripMenuItem)sender).Text);
                FrmSelectLabel frmSelectLabel = new FrmSelectLabel();
                frmSelectLabel.ShowDialog();
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }
        /// <summary>
        /// メニューバーの管理ツールで「出庫」を選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemShippingClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((ToolStripMenuItem)sender).Text);
                FrmShipping frmShipping = new FrmShipping();
                frmShipping.ShowDialog();
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }
        /// <summary>
        /// メニューバーの管理ツールで「COMポート」を選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemCOMPortClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((ToolStripMenuItem)sender).Text);
                FrmCOMPort frmCOMPort = new FrmCOMPort();
                frmCOMPort.ShowDialog();
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }
        /// <summary>
        /// メニューバーの管理ツールで「CCMシミュレーター」を選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemCCMSimulatorClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((ToolStripMenuItem)sender).Text);
                var vm = new ViewModels.CCMSimulatorData();
                FrmCCMSimulator frmCCMSimulator = new FrmCCMSimulator(vm);
                frmCCMSimulator.ShowDialog();
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }
        /// <summary>
        /// メニューバーの管理ツールで「ラベル(仮)」を選択　　ラベル(仮) 後に削除致します。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemLabelSelectionClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((ToolStripMenuItem)sender).Text);
                FrmLabelSelection frmLabelSelection = new FrmLabelSelection();
                frmLabelSelection.ShowDialog();
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }
        /// <summary>
        /// ロットNo.編集画面を開く
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLotRegisterClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                var vm = new ViewModels.LotRegister();
                vm.Lot = HgTintingDirection.Value;
                // Order_idで検索する
                var columnIndex = ViewSettingsOrders.FindIndex(x => x.ColumnName == "Order_id");
                if (GvDetail.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = GvDetail.SelectedRows[0];
                    int.TryParse(row.Cells[columnIndex].Value.ToString(), out int orderId);
                    using (var db = new SqlBase(SqlBase.DatabaseKind.NPMAIN, SqlBase.TransactionUse.No, Log.ApplicationType.OrderManager))
                    {
                        // 行取得のSQLを作成
                        var parameters = new List<ParameterItem>()
                        {
                            new ParameterItem("orderId", orderId),
                        };
                        var rec = db.Select(Sql.NpMain.Orders.GetDetailByOrderId(), parameters);
                        int.TryParse(rec.Rows[0]["HG_Data_Number"].ToString(), out int dataNumber);
                        vm.DataNumber = dataNumber;
                    }
                }
                FrmLotRegister frmLotRegister = new FrmLotRegister(vm);
                frmLotRegister.ShowDialog();
                InitializeForm();
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }
        /// <summary>
        /// 処理No.指定画面を開く
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnProcessDetailClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                var vm = new ViewModels.SelectDataNumber();
                // Order_idで検索する
                var columnIndex = ViewSettingsOrders.FindIndex(x => x.ColumnName == "Order_id");
                if (GvOrder.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = GvOrder.SelectedRows[0];
                    int.TryParse(row.Cells[columnIndex].Value.ToString(), out int orderId);
                    using (var db = new SqlBase(SqlBase.DatabaseKind.NPMAIN, SqlBase.TransactionUse.No, Log.ApplicationType.OrderManager))
                    {
                        var parameters = new List<ParameterItem>()
                        {
                            new ParameterItem("orderId", orderId),
                        };
                        var rec = db.Select(Sql.NpMain.Orders.GetDetailByOrderId(), parameters);
                        int.TryParse(rec.Rows[0]["HG_Data_Number"].ToString(), out int dataNumber);
                        vm.DataNumber = dataNumber;
                    }
                }
                var frmDataNumber = new FrmSelectDataNumber(vm);
                if (frmDataNumber.ShowDialog() == DialogResult.OK)
                {
                    selectProductCode = vm.SelectedProductCode;
                    if (tabMain.SelectedIndex == TAB_INDEX_DETAIL)
                    {
                        SelectDataGridViewRowByProductCode();
                    }
                    else
                    {
                        tabMain.SelectedIndex = TAB_INDEX_DETAIL;
                    }
                }
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }
        //
        /// <summary>
        /// タブ選択変更イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {

            SelectDataGridViewRowByProductCode();
        }
        /// <summary>
        /// 注文タブ内一覧の選択行変更イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GvOrder_SelectionChanged(object sender, EventArgs e)
        {
            // 注文タブを開いていない時はスルー
            if (tabMain.SelectedIndex != TAB_INDEX_OREDR)
            {
                return;
            }
            PutLog(Sentence.Messages.ButtonClicked, ((DataGridView)sender).Text);
            // Statusで検索する
            var columnIndex = ViewSettingsOrders.FindIndex(x => x.ColumnName == "Status");
            var dgv = (DataGridView)sender;
            if (dgv.SelectedRows.Count > 0)
            {
                // 選択している行を取得
                var selectedRow = dgv.SelectedRows[0];
                int.TryParse(selectedRow.Cells[columnIndex].Value.ToString(), out int orderId);
                switch (orderId)
                {
                    case 0:
                        BtnPrintEmergency.Enabled = false;
                        BtnPrint.Enabled = false;
                        break;
                    case 1:
                        BtnPrintEmergency.Enabled = true;
                        BtnPrint.Enabled = false;
                        break;
                    case 2:
                        BtnPrintEmergency.Enabled = true;
                        BtnPrint.Enabled = false;
                        break;
                    case 3:
                        BtnPrintEmergency.Enabled = true;
                        BtnPrint.Enabled = true;
                        break;
                    case 4:
                        BtnPrintEmergency.Enabled = true;
                        BtnPrint.Enabled = true;
                        break;
                    default:
                        BtnPrintEmergency.Enabled = true;
                        BtnPrint.Enabled = false;
                        break;

                }
            }
        }
        /// <summary>
        /// 詳細タブ内一覧の選択行変更イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GvDetail_SelectionChanged(object sender, EventArgs e)
        {
            // 詳細タブを開いていない時はスルー
            if (tabMain.SelectedIndex != TAB_INDEX_DETAIL)
            {
                return;
            }
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((DataGridView)sender).Text);
                // Order_idで検索する
                var columnIndex = ViewSettingsOrders.FindIndex(x => x.ColumnName == "Order_id");
                var dgv = (DataGridView)sender;
                if (dgv.SelectedRows.Count > 0)
                {
                    // 選択している行を取得
                    var selectedRow = dgv.SelectedRows[0];
                    int.TryParse(selectedRow.Cells[columnIndex].Value.ToString(), out int orderId);
                    using (var db = new SqlBase(SqlBase.DatabaseKind.NPMAIN, SqlBase.TransactionUse.No, Log.ApplicationType.OrderManager))
                    {
                        // 行取得のSQLを作成
                        var parameters = new List<ParameterItem>()
                        {
                            new ParameterItem("orderId", orderId),
                        };
                        var rec = db.Select(Sql.NpMain.Orders.GetDetailByOrderId(), parameters);
                        // フォームで定義された、取得値設定先のコントロールを抽出する
                        db.ToLabelTextBox(this.Controls, rec.Rows);
                        //指定LotのTextBoxの入力値を有無を調べる
                        if (string.IsNullOrEmpty(HgTintingDirection.Value))
                        {
                            BorderHgTintingDirection.Visible = false;
                        }
                        else
                        {

                            BorderHgTintingDirection.Visible = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }

        /// <summary>
        /// 配合タブ内一覧の選択行変更イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GvDetail_GvFormulation(object sender, EventArgs e)
        {
            // 配合タブを開いていない時はスルー
            if (tabMain.SelectedIndex != TAB_INDEX_FORMULATION)
            {
                return;
            }
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((DataGridView)sender).Text);
                // Order_idで検索する
                var columnIndex = ViewSettingsOrders.FindIndex(x => x.ColumnName == "Order_id");
                var dgv = (DataGridView)sender;
                if (dgv.SelectedRows.Count > 0)
                {
                    // 選択している行を取得
                    var selectedRow = dgv.SelectedRows[0];
                    int.TryParse(selectedRow.Cells[columnIndex].Value.ToString(), out int orderId);
                    using (var db = new SqlBase(SqlBase.DatabaseKind.NPMAIN, SqlBase.TransactionUse.No, Log.ApplicationType.OrderManager))
                    {
                        // 行取得のSQLを作成
                        var parameters = new List<ParameterItem>()
                        {
                            new ParameterItem("orderId", orderId),
                        };
                        var rec = db.Select(Sql.NpMain.Orders.GetDetailByOrderId(), parameters);
                        // フォームで定義された、取得値設定先のコントロールを抽出する
                        db.ToLabelTextBox(this.Controls, rec.Rows);
                        //指定LotのTextBoxの入力値を有無を調べる
                        if (string.IsNullOrEmpty(HgTintingDirection.Value))
                        {
                            BorderHgTintingDirection.Visible = false;
                        }
                        else
                        {

                            BorderHgTintingDirection.Visible = true;
                        }
                        GvWeight.Rows.Clear();
                        var cnt = 1;
                        foreach (DataColumn column in rec.Columns)
                        {
                            //string columnName = "Colorant_" + cnt;
                            //switch (column.ColumnName)
                            //{
                            //    case "White_Code":
                            //        GvWeight.Rows.Add(rec.Rows[0]["White_Code"], rec.Rows[0]["White_Weight"]);
                            //        break;
                            //    case columnName:
                            //        GvWeight.Rows.Add(rec.Rows[0]["Colorant_" + cnt], rec.Rows[0]["Weight_" + cnt]);
                            //        cnt++;
                            //        break;
                            //    default:
                            //        break;
                            //}
                            if (column.ColumnName.Equals("White_Code"))
                            {

                                GvWeight.Rows.Add(rec.Rows[0]["White_Code"], rec.Rows[0]["White_Weight"]);
                            }
                            if(column.ColumnName.Equals("Colorant_" + cnt))
                            {
                                
                                GvWeight.Rows.Add(rec.Rows[0]["Colorant_" + cnt], rec.Rows[0]["Weight_" + cnt]);
                                cnt++;
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                PutLog(ex);
            }
        }

        /// <summary>
        /// 缶タブ内一覧の選択行変更イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GvOrderNumber_SelectionChanged(object sender, EventArgs e)
        {
            // 缶タブを開いていない時はスルー
            if (tabMain.SelectedIndex != TAB_INDEX_CAN)
            {
                return;
            }
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((DataGridView)sender).Text);
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
            this.Shown += new System.EventHandler(this.FrmMainShown);
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(this.FormKeyDown);
            this.GvOrder.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(this.GvOrderDataBindingComplete);
            this.GvDetail.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(this.GvDetailDataBindingComplete);
            this.GvFormulation.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(this.GvFormulationDataBindingComplete);
            this.GvOrderNumber.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(this.GvOrderNumberDataBindingComplete);
            this.GvOrder.CellClick += new DataGridViewCellEventHandler(this.GvOrderCellClick);
            this.BtnPrint.Click += new EventHandler(this.BtnPrintClick);
            this.BtnPrintInstructions.Click += new EventHandler(this.BtnPrintInstructionsClick);
            this.BtnPrintEmergency.Click += new EventHandler(this.BtnPrintEmergencyClick);
            this.BtnOrderStart.Click += new EventHandler(this.BtnOrderStartClick);
            this.BtnOrderClose.Click += new EventHandler(this.BtnOrderCloseClick);
            this.BtnProcessDetail.Click += new EventHandler(this.BtnProcessDetailClick);
            this.ToolStripMenuItemCloseForm.Click += new EventHandler(this.ToolStripMenuItemCloseFormClick);
            this.ToolStripMenuItemCanType.Click += new EventHandler(this.ToolStripMenuItemCanTypeClick);
            this.ToolStripMenuItemCapType.Click += new EventHandler(this.ToolStripMenuItemCapTypeClick);
            this.ToolStripMenuItemProductCodeMaster.Click += new EventHandler(this.ToolStripMenuItemProductCodeMasterClick);
            this.ToolStripMenuItemNPProductCodeMaster.Click += new EventHandler(this.ToolStripMenuItemNPProductCodeMasterClick);
            this.ToolStripMenuItemInitialSetting.Click += new EventHandler(this.ToolStripMenuItemInitialSettingClick);
            this.ToolStripMenuItemSetting.Click += new EventHandler(this.ToolStripMenuItemSettingClick);
            this.ToolStripMenuItemSelectLabel.Click += new EventHandler(this.ToolStripMenuItemSelectLabelClick);
            this.ToolStripMenuItemShipping.Click += new EventHandler(this.ToolStripMenuItemShippingClick);
            this.ToolStripMenuItemCOMPort.Click += new EventHandler(this.ToolStripMenuItemCOMPortClick);
            this.ToolStripMenuItemCCMSimulator.Click += new EventHandler(this.ToolStripMenuItemCCMSimulatorClick);
            this.GvOrder.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GvOrder_CellMouseUp);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            //ラベル(仮)のイベントハンドラー
            this.ToolStripMenuItemLabelSelection.Click += new EventHandler(this.ToolStripMenuItemLabelSelectionClick);
            this.BtnLotRegister.Click += new EventHandler(this.BtnLotRegisterClick);
            this.tabMain.SelectedIndexChanged += new EventHandler(this.tabMain_SelectedIndexChanged);
            this.GvOrder.SelectionChanged += new EventHandler(this.GvOrder_SelectionChanged);
            this.GvDetail.SelectionChanged += new EventHandler(this.GvDetail_SelectionChanged);
            this.GvFormulation.SelectionChanged += new EventHandler(this.GvDetail_GvFormulation);
            this.GvOrderNumber.SelectionChanged += new EventHandler(this.GvOrderNumber_SelectionChanged);
            // DataGridViewの初期設定
            InitializeGridView(GvOrder);
            InitializeGridView(GvDetail);
            InitializeGridView(GvFormulation);
            InitializeGridView(GvWeight);
            InitializeGridView(GvBarcode);
            InitializeGridView(GvOrderNumber);
            InitializeGridView(GvWeightDetail);
            InitializeGridView(GvOutWeight);
            // DataGridViewの表示
            using (var db = new SqlBase(SqlBase.DatabaseKind.NPMAIN, SqlBase.TransactionUse.No, Log.ApplicationType.OrderManager))
            {
                var result = db.Select(Sql.NpMain.Orders.GetPreview(ViewSettingsOrders));
                ColorExplanation(result);

                GvOrder.DataSource = result;
                GvDetail.DataSource = result;
                GvFormulation.DataSource = result;

                result = db.Select(Sql.NpMain.Orders.GetPreview(ViewSettingsOrderNumbers));
                GvOrderNumber.DataSource = result;
            }
            var cnt = 0;
            foreach (var item in ViewSettingsOrders)
            {
                GvOrder.Columns[cnt].Width = item.Width;
                GvOrder.Columns[cnt].Visible = item.Visible;
                GvOrder.Columns[cnt].DefaultCellStyle.Alignment = item.alignment;
                GvDetail.Columns[cnt].Width = item.Width;
                GvDetail.Columns[cnt].Visible = item.Visible;
                GvDetail.Columns[cnt].DefaultCellStyle.Alignment = item.alignment;
                GvFormulation.Columns[cnt].Width = item.Width;
                GvFormulation.Columns[cnt].Visible = item.Visible;
                GvFormulation.Columns[cnt].DefaultCellStyle.Alignment = item.alignment;
                cnt++;
            }
            cnt = 0;
            foreach (var item in ViewSettingsWeights)
            {
                //GvWeight.Columns[cnt].Width = item.Width;
                //GvWeight.Columns[cnt].Visible = item.Visible;
                //GvWeight.Columns[cnt].DefaultCellStyle.Alignment = item.alignment;
                //GvWeight.Columns[cnt].HeaderText = item.DisplayName;
                //cnt++;
                var column = new DataGridViewColumn();
                column.Name = item.ColumnName;
                column.HeaderText = item.DisplayName;
                column.Width = item.Width;
                column.Visible = item.Visible;
                column.DefaultCellStyle.Alignment = item.alignment;
                column.CellTemplate = new DataGridViewTextBoxCell();
                GvWeight.Columns.Add(column);
                cnt++;

            }
            cnt = 0;
            foreach (var item in ViewSettingsOrderNumbers)
            {
                GvOrderNumber.Columns[cnt].Width = item.Width;
                GvOrderNumber.Columns[cnt].Visible = item.Visible;
                GvOrderNumber.Columns[cnt].DefaultCellStyle.Alignment = item.alignment;
                if (cnt <= 0)
                {
                    GvOrderNumber.Columns[cnt].HeaderText = string.Empty;
                }
                else
                {
                    GvOrderNumber.Columns[cnt].HeaderText = item.DisplayName;
                }
                cnt++;
                //var column = new DataGridViewColumn();
                //column.Name = item.ColumnName;
                //column.HeaderText = item.DisplayName;
                //column.Width = item.Width;
                //column.Visible = item.Visible;
                //column.DefaultCellStyle.Alignment = item.alignment;
                //GvOrderNumber.Columns.Add(column);
            }
            foreach (var item in ViewSettingsBarcodes)
            {
                var column = new DataGridViewColumn();
                column.Name = item.ColumnName;
                column.HeaderText = item.DisplayName;
                column.Width = item.Width;
                column.Visible = item.Visible;
                column.DefaultCellStyle.Alignment = item.alignment;
                GvBarcode.Columns.Add(column);
            }
            foreach (var item in ViewSettingsDetails)
            {
                var column = new DataGridViewColumn();
                column.Name = item.ColumnName;
                column.HeaderText = item.DisplayName;
                column.Width = item.Width;
                column.Visible = item.Visible;
                column.DefaultCellStyle.Alignment = item.alignment;
                GvWeightDetail.Columns.Add(column);
            }
            foreach (var item in ViewSettingsOutWeights)
            {
                var column = new DataGridViewColumn();
                column.Name = item.ColumnName;
                column.HeaderText = item.DisplayName;
                column.Width = item.Width;
                column.Visible = item.Visible;
                column.DefaultCellStyle.Alignment = item.alignment;
                GvOutWeight.Columns.Add(column);
            }
            // データ表示部のコントロール制御
            Funcs.SetControlEnabled(this.Controls, true);
            // ログ出力
            PutLog(Sentence.Messages.InitializedMainForm);
        }
        #endregion

        #region DataGridViewの書式設定
        /// <summary>
        /// DataGridViewの書式設定
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="e"></param>
        private void DataGridViewFormatting(DataGridView dgv)
        {
            if (!dgv.Visible)
            {
                return;
            }
            if (!ViewGrid.Contains(dgv.Name))
            {
                ViewGrid.Add(dgv.Name);
                return;
            }
            ViewGrid = new List<string>();
            var cnt = 0;
            var rowHeight = 48;
            var fontSizeProductCode = 24;
            var fontSizeDefault = 12;
            switch (dgv.Name)
            {
                case "GvOrder":
                    rowHeight = 32;
                    fontSizeProductCode = 16;
                    fontSizeDefault = 8;
                    break;
            }
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Height = rowHeight;
                row.Cells[COLUMN_DELIVERY_CODE].Style.BackColor = StatusBackColorList[int.Parse(row.Cells[COLUMN_STATUS].Value.ToString())];
                row.Cells[COLUMN_DELIVERY_CODE].Style.ForeColor = Color.Black;
                row.Cells[COLUMN_PRODUCT_CODE].Style.BackColor = Color.LightYellow;
                row.Cells[COLUMN_PRODUCT_NAME].Style.WrapMode = DataGridViewTriState.True;
                row.Cells[COLUMN_COLOR_SAMPLE].Style.WrapMode = DataGridViewTriState.True;
                var i = 0;
                foreach (var cell in row.Cells)
                {
                    switch (i)
                    {
                        case COLUMN_PRODUCT_CODE:
                            row.Cells[i].Style.Font = new Font(dgv.Font.Name, fontSizeProductCode);
                            break;
                        default:
                            row.Cells[i].Style.Font = new Font(dgv.Font.Name, fontSizeDefault);
                            break;
                    }
                    i++;
                }
                
                row.Cells[COLUMN_PRODUCT_CODE].Style.ForeColor = Color.Black;
                if (cnt == 10)
                {
                    row.Cells[COLUMN_SHIPPING_ID].Style.BackColor = Color.Gold;
                    row.Cells[COLUMN_EXTIMED_DATE].Style.BackColor = Color.Gold;
                }
                cnt++;
            }
        }
        #endregion

        #region 製品コードでDataGridViewの該当行を探す
        /// <summary>
        /// 製品コードでDataGridViewの該当行を探す
        /// </summary>
        /// <param name="productCode"></param>
        /// <returns></returns>
        private int GetGridViewRowIndexByProductCode(string productCode)
        {
            return GetGridViewRowIndex(productCode, COLUMN_PRODUCT_CODE);
        }
        #endregion

        #region DataGridViewの該当行を探す
        /// <summary>
        /// DataGridViewの該当行を探す
        /// </summary>
        /// <param name="code"></param>
        /// <param name="cellIndex"></param>
        /// <returns></returns>
        private int GetGridViewRowIndex(string code, int cellIndex)
        {
            var rowIndex = -1;
            if (string.IsNullOrEmpty(code))
            {
                return rowIndex;
            }
            if (GvOrder.SelectedRows.Count > 0)
            {
                rowIndex = GvOrder.SelectedRows[0].Index;
            }
            foreach (DataGridViewRow row in GvOrder.Rows)
            {
                if (row.Cells[cellIndex].Value.ToString() == code)
                {
                    rowIndex = row.Index;
                    break;
                }
            }
            return rowIndex;
        }
        #endregion

        #region DataGridViewの選択行を移動する
        /// <summary>
        /// DataGridViewの選択行を移動する
        /// </summary>
        /// <param name="gv"></param>
        /// <param name="rowIndex"></param>
        private void SetGridViewRowIndex(DataGridView gv, int rowIndex)
        {
            gv.ClearSelection();
            gv.Rows[rowIndex].Selected = true;
            gv.FirstDisplayedScrollingRowIndex = rowIndex;
        }
        #endregion

        #region 入力した製品コードを選択状態にする
        /// <summary>
        /// 入力した製品コードを選択状態にする
        /// </summary>
        private void SelectDataGridViewRowByProductCode()
        {
            // 選択行の移動
            var nextRowIndex = GetGridViewRowIndexByProductCode(selectProductCode);
            if (nextRowIndex > -1)
            {
                SetGridViewRowIndex(GvOrder, nextRowIndex);
                SetGridViewRowIndex(GvDetail, nextRowIndex);
                SetGridViewRowIndex(GvFormulation, nextRowIndex);
                SetGridViewRowIndex(GvOrderNumber, nextRowIndex);
            }
            selectProductCode = string.Empty;
        }
        #endregion

        #region "カラーの説明"部の設定
        /// <summary>
        /// "カラーの説明"部の設定
        /// </summary>
        /// <param name="dt"></param>
        private void ColorExplanation(DataTable dt)
        {
            DataRow[] beforeSS = dt.Select(string.Format("[{0}] <= #{1}#", "SS出荷予定日", DateTime.Today) + "AND Status = " + 0);
            DataRow[] afterSS = dt.Select(string.Format("[{0}] > #{1}#", "SS出荷予定日", DateTime.Today) + "AND Status = " + 0);

            label6.Text = "[" + beforeSS.Length + "/" + afterSS.Length + "] 99.99t";

            DataRow[] ccm = dt.Select("Status = " + 1);
            label7.Text = "[" + ccm.Length + "] 99.99t";
            DataRow[] ready = dt.Select("Status = " + 2);
            label8.Text = "[" + ready.Length + "] 99.99t";
            DataRow[] testCan = dt.Select("Status = " + 3);
            label9.Text = "[" + testCan.Length + "] 99.99t";
            DataRow[] productCan = dt.Select("Status = " + 4);
            label10.Text = "[" + productCan.Length + "] 99.99t";
        }

        #endregion

        #endregion

        private void tabDetail1_Click(object sender, EventArgs e)
        {

        }
    }
}