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
    partial class FrmLabelSelection
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlControl = new System.Windows.Forms.Panel();
            this.PrinterSetting = new System.Windows.Forms.GroupBox();
            this.NumCenterAligned = new NipponPaint.NpCommon.FormControls.LabelNumericUpDown();
            this.NumPositionY = new NipponPaint.NpCommon.FormControls.LabelNumericUpDown();
            this.NumLeftAligned = new NipponPaint.NpCommon.FormControls.LabelNumericUpDown();
            this.NumPositionX = new NipponPaint.NpCommon.FormControls.LabelNumericUpDown();
            this.TxtLabelDescription = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.TxtLabelType = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnModify = new System.Windows.Forms.Button();
            this.BtnCopyCreate = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.DgvList = new System.Windows.Forms.DataGridView();
            this.PnlControl.SuspendLayout();
            this.PrinterSetting.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlControl
            // 
            this.PnlControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PnlControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlControl.Controls.Add(this.PrinterSetting);
            this.PnlControl.Controls.Add(this.TxtLabelDescription);
            this.PnlControl.Controls.Add(this.TxtLabelType);
            this.PnlControl.Controls.Add(this.panel1);
            this.PnlControl.Location = new System.Drawing.Point(12, 248);
            this.PnlControl.Name = "PnlControl";
            this.PnlControl.Size = new System.Drawing.Size(977, 322);
            this.PnlControl.TabIndex = 28;
            // 
            // PrinterSetting
            // 
            this.PrinterSetting.Controls.Add(this.NumCenterAligned);
            this.PrinterSetting.Controls.Add(this.NumPositionY);
            this.PrinterSetting.Controls.Add(this.NumLeftAligned);
            this.PrinterSetting.Controls.Add(this.NumPositionX);
            this.PrinterSetting.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PrinterSetting.Location = new System.Drawing.Point(300, 104);
            this.PrinterSetting.Name = "PrinterSetting";
            this.PrinterSetting.Size = new System.Drawing.Size(414, 207);
            this.PrinterSetting.TabIndex = 35;
            this.PrinterSetting.TabStop = false;
            this.PrinterSetting.Text = "プリンタ設定";
            // 
            // NumCenterAligned
            // 
            this.NumCenterAligned.DatabaseColumnName = "";
            this.NumCenterAligned.DecimalPlaces = 0;
            this.NumCenterAligned.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NumCenterAligned.Id = "";
            this.NumCenterAligned.Location = new System.Drawing.Point(98, 156);
            this.NumCenterAligned.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NumCenterAligned.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumCenterAligned.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.NumCenterAligned.Name = "NumCenterAligned";
            this.NumCenterAligned.Size = new System.Drawing.Size(293, 30);
            this.NumCenterAligned.TabIndex = 33;
            this.NumCenterAligned.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NumCenterAligned.Title = "Y位置修正(&Q)";
            this.NumCenterAligned.TitleControlName = "LblTitle";
            this.NumCenterAligned.TitleSize = new System.Drawing.Size(154, 30);
            this.NumCenterAligned.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // NumPositionY
            // 
            this.NumPositionY.DatabaseColumnName = "";
            this.NumPositionY.DecimalPlaces = 0;
            this.NumPositionY.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NumPositionY.Id = "";
            this.NumPositionY.Location = new System.Drawing.Point(98, 72);
            this.NumPositionY.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NumPositionY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumPositionY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.NumPositionY.Name = "NumPositionY";
            this.NumPositionY.Size = new System.Drawing.Size(293, 30);
            this.NumPositionY.TabIndex = 31;
            this.NumPositionY.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NumPositionY.Title = "Y位置(Y)";
            this.NumPositionY.TitleControlName = "LblTitle";
            this.NumPositionY.TitleSize = new System.Drawing.Size(154, 30);
            this.NumPositionY.Value = new decimal(new int[] {
            111,
            0,
            0,
            -2147483648});
            // 
            // NumLeftAligned
            // 
            this.NumLeftAligned.DatabaseColumnName = "";
            this.NumLeftAligned.DecimalPlaces = 0;
            this.NumLeftAligned.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NumLeftAligned.Id = "";
            this.NumLeftAligned.Location = new System.Drawing.Point(98, 114);
            this.NumLeftAligned.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NumLeftAligned.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumLeftAligned.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.NumLeftAligned.Name = "NumLeftAligned";
            this.NumLeftAligned.Size = new System.Drawing.Size(293, 30);
            this.NumLeftAligned.TabIndex = 32;
            this.NumLeftAligned.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NumLeftAligned.Title = "X位置修正(&P)";
            this.NumLeftAligned.TitleControlName = "LblTitle";
            this.NumLeftAligned.TitleSize = new System.Drawing.Size(154, 30);
            this.NumLeftAligned.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // NumPositionX
            // 
            this.NumPositionX.DatabaseColumnName = "";
            this.NumPositionX.DecimalPlaces = 0;
            this.NumPositionX.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NumPositionX.Id = "";
            this.NumPositionX.Location = new System.Drawing.Point(98, 30);
            this.NumPositionX.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NumPositionX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumPositionX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.NumPositionX.Name = "NumPositionX";
            this.NumPositionX.Size = new System.Drawing.Size(293, 30);
            this.NumPositionX.TabIndex = 30;
            this.NumPositionX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NumPositionX.Title = "X位置(X)";
            this.NumPositionX.TitleControlName = "LblTitle";
            this.NumPositionX.TitleSize = new System.Drawing.Size(154, 30);
            this.NumPositionX.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // TxtLabelDescription
            // 
            this.TxtLabelDescription.DatabaseColumnName = "Label_Description";
            this.TxtLabelDescription.DataControlName = "txtData";
            this.TxtLabelDescription.DataEnabled = true;
            this.TxtLabelDescription.DataReadOnly = false;
            this.TxtLabelDescription.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtLabelDescription.DataTextSize = new System.Drawing.Size(551, 30);
            this.TxtLabelDescription.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtLabelDescription.Id = "";
            this.TxtLabelDescription.Label = "";
            this.TxtLabelDescription.Location = new System.Drawing.Point(9, 49);
            this.TxtLabelDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtLabelDescription.MaxByteLength = 65535;
            this.TxtLabelDescription.MaxLength = 0;
            this.TxtLabelDescription.Name = "TxtLabelDescription";
            this.TxtLabelDescription.Size = new System.Drawing.Size(705, 30);
            this.TxtLabelDescription.TabIndex = 29;
            this.TxtLabelDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtLabelDescription.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtLabelDescription.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtLabelDescription.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtLabelDescription.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtLabelDescription.Title = "ラベル詳細(&D)";
            this.TxtLabelDescription.TitleControlName = "lblTitle";
            this.TxtLabelDescription.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtLabelDescription.Value = "";
            // 
            // TxtLabelType
            // 
            this.TxtLabelType.DatabaseColumnName = "Label_Type";
            this.TxtLabelType.DataControlName = "txtData";
            this.TxtLabelType.DataEnabled = true;
            this.TxtLabelType.DataReadOnly = false;
            this.TxtLabelType.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtLabelType.DataTextSize = new System.Drawing.Size(139, 30);
            this.TxtLabelType.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtLabelType.Id = "";
            this.TxtLabelType.Label = "";
            this.TxtLabelType.Location = new System.Drawing.Point(9, 9);
            this.TxtLabelType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtLabelType.MaxByteLength = 65535;
            this.TxtLabelType.MaxLength = 0;
            this.TxtLabelType.Name = "TxtLabelType";
            this.TxtLabelType.Size = new System.Drawing.Size(293, 30);
            this.TxtLabelType.TabIndex = 28;
            this.TxtLabelType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtLabelType.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtLabelType.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtLabelType.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtLabelType.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtLabelType.Title = "ラベルタイプ(&L)";
            this.TxtLabelType.TitleControlName = "lblTitle";
            this.TxtLabelType.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtLabelType.Value = "";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.BtnDelete);
            this.panel1.Controls.Add(this.BtnModify);
            this.panel1.Controls.Add(this.BtnCopyCreate);
            this.panel1.Controls.Add(this.BtnCreate);
            this.panel1.Location = new System.Drawing.Point(732, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 302);
            this.panel1.TabIndex = 36;
            // 
            // BtnExit
            // 
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnExit.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnExit.Location = new System.Drawing.Point(5, 243);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(220, 54);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "終了";
            this.BtnExit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnDelete.Location = new System.Drawing.Point(5, 184);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(220, 54);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "削除(F4)";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnModify
            // 
            this.BtnModify.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnModify.Location = new System.Drawing.Point(5, 124);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(220, 54);
            this.BtnModify.TabIndex = 2;
            this.BtnModify.Text = "修正(F2)";
            this.BtnModify.UseVisualStyleBackColor = true;
            // 
            // BtnCopyCreate
            // 
            this.BtnCopyCreate.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnCopyCreate.Location = new System.Drawing.Point(5, 65);
            this.BtnCopyCreate.Name = "BtnCopyCreate";
            this.BtnCopyCreate.Size = new System.Drawing.Size(220, 54);
            this.BtnCopyCreate.TabIndex = 1;
            this.BtnCopyCreate.Text = "複写して新規作成(F6)";
            this.BtnCopyCreate.UseVisualStyleBackColor = true;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnCreate.Location = new System.Drawing.Point(5, 5);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(220, 54);
            this.BtnCreate.TabIndex = 0;
            this.BtnCreate.Text = "新規(F5)";
            this.BtnCreate.UseVisualStyleBackColor = true;
            // 
            // DgvList
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvList.DefaultCellStyle = dataGridViewCellStyle12;
            this.DgvList.Location = new System.Drawing.Point(12, 12);
            this.DgvList.Name = "DgvList";
            this.DgvList.RowTemplate.Height = 21;
            this.DgvList.Size = new System.Drawing.Size(977, 216);
            this.DgvList.TabIndex = 29;
            // 
            // FrmLabelSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnExit;
            this.ClientSize = new System.Drawing.Size(1005, 589);
            this.ControlBox = false;
            this.Controls.Add(this.DgvList);
            this.Controls.Add(this.PnlControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmLabelSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ラベル(仮)";
            this.PnlControl.ResumeLayout(false);
            this.PrinterSetting.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvList;
        private System.Windows.Forms.Panel PnlControl;
        private NpCommon.FormControls.LabelTextBox TxtLabelType;
        private NpCommon.FormControls.LabelTextBox TxtLabelDescription;
        private NpCommon.FormControls.LabelNumericUpDown NumPositionY;
        private NpCommon.FormControls.LabelNumericUpDown NumPositionX;
        private NpCommon.FormControls.LabelNumericUpDown NumCenterAligned;
        private NpCommon.FormControls.LabelNumericUpDown NumLeftAligned;
        private System.Windows.Forms.GroupBox PrinterSetting;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.Button BtnCopyCreate;
    }
}