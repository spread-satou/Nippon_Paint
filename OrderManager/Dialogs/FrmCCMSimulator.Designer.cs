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
    partial class FrmCCMSimulator
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
            this.GrpBoxPutCan = new System.Windows.Forms.GroupBox();
            this.ChkFixedCan = new System.Windows.Forms.RadioButton();
            this.ChkFilledCan = new System.Windows.Forms.RadioButton();
            this.ChkEmptyCan = new System.Windows.Forms.RadioButton();
            this.GrpBoxCorrection = new System.Windows.Forms.GroupBox();
            this.NumUpDownCorrection = new NipponPaint.NpCommon.FormControls.LabelNumericUpDown();
            this.DrpProductCodeLeft = new NipponPaint.NpCommon.FormControls.LabelDropDown();
            this.GrpInfo = new System.Windows.Forms.GroupBox();
            this.DrpProductCodeRight = new NipponPaint.NpCommon.FormControls.ComboBoxEx();
            this.TxtLine = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.TxtIndexNumber = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.TxtColorFileName = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.TxtPaintName = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.BtnToRight = new System.Windows.Forms.Button();
            this.BtnToLeft = new System.Windows.Forms.Button();
            this.TxtKanjiColorName = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.GrpBoxBase = new System.Windows.Forms.GroupBox();
            this.DrpBaseSelect = new NipponPaint.NpCommon.FormControls.ComboBoxEx();
            this.TxtBaseValue = new System.Windows.Forms.TextBox();
            this.GrpBoxLabel = new System.Windows.Forms.GroupBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TxtCSAreaCode = new System.Windows.Forms.TextBox();
            this.LblCSAreaCode = new System.Windows.Forms.Label();
            this.NumUpDownLabel = new NipponPaint.NpCommon.FormControls.LabelNumericUpDown();
            this.BtnColorNamePrint = new System.Windows.Forms.Button();
            this.GrpBoxButton = new System.Windows.Forms.GroupBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnCCMDataSend = new System.Windows.Forms.Button();
            this.GrpBoxColorant = new System.Windows.Forms.GroupBox();
            this.DrpColoarantSelect10 = new NipponPaint.NpCommon.FormControls.ComboBoxEx();
            this.DrpColoarantSelect9 = new NipponPaint.NpCommon.FormControls.ComboBoxEx();
            this.DrpColoarantSelect8 = new NipponPaint.NpCommon.FormControls.ComboBoxEx();
            this.DrpColoarantSelect7 = new NipponPaint.NpCommon.FormControls.ComboBoxEx();
            this.DrpColoarantSelect6 = new NipponPaint.NpCommon.FormControls.ComboBoxEx();
            this.DrpColoarantSelect5 = new NipponPaint.NpCommon.FormControls.ComboBoxEx();
            this.DrpColoarantSelect4 = new NipponPaint.NpCommon.FormControls.ComboBoxEx();
            this.DrpColoarantSelect3 = new NipponPaint.NpCommon.FormControls.ComboBoxEx();
            this.DrpColoarantSelect2 = new NipponPaint.NpCommon.FormControls.ComboBoxEx();
            this.DrpColoarantSelect1 = new NipponPaint.NpCommon.FormControls.ComboBoxEx();
            this.TxtColoarantValue2 = new System.Windows.Forms.TextBox();
            this.TxtColoarantValue3 = new System.Windows.Forms.TextBox();
            this.TxtColoarantValue4 = new System.Windows.Forms.TextBox();
            this.TxtColoarantValue7 = new System.Windows.Forms.TextBox();
            this.TxtColoarantValue6 = new System.Windows.Forms.TextBox();
            this.TxtColoarantValue8 = new System.Windows.Forms.TextBox();
            this.TxtColoarantValue9 = new System.Windows.Forms.TextBox();
            this.TxtColoarantValue10 = new System.Windows.Forms.TextBox();
            this.TxtColoarantValue5 = new System.Windows.Forms.TextBox();
            this.TxtColoarantValue1 = new System.Windows.Forms.TextBox();
            this.GrpBoxPutCan.SuspendLayout();
            this.GrpBoxCorrection.SuspendLayout();
            this.GrpInfo.SuspendLayout();
            this.GrpBoxBase.SuspendLayout();
            this.GrpBoxLabel.SuspendLayout();
            this.GrpBoxButton.SuspendLayout();
            this.GrpBoxColorant.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBoxPutCan
            // 
            this.GrpBoxPutCan.Controls.Add(this.ChkFixedCan);
            this.GrpBoxPutCan.Controls.Add(this.ChkFilledCan);
            this.GrpBoxPutCan.Controls.Add(this.ChkEmptyCan);
            this.GrpBoxPutCan.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GrpBoxPutCan.Location = new System.Drawing.Point(12, 12);
            this.GrpBoxPutCan.Name = "GrpBoxPutCan";
            this.GrpBoxPutCan.Size = new System.Drawing.Size(305, 215);
            this.GrpBoxPutCan.TabIndex = 1;
            this.GrpBoxPutCan.TabStop = false;
            this.GrpBoxPutCan.Text = "投入缶の種類";
            // 
            // ChkFixedCan
            // 
            this.ChkFixedCan.AutoSize = true;
            this.ChkFixedCan.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ChkFixedCan.Location = new System.Drawing.Point(6, 97);
            this.ChkFixedCan.Name = "ChkFixedCan";
            this.ChkFixedCan.Size = new System.Drawing.Size(97, 27);
            this.ChkFixedCan.TabIndex = 6;
            this.ChkFixedCan.Text = "修正缶(&X)";
            this.ChkFixedCan.UseVisualStyleBackColor = true;
            // 
            // ChkFilledCan
            // 
            this.ChkFilledCan.AutoSize = true;
            this.ChkFilledCan.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ChkFilledCan.Location = new System.Drawing.Point(6, 64);
            this.ChkFilledCan.Name = "ChkFilledCan";
            this.ChkFilledCan.Size = new System.Drawing.Size(96, 27);
            this.ChkFilledCan.TabIndex = 5;
            this.ChkFilledCan.Text = "充填缶(&F)";
            this.ChkFilledCan.UseVisualStyleBackColor = true;
            // 
            // ChkEmptyCan
            // 
            this.ChkEmptyCan.AutoSize = true;
            this.ChkEmptyCan.Checked = true;
            this.ChkEmptyCan.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ChkEmptyCan.Location = new System.Drawing.Point(6, 31);
            this.ChkEmptyCan.Name = "ChkEmptyCan";
            this.ChkEmptyCan.Size = new System.Drawing.Size(81, 27);
            this.ChkEmptyCan.TabIndex = 4;
            this.ChkEmptyCan.TabStop = true;
            this.ChkEmptyCan.Text = "空缶(&E)";
            this.ChkEmptyCan.UseVisualStyleBackColor = true;
            // 
            // GrpBoxCorrection
            // 
            this.GrpBoxCorrection.Controls.Add(this.NumUpDownCorrection);
            this.GrpBoxCorrection.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GrpBoxCorrection.Location = new System.Drawing.Point(12, 227);
            this.GrpBoxCorrection.Name = "GrpBoxCorrection";
            this.GrpBoxCorrection.Size = new System.Drawing.Size(305, 75);
            this.GrpBoxCorrection.TabIndex = 7;
            this.GrpBoxCorrection.TabStop = false;
            this.GrpBoxCorrection.Text = "補正";
            // 
            // NumUpDownCorrection
            // 
            this.NumUpDownCorrection.DatabaseColumnName = "";
            this.NumUpDownCorrection.DecimalPlaces = 0;
            this.NumUpDownCorrection.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NumUpDownCorrection.Id = null;
            this.NumUpDownCorrection.Location = new System.Drawing.Point(6, 31);
            this.NumUpDownCorrection.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NumUpDownCorrection.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumUpDownCorrection.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumUpDownCorrection.Name = "NumUpDownCorrection";
            this.NumUpDownCorrection.Size = new System.Drawing.Size(293, 30);
            this.NumUpDownCorrection.TabIndex = 92;
            this.NumUpDownCorrection.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NumUpDownCorrection.TextBackColor = System.Drawing.SystemColors.Window;
            this.NumUpDownCorrection.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.NumUpDownCorrection.Title = "補正(&R)";
            this.NumUpDownCorrection.TitleControlName = "lblTitle";
            this.NumUpDownCorrection.TitleSize = new System.Drawing.Size(154, 30);
            this.NumUpDownCorrection.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // DrpProductCodeLeft
            // 
            this.DrpProductCodeLeft.DatabaseColumnName = "";
            this.DrpProductCodeLeft.DisplayMemberField = "";
            this.DrpProductCodeLeft.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DrpProductCodeLeft.Id = null;
            this.DrpProductCodeLeft.Location = new System.Drawing.Point(6, 101);
            this.DrpProductCodeLeft.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DrpProductCodeLeft.Name = "DrpProductCodeLeft";
            this.DrpProductCodeLeft.Size = new System.Drawing.Size(292, 31);
            this.DrpProductCodeLeft.TabIndex = 94;
            this.DrpProductCodeLeft.TableName = "";
            this.DrpProductCodeLeft.TextBackColor = System.Drawing.SystemColors.Window;
            this.DrpProductCodeLeft.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.DrpProductCodeLeft.Title = "製品コード(&P)";
            this.DrpProductCodeLeft.TitleControlName = "lblTitle";
            this.DrpProductCodeLeft.TitleSize = new System.Drawing.Size(154, 31);
            this.DrpProductCodeLeft.ValueMemberField = "";
            // 
            // GrpInfo
            // 
            this.GrpInfo.Controls.Add(this.DrpProductCodeRight);
            this.GrpInfo.Controls.Add(this.TxtLine);
            this.GrpInfo.Controls.Add(this.TxtIndexNumber);
            this.GrpInfo.Controls.Add(this.TxtColorFileName);
            this.GrpInfo.Controls.Add(this.TxtPaintName);
            this.GrpInfo.Controls.Add(this.BtnToRight);
            this.GrpInfo.Controls.Add(this.BtnToLeft);
            this.GrpInfo.Controls.Add(this.TxtKanjiColorName);
            this.GrpInfo.Controls.Add(this.DrpProductCodeLeft);
            this.GrpInfo.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GrpInfo.Location = new System.Drawing.Point(337, 12);
            this.GrpInfo.Name = "GrpInfo";
            this.GrpInfo.Size = new System.Drawing.Size(792, 215);
            this.GrpInfo.TabIndex = 7;
            this.GrpInfo.TabStop = false;
            this.GrpInfo.Text = "一般情報";
            this.GrpInfo.Enter += new System.EventHandler(this.GrpInfo_Enter);
            // 
            // DrpProductCodeRight
            // 
            this.DrpProductCodeRight.BackColor = System.Drawing.SystemColors.WindowText;
            this.DrpProductCodeRight.BorderColor = System.Drawing.Color.Silver;
            this.DrpProductCodeRight.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.DrpProductCodeRight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrpProductCodeRight.DropDownWidth = 138;
            this.DrpProductCodeRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrpProductCodeRight.ForeColor = System.Drawing.SystemColors.Window;
            this.DrpProductCodeRight.FormattingEnabled = true;
            this.DrpProductCodeRight.IntegralHeight = false;
            this.DrpProductCodeRight.Location = new System.Drawing.Point(298, 101);
            this.DrpProductCodeRight.Name = "DrpProductCodeRight";
            this.DrpProductCodeRight.Size = new System.Drawing.Size(138, 31);
            this.DrpProductCodeRight.TabIndex = 94;
            // 
            // TxtLine
            // 
            this.TxtLine.DatabaseColumnName = "";
            this.TxtLine.DataControlName = "txtData";
            this.TxtLine.DataEnabled = true;
            this.TxtLine.DataReadOnly = false;
            this.TxtLine.DataTextLocation = new System.Drawing.Point(190, 0);
            this.TxtLine.DataTextSize = new System.Drawing.Size(529, 30);
            this.TxtLine.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtLine.Id = null;
            this.TxtLine.Label = "";
            this.TxtLine.Location = new System.Drawing.Point(6, 171);
            this.TxtLine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtLine.MaxByteLength = 65535;
            this.TxtLine.MaxLength = 0;
            this.TxtLine.Name = "TxtLine";
            this.TxtLine.Size = new System.Drawing.Size(719, 30);
            this.TxtLine.TabIndex = 102;
            this.TxtLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtLine.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtLine.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtLine.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtLine.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtLine.Title = "ライン(&L)";
            this.TxtLine.TitleControlName = "lblTitle";
            this.TxtLine.TitleSize = new System.Drawing.Size(190, 30);
            this.TxtLine.Value = "";
            // 
            // TxtIndexNumber
            // 
            this.TxtIndexNumber.DatabaseColumnName = "";
            this.TxtIndexNumber.DataControlName = "txtData";
            this.TxtIndexNumber.DataEnabled = true;
            this.TxtIndexNumber.DataReadOnly = false;
            this.TxtIndexNumber.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtIndexNumber.DataTextSize = new System.Drawing.Size(139, 30);
            this.TxtIndexNumber.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtIndexNumber.Id = null;
            this.TxtIndexNumber.Label = "";
            this.TxtIndexNumber.Location = new System.Drawing.Point(303, 136);
            this.TxtIndexNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtIndexNumber.MaxByteLength = 65535;
            this.TxtIndexNumber.MaxLength = 0;
            this.TxtIndexNumber.Name = "TxtIndexNumber";
            this.TxtIndexNumber.Size = new System.Drawing.Size(293, 30);
            this.TxtIndexNumber.TabIndex = 101;
            this.TxtIndexNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtIndexNumber.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtIndexNumber.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtIndexNumber.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtIndexNumber.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtIndexNumber.Title = "目次番号(&N)";
            this.TxtIndexNumber.TitleControlName = "lblTitle";
            this.TxtIndexNumber.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtIndexNumber.Value = "";
            // 
            // TxtColorFileName
            // 
            this.TxtColorFileName.DatabaseColumnName = "";
            this.TxtColorFileName.DataControlName = "txtData";
            this.TxtColorFileName.DataEnabled = true;
            this.TxtColorFileName.DataReadOnly = false;
            this.TxtColorFileName.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtColorFileName.DataTextSize = new System.Drawing.Size(139, 30);
            this.TxtColorFileName.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtColorFileName.Id = null;
            this.TxtColorFileName.Label = "";
            this.TxtColorFileName.Location = new System.Drawing.Point(6, 136);
            this.TxtColorFileName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtColorFileName.MaxByteLength = 65535;
            this.TxtColorFileName.MaxLength = 0;
            this.TxtColorFileName.Name = "TxtColorFileName";
            this.TxtColorFileName.Size = new System.Drawing.Size(293, 30);
            this.TxtColorFileName.TabIndex = 98;
            this.TxtColorFileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtColorFileName.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtColorFileName.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtColorFileName.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtColorFileName.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtColorFileName.Title = "既調色ﾌｧｲﾙ名(&F)";
            this.TxtColorFileName.TitleControlName = "lblTitle";
            this.TxtColorFileName.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtColorFileName.Value = "";
            // 
            // TxtPaintName
            // 
            this.TxtPaintName.DatabaseColumnName = "";
            this.TxtPaintName.DataControlName = "txtData";
            this.TxtPaintName.DataEnabled = true;
            this.TxtPaintName.DataReadOnly = false;
            this.TxtPaintName.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtPaintName.DataTextSize = new System.Drawing.Size(278, 30);
            this.TxtPaintName.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtPaintName.Id = null;
            this.TxtPaintName.Label = "";
            this.TxtPaintName.Location = new System.Drawing.Point(6, 66);
            this.TxtPaintName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPaintName.MaxByteLength = 65535;
            this.TxtPaintName.MaxLength = 0;
            this.TxtPaintName.Name = "TxtPaintName";
            this.TxtPaintName.Size = new System.Drawing.Size(432, 30);
            this.TxtPaintName.TabIndex = 100;
            this.TxtPaintName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtPaintName.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtPaintName.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtPaintName.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtPaintName.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtPaintName.Title = "品名(&C)";
            this.TxtPaintName.TitleControlName = "lblTitle";
            this.TxtPaintName.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtPaintName.Value = "";
            // 
            // BtnToRight
            // 
            this.BtnToRight.Location = new System.Drawing.Point(757, 31);
            this.BtnToRight.Name = "BtnToRight";
            this.BtnToRight.Size = new System.Drawing.Size(30, 30);
            this.BtnToRight.TabIndex = 98;
            this.BtnToRight.Text = "＞";
            this.BtnToRight.UseVisualStyleBackColor = true;
            // 
            // BtnToLeft
            // 
            this.BtnToLeft.Location = new System.Drawing.Point(728, 31);
            this.BtnToLeft.Name = "BtnToLeft";
            this.BtnToLeft.Size = new System.Drawing.Size(30, 30);
            this.BtnToLeft.TabIndex = 99;
            this.BtnToLeft.Text = "＜";
            this.BtnToLeft.UseVisualStyleBackColor = true;
            // 
            // TxtKanjiColorName
            // 
            this.TxtKanjiColorName.DatabaseColumnName = "";
            this.TxtKanjiColorName.DataControlName = "txtData";
            this.TxtKanjiColorName.DataEnabled = true;
            this.TxtKanjiColorName.DataReadOnly = false;
            this.TxtKanjiColorName.DataTextLocation = new System.Drawing.Point(190, 0);
            this.TxtKanjiColorName.DataTextSize = new System.Drawing.Size(529, 30);
            this.TxtKanjiColorName.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtKanjiColorName.Id = null;
            this.TxtKanjiColorName.Label = "";
            this.TxtKanjiColorName.Location = new System.Drawing.Point(6, 31);
            this.TxtKanjiColorName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtKanjiColorName.MaxByteLength = 65535;
            this.TxtKanjiColorName.MaxLength = 0;
            this.TxtKanjiColorName.Name = "TxtKanjiColorName";
            this.TxtKanjiColorName.Size = new System.Drawing.Size(719, 30);
            this.TxtKanjiColorName.TabIndex = 6;
            this.TxtKanjiColorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtKanjiColorName.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtKanjiColorName.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtKanjiColorName.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtKanjiColorName.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtKanjiColorName.Title = "色名(漢字)(&X)　　(0/0)";
            this.TxtKanjiColorName.TitleControlName = "lblTitle";
            this.TxtKanjiColorName.TitleSize = new System.Drawing.Size(190, 30);
            this.TxtKanjiColorName.Value = "";
            // 
            // GrpBoxBase
            // 
            this.GrpBoxBase.Controls.Add(this.DrpBaseSelect);
            this.GrpBoxBase.Controls.Add(this.TxtBaseValue);
            this.GrpBoxBase.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GrpBoxBase.Location = new System.Drawing.Point(337, 227);
            this.GrpBoxBase.Name = "GrpBoxBase";
            this.GrpBoxBase.Size = new System.Drawing.Size(792, 75);
            this.GrpBoxBase.TabIndex = 93;
            this.GrpBoxBase.TabStop = false;
            this.GrpBoxBase.Text = "ベース";
            // 
            // DrpBaseSelect
            // 
            this.DrpBaseSelect.BackColor = System.Drawing.SystemColors.WindowText;
            this.DrpBaseSelect.BorderColor = System.Drawing.Color.Silver;
            this.DrpBaseSelect.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.DrpBaseSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrpBaseSelect.DropDownWidth = 529;
            this.DrpBaseSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrpBaseSelect.ForeColor = System.Drawing.SystemColors.Window;
            this.DrpBaseSelect.FormattingEnabled = true;
            this.DrpBaseSelect.IntegralHeight = false;
            this.DrpBaseSelect.Location = new System.Drawing.Point(6, 31);
            this.DrpBaseSelect.Name = "DrpBaseSelect";
            this.DrpBaseSelect.Size = new System.Drawing.Size(529, 31);
            this.DrpBaseSelect.TabIndex = 103;
            // 
            // TxtBaseValue
            // 
            this.TxtBaseValue.BackColor = System.Drawing.SystemColors.WindowText;
            this.TxtBaseValue.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtBaseValue.Location = new System.Drawing.Point(535, 31);
            this.TxtBaseValue.Multiline = true;
            this.TxtBaseValue.Name = "TxtBaseValue";
            this.TxtBaseValue.Size = new System.Drawing.Size(139, 30);
            this.TxtBaseValue.TabIndex = 103;
            this.TxtBaseValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GrpBoxLabel
            // 
            this.GrpBoxLabel.Controls.Add(this.DateTimePicker);
            this.GrpBoxLabel.Controls.Add(this.TxtCSAreaCode);
            this.GrpBoxLabel.Controls.Add(this.LblCSAreaCode);
            this.GrpBoxLabel.Controls.Add(this.NumUpDownLabel);
            this.GrpBoxLabel.Controls.Add(this.BtnColorNamePrint);
            this.GrpBoxLabel.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GrpBoxLabel.Location = new System.Drawing.Point(12, 302);
            this.GrpBoxLabel.Name = "GrpBoxLabel";
            this.GrpBoxLabel.Size = new System.Drawing.Size(305, 218);
            this.GrpBoxLabel.TabIndex = 7;
            this.GrpBoxLabel.TabStop = false;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(6, 118);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(293, 30);
            this.DateTimePicker.TabIndex = 102;
            // 
            // TxtCSAreaCode
            // 
            this.TxtCSAreaCode.BackColor = System.Drawing.SystemColors.WindowText;
            this.TxtCSAreaCode.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtCSAreaCode.Location = new System.Drawing.Point(6, 177);
            this.TxtCSAreaCode.Multiline = true;
            this.TxtCSAreaCode.Name = "TxtCSAreaCode";
            this.TxtCSAreaCode.Size = new System.Drawing.Size(293, 30);
            this.TxtCSAreaCode.TabIndex = 101;
            // 
            // LblCSAreaCode
            // 
            this.LblCSAreaCode.AutoSize = true;
            this.LblCSAreaCode.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblCSAreaCode.Location = new System.Drawing.Point(6, 151);
            this.LblCSAreaCode.Name = "LblCSAreaCode";
            this.LblCSAreaCode.Size = new System.Drawing.Size(131, 23);
            this.LblCSAreaCode.TabIndex = 100;
            this.LblCSAreaCode.Text = "CSエリアｺｰﾄﾞ(&A)";
            // 
            // NumUpDownLabel
            // 
            this.NumUpDownLabel.DatabaseColumnName = "";
            this.NumUpDownLabel.DecimalPlaces = 0;
            this.NumUpDownLabel.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NumUpDownLabel.Id = null;
            this.NumUpDownLabel.Location = new System.Drawing.Point(6, 80);
            this.NumUpDownLabel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NumUpDownLabel.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumUpDownLabel.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumUpDownLabel.Name = "NumUpDownLabel";
            this.NumUpDownLabel.Size = new System.Drawing.Size(293, 30);
            this.NumUpDownLabel.TabIndex = 98;
            this.NumUpDownLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NumUpDownLabel.TextBackColor = System.Drawing.SystemColors.Window;
            this.NumUpDownLabel.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.NumUpDownLabel.Title = "ラベル(&P)";
            this.NumUpDownLabel.TitleControlName = "lblTitle";
            this.NumUpDownLabel.TitleSize = new System.Drawing.Size(154, 30);
            this.NumUpDownLabel.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // BtnColorNamePrint
            // 
            this.BtnColorNamePrint.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnColorNamePrint.Location = new System.Drawing.Point(42, 21);
            this.BtnColorNamePrint.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnColorNamePrint.Name = "BtnColorNamePrint";
            this.BtnColorNamePrint.Size = new System.Drawing.Size(220, 54);
            this.BtnColorNamePrint.TabIndex = 97;
            this.BtnColorNamePrint.Text = "色名ラベルのプリント(&F9)";
            this.BtnColorNamePrint.UseVisualStyleBackColor = true;
            // 
            // GrpBoxButton
            // 
            this.GrpBoxButton.Controls.Add(this.BtnClose);
            this.GrpBoxButton.Controls.Add(this.BtnCancel);
            this.GrpBoxButton.Controls.Add(this.BtnCCMDataSend);
            this.GrpBoxButton.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GrpBoxButton.Location = new System.Drawing.Point(12, 522);
            this.GrpBoxButton.Name = "GrpBoxButton";
            this.GrpBoxButton.Size = new System.Drawing.Size(305, 207);
            this.GrpBoxButton.TabIndex = 102;
            this.GrpBoxButton.TabStop = false;
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnClose.Location = new System.Drawing.Point(42, 141);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(220, 54);
            this.BtnClose.TabIndex = 10;
            this.BtnClose.Text = "閉じる(&F7)";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnCancel.Location = new System.Drawing.Point(42, 81);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(220, 54);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "キャンセル(&F6)";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnCCMDataSend
            // 
            this.BtnCCMDataSend.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnCCMDataSend.Location = new System.Drawing.Point(42, 21);
            this.BtnCCMDataSend.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnCCMDataSend.Name = "BtnCCMDataSend";
            this.BtnCCMDataSend.Size = new System.Drawing.Size(220, 54);
            this.BtnCCMDataSend.TabIndex = 8;
            this.BtnCCMDataSend.Text = "CCMデータ送信";
            this.BtnCCMDataSend.UseVisualStyleBackColor = true;
            // 
            // GrpBoxColorant
            // 
            this.GrpBoxColorant.Controls.Add(this.DrpColoarantSelect10);
            this.GrpBoxColorant.Controls.Add(this.DrpColoarantSelect9);
            this.GrpBoxColorant.Controls.Add(this.DrpColoarantSelect8);
            this.GrpBoxColorant.Controls.Add(this.DrpColoarantSelect7);
            this.GrpBoxColorant.Controls.Add(this.DrpColoarantSelect6);
            this.GrpBoxColorant.Controls.Add(this.DrpColoarantSelect5);
            this.GrpBoxColorant.Controls.Add(this.DrpColoarantSelect4);
            this.GrpBoxColorant.Controls.Add(this.DrpColoarantSelect3);
            this.GrpBoxColorant.Controls.Add(this.DrpColoarantSelect2);
            this.GrpBoxColorant.Controls.Add(this.DrpColoarantSelect1);
            this.GrpBoxColorant.Controls.Add(this.TxtColoarantValue2);
            this.GrpBoxColorant.Controls.Add(this.TxtColoarantValue3);
            this.GrpBoxColorant.Controls.Add(this.TxtColoarantValue4);
            this.GrpBoxColorant.Controls.Add(this.TxtColoarantValue7);
            this.GrpBoxColorant.Controls.Add(this.TxtColoarantValue6);
            this.GrpBoxColorant.Controls.Add(this.TxtColoarantValue8);
            this.GrpBoxColorant.Controls.Add(this.TxtColoarantValue9);
            this.GrpBoxColorant.Controls.Add(this.TxtColoarantValue10);
            this.GrpBoxColorant.Controls.Add(this.TxtColoarantValue5);
            this.GrpBoxColorant.Controls.Add(this.TxtColoarantValue1);
            this.GrpBoxColorant.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GrpBoxColorant.Location = new System.Drawing.Point(337, 302);
            this.GrpBoxColorant.Name = "GrpBoxColorant";
            this.GrpBoxColorant.Size = new System.Drawing.Size(792, 427);
            this.GrpBoxColorant.TabIndex = 104;
            this.GrpBoxColorant.TabStop = false;
            this.GrpBoxColorant.Text = "着色材";
            // 
            // DrpColoarantSelect10
            // 
            this.DrpColoarantSelect10.BackColor = System.Drawing.SystemColors.WindowText;
            this.DrpColoarantSelect10.BorderColor = System.Drawing.Color.Silver;
            this.DrpColoarantSelect10.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.DrpColoarantSelect10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrpColoarantSelect10.DropDownWidth = 529;
            this.DrpColoarantSelect10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrpColoarantSelect10.ForeColor = System.Drawing.SystemColors.Window;
            this.DrpColoarantSelect10.FormattingEnabled = true;
            this.DrpColoarantSelect10.IntegralHeight = false;
            this.DrpColoarantSelect10.Location = new System.Drawing.Point(6, 346);
            this.DrpColoarantSelect10.Name = "DrpColoarantSelect10";
            this.DrpColoarantSelect10.Size = new System.Drawing.Size(529, 31);
            this.DrpColoarantSelect10.TabIndex = 129;
            // 
            // DrpColoarantSelect9
            // 
            this.DrpColoarantSelect9.BackColor = System.Drawing.SystemColors.WindowText;
            this.DrpColoarantSelect9.BorderColor = System.Drawing.Color.Silver;
            this.DrpColoarantSelect9.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.DrpColoarantSelect9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrpColoarantSelect9.DropDownWidth = 529;
            this.DrpColoarantSelect9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrpColoarantSelect9.ForeColor = System.Drawing.SystemColors.Window;
            this.DrpColoarantSelect9.FormattingEnabled = true;
            this.DrpColoarantSelect9.IntegralHeight = false;
            this.DrpColoarantSelect9.Location = new System.Drawing.Point(6, 311);
            this.DrpColoarantSelect9.Name = "DrpColoarantSelect9";
            this.DrpColoarantSelect9.Size = new System.Drawing.Size(529, 31);
            this.DrpColoarantSelect9.TabIndex = 128;
            // 
            // DrpColoarantSelect8
            // 
            this.DrpColoarantSelect8.BackColor = System.Drawing.SystemColors.WindowText;
            this.DrpColoarantSelect8.BorderColor = System.Drawing.Color.Silver;
            this.DrpColoarantSelect8.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.DrpColoarantSelect8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrpColoarantSelect8.DropDownWidth = 529;
            this.DrpColoarantSelect8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrpColoarantSelect8.ForeColor = System.Drawing.SystemColors.Window;
            this.DrpColoarantSelect8.FormattingEnabled = true;
            this.DrpColoarantSelect8.IntegralHeight = false;
            this.DrpColoarantSelect8.Location = new System.Drawing.Point(6, 276);
            this.DrpColoarantSelect8.Name = "DrpColoarantSelect8";
            this.DrpColoarantSelect8.Size = new System.Drawing.Size(529, 31);
            this.DrpColoarantSelect8.TabIndex = 127;
            // 
            // DrpColoarantSelect7
            // 
            this.DrpColoarantSelect7.BackColor = System.Drawing.SystemColors.WindowText;
            this.DrpColoarantSelect7.BorderColor = System.Drawing.Color.Silver;
            this.DrpColoarantSelect7.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.DrpColoarantSelect7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrpColoarantSelect7.DropDownWidth = 529;
            this.DrpColoarantSelect7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrpColoarantSelect7.ForeColor = System.Drawing.SystemColors.Window;
            this.DrpColoarantSelect7.FormattingEnabled = true;
            this.DrpColoarantSelect7.IntegralHeight = false;
            this.DrpColoarantSelect7.Location = new System.Drawing.Point(6, 241);
            this.DrpColoarantSelect7.Name = "DrpColoarantSelect7";
            this.DrpColoarantSelect7.Size = new System.Drawing.Size(529, 31);
            this.DrpColoarantSelect7.TabIndex = 126;
            // 
            // DrpColoarantSelect6
            // 
            this.DrpColoarantSelect6.BackColor = System.Drawing.SystemColors.WindowText;
            this.DrpColoarantSelect6.BorderColor = System.Drawing.Color.Silver;
            this.DrpColoarantSelect6.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.DrpColoarantSelect6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrpColoarantSelect6.DropDownWidth = 529;
            this.DrpColoarantSelect6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrpColoarantSelect6.ForeColor = System.Drawing.SystemColors.Window;
            this.DrpColoarantSelect6.FormattingEnabled = true;
            this.DrpColoarantSelect6.IntegralHeight = false;
            this.DrpColoarantSelect6.Location = new System.Drawing.Point(6, 206);
            this.DrpColoarantSelect6.Name = "DrpColoarantSelect6";
            this.DrpColoarantSelect6.Size = new System.Drawing.Size(529, 31);
            this.DrpColoarantSelect6.TabIndex = 125;
            // 
            // DrpColoarantSelect5
            // 
            this.DrpColoarantSelect5.BackColor = System.Drawing.SystemColors.WindowText;
            this.DrpColoarantSelect5.BorderColor = System.Drawing.Color.Silver;
            this.DrpColoarantSelect5.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.DrpColoarantSelect5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrpColoarantSelect5.DropDownWidth = 529;
            this.DrpColoarantSelect5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrpColoarantSelect5.ForeColor = System.Drawing.SystemColors.Window;
            this.DrpColoarantSelect5.FormattingEnabled = true;
            this.DrpColoarantSelect5.IntegralHeight = false;
            this.DrpColoarantSelect5.Location = new System.Drawing.Point(6, 171);
            this.DrpColoarantSelect5.Name = "DrpColoarantSelect5";
            this.DrpColoarantSelect5.Size = new System.Drawing.Size(529, 31);
            this.DrpColoarantSelect5.TabIndex = 124;
            // 
            // DrpColoarantSelect4
            // 
            this.DrpColoarantSelect4.BackColor = System.Drawing.SystemColors.WindowText;
            this.DrpColoarantSelect4.BorderColor = System.Drawing.Color.Silver;
            this.DrpColoarantSelect4.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.DrpColoarantSelect4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrpColoarantSelect4.DropDownWidth = 529;
            this.DrpColoarantSelect4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrpColoarantSelect4.ForeColor = System.Drawing.SystemColors.Window;
            this.DrpColoarantSelect4.FormattingEnabled = true;
            this.DrpColoarantSelect4.IntegralHeight = false;
            this.DrpColoarantSelect4.Location = new System.Drawing.Point(6, 136);
            this.DrpColoarantSelect4.Name = "DrpColoarantSelect4";
            this.DrpColoarantSelect4.Size = new System.Drawing.Size(529, 31);
            this.DrpColoarantSelect4.TabIndex = 123;
            // 
            // DrpColoarantSelect3
            // 
            this.DrpColoarantSelect3.BackColor = System.Drawing.SystemColors.WindowText;
            this.DrpColoarantSelect3.BorderColor = System.Drawing.Color.Silver;
            this.DrpColoarantSelect3.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.DrpColoarantSelect3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrpColoarantSelect3.DropDownWidth = 529;
            this.DrpColoarantSelect3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrpColoarantSelect3.ForeColor = System.Drawing.SystemColors.Window;
            this.DrpColoarantSelect3.FormattingEnabled = true;
            this.DrpColoarantSelect3.IntegralHeight = false;
            this.DrpColoarantSelect3.Location = new System.Drawing.Point(6, 101);
            this.DrpColoarantSelect3.Name = "DrpColoarantSelect3";
            this.DrpColoarantSelect3.Size = new System.Drawing.Size(529, 31);
            this.DrpColoarantSelect3.TabIndex = 122;
            // 
            // DrpColoarantSelect2
            // 
            this.DrpColoarantSelect2.BackColor = System.Drawing.SystemColors.WindowText;
            this.DrpColoarantSelect2.BorderColor = System.Drawing.Color.Silver;
            this.DrpColoarantSelect2.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.DrpColoarantSelect2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrpColoarantSelect2.DropDownWidth = 529;
            this.DrpColoarantSelect2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrpColoarantSelect2.ForeColor = System.Drawing.SystemColors.Window;
            this.DrpColoarantSelect2.FormattingEnabled = true;
            this.DrpColoarantSelect2.IntegralHeight = false;
            this.DrpColoarantSelect2.Location = new System.Drawing.Point(6, 66);
            this.DrpColoarantSelect2.Name = "DrpColoarantSelect2";
            this.DrpColoarantSelect2.Size = new System.Drawing.Size(529, 31);
            this.DrpColoarantSelect2.TabIndex = 121;
            // 
            // DrpColoarantSelect1
            // 
            this.DrpColoarantSelect1.BackColor = System.Drawing.SystemColors.WindowText;
            this.DrpColoarantSelect1.BorderColor = System.Drawing.Color.Silver;
            this.DrpColoarantSelect1.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.DrpColoarantSelect1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrpColoarantSelect1.DropDownWidth = 529;
            this.DrpColoarantSelect1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrpColoarantSelect1.ForeColor = System.Drawing.SystemColors.Window;
            this.DrpColoarantSelect1.FormattingEnabled = true;
            this.DrpColoarantSelect1.IntegralHeight = false;
            this.DrpColoarantSelect1.Location = new System.Drawing.Point(6, 31);
            this.DrpColoarantSelect1.Name = "DrpColoarantSelect1";
            this.DrpColoarantSelect1.Size = new System.Drawing.Size(529, 31);
            this.DrpColoarantSelect1.TabIndex = 104;
            // 
            // TxtColoarantValue2
            // 
            this.TxtColoarantValue2.BackColor = System.Drawing.SystemColors.WindowText;
            this.TxtColoarantValue2.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtColoarantValue2.Location = new System.Drawing.Point(535, 66);
            this.TxtColoarantValue2.Multiline = true;
            this.TxtColoarantValue2.Name = "TxtColoarantValue2";
            this.TxtColoarantValue2.Size = new System.Drawing.Size(139, 30);
            this.TxtColoarantValue2.TabIndex = 120;
            this.TxtColoarantValue2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtColoarantValue3
            // 
            this.TxtColoarantValue3.BackColor = System.Drawing.SystemColors.WindowText;
            this.TxtColoarantValue3.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtColoarantValue3.Location = new System.Drawing.Point(535, 101);
            this.TxtColoarantValue3.Multiline = true;
            this.TxtColoarantValue3.Name = "TxtColoarantValue3";
            this.TxtColoarantValue3.Size = new System.Drawing.Size(139, 30);
            this.TxtColoarantValue3.TabIndex = 118;
            this.TxtColoarantValue3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtColoarantValue4
            // 
            this.TxtColoarantValue4.BackColor = System.Drawing.SystemColors.WindowText;
            this.TxtColoarantValue4.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtColoarantValue4.Location = new System.Drawing.Point(535, 136);
            this.TxtColoarantValue4.Multiline = true;
            this.TxtColoarantValue4.Name = "TxtColoarantValue4";
            this.TxtColoarantValue4.Size = new System.Drawing.Size(139, 30);
            this.TxtColoarantValue4.TabIndex = 116;
            this.TxtColoarantValue4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtColoarantValue7
            // 
            this.TxtColoarantValue7.BackColor = System.Drawing.SystemColors.WindowText;
            this.TxtColoarantValue7.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtColoarantValue7.Location = new System.Drawing.Point(535, 241);
            this.TxtColoarantValue7.Multiline = true;
            this.TxtColoarantValue7.Name = "TxtColoarantValue7";
            this.TxtColoarantValue7.Size = new System.Drawing.Size(139, 30);
            this.TxtColoarantValue7.TabIndex = 114;
            this.TxtColoarantValue7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtColoarantValue6
            // 
            this.TxtColoarantValue6.BackColor = System.Drawing.SystemColors.WindowText;
            this.TxtColoarantValue6.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtColoarantValue6.Location = new System.Drawing.Point(535, 206);
            this.TxtColoarantValue6.Multiline = true;
            this.TxtColoarantValue6.Name = "TxtColoarantValue6";
            this.TxtColoarantValue6.Size = new System.Drawing.Size(139, 30);
            this.TxtColoarantValue6.TabIndex = 112;
            this.TxtColoarantValue6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtColoarantValue8
            // 
            this.TxtColoarantValue8.BackColor = System.Drawing.SystemColors.WindowText;
            this.TxtColoarantValue8.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtColoarantValue8.Location = new System.Drawing.Point(535, 276);
            this.TxtColoarantValue8.Multiline = true;
            this.TxtColoarantValue8.Name = "TxtColoarantValue8";
            this.TxtColoarantValue8.Size = new System.Drawing.Size(139, 30);
            this.TxtColoarantValue8.TabIndex = 110;
            this.TxtColoarantValue8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtColoarantValue9
            // 
            this.TxtColoarantValue9.BackColor = System.Drawing.SystemColors.WindowText;
            this.TxtColoarantValue9.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtColoarantValue9.Location = new System.Drawing.Point(535, 311);
            this.TxtColoarantValue9.Multiline = true;
            this.TxtColoarantValue9.Name = "TxtColoarantValue9";
            this.TxtColoarantValue9.Size = new System.Drawing.Size(139, 30);
            this.TxtColoarantValue9.TabIndex = 108;
            this.TxtColoarantValue9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtColoarantValue10
            // 
            this.TxtColoarantValue10.BackColor = System.Drawing.SystemColors.WindowText;
            this.TxtColoarantValue10.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtColoarantValue10.Location = new System.Drawing.Point(535, 346);
            this.TxtColoarantValue10.Multiline = true;
            this.TxtColoarantValue10.Name = "TxtColoarantValue10";
            this.TxtColoarantValue10.Size = new System.Drawing.Size(139, 30);
            this.TxtColoarantValue10.TabIndex = 106;
            this.TxtColoarantValue10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtColoarantValue5
            // 
            this.TxtColoarantValue5.BackColor = System.Drawing.SystemColors.WindowText;
            this.TxtColoarantValue5.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtColoarantValue5.Location = new System.Drawing.Point(535, 171);
            this.TxtColoarantValue5.Multiline = true;
            this.TxtColoarantValue5.Name = "TxtColoarantValue5";
            this.TxtColoarantValue5.Size = new System.Drawing.Size(139, 30);
            this.TxtColoarantValue5.TabIndex = 104;
            this.TxtColoarantValue5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtColoarantValue1
            // 
            this.TxtColoarantValue1.BackColor = System.Drawing.SystemColors.WindowText;
            this.TxtColoarantValue1.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtColoarantValue1.Location = new System.Drawing.Point(535, 31);
            this.TxtColoarantValue1.Multiline = true;
            this.TxtColoarantValue1.Name = "TxtColoarantValue1";
            this.TxtColoarantValue1.Size = new System.Drawing.Size(139, 30);
            this.TxtColoarantValue1.TabIndex = 103;
            this.TxtColoarantValue1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmCCMSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(1143, 742);
            this.ControlBox = false;
            this.Controls.Add(this.GrpBoxColorant);
            this.Controls.Add(this.GrpBoxButton);
            this.Controls.Add(this.GrpBoxLabel);
            this.Controls.Add(this.GrpBoxBase);
            this.Controls.Add(this.GrpInfo);
            this.Controls.Add(this.GrpBoxCorrection);
            this.Controls.Add(this.GrpBoxPutCan);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmCCMSimulator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CCMシミュレータ";
            this.GrpBoxPutCan.ResumeLayout(false);
            this.GrpBoxPutCan.PerformLayout();
            this.GrpBoxCorrection.ResumeLayout(false);
            this.GrpInfo.ResumeLayout(false);
            this.GrpBoxBase.ResumeLayout(false);
            this.GrpBoxBase.PerformLayout();
            this.GrpBoxLabel.ResumeLayout(false);
            this.GrpBoxLabel.PerformLayout();
            this.GrpBoxButton.ResumeLayout(false);
            this.GrpBoxColorant.ResumeLayout(false);
            this.GrpBoxColorant.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBoxPutCan;
        private System.Windows.Forms.RadioButton ChkEmptyCan;
        private System.Windows.Forms.RadioButton ChkFixedCan;
        private System.Windows.Forms.RadioButton ChkFilledCan;
        private System.Windows.Forms.GroupBox GrpBoxCorrection;
        private NipponPaint.NpCommon.FormControls.LabelNumericUpDown NumUpDownCorrection;
        private NipponPaint.NpCommon.FormControls.LabelDropDown DrpProductCodeLeft;
        private System.Windows.Forms.GroupBox GrpInfo;
        private System.Windows.Forms.Button BtnToRight;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtKanjiColorName;
        private System.Windows.Forms.Button BtnToLeft;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtPaintName;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtLine;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtIndexNumber;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtColorFileName;
        private System.Windows.Forms.GroupBox GrpBoxBase;
        private System.Windows.Forms.GroupBox GrpBoxLabel;
        private System.Windows.Forms.TextBox TxtCSAreaCode;
        private NipponPaint.NpCommon.FormControls.LabelNumericUpDown NumUpDownLabel;
        private System.Windows.Forms.Button BtnColorNamePrint;
        private System.Windows.Forms.GroupBox GrpBoxButton;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnCCMDataSend;
        private System.Windows.Forms.TextBox TxtBaseValue;
        private System.Windows.Forms.GroupBox GrpBoxColorant;
        private System.Windows.Forms.TextBox TxtColoarantValue2;
        private System.Windows.Forms.TextBox TxtColoarantValue3;
        private System.Windows.Forms.TextBox TxtColoarantValue4;
        private System.Windows.Forms.TextBox TxtColoarantValue7;
        private System.Windows.Forms.TextBox TxtColoarantValue6;
        private System.Windows.Forms.TextBox TxtColoarantValue8;
        private System.Windows.Forms.TextBox TxtColoarantValue9;
        private System.Windows.Forms.TextBox TxtColoarantValue10;
        private System.Windows.Forms.TextBox TxtColoarantValue5;
        private System.Windows.Forms.TextBox TxtColoarantValue1;
        private System.Windows.Forms.Label LblCSAreaCode;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private NpCommon.FormControls.ComboBoxEx DrpProductCodeRight;
        private NpCommon.FormControls.ComboBoxEx DrpBaseSelect;
        private NpCommon.FormControls.ComboBoxEx DrpColoarantSelect1;
        private NpCommon.FormControls.ComboBoxEx DrpColoarantSelect10;
        private NpCommon.FormControls.ComboBoxEx DrpColoarantSelect9;
        private NpCommon.FormControls.ComboBoxEx DrpColoarantSelect8;
        private NpCommon.FormControls.ComboBoxEx DrpColoarantSelect7;
        private NpCommon.FormControls.ComboBoxEx DrpColoarantSelect6;
        private NpCommon.FormControls.ComboBoxEx DrpColoarantSelect5;
        private NpCommon.FormControls.ComboBoxEx DrpColoarantSelect4;
        private NpCommon.FormControls.ComboBoxEx DrpColoarantSelect3;
        private NpCommon.FormControls.ComboBoxEx DrpColoarantSelect2;
    }
}