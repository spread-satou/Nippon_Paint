
namespace NipponPaint.OrderManager
{
    partial class FrmMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tabOrder = new System.Windows.Forms.TabPage();
            this.GvOrder = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TsmiDecide = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiOperatorDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiOrderStart = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiInstructionPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiProductLabelPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiColorLabelPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiCopyLabelPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiOrderClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabDetail = new System.Windows.Forms.TabPage();
            this.splitDetail = new System.Windows.Forms.SplitContainer();
            this.GvDetail = new System.Windows.Forms.DataGridView();
            this.pnlDetailItems = new System.Windows.Forms.Panel();
            this.tabDetailSub = new System.Windows.Forms.TabControl();
            this.tabDetail1 = new System.Windows.Forms.TabPage();
            this.HgWeight = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.TotalWeight = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgOrderInputTime = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgOrderInputDate = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgTintingPriceRank = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.Revision = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgCustomerCode = new NipponPaint.NpCommon.FormControls.LabelCodeText();
            this.HgSupplementalAddition = new NipponPaint.NpCommon.FormControls.LabelCodeText();
            this.HgSsShippingDate_1 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgSamplePlates = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgGlossAddition = new NipponPaint.NpCommon.FormControls.LabelCodeText();
            this.HgNote = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgSampleBack = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgColorSample = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.NumberOfCans = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgVolumeCode = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.IndexNumber = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.TintedColor = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgProductName = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgColorName = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.CcmColorName = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgTintingDirection = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgDeliveryCode = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgTruckCompanyName_1 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgProductNo = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgDeliveryDate = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgSalesInCharge = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgDataNumber = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.OrderNumber = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.ProductCode = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.BtnLotRegister = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BorderHgTintingDirection = new NipponPaint.NpCommon.FormControls.PanelBorder();
            this.BorderHgSamplePlates = new NipponPaint.NpCommon.FormControls.PanelBorder();
            this.tabDetail2 = new System.Windows.Forms.TabPage();
            this.HgUnifiedArticleNumber = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgSsShippingDate_2 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgNpcVolumeCode = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgNpcArticleNumber = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgDeliveryAddressKanji = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgDeliveryNameKanji = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgDeliveryPointCode = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgOrderInvoiceId = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgDeliveryTelNo = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgSalesBranchName = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgThemeCode = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.MixingSpeed = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.Overfilling = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgSumUpKey = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.MixingTime = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.QualitySample = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.CapType = new NipponPaint.NpCommon.FormControls.LabelCodeText();
            this.CanType = new NipponPaint.NpCommon.FormControls.LabelCodeText();
            this.HgComments = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.FormulaRelease = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.PrefillAmount = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.tabDetail3 = new System.Windows.Forms.TabPage();
            this.HgRfDisplayColors = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgTruckCompanyName_3 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgAskId = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.labelTextBox68 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgSsDeliveryKanji = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgSsDeliveryCode = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgDeliveryAreaCode = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgCustomerName = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgPaintKindCode = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgCancel = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgWaterBorne = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgSsCode = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgAdditionalNo2 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgAdditionalNo1 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.HgLineNumber = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.tabFormulation = new System.Windows.Forms.TabPage();
            this.splitFormulation = new System.Windows.Forms.SplitContainer();
            this.GvFormulation = new System.Windows.Forms.DataGridView();
            this.pnlFormulation = new System.Windows.Forms.Panel();
            this.labelTextBox79 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.labelTextBox78 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.labelTextBox77 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.labelTextBox76 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.labelTextBox75 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.labelTextBox74 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.labelTextBox73 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.labelTextBox62 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.labelTextBox61 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.labelTextBox60 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.labelTextBox59 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.labelTextBox58 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.labelTextBox57 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.labelTextBox56 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.labelTextBox55 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.labelTextBox54 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.labelTextBox53 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.labelTextBox52 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.labelTextBox51 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.GvWeight = new System.Windows.Forms.DataGridView();
            this.tabCan = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.GvOutWeight = new System.Windows.Forms.DataGridView();
            this.GvWeightDetail = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.labelTextBox83 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.labelTextBox82 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.labelTextBox81 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.labelTextBox80 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.labelTextBox12 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.labelTextBox11 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.labelTextBox10 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.labelTextBox9 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.GvBarcode = new System.Windows.Forms.DataGridView();
            this.GvOrderNumber = new System.Windows.Forms.DataGridView();
            this.splitCanMain = new System.Windows.Forms.SplitContainer();
            this.splitCanLeft = new System.Windows.Forms.SplitContainer();
            this.splitCanRight = new System.Windows.Forms.SplitContainer();
            this.pnlFuncs = new System.Windows.Forms.Panel();
            this.BtnProcessDetail = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.BtnStatusResume = new System.Windows.Forms.Button();
            this.BtnOrderStart = new System.Windows.Forms.Button();
            this.BtnDecidePerson = new System.Windows.Forms.Button();
            this.BtnOrderClose = new System.Windows.Forms.Button();
            this.BtnPrintEmergency = new System.Windows.Forms.Button();
            this.BtnPrintInstructions = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RdoTomorrowAfter = new System.Windows.Forms.RadioButton();
            this.RdoTodayBefore = new System.Windows.Forms.RadioButton();
            this.RdoPreviewAll = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RdoOrderPerson = new System.Windows.Forms.RadioButton();
            this.RdoSortRanking = new System.Windows.Forms.RadioButton();
            this.RdoSortKubun = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlColorExplanation = new System.Windows.Forms.Panel();
            this.lblStatus5 = new System.Windows.Forms.Label();
            this.lblStatus4 = new System.Windows.Forms.Label();
            this.lblStatus3 = new System.Windows.Forms.Label();
            this.lblStatus2 = new System.Windows.Forms.Label();
            this.lblStatus1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panLogo = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.BorderBtnPrint = new NipponPaint.NpCommon.FormControls.PanelBorder();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCloseForm = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCanType = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCapType = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemProductCodeMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNPProductCodeMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemInitialSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSelectLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemShipping = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCOMPort = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCCMSimulator = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLabelSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.tabOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvOrder)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitDetail)).BeginInit();
            this.splitDetail.Panel1.SuspendLayout();
            this.splitDetail.Panel2.SuspendLayout();
            this.splitDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvDetail)).BeginInit();
            this.pnlDetailItems.SuspendLayout();
            this.tabDetailSub.SuspendLayout();
            this.tabDetail1.SuspendLayout();
            this.tabDetail2.SuspendLayout();
            this.tabDetail3.SuspendLayout();
            this.tabFormulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitFormulation)).BeginInit();
            this.splitFormulation.Panel1.SuspendLayout();
            this.splitFormulation.Panel2.SuspendLayout();
            this.splitFormulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvFormulation)).BeginInit();
            this.pnlFormulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvWeight)).BeginInit();
            this.tabCan.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvOutWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvWeightDetail)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvOrderNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitCanMain)).BeginInit();
            this.splitCanMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitCanLeft)).BeginInit();
            this.splitCanLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitCanRight)).BeginInit();
            this.splitCanRight.SuspendLayout();
            this.pnlFuncs.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlColorExplanation.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOrder
            // 
            this.tabOrder.BackColor = System.Drawing.SystemColors.Control;
            this.tabOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabOrder.Controls.Add(this.GvOrder);
            this.tabOrder.Location = new System.Drawing.Point(4, 29);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrder.Size = new System.Drawing.Size(1663, 932);
            this.tabOrder.TabIndex = 0;
            this.tabOrder.Text = "注文";
            // 
            // GvOrder
            // 
            this.GvOrder.AllowUserToAddRows = false;
            this.GvOrder.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvOrder.ContextMenuStrip = this.contextMenuStrip;
            this.GvOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GvOrder.Location = new System.Drawing.Point(3, 3);
            this.GvOrder.Name = "GvOrder";
            this.GvOrder.ReadOnly = true;
            this.GvOrder.RowTemplate.Height = 21;
            this.GvOrder.Size = new System.Drawing.Size(1655, 924);
            this.GvOrder.TabIndex = 0;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Font = new System.Drawing.Font("メイリオ", 9F);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiDecide,
            this.TsmiOperatorDelete,
            this.TsmiOrderStart,
            this.TsmiInstructionPrint,
            this.TsmiProductLabelPrint,
            this.TsmiColorLabelPrint,
            this.TsmiCopyLabelPrint,
            this.TsmiOrderClose});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(197, 180);
            // 
            // TsmiDecide
            // 
            this.TsmiDecide.Name = "TsmiDecide";
            this.TsmiDecide.Size = new System.Drawing.Size(196, 22);
            this.TsmiDecide.Text = "担当者を決定";
            // 
            // TsmiOperatorDelete
            // 
            this.TsmiOperatorDelete.Name = "TsmiOperatorDelete";
            this.TsmiOperatorDelete.Size = new System.Drawing.Size(196, 22);
            this.TsmiOperatorDelete.Text = "オペレータ削除";
            // 
            // TsmiOrderStart
            // 
            this.TsmiOrderStart.Name = "TsmiOrderStart";
            this.TsmiOrderStart.Size = new System.Drawing.Size(196, 22);
            this.TsmiOrderStart.Text = "注文開始";
            // 
            // TsmiInstructionPrint
            // 
            this.TsmiInstructionPrint.Name = "TsmiInstructionPrint";
            this.TsmiInstructionPrint.Size = new System.Drawing.Size(196, 22);
            this.TsmiInstructionPrint.Text = "作業指示書の印刷";
            // 
            // TsmiProductLabelPrint
            // 
            this.TsmiProductLabelPrint.Name = "TsmiProductLabelPrint";
            this.TsmiProductLabelPrint.Size = new System.Drawing.Size(196, 22);
            this.TsmiProductLabelPrint.Text = "製品ラベルのプリント";
            // 
            // TsmiColorLabelPrint
            // 
            this.TsmiColorLabelPrint.Name = "TsmiColorLabelPrint";
            this.TsmiColorLabelPrint.Size = new System.Drawing.Size(196, 22);
            this.TsmiColorLabelPrint.Text = "色名ラベルのプリント";
            // 
            // TsmiCopyLabelPrint
            // 
            this.TsmiCopyLabelPrint.Name = "TsmiCopyLabelPrint";
            this.TsmiCopyLabelPrint.Size = new System.Drawing.Size(196, 22);
            this.TsmiCopyLabelPrint.Text = "控え板ラベル印刷";
            // 
            // TsmiOrderClose
            // 
            this.TsmiOrderClose.Name = "TsmiOrderClose";
            this.TsmiOrderClose.Size = new System.Drawing.Size(196, 22);
            this.TsmiOrderClose.Text = "注文を閉じる";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabOrder);
            this.tabMain.Controls.Add(this.tabDetail);
            this.tabMain.Controls.Add(this.tabFormulation);
            this.tabMain.Controls.Add(this.tabCan);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.ItemSize = new System.Drawing.Size(84, 25);
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1671, 965);
            this.tabMain.TabIndex = 7;
            // 
            // tabDetail
            // 
            this.tabDetail.BackColor = System.Drawing.SystemColors.Control;
            this.tabDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabDetail.Controls.Add(this.splitDetail);
            this.tabDetail.Location = new System.Drawing.Point(4, 29);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetail.Size = new System.Drawing.Size(1663, 932);
            this.tabDetail.TabIndex = 1;
            this.tabDetail.Text = "詳細";
            // 
            // splitDetail
            // 
            this.splitDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitDetail.Location = new System.Drawing.Point(3, 3);
            this.splitDetail.Name = "splitDetail";
            this.splitDetail.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitDetail.Panel1
            // 
            this.splitDetail.Panel1.Controls.Add(this.GvDetail);
            // 
            // splitDetail.Panel2
            // 
            this.splitDetail.Panel2.Controls.Add(this.pnlDetailItems);
            this.splitDetail.Size = new System.Drawing.Size(1655, 924);
            this.splitDetail.SplitterDistance = 396;
            this.splitDetail.SplitterWidth = 3;
            this.splitDetail.TabIndex = 0;
            // 
            // GvDetail
            // 
            this.GvDetail.AllowUserToAddRows = false;
            this.GvDetail.AllowUserToDeleteRows = false;
            this.GvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GvDetail.Location = new System.Drawing.Point(0, 0);
            this.GvDetail.Name = "GvDetail";
            this.GvDetail.ReadOnly = true;
            this.GvDetail.RowTemplate.Height = 21;
            this.GvDetail.Size = new System.Drawing.Size(1655, 396);
            this.GvDetail.TabIndex = 0;
            // 
            // pnlDetailItems
            // 
            this.pnlDetailItems.Controls.Add(this.tabDetailSub);
            this.pnlDetailItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetailItems.Location = new System.Drawing.Point(0, 0);
            this.pnlDetailItems.Name = "pnlDetailItems";
            this.pnlDetailItems.Size = new System.Drawing.Size(1655, 525);
            this.pnlDetailItems.TabIndex = 0;
            // 
            // tabDetailSub
            // 
            this.tabDetailSub.Controls.Add(this.tabDetail1);
            this.tabDetailSub.Controls.Add(this.tabDetail2);
            this.tabDetailSub.Controls.Add(this.tabDetail3);
            this.tabDetailSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDetailSub.Location = new System.Drawing.Point(0, 0);
            this.tabDetailSub.Name = "tabDetailSub";
            this.tabDetailSub.SelectedIndex = 0;
            this.tabDetailSub.Size = new System.Drawing.Size(1655, 525);
            this.tabDetailSub.TabIndex = 0;
            // 
            // tabDetail1
            // 
            this.tabDetail1.BackColor = System.Drawing.SystemColors.Control;
            this.tabDetail1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabDetail1.Controls.Add(this.HgWeight);
            this.tabDetail1.Controls.Add(this.TotalWeight);
            this.tabDetail1.Controls.Add(this.HgOrderInputTime);
            this.tabDetail1.Controls.Add(this.HgOrderInputDate);
            this.tabDetail1.Controls.Add(this.HgTintingPriceRank);
            this.tabDetail1.Controls.Add(this.Revision);
            this.tabDetail1.Controls.Add(this.HgCustomerCode);
            this.tabDetail1.Controls.Add(this.HgSupplementalAddition);
            this.tabDetail1.Controls.Add(this.HgSsShippingDate_1);
            this.tabDetail1.Controls.Add(this.HgSamplePlates);
            this.tabDetail1.Controls.Add(this.HgGlossAddition);
            this.tabDetail1.Controls.Add(this.HgNote);
            this.tabDetail1.Controls.Add(this.HgSampleBack);
            this.tabDetail1.Controls.Add(this.HgColorSample);
            this.tabDetail1.Controls.Add(this.NumberOfCans);
            this.tabDetail1.Controls.Add(this.HgVolumeCode);
            this.tabDetail1.Controls.Add(this.IndexNumber);
            this.tabDetail1.Controls.Add(this.TintedColor);
            this.tabDetail1.Controls.Add(this.HgProductName);
            this.tabDetail1.Controls.Add(this.HgColorName);
            this.tabDetail1.Controls.Add(this.CcmColorName);
            this.tabDetail1.Controls.Add(this.HgTintingDirection);
            this.tabDetail1.Controls.Add(this.HgDeliveryCode);
            this.tabDetail1.Controls.Add(this.HgTruckCompanyName_1);
            this.tabDetail1.Controls.Add(this.HgProductNo);
            this.tabDetail1.Controls.Add(this.HgDeliveryDate);
            this.tabDetail1.Controls.Add(this.HgSalesInCharge);
            this.tabDetail1.Controls.Add(this.HgDataNumber);
            this.tabDetail1.Controls.Add(this.OrderNumber);
            this.tabDetail1.Controls.Add(this.ProductCode);
            this.tabDetail1.Controls.Add(this.BtnLotRegister);
            this.tabDetail1.Controls.Add(this.button2);
            this.tabDetail1.Controls.Add(this.button1);
            this.tabDetail1.Controls.Add(this.BorderHgTintingDirection);
            this.tabDetail1.Controls.Add(this.BorderHgSamplePlates);
            this.tabDetail1.Font = new System.Drawing.Font("メイリオ", 7F);
            this.tabDetail1.Location = new System.Drawing.Point(4, 32);
            this.tabDetail1.Name = "tabDetail1";
            this.tabDetail1.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetail1.Size = new System.Drawing.Size(1647, 489);
            this.tabDetail1.TabIndex = 0;
            this.tabDetail1.Text = "詳細１";
            this.tabDetail1.Click += new System.EventHandler(this.tabDetail1_Click);
            // 
            // HgWeight
            // 
            this.HgWeight.DatabaseColumnName = "HG_Weight";
            this.HgWeight.DataControlName = "txtData";
            this.HgWeight.DataEnabled = true;
            this.HgWeight.DataReadOnly = false;
            this.HgWeight.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgWeight.DataTextSize = new System.Drawing.Size(139, 30);
            this.HgWeight.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgWeight.Id = "";
            this.HgWeight.Label = "";
            this.HgWeight.Location = new System.Drawing.Point(933, 454);
            this.HgWeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgWeight.MaxByteLength = 65535;
            this.HgWeight.MaxLength = 0;
            this.HgWeight.Name = "HgWeight";
            this.HgWeight.Size = new System.Drawing.Size(293, 30);
            this.HgWeight.TabIndex = 96;
            this.HgWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgWeight.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgWeight.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgWeight.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgWeight.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgWeight.Title = "充填済み重量(g)";
            this.HgWeight.TitleControlName = "lblTitle";
            this.HgWeight.TitleSize = new System.Drawing.Size(154, 30);
            this.HgWeight.Value = "";
            // 
            // TotalWeight
            // 
            this.TotalWeight.DatabaseColumnName = "Total_Weight";
            this.TotalWeight.DataControlName = "txtData";
            this.TotalWeight.DataEnabled = true;
            this.TotalWeight.DataReadOnly = false;
            this.TotalWeight.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TotalWeight.DataTextSize = new System.Drawing.Size(139, 30);
            this.TotalWeight.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TotalWeight.Id = "";
            this.TotalWeight.Label = "";
            this.TotalWeight.Location = new System.Drawing.Point(623, 454);
            this.TotalWeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TotalWeight.MaxByteLength = 65535;
            this.TotalWeight.MaxLength = 0;
            this.TotalWeight.Name = "TotalWeight";
            this.TotalWeight.Size = new System.Drawing.Size(293, 30);
            this.TotalWeight.TabIndex = 95;
            this.TotalWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TotalWeight.TextBackColor = System.Drawing.SystemColors.Window;
            this.TotalWeight.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalWeight.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TotalWeight.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TotalWeight.Title = "合計重量[g]";
            this.TotalWeight.TitleControlName = "lblTitle";
            this.TotalWeight.TitleSize = new System.Drawing.Size(154, 30);
            this.TotalWeight.Value = "";
            // 
            // HgOrderInputTime
            // 
            this.HgOrderInputTime.DatabaseColumnName = "HG_Order_Input_Time";
            this.HgOrderInputTime.DataControlName = "txtData";
            this.HgOrderInputTime.DataEnabled = true;
            this.HgOrderInputTime.DataReadOnly = false;
            this.HgOrderInputTime.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgOrderInputTime.DataTextSize = new System.Drawing.Size(139, 30);
            this.HgOrderInputTime.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgOrderInputTime.Id = "";
            this.HgOrderInputTime.Label = "";
            this.HgOrderInputTime.Location = new System.Drawing.Point(313, 454);
            this.HgOrderInputTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgOrderInputTime.MaxByteLength = 65535;
            this.HgOrderInputTime.MaxLength = 0;
            this.HgOrderInputTime.Name = "HgOrderInputTime";
            this.HgOrderInputTime.Size = new System.Drawing.Size(293, 30);
            this.HgOrderInputTime.TabIndex = 94;
            this.HgOrderInputTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgOrderInputTime.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgOrderInputTime.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgOrderInputTime.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgOrderInputTime.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgOrderInputTime.Title = "投入時刻";
            this.HgOrderInputTime.TitleControlName = "lblTitle";
            this.HgOrderInputTime.TitleSize = new System.Drawing.Size(154, 30);
            this.HgOrderInputTime.Value = "";
            // 
            // HgOrderInputDate
            // 
            this.HgOrderInputDate.DatabaseColumnName = "HG_Order_Input_Date";
            this.HgOrderInputDate.DataControlName = "txtData";
            this.HgOrderInputDate.DataEnabled = true;
            this.HgOrderInputDate.DataReadOnly = false;
            this.HgOrderInputDate.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgOrderInputDate.DataTextSize = new System.Drawing.Size(139, 30);
            this.HgOrderInputDate.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgOrderInputDate.Id = "";
            this.HgOrderInputDate.Label = "";
            this.HgOrderInputDate.Location = new System.Drawing.Point(3, 454);
            this.HgOrderInputDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgOrderInputDate.MaxByteLength = 65535;
            this.HgOrderInputDate.MaxLength = 0;
            this.HgOrderInputDate.Name = "HgOrderInputDate";
            this.HgOrderInputDate.Size = new System.Drawing.Size(293, 30);
            this.HgOrderInputDate.TabIndex = 93;
            this.HgOrderInputDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgOrderInputDate.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgOrderInputDate.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgOrderInputDate.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgOrderInputDate.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgOrderInputDate.Title = "投入日";
            this.HgOrderInputDate.TitleControlName = "lblTitle";
            this.HgOrderInputDate.TitleSize = new System.Drawing.Size(154, 30);
            this.HgOrderInputDate.Value = "";
            // 
            // HgTintingPriceRank
            // 
            this.HgTintingPriceRank.DatabaseColumnName = "HG_Tinting_Price_Rank";
            this.HgTintingPriceRank.DataControlName = "txtData";
            this.HgTintingPriceRank.DataEnabled = true;
            this.HgTintingPriceRank.DataReadOnly = false;
            this.HgTintingPriceRank.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgTintingPriceRank.DataTextSize = new System.Drawing.Size(139, 30);
            this.HgTintingPriceRank.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgTintingPriceRank.Id = "";
            this.HgTintingPriceRank.Label = "";
            this.HgTintingPriceRank.Location = new System.Drawing.Point(313, 419);
            this.HgTintingPriceRank.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgTintingPriceRank.MaxByteLength = 65535;
            this.HgTintingPriceRank.MaxLength = 0;
            this.HgTintingPriceRank.Name = "HgTintingPriceRank";
            this.HgTintingPriceRank.Size = new System.Drawing.Size(293, 30);
            this.HgTintingPriceRank.TabIndex = 92;
            this.HgTintingPriceRank.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgTintingPriceRank.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgTintingPriceRank.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgTintingPriceRank.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgTintingPriceRank.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgTintingPriceRank.Title = "調色ランク";
            this.HgTintingPriceRank.TitleControlName = "lblTitle";
            this.HgTintingPriceRank.TitleSize = new System.Drawing.Size(154, 30);
            this.HgTintingPriceRank.Value = "";
            // 
            // Revision
            // 
            this.Revision.DatabaseColumnName = "Revision";
            this.Revision.DataControlName = "txtData";
            this.Revision.DataEnabled = true;
            this.Revision.DataReadOnly = false;
            this.Revision.DataTextLocation = new System.Drawing.Point(154, 0);
            this.Revision.DataTextSize = new System.Drawing.Size(139, 30);
            this.Revision.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Revision.Id = "";
            this.Revision.Label = "";
            this.Revision.Location = new System.Drawing.Point(3, 419);
            this.Revision.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Revision.MaxByteLength = 65535;
            this.Revision.MaxLength = 0;
            this.Revision.Name = "Revision";
            this.Revision.Size = new System.Drawing.Size(293, 30);
            this.Revision.TabIndex = 91;
            this.Revision.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Revision.TextBackColor = System.Drawing.SystemColors.Window;
            this.Revision.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Revision.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Revision.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.Revision.Title = "補正";
            this.Revision.TitleControlName = "lblTitle";
            this.Revision.TitleSize = new System.Drawing.Size(154, 30);
            this.Revision.Value = "";
            // 
            // HgCustomerCode
            // 
            this.HgCustomerCode.CodeControlName = "txtCode";
            this.HgCustomerCode.CodeReadOnly = false;
            this.HgCustomerCode.CodeText = "";
            this.HgCustomerCode.CodeTextSize = new System.Drawing.Size(80, 30);
            this.HgCustomerCode.DatabaseColumnCode = "";
            this.HgCustomerCode.DatabaseColumnName = "";
            this.HgCustomerCode.DataControlName = "txtData";
            this.HgCustomerCode.DataReadOnly = false;
            this.HgCustomerCode.DataTextSize = new System.Drawing.Size(1069, 30);
            this.HgCustomerCode.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgCustomerCode.Location = new System.Drawing.Point(3, 384);
            this.HgCustomerCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HgCustomerCode.Name = "HgCustomerCode";
            this.HgCustomerCode.Size = new System.Drawing.Size(1223, 30);
            this.HgCustomerCode.TabIndex = 90;
            this.HgCustomerCode.TextAlignCode = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgCustomerCode.TextAlignData = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgCustomerCode.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgCustomerCode.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgCustomerCode.Title = "得意先";
            this.HgCustomerCode.TitleControlName = "lblTitle";
            this.HgCustomerCode.TitleSize = new System.Drawing.Size(154, 30);
            // 
            // HgSupplementalAddition
            // 
            this.HgSupplementalAddition.CodeControlName = "txtCode";
            this.HgSupplementalAddition.CodeReadOnly = false;
            this.HgSupplementalAddition.CodeText = "";
            this.HgSupplementalAddition.CodeTextSize = new System.Drawing.Size(80, 30);
            this.HgSupplementalAddition.DatabaseColumnCode = "";
            this.HgSupplementalAddition.DatabaseColumnName = "";
            this.HgSupplementalAddition.DataControlName = "txtData";
            this.HgSupplementalAddition.DataReadOnly = false;
            this.HgSupplementalAddition.DataTextSize = new System.Drawing.Size(1069, 30);
            this.HgSupplementalAddition.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgSupplementalAddition.Location = new System.Drawing.Point(3, 349);
            this.HgSupplementalAddition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HgSupplementalAddition.Name = "HgSupplementalAddition";
            this.HgSupplementalAddition.Size = new System.Drawing.Size(1223, 30);
            this.HgSupplementalAddition.TabIndex = 89;
            this.HgSupplementalAddition.TextAlignCode = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgSupplementalAddition.TextAlignData = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgSupplementalAddition.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgSupplementalAddition.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgSupplementalAddition.Title = "機能区分";
            this.HgSupplementalAddition.TitleControlName = "lblTitle";
            this.HgSupplementalAddition.TitleSize = new System.Drawing.Size(154, 30);
            // 
            // HgSsShippingDate_1
            // 
            this.HgSsShippingDate_1.DatabaseColumnName = "HG_SS_Shipping_Date";
            this.HgSsShippingDate_1.DataControlName = "txtData";
            this.HgSsShippingDate_1.DataEnabled = true;
            this.HgSsShippingDate_1.DataReadOnly = false;
            this.HgSsShippingDate_1.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgSsShippingDate_1.DataTextSize = new System.Drawing.Size(139, 30);
            this.HgSsShippingDate_1.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgSsShippingDate_1.Id = "";
            this.HgSsShippingDate_1.Label = "";
            this.HgSsShippingDate_1.Location = new System.Drawing.Point(1243, 348);
            this.HgSsShippingDate_1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgSsShippingDate_1.MaxByteLength = 65535;
            this.HgSsShippingDate_1.MaxLength = 0;
            this.HgSsShippingDate_1.Name = "HgSsShippingDate_1";
            this.HgSsShippingDate_1.Size = new System.Drawing.Size(293, 30);
            this.HgSsShippingDate_1.TabIndex = 88;
            this.HgSsShippingDate_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgSsShippingDate_1.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgSsShippingDate_1.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgSsShippingDate_1.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgSsShippingDate_1.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgSsShippingDate_1.Title = "SS出荷予定日";
            this.HgSsShippingDate_1.TitleControlName = "lblTitle";
            this.HgSsShippingDate_1.TitleSize = new System.Drawing.Size(154, 30);
            this.HgSsShippingDate_1.Value = "";
            // 
            // HgSamplePlates
            // 
            this.HgSamplePlates.DatabaseColumnName = "HG_Sample_Plates";
            this.HgSamplePlates.DataControlName = "txtData";
            this.HgSamplePlates.DataEnabled = true;
            this.HgSamplePlates.DataReadOnly = false;
            this.HgSamplePlates.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgSamplePlates.DataTextSize = new System.Drawing.Size(139, 30);
            this.HgSamplePlates.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgSamplePlates.Id = "";
            this.HgSamplePlates.Label = "";
            this.HgSamplePlates.Location = new System.Drawing.Point(1243, 314);
            this.HgSamplePlates.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgSamplePlates.MaxByteLength = 65535;
            this.HgSamplePlates.MaxLength = 0;
            this.HgSamplePlates.Name = "HgSamplePlates";
            this.HgSamplePlates.Size = new System.Drawing.Size(293, 30);
            this.HgSamplePlates.TabIndex = 87;
            this.HgSamplePlates.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgSamplePlates.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgSamplePlates.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgSamplePlates.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgSamplePlates.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgSamplePlates.Title = "塗板添付枚数";
            this.HgSamplePlates.TitleControlName = "lblTitle";
            this.HgSamplePlates.TitleSize = new System.Drawing.Size(154, 30);
            this.HgSamplePlates.Value = "";
            // 
            // HgGlossAddition
            // 
            this.HgGlossAddition.CodeControlName = "txtCode";
            this.HgGlossAddition.CodeReadOnly = false;
            this.HgGlossAddition.CodeText = "";
            this.HgGlossAddition.CodeTextSize = new System.Drawing.Size(80, 30);
            this.HgGlossAddition.DatabaseColumnCode = "";
            this.HgGlossAddition.DatabaseColumnName = "";
            this.HgGlossAddition.DataControlName = "txtData";
            this.HgGlossAddition.DataReadOnly = false;
            this.HgGlossAddition.DataTextSize = new System.Drawing.Size(1069, 30);
            this.HgGlossAddition.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgGlossAddition.Location = new System.Drawing.Point(3, 314);
            this.HgGlossAddition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HgGlossAddition.Name = "HgGlossAddition";
            this.HgGlossAddition.Size = new System.Drawing.Size(1223, 30);
            this.HgGlossAddition.TabIndex = 86;
            this.HgGlossAddition.TextAlignCode = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgGlossAddition.TextAlignData = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgGlossAddition.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgGlossAddition.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgGlossAddition.Title = "艶区分";
            this.HgGlossAddition.TitleControlName = "lblTitle";
            this.HgGlossAddition.TitleSize = new System.Drawing.Size(154, 30);
            // 
            // HgNote
            // 
            this.HgNote.DatabaseColumnName = "HG_Note";
            this.HgNote.DataControlName = "txtData";
            this.HgNote.DataEnabled = true;
            this.HgNote.DataReadOnly = false;
            this.HgNote.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgNote.DataTextSize = new System.Drawing.Size(1069, 30);
            this.HgNote.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgNote.Id = "";
            this.HgNote.Label = "";
            this.HgNote.Location = new System.Drawing.Point(3, 279);
            this.HgNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgNote.MaxByteLength = 65535;
            this.HgNote.MaxLength = 0;
            this.HgNote.Name = "HgNote";
            this.HgNote.Size = new System.Drawing.Size(1223, 30);
            this.HgNote.TabIndex = 85;
            this.HgNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgNote.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgNote.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgNote.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgNote.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgNote.Title = "調色適用";
            this.HgNote.TitleControlName = "lblTitle";
            this.HgNote.TitleSize = new System.Drawing.Size(154, 30);
            this.HgNote.Value = "";
            // 
            // HgSampleBack
            // 
            this.HgSampleBack.DatabaseColumnName = "HG_Sample_Back";
            this.HgSampleBack.DataControlName = "txtData";
            this.HgSampleBack.DataEnabled = true;
            this.HgSampleBack.DataReadOnly = false;
            this.HgSampleBack.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgSampleBack.DataTextSize = new System.Drawing.Size(759, 30);
            this.HgSampleBack.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgSampleBack.Id = "";
            this.HgSampleBack.Label = "";
            this.HgSampleBack.Location = new System.Drawing.Point(313, 244);
            this.HgSampleBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgSampleBack.MaxByteLength = 65535;
            this.HgSampleBack.MaxLength = 0;
            this.HgSampleBack.Name = "HgSampleBack";
            this.HgSampleBack.Size = new System.Drawing.Size(913, 30);
            this.HgSampleBack.TabIndex = 84;
            this.HgSampleBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgSampleBack.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgSampleBack.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgSampleBack.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgSampleBack.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgSampleBack.Title = "見本返却方法";
            this.HgSampleBack.TitleControlName = "lblTitle";
            this.HgSampleBack.TitleSize = new System.Drawing.Size(154, 30);
            this.HgSampleBack.Value = "";
            // 
            // HgColorSample
            // 
            this.HgColorSample.DatabaseColumnName = "HG_Color_Sample";
            this.HgColorSample.DataControlName = "txtData";
            this.HgColorSample.DataEnabled = true;
            this.HgColorSample.DataReadOnly = false;
            this.HgColorSample.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgColorSample.DataTextSize = new System.Drawing.Size(759, 30);
            this.HgColorSample.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgColorSample.Id = "";
            this.HgColorSample.Label = "";
            this.HgColorSample.Location = new System.Drawing.Point(313, 209);
            this.HgColorSample.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgColorSample.MaxByteLength = 65535;
            this.HgColorSample.MaxLength = 0;
            this.HgColorSample.Name = "HgColorSample";
            this.HgColorSample.Size = new System.Drawing.Size(913, 30);
            this.HgColorSample.TabIndex = 83;
            this.HgColorSample.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgColorSample.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgColorSample.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgColorSample.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgColorSample.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgColorSample.Title = "標準色見本";
            this.HgColorSample.TitleControlName = "lblTitle";
            this.HgColorSample.TitleSize = new System.Drawing.Size(154, 30);
            this.HgColorSample.Value = "";
            // 
            // NumberOfCans
            // 
            this.NumberOfCans.DatabaseColumnName = "Number_of_cans";
            this.NumberOfCans.DataControlName = "txtData";
            this.NumberOfCans.DataEnabled = true;
            this.NumberOfCans.DataReadOnly = false;
            this.NumberOfCans.DataTextLocation = new System.Drawing.Point(154, 0);
            this.NumberOfCans.DataTextSize = new System.Drawing.Size(139, 30);
            this.NumberOfCans.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NumberOfCans.Id = "";
            this.NumberOfCans.Label = "";
            this.NumberOfCans.Location = new System.Drawing.Point(3, 244);
            this.NumberOfCans.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NumberOfCans.MaxByteLength = 65535;
            this.NumberOfCans.MaxLength = 0;
            this.NumberOfCans.Name = "NumberOfCans";
            this.NumberOfCans.Size = new System.Drawing.Size(293, 30);
            this.NumberOfCans.TabIndex = 82;
            this.NumberOfCans.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NumberOfCans.TextBackColor = System.Drawing.SystemColors.Window;
            this.NumberOfCans.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NumberOfCans.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NumberOfCans.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.NumberOfCans.Title = "缶数";
            this.NumberOfCans.TitleControlName = "lblTitle";
            this.NumberOfCans.TitleSize = new System.Drawing.Size(154, 30);
            this.NumberOfCans.Value = "";
            // 
            // HgVolumeCode
            // 
            this.HgVolumeCode.DatabaseColumnName = "HG_Volume_Code";
            this.HgVolumeCode.DataControlName = "txtData";
            this.HgVolumeCode.DataEnabled = true;
            this.HgVolumeCode.DataReadOnly = false;
            this.HgVolumeCode.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgVolumeCode.DataTextSize = new System.Drawing.Size(139, 30);
            this.HgVolumeCode.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgVolumeCode.Id = "";
            this.HgVolumeCode.Label = "";
            this.HgVolumeCode.Location = new System.Drawing.Point(3, 209);
            this.HgVolumeCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgVolumeCode.MaxByteLength = 65535;
            this.HgVolumeCode.MaxLength = 0;
            this.HgVolumeCode.Name = "HgVolumeCode";
            this.HgVolumeCode.Size = new System.Drawing.Size(293, 30);
            this.HgVolumeCode.TabIndex = 81;
            this.HgVolumeCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgVolumeCode.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgVolumeCode.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgVolumeCode.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgVolumeCode.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgVolumeCode.Title = "容量コード";
            this.HgVolumeCode.TitleControlName = "lblTitle";
            this.HgVolumeCode.TitleSize = new System.Drawing.Size(154, 30);
            this.HgVolumeCode.Value = "";
            // 
            // IndexNumber
            // 
            this.IndexNumber.DatabaseColumnName = "Index_Number";
            this.IndexNumber.DataControlName = "txtData";
            this.IndexNumber.DataEnabled = true;
            this.IndexNumber.DataReadOnly = false;
            this.IndexNumber.DataTextLocation = new System.Drawing.Point(154, 0);
            this.IndexNumber.DataTextSize = new System.Drawing.Size(139, 30);
            this.IndexNumber.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.IndexNumber.Id = "";
            this.IndexNumber.Label = "";
            this.IndexNumber.Location = new System.Drawing.Point(1243, 174);
            this.IndexNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IndexNumber.MaxByteLength = 65535;
            this.IndexNumber.MaxLength = 0;
            this.IndexNumber.Name = "IndexNumber";
            this.IndexNumber.Size = new System.Drawing.Size(293, 30);
            this.IndexNumber.TabIndex = 80;
            this.IndexNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.IndexNumber.TextBackColor = System.Drawing.SystemColors.Window;
            this.IndexNumber.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IndexNumber.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.IndexNumber.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.IndexNumber.Title = "目次番号";
            this.IndexNumber.TitleControlName = "lblTitle";
            this.IndexNumber.TitleSize = new System.Drawing.Size(154, 30);
            this.IndexNumber.Value = "";
            // 
            // TintedColor
            // 
            this.TintedColor.DatabaseColumnName = "Tinted_Color";
            this.TintedColor.DataControlName = "txtData";
            this.TintedColor.DataEnabled = true;
            this.TintedColor.DataReadOnly = false;
            this.TintedColor.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TintedColor.DataTextSize = new System.Drawing.Size(139, 30);
            this.TintedColor.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TintedColor.Id = "";
            this.TintedColor.Label = "";
            this.TintedColor.Location = new System.Drawing.Point(933, 174);
            this.TintedColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TintedColor.MaxByteLength = 65535;
            this.TintedColor.MaxLength = 0;
            this.TintedColor.Name = "TintedColor";
            this.TintedColor.Size = new System.Drawing.Size(293, 30);
            this.TintedColor.TabIndex = 79;
            this.TintedColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TintedColor.TextBackColor = System.Drawing.SystemColors.Window;
            this.TintedColor.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TintedColor.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TintedColor.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TintedColor.Title = "既調色ファイル名";
            this.TintedColor.TitleControlName = "lblTitle";
            this.TintedColor.TitleSize = new System.Drawing.Size(154, 30);
            this.TintedColor.Value = "";
            // 
            // HgProductName
            // 
            this.HgProductName.DatabaseColumnName = "HG_Product_Name";
            this.HgProductName.DataControlName = "txtData";
            this.HgProductName.DataEnabled = true;
            this.HgProductName.DataReadOnly = false;
            this.HgProductName.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgProductName.DataTextSize = new System.Drawing.Size(759, 30);
            this.HgProductName.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgProductName.Id = "";
            this.HgProductName.Label = "";
            this.HgProductName.Location = new System.Drawing.Point(3, 174);
            this.HgProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgProductName.MaxByteLength = 65535;
            this.HgProductName.MaxLength = 0;
            this.HgProductName.Name = "HgProductName";
            this.HgProductName.Size = new System.Drawing.Size(913, 30);
            this.HgProductName.TabIndex = 78;
            this.HgProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgProductName.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgProductName.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgProductName.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgProductName.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgProductName.Title = "品名";
            this.HgProductName.TitleControlName = "lblTitle";
            this.HgProductName.TitleSize = new System.Drawing.Size(154, 30);
            this.HgProductName.Value = "";
            // 
            // HgColorName
            // 
            this.HgColorName.DatabaseColumnName = "HG_Color_Name";
            this.HgColorName.DataControlName = "txtData";
            this.HgColorName.DataEnabled = true;
            this.HgColorName.DataReadOnly = false;
            this.HgColorName.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgColorName.DataTextSize = new System.Drawing.Size(1069, 30);
            this.HgColorName.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgColorName.Id = "";
            this.HgColorName.Label = "";
            this.HgColorName.Location = new System.Drawing.Point(3, 139);
            this.HgColorName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgColorName.MaxByteLength = 65535;
            this.HgColorName.MaxLength = 0;
            this.HgColorName.Name = "HgColorName";
            this.HgColorName.Size = new System.Drawing.Size(1223, 30);
            this.HgColorName.TabIndex = 77;
            this.HgColorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgColorName.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgColorName.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgColorName.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgColorName.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgColorName.Title = "色名（6/0）";
            this.HgColorName.TitleControlName = "lblTitle";
            this.HgColorName.TitleSize = new System.Drawing.Size(154, 30);
            this.HgColorName.Value = "";
            // 
            // CcmColorName
            // 
            this.CcmColorName.DatabaseColumnName = "CCM_color_Name";
            this.CcmColorName.DataControlName = "txtData";
            this.CcmColorName.DataEnabled = true;
            this.CcmColorName.DataReadOnly = false;
            this.CcmColorName.DataTextLocation = new System.Drawing.Point(154, 0);
            this.CcmColorName.DataTextSize = new System.Drawing.Size(1069, 30);
            this.CcmColorName.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CcmColorName.Id = "";
            this.CcmColorName.Label = "";
            this.CcmColorName.Location = new System.Drawing.Point(3, 104);
            this.CcmColorName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CcmColorName.MaxByteLength = 65535;
            this.CcmColorName.MaxLength = 0;
            this.CcmColorName.Name = "CcmColorName";
            this.CcmColorName.Size = new System.Drawing.Size(1223, 30);
            this.CcmColorName.TabIndex = 76;
            this.CcmColorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CcmColorName.TextBackColor = System.Drawing.SystemColors.Window;
            this.CcmColorName.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CcmColorName.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CcmColorName.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.CcmColorName.Title = "CCM色名";
            this.CcmColorName.TitleControlName = "lblTitle";
            this.CcmColorName.TitleSize = new System.Drawing.Size(154, 30);
            this.CcmColorName.Value = "";
            // 
            // HgTintingDirection
            // 
            this.HgTintingDirection.DatabaseColumnName = "HG_Tinting_Direction";
            this.HgTintingDirection.DataControlName = "txtData";
            this.HgTintingDirection.DataEnabled = true;
            this.HgTintingDirection.DataReadOnly = false;
            this.HgTintingDirection.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgTintingDirection.DataTextSize = new System.Drawing.Size(449, 30);
            this.HgTintingDirection.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgTintingDirection.Id = "";
            this.HgTintingDirection.Label = "";
            this.HgTintingDirection.Location = new System.Drawing.Point(933, 69);
            this.HgTintingDirection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgTintingDirection.MaxByteLength = 65535;
            this.HgTintingDirection.MaxLength = 0;
            this.HgTintingDirection.Name = "HgTintingDirection";
            this.HgTintingDirection.Size = new System.Drawing.Size(603, 30);
            this.HgTintingDirection.TabIndex = 75;
            this.HgTintingDirection.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgTintingDirection.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgTintingDirection.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgTintingDirection.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgTintingDirection.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgTintingDirection.Title = "指定LOT";
            this.HgTintingDirection.TitleControlName = "lblTitle";
            this.HgTintingDirection.TitleSize = new System.Drawing.Size(154, 30);
            this.HgTintingDirection.Value = "";
            // 
            // HgDeliveryCode
            // 
            this.HgDeliveryCode.DatabaseColumnName = "HG_HG_Delivery_Code";
            this.HgDeliveryCode.DataControlName = "txtData";
            this.HgDeliveryCode.DataEnabled = true;
            this.HgDeliveryCode.DataReadOnly = false;
            this.HgDeliveryCode.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgDeliveryCode.DataTextSize = new System.Drawing.Size(139, 30);
            this.HgDeliveryCode.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgDeliveryCode.Id = "";
            this.HgDeliveryCode.Label = "";
            this.HgDeliveryCode.Location = new System.Drawing.Point(623, 69);
            this.HgDeliveryCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgDeliveryCode.MaxByteLength = 65535;
            this.HgDeliveryCode.MaxLength = 0;
            this.HgDeliveryCode.Name = "HgDeliveryCode";
            this.HgDeliveryCode.Size = new System.Drawing.Size(293, 30);
            this.HgDeliveryCode.TabIndex = 74;
            this.HgDeliveryCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgDeliveryCode.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgDeliveryCode.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgDeliveryCode.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgDeliveryCode.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgDeliveryCode.Title = "配送モード";
            this.HgDeliveryCode.TitleControlName = "lblTitle";
            this.HgDeliveryCode.TitleSize = new System.Drawing.Size(154, 30);
            this.HgDeliveryCode.Value = "";
            // 
            // HgTruckCompanyName_1
            // 
            this.HgTruckCompanyName_1.DatabaseColumnName = "HG_Truck_Company_Name";
            this.HgTruckCompanyName_1.DataControlName = "txtData";
            this.HgTruckCompanyName_1.DataEnabled = true;
            this.HgTruckCompanyName_1.DataReadOnly = false;
            this.HgTruckCompanyName_1.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgTruckCompanyName_1.DataTextSize = new System.Drawing.Size(139, 30);
            this.HgTruckCompanyName_1.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgTruckCompanyName_1.Id = "";
            this.HgTruckCompanyName_1.Label = "";
            this.HgTruckCompanyName_1.Location = new System.Drawing.Point(313, 69);
            this.HgTruckCompanyName_1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgTruckCompanyName_1.MaxByteLength = 65535;
            this.HgTruckCompanyName_1.MaxLength = 0;
            this.HgTruckCompanyName_1.Name = "HgTruckCompanyName_1";
            this.HgTruckCompanyName_1.Size = new System.Drawing.Size(293, 30);
            this.HgTruckCompanyName_1.TabIndex = 73;
            this.HgTruckCompanyName_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgTruckCompanyName_1.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgTruckCompanyName_1.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgTruckCompanyName_1.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgTruckCompanyName_1.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgTruckCompanyName_1.Title = "配送業者";
            this.HgTruckCompanyName_1.TitleControlName = "lblTitle";
            this.HgTruckCompanyName_1.TitleSize = new System.Drawing.Size(154, 30);
            this.HgTruckCompanyName_1.Value = "";
            // 
            // HgProductNo
            // 
            this.HgProductNo.DatabaseColumnName = "HG_Product_No";
            this.HgProductNo.DataControlName = "txtData";
            this.HgProductNo.DataEnabled = true;
            this.HgProductNo.DataReadOnly = false;
            this.HgProductNo.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgProductNo.DataTextSize = new System.Drawing.Size(139, 30);
            this.HgProductNo.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgProductNo.Id = "";
            this.HgProductNo.Label = "";
            this.HgProductNo.Location = new System.Drawing.Point(3, 69);
            this.HgProductNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgProductNo.MaxByteLength = 65535;
            this.HgProductNo.MaxLength = 0;
            this.HgProductNo.Name = "HgProductNo";
            this.HgProductNo.Size = new System.Drawing.Size(293, 30);
            this.HgProductNo.TabIndex = 72;
            this.HgProductNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgProductNo.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgProductNo.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgProductNo.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgProductNo.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgProductNo.Title = "品名コード";
            this.HgProductNo.TitleControlName = "lblTitle";
            this.HgProductNo.TitleSize = new System.Drawing.Size(154, 30);
            this.HgProductNo.Value = "";
            // 
            // HgDeliveryDate
            // 
            this.HgDeliveryDate.DatabaseColumnName = "HG_Delivery_Date";
            this.HgDeliveryDate.DataControlName = "txtData";
            this.HgDeliveryDate.DataEnabled = true;
            this.HgDeliveryDate.DataReadOnly = false;
            this.HgDeliveryDate.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgDeliveryDate.DataTextSize = new System.Drawing.Size(139, 30);
            this.HgDeliveryDate.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgDeliveryDate.Id = "";
            this.HgDeliveryDate.Label = "";
            this.HgDeliveryDate.Location = new System.Drawing.Point(1243, 104);
            this.HgDeliveryDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgDeliveryDate.MaxByteLength = 65535;
            this.HgDeliveryDate.MaxLength = 0;
            this.HgDeliveryDate.Name = "HgDeliveryDate";
            this.HgDeliveryDate.Size = new System.Drawing.Size(293, 30);
            this.HgDeliveryDate.TabIndex = 71;
            this.HgDeliveryDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgDeliveryDate.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgDeliveryDate.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgDeliveryDate.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgDeliveryDate.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgDeliveryDate.Title = "納期";
            this.HgDeliveryDate.TitleControlName = "lblTitle";
            this.HgDeliveryDate.TitleSize = new System.Drawing.Size(154, 30);
            this.HgDeliveryDate.Value = "";
            // 
            // HgSalesInCharge
            // 
            this.HgSalesInCharge.DatabaseColumnName = "HG_Sales_in_Charge";
            this.HgSalesInCharge.DataControlName = "txtData";
            this.HgSalesInCharge.DataEnabled = true;
            this.HgSalesInCharge.DataReadOnly = false;
            this.HgSalesInCharge.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgSalesInCharge.DataTextSize = new System.Drawing.Size(139, 30);
            this.HgSalesInCharge.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgSalesInCharge.Id = "";
            this.HgSalesInCharge.Label = "";
            this.HgSalesInCharge.Location = new System.Drawing.Point(1243, 34);
            this.HgSalesInCharge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgSalesInCharge.MaxByteLength = 65535;
            this.HgSalesInCharge.MaxLength = 0;
            this.HgSalesInCharge.Name = "HgSalesInCharge";
            this.HgSalesInCharge.Size = new System.Drawing.Size(293, 30);
            this.HgSalesInCharge.TabIndex = 70;
            this.HgSalesInCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgSalesInCharge.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgSalesInCharge.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgSalesInCharge.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgSalesInCharge.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgSalesInCharge.Title = "受注担当者";
            this.HgSalesInCharge.TitleControlName = "lblTitle";
            this.HgSalesInCharge.TitleSize = new System.Drawing.Size(154, 30);
            this.HgSalesInCharge.Value = "";
            // 
            // HgDataNumber
            // 
            this.HgDataNumber.DatabaseColumnName = "HG_Data_Number";
            this.HgDataNumber.DataControlName = "txtData";
            this.HgDataNumber.DataEnabled = true;
            this.HgDataNumber.DataReadOnly = false;
            this.HgDataNumber.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgDataNumber.DataTextSize = new System.Drawing.Size(311, 59);
            this.HgDataNumber.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgDataNumber.Id = "";
            this.HgDataNumber.Label = "";
            this.HgDataNumber.Location = new System.Drawing.Point(313, 5);
            this.HgDataNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgDataNumber.MaxByteLength = 65535;
            this.HgDataNumber.MaxLength = 0;
            this.HgDataNumber.Name = "HgDataNumber";
            this.HgDataNumber.Size = new System.Drawing.Size(465, 59);
            this.HgDataNumber.TabIndex = 69;
            this.HgDataNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgDataNumber.TextBackColor = System.Drawing.Color.MistyRose;
            this.HgDataNumber.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgDataNumber.TextFont = new System.Drawing.Font("メイリオ", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgDataNumber.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgDataNumber.Title = "処理No.";
            this.HgDataNumber.TitleControlName = "lblTitle";
            this.HgDataNumber.TitleSize = new System.Drawing.Size(154, 59);
            this.HgDataNumber.Value = "";
            // 
            // OrderNumber
            // 
            this.OrderNumber.DatabaseColumnName = "Order_Number";
            this.OrderNumber.DataControlName = "txtData";
            this.OrderNumber.DataEnabled = true;
            this.OrderNumber.DataReadOnly = false;
            this.OrderNumber.DataTextLocation = new System.Drawing.Point(154, 0);
            this.OrderNumber.DataTextSize = new System.Drawing.Size(139, 30);
            this.OrderNumber.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OrderNumber.Id = "";
            this.OrderNumber.Label = "";
            this.OrderNumber.Location = new System.Drawing.Point(933, 34);
            this.OrderNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrderNumber.MaxByteLength = 65535;
            this.OrderNumber.MaxLength = 0;
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.Size = new System.Drawing.Size(293, 30);
            this.OrderNumber.TabIndex = 68;
            this.OrderNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.OrderNumber.TextBackColor = System.Drawing.SystemColors.Window;
            this.OrderNumber.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OrderNumber.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OrderNumber.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.OrderNumber.Title = "注文番号";
            this.OrderNumber.TitleControlName = "lblTitle";
            this.OrderNumber.TitleSize = new System.Drawing.Size(154, 30);
            this.OrderNumber.Value = "";
            // 
            // ProductCode
            // 
            this.ProductCode.DatabaseColumnName = "Product_Code";
            this.ProductCode.DataControlName = "txtData";
            this.ProductCode.DataEnabled = true;
            this.ProductCode.DataReadOnly = false;
            this.ProductCode.DataTextLocation = new System.Drawing.Point(154, 0);
            this.ProductCode.DataTextSize = new System.Drawing.Size(139, 59);
            this.ProductCode.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ProductCode.Id = "";
            this.ProductCode.Label = "";
            this.ProductCode.Location = new System.Drawing.Point(3, 5);
            this.ProductCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductCode.MaxByteLength = 65535;
            this.ProductCode.MaxLength = 0;
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.Size = new System.Drawing.Size(293, 59);
            this.ProductCode.TabIndex = 67;
            this.ProductCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductCode.TextBackColor = System.Drawing.Color.MistyRose;
            this.ProductCode.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProductCode.TextFont = new System.Drawing.Font("メイリオ", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ProductCode.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.ProductCode.Title = "製品コード";
            this.ProductCode.TitleControlName = "lblTitle";
            this.ProductCode.TitleSize = new System.Drawing.Size(154, 59);
            this.ProductCode.Value = "";
            // 
            // BtnLotRegister
            // 
            this.BtnLotRegister.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnLotRegister.Location = new System.Drawing.Point(1549, 69);
            this.BtnLotRegister.Name = "BtnLotRegister";
            this.BtnLotRegister.Size = new System.Drawing.Size(57, 30);
            this.BtnLotRegister.TabIndex = 33;
            this.BtnLotRegister.Text = "...(&L)";
            this.BtnLotRegister.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(1299, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 30);
            this.button2.TabIndex = 32;
            this.button2.Text = ">(&K)";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(1242, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 30);
            this.button1.TabIndex = 31;
            this.button1.Text = "<(&J)";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BorderHgTintingDirection
            // 
            this.BorderHgTintingDirection.BackColor = System.Drawing.Color.Transparent;
            this.BorderHgTintingDirection.BorderColor = System.Drawing.Color.Red;
            this.BorderHgTintingDirection.Location = new System.Drawing.Point(930, 66);
            this.BorderHgTintingDirection.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.BorderHgTintingDirection.Name = "BorderHgTintingDirection";
            this.BorderHgTintingDirection.Size = new System.Drawing.Size(609, 36);
            this.BorderHgTintingDirection.TabIndex = 97;
            // 
            // BorderHgSamplePlates
            // 
            this.BorderHgSamplePlates.BackColor = System.Drawing.Color.Transparent;
            this.BorderHgSamplePlates.BorderColor = System.Drawing.Color.Transparent;
            this.BorderHgSamplePlates.Location = new System.Drawing.Point(1240, 311);
            this.BorderHgSamplePlates.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.BorderHgSamplePlates.Name = "BorderHgSamplePlates";
            this.BorderHgSamplePlates.Size = new System.Drawing.Size(299, 36);
            this.BorderHgSamplePlates.TabIndex = 98;
            // 
            // tabDetail2
            // 
            this.tabDetail2.BackColor = System.Drawing.SystemColors.Control;
            this.tabDetail2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabDetail2.Controls.Add(this.HgUnifiedArticleNumber);
            this.tabDetail2.Controls.Add(this.HgSsShippingDate_2);
            this.tabDetail2.Controls.Add(this.HgNpcVolumeCode);
            this.tabDetail2.Controls.Add(this.HgNpcArticleNumber);
            this.tabDetail2.Controls.Add(this.HgDeliveryAddressKanji);
            this.tabDetail2.Controls.Add(this.HgDeliveryNameKanji);
            this.tabDetail2.Controls.Add(this.HgDeliveryPointCode);
            this.tabDetail2.Controls.Add(this.HgOrderInvoiceId);
            this.tabDetail2.Controls.Add(this.HgDeliveryTelNo);
            this.tabDetail2.Controls.Add(this.HgSalesBranchName);
            this.tabDetail2.Controls.Add(this.HgThemeCode);
            this.tabDetail2.Controls.Add(this.MixingSpeed);
            this.tabDetail2.Controls.Add(this.Overfilling);
            this.tabDetail2.Controls.Add(this.HgSumUpKey);
            this.tabDetail2.Controls.Add(this.MixingTime);
            this.tabDetail2.Controls.Add(this.QualitySample);
            this.tabDetail2.Controls.Add(this.CapType);
            this.tabDetail2.Controls.Add(this.CanType);
            this.tabDetail2.Controls.Add(this.HgComments);
            this.tabDetail2.Controls.Add(this.FormulaRelease);
            this.tabDetail2.Controls.Add(this.PrefillAmount);
            this.tabDetail2.Location = new System.Drawing.Point(4, 22);
            this.tabDetail2.Name = "tabDetail2";
            this.tabDetail2.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetail2.Size = new System.Drawing.Size(1647, 499);
            this.tabDetail2.TabIndex = 1;
            this.tabDetail2.Text = "詳細２";
            // 
            // HgUnifiedArticleNumber
            // 
            this.HgUnifiedArticleNumber.DatabaseColumnName = "HG_Unified_Article_Number";
            this.HgUnifiedArticleNumber.DataControlName = "txtData";
            this.HgUnifiedArticleNumber.DataEnabled = true;
            this.HgUnifiedArticleNumber.DataReadOnly = false;
            this.HgUnifiedArticleNumber.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgUnifiedArticleNumber.DataTextSize = new System.Drawing.Size(139, 30);
            this.HgUnifiedArticleNumber.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgUnifiedArticleNumber.Id = "";
            this.HgUnifiedArticleNumber.Label = "";
            this.HgUnifiedArticleNumber.Location = new System.Drawing.Point(313, 425);
            this.HgUnifiedArticleNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgUnifiedArticleNumber.MaxByteLength = 65535;
            this.HgUnifiedArticleNumber.MaxLength = 0;
            this.HgUnifiedArticleNumber.Name = "HgUnifiedArticleNumber";
            this.HgUnifiedArticleNumber.Size = new System.Drawing.Size(293, 30);
            this.HgUnifiedArticleNumber.TabIndex = 99;
            this.HgUnifiedArticleNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgUnifiedArticleNumber.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgUnifiedArticleNumber.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgUnifiedArticleNumber.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgUnifiedArticleNumber.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgUnifiedArticleNumber.Title = "統合商品コード";
            this.HgUnifiedArticleNumber.TitleControlName = "lblTitle";
            this.HgUnifiedArticleNumber.TitleSize = new System.Drawing.Size(154, 30);
            this.HgUnifiedArticleNumber.Value = "";
            // 
            // HgSsShippingDate_2
            // 
            this.HgSsShippingDate_2.DatabaseColumnName = "HG_SS_Shipping_Date";
            this.HgSsShippingDate_2.DataControlName = "txtData";
            this.HgSsShippingDate_2.DataEnabled = true;
            this.HgSsShippingDate_2.DataReadOnly = false;
            this.HgSsShippingDate_2.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgSsShippingDate_2.DataTextSize = new System.Drawing.Size(139, 30);
            this.HgSsShippingDate_2.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgSsShippingDate_2.Id = "";
            this.HgSsShippingDate_2.Label = "";
            this.HgSsShippingDate_2.Location = new System.Drawing.Point(3, 425);
            this.HgSsShippingDate_2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgSsShippingDate_2.MaxByteLength = 65535;
            this.HgSsShippingDate_2.MaxLength = 0;
            this.HgSsShippingDate_2.Name = "HgSsShippingDate_2";
            this.HgSsShippingDate_2.Size = new System.Drawing.Size(293, 30);
            this.HgSsShippingDate_2.TabIndex = 98;
            this.HgSsShippingDate_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgSsShippingDate_2.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgSsShippingDate_2.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgSsShippingDate_2.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgSsShippingDate_2.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgSsShippingDate_2.Title = "出荷予定日";
            this.HgSsShippingDate_2.TitleControlName = "lblTitle";
            this.HgSsShippingDate_2.TitleSize = new System.Drawing.Size(154, 30);
            this.HgSsShippingDate_2.Value = "";
            // 
            // HgNpcVolumeCode
            // 
            this.HgNpcVolumeCode.DatabaseColumnName = "HG_NPC_Volume_Code";
            this.HgNpcVolumeCode.DataControlName = "txtData";
            this.HgNpcVolumeCode.DataEnabled = true;
            this.HgNpcVolumeCode.DataReadOnly = false;
            this.HgNpcVolumeCode.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgNpcVolumeCode.DataTextSize = new System.Drawing.Size(139, 30);
            this.HgNpcVolumeCode.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgNpcVolumeCode.Id = "";
            this.HgNpcVolumeCode.Label = "";
            this.HgNpcVolumeCode.Location = new System.Drawing.Point(313, 390);
            this.HgNpcVolumeCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgNpcVolumeCode.MaxByteLength = 65535;
            this.HgNpcVolumeCode.MaxLength = 0;
            this.HgNpcVolumeCode.Name = "HgNpcVolumeCode";
            this.HgNpcVolumeCode.Size = new System.Drawing.Size(293, 30);
            this.HgNpcVolumeCode.TabIndex = 97;
            this.HgNpcVolumeCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgNpcVolumeCode.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgNpcVolumeCode.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgNpcVolumeCode.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgNpcVolumeCode.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgNpcVolumeCode.Title = "NP容量";
            this.HgNpcVolumeCode.TitleControlName = "lblTitle";
            this.HgNpcVolumeCode.TitleSize = new System.Drawing.Size(154, 30);
            this.HgNpcVolumeCode.Value = "";
            // 
            // HgNpcArticleNumber
            // 
            this.HgNpcArticleNumber.DatabaseColumnName = "HG_NPC_Article_Number";
            this.HgNpcArticleNumber.DataControlName = "txtData";
            this.HgNpcArticleNumber.DataEnabled = true;
            this.HgNpcArticleNumber.DataReadOnly = false;
            this.HgNpcArticleNumber.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgNpcArticleNumber.DataTextSize = new System.Drawing.Size(139, 30);
            this.HgNpcArticleNumber.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgNpcArticleNumber.Id = "";
            this.HgNpcArticleNumber.Label = "";
            this.HgNpcArticleNumber.Location = new System.Drawing.Point(3, 390);
            this.HgNpcArticleNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgNpcArticleNumber.MaxByteLength = 65535;
            this.HgNpcArticleNumber.MaxLength = 0;
            this.HgNpcArticleNumber.Name = "HgNpcArticleNumber";
            this.HgNpcArticleNumber.Size = new System.Drawing.Size(293, 30);
            this.HgNpcArticleNumber.TabIndex = 96;
            this.HgNpcArticleNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgNpcArticleNumber.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgNpcArticleNumber.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgNpcArticleNumber.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgNpcArticleNumber.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgNpcArticleNumber.Title = "NP商品コード";
            this.HgNpcArticleNumber.TitleControlName = "lblTitle";
            this.HgNpcArticleNumber.TitleSize = new System.Drawing.Size(154, 30);
            this.HgNpcArticleNumber.Value = "";
            // 
            // HgDeliveryAddressKanji
            // 
            this.HgDeliveryAddressKanji.DatabaseColumnName = "HG_Delivery_Address_Kanji";
            this.HgDeliveryAddressKanji.DataControlName = "txtData";
            this.HgDeliveryAddressKanji.DataEnabled = true;
            this.HgDeliveryAddressKanji.DataReadOnly = false;
            this.HgDeliveryAddressKanji.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgDeliveryAddressKanji.DataTextSize = new System.Drawing.Size(1379, 30);
            this.HgDeliveryAddressKanji.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgDeliveryAddressKanji.Id = "";
            this.HgDeliveryAddressKanji.Label = "";
            this.HgDeliveryAddressKanji.Location = new System.Drawing.Point(3, 355);
            this.HgDeliveryAddressKanji.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgDeliveryAddressKanji.MaxByteLength = 65535;
            this.HgDeliveryAddressKanji.MaxLength = 0;
            this.HgDeliveryAddressKanji.Name = "HgDeliveryAddressKanji";
            this.HgDeliveryAddressKanji.Size = new System.Drawing.Size(1533, 30);
            this.HgDeliveryAddressKanji.TabIndex = 95;
            this.HgDeliveryAddressKanji.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgDeliveryAddressKanji.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgDeliveryAddressKanji.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgDeliveryAddressKanji.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgDeliveryAddressKanji.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgDeliveryAddressKanji.Title = "納入先住所";
            this.HgDeliveryAddressKanji.TitleControlName = "lblTitle";
            this.HgDeliveryAddressKanji.TitleSize = new System.Drawing.Size(154, 30);
            this.HgDeliveryAddressKanji.Value = "";
            // 
            // HgDeliveryNameKanji
            // 
            this.HgDeliveryNameKanji.DatabaseColumnName = "HG_Delivery_Name_Kanji";
            this.HgDeliveryNameKanji.DataControlName = "txtData";
            this.HgDeliveryNameKanji.DataEnabled = true;
            this.HgDeliveryNameKanji.DataReadOnly = false;
            this.HgDeliveryNameKanji.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgDeliveryNameKanji.DataTextSize = new System.Drawing.Size(1379, 30);
            this.HgDeliveryNameKanji.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgDeliveryNameKanji.Id = "";
            this.HgDeliveryNameKanji.Label = "";
            this.HgDeliveryNameKanji.Location = new System.Drawing.Point(3, 320);
            this.HgDeliveryNameKanji.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgDeliveryNameKanji.MaxByteLength = 65535;
            this.HgDeliveryNameKanji.MaxLength = 0;
            this.HgDeliveryNameKanji.Name = "HgDeliveryNameKanji";
            this.HgDeliveryNameKanji.Size = new System.Drawing.Size(1533, 30);
            this.HgDeliveryNameKanji.TabIndex = 94;
            this.HgDeliveryNameKanji.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgDeliveryNameKanji.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgDeliveryNameKanji.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgDeliveryNameKanji.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgDeliveryNameKanji.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgDeliveryNameKanji.Title = "納入先名";
            this.HgDeliveryNameKanji.TitleControlName = "lblTitle";
            this.HgDeliveryNameKanji.TitleSize = new System.Drawing.Size(154, 30);
            this.HgDeliveryNameKanji.Value = "";
            // 
            // HgDeliveryPointCode
            // 
            this.HgDeliveryPointCode.DatabaseColumnName = "HG_Delivery_Point_Code";
            this.HgDeliveryPointCode.DataControlName = "txtData";
            this.HgDeliveryPointCode.DataEnabled = true;
            this.HgDeliveryPointCode.DataReadOnly = false;
            this.HgDeliveryPointCode.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgDeliveryPointCode.DataTextSize = new System.Drawing.Size(139, 30);
            this.HgDeliveryPointCode.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgDeliveryPointCode.Id = "";
            this.HgDeliveryPointCode.Label = "";
            this.HgDeliveryPointCode.Location = new System.Drawing.Point(933, 285);
            this.HgDeliveryPointCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgDeliveryPointCode.MaxByteLength = 65535;
            this.HgDeliveryPointCode.MaxLength = 0;
            this.HgDeliveryPointCode.Name = "HgDeliveryPointCode";
            this.HgDeliveryPointCode.Size = new System.Drawing.Size(293, 30);
            this.HgDeliveryPointCode.TabIndex = 93;
            this.HgDeliveryPointCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgDeliveryPointCode.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgDeliveryPointCode.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgDeliveryPointCode.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgDeliveryPointCode.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgDeliveryPointCode.Title = "着地コード";
            this.HgDeliveryPointCode.TitleControlName = "lblTitle";
            this.HgDeliveryPointCode.TitleSize = new System.Drawing.Size(154, 30);
            this.HgDeliveryPointCode.Value = "";
            // 
            // HgOrderInvoiceId
            // 
            this.HgOrderInvoiceId.DatabaseColumnName = "HG_Order_Invoice_ID";
            this.HgOrderInvoiceId.DataControlName = "txtData";
            this.HgOrderInvoiceId.DataEnabled = true;
            this.HgOrderInvoiceId.DataReadOnly = false;
            this.HgOrderInvoiceId.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgOrderInvoiceId.DataTextSize = new System.Drawing.Size(139, 30);
            this.HgOrderInvoiceId.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgOrderInvoiceId.Id = "";
            this.HgOrderInvoiceId.Label = "";
            this.HgOrderInvoiceId.Location = new System.Drawing.Point(623, 285);
            this.HgOrderInvoiceId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgOrderInvoiceId.MaxByteLength = 65535;
            this.HgOrderInvoiceId.MaxLength = 0;
            this.HgOrderInvoiceId.Name = "HgOrderInvoiceId";
            this.HgOrderInvoiceId.Size = new System.Drawing.Size(293, 30);
            this.HgOrderInvoiceId.TabIndex = 92;
            this.HgOrderInvoiceId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgOrderInvoiceId.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgOrderInvoiceId.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgOrderInvoiceId.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgOrderInvoiceId.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgOrderInvoiceId.Title = "伝票区分";
            this.HgOrderInvoiceId.TitleControlName = "lblTitle";
            this.HgOrderInvoiceId.TitleSize = new System.Drawing.Size(154, 30);
            this.HgOrderInvoiceId.Value = "";
            // 
            // HgDeliveryTelNo
            // 
            this.HgDeliveryTelNo.DatabaseColumnName = "HG_Delivery_TelNo";
            this.HgDeliveryTelNo.DataControlName = "txtData";
            this.HgDeliveryTelNo.DataEnabled = true;
            this.HgDeliveryTelNo.DataReadOnly = false;
            this.HgDeliveryTelNo.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgDeliveryTelNo.DataTextSize = new System.Drawing.Size(449, 30);
            this.HgDeliveryTelNo.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgDeliveryTelNo.Id = "";
            this.HgDeliveryTelNo.Label = "";
            this.HgDeliveryTelNo.Location = new System.Drawing.Point(3, 285);
            this.HgDeliveryTelNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgDeliveryTelNo.MaxByteLength = 65535;
            this.HgDeliveryTelNo.MaxLength = 0;
            this.HgDeliveryTelNo.Name = "HgDeliveryTelNo";
            this.HgDeliveryTelNo.Size = new System.Drawing.Size(603, 30);
            this.HgDeliveryTelNo.TabIndex = 91;
            this.HgDeliveryTelNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgDeliveryTelNo.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgDeliveryTelNo.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgDeliveryTelNo.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgDeliveryTelNo.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgDeliveryTelNo.Title = "納入先TEL";
            this.HgDeliveryTelNo.TitleControlName = "lblTitle";
            this.HgDeliveryTelNo.TitleSize = new System.Drawing.Size(154, 30);
            this.HgDeliveryTelNo.Value = "";
            // 
            // HgSalesBranchName
            // 
            this.HgSalesBranchName.DatabaseColumnName = "HG_Sales_Branch_Name";
            this.HgSalesBranchName.DataControlName = "txtData";
            this.HgSalesBranchName.DataEnabled = true;
            this.HgSalesBranchName.DataReadOnly = false;
            this.HgSalesBranchName.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgSalesBranchName.DataTextSize = new System.Drawing.Size(1379, 30);
            this.HgSalesBranchName.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgSalesBranchName.Id = "";
            this.HgSalesBranchName.Label = "";
            this.HgSalesBranchName.Location = new System.Drawing.Point(3, 250);
            this.HgSalesBranchName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgSalesBranchName.MaxByteLength = 65535;
            this.HgSalesBranchName.MaxLength = 0;
            this.HgSalesBranchName.Name = "HgSalesBranchName";
            this.HgSalesBranchName.Size = new System.Drawing.Size(1533, 30);
            this.HgSalesBranchName.TabIndex = 90;
            this.HgSalesBranchName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgSalesBranchName.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgSalesBranchName.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgSalesBranchName.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgSalesBranchName.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgSalesBranchName.Title = "営業所名";
            this.HgSalesBranchName.TitleControlName = "lblTitle";
            this.HgSalesBranchName.TitleSize = new System.Drawing.Size(154, 30);
            this.HgSalesBranchName.Value = "";
            // 
            // HgThemeCode
            // 
            this.HgThemeCode.DatabaseColumnName = "HG_Theme_Code";
            this.HgThemeCode.DataControlName = "txtData";
            this.HgThemeCode.DataEnabled = true;
            this.HgThemeCode.DataReadOnly = false;
            this.HgThemeCode.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgThemeCode.DataTextSize = new System.Drawing.Size(139, 30);
            this.HgThemeCode.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgThemeCode.Id = "";
            this.HgThemeCode.Label = "";
            this.HgThemeCode.Location = new System.Drawing.Point(313, 215);
            this.HgThemeCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgThemeCode.MaxByteLength = 65535;
            this.HgThemeCode.MaxLength = 0;
            this.HgThemeCode.Name = "HgThemeCode";
            this.HgThemeCode.Size = new System.Drawing.Size(293, 30);
            this.HgThemeCode.TabIndex = 89;
            this.HgThemeCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgThemeCode.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgThemeCode.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgThemeCode.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgThemeCode.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgThemeCode.Title = "RF集計区分";
            this.HgThemeCode.TitleControlName = "lblTitle";
            this.HgThemeCode.TitleSize = new System.Drawing.Size(154, 30);
            this.HgThemeCode.Value = "";
            // 
            // MixingSpeed
            // 
            this.MixingSpeed.DatabaseColumnName = "Mixing_Speed";
            this.MixingSpeed.DataControlName = "txtData";
            this.MixingSpeed.DataEnabled = true;
            this.MixingSpeed.DataReadOnly = false;
            this.MixingSpeed.DataTextLocation = new System.Drawing.Point(164, 0);
            this.MixingSpeed.DataTextSize = new System.Drawing.Size(129, 30);
            this.MixingSpeed.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MixingSpeed.Id = "";
            this.MixingSpeed.Label = "";
            this.MixingSpeed.Location = new System.Drawing.Point(313, 180);
            this.MixingSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MixingSpeed.MaxByteLength = 65535;
            this.MixingSpeed.MaxLength = 0;
            this.MixingSpeed.Name = "MixingSpeed";
            this.MixingSpeed.Size = new System.Drawing.Size(293, 30);
            this.MixingSpeed.TabIndex = 88;
            this.MixingSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MixingSpeed.TextBackColor = System.Drawing.SystemColors.Window;
            this.MixingSpeed.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MixingSpeed.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MixingSpeed.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.MixingSpeed.Title = "ﾐｷｼﾝｸﾞｽﾋﾟｰﾄﾞ(回/分)";
            this.MixingSpeed.TitleControlName = "lblTitle";
            this.MixingSpeed.TitleSize = new System.Drawing.Size(164, 30);
            this.MixingSpeed.Value = "";
            // 
            // Overfilling
            // 
            this.Overfilling.DatabaseColumnName = "Overfilling";
            this.Overfilling.DataControlName = "txtData";
            this.Overfilling.DataEnabled = true;
            this.Overfilling.DataReadOnly = false;
            this.Overfilling.DataTextLocation = new System.Drawing.Point(154, 0);
            this.Overfilling.DataTextSize = new System.Drawing.Size(139, 30);
            this.Overfilling.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Overfilling.Id = "";
            this.Overfilling.Label = "";
            this.Overfilling.Location = new System.Drawing.Point(313, 145);
            this.Overfilling.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Overfilling.MaxByteLength = 65535;
            this.Overfilling.MaxLength = 0;
            this.Overfilling.Name = "Overfilling";
            this.Overfilling.Size = new System.Drawing.Size(293, 30);
            this.Overfilling.TabIndex = 87;
            this.Overfilling.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Overfilling.TextBackColor = System.Drawing.SystemColors.Window;
            this.Overfilling.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Overfilling.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Overfilling.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.Overfilling.Title = "超過[%]";
            this.Overfilling.TitleControlName = "lblTitle";
            this.Overfilling.TitleSize = new System.Drawing.Size(154, 30);
            this.Overfilling.Value = "";
            // 
            // HgSumUpKey
            // 
            this.HgSumUpKey.DatabaseColumnName = "HG_Sum_up_Key";
            this.HgSumUpKey.DataControlName = "txtData";
            this.HgSumUpKey.DataEnabled = true;
            this.HgSumUpKey.DataReadOnly = false;
            this.HgSumUpKey.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgSumUpKey.DataTextSize = new System.Drawing.Size(139, 30);
            this.HgSumUpKey.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgSumUpKey.Id = "";
            this.HgSumUpKey.Label = "";
            this.HgSumUpKey.Location = new System.Drawing.Point(3, 215);
            this.HgSumUpKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgSumUpKey.MaxByteLength = 65535;
            this.HgSumUpKey.MaxLength = 0;
            this.HgSumUpKey.Name = "HgSumUpKey";
            this.HgSumUpKey.Size = new System.Drawing.Size(293, 30);
            this.HgSumUpKey.TabIndex = 86;
            this.HgSumUpKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgSumUpKey.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgSumUpKey.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgSumUpKey.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgSumUpKey.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgSumUpKey.Title = "順位コード";
            this.HgSumUpKey.TitleControlName = "lblTitle";
            this.HgSumUpKey.TitleSize = new System.Drawing.Size(154, 30);
            this.HgSumUpKey.Value = "";
            // 
            // MixingTime
            // 
            this.MixingTime.DatabaseColumnName = "Mixing_Time";
            this.MixingTime.DataControlName = "txtData";
            this.MixingTime.DataEnabled = true;
            this.MixingTime.DataReadOnly = false;
            this.MixingTime.DataTextLocation = new System.Drawing.Point(154, 0);
            this.MixingTime.DataTextSize = new System.Drawing.Size(139, 30);
            this.MixingTime.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MixingTime.Id = "";
            this.MixingTime.Label = "";
            this.MixingTime.Location = new System.Drawing.Point(3, 180);
            this.MixingTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MixingTime.MaxByteLength = 65535;
            this.MixingTime.MaxLength = 0;
            this.MixingTime.Name = "MixingTime";
            this.MixingTime.Size = new System.Drawing.Size(293, 30);
            this.MixingTime.TabIndex = 85;
            this.MixingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MixingTime.TextBackColor = System.Drawing.SystemColors.Window;
            this.MixingTime.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MixingTime.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MixingTime.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.MixingTime.Title = "ﾐｼｷﾝｸﾞﾀｲﾑ[s]";
            this.MixingTime.TitleControlName = "lblTitle";
            this.MixingTime.TitleSize = new System.Drawing.Size(154, 30);
            this.MixingTime.Value = "";
            // 
            // QualitySample
            // 
            this.QualitySample.DatabaseColumnName = "Quality_Sample";
            this.QualitySample.DataControlName = "txtData";
            this.QualitySample.DataEnabled = true;
            this.QualitySample.DataReadOnly = false;
            this.QualitySample.DataTextLocation = new System.Drawing.Point(154, 0);
            this.QualitySample.DataTextSize = new System.Drawing.Size(139, 30);
            this.QualitySample.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.QualitySample.Id = "";
            this.QualitySample.Label = "";
            this.QualitySample.Location = new System.Drawing.Point(3, 145);
            this.QualitySample.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QualitySample.MaxByteLength = 65535;
            this.QualitySample.MaxLength = 0;
            this.QualitySample.Name = "QualitySample";
            this.QualitySample.Size = new System.Drawing.Size(293, 30);
            this.QualitySample.TabIndex = 84;
            this.QualitySample.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.QualitySample.TextBackColor = System.Drawing.SystemColors.Window;
            this.QualitySample.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.QualitySample.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.QualitySample.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.QualitySample.Title = "ｸｵﾘﾃｨｻﾝﾌﾟﾙ[g]";
            this.QualitySample.TitleControlName = "lblTitle";
            this.QualitySample.TitleSize = new System.Drawing.Size(154, 30);
            this.QualitySample.Value = "";
            // 
            // CapType
            // 
            this.CapType.CodeControlName = "txtCode";
            this.CapType.CodeReadOnly = false;
            this.CapType.CodeText = "";
            this.CapType.CodeTextSize = new System.Drawing.Size(80, 30);
            this.CapType.DatabaseColumnCode = "";
            this.CapType.DatabaseColumnName = "";
            this.CapType.DataControlName = "txtData";
            this.CapType.DataReadOnly = false;
            this.CapType.DataTextSize = new System.Drawing.Size(1379, 30);
            this.CapType.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CapType.Location = new System.Drawing.Point(3, 110);
            this.CapType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CapType.Name = "CapType";
            this.CapType.Size = new System.Drawing.Size(1533, 30);
            this.CapType.TabIndex = 83;
            this.CapType.TextAlignCode = System.Windows.Forms.HorizontalAlignment.Left;
            this.CapType.TextAlignData = System.Windows.Forms.HorizontalAlignment.Left;
            this.CapType.TextBackColor = System.Drawing.SystemColors.Window;
            this.CapType.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.CapType.Title = "キャップタイプ";
            this.CapType.TitleControlName = "lblTitle";
            this.CapType.TitleSize = new System.Drawing.Size(154, 30);
            // 
            // CanType
            // 
            this.CanType.CodeControlName = "txtCode";
            this.CanType.CodeReadOnly = false;
            this.CanType.CodeText = "";
            this.CanType.CodeTextSize = new System.Drawing.Size(80, 30);
            this.CanType.DatabaseColumnCode = "";
            this.CanType.DatabaseColumnName = "";
            this.CanType.DataControlName = "txtData";
            this.CanType.DataReadOnly = false;
            this.CanType.DataTextSize = new System.Drawing.Size(1379, 30);
            this.CanType.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CanType.Location = new System.Drawing.Point(3, 75);
            this.CanType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CanType.Name = "CanType";
            this.CanType.Size = new System.Drawing.Size(1533, 30);
            this.CanType.TabIndex = 82;
            this.CanType.TextAlignCode = System.Windows.Forms.HorizontalAlignment.Left;
            this.CanType.TextAlignData = System.Windows.Forms.HorizontalAlignment.Left;
            this.CanType.TextBackColor = System.Drawing.SystemColors.Window;
            this.CanType.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.CanType.Title = "缶タイプ";
            this.CanType.TitleControlName = "lblTitle";
            this.CanType.TitleSize = new System.Drawing.Size(154, 30);
            // 
            // HgComments
            // 
            this.HgComments.DatabaseColumnName = "HG_Comments";
            this.HgComments.DataControlName = "txtData";
            this.HgComments.DataEnabled = true;
            this.HgComments.DataReadOnly = false;
            this.HgComments.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgComments.DataTextSize = new System.Drawing.Size(1379, 30);
            this.HgComments.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgComments.Id = "";
            this.HgComments.Label = "";
            this.HgComments.Location = new System.Drawing.Point(3, 40);
            this.HgComments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgComments.MaxByteLength = 65535;
            this.HgComments.MaxLength = 0;
            this.HgComments.Name = "HgComments";
            this.HgComments.Size = new System.Drawing.Size(1533, 30);
            this.HgComments.TabIndex = 80;
            this.HgComments.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgComments.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgComments.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgComments.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgComments.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgComments.Title = "HG概要";
            this.HgComments.TitleControlName = "lblTitle";
            this.HgComments.TitleSize = new System.Drawing.Size(154, 30);
            this.HgComments.Value = "";
            // 
            // FormulaRelease
            // 
            this.FormulaRelease.DatabaseColumnName = "Formula_Release";
            this.FormulaRelease.DataControlName = "txtData";
            this.FormulaRelease.DataEnabled = true;
            this.FormulaRelease.DataReadOnly = false;
            this.FormulaRelease.DataTextLocation = new System.Drawing.Point(154, 0);
            this.FormulaRelease.DataTextSize = new System.Drawing.Size(139, 30);
            this.FormulaRelease.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormulaRelease.Id = "";
            this.FormulaRelease.Label = "";
            this.FormulaRelease.Location = new System.Drawing.Point(313, 5);
            this.FormulaRelease.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FormulaRelease.MaxByteLength = 65535;
            this.FormulaRelease.MaxLength = 0;
            this.FormulaRelease.Name = "FormulaRelease";
            this.FormulaRelease.Size = new System.Drawing.Size(293, 30);
            this.FormulaRelease.TabIndex = 79;
            this.FormulaRelease.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FormulaRelease.TextBackColor = System.Drawing.SystemColors.Window;
            this.FormulaRelease.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FormulaRelease.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormulaRelease.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.FormulaRelease.Title = "最終配合リリース";
            this.FormulaRelease.TitleControlName = "lblTitle";
            this.FormulaRelease.TitleSize = new System.Drawing.Size(154, 30);
            this.FormulaRelease.Value = "";
            // 
            // PrefillAmount
            // 
            this.PrefillAmount.DatabaseColumnName = "Prefill_Amount";
            this.PrefillAmount.DataControlName = "txtData";
            this.PrefillAmount.DataEnabled = true;
            this.PrefillAmount.DataReadOnly = false;
            this.PrefillAmount.DataTextLocation = new System.Drawing.Point(154, 0);
            this.PrefillAmount.DataTextSize = new System.Drawing.Size(139, 30);
            this.PrefillAmount.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PrefillAmount.Id = "";
            this.PrefillAmount.Label = "";
            this.PrefillAmount.Location = new System.Drawing.Point(3, 5);
            this.PrefillAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PrefillAmount.MaxByteLength = 65535;
            this.PrefillAmount.MaxLength = 0;
            this.PrefillAmount.Name = "PrefillAmount";
            this.PrefillAmount.Size = new System.Drawing.Size(293, 30);
            this.PrefillAmount.TabIndex = 78;
            this.PrefillAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PrefillAmount.TextBackColor = System.Drawing.SystemColors.Window;
            this.PrefillAmount.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PrefillAmount.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PrefillAmount.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.PrefillAmount.Title = "重量";
            this.PrefillAmount.TitleControlName = "lblTitle";
            this.PrefillAmount.TitleSize = new System.Drawing.Size(154, 30);
            this.PrefillAmount.Value = "";
            // 
            // tabDetail3
            // 
            this.tabDetail3.BackColor = System.Drawing.SystemColors.Control;
            this.tabDetail3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabDetail3.Controls.Add(this.HgRfDisplayColors);
            this.tabDetail3.Controls.Add(this.HgTruckCompanyName_3);
            this.tabDetail3.Controls.Add(this.HgAskId);
            this.tabDetail3.Controls.Add(this.labelTextBox68);
            this.tabDetail3.Controls.Add(this.HgSsDeliveryKanji);
            this.tabDetail3.Controls.Add(this.HgSsDeliveryCode);
            this.tabDetail3.Controls.Add(this.HgDeliveryAreaCode);
            this.tabDetail3.Controls.Add(this.HgCustomerName);
            this.tabDetail3.Controls.Add(this.HgPaintKindCode);
            this.tabDetail3.Controls.Add(this.HgCancel);
            this.tabDetail3.Controls.Add(this.HgWaterBorne);
            this.tabDetail3.Controls.Add(this.HgSsCode);
            this.tabDetail3.Controls.Add(this.HgAdditionalNo2);
            this.tabDetail3.Controls.Add(this.HgAdditionalNo1);
            this.tabDetail3.Controls.Add(this.HgLineNumber);
            this.tabDetail3.Location = new System.Drawing.Point(4, 22);
            this.tabDetail3.Name = "tabDetail3";
            this.tabDetail3.Size = new System.Drawing.Size(1647, 499);
            this.tabDetail3.TabIndex = 2;
            this.tabDetail3.Text = "詳細３";
            // 
            // HgRfDisplayColors
            // 
            this.HgRfDisplayColors.DatabaseColumnName = "HG_RF_Display_Colors";
            this.HgRfDisplayColors.DataControlName = "txtData";
            this.HgRfDisplayColors.DataEnabled = true;
            this.HgRfDisplayColors.DataReadOnly = false;
            this.HgRfDisplayColors.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgRfDisplayColors.DataTextSize = new System.Drawing.Size(139, 30);
            this.HgRfDisplayColors.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgRfDisplayColors.Id = "";
            this.HgRfDisplayColors.Label = "";
            this.HgRfDisplayColors.Location = new System.Drawing.Point(3, 425);
            this.HgRfDisplayColors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgRfDisplayColors.MaxByteLength = 65535;
            this.HgRfDisplayColors.MaxLength = 0;
            this.HgRfDisplayColors.Name = "HgRfDisplayColors";
            this.HgRfDisplayColors.Size = new System.Drawing.Size(293, 30);
            this.HgRfDisplayColors.TabIndex = 44;
            this.HgRfDisplayColors.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgRfDisplayColors.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgRfDisplayColors.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgRfDisplayColors.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgRfDisplayColors.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgRfDisplayColors.Title = "ＲＦ表示色";
            this.HgRfDisplayColors.TitleControlName = "lblTitle";
            this.HgRfDisplayColors.TitleSize = new System.Drawing.Size(154, 30);
            this.HgRfDisplayColors.Value = "";
            // 
            // HgTruckCompanyName_3
            // 
            this.HgTruckCompanyName_3.DatabaseColumnName = "HG_Truck_Company_Name";
            this.HgTruckCompanyName_3.DataControlName = "txtData";
            this.HgTruckCompanyName_3.DataEnabled = true;
            this.HgTruckCompanyName_3.DataReadOnly = false;
            this.HgTruckCompanyName_3.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgTruckCompanyName_3.DataTextSize = new System.Drawing.Size(1379, 30);
            this.HgTruckCompanyName_3.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgTruckCompanyName_3.Id = "";
            this.HgTruckCompanyName_3.Label = "";
            this.HgTruckCompanyName_3.Location = new System.Drawing.Point(3, 390);
            this.HgTruckCompanyName_3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgTruckCompanyName_3.MaxByteLength = 65535;
            this.HgTruckCompanyName_3.MaxLength = 0;
            this.HgTruckCompanyName_3.Name = "HgTruckCompanyName_3";
            this.HgTruckCompanyName_3.Size = new System.Drawing.Size(1533, 30);
            this.HgTruckCompanyName_3.TabIndex = 43;
            this.HgTruckCompanyName_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgTruckCompanyName_3.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgTruckCompanyName_3.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgTruckCompanyName_3.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgTruckCompanyName_3.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgTruckCompanyName_3.Title = "配送業者名";
            this.HgTruckCompanyName_3.TitleControlName = "lblTitle";
            this.HgTruckCompanyName_3.TitleSize = new System.Drawing.Size(154, 30);
            this.HgTruckCompanyName_3.Value = "";
            // 
            // HgAskId
            // 
            this.HgAskId.DatabaseColumnName = "HG_ASK_ID";
            this.HgAskId.DataControlName = "txtData";
            this.HgAskId.DataEnabled = true;
            this.HgAskId.DataReadOnly = false;
            this.HgAskId.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgAskId.DataTextSize = new System.Drawing.Size(139, 30);
            this.HgAskId.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgAskId.Id = "";
            this.HgAskId.Label = "";
            this.HgAskId.Location = new System.Drawing.Point(3, 355);
            this.HgAskId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgAskId.MaxByteLength = 65535;
            this.HgAskId.MaxLength = 0;
            this.HgAskId.Name = "HgAskId";
            this.HgAskId.Size = new System.Drawing.Size(293, 30);
            this.HgAskId.TabIndex = 42;
            this.HgAskId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgAskId.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgAskId.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgAskId.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgAskId.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgAskId.Title = "ＡＳＫ－ＩＤ";
            this.HgAskId.TitleControlName = "lblTitle";
            this.HgAskId.TitleSize = new System.Drawing.Size(154, 30);
            this.HgAskId.Value = "";
            // 
            // labelTextBox68
            // 
            this.labelTextBox68.DatabaseColumnName = null;
            this.labelTextBox68.DataControlName = "txtData";
            this.labelTextBox68.DataEnabled = true;
            this.labelTextBox68.DataReadOnly = false;
            this.labelTextBox68.DataTextLocation = new System.Drawing.Point(154, 0);
            this.labelTextBox68.DataTextSize = new System.Drawing.Size(139, 30);
            this.labelTextBox68.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox68.Id = "";
            this.labelTextBox68.Label = "";
            this.labelTextBox68.Location = new System.Drawing.Point(3, 320);
            this.labelTextBox68.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelTextBox68.MaxByteLength = 65535;
            this.labelTextBox68.MaxLength = 0;
            this.labelTextBox68.Name = "labelTextBox68";
            this.labelTextBox68.Size = new System.Drawing.Size(293, 30);
            this.labelTextBox68.TabIndex = 41;
            this.labelTextBox68.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelTextBox68.TextBackColor = System.Drawing.SystemColors.Window;
            this.labelTextBox68.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTextBox68.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox68.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTextBox68.Title = "運送区分（ラベル）";
            this.labelTextBox68.TitleControlName = "lblTitle";
            this.labelTextBox68.TitleSize = new System.Drawing.Size(154, 30);
            this.labelTextBox68.Value = "";
            // 
            // HgSsDeliveryKanji
            // 
            this.HgSsDeliveryKanji.DatabaseColumnName = "HG_SS_Delivery_Kanji";
            this.HgSsDeliveryKanji.DataControlName = "txtData";
            this.HgSsDeliveryKanji.DataEnabled = true;
            this.HgSsDeliveryKanji.DataReadOnly = false;
            this.HgSsDeliveryKanji.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgSsDeliveryKanji.DataTextSize = new System.Drawing.Size(1379, 30);
            this.HgSsDeliveryKanji.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgSsDeliveryKanji.Id = "";
            this.HgSsDeliveryKanji.Label = "";
            this.HgSsDeliveryKanji.Location = new System.Drawing.Point(3, 285);
            this.HgSsDeliveryKanji.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgSsDeliveryKanji.MaxByteLength = 65535;
            this.HgSsDeliveryKanji.MaxLength = 0;
            this.HgSsDeliveryKanji.Name = "HgSsDeliveryKanji";
            this.HgSsDeliveryKanji.Size = new System.Drawing.Size(1533, 30);
            this.HgSsDeliveryKanji.TabIndex = 40;
            this.HgSsDeliveryKanji.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgSsDeliveryKanji.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgSsDeliveryKanji.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgSsDeliveryKanji.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgSsDeliveryKanji.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgSsDeliveryKanji.Title = "SS運送区分名";
            this.HgSsDeliveryKanji.TitleControlName = "lblTitle";
            this.HgSsDeliveryKanji.TitleSize = new System.Drawing.Size(154, 30);
            this.HgSsDeliveryKanji.Value = "";
            // 
            // HgSsDeliveryCode
            // 
            this.HgSsDeliveryCode.DatabaseColumnName = "HG_SS_Delivery_Code";
            this.HgSsDeliveryCode.DataControlName = "txtData";
            this.HgSsDeliveryCode.DataEnabled = true;
            this.HgSsDeliveryCode.DataReadOnly = false;
            this.HgSsDeliveryCode.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgSsDeliveryCode.DataTextSize = new System.Drawing.Size(139, 30);
            this.HgSsDeliveryCode.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgSsDeliveryCode.Id = "";
            this.HgSsDeliveryCode.Label = "";
            this.HgSsDeliveryCode.Location = new System.Drawing.Point(3, 250);
            this.HgSsDeliveryCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgSsDeliveryCode.MaxByteLength = 65535;
            this.HgSsDeliveryCode.MaxLength = 0;
            this.HgSsDeliveryCode.Name = "HgSsDeliveryCode";
            this.HgSsDeliveryCode.Size = new System.Drawing.Size(293, 30);
            this.HgSsDeliveryCode.TabIndex = 39;
            this.HgSsDeliveryCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgSsDeliveryCode.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgSsDeliveryCode.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgSsDeliveryCode.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgSsDeliveryCode.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgSsDeliveryCode.Title = "自動倉入区分";
            this.HgSsDeliveryCode.TitleControlName = "lblTitle";
            this.HgSsDeliveryCode.TitleSize = new System.Drawing.Size(154, 30);
            this.HgSsDeliveryCode.Value = "";
            // 
            // HgDeliveryAreaCode
            // 
            this.HgDeliveryAreaCode.DatabaseColumnName = "HG_Delivery_Area_Code";
            this.HgDeliveryAreaCode.DataControlName = "txtData";
            this.HgDeliveryAreaCode.DataEnabled = true;
            this.HgDeliveryAreaCode.DataReadOnly = false;
            this.HgDeliveryAreaCode.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgDeliveryAreaCode.DataTextSize = new System.Drawing.Size(139, 30);
            this.HgDeliveryAreaCode.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgDeliveryAreaCode.Id = "";
            this.HgDeliveryAreaCode.Label = "";
            this.HgDeliveryAreaCode.Location = new System.Drawing.Point(3, 215);
            this.HgDeliveryAreaCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgDeliveryAreaCode.MaxByteLength = 65535;
            this.HgDeliveryAreaCode.MaxLength = 0;
            this.HgDeliveryAreaCode.Name = "HgDeliveryAreaCode";
            this.HgDeliveryAreaCode.Size = new System.Drawing.Size(293, 30);
            this.HgDeliveryAreaCode.TabIndex = 38;
            this.HgDeliveryAreaCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgDeliveryAreaCode.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgDeliveryAreaCode.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgDeliveryAreaCode.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgDeliveryAreaCode.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgDeliveryAreaCode.Title = "エリア区分";
            this.HgDeliveryAreaCode.TitleControlName = "lblTitle";
            this.HgDeliveryAreaCode.TitleSize = new System.Drawing.Size(154, 30);
            this.HgDeliveryAreaCode.Value = "";
            // 
            // HgCustomerName
            // 
            this.HgCustomerName.DatabaseColumnName = "HG_Customer_Name";
            this.HgCustomerName.DataControlName = "txtData";
            this.HgCustomerName.DataEnabled = true;
            this.HgCustomerName.DataReadOnly = false;
            this.HgCustomerName.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgCustomerName.DataTextSize = new System.Drawing.Size(1379, 30);
            this.HgCustomerName.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgCustomerName.Id = "";
            this.HgCustomerName.Label = "";
            this.HgCustomerName.Location = new System.Drawing.Point(3, 180);
            this.HgCustomerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgCustomerName.MaxByteLength = 65535;
            this.HgCustomerName.MaxLength = 0;
            this.HgCustomerName.Name = "HgCustomerName";
            this.HgCustomerName.Size = new System.Drawing.Size(1533, 30);
            this.HgCustomerName.TabIndex = 37;
            this.HgCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgCustomerName.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgCustomerName.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgCustomerName.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgCustomerName.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgCustomerName.Title = "得意先名";
            this.HgCustomerName.TitleControlName = "lblTitle";
            this.HgCustomerName.TitleSize = new System.Drawing.Size(154, 30);
            this.HgCustomerName.Value = "";
            // 
            // HgPaintKindCode
            // 
            this.HgPaintKindCode.DatabaseColumnName = "HG_Paint_Kind_Code";
            this.HgPaintKindCode.DataControlName = "txtData";
            this.HgPaintKindCode.DataEnabled = true;
            this.HgPaintKindCode.DataReadOnly = false;
            this.HgPaintKindCode.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgPaintKindCode.DataTextSize = new System.Drawing.Size(139, 30);
            this.HgPaintKindCode.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgPaintKindCode.Id = "";
            this.HgPaintKindCode.Label = "";
            this.HgPaintKindCode.Location = new System.Drawing.Point(3, 145);
            this.HgPaintKindCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgPaintKindCode.MaxByteLength = 65535;
            this.HgPaintKindCode.MaxLength = 0;
            this.HgPaintKindCode.Name = "HgPaintKindCode";
            this.HgPaintKindCode.Size = new System.Drawing.Size(293, 30);
            this.HgPaintKindCode.TabIndex = 36;
            this.HgPaintKindCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgPaintKindCode.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgPaintKindCode.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgPaintKindCode.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgPaintKindCode.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgPaintKindCode.Title = "分類";
            this.HgPaintKindCode.TitleControlName = "lblTitle";
            this.HgPaintKindCode.TitleSize = new System.Drawing.Size(154, 30);
            this.HgPaintKindCode.Value = "";
            // 
            // HgCancel
            // 
            this.HgCancel.DatabaseColumnName = "HG_Cancel";
            this.HgCancel.DataControlName = "txtData";
            this.HgCancel.DataEnabled = true;
            this.HgCancel.DataReadOnly = false;
            this.HgCancel.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgCancel.DataTextSize = new System.Drawing.Size(139, 30);
            this.HgCancel.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgCancel.Id = "";
            this.HgCancel.Label = "";
            this.HgCancel.Location = new System.Drawing.Point(3, 110);
            this.HgCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgCancel.MaxByteLength = 65535;
            this.HgCancel.MaxLength = 0;
            this.HgCancel.Name = "HgCancel";
            this.HgCancel.Size = new System.Drawing.Size(293, 30);
            this.HgCancel.TabIndex = 35;
            this.HgCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgCancel.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgCancel.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgCancel.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgCancel.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgCancel.Title = "キャンセル";
            this.HgCancel.TitleControlName = "lblTitle";
            this.HgCancel.TitleSize = new System.Drawing.Size(154, 30);
            this.HgCancel.Value = "";
            // 
            // HgWaterBorne
            // 
            this.HgWaterBorne.DatabaseColumnName = "HG_Water_Borne";
            this.HgWaterBorne.DataControlName = "txtData";
            this.HgWaterBorne.DataEnabled = true;
            this.HgWaterBorne.DataReadOnly = false;
            this.HgWaterBorne.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgWaterBorne.DataTextSize = new System.Drawing.Size(139, 30);
            this.HgWaterBorne.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgWaterBorne.Id = "";
            this.HgWaterBorne.Label = "";
            this.HgWaterBorne.Location = new System.Drawing.Point(3, 75);
            this.HgWaterBorne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgWaterBorne.MaxByteLength = 65535;
            this.HgWaterBorne.MaxLength = 0;
            this.HgWaterBorne.Name = "HgWaterBorne";
            this.HgWaterBorne.Size = new System.Drawing.Size(293, 30);
            this.HgWaterBorne.TabIndex = 34;
            this.HgWaterBorne.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgWaterBorne.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgWaterBorne.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgWaterBorne.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgWaterBorne.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgWaterBorne.Title = "水性溶剤区分";
            this.HgWaterBorne.TitleControlName = "lblTitle";
            this.HgWaterBorne.TitleSize = new System.Drawing.Size(154, 30);
            this.HgWaterBorne.Value = "";
            // 
            // HgSsCode
            // 
            this.HgSsCode.DatabaseColumnName = "HG_SS_Code";
            this.HgSsCode.DataControlName = "txtData";
            this.HgSsCode.DataEnabled = true;
            this.HgSsCode.DataReadOnly = false;
            this.HgSsCode.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgSsCode.DataTextSize = new System.Drawing.Size(139, 30);
            this.HgSsCode.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgSsCode.Id = "";
            this.HgSsCode.Label = "";
            this.HgSsCode.Location = new System.Drawing.Point(3, 40);
            this.HgSsCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgSsCode.MaxByteLength = 65535;
            this.HgSsCode.MaxLength = 0;
            this.HgSsCode.Name = "HgSsCode";
            this.HgSsCode.Size = new System.Drawing.Size(293, 30);
            this.HgSsCode.TabIndex = 33;
            this.HgSsCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgSsCode.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgSsCode.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgSsCode.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgSsCode.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgSsCode.Title = "SSコード";
            this.HgSsCode.TitleControlName = "lblTitle";
            this.HgSsCode.TitleSize = new System.Drawing.Size(154, 30);
            this.HgSsCode.Value = "";
            // 
            // HgAdditionalNo2
            // 
            this.HgAdditionalNo2.DatabaseColumnName = "HG_Additional_No2";
            this.HgAdditionalNo2.DataControlName = "txtData";
            this.HgAdditionalNo2.DataEnabled = true;
            this.HgAdditionalNo2.DataReadOnly = false;
            this.HgAdditionalNo2.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgAdditionalNo2.DataTextSize = new System.Drawing.Size(139, 30);
            this.HgAdditionalNo2.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgAdditionalNo2.Id = "";
            this.HgAdditionalNo2.Label = "";
            this.HgAdditionalNo2.Location = new System.Drawing.Point(623, 5);
            this.HgAdditionalNo2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgAdditionalNo2.MaxByteLength = 65535;
            this.HgAdditionalNo2.MaxLength = 0;
            this.HgAdditionalNo2.Name = "HgAdditionalNo2";
            this.HgAdditionalNo2.Size = new System.Drawing.Size(293, 30);
            this.HgAdditionalNo2.TabIndex = 32;
            this.HgAdditionalNo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgAdditionalNo2.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgAdditionalNo2.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgAdditionalNo2.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgAdditionalNo2.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgAdditionalNo2.Title = "分割回答No.2";
            this.HgAdditionalNo2.TitleControlName = "lblTitle";
            this.HgAdditionalNo2.TitleSize = new System.Drawing.Size(154, 30);
            this.HgAdditionalNo2.Value = "";
            // 
            // HgAdditionalNo1
            // 
            this.HgAdditionalNo1.DatabaseColumnName = "HG_Additional_No1";
            this.HgAdditionalNo1.DataControlName = "txtData";
            this.HgAdditionalNo1.DataEnabled = true;
            this.HgAdditionalNo1.DataReadOnly = false;
            this.HgAdditionalNo1.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgAdditionalNo1.DataTextSize = new System.Drawing.Size(139, 30);
            this.HgAdditionalNo1.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgAdditionalNo1.Id = "";
            this.HgAdditionalNo1.Label = "";
            this.HgAdditionalNo1.Location = new System.Drawing.Point(313, 5);
            this.HgAdditionalNo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgAdditionalNo1.MaxByteLength = 65535;
            this.HgAdditionalNo1.MaxLength = 0;
            this.HgAdditionalNo1.Name = "HgAdditionalNo1";
            this.HgAdditionalNo1.Size = new System.Drawing.Size(293, 30);
            this.HgAdditionalNo1.TabIndex = 31;
            this.HgAdditionalNo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgAdditionalNo1.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgAdditionalNo1.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgAdditionalNo1.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgAdditionalNo1.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgAdditionalNo1.Title = "分割回答No.1";
            this.HgAdditionalNo1.TitleControlName = "lblTitle";
            this.HgAdditionalNo1.TitleSize = new System.Drawing.Size(154, 30);
            this.HgAdditionalNo1.Value = "";
            // 
            // HgLineNumber
            // 
            this.HgLineNumber.DatabaseColumnName = "HG_Line_Number";
            this.HgLineNumber.DataControlName = "txtData";
            this.HgLineNumber.DataEnabled = true;
            this.HgLineNumber.DataReadOnly = false;
            this.HgLineNumber.DataTextLocation = new System.Drawing.Point(154, 0);
            this.HgLineNumber.DataTextSize = new System.Drawing.Size(139, 30);
            this.HgLineNumber.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgLineNumber.Id = "";
            this.HgLineNumber.Label = "";
            this.HgLineNumber.Location = new System.Drawing.Point(3, 5);
            this.HgLineNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HgLineNumber.MaxByteLength = 65535;
            this.HgLineNumber.MaxLength = 0;
            this.HgLineNumber.Name = "HgLineNumber";
            this.HgLineNumber.Size = new System.Drawing.Size(293, 30);
            this.HgLineNumber.TabIndex = 30;
            this.HgLineNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HgLineNumber.TextBackColor = System.Drawing.SystemColors.Window;
            this.HgLineNumber.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HgLineNumber.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HgLineNumber.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.HgLineNumber.Title = "行番号";
            this.HgLineNumber.TitleControlName = "lblTitle";
            this.HgLineNumber.TitleSize = new System.Drawing.Size(154, 30);
            this.HgLineNumber.Value = "";
            // 
            // tabFormulation
            // 
            this.tabFormulation.BackColor = System.Drawing.SystemColors.Control;
            this.tabFormulation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabFormulation.Controls.Add(this.splitFormulation);
            this.tabFormulation.Location = new System.Drawing.Point(4, 29);
            this.tabFormulation.Name = "tabFormulation";
            this.tabFormulation.Size = new System.Drawing.Size(1663, 932);
            this.tabFormulation.TabIndex = 2;
            this.tabFormulation.Text = "配合";
            // 
            // splitFormulation
            // 
            this.splitFormulation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitFormulation.Location = new System.Drawing.Point(0, 0);
            this.splitFormulation.Name = "splitFormulation";
            this.splitFormulation.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitFormulation.Panel1
            // 
            this.splitFormulation.Panel1.Controls.Add(this.GvFormulation);
            // 
            // splitFormulation.Panel2
            // 
            this.splitFormulation.Panel2.Controls.Add(this.pnlFormulation);
            this.splitFormulation.Size = new System.Drawing.Size(1661, 930);
            this.splitFormulation.SplitterDistance = 360;
            this.splitFormulation.SplitterWidth = 3;
            this.splitFormulation.TabIndex = 0;
            // 
            // GvFormulation
            // 
            this.GvFormulation.AllowUserToAddRows = false;
            this.GvFormulation.AllowUserToDeleteRows = false;
            this.GvFormulation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvFormulation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GvFormulation.Location = new System.Drawing.Point(0, 0);
            this.GvFormulation.Name = "GvFormulation";
            this.GvFormulation.ReadOnly = true;
            this.GvFormulation.RowTemplate.Height = 21;
            this.GvFormulation.Size = new System.Drawing.Size(1661, 360);
            this.GvFormulation.TabIndex = 0;
            // 
            // pnlFormulation
            // 
            this.pnlFormulation.BackColor = System.Drawing.Color.Black;
            this.pnlFormulation.Controls.Add(this.labelTextBox79);
            this.pnlFormulation.Controls.Add(this.labelTextBox78);
            this.pnlFormulation.Controls.Add(this.labelTextBox77);
            this.pnlFormulation.Controls.Add(this.labelTextBox76);
            this.pnlFormulation.Controls.Add(this.labelTextBox75);
            this.pnlFormulation.Controls.Add(this.labelTextBox74);
            this.pnlFormulation.Controls.Add(this.labelTextBox73);
            this.pnlFormulation.Controls.Add(this.labelTextBox62);
            this.pnlFormulation.Controls.Add(this.labelTextBox61);
            this.pnlFormulation.Controls.Add(this.labelTextBox60);
            this.pnlFormulation.Controls.Add(this.labelTextBox59);
            this.pnlFormulation.Controls.Add(this.labelTextBox58);
            this.pnlFormulation.Controls.Add(this.labelTextBox57);
            this.pnlFormulation.Controls.Add(this.labelTextBox56);
            this.pnlFormulation.Controls.Add(this.labelTextBox55);
            this.pnlFormulation.Controls.Add(this.labelTextBox54);
            this.pnlFormulation.Controls.Add(this.labelTextBox53);
            this.pnlFormulation.Controls.Add(this.labelTextBox52);
            this.pnlFormulation.Controls.Add(this.labelTextBox51);
            this.pnlFormulation.Controls.Add(this.GvWeight);
            this.pnlFormulation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormulation.Location = new System.Drawing.Point(0, 0);
            this.pnlFormulation.Name = "pnlFormulation";
            this.pnlFormulation.Size = new System.Drawing.Size(1661, 567);
            this.pnlFormulation.TabIndex = 0;
            // 
            // labelTextBox79
            // 
            this.labelTextBox79.DatabaseColumnName = "Formula_Release";
            this.labelTextBox79.DataControlName = "txtData";
            this.labelTextBox79.DataEnabled = true;
            this.labelTextBox79.DataReadOnly = false;
            this.labelTextBox79.DataTextLocation = new System.Drawing.Point(154, 0);
            this.labelTextBox79.DataTextSize = new System.Drawing.Size(139, 30);
            this.labelTextBox79.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox79.Id = "";
            this.labelTextBox79.Label = "";
            this.labelTextBox79.Location = new System.Drawing.Point(313, 320);
            this.labelTextBox79.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelTextBox79.MaxByteLength = 65535;
            this.labelTextBox79.MaxLength = 0;
            this.labelTextBox79.Name = "labelTextBox79";
            this.labelTextBox79.Size = new System.Drawing.Size(293, 30);
            this.labelTextBox79.TabIndex = 111;
            this.labelTextBox79.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelTextBox79.TextBackColor = System.Drawing.SystemColors.Window;
            this.labelTextBox79.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTextBox79.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox79.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTextBox79.Title = "最終配合リリース";
            this.labelTextBox79.TitleControlName = "lblTitle";
            this.labelTextBox79.TitleSize = new System.Drawing.Size(154, 30);
            this.labelTextBox79.Value = "";
            // 
            // labelTextBox78
            // 
            this.labelTextBox78.DatabaseColumnName = "Revision";
            this.labelTextBox78.DataControlName = "txtData";
            this.labelTextBox78.DataEnabled = true;
            this.labelTextBox78.DataReadOnly = false;
            this.labelTextBox78.DataTextLocation = new System.Drawing.Point(154, 0);
            this.labelTextBox78.DataTextSize = new System.Drawing.Size(139, 30);
            this.labelTextBox78.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox78.Id = "";
            this.labelTextBox78.Label = "";
            this.labelTextBox78.Location = new System.Drawing.Point(313, 285);
            this.labelTextBox78.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelTextBox78.MaxByteLength = 65535;
            this.labelTextBox78.MaxLength = 0;
            this.labelTextBox78.Name = "labelTextBox78";
            this.labelTextBox78.Size = new System.Drawing.Size(293, 30);
            this.labelTextBox78.TabIndex = 110;
            this.labelTextBox78.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelTextBox78.TextBackColor = System.Drawing.SystemColors.Window;
            this.labelTextBox78.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTextBox78.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox78.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTextBox78.Title = "補正";
            this.labelTextBox78.TitleControlName = "lblTitle";
            this.labelTextBox78.TitleSize = new System.Drawing.Size(154, 30);
            this.labelTextBox78.Value = "";
            // 
            // labelTextBox77
            // 
            this.labelTextBox77.DatabaseColumnName = "Mixing_Speed";
            this.labelTextBox77.DataControlName = "txtData";
            this.labelTextBox77.DataEnabled = true;
            this.labelTextBox77.DataReadOnly = false;
            this.labelTextBox77.DataTextLocation = new System.Drawing.Point(164, 0);
            this.labelTextBox77.DataTextSize = new System.Drawing.Size(129, 30);
            this.labelTextBox77.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox77.Id = "";
            this.labelTextBox77.Label = "";
            this.labelTextBox77.Location = new System.Drawing.Point(313, 250);
            this.labelTextBox77.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelTextBox77.MaxByteLength = 65535;
            this.labelTextBox77.MaxLength = 0;
            this.labelTextBox77.Name = "labelTextBox77";
            this.labelTextBox77.Size = new System.Drawing.Size(293, 30);
            this.labelTextBox77.TabIndex = 109;
            this.labelTextBox77.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelTextBox77.TextBackColor = System.Drawing.SystemColors.Window;
            this.labelTextBox77.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTextBox77.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox77.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTextBox77.Title = "ﾐｷｼﾝｸﾞｽﾋﾟｰﾄﾞ(回/分)";
            this.labelTextBox77.TitleControlName = "lblTitle";
            this.labelTextBox77.TitleSize = new System.Drawing.Size(164, 30);
            this.labelTextBox77.Value = "";
            // 
            // labelTextBox76
            // 
            this.labelTextBox76.DatabaseColumnName = "Mixing_Time";
            this.labelTextBox76.DataControlName = "txtData";
            this.labelTextBox76.DataEnabled = true;
            this.labelTextBox76.DataReadOnly = false;
            this.labelTextBox76.DataTextLocation = new System.Drawing.Point(154, 0);
            this.labelTextBox76.DataTextSize = new System.Drawing.Size(139, 30);
            this.labelTextBox76.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox76.Id = "";
            this.labelTextBox76.Label = "";
            this.labelTextBox76.Location = new System.Drawing.Point(313, 215);
            this.labelTextBox76.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelTextBox76.MaxByteLength = 65535;
            this.labelTextBox76.MaxLength = 0;
            this.labelTextBox76.Name = "labelTextBox76";
            this.labelTextBox76.Size = new System.Drawing.Size(293, 30);
            this.labelTextBox76.TabIndex = 108;
            this.labelTextBox76.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelTextBox76.TextBackColor = System.Drawing.SystemColors.Window;
            this.labelTextBox76.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTextBox76.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox76.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTextBox76.Title = "ﾐｷｼﾝｸﾞﾀｲﾑ[s]";
            this.labelTextBox76.TitleControlName = "lblTitle";
            this.labelTextBox76.TitleSize = new System.Drawing.Size(154, 30);
            this.labelTextBox76.Value = "";
            // 
            // labelTextBox75
            // 
            this.labelTextBox75.DatabaseColumnName = "Quality_Sample";
            this.labelTextBox75.DataControlName = "txtData";
            this.labelTextBox75.DataEnabled = true;
            this.labelTextBox75.DataReadOnly = false;
            this.labelTextBox75.DataTextLocation = new System.Drawing.Point(154, 0);
            this.labelTextBox75.DataTextSize = new System.Drawing.Size(139, 30);
            this.labelTextBox75.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox75.Id = "";
            this.labelTextBox75.Label = "";
            this.labelTextBox75.Location = new System.Drawing.Point(313, 180);
            this.labelTextBox75.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelTextBox75.MaxByteLength = 65535;
            this.labelTextBox75.MaxLength = 0;
            this.labelTextBox75.Name = "labelTextBox75";
            this.labelTextBox75.Size = new System.Drawing.Size(293, 30);
            this.labelTextBox75.TabIndex = 107;
            this.labelTextBox75.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelTextBox75.TextBackColor = System.Drawing.SystemColors.Window;
            this.labelTextBox75.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTextBox75.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox75.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTextBox75.Title = "ｸｵﾘﾃｨｻﾝﾌﾟﾙ[g]";
            this.labelTextBox75.TitleControlName = "lblTitle";
            this.labelTextBox75.TitleSize = new System.Drawing.Size(154, 30);
            this.labelTextBox75.Value = "";
            // 
            // labelTextBox74
            // 
            this.labelTextBox74.DatabaseColumnName = "Overfilling";
            this.labelTextBox74.DataControlName = "txtData";
            this.labelTextBox74.DataEnabled = true;
            this.labelTextBox74.DataReadOnly = false;
            this.labelTextBox74.DataTextLocation = new System.Drawing.Point(154, 0);
            this.labelTextBox74.DataTextSize = new System.Drawing.Size(139, 30);
            this.labelTextBox74.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox74.Id = "";
            this.labelTextBox74.Label = "";
            this.labelTextBox74.Location = new System.Drawing.Point(313, 145);
            this.labelTextBox74.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelTextBox74.MaxByteLength = 65535;
            this.labelTextBox74.MaxLength = 0;
            this.labelTextBox74.Name = "labelTextBox74";
            this.labelTextBox74.Size = new System.Drawing.Size(293, 30);
            this.labelTextBox74.TabIndex = 106;
            this.labelTextBox74.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelTextBox74.TextBackColor = System.Drawing.SystemColors.Window;
            this.labelTextBox74.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTextBox74.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox74.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTextBox74.Title = "超過[%]";
            this.labelTextBox74.TitleControlName = "lblTitle";
            this.labelTextBox74.TitleSize = new System.Drawing.Size(154, 30);
            this.labelTextBox74.Value = "";
            // 
            // labelTextBox73
            // 
            this.labelTextBox73.DatabaseColumnName = "Prefill_Amount";
            this.labelTextBox73.DataControlName = "txtData";
            this.labelTextBox73.DataEnabled = true;
            this.labelTextBox73.DataReadOnly = false;
            this.labelTextBox73.DataTextLocation = new System.Drawing.Point(154, 0);
            this.labelTextBox73.DataTextSize = new System.Drawing.Size(139, 30);
            this.labelTextBox73.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox73.Id = "";
            this.labelTextBox73.Label = "";
            this.labelTextBox73.Location = new System.Drawing.Point(313, 110);
            this.labelTextBox73.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelTextBox73.MaxByteLength = 65535;
            this.labelTextBox73.MaxLength = 0;
            this.labelTextBox73.Name = "labelTextBox73";
            this.labelTextBox73.Size = new System.Drawing.Size(293, 30);
            this.labelTextBox73.TabIndex = 105;
            this.labelTextBox73.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelTextBox73.TextBackColor = System.Drawing.SystemColors.Window;
            this.labelTextBox73.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTextBox73.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox73.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTextBox73.Title = "充填済み重量(g)";
            this.labelTextBox73.TitleControlName = "lblTitle";
            this.labelTextBox73.TitleSize = new System.Drawing.Size(154, 30);
            this.labelTextBox73.Value = "";
            // 
            // labelTextBox62
            // 
            this.labelTextBox62.DatabaseColumnName = "HG_Theme_Code";
            this.labelTextBox62.DataControlName = "txtData";
            this.labelTextBox62.DataEnabled = true;
            this.labelTextBox62.DataReadOnly = false;
            this.labelTextBox62.DataTextLocation = new System.Drawing.Point(154, 0);
            this.labelTextBox62.DataTextSize = new System.Drawing.Size(139, 30);
            this.labelTextBox62.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox62.Id = "";
            this.labelTextBox62.Label = "";
            this.labelTextBox62.Location = new System.Drawing.Point(3, 355);
            this.labelTextBox62.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelTextBox62.MaxByteLength = 65535;
            this.labelTextBox62.MaxLength = 0;
            this.labelTextBox62.Name = "labelTextBox62";
            this.labelTextBox62.Size = new System.Drawing.Size(293, 30);
            this.labelTextBox62.TabIndex = 104;
            this.labelTextBox62.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelTextBox62.TextBackColor = System.Drawing.SystemColors.Window;
            this.labelTextBox62.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTextBox62.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox62.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTextBox62.Title = "RF集計区分";
            this.labelTextBox62.TitleControlName = "lblTitle";
            this.labelTextBox62.TitleSize = new System.Drawing.Size(154, 30);
            this.labelTextBox62.Value = "";
            // 
            // labelTextBox61
            // 
            this.labelTextBox61.DatabaseColumnName = "HG_Sum_up_Key";
            this.labelTextBox61.DataControlName = "txtData";
            this.labelTextBox61.DataEnabled = true;
            this.labelTextBox61.DataReadOnly = false;
            this.labelTextBox61.DataTextLocation = new System.Drawing.Point(154, 0);
            this.labelTextBox61.DataTextSize = new System.Drawing.Size(139, 30);
            this.labelTextBox61.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox61.Id = "";
            this.labelTextBox61.Label = "";
            this.labelTextBox61.Location = new System.Drawing.Point(3, 320);
            this.labelTextBox61.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelTextBox61.MaxByteLength = 65535;
            this.labelTextBox61.MaxLength = 0;
            this.labelTextBox61.Name = "labelTextBox61";
            this.labelTextBox61.Size = new System.Drawing.Size(293, 30);
            this.labelTextBox61.TabIndex = 103;
            this.labelTextBox61.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelTextBox61.TextBackColor = System.Drawing.SystemColors.Window;
            this.labelTextBox61.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTextBox61.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox61.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTextBox61.Title = "順位コード";
            this.labelTextBox61.TitleControlName = "lblTitle";
            this.labelTextBox61.TitleSize = new System.Drawing.Size(154, 30);
            this.labelTextBox61.Value = "";
            // 
            // labelTextBox60
            // 
            this.labelTextBox60.DatabaseColumnName = "HG_Tinting_Price_Rank";
            this.labelTextBox60.DataControlName = "txtData";
            this.labelTextBox60.DataEnabled = true;
            this.labelTextBox60.DataReadOnly = false;
            this.labelTextBox60.DataTextLocation = new System.Drawing.Point(154, 0);
            this.labelTextBox60.DataTextSize = new System.Drawing.Size(139, 30);
            this.labelTextBox60.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox60.Id = "";
            this.labelTextBox60.Label = "";
            this.labelTextBox60.Location = new System.Drawing.Point(3, 285);
            this.labelTextBox60.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelTextBox60.MaxByteLength = 65535;
            this.labelTextBox60.MaxLength = 0;
            this.labelTextBox60.Name = "labelTextBox60";
            this.labelTextBox60.Size = new System.Drawing.Size(293, 30);
            this.labelTextBox60.TabIndex = 102;
            this.labelTextBox60.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelTextBox60.TextBackColor = System.Drawing.SystemColors.Window;
            this.labelTextBox60.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTextBox60.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox60.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTextBox60.Title = "調色ランク";
            this.labelTextBox60.TitleControlName = "lblTitle";
            this.labelTextBox60.TitleSize = new System.Drawing.Size(154, 30);
            this.labelTextBox60.Value = "";
            // 
            // labelTextBox59
            // 
            this.labelTextBox59.DatabaseColumnName = "HG_Volume_Code";
            this.labelTextBox59.DataControlName = "txtData";
            this.labelTextBox59.DataEnabled = true;
            this.labelTextBox59.DataReadOnly = false;
            this.labelTextBox59.DataTextLocation = new System.Drawing.Point(154, 0);
            this.labelTextBox59.DataTextSize = new System.Drawing.Size(139, 30);
            this.labelTextBox59.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox59.Id = "";
            this.labelTextBox59.Label = "";
            this.labelTextBox59.Location = new System.Drawing.Point(3, 250);
            this.labelTextBox59.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelTextBox59.MaxByteLength = 65535;
            this.labelTextBox59.MaxLength = 0;
            this.labelTextBox59.Name = "labelTextBox59";
            this.labelTextBox59.Size = new System.Drawing.Size(293, 30);
            this.labelTextBox59.TabIndex = 101;
            this.labelTextBox59.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelTextBox59.TextBackColor = System.Drawing.SystemColors.Window;
            this.labelTextBox59.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTextBox59.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox59.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTextBox59.Title = "容量コード";
            this.labelTextBox59.TitleControlName = "lblTitle";
            this.labelTextBox59.TitleSize = new System.Drawing.Size(154, 30);
            this.labelTextBox59.Value = "";
            // 
            // labelTextBox58
            // 
            this.labelTextBox58.DatabaseColumnName = "Number_of_cans";
            this.labelTextBox58.DataControlName = "txtData";
            this.labelTextBox58.DataEnabled = true;
            this.labelTextBox58.DataReadOnly = false;
            this.labelTextBox58.DataTextLocation = new System.Drawing.Point(154, 0);
            this.labelTextBox58.DataTextSize = new System.Drawing.Size(139, 30);
            this.labelTextBox58.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox58.Id = "";
            this.labelTextBox58.Label = "";
            this.labelTextBox58.Location = new System.Drawing.Point(3, 215);
            this.labelTextBox58.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelTextBox58.MaxByteLength = 65535;
            this.labelTextBox58.MaxLength = 0;
            this.labelTextBox58.Name = "labelTextBox58";
            this.labelTextBox58.Size = new System.Drawing.Size(293, 30);
            this.labelTextBox58.TabIndex = 100;
            this.labelTextBox58.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelTextBox58.TextBackColor = System.Drawing.SystemColors.Window;
            this.labelTextBox58.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTextBox58.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox58.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTextBox58.Title = "缶数";
            this.labelTextBox58.TitleControlName = "lblTitle";
            this.labelTextBox58.TitleSize = new System.Drawing.Size(154, 30);
            this.labelTextBox58.Value = "";
            // 
            // labelTextBox57
            // 
            this.labelTextBox57.DatabaseColumnName = "HG_Data_Number";
            this.labelTextBox57.DataControlName = "txtData";
            this.labelTextBox57.DataEnabled = true;
            this.labelTextBox57.DataReadOnly = false;
            this.labelTextBox57.DataTextLocation = new System.Drawing.Point(154, 0);
            this.labelTextBox57.DataTextSize = new System.Drawing.Size(139, 30);
            this.labelTextBox57.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox57.Id = "";
            this.labelTextBox57.Label = "";
            this.labelTextBox57.Location = new System.Drawing.Point(3, 180);
            this.labelTextBox57.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelTextBox57.MaxByteLength = 65535;
            this.labelTextBox57.MaxLength = 0;
            this.labelTextBox57.Name = "labelTextBox57";
            this.labelTextBox57.Size = new System.Drawing.Size(293, 30);
            this.labelTextBox57.TabIndex = 99;
            this.labelTextBox57.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelTextBox57.TextBackColor = System.Drawing.SystemColors.Window;
            this.labelTextBox57.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTextBox57.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox57.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTextBox57.Title = "処理No.";
            this.labelTextBox57.TitleControlName = "lblTitle";
            this.labelTextBox57.TitleSize = new System.Drawing.Size(154, 30);
            this.labelTextBox57.Value = "";
            // 
            // labelTextBox56
            // 
            this.labelTextBox56.DatabaseColumnName = "Product_Code";
            this.labelTextBox56.DataControlName = "txtData";
            this.labelTextBox56.DataEnabled = true;
            this.labelTextBox56.DataReadOnly = false;
            this.labelTextBox56.DataTextLocation = new System.Drawing.Point(154, 0);
            this.labelTextBox56.DataTextSize = new System.Drawing.Size(139, 30);
            this.labelTextBox56.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox56.Id = "";
            this.labelTextBox56.Label = "";
            this.labelTextBox56.Location = new System.Drawing.Point(3, 145);
            this.labelTextBox56.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelTextBox56.MaxByteLength = 65535;
            this.labelTextBox56.MaxLength = 0;
            this.labelTextBox56.Name = "labelTextBox56";
            this.labelTextBox56.Size = new System.Drawing.Size(293, 30);
            this.labelTextBox56.TabIndex = 98;
            this.labelTextBox56.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelTextBox56.TextBackColor = System.Drawing.SystemColors.Window;
            this.labelTextBox56.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTextBox56.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox56.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTextBox56.Title = "製品コード";
            this.labelTextBox56.TitleControlName = "lblTitle";
            this.labelTextBox56.TitleSize = new System.Drawing.Size(154, 30);
            this.labelTextBox56.Value = "";
            // 
            // labelTextBox55
            // 
            this.labelTextBox55.DatabaseColumnName = "Order_Number";
            this.labelTextBox55.DataControlName = "txtData";
            this.labelTextBox55.DataEnabled = true;
            this.labelTextBox55.DataReadOnly = false;
            this.labelTextBox55.DataTextLocation = new System.Drawing.Point(154, 0);
            this.labelTextBox55.DataTextSize = new System.Drawing.Size(139, 30);
            this.labelTextBox55.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox55.Id = "";
            this.labelTextBox55.Label = "";
            this.labelTextBox55.Location = new System.Drawing.Point(3, 110);
            this.labelTextBox55.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelTextBox55.MaxByteLength = 65535;
            this.labelTextBox55.MaxLength = 0;
            this.labelTextBox55.Name = "labelTextBox55";
            this.labelTextBox55.Size = new System.Drawing.Size(293, 30);
            this.labelTextBox55.TabIndex = 97;
            this.labelTextBox55.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelTextBox55.TextBackColor = System.Drawing.SystemColors.Window;
            this.labelTextBox55.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTextBox55.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox55.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTextBox55.Title = "注文番号";
            this.labelTextBox55.TitleControlName = "lblTitle";
            this.labelTextBox55.TitleSize = new System.Drawing.Size(154, 30);
            this.labelTextBox55.Value = "";
            // 
            // labelTextBox54
            // 
            this.labelTextBox54.DatabaseColumnName = "Total_Weight";
            this.labelTextBox54.DataControlName = "txtData";
            this.labelTextBox54.DataEnabled = true;
            this.labelTextBox54.DataReadOnly = false;
            this.labelTextBox54.DataTextLocation = new System.Drawing.Point(154, 0);
            this.labelTextBox54.DataTextSize = new System.Drawing.Size(139, 30);
            this.labelTextBox54.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox54.Id = "";
            this.labelTextBox54.Label = "";
            this.labelTextBox54.Location = new System.Drawing.Point(313, 75);
            this.labelTextBox54.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelTextBox54.MaxByteLength = 65535;
            this.labelTextBox54.MaxLength = 0;
            this.labelTextBox54.Name = "labelTextBox54";
            this.labelTextBox54.Size = new System.Drawing.Size(293, 30);
            this.labelTextBox54.TabIndex = 96;
            this.labelTextBox54.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelTextBox54.TextBackColor = System.Drawing.SystemColors.Window;
            this.labelTextBox54.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTextBox54.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox54.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTextBox54.Title = "合計重量[g]";
            this.labelTextBox54.TitleControlName = "lblTitle";
            this.labelTextBox54.TitleSize = new System.Drawing.Size(154, 30);
            this.labelTextBox54.Value = "";
            // 
            // labelTextBox53
            // 
            this.labelTextBox53.DatabaseColumnName = "HG_Product_No";
            this.labelTextBox53.DataControlName = "txtData";
            this.labelTextBox53.DataEnabled = true;
            this.labelTextBox53.DataReadOnly = false;
            this.labelTextBox53.DataTextLocation = new System.Drawing.Point(154, 0);
            this.labelTextBox53.DataTextSize = new System.Drawing.Size(139, 30);
            this.labelTextBox53.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox53.Id = "";
            this.labelTextBox53.Label = "";
            this.labelTextBox53.Location = new System.Drawing.Point(3, 75);
            this.labelTextBox53.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelTextBox53.MaxByteLength = 65535;
            this.labelTextBox53.MaxLength = 0;
            this.labelTextBox53.Name = "labelTextBox53";
            this.labelTextBox53.Size = new System.Drawing.Size(293, 30);
            this.labelTextBox53.TabIndex = 95;
            this.labelTextBox53.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelTextBox53.TextBackColor = System.Drawing.SystemColors.Window;
            this.labelTextBox53.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTextBox53.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox53.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTextBox53.Title = "品名コード";
            this.labelTextBox53.TitleControlName = "lblTitle";
            this.labelTextBox53.TitleSize = new System.Drawing.Size(154, 30);
            this.labelTextBox53.Value = "";
            // 
            // labelTextBox52
            // 
            this.labelTextBox52.DatabaseColumnName = "Paint_Name";
            this.labelTextBox52.DataControlName = "txtData";
            this.labelTextBox52.DataEnabled = true;
            this.labelTextBox52.DataReadOnly = false;
            this.labelTextBox52.DataTextLocation = new System.Drawing.Point(154, 0);
            this.labelTextBox52.DataTextSize = new System.Drawing.Size(1379, 30);
            this.labelTextBox52.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox52.Id = "";
            this.labelTextBox52.Label = "";
            this.labelTextBox52.Location = new System.Drawing.Point(3, 40);
            this.labelTextBox52.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelTextBox52.MaxByteLength = 65535;
            this.labelTextBox52.MaxLength = 0;
            this.labelTextBox52.Name = "labelTextBox52";
            this.labelTextBox52.Size = new System.Drawing.Size(1533, 30);
            this.labelTextBox52.TabIndex = 94;
            this.labelTextBox52.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelTextBox52.TextBackColor = System.Drawing.SystemColors.Window;
            this.labelTextBox52.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTextBox52.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox52.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTextBox52.Title = "品名";
            this.labelTextBox52.TitleControlName = "lblTitle";
            this.labelTextBox52.TitleSize = new System.Drawing.Size(154, 30);
            this.labelTextBox52.Value = "";
            // 
            // labelTextBox51
            // 
            this.labelTextBox51.DatabaseColumnName = "Color_Name";
            this.labelTextBox51.DataControlName = "txtData";
            this.labelTextBox51.DataEnabled = true;
            this.labelTextBox51.DataReadOnly = false;
            this.labelTextBox51.DataTextLocation = new System.Drawing.Point(154, 0);
            this.labelTextBox51.DataTextSize = new System.Drawing.Size(1379, 30);
            this.labelTextBox51.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox51.Id = "";
            this.labelTextBox51.Label = "";
            this.labelTextBox51.Location = new System.Drawing.Point(3, 5);
            this.labelTextBox51.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelTextBox51.MaxByteLength = 65535;
            this.labelTextBox51.MaxLength = 0;
            this.labelTextBox51.Name = "labelTextBox51";
            this.labelTextBox51.Size = new System.Drawing.Size(1533, 30);
            this.labelTextBox51.TabIndex = 93;
            this.labelTextBox51.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelTextBox51.TextBackColor = System.Drawing.SystemColors.Window;
            this.labelTextBox51.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTextBox51.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox51.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTextBox51.Title = "色名";
            this.labelTextBox51.TitleControlName = "lblTitle";
            this.labelTextBox51.TitleSize = new System.Drawing.Size(154, 30);
            this.labelTextBox51.Value = "";
            // 
            // GvWeight
            // 
            this.GvWeight.AllowUserToAddRows = false;
            this.GvWeight.AllowUserToDeleteRows = false;
            this.GvWeight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvWeight.Location = new System.Drawing.Point(623, 75);
            this.GvWeight.Name = "GvWeight";
            this.GvWeight.ReadOnly = true;
            this.GvWeight.RowTemplate.Height = 21;
            this.GvWeight.Size = new System.Drawing.Size(586, 458);
            this.GvWeight.TabIndex = 73;
            // 
            // tabCan
            // 
            this.tabCan.BackColor = System.Drawing.SystemColors.Control;
            this.tabCan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabCan.Controls.Add(this.panel9);
            this.tabCan.Controls.Add(this.panel8);
            this.tabCan.Controls.Add(this.panel7);
            this.tabCan.Location = new System.Drawing.Point(4, 29);
            this.tabCan.Name = "tabCan";
            this.tabCan.Size = new System.Drawing.Size(1663, 932);
            this.tabCan.TabIndex = 3;
            this.tabCan.Text = "缶";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.GvOutWeight);
            this.panel9.Controls.Add(this.GvWeightDetail);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 547);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1661, 383);
            this.panel9.TabIndex = 2;
            // 
            // GvOutWeight
            // 
            this.GvOutWeight.AllowUserToAddRows = false;
            this.GvOutWeight.AllowUserToDeleteRows = false;
            this.GvOutWeight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvOutWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GvOutWeight.Location = new System.Drawing.Point(632, 0);
            this.GvOutWeight.Name = "GvOutWeight";
            this.GvOutWeight.ReadOnly = true;
            this.GvOutWeight.RowTemplate.Height = 21;
            this.GvOutWeight.Size = new System.Drawing.Size(1029, 383);
            this.GvOutWeight.TabIndex = 1;
            // 
            // GvWeightDetail
            // 
            this.GvWeightDetail.AllowUserToAddRows = false;
            this.GvWeightDetail.AllowUserToDeleteRows = false;
            this.GvWeightDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvWeightDetail.Dock = System.Windows.Forms.DockStyle.Left;
            this.GvWeightDetail.Location = new System.Drawing.Point(0, 0);
            this.GvWeightDetail.Name = "GvWeightDetail";
            this.GvWeightDetail.ReadOnly = true;
            this.GvWeightDetail.RowTemplate.Height = 21;
            this.GvWeightDetail.Size = new System.Drawing.Size(632, 383);
            this.GvWeightDetail.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Controls.Add(this.labelTextBox83);
            this.panel8.Controls.Add(this.labelTextBox82);
            this.panel8.Controls.Add(this.labelTextBox81);
            this.panel8.Controls.Add(this.labelTextBox80);
            this.panel8.Controls.Add(this.labelTextBox12);
            this.panel8.Controls.Add(this.labelTextBox11);
            this.panel8.Controls.Add(this.labelTextBox10);
            this.panel8.Controls.Add(this.labelTextBox9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 375);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1661, 172);
            this.panel8.TabIndex = 1;
            // 
            // labelTextBox83
            // 
            this.labelTextBox83.DatabaseColumnName = null;
            this.labelTextBox83.DataControlName = "txtData";
            this.labelTextBox83.DataEnabled = true;
            this.labelTextBox83.DataReadOnly = false;
            this.labelTextBox83.DataTextLocation = new System.Drawing.Point(154, 0);
            this.labelTextBox83.DataTextSize = new System.Drawing.Size(139, 30);
            this.labelTextBox83.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox83.Id = "";
            this.labelTextBox83.Label = "";
            this.labelTextBox83.Location = new System.Drawing.Point(646, 129);
            this.labelTextBox83.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelTextBox83.MaxByteLength = 65535;
            this.labelTextBox83.MaxLength = 0;
            this.labelTextBox83.Name = "labelTextBox83";
            this.labelTextBox83.Size = new System.Drawing.Size(293, 30);
            this.labelTextBox83.TabIndex = 23;
            this.labelTextBox83.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelTextBox83.TextBackColor = System.Drawing.SystemColors.Window;
            this.labelTextBox83.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTextBox83.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox83.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTextBox83.Title = "吐出された配合ﾘﾘｰｽ";
            this.labelTextBox83.TitleControlName = "lblTitle";
            this.labelTextBox83.TitleSize = new System.Drawing.Size(154, 30);
            this.labelTextBox83.Value = "";
            // 
            // labelTextBox82
            // 
            this.labelTextBox82.DatabaseColumnName = null;
            this.labelTextBox82.DataControlName = "txtData";
            this.labelTextBox82.DataEnabled = true;
            this.labelTextBox82.DataReadOnly = false;
            this.labelTextBox82.DataTextLocation = new System.Drawing.Point(154, 0);
            this.labelTextBox82.DataTextSize = new System.Drawing.Size(139, 30);
            this.labelTextBox82.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox82.Id = "";
            this.labelTextBox82.Label = "";
            this.labelTextBox82.Location = new System.Drawing.Point(646, 88);
            this.labelTextBox82.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelTextBox82.MaxByteLength = 65535;
            this.labelTextBox82.MaxLength = 0;
            this.labelTextBox82.Name = "labelTextBox82";
            this.labelTextBox82.Size = new System.Drawing.Size(293, 30);
            this.labelTextBox82.TabIndex = 22;
            this.labelTextBox82.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelTextBox82.TextBackColor = System.Drawing.SystemColors.Window;
            this.labelTextBox82.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTextBox82.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox82.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTextBox82.Title = "出力重量[g]";
            this.labelTextBox82.TitleControlName = "lblTitle";
            this.labelTextBox82.TitleSize = new System.Drawing.Size(154, 30);
            this.labelTextBox82.Value = "";
            // 
            // labelTextBox81
            // 
            this.labelTextBox81.DatabaseColumnName = null;
            this.labelTextBox81.DataControlName = "txtData";
            this.labelTextBox81.DataEnabled = true;
            this.labelTextBox81.DataReadOnly = false;
            this.labelTextBox81.DataTextLocation = new System.Drawing.Point(154, 0);
            this.labelTextBox81.DataTextSize = new System.Drawing.Size(139, 30);
            this.labelTextBox81.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox81.Id = "";
            this.labelTextBox81.Label = "";
            this.labelTextBox81.Location = new System.Drawing.Point(646, 48);
            this.labelTextBox81.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelTextBox81.MaxByteLength = 65535;
            this.labelTextBox81.MaxLength = 0;
            this.labelTextBox81.Name = "labelTextBox81";
            this.labelTextBox81.Size = new System.Drawing.Size(293, 30);
            this.labelTextBox81.TabIndex = 21;
            this.labelTextBox81.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelTextBox81.TextBackColor = System.Drawing.SystemColors.Window;
            this.labelTextBox81.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTextBox81.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox81.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTextBox81.Title = "目標重量[g]";
            this.labelTextBox81.TitleControlName = "lblTitle";
            this.labelTextBox81.TitleSize = new System.Drawing.Size(154, 30);
            this.labelTextBox81.Value = "";
            // 
            // labelTextBox80
            // 
            this.labelTextBox80.DatabaseColumnName = null;
            this.labelTextBox80.DataControlName = "txtData";
            this.labelTextBox80.DataEnabled = true;
            this.labelTextBox80.DataReadOnly = false;
            this.labelTextBox80.DataTextLocation = new System.Drawing.Point(154, 0);
            this.labelTextBox80.DataTextSize = new System.Drawing.Size(139, 30);
            this.labelTextBox80.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox80.Id = "";
            this.labelTextBox80.Label = "";
            this.labelTextBox80.Location = new System.Drawing.Point(646, 9);
            this.labelTextBox80.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelTextBox80.MaxByteLength = 65535;
            this.labelTextBox80.MaxLength = 0;
            this.labelTextBox80.Name = "labelTextBox80";
            this.labelTextBox80.Size = new System.Drawing.Size(293, 30);
            this.labelTextBox80.TabIndex = 20;
            this.labelTextBox80.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelTextBox80.TextBackColor = System.Drawing.SystemColors.Window;
            this.labelTextBox80.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTextBox80.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox80.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTextBox80.Title = "バーコード";
            this.labelTextBox80.TitleControlName = "lblTitle";
            this.labelTextBox80.TitleSize = new System.Drawing.Size(154, 30);
            this.labelTextBox80.Value = "";
            // 
            // labelTextBox12
            // 
            this.labelTextBox12.DatabaseColumnName = null;
            this.labelTextBox12.DataControlName = "txtData";
            this.labelTextBox12.DataEnabled = true;
            this.labelTextBox12.DataReadOnly = false;
            this.labelTextBox12.DataTextLocation = new System.Drawing.Point(154, 0);
            this.labelTextBox12.DataTextSize = new System.Drawing.Size(139, 30);
            this.labelTextBox12.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox12.Id = "";
            this.labelTextBox12.Label = "";
            this.labelTextBox12.Location = new System.Drawing.Point(9, 129);
            this.labelTextBox12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelTextBox12.MaxByteLength = 65535;
            this.labelTextBox12.MaxLength = 0;
            this.labelTextBox12.Name = "labelTextBox12";
            this.labelTextBox12.Size = new System.Drawing.Size(293, 30);
            this.labelTextBox12.TabIndex = 19;
            this.labelTextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelTextBox12.TextBackColor = System.Drawing.SystemColors.Window;
            this.labelTextBox12.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTextBox12.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox12.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTextBox12.Title = "最終配合リリース";
            this.labelTextBox12.TitleControlName = "lblTitle";
            this.labelTextBox12.TitleSize = new System.Drawing.Size(154, 30);
            this.labelTextBox12.Value = "";
            // 
            // labelTextBox11
            // 
            this.labelTextBox11.DatabaseColumnName = null;
            this.labelTextBox11.DataControlName = "txtData";
            this.labelTextBox11.DataEnabled = true;
            this.labelTextBox11.DataReadOnly = false;
            this.labelTextBox11.DataTextLocation = new System.Drawing.Point(154, 0);
            this.labelTextBox11.DataTextSize = new System.Drawing.Size(139, 30);
            this.labelTextBox11.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox11.Id = "";
            this.labelTextBox11.Label = "";
            this.labelTextBox11.Location = new System.Drawing.Point(9, 88);
            this.labelTextBox11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelTextBox11.MaxByteLength = 65535;
            this.labelTextBox11.MaxLength = 0;
            this.labelTextBox11.Name = "labelTextBox11";
            this.labelTextBox11.Size = new System.Drawing.Size(293, 30);
            this.labelTextBox11.TabIndex = 18;
            this.labelTextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelTextBox11.TextBackColor = System.Drawing.SystemColors.Window;
            this.labelTextBox11.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTextBox11.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox11.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTextBox11.Title = "補正";
            this.labelTextBox11.TitleControlName = "lblTitle";
            this.labelTextBox11.TitleSize = new System.Drawing.Size(154, 30);
            this.labelTextBox11.Value = "";
            // 
            // labelTextBox10
            // 
            this.labelTextBox10.DatabaseColumnName = null;
            this.labelTextBox10.DataControlName = "txtData";
            this.labelTextBox10.DataEnabled = true;
            this.labelTextBox10.DataReadOnly = false;
            this.labelTextBox10.DataTextLocation = new System.Drawing.Point(154, 0);
            this.labelTextBox10.DataTextSize = new System.Drawing.Size(139, 30);
            this.labelTextBox10.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox10.Id = "";
            this.labelTextBox10.Label = "";
            this.labelTextBox10.Location = new System.Drawing.Point(9, 48);
            this.labelTextBox10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelTextBox10.MaxByteLength = 65535;
            this.labelTextBox10.MaxLength = 0;
            this.labelTextBox10.Name = "labelTextBox10";
            this.labelTextBox10.Size = new System.Drawing.Size(293, 30);
            this.labelTextBox10.TabIndex = 17;
            this.labelTextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelTextBox10.TextBackColor = System.Drawing.SystemColors.Window;
            this.labelTextBox10.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTextBox10.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox10.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTextBox10.Title = "缶数";
            this.labelTextBox10.TitleControlName = "lblTitle";
            this.labelTextBox10.TitleSize = new System.Drawing.Size(154, 30);
            this.labelTextBox10.Value = "";
            // 
            // labelTextBox9
            // 
            this.labelTextBox9.DatabaseColumnName = null;
            this.labelTextBox9.DataControlName = "txtData";
            this.labelTextBox9.DataEnabled = true;
            this.labelTextBox9.DataReadOnly = false;
            this.labelTextBox9.DataTextLocation = new System.Drawing.Point(154, 0);
            this.labelTextBox9.DataTextSize = new System.Drawing.Size(139, 30);
            this.labelTextBox9.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox9.Id = "";
            this.labelTextBox9.Label = "";
            this.labelTextBox9.Location = new System.Drawing.Point(9, 9);
            this.labelTextBox9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelTextBox9.MaxByteLength = 65535;
            this.labelTextBox9.MaxLength = 0;
            this.labelTextBox9.Name = "labelTextBox9";
            this.labelTextBox9.Size = new System.Drawing.Size(293, 30);
            this.labelTextBox9.TabIndex = 16;
            this.labelTextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelTextBox9.TextBackColor = System.Drawing.SystemColors.Window;
            this.labelTextBox9.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTextBox9.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox9.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTextBox9.Title = "注文番号";
            this.labelTextBox9.TitleControlName = "lblTitle";
            this.labelTextBox9.TitleSize = new System.Drawing.Size(154, 30);
            this.labelTextBox9.Value = "";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.GvBarcode);
            this.panel7.Controls.Add(this.GvOrderNumber);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1661, 375);
            this.panel7.TabIndex = 0;
            // 
            // GvBarcode
            // 
            this.GvBarcode.AllowUserToAddRows = false;
            this.GvBarcode.AllowUserToDeleteRows = false;
            this.GvBarcode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvBarcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GvBarcode.Location = new System.Drawing.Point(632, 0);
            this.GvBarcode.Name = "GvBarcode";
            this.GvBarcode.ReadOnly = true;
            this.GvBarcode.RowTemplate.Height = 21;
            this.GvBarcode.Size = new System.Drawing.Size(1029, 375);
            this.GvBarcode.TabIndex = 1;
            // 
            // GvOrderNumber
            // 
            this.GvOrderNumber.AllowUserToAddRows = false;
            this.GvOrderNumber.AllowUserToDeleteRows = false;
            this.GvOrderNumber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvOrderNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.GvOrderNumber.Location = new System.Drawing.Point(0, 0);
            this.GvOrderNumber.Name = "GvOrderNumber";
            this.GvOrderNumber.ReadOnly = true;
            this.GvOrderNumber.RowTemplate.Height = 21;
            this.GvOrderNumber.Size = new System.Drawing.Size(632, 375);
            this.GvOrderNumber.TabIndex = 0;
            // 
            // splitCanMain
            // 
            this.splitCanMain.Location = new System.Drawing.Point(0, 0);
            this.splitCanMain.Name = "splitCanMain";
            this.splitCanMain.Size = new System.Drawing.Size(150, 100);
            this.splitCanMain.TabIndex = 0;
            // 
            // splitCanLeft
            // 
            this.splitCanLeft.Location = new System.Drawing.Point(0, 0);
            this.splitCanLeft.Name = "splitCanLeft";
            this.splitCanLeft.Size = new System.Drawing.Size(150, 100);
            this.splitCanLeft.TabIndex = 0;
            // 
            // splitCanRight
            // 
            this.splitCanRight.Location = new System.Drawing.Point(0, 0);
            this.splitCanRight.Name = "splitCanRight";
            this.splitCanRight.Size = new System.Drawing.Size(150, 100);
            this.splitCanRight.TabIndex = 0;
            // 
            // pnlFuncs
            // 
            this.pnlFuncs.Controls.Add(this.BtnProcessDetail);
            this.pnlFuncs.Controls.Add(this.BtnPrint);
            this.pnlFuncs.Controls.Add(this.BtnStatusResume);
            this.pnlFuncs.Controls.Add(this.BtnOrderStart);
            this.pnlFuncs.Controls.Add(this.BtnDecidePerson);
            this.pnlFuncs.Controls.Add(this.BtnOrderClose);
            this.pnlFuncs.Controls.Add(this.BtnPrintEmergency);
            this.pnlFuncs.Controls.Add(this.BtnPrintInstructions);
            this.pnlFuncs.Controls.Add(this.panel1);
            this.pnlFuncs.Controls.Add(this.pnlColorExplanation);
            this.pnlFuncs.Controls.Add(this.panLogo);
            this.pnlFuncs.Controls.Add(this.splitter1);
            this.pnlFuncs.Controls.Add(this.BorderBtnPrint);
            this.pnlFuncs.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFuncs.Location = new System.Drawing.Point(0, 26);
            this.pnlFuncs.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlFuncs.Name = "pnlFuncs";
            this.pnlFuncs.Size = new System.Drawing.Size(223, 965);
            this.pnlFuncs.TabIndex = 0;
            // 
            // BtnProcessDetail
            // 
            this.BtnProcessDetail.Location = new System.Drawing.Point(5, 906);
            this.BtnProcessDetail.Name = "BtnProcessDetail";
            this.BtnProcessDetail.Size = new System.Drawing.Size(216, 54);
            this.BtnProcessDetail.TabIndex = 20;
            this.BtnProcessDetail.Text = "処理No.詳細(F12)";
            this.BtnProcessDetail.UseVisualStyleBackColor = true;
            // 
            // BtnPrint
            // 
            this.BtnPrint.Location = new System.Drawing.Point(5, 511);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(216, 54);
            this.BtnPrint.TabIndex = 19;
            this.BtnPrint.Text = "ラベル印刷(F4)";
            this.BtnPrint.UseVisualStyleBackColor = true;
            // 
            // BtnStatusResume
            // 
            this.BtnStatusResume.Location = new System.Drawing.Point(5, 736);
            this.BtnStatusResume.Name = "BtnStatusResume";
            this.BtnStatusResume.Size = new System.Drawing.Size(216, 54);
            this.BtnStatusResume.TabIndex = 18;
            this.BtnStatusResume.Text = "ステータスを戻す(F8)";
            this.BtnStatusResume.UseVisualStyleBackColor = true;
            // 
            // BtnOrderStart
            // 
            this.BtnOrderStart.Location = new System.Drawing.Point(5, 680);
            this.BtnOrderStart.Name = "BtnOrderStart";
            this.BtnOrderStart.Size = new System.Drawing.Size(216, 54);
            this.BtnOrderStart.TabIndex = 17;
            this.BtnOrderStart.Text = "注文開始(F7)";
            this.BtnOrderStart.UseVisualStyleBackColor = true;
            // 
            // BtnDecidePerson
            // 
            this.BtnDecidePerson.Location = new System.Drawing.Point(5, 793);
            this.BtnDecidePerson.Name = "BtnDecidePerson";
            this.BtnDecidePerson.Size = new System.Drawing.Size(216, 54);
            this.BtnDecidePerson.TabIndex = 16;
            this.BtnDecidePerson.Text = "担当者を決定(F9)";
            this.BtnDecidePerson.UseVisualStyleBackColor = true;
            // 
            // BtnOrderClose
            // 
            this.BtnOrderClose.Location = new System.Drawing.Point(5, 850);
            this.BtnOrderClose.Name = "BtnOrderClose";
            this.BtnOrderClose.Size = new System.Drawing.Size(216, 54);
            this.BtnOrderClose.TabIndex = 15;
            this.BtnOrderClose.Text = "注文を閉じる(F10)";
            this.BtnOrderClose.UseVisualStyleBackColor = true;
            // 
            // BtnPrintEmergency
            // 
            this.BtnPrintEmergency.Location = new System.Drawing.Point(5, 623);
            this.BtnPrintEmergency.Name = "BtnPrintEmergency";
            this.BtnPrintEmergency.Size = new System.Drawing.Size(216, 54);
            this.BtnPrintEmergency.TabIndex = 14;
            this.BtnPrintEmergency.Text = "緊急印刷(F6)";
            this.BtnPrintEmergency.UseVisualStyleBackColor = true;
            // 
            // BtnPrintInstructions
            // 
            this.BtnPrintInstructions.Location = new System.Drawing.Point(5, 567);
            this.BtnPrintInstructions.Name = "BtnPrintInstructions";
            this.BtnPrintInstructions.Size = new System.Drawing.Size(216, 54);
            this.BtnPrintInstructions.TabIndex = 12;
            this.BtnPrintInstructions.Text = "作業指示書の印刷(F5)";
            this.BtnPrintInstructions.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 245);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.RdoTomorrowAfter);
            this.panel3.Controls.Add(this.RdoTodayBefore);
            this.panel3.Controls.Add(this.RdoPreviewAll);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 120);
            this.panel3.TabIndex = 22;
            // 
            // RdoTomorrowAfter
            // 
            this.RdoTomorrowAfter.AutoSize = true;
            this.RdoTomorrowAfter.Location = new System.Drawing.Point(7, 84);
            this.RdoTomorrowAfter.Name = "RdoTomorrowAfter";
            this.RdoTomorrowAfter.Size = new System.Drawing.Size(120, 27);
            this.RdoTomorrowAfter.TabIndex = 8;
            this.RdoTomorrowAfter.Text = "明日以降(F3)";
            this.RdoTomorrowAfter.UseVisualStyleBackColor = true;
            // 
            // RdoTodayBefore
            // 
            this.RdoTodayBefore.AutoSize = true;
            this.RdoTodayBefore.Location = new System.Drawing.Point(7, 56);
            this.RdoTodayBefore.Name = "RdoTodayBefore";
            this.RdoTodayBefore.Size = new System.Drawing.Size(120, 27);
            this.RdoTodayBefore.TabIndex = 7;
            this.RdoTodayBefore.Text = "今日以前(F2)";
            this.RdoTodayBefore.UseVisualStyleBackColor = true;
            // 
            // RdoPreviewAll
            // 
            this.RdoPreviewAll.AutoSize = true;
            this.RdoPreviewAll.Checked = true;
            this.RdoPreviewAll.Location = new System.Drawing.Point(7, 28);
            this.RdoPreviewAll.Name = "RdoPreviewAll";
            this.RdoPreviewAll.Size = new System.Drawing.Size(90, 27);
            this.RdoPreviewAll.TabIndex = 6;
            this.RdoPreviewAll.TabStop = true;
            this.RdoPreviewAll.Text = "全て(F1)";
            this.RdoPreviewAll.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Navy;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "表示選択";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.RdoOrderPerson);
            this.panel2.Controls.Add(this.RdoSortRanking);
            this.panel2.Controls.Add(this.RdoSortKubun);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 120);
            this.panel2.TabIndex = 0;
            // 
            // RdoOrderPerson
            // 
            this.RdoOrderPerson.AutoSize = true;
            this.RdoOrderPerson.Location = new System.Drawing.Point(7, 84);
            this.RdoOrderPerson.Name = "RdoOrderPerson";
            this.RdoOrderPerson.Size = new System.Drawing.Size(113, 27);
            this.RdoOrderPerson.TabIndex = 5;
            this.RdoOrderPerson.Text = "担当者名(&N)";
            this.RdoOrderPerson.UseVisualStyleBackColor = true;
            // 
            // RdoSortRanking
            // 
            this.RdoSortRanking.AutoSize = true;
            this.RdoSortRanking.Location = new System.Drawing.Point(7, 56);
            this.RdoSortRanking.Name = "RdoSortRanking";
            this.RdoSortRanking.Size = new System.Drawing.Size(127, 27);
            this.RdoSortRanking.TabIndex = 4;
            this.RdoSortRanking.Text = "順位コード(&R)";
            this.RdoSortRanking.UseVisualStyleBackColor = true;
            // 
            // RdoSortKubun
            // 
            this.RdoSortKubun.AutoSize = true;
            this.RdoSortKubun.Checked = true;
            this.RdoSortKubun.Location = new System.Drawing.Point(7, 28);
            this.RdoSortKubun.Name = "RdoSortKubun";
            this.RdoSortKubun.Size = new System.Drawing.Size(112, 27);
            this.RdoSortKubun.TabIndex = 3;
            this.RdoSortKubun.TabStop = true;
            this.RdoSortKubun.Text = "運送区分(&T)";
            this.RdoSortKubun.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Navy;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "ソート順";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlColorExplanation
            // 
            this.pnlColorExplanation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColorExplanation.Controls.Add(this.lblStatus5);
            this.pnlColorExplanation.Controls.Add(this.lblStatus4);
            this.pnlColorExplanation.Controls.Add(this.lblStatus3);
            this.pnlColorExplanation.Controls.Add(this.lblStatus2);
            this.pnlColorExplanation.Controls.Add(this.lblStatus1);
            this.pnlColorExplanation.Controls.Add(this.label10);
            this.pnlColorExplanation.Controls.Add(this.label9);
            this.pnlColorExplanation.Controls.Add(this.label8);
            this.pnlColorExplanation.Controls.Add(this.label7);
            this.pnlColorExplanation.Controls.Add(this.label6);
            this.pnlColorExplanation.Controls.Add(this.label1);
            this.pnlColorExplanation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlColorExplanation.Location = new System.Drawing.Point(3, 72);
            this.pnlColorExplanation.Name = "pnlColorExplanation";
            this.pnlColorExplanation.Size = new System.Drawing.Size(220, 191);
            this.pnlColorExplanation.TabIndex = 2;
            // 
            // lblStatus5
            // 
            this.lblStatus5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblStatus5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus5.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblStatus5.Location = new System.Drawing.Point(3, 153);
            this.lblStatus5.Name = "lblStatus5";
            this.lblStatus5.Size = new System.Drawing.Size(103, 24);
            this.lblStatus5.TabIndex = 21;
            this.lblStatus5.Text = "製造缶実施中";
            this.lblStatus5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus4
            // 
            this.lblStatus4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblStatus4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus4.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblStatus4.Location = new System.Drawing.Point(3, 123);
            this.lblStatus4.Name = "lblStatus4";
            this.lblStatus4.Size = new System.Drawing.Size(103, 24);
            this.lblStatus4.TabIndex = 20;
            this.lblStatus4.Text = "テスト缶実施中";
            this.lblStatus4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus3
            // 
            this.lblStatus3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblStatus3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus3.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblStatus3.Location = new System.Drawing.Point(3, 93);
            this.lblStatus3.Name = "lblStatus3";
            this.lblStatus3.Size = new System.Drawing.Size(103, 24);
            this.lblStatus3.TabIndex = 19;
            this.lblStatus3.Text = "準備完";
            this.lblStatus3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus2
            // 
            this.lblStatus2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblStatus2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus2.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblStatus2.Location = new System.Drawing.Point(3, 63);
            this.lblStatus2.Name = "lblStatus2";
            this.lblStatus2.Size = new System.Drawing.Size(103, 24);
            this.lblStatus2.TabIndex = 18;
            this.lblStatus2.Text = "CCM配合待ち";
            this.lblStatus2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus1
            // 
            this.lblStatus1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblStatus1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus1.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblStatus1.Location = new System.Drawing.Point(3, 33);
            this.lblStatus1.Name = "lblStatus1";
            this.lblStatus1.Size = new System.Drawing.Size(103, 24);
            this.lblStatus1.TabIndex = 17;
            this.lblStatus1.Text = "調色担当待ち";
            this.lblStatus1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(110, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "[xx/xx] 99.99t";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(110, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "[xx/xx] 99.99t";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(110, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "[xx/xx] 99.99t";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(110, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "[xx/xx] 99.99t";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(110, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "[xx/xx] 99.99t";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "カラーの説明";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panLogo
            // 
            this.panLogo.BackColor = System.Drawing.Color.Black;
            this.panLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panLogo.BackgroundImage")));
            this.panLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLogo.Location = new System.Drawing.Point(3, 0);
            this.panLogo.Name = "panLogo";
            this.panLogo.Size = new System.Drawing.Size(220, 72);
            this.panLogo.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 965);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // BorderBtnPrint
            // 
            this.BorderBtnPrint.BackColor = System.Drawing.Color.Transparent;
            this.BorderBtnPrint.BorderColor = System.Drawing.Color.Transparent;
            this.BorderBtnPrint.Location = new System.Drawing.Point(3, 509);
            this.BorderBtnPrint.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.BorderBtnPrint.Name = "BorderBtnPrint";
            this.BorderBtnPrint.Size = new System.Drawing.Size(220, 58);
            this.BorderBtnPrint.TabIndex = 99;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tabMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(223, 26);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1671, 965);
            this.pnlMain.TabIndex = 1;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.設定ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1894, 26);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemCloseForm});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.ファイルToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // ToolStripMenuItemCloseForm
            // 
            this.ToolStripMenuItemCloseForm.Name = "ToolStripMenuItemCloseForm";
            this.ToolStripMenuItemCloseForm.Size = new System.Drawing.Size(119, 22);
            this.ToolStripMenuItemCloseForm.Text = "閉じる(&C)";
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemCanType,
            this.ToolStripMenuItemCapType,
            this.ToolStripMenuItemProductCodeMaster,
            this.ToolStripMenuItemNPProductCodeMaster,
            this.ToolStripMenuItemInitialSetting,
            this.ToolStripMenuItemSetting,
            this.ToolStripMenuItemSelectLabel,
            this.ToolStripMenuItemShipping,
            this.ToolStripMenuItemCOMPort,
            this.ToolStripMenuItemCCMSimulator,
            this.ToolStripMenuItemLabelSelection});
            this.設定ToolStripMenuItem.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.設定ToolStripMenuItem.Text = "管理ツール(&M)";
            // 
            // ToolStripMenuItemCanType
            // 
            this.ToolStripMenuItemCanType.Name = "ToolStripMenuItemCanType";
            this.ToolStripMenuItemCanType.Size = new System.Drawing.Size(215, 22);
            this.ToolStripMenuItemCanType.Text = "缶タイプ(&C)";
            // 
            // ToolStripMenuItemCapType
            // 
            this.ToolStripMenuItemCapType.Name = "ToolStripMenuItemCapType";
            this.ToolStripMenuItemCapType.Size = new System.Drawing.Size(215, 22);
            this.ToolStripMenuItemCapType.Text = "キャップタイプ(&P)";
            // 
            // ToolStripMenuItemProductCodeMaster
            // 
            this.ToolStripMenuItemProductCodeMaster.Name = "ToolStripMenuItemProductCodeMaster";
            this.ToolStripMenuItemProductCodeMaster.Size = new System.Drawing.Size(215, 22);
            this.ToolStripMenuItemProductCodeMaster.Text = "商品コードマスタ(&M)";
            // 
            // ToolStripMenuItemNPProductCodeMaster
            // 
            this.ToolStripMenuItemNPProductCodeMaster.Name = "ToolStripMenuItemNPProductCodeMaster";
            this.ToolStripMenuItemNPProductCodeMaster.Size = new System.Drawing.Size(215, 22);
            this.ToolStripMenuItemNPProductCodeMaster.Text = "ＮＰ商品コードマスタ(&N)";
            // 
            // ToolStripMenuItemInitialSetting
            // 
            this.ToolStripMenuItemInitialSetting.Name = "ToolStripMenuItemInitialSetting";
            this.ToolStripMenuItemInitialSetting.Size = new System.Drawing.Size(215, 22);
            this.ToolStripMenuItemInitialSetting.Text = "初期設定(&I)";
            // 
            // ToolStripMenuItemSetting
            // 
            this.ToolStripMenuItemSetting.Name = "ToolStripMenuItemSetting";
            this.ToolStripMenuItemSetting.Size = new System.Drawing.Size(215, 22);
            this.ToolStripMenuItemSetting.Text = "設定(&S)";
            // 
            // ToolStripMenuItemSelectLabel
            // 
            this.ToolStripMenuItemSelectLabel.Name = "ToolStripMenuItemSelectLabel";
            this.ToolStripMenuItemSelectLabel.Size = new System.Drawing.Size(215, 22);
            this.ToolStripMenuItemSelectLabel.Text = "ラベル(&L)";
            // 
            // ToolStripMenuItemShipping
            // 
            this.ToolStripMenuItemShipping.Name = "ToolStripMenuItemShipping";
            this.ToolStripMenuItemShipping.Size = new System.Drawing.Size(215, 22);
            this.ToolStripMenuItemShipping.Text = "出庫(&G)";
            // 
            // ToolStripMenuItemCOMPort
            // 
            this.ToolStripMenuItemCOMPort.Name = "ToolStripMenuItemCOMPort";
            this.ToolStripMenuItemCOMPort.Size = new System.Drawing.Size(215, 22);
            this.ToolStripMenuItemCOMPort.Text = "ＣＯＭポート(&P)";
            // 
            // ToolStripMenuItemCCMSimulator
            // 
            this.ToolStripMenuItemCCMSimulator.Name = "ToolStripMenuItemCCMSimulator";
            this.ToolStripMenuItemCCMSimulator.Size = new System.Drawing.Size(215, 22);
            this.ToolStripMenuItemCCMSimulator.Text = "ＣＣＭシミュレーター(&D)";
            // 
            // ToolStripMenuItemLabelSelection
            // 
            this.ToolStripMenuItemLabelSelection.Name = "ToolStripMenuItemLabelSelection";
            this.ToolStripMenuItemLabelSelection.Size = new System.Drawing.Size(215, 22);
            this.ToolStripMenuItemLabelSelection.Text = "ラベル(仮)";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1894, 991);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlFuncs);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "+";
            this.tabOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GvOrder)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabDetail.ResumeLayout(false);
            this.splitDetail.Panel1.ResumeLayout(false);
            this.splitDetail.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitDetail)).EndInit();
            this.splitDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GvDetail)).EndInit();
            this.pnlDetailItems.ResumeLayout(false);
            this.tabDetailSub.ResumeLayout(false);
            this.tabDetail1.ResumeLayout(false);
            this.tabDetail2.ResumeLayout(false);
            this.tabDetail3.ResumeLayout(false);
            this.tabFormulation.ResumeLayout(false);
            this.splitFormulation.Panel1.ResumeLayout(false);
            this.splitFormulation.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitFormulation)).EndInit();
            this.splitFormulation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GvFormulation)).EndInit();
            this.pnlFormulation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GvWeight)).EndInit();
            this.tabCan.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GvOutWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvWeightDetail)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GvBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvOrderNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitCanMain)).EndInit();
            this.splitCanMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCanLeft)).EndInit();
            this.splitCanLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCanRight)).EndInit();
            this.splitCanRight.ResumeLayout(false);
            this.pnlFuncs.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlColorExplanation.ResumeLayout(false);
            this.pnlColorExplanation.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.Panel pnlFuncs;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlColorExplanation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panLogo;
        private System.Windows.Forms.RadioButton RdoOrderPerson;
        private System.Windows.Forms.RadioButton RdoSortRanking;
        private System.Windows.Forms.RadioButton RdoSortKubun;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCanType;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCapType;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemProductCodeMaster;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNPProductCodeMaster;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemInitialSetting;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSetting;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCOMPort;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCCMSimulator;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLabelSelection;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCloseForm;
        private System.Windows.Forms.Button BtnOrderClose;
        private System.Windows.Forms.Button BtnPrintEmergency;
        private System.Windows.Forms.Button BtnPrintInstructions;
        private System.Windows.Forms.TabPage tabOrder;
        private System.Windows.Forms.DataGridView GvOrder;
        private System.Windows.Forms.TabPage tabDetail;
        private System.Windows.Forms.SplitContainer splitDetail;
        private System.Windows.Forms.Panel pnlDetailItems;
        private System.Windows.Forms.TabControl tabDetailSub;
        private System.Windows.Forms.TabPage tabDetail1;
        private System.Windows.Forms.Button BtnLotRegister;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabDetail2;
        private System.Windows.Forms.TabPage tabDetail3;
        private System.Windows.Forms.TabPage tabFormulation;
        private System.Windows.Forms.SplitContainer splitFormulation;
        private System.Windows.Forms.Panel pnlFormulation;
        private System.Windows.Forms.TabPage tabCan;
        private System.Windows.Forms.SplitContainer splitCanMain;
        private System.Windows.Forms.SplitContainer splitCanLeft;
        private System.Windows.Forms.SplitContainer splitCanRight;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSelectLabel;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemShipping;
        private System.Windows.Forms.Button BtnDecidePerson;
        private System.Windows.Forms.DataGridView GvWeight;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView GvOutWeight;
        private System.Windows.Forms.DataGridView GvWeightDetail;
        private System.Windows.Forms.DataGridView GvBarcode;
        private System.Windows.Forms.DataGridView GvOrderNumber;
        private System.Windows.Forms.Button BtnStatusResume;
        private System.Windows.Forms.Button BtnOrderStart;
        private System.Windows.Forms.Button BtnPrint;
        private NipponPaint.NpCommon.FormControls.LabelTextBox ProductCode;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgDataNumber;
        private NipponPaint.NpCommon.FormControls.LabelTextBox OrderNumber;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgDeliveryDate;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgSalesInCharge;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgTintingDirection;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgDeliveryCode;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgTruckCompanyName_1;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgProductNo;
        private NipponPaint.NpCommon.FormControls.LabelTextBox CcmColorName;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgColorName;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgProductName;
        private NipponPaint.NpCommon.FormControls.LabelTextBox IndexNumber;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TintedColor;
        private NipponPaint.NpCommon.FormControls.LabelTextBox NumberOfCans;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgVolumeCode;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgSampleBack;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgColorSample;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgNote;
        private NipponPaint.NpCommon.FormControls.LabelCodeText HgSupplementalAddition;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgSsShippingDate_1;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgSamplePlates;
        private NipponPaint.NpCommon.FormControls.LabelCodeText HgGlossAddition;
        private NipponPaint.NpCommon.FormControls.LabelCodeText HgCustomerCode;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgTintingPriceRank;
        private NipponPaint.NpCommon.FormControls.LabelTextBox Revision;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgWeight;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TotalWeight;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgOrderInputTime;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgOrderInputDate;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgComments;
        private NipponPaint.NpCommon.FormControls.LabelTextBox FormulaRelease;
        private NipponPaint.NpCommon.FormControls.LabelTextBox PrefillAmount;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgDeliveryPointCode;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgOrderInvoiceId;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgDeliveryTelNo;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgSalesBranchName;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgThemeCode;
        private NipponPaint.NpCommon.FormControls.LabelTextBox MixingSpeed;
        private NipponPaint.NpCommon.FormControls.LabelTextBox Overfilling;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgSumUpKey;
        private NipponPaint.NpCommon.FormControls.LabelTextBox MixingTime;
        private NipponPaint.NpCommon.FormControls.LabelTextBox QualitySample;
        private NipponPaint.NpCommon.FormControls.LabelCodeText CapType;
        private NipponPaint.NpCommon.FormControls.LabelCodeText CanType;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgDeliveryAddressKanji;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgDeliveryNameKanji;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgUnifiedArticleNumber;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgSsShippingDate_2;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgNpcVolumeCode;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgNpcArticleNumber;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgAdditionalNo2;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgAdditionalNo1;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgLineNumber;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgSsCode;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgRfDisplayColors;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgTruckCompanyName_3;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgAskId;
        private NipponPaint.NpCommon.FormControls.LabelTextBox labelTextBox68;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgSsDeliveryKanji;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgSsDeliveryCode;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgDeliveryAreaCode;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgCustomerName;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgPaintKindCode;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgCancel;
        private NipponPaint.NpCommon.FormControls.LabelTextBox HgWaterBorne;
        private NipponPaint.NpCommon.FormControls.LabelTextBox labelTextBox54;
        private NipponPaint.NpCommon.FormControls.LabelTextBox labelTextBox53;
        private NipponPaint.NpCommon.FormControls.LabelTextBox labelTextBox52;
        private NipponPaint.NpCommon.FormControls.LabelTextBox labelTextBox51;
        private NipponPaint.NpCommon.FormControls.LabelTextBox labelTextBox62;
        private NipponPaint.NpCommon.FormControls.LabelTextBox labelTextBox61;
        private NipponPaint.NpCommon.FormControls.LabelTextBox labelTextBox60;
        private NipponPaint.NpCommon.FormControls.LabelTextBox labelTextBox59;
        private NipponPaint.NpCommon.FormControls.LabelTextBox labelTextBox58;
        private NipponPaint.NpCommon.FormControls.LabelTextBox labelTextBox57;
        private NipponPaint.NpCommon.FormControls.LabelTextBox labelTextBox56;
        private NipponPaint.NpCommon.FormControls.LabelTextBox labelTextBox55;
        private NipponPaint.NpCommon.FormControls.LabelTextBox labelTextBox79;
        private NipponPaint.NpCommon.FormControls.LabelTextBox labelTextBox78;
        private NipponPaint.NpCommon.FormControls.LabelTextBox labelTextBox77;
        private NipponPaint.NpCommon.FormControls.LabelTextBox labelTextBox76;
        private NipponPaint.NpCommon.FormControls.LabelTextBox labelTextBox75;
        private NipponPaint.NpCommon.FormControls.LabelTextBox labelTextBox74;
        private NipponPaint.NpCommon.FormControls.LabelTextBox labelTextBox73;
        private NipponPaint.NpCommon.FormControls.LabelTextBox labelTextBox83;
        private NipponPaint.NpCommon.FormControls.LabelTextBox labelTextBox82;
        private NipponPaint.NpCommon.FormControls.LabelTextBox labelTextBox81;
        private NipponPaint.NpCommon.FormControls.LabelTextBox labelTextBox80;
        private NipponPaint.NpCommon.FormControls.LabelTextBox labelTextBox12;
        private NipponPaint.NpCommon.FormControls.LabelTextBox labelTextBox11;
        private NipponPaint.NpCommon.FormControls.LabelTextBox labelTextBox10;
        private NipponPaint.NpCommon.FormControls.LabelTextBox labelTextBox9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton RdoTomorrowAfter;
        private System.Windows.Forms.RadioButton RdoTodayBefore;
        private System.Windows.Forms.RadioButton RdoPreviewAll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatus1;
        private System.Windows.Forms.Label lblStatus5;
        private System.Windows.Forms.Label lblStatus4;
        private System.Windows.Forms.Label lblStatus3;
        private System.Windows.Forms.Label lblStatus2;
        private System.Windows.Forms.Button BtnProcessDetail;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TsmiDecide;
        private System.Windows.Forms.ToolStripMenuItem TsmiOperatorDelete;
        private System.Windows.Forms.ToolStripMenuItem TsmiOrderStart;
        private System.Windows.Forms.ToolStripMenuItem TsmiInstructionPrint;
        private System.Windows.Forms.ToolStripMenuItem TsmiProductLabelPrint;
        private System.Windows.Forms.ToolStripMenuItem TsmiColorLabelPrint;
        private System.Windows.Forms.ToolStripMenuItem TsmiCopyLabelPrint;
        private System.Windows.Forms.ToolStripMenuItem TsmiOrderClose;
        private NpCommon.FormControls.PanelBorder BorderHgTintingDirection;
        private NpCommon.FormControls.PanelBorder BorderHgSamplePlates;
        private NpCommon.FormControls.PanelBorder BorderBtnPrint;
        private System.Windows.Forms.DataGridView GvDetail;
        private System.Windows.Forms.DataGridView GvFormulation;
    }
}

