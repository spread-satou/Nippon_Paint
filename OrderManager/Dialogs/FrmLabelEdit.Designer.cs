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

namespace NipponPaint.OrderManager.Dialogs
{
    partial class FrmLabelEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.GbxMoveG = new System.Windows.Forms.GroupBox();
            this.TxtMoveY = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.TxtMoveX = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.NudMoveFieldID = new NipponPaint.NpCommon.FormControls.LabelNumericUpDown();
            this.TxtMoveCaption = new NipponPaint.NpCommon.FormControls.LabelTextButton();
            this.GbxFixedG = new System.Windows.Forms.GroupBox();
            this.NudFixedFieldID = new NipponPaint.NpCommon.FormControls.LabelNumericUpDown();
            this.CmbFixedGroupID = new NipponPaint.NpCommon.FormControls.LabelDropDown();
            this.TxtFixedCaption = new NipponPaint.NpCommon.FormControls.LabelTextButton();
            this.GbxVariableG = new System.Windows.Forms.GroupBox();
            this.NudVariableFieldID = new NipponPaint.NpCommon.FormControls.LabelNumericUpDown();
            this.TxtVariableCaption = new NipponPaint.NpCommon.FormControls.LabelTextButton();
            this.GbxToxLogo = new System.Windows.Forms.GroupBox();
            this.TxtToxCaption = new NipponPaint.NpCommon.FormControls.LabelTextButton();
            this.ChkToxLogo = new System.Windows.Forms.CheckBox();
            this.GbxFlaLogo = new System.Windows.Forms.GroupBox();
            this.TxtFlaCaption = new NipponPaint.NpCommon.FormControls.LabelTextButton();
            this.ChkFlaLogo = new System.Windows.Forms.CheckBox();
            this.GbxJisLogo = new System.Windows.Forms.GroupBox();
            this.ChkJisLogo = new System.Windows.Forms.CheckBox();
            this.GbxNpLogo = new System.Windows.Forms.GroupBox();
            this.ChkNpLogo = new System.Windows.Forms.CheckBox();
            this.GbxZoom = new System.Windows.Forms.GroupBox();
            this.Rbt40 = new System.Windows.Forms.RadioButton();
            this.Rbt60 = new System.Windows.Forms.RadioButton();
            this.Rbt80 = new System.Windows.Forms.RadioButton();
            this.Rbt100 = new System.Windows.Forms.RadioButton();
            this.GbxLabel = new System.Windows.Forms.GroupBox();
            this.TxtLabel = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GbxMoveG.SuspendLayout();
            this.GbxFixedG.SuspendLayout();
            this.GbxVariableG.SuspendLayout();
            this.GbxToxLogo.SuspendLayout();
            this.GbxFlaLogo.SuspendLayout();
            this.GbxJisLogo.SuspendLayout();
            this.GbxNpLogo.SuspendLayout();
            this.GbxZoom.SuspendLayout();
            this.GbxLabel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1174, 1758);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.BtnClose.Location = new System.Drawing.Point(818, 646);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(169, 50);
            this.BtnClose.TabIndex = 13;
            this.BtnClose.Text = "閉じる";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.BtnSave.Location = new System.Drawing.Point(647, 646);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(169, 50);
            this.BtnSave.TabIndex = 12;
            this.BtnSave.Text = "保存";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnPrint
            // 
            this.BtnPrint.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.BtnPrint.Location = new System.Drawing.Point(475, 646);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(169, 50);
            this.BtnPrint.TabIndex = 11;
            this.BtnPrint.Text = "プリント";
            this.BtnPrint.UseVisualStyleBackColor = true;
            // 
            // GbxMoveG
            // 
            this.GbxMoveG.Controls.Add(this.TxtMoveY);
            this.GbxMoveG.Controls.Add(this.TxtMoveX);
            this.GbxMoveG.Controls.Add(this.NudMoveFieldID);
            this.GbxMoveG.Controls.Add(this.TxtMoveCaption);
            this.GbxMoveG.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.GbxMoveG.Location = new System.Drawing.Point(476, 540);
            this.GbxMoveG.Name = "GbxMoveG";
            this.GbxMoveG.Size = new System.Drawing.Size(510, 100);
            this.GbxMoveG.TabIndex = 10;
            this.GbxMoveG.TabStop = false;
            this.GbxMoveG.Text = "移動可能グループ";
            // 
            // TxtMoveY
            // 
            this.TxtMoveY.DatabaseColumnName = "Position_Y";
            this.TxtMoveY.DataControlName = "TxtData";
            this.TxtMoveY.DataEnabled = true;
            this.TxtMoveY.DataReadOnly = false;
            this.TxtMoveY.DataTextLocation = new System.Drawing.Point(75, 0);
            this.TxtMoveY.DataTextSize = new System.Drawing.Size(69, 30);
            this.TxtMoveY.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtMoveY.Id = null;
            this.TxtMoveY.Label = "";
            this.TxtMoveY.Location = new System.Drawing.Point(308, 30);
            this.TxtMoveY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtMoveY.MaxByteLength = 65535;
            this.TxtMoveY.MaxLength = 0;
            this.TxtMoveY.Name = "TxtMoveY";
            this.TxtMoveY.Size = new System.Drawing.Size(144, 30);
            this.TxtMoveY.TabIndex = 11;
            this.TxtMoveY.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtMoveY.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtMoveY.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtMoveY.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtMoveY.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtMoveY.Title = "Y";
            this.TxtMoveY.TitleControlName = "LblTitle";
            this.TxtMoveY.TitleSize = new System.Drawing.Size(75, 30);
            this.TxtMoveY.Value = "";
            // 
            // TxtMoveX
            // 
            this.TxtMoveX.DatabaseColumnName = "Position_X";
            this.TxtMoveX.DataControlName = "TxtData";
            this.TxtMoveX.DataEnabled = true;
            this.TxtMoveX.DataReadOnly = false;
            this.TxtMoveX.DataTextLocation = new System.Drawing.Point(75, 0);
            this.TxtMoveX.DataTextSize = new System.Drawing.Size(69, 30);
            this.TxtMoveX.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtMoveX.Id = null;
            this.TxtMoveX.Label = "";
            this.TxtMoveX.Location = new System.Drawing.Point(161, 30);
            this.TxtMoveX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtMoveX.MaxByteLength = 65535;
            this.TxtMoveX.MaxLength = 0;
            this.TxtMoveX.Name = "TxtMoveX";
            this.TxtMoveX.Size = new System.Drawing.Size(144, 30);
            this.TxtMoveX.TabIndex = 10;
            this.TxtMoveX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtMoveX.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtMoveX.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtMoveX.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtMoveX.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtMoveX.Title = "X";
            this.TxtMoveX.TitleControlName = "LblTitle";
            this.TxtMoveX.TitleSize = new System.Drawing.Size(75, 30);
            this.TxtMoveX.Value = "";
            // 
            // NudMoveFieldID
            // 
            this.NudMoveFieldID.DatabaseColumnName = "Field_Name";
            this.NudMoveFieldID.DecimalPlaces = 0;
            this.NudMoveFieldID.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NudMoveFieldID.Id = null;
            this.NudMoveFieldID.Location = new System.Drawing.Point(8, 30);
            this.NudMoveFieldID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NudMoveFieldID.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.NudMoveFieldID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudMoveFieldID.Name = "NudMoveFieldID";
            this.NudMoveFieldID.Size = new System.Drawing.Size(150, 30);
            this.NudMoveFieldID.TabIndex = 9;
            this.NudMoveFieldID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NudMoveFieldID.Title = "ﾌｨｰﾙﾄﾞID";
            this.NudMoveFieldID.TitleControlName = "LblTitle";
            this.NudMoveFieldID.TitleSize = new System.Drawing.Size(75, 30);
            this.NudMoveFieldID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TxtMoveCaption
            // 
            this.TxtMoveCaption.BtnLocation = new System.Drawing.Point(444, 0);
            this.TxtMoveCaption.BtnName = "ﾌｫﾝﾄ";
            this.TxtMoveCaption.BtnSize = new System.Drawing.Size(50, 30);
            this.TxtMoveCaption.DatabaseColumnName = "Caption";
            this.TxtMoveCaption.DataControlName = "TxtData";
            this.TxtMoveCaption.DataTextLocation = new System.Drawing.Point(75, 0);
            this.TxtMoveCaption.DataTextSize = new System.Drawing.Size(369, 30);
            this.TxtMoveCaption.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.TxtMoveCaption.Id = null;
            this.TxtMoveCaption.Location = new System.Drawing.Point(8, 62);
            this.TxtMoveCaption.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtMoveCaption.Name = "TxtMoveCaption";
            this.TxtMoveCaption.Size = new System.Drawing.Size(494, 30);
            this.TxtMoveCaption.TabIndex = 0;
            this.TxtMoveCaption.Title = "ﾒｯｾｰｼﾞ";
            this.TxtMoveCaption.TitleControlName = "LblTitle";
            this.TxtMoveCaption.TitleSize = new System.Drawing.Size(75, 30);
            this.TxtMoveCaption.Value = "";
            // 
            // GbxFixedG
            // 
            this.GbxFixedG.Controls.Add(this.NudFixedFieldID);
            this.GbxFixedG.Controls.Add(this.CmbFixedGroupID);
            this.GbxFixedG.Controls.Add(this.TxtFixedCaption);
            this.GbxFixedG.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.GbxFixedG.Location = new System.Drawing.Point(476, 440);
            this.GbxFixedG.Name = "GbxFixedG";
            this.GbxFixedG.Size = new System.Drawing.Size(510, 100);
            this.GbxFixedG.TabIndex = 9;
            this.GbxFixedG.TabStop = false;
            this.GbxFixedG.Text = "固定グループ";
            // 
            // NudFixedFieldID
            // 
            this.NudFixedFieldID.DatabaseColumnName = "Field_Name";
            this.NudFixedFieldID.DecimalPlaces = 0;
            this.NudFixedFieldID.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NudFixedFieldID.Id = null;
            this.NudFixedFieldID.Location = new System.Drawing.Point(161, 30);
            this.NudFixedFieldID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NudFixedFieldID.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.NudFixedFieldID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudFixedFieldID.Name = "NudFixedFieldID";
            this.NudFixedFieldID.Size = new System.Drawing.Size(150, 30);
            this.NudFixedFieldID.TabIndex = 8;
            this.NudFixedFieldID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NudFixedFieldID.Title = "ﾌｨｰﾙﾄﾞID";
            this.NudFixedFieldID.TitleControlName = "LblTitle";
            this.NudFixedFieldID.TitleSize = new System.Drawing.Size(75, 30);
            this.NudFixedFieldID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CmbFixedGroupID
            // 
            this.CmbFixedGroupID.DatabaseColumnName = "Field_Name";
            this.CmbFixedGroupID.DisplayMemberField = "";
            this.CmbFixedGroupID.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CmbFixedGroupID.Id = null;
            this.CmbFixedGroupID.Location = new System.Drawing.Point(8, 30);
            this.CmbFixedGroupID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CmbFixedGroupID.Name = "CmbFixedGroupID";
            this.CmbFixedGroupID.Size = new System.Drawing.Size(150, 31);
            this.CmbFixedGroupID.TabIndex = 3;
            this.CmbFixedGroupID.TableName = "";
            this.CmbFixedGroupID.Title = "ｸﾞﾙｰﾌﾟID";
            this.CmbFixedGroupID.TitleControlName = "LblTitle";
            this.CmbFixedGroupID.TitleSize = new System.Drawing.Size(75, 31);
            this.CmbFixedGroupID.ValueMemberField = "";
            // 
            // TxtFixedCaption
            // 
            this.TxtFixedCaption.BtnLocation = new System.Drawing.Point(444, 0);
            this.TxtFixedCaption.BtnName = "ﾌｫﾝﾄ";
            this.TxtFixedCaption.BtnSize = new System.Drawing.Size(50, 30);
            this.TxtFixedCaption.DatabaseColumnName = "Caption";
            this.TxtFixedCaption.DataControlName = "TxtData";
            this.TxtFixedCaption.DataTextLocation = new System.Drawing.Point(75, 0);
            this.TxtFixedCaption.DataTextSize = new System.Drawing.Size(369, 30);
            this.TxtFixedCaption.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.TxtFixedCaption.Id = null;
            this.TxtFixedCaption.Location = new System.Drawing.Point(8, 62);
            this.TxtFixedCaption.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtFixedCaption.Name = "TxtFixedCaption";
            this.TxtFixedCaption.Size = new System.Drawing.Size(494, 30);
            this.TxtFixedCaption.TabIndex = 0;
            this.TxtFixedCaption.Title = "ﾒｯｾｰｼﾞ";
            this.TxtFixedCaption.TitleControlName = "LblTitle";
            this.TxtFixedCaption.TitleSize = new System.Drawing.Size(75, 30);
            this.TxtFixedCaption.Value = "";
            // 
            // GbxVariableG
            // 
            this.GbxVariableG.Controls.Add(this.NudVariableFieldID);
            this.GbxVariableG.Controls.Add(this.TxtVariableCaption);
            this.GbxVariableG.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.GbxVariableG.Location = new System.Drawing.Point(476, 340);
            this.GbxVariableG.Name = "GbxVariableG";
            this.GbxVariableG.Size = new System.Drawing.Size(510, 100);
            this.GbxVariableG.TabIndex = 8;
            this.GbxVariableG.TabStop = false;
            this.GbxVariableG.Text = "Variable fields";
            // 
            // NudVariableFieldID
            // 
            this.NudVariableFieldID.DatabaseColumnName = "Field_Name";
            this.NudVariableFieldID.DecimalPlaces = 0;
            this.NudVariableFieldID.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NudVariableFieldID.Id = null;
            this.NudVariableFieldID.Location = new System.Drawing.Point(8, 30);
            this.NudVariableFieldID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NudVariableFieldID.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.NudVariableFieldID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudVariableFieldID.Name = "NudVariableFieldID";
            this.NudVariableFieldID.Size = new System.Drawing.Size(150, 30);
            this.NudVariableFieldID.TabIndex = 3;
            this.NudVariableFieldID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NudVariableFieldID.Title = "ﾌｨｰﾙﾄﾞID";
            this.NudVariableFieldID.TitleControlName = "LblTitle";
            this.NudVariableFieldID.TitleSize = new System.Drawing.Size(75, 30);
            this.NudVariableFieldID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TxtVariableCaption
            // 
            this.TxtVariableCaption.BtnLocation = new System.Drawing.Point(444, 0);
            this.TxtVariableCaption.BtnName = "ﾌｫﾝﾄ";
            this.TxtVariableCaption.BtnSize = new System.Drawing.Size(50, 30);
            this.TxtVariableCaption.DatabaseColumnName = "Caption";
            this.TxtVariableCaption.DataControlName = "TxtData";
            this.TxtVariableCaption.DataTextLocation = new System.Drawing.Point(75, 0);
            this.TxtVariableCaption.DataTextSize = new System.Drawing.Size(369, 30);
            this.TxtVariableCaption.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.TxtVariableCaption.Id = null;
            this.TxtVariableCaption.Location = new System.Drawing.Point(8, 62);
            this.TxtVariableCaption.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtVariableCaption.Name = "TxtVariableCaption";
            this.TxtVariableCaption.Size = new System.Drawing.Size(494, 30);
            this.TxtVariableCaption.TabIndex = 0;
            this.TxtVariableCaption.Title = "ﾒｯｾｰｼﾞ";
            this.TxtVariableCaption.TitleControlName = "LblTitle";
            this.TxtVariableCaption.TitleSize = new System.Drawing.Size(75, 30);
            this.TxtVariableCaption.Value = "";
            // 
            // GbxToxLogo
            // 
            this.GbxToxLogo.Controls.Add(this.TxtToxCaption);
            this.GbxToxLogo.Controls.Add(this.ChkToxLogo);
            this.GbxToxLogo.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.GbxToxLogo.Location = new System.Drawing.Point(734, 210);
            this.GbxToxLogo.Name = "GbxToxLogo";
            this.GbxToxLogo.Size = new System.Drawing.Size(252, 130);
            this.GbxToxLogo.TabIndex = 7;
            this.GbxToxLogo.TabStop = false;
            this.GbxToxLogo.Text = "可変フィールド";
            // 
            // TxtToxCaption
            // 
            this.TxtToxCaption.BtnLocation = new System.Drawing.Point(186, 30);
            this.TxtToxCaption.BtnName = "ﾌｫﾝﾄ";
            this.TxtToxCaption.BtnSize = new System.Drawing.Size(50, 30);
            this.TxtToxCaption.DatabaseColumnName = "Caption";
            this.TxtToxCaption.DataControlName = "TxtData";
            this.TxtToxCaption.DataTextLocation = new System.Drawing.Point(0, 30);
            this.TxtToxCaption.DataTextSize = new System.Drawing.Size(185, 30);
            this.TxtToxCaption.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.TxtToxCaption.Id = null;
            this.TxtToxCaption.Location = new System.Drawing.Point(8, 60);
            this.TxtToxCaption.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtToxCaption.Name = "TxtToxCaption";
            this.TxtToxCaption.Size = new System.Drawing.Size(236, 60);
            this.TxtToxCaption.TabIndex = 1;
            this.TxtToxCaption.Title = "ﾒｯｾｰｼﾞ";
            this.TxtToxCaption.TitleControlName = "LblTitle";
            this.TxtToxCaption.TitleSize = new System.Drawing.Size(75, 30);
            this.TxtToxCaption.Value = "";
            // 
            // ChkToxLogo
            // 
            this.ChkToxLogo.AutoSize = true;
            this.ChkToxLogo.Location = new System.Drawing.Point(8, 30);
            this.ChkToxLogo.Name = "ChkToxLogo";
            this.ChkToxLogo.Size = new System.Drawing.Size(119, 27);
            this.ChkToxLogo.TabIndex = 0;
            this.ChkToxLogo.Text = "有害性マーク";
            this.ChkToxLogo.UseVisualStyleBackColor = true;
            // 
            // GbxFlaLogo
            // 
            this.GbxFlaLogo.Controls.Add(this.TxtFlaCaption);
            this.GbxFlaLogo.Controls.Add(this.ChkFlaLogo);
            this.GbxFlaLogo.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.GbxFlaLogo.Location = new System.Drawing.Point(476, 210);
            this.GbxFlaLogo.Name = "GbxFlaLogo";
            this.GbxFlaLogo.Size = new System.Drawing.Size(253, 130);
            this.GbxFlaLogo.TabIndex = 6;
            this.GbxFlaLogo.TabStop = false;
            this.GbxFlaLogo.Text = "引火性";
            // 
            // TxtFlaCaption
            // 
            this.TxtFlaCaption.BtnLocation = new System.Drawing.Point(186, 30);
            this.TxtFlaCaption.BtnName = "ﾌｫﾝﾄ";
            this.TxtFlaCaption.BtnSize = new System.Drawing.Size(50, 30);
            this.TxtFlaCaption.DatabaseColumnName = "Caption";
            this.TxtFlaCaption.DataControlName = "TxtData";
            this.TxtFlaCaption.DataTextLocation = new System.Drawing.Point(0, 30);
            this.TxtFlaCaption.DataTextSize = new System.Drawing.Size(185, 30);
            this.TxtFlaCaption.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.TxtFlaCaption.Id = null;
            this.TxtFlaCaption.Location = new System.Drawing.Point(8, 60);
            this.TxtFlaCaption.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtFlaCaption.Name = "TxtFlaCaption";
            this.TxtFlaCaption.Size = new System.Drawing.Size(236, 60);
            this.TxtFlaCaption.TabIndex = 0;
            this.TxtFlaCaption.Title = "ﾒｯｾｰｼﾞ";
            this.TxtFlaCaption.TitleControlName = "LblTitle";
            this.TxtFlaCaption.TitleSize = new System.Drawing.Size(75, 30);
            this.TxtFlaCaption.Value = "";
            // 
            // ChkFlaLogo
            // 
            this.ChkFlaLogo.AutoSize = true;
            this.ChkFlaLogo.Location = new System.Drawing.Point(8, 30);
            this.ChkFlaLogo.Name = "ChkFlaLogo";
            this.ChkFlaLogo.Size = new System.Drawing.Size(119, 27);
            this.ChkFlaLogo.TabIndex = 0;
            this.ChkFlaLogo.Text = "引火性マーク";
            this.ChkFlaLogo.UseVisualStyleBackColor = true;
            // 
            // GbxJisLogo
            // 
            this.GbxJisLogo.Controls.Add(this.ChkJisLogo);
            this.GbxJisLogo.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.GbxJisLogo.Location = new System.Drawing.Point(734, 140);
            this.GbxJisLogo.Name = "GbxJisLogo";
            this.GbxJisLogo.Size = new System.Drawing.Size(252, 70);
            this.GbxJisLogo.TabIndex = 5;
            this.GbxJisLogo.TabStop = false;
            this.GbxJisLogo.Text = "JISマーク";
            // 
            // ChkJisLogo
            // 
            this.ChkJisLogo.AutoSize = true;
            this.ChkJisLogo.Location = new System.Drawing.Point(8, 30);
            this.ChkJisLogo.Name = "ChkJisLogo";
            this.ChkJisLogo.Size = new System.Drawing.Size(97, 27);
            this.ChkJisLogo.TabIndex = 0;
            this.ChkJisLogo.Text = "JISマーク";
            this.ChkJisLogo.UseVisualStyleBackColor = true;
            // 
            // GbxNpLogo
            // 
            this.GbxNpLogo.Controls.Add(this.ChkNpLogo);
            this.GbxNpLogo.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.GbxNpLogo.Location = new System.Drawing.Point(476, 140);
            this.GbxNpLogo.Name = "GbxNpLogo";
            this.GbxNpLogo.Size = new System.Drawing.Size(253, 70);
            this.GbxNpLogo.TabIndex = 4;
            this.GbxNpLogo.TabStop = false;
            this.GbxNpLogo.Text = "日本ペイントロゴ";
            // 
            // ChkNpLogo
            // 
            this.ChkNpLogo.AutoSize = true;
            this.ChkNpLogo.Location = new System.Drawing.Point(8, 30);
            this.ChkNpLogo.Name = "ChkNpLogo";
            this.ChkNpLogo.Size = new System.Drawing.Size(164, 27);
            this.ChkNpLogo.TabIndex = 0;
            this.ChkNpLogo.Text = "日本ペイント　ロゴ";
            this.ChkNpLogo.UseVisualStyleBackColor = true;
            // 
            // GbxZoom
            // 
            this.GbxZoom.Controls.Add(this.Rbt40);
            this.GbxZoom.Controls.Add(this.Rbt60);
            this.GbxZoom.Controls.Add(this.Rbt80);
            this.GbxZoom.Controls.Add(this.Rbt100);
            this.GbxZoom.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.GbxZoom.Location = new System.Drawing.Point(476, 70);
            this.GbxZoom.Name = "GbxZoom";
            this.GbxZoom.Size = new System.Drawing.Size(510, 70);
            this.GbxZoom.TabIndex = 3;
            this.GbxZoom.TabStop = false;
            this.GbxZoom.Text = "ズーム";
            // 
            // Rbt40
            // 
            this.Rbt40.AutoSize = true;
            this.Rbt40.Location = new System.Drawing.Point(371, 30);
            this.Rbt40.Name = "Rbt40";
            this.Rbt40.Size = new System.Drawing.Size(61, 27);
            this.Rbt40.TabIndex = 3;
            this.Rbt40.TabStop = true;
            this.Rbt40.Text = "40%";
            this.Rbt40.UseVisualStyleBackColor = true;
            // 
            // Rbt60
            // 
            this.Rbt60.AutoSize = true;
            this.Rbt60.Location = new System.Drawing.Point(247, 29);
            this.Rbt60.Name = "Rbt60";
            this.Rbt60.Size = new System.Drawing.Size(61, 27);
            this.Rbt60.TabIndex = 2;
            this.Rbt60.TabStop = true;
            this.Rbt60.Text = "60%";
            this.Rbt60.UseVisualStyleBackColor = true;
            // 
            // Rbt80
            // 
            this.Rbt80.AutoSize = true;
            this.Rbt80.Location = new System.Drawing.Point(124, 29);
            this.Rbt80.Name = "Rbt80";
            this.Rbt80.Size = new System.Drawing.Size(61, 27);
            this.Rbt80.TabIndex = 1;
            this.Rbt80.TabStop = true;
            this.Rbt80.Text = "80%";
            this.Rbt80.UseVisualStyleBackColor = true;
            // 
            // Rbt100
            // 
            this.Rbt100.AutoSize = true;
            this.Rbt100.Location = new System.Drawing.Point(8, 30);
            this.Rbt100.Name = "Rbt100";
            this.Rbt100.Size = new System.Drawing.Size(70, 27);
            this.Rbt100.TabIndex = 0;
            this.Rbt100.TabStop = true;
            this.Rbt100.Text = "100%";
            this.Rbt100.UseVisualStyleBackColor = true;
            // 
            // GbxLabel
            // 
            this.GbxLabel.Controls.Add(this.TxtLabel);
            this.GbxLabel.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.GbxLabel.Location = new System.Drawing.Point(476, 0);
            this.GbxLabel.Name = "GbxLabel";
            this.GbxLabel.Size = new System.Drawing.Size(510, 70);
            this.GbxLabel.TabIndex = 0;
            this.GbxLabel.TabStop = false;
            this.GbxLabel.Text = "ラベル";
            // 
            // TxtLabel
            // 
            this.TxtLabel.DatabaseColumnName = "Label_Description";
            this.TxtLabel.DataControlName = "TxtData";
            this.TxtLabel.DataEnabled = true;
            this.TxtLabel.DataReadOnly = false;
            this.TxtLabel.DataTextLocation = new System.Drawing.Point(75, 0);
            this.TxtLabel.DataTextSize = new System.Drawing.Size(419, 30);
            this.TxtLabel.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtLabel.Id = null;
            this.TxtLabel.Label = "";
            this.TxtLabel.Location = new System.Drawing.Point(9, 30);
            this.TxtLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtLabel.MaxByteLength = 65535;
            this.TxtLabel.MaxLength = 0;
            this.TxtLabel.Name = "TxtLabel";
            this.TxtLabel.Size = new System.Drawing.Size(494, 30);
            this.TxtLabel.TabIndex = 2;
            this.TxtLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtLabel.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtLabel.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtLabel.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtLabel.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtLabel.Title = "ﾗﾍﾞﾙ詳細";
            this.TxtLabel.TitleControlName = "LblTitle";
            this.TxtLabel.TitleSize = new System.Drawing.Size(75, 30);
            this.TxtLabel.Value = "";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 703);
            this.panel1.TabIndex = 20;
            // 
            // FrmLabelEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 703);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.GbxMoveG);
            this.Controls.Add(this.GbxFixedG);
            this.Controls.Add(this.GbxVariableG);
            this.Controls.Add(this.GbxToxLogo);
            this.Controls.Add(this.GbxFlaLogo);
            this.Controls.Add(this.GbxJisLogo);
            this.Controls.Add(this.GbxNpLogo);
            this.Controls.Add(this.GbxZoom);
            this.Controls.Add(this.GbxLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmLabelEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ラベル";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GbxMoveG.ResumeLayout(false);
            this.GbxFixedG.ResumeLayout(false);
            this.GbxVariableG.ResumeLayout(false);
            this.GbxToxLogo.ResumeLayout(false);
            this.GbxToxLogo.PerformLayout();
            this.GbxFlaLogo.ResumeLayout(false);
            this.GbxFlaLogo.PerformLayout();
            this.GbxJisLogo.ResumeLayout(false);
            this.GbxJisLogo.PerformLayout();
            this.GbxNpLogo.ResumeLayout(false);
            this.GbxNpLogo.PerformLayout();
            this.GbxZoom.ResumeLayout(false);
            this.GbxZoom.PerformLayout();
            this.GbxLabel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxLabel;
        private NpCommon.FormControls.LabelTextButton TxtFlaCaption;
        private System.Windows.Forms.GroupBox GbxZoom;
        private System.Windows.Forms.RadioButton Rbt40;
        private System.Windows.Forms.RadioButton Rbt60;
        private System.Windows.Forms.RadioButton Rbt80;
        private System.Windows.Forms.RadioButton Rbt100;
        private System.Windows.Forms.GroupBox GbxNpLogo;
        private System.Windows.Forms.CheckBox ChkNpLogo;
        private System.Windows.Forms.GroupBox GbxJisLogo;
        private System.Windows.Forms.CheckBox ChkJisLogo;
        private System.Windows.Forms.GroupBox GbxToxLogo;
        private System.Windows.Forms.CheckBox ChkToxLogo;
        private System.Windows.Forms.GroupBox GbxFlaLogo;
        private System.Windows.Forms.CheckBox ChkFlaLogo;
        private System.Windows.Forms.GroupBox GbxVariableG;
        private NpCommon.FormControls.LabelTextButton TxtVariableCaption;
        private System.Windows.Forms.GroupBox GbxFixedG;
        private NpCommon.FormControls.LabelTextButton TxtFixedCaption;
        private System.Windows.Forms.GroupBox GbxMoveG;
        private NpCommon.FormControls.LabelTextButton TxtMoveCaption;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnClose;
        private NpCommon.FormControls.LabelTextButton TxtToxCaption;
        private NpCommon.FormControls.LabelTextBox TxtLabel;
        private NpCommon.FormControls.LabelDropDown CmbFixedGroupID;
        private NpCommon.FormControls.LabelNumericUpDown NudVariableFieldID;
        private NpCommon.FormControls.LabelNumericUpDown NudFixedFieldID;
        private NpCommon.FormControls.LabelNumericUpDown NudMoveFieldID;
        private NpCommon.FormControls.LabelTextBox TxtMoveX;
        private NpCommon.FormControls.LabelTextBox TxtMoveY;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}