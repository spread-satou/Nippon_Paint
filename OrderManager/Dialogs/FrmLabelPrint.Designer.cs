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
    partial class FrmLabelPrint
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
            this.GrpBoxPrint = new System.Windows.Forms.GroupBox();
            this.RBtnNifudaLabelPrint = new System.Windows.Forms.RadioButton();
            this.RBtnProductLabelPrint = new System.Windows.Forms.RadioButton();
            this.RBtnColorNameLabelPrint = new System.Windows.Forms.RadioButton();
            this.RBtnReserveLabelPrint = new System.Windows.Forms.RadioButton();
            this.GrpBoxNumberOfPrint = new System.Windows.Forms.GroupBox();
            this.TxtNormalHeight = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.LblHeight = new System.Windows.Forms.Label();
            this.LblWidth = new System.Windows.Forms.Label();
            this.TxtNormalWidth = new System.Windows.Forms.TextBox();
            this.TxtKanjiHeight = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.TxtKanjiWidth = new System.Windows.Forms.TextBox();
            this.NumUpDownNumberOfPrint = new NipponPaint.NpCommon.FormControls.LabelNumericUpDown();
            this.GrpBoxBtnPrint = new System.Windows.Forms.GroupBox();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.GrpBoxBtnClose = new System.Windows.Forms.GroupBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.GrpBoxNumberOfCan = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnSelectClear = new System.Windows.Forms.Button();
            this.BtnSelectBack = new System.Windows.Forms.Button();
            this.BtnSelectBefore = new System.Windows.Forms.Button();
            this.BtnSelectAll = new System.Windows.Forms.Button();
            this.labelTextBox1 = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.GrpBoxPrint.SuspendLayout();
            this.GrpBoxNumberOfPrint.SuspendLayout();
            this.GrpBoxBtnPrint.SuspendLayout();
            this.GrpBoxBtnClose.SuspendLayout();
            this.GrpBoxNumberOfCan.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBoxPrint
            // 
            this.GrpBoxPrint.Controls.Add(this.RBtnNifudaLabelPrint);
            this.GrpBoxPrint.Controls.Add(this.RBtnProductLabelPrint);
            this.GrpBoxPrint.Controls.Add(this.RBtnColorNameLabelPrint);
            this.GrpBoxPrint.Controls.Add(this.RBtnReserveLabelPrint);
            this.GrpBoxPrint.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GrpBoxPrint.Location = new System.Drawing.Point(13, 12);
            this.GrpBoxPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrpBoxPrint.Name = "GrpBoxPrint";
            this.GrpBoxPrint.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrpBoxPrint.Size = new System.Drawing.Size(444, 274);
            this.GrpBoxPrint.TabIndex = 0;
            this.GrpBoxPrint.TabStop = false;
            this.GrpBoxPrint.Text = "ラベル印刷";
            // 
            // RBtnNifudaLabelPrint
            // 
            this.RBtnNifudaLabelPrint.AutoSize = true;
            this.RBtnNifudaLabelPrint.Location = new System.Drawing.Point(6, 130);
            this.RBtnNifudaLabelPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RBtnNifudaLabelPrint.Name = "RBtnNifudaLabelPrint";
            this.RBtnNifudaLabelPrint.Size = new System.Drawing.Size(157, 27);
            this.RBtnNifudaLabelPrint.TabIndex = 11;
            this.RBtnNifudaLabelPrint.Text = "荷札ラベル印刷(&T)";
            this.RBtnNifudaLabelPrint.UseVisualStyleBackColor = true;
            // 
            // RBtnProductLabelPrint
            // 
            this.RBtnProductLabelPrint.AutoSize = true;
            this.RBtnProductLabelPrint.Checked = true;
            this.RBtnProductLabelPrint.Location = new System.Drawing.Point(6, 31);
            this.RBtnProductLabelPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RBtnProductLabelPrint.Name = "RBtnProductLabelPrint";
            this.RBtnProductLabelPrint.Size = new System.Drawing.Size(201, 27);
            this.RBtnProductLabelPrint.TabIndex = 10;
            this.RBtnProductLabelPrint.TabStop = true;
            this.RBtnProductLabelPrint.Text = "製品ラベルのプリント(&P)";
            this.RBtnProductLabelPrint.UseVisualStyleBackColor = true;
            // 
            // RBtnColorNameLabelPrint
            // 
            this.RBtnColorNameLabelPrint.AutoSize = true;
            this.RBtnColorNameLabelPrint.Location = new System.Drawing.Point(6, 64);
            this.RBtnColorNameLabelPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RBtnColorNameLabelPrint.Name = "RBtnColorNameLabelPrint";
            this.RBtnColorNameLabelPrint.Size = new System.Drawing.Size(203, 27);
            this.RBtnColorNameLabelPrint.TabIndex = 9;
            this.RBtnColorNameLabelPrint.Text = "色名ラベルのプリント(&O)";
            this.RBtnColorNameLabelPrint.UseVisualStyleBackColor = true;
            // 
            // RBtnReserveLabelPrint
            // 
            this.RBtnReserveLabelPrint.AutoSize = true;
            this.RBtnReserveLabelPrint.Location = new System.Drawing.Point(6, 97);
            this.RBtnReserveLabelPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RBtnReserveLabelPrint.Name = "RBtnReserveLabelPrint";
            this.RBtnReserveLabelPrint.Size = new System.Drawing.Size(172, 27);
            this.RBtnReserveLabelPrint.TabIndex = 0;
            this.RBtnReserveLabelPrint.Text = "控え板ラベル印刷(&R)";
            this.RBtnReserveLabelPrint.UseVisualStyleBackColor = true;
            // 
            // GrpBoxNumberOfPrint
            // 
            this.GrpBoxNumberOfPrint.Controls.Add(this.TxtNormalHeight);
            this.GrpBoxNumberOfPrint.Controls.Add(this.LblHeight);
            this.GrpBoxNumberOfPrint.Controls.Add(this.LblWidth);
            this.GrpBoxNumberOfPrint.Controls.Add(this.TxtNormalWidth);
            this.GrpBoxNumberOfPrint.Controls.Add(this.TxtKanjiHeight);
            this.GrpBoxNumberOfPrint.Controls.Add(this.TxtKanjiWidth);
            this.GrpBoxNumberOfPrint.Controls.Add(this.NumUpDownNumberOfPrint);
            this.GrpBoxNumberOfPrint.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GrpBoxNumberOfPrint.Location = new System.Drawing.Point(470, 12);
            this.GrpBoxNumberOfPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrpBoxNumberOfPrint.Name = "GrpBoxNumberOfPrint";
            this.GrpBoxNumberOfPrint.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrpBoxNumberOfPrint.Size = new System.Drawing.Size(444, 274);
            this.GrpBoxNumberOfPrint.TabIndex = 1;
            this.GrpBoxNumberOfPrint.TabStop = false;
            this.GrpBoxNumberOfPrint.Text = "印刷枚数";
            // 
            // TxtNormalHeight
            // 
            this.TxtNormalHeight.DatabaseColumnName = "";
            this.TxtNormalHeight.DataControlName = "txtData";
            this.TxtNormalHeight.DataEnabled = true;
            this.TxtNormalHeight.DataReadOnly = false;
            this.TxtNormalHeight.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtNormalHeight.DataTextSize = new System.Drawing.Size(139, 30);
            this.TxtNormalHeight.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtNormalHeight.Id = null;
            this.TxtNormalHeight.Label = "";
            this.TxtNormalHeight.Location = new System.Drawing.Point(6, 163);
            this.TxtNormalHeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNormalHeight.MaxByteLength = 65535;
            this.TxtNormalHeight.MaxLength = 0;
            this.TxtNormalHeight.Name = "TxtNormalHeight";
            this.TxtNormalHeight.Size = new System.Drawing.Size(293, 30);
            this.TxtNormalHeight.TabIndex = 105;
            this.TxtNormalHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtNormalHeight.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtNormalHeight.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtNormalHeight.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtNormalHeight.Title = "通常";
            this.TxtNormalHeight.TitleControlName = "lblTitle";
            this.TxtNormalHeight.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtNormalHeight.Value = "";
            // 
            // LblHeight
            // 
            this.LblHeight.AutoSize = true;
            this.LblHeight.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblHeight.Location = new System.Drawing.Point(206, 97);
            this.LblHeight.Name = "LblHeight";
            this.LblHeight.Size = new System.Drawing.Size(40, 23);
            this.LblHeight.TabIndex = 104;
            this.LblHeight.Text = "高さ";
            // 
            // LblWidth
            // 
            this.LblWidth.AutoSize = true;
            this.LblWidth.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblWidth.Location = new System.Drawing.Point(354, 97);
            this.LblWidth.Name = "LblWidth";
            this.LblWidth.Size = new System.Drawing.Size(25, 23);
            this.LblWidth.TabIndex = 103;
            this.LblWidth.Text = "幅";
            // 
            // TxtNormalWidth
            // 
            this.TxtNormalWidth.Location = new System.Drawing.Point(298, 163);
            this.TxtNormalWidth.Name = "TxtNormalWidth";
            this.TxtNormalWidth.Size = new System.Drawing.Size(139, 30);
            this.TxtNormalWidth.TabIndex = 102;
            this.TxtNormalWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtKanjiHeight
            // 
            this.TxtKanjiHeight.DatabaseColumnName = "";
            this.TxtKanjiHeight.DataControlName = "txtData";
            this.TxtKanjiHeight.DataEnabled = true;
            this.TxtKanjiHeight.DataReadOnly = false;
            this.TxtKanjiHeight.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtKanjiHeight.DataTextSize = new System.Drawing.Size(139, 30);
            this.TxtKanjiHeight.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtKanjiHeight.Id = null;
            this.TxtKanjiHeight.Label = "";
            this.TxtKanjiHeight.Location = new System.Drawing.Point(6, 128);
            this.TxtKanjiHeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtKanjiHeight.MaxByteLength = 65535;
            this.TxtKanjiHeight.MaxLength = 0;
            this.TxtKanjiHeight.Name = "TxtKanjiHeight";
            this.TxtKanjiHeight.Size = new System.Drawing.Size(293, 30);
            this.TxtKanjiHeight.TabIndex = 99;
            this.TxtKanjiHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtKanjiHeight.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtKanjiHeight.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtKanjiHeight.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtKanjiHeight.Title = "漢字";
            this.TxtKanjiHeight.TitleControlName = "lblTitle";
            this.TxtKanjiHeight.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtKanjiHeight.Value = "";
            // 
            // TxtKanjiWidth
            // 
            this.TxtKanjiWidth.Location = new System.Drawing.Point(298, 128);
            this.TxtKanjiWidth.Name = "TxtKanjiWidth";
            this.TxtKanjiWidth.Size = new System.Drawing.Size(139, 30);
            this.TxtKanjiWidth.TabIndex = 100;
            this.TxtKanjiWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NumUpDownNumberOfPrint
            // 
            this.NumUpDownNumberOfPrint.DatabaseColumnName = "";
            this.NumUpDownNumberOfPrint.DecimalPlaces = 0;
            this.NumUpDownNumberOfPrint.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NumUpDownNumberOfPrint.Id = null;
            this.NumUpDownNumberOfPrint.Location = new System.Drawing.Point(6, 31);
            this.NumUpDownNumberOfPrint.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NumUpDownNumberOfPrint.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumUpDownNumberOfPrint.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumUpDownNumberOfPrint.Name = "NumUpDownNumberOfPrint";
            this.NumUpDownNumberOfPrint.Size = new System.Drawing.Size(293, 30);
            this.NumUpDownNumberOfPrint.TabIndex = 92;
            this.NumUpDownNumberOfPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NumUpDownNumberOfPrint.Title = "印刷枚数(&N)";
            this.NumUpDownNumberOfPrint.TitleControlName = "lblTitle";
            this.NumUpDownNumberOfPrint.TitleSize = new System.Drawing.Size(154, 30);
            this.NumUpDownNumberOfPrint.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // GrpBoxBtnPrint
            // 
            this.GrpBoxBtnPrint.Controls.Add(this.BtnPrint);
            this.GrpBoxBtnPrint.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GrpBoxBtnPrint.Location = new System.Drawing.Point(13, 286);
            this.GrpBoxBtnPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrpBoxBtnPrint.Name = "GrpBoxBtnPrint";
            this.GrpBoxBtnPrint.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrpBoxBtnPrint.Size = new System.Drawing.Size(444, 83);
            this.GrpBoxBtnPrint.TabIndex = 12;
            this.GrpBoxBtnPrint.TabStop = false;
            // 
            // BtnPrint
            // 
            this.BtnPrint.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnPrint.Location = new System.Drawing.Point(117, 19);
            this.BtnPrint.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(220, 54);
            this.BtnPrint.TabIndex = 0;
            this.BtnPrint.Text = "ラベル印刷";
            this.BtnPrint.UseVisualStyleBackColor = true;
            // 
            // GrpBoxBtnClose
            // 
            this.GrpBoxBtnClose.Controls.Add(this.BtnClose);
            this.GrpBoxBtnClose.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GrpBoxBtnClose.Location = new System.Drawing.Point(470, 286);
            this.GrpBoxBtnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrpBoxBtnClose.Name = "GrpBoxBtnClose";
            this.GrpBoxBtnClose.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrpBoxBtnClose.Size = new System.Drawing.Size(444, 83);
            this.GrpBoxBtnClose.TabIndex = 13;
            this.GrpBoxBtnClose.TabStop = false;
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnClose.Location = new System.Drawing.Point(118, 19);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(220, 54);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "閉じる";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // GrpBoxNumberOfCan
            // 
            this.GrpBoxNumberOfCan.Controls.Add(this.listBox1);
            this.GrpBoxNumberOfCan.Controls.Add(this.BtnSelectClear);
            this.GrpBoxNumberOfCan.Controls.Add(this.BtnSelectBack);
            this.GrpBoxNumberOfCan.Controls.Add(this.BtnSelectBefore);
            this.GrpBoxNumberOfCan.Controls.Add(this.BtnSelectAll);
            this.GrpBoxNumberOfCan.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GrpBoxNumberOfCan.Location = new System.Drawing.Point(470, 392);
            this.GrpBoxNumberOfCan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrpBoxNumberOfCan.Name = "GrpBoxNumberOfCan";
            this.GrpBoxNumberOfCan.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrpBoxNumberOfCan.Size = new System.Drawing.Size(444, 274);
            this.GrpBoxNumberOfCan.TabIndex = 105;
            this.GrpBoxNumberOfCan.TabStop = false;
            this.GrpBoxNumberOfCan.Text = "缶数";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(8, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(204, 234);
            this.listBox1.TabIndex = 5;
            // 
            // BtnSelectClear
            // 
            this.BtnSelectClear.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnSelectClear.Location = new System.Drawing.Point(217, 208);
            this.BtnSelectClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnSelectClear.Name = "BtnSelectClear";
            this.BtnSelectClear.Size = new System.Drawing.Size(220, 54);
            this.BtnSelectClear.TabIndex = 2;
            this.BtnSelectClear.Text = "選択全消去";
            this.BtnSelectClear.UseVisualStyleBackColor = true;
            // 
            // BtnSelectBack
            // 
            this.BtnSelectBack.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnSelectBack.Location = new System.Drawing.Point(217, 90);
            this.BtnSelectBack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnSelectBack.Name = "BtnSelectBack";
            this.BtnSelectBack.Size = new System.Drawing.Size(220, 54);
            this.BtnSelectBack.TabIndex = 3;
            this.BtnSelectBack.Text = "後選択";
            this.BtnSelectBack.UseVisualStyleBackColor = true;
            // 
            // BtnSelectBefore
            // 
            this.BtnSelectBefore.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnSelectBefore.Location = new System.Drawing.Point(217, 31);
            this.BtnSelectBefore.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnSelectBefore.Name = "BtnSelectBefore";
            this.BtnSelectBefore.Size = new System.Drawing.Size(220, 54);
            this.BtnSelectBefore.TabIndex = 4;
            this.BtnSelectBefore.Text = "前選択";
            this.BtnSelectBefore.UseVisualStyleBackColor = true;
            // 
            // BtnSelectAll
            // 
            this.BtnSelectAll.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnSelectAll.Location = new System.Drawing.Point(217, 149);
            this.BtnSelectAll.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnSelectAll.Name = "BtnSelectAll";
            this.BtnSelectAll.Size = new System.Drawing.Size(220, 54);
            this.BtnSelectAll.TabIndex = 1;
            this.BtnSelectAll.Text = "全て";
            this.BtnSelectAll.UseVisualStyleBackColor = true;
            // 
            // labelTextBox1
            // 
            this.labelTextBox1.DatabaseColumnName = "";
            this.labelTextBox1.DataControlName = "txtData";
            this.labelTextBox1.DataEnabled = true;
            this.labelTextBox1.DataReadOnly = false;
            this.labelTextBox1.DataTextLocation = new System.Drawing.Point(154, 0);
            this.labelTextBox1.DataTextSize = new System.Drawing.Size(139, 30);
            this.labelTextBox1.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox1.Id = null;
            this.labelTextBox1.Label = "";
            this.labelTextBox1.Location = new System.Drawing.Point(6, 163);
            this.labelTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelTextBox1.MaxByteLength = 65535;
            this.labelTextBox1.MaxLength = 0;
            this.labelTextBox1.Name = "labelTextBox1";
            this.labelTextBox1.Size = new System.Drawing.Size(293, 30);
            this.labelTextBox1.TabIndex = 101;
            this.labelTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.labelTextBox1.TextBackColor = System.Drawing.SystemColors.Window;
            this.labelTextBox1.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTextBox1.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTextBox1.Title = "通常";
            this.labelTextBox1.TitleControlName = "lblTitle";
            this.labelTextBox1.TitleSize = new System.Drawing.Size(154, 30);
            this.labelTextBox1.Value = "";
            // 
            // FrmLabelPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(928, 677);
            this.ControlBox = false;
            this.Controls.Add(this.GrpBoxNumberOfCan);
            this.Controls.Add(this.GrpBoxBtnClose);
            this.Controls.Add(this.GrpBoxBtnPrint);
            this.Controls.Add(this.GrpBoxNumberOfPrint);
            this.Controls.Add(this.GrpBoxPrint);
            this.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "FrmLabelPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ラベル印刷";
            this.GrpBoxPrint.ResumeLayout(false);
            this.GrpBoxPrint.PerformLayout();
            this.GrpBoxNumberOfPrint.ResumeLayout(false);
            this.GrpBoxNumberOfPrint.PerformLayout();
            this.GrpBoxBtnPrint.ResumeLayout(false);
            this.GrpBoxBtnClose.ResumeLayout(false);
            this.GrpBoxNumberOfCan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBoxPrint;
        private System.Windows.Forms.GroupBox GrpBoxNumberOfPrint;
        private System.Windows.Forms.RadioButton RBtnReserveLabelPrint;
        private System.Windows.Forms.RadioButton RBtnProductLabelPrint;
        private System.Windows.Forms.RadioButton RBtnColorNameLabelPrint;
        private System.Windows.Forms.RadioButton RBtnNifudaLabelPrint;
        private NipponPaint.NpCommon.FormControls.LabelNumericUpDown NumUpDownNumberOfPrint;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtKanjiHeight;
        private System.Windows.Forms.TextBox TxtNormalWidth;
        private NipponPaint.NpCommon.FormControls.LabelTextBox labelTextBox1;
        private System.Windows.Forms.TextBox TxtKanjiWidth;
        private System.Windows.Forms.Label LblHeight;
        private System.Windows.Forms.Label LblWidth;
        private System.Windows.Forms.GroupBox GrpBoxBtnPrint;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.GroupBox GrpBoxBtnClose;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.GroupBox GrpBoxNumberOfCan;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnSelectClear;
        private System.Windows.Forms.Button BtnSelectBack;
        private System.Windows.Forms.Button BtnSelectBefore;
        private System.Windows.Forms.Button BtnSelectAll;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtNormalHeight;
    }
}