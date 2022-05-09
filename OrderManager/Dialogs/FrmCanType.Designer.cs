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
    partial class FrmCanType
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvList = new System.Windows.Forms.DataGridView();
            this.CanType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlControl = new System.Windows.Forms.Panel();
            this.DrpHoleSize = new NipponPaint.NpCommon.FormControls.LabelDropDown();
            this.NumMaxVolume = new NipponPaint.NpCommon.FormControls.LabelNumericUpDown();
            this.NumNormalVolume = new NipponPaint.NpCommon.FormControls.LabelNumericUpDown();
            this.NumEmptyCanWeight = new NipponPaint.NpCommon.FormControls.LabelNumericUpDown();
            this.TxtMaxVolume = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.TxtEmptyCanWeight = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.TxtNormalVolume = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.TxtCanType = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.dialogEditButtons = new NipponPaint.NpCommon.FormControls.DialogEditButtons();
            this.TxtHoleSize = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.TxtCanDescription = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).BeginInit();
            this.PnlControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvList
            // 
            this.DgvList.AllowUserToAddRows = false;
            this.DgvList.AllowUserToDeleteRows = false;
            this.DgvList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CanType,
            this.CanDescription});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvList.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvList.EnableHeadersVisualStyles = false;
            this.DgvList.Location = new System.Drawing.Point(12, 12);
            this.DgvList.MultiSelect = false;
            this.DgvList.Name = "DgvList";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DgvList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvList.RowTemplate.Height = 21;
            this.DgvList.Size = new System.Drawing.Size(977, 216);
            this.DgvList.TabIndex = 0;
            // 
            // CanType
            // 
            this.CanType.HeaderText = "缶タイプ";
            this.CanType.Name = "CanType";
            this.CanType.Width = 200;
            // 
            // CanDescription
            // 
            this.CanDescription.HeaderText = "缶詳細";
            this.CanDescription.Name = "CanDescription";
            this.CanDescription.Width = 200;
            // 
            // PnlControl
            // 
            this.PnlControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PnlControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlControl.Controls.Add(this.DrpHoleSize);
            this.PnlControl.Controls.Add(this.NumMaxVolume);
            this.PnlControl.Controls.Add(this.NumNormalVolume);
            this.PnlControl.Controls.Add(this.NumEmptyCanWeight);
            this.PnlControl.Controls.Add(this.TxtMaxVolume);
            this.PnlControl.Controls.Add(this.TxtEmptyCanWeight);
            this.PnlControl.Controls.Add(this.TxtNormalVolume);
            this.PnlControl.Controls.Add(this.TxtCanType);
            this.PnlControl.Controls.Add(this.dialogEditButtons);
            this.PnlControl.Controls.Add(this.TxtHoleSize);
            this.PnlControl.Controls.Add(this.TxtCanDescription);
            this.PnlControl.Location = new System.Drawing.Point(12, 238);
            this.PnlControl.Name = "PnlControl";
            this.PnlControl.Size = new System.Drawing.Size(977, 264);
            this.PnlControl.TabIndex = 18;
            // 
            // DrpHoleSize
            // 
            this.DrpHoleSize.DatabaseColumnName = "Hole_Size";
            this.DrpHoleSize.DisplayMemberField = "";
            this.DrpHoleSize.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DrpHoleSize.Id = "";
            this.DrpHoleSize.Location = new System.Drawing.Point(310, 79);
            this.DrpHoleSize.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DrpHoleSize.Name = "DrpHoleSize";
            this.DrpHoleSize.Size = new System.Drawing.Size(293, 31);
            this.DrpHoleSize.TabIndex = 24;
            this.DrpHoleSize.TableName = "";
            this.DrpHoleSize.TextBackColor = System.Drawing.SystemColors.Window;
            this.DrpHoleSize.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.DrpHoleSize.Title = "穴サイズ[mm](&S)";
            this.DrpHoleSize.TitleControlName = "LblTitle";
            this.DrpHoleSize.TitleSize = new System.Drawing.Size(154, 31);
            this.DrpHoleSize.ValueMemberField = "";
            // 
            // NumMaxVolume
            // 
            this.NumMaxVolume.DatabaseColumnName = "Available_Volume";
            this.NumMaxVolume.DecimalPlaces = 0;
            this.NumMaxVolume.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NumMaxVolume.Id = "";
            this.NumMaxVolume.Location = new System.Drawing.Point(310, 184);
            this.NumMaxVolume.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NumMaxVolume.Maximum = new decimal(new int[] {
            25000,
            0,
            0,
            0});
            this.NumMaxVolume.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumMaxVolume.Name = "NumMaxVolume";
            this.NumMaxVolume.Size = new System.Drawing.Size(293, 30);
            this.NumMaxVolume.TabIndex = 23;
            this.NumMaxVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NumMaxVolume.TextBackColor = System.Drawing.SystemColors.Window;
            this.NumMaxVolume.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.NumMaxVolume.Title = "最大容量[ml](&V)";
            this.NumMaxVolume.TitleControlName = "LblTitle";
            this.NumMaxVolume.TitleSize = new System.Drawing.Size(154, 30);
            this.NumMaxVolume.Value = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            // 
            // NumNormalVolume
            // 
            this.NumNormalVolume.DatabaseColumnName = "Nominal_Volume";
            this.NumNormalVolume.DecimalPlaces = 0;
            this.NumNormalVolume.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NumNormalVolume.Id = "";
            this.NumNormalVolume.Location = new System.Drawing.Point(310, 149);
            this.NumNormalVolume.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NumNormalVolume.Maximum = new decimal(new int[] {
            25000,
            0,
            0,
            0});
            this.NumNormalVolume.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumNormalVolume.Name = "NumNormalVolume";
            this.NumNormalVolume.Size = new System.Drawing.Size(293, 30);
            this.NumNormalVolume.TabIndex = 22;
            this.NumNormalVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NumNormalVolume.TextBackColor = System.Drawing.SystemColors.Window;
            this.NumNormalVolume.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.NumNormalVolume.Title = "通常容量[ml](&W)";
            this.NumNormalVolume.TitleControlName = "LblTitle";
            this.NumNormalVolume.TitleSize = new System.Drawing.Size(154, 30);
            this.NumNormalVolume.Value = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            // 
            // NumEmptyCanWeight
            // 
            this.NumEmptyCanWeight.DatabaseColumnName = "Can_Weight";
            this.NumEmptyCanWeight.DecimalPlaces = 0;
            this.NumEmptyCanWeight.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NumEmptyCanWeight.Id = "";
            this.NumEmptyCanWeight.Location = new System.Drawing.Point(310, 114);
            this.NumEmptyCanWeight.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NumEmptyCanWeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumEmptyCanWeight.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumEmptyCanWeight.Name = "NumEmptyCanWeight";
            this.NumEmptyCanWeight.Size = new System.Drawing.Size(293, 30);
            this.NumEmptyCanWeight.TabIndex = 21;
            this.NumEmptyCanWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NumEmptyCanWeight.TextBackColor = System.Drawing.SystemColors.Window;
            this.NumEmptyCanWeight.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.NumEmptyCanWeight.Title = "空缶重量[g](&A)";
            this.NumEmptyCanWeight.TitleControlName = "LblTitle";
            this.NumEmptyCanWeight.TitleSize = new System.Drawing.Size(154, 30);
            this.NumEmptyCanWeight.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // TxtMaxVolume
            // 
            this.TxtMaxVolume.DatabaseColumnName = "Available_Volume";
            this.TxtMaxVolume.DataControlName = "txtData";
            this.TxtMaxVolume.DataEnabled = true;
            this.TxtMaxVolume.DataReadOnly = false;
            this.TxtMaxVolume.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtMaxVolume.DataTextSize = new System.Drawing.Size(139, 30);
            this.TxtMaxVolume.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtMaxVolume.Id = "";
            this.TxtMaxVolume.Label = "";
            this.TxtMaxVolume.Location = new System.Drawing.Point(9, 184);
            this.TxtMaxVolume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtMaxVolume.MaxByteLength = 65535;
            this.TxtMaxVolume.MaxLength = 0;
            this.TxtMaxVolume.Name = "TxtMaxVolume";
            this.TxtMaxVolume.Size = new System.Drawing.Size(293, 30);
            this.TxtMaxVolume.TabIndex = 6;
            this.TxtMaxVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtMaxVolume.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtMaxVolume.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtMaxVolume.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtMaxVolume.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtMaxVolume.Title = "最大容量[ml](&V)";
            this.TxtMaxVolume.TitleControlName = "lblTitle";
            this.TxtMaxVolume.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtMaxVolume.Value = "";
            // 
            // TxtEmptyCanWeight
            // 
            this.TxtEmptyCanWeight.DatabaseColumnName = "Can_Weight";
            this.TxtEmptyCanWeight.DataControlName = "txtData";
            this.TxtEmptyCanWeight.DataEnabled = true;
            this.TxtEmptyCanWeight.DataReadOnly = false;
            this.TxtEmptyCanWeight.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtEmptyCanWeight.DataTextSize = new System.Drawing.Size(139, 30);
            this.TxtEmptyCanWeight.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtEmptyCanWeight.Id = "";
            this.TxtEmptyCanWeight.Label = "";
            this.TxtEmptyCanWeight.Location = new System.Drawing.Point(9, 114);
            this.TxtEmptyCanWeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtEmptyCanWeight.MaxByteLength = 65535;
            this.TxtEmptyCanWeight.MaxLength = 0;
            this.TxtEmptyCanWeight.Name = "TxtEmptyCanWeight";
            this.TxtEmptyCanWeight.Size = new System.Drawing.Size(293, 30);
            this.TxtEmptyCanWeight.TabIndex = 7;
            this.TxtEmptyCanWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtEmptyCanWeight.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtEmptyCanWeight.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtEmptyCanWeight.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtEmptyCanWeight.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtEmptyCanWeight.Title = "空缶重量[g](&A)";
            this.TxtEmptyCanWeight.TitleControlName = "lblTitle";
            this.TxtEmptyCanWeight.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtEmptyCanWeight.Value = "";
            // 
            // TxtNormalVolume
            // 
            this.TxtNormalVolume.DatabaseColumnName = "Nominal_Volume";
            this.TxtNormalVolume.DataControlName = "txtData";
            this.TxtNormalVolume.DataEnabled = true;
            this.TxtNormalVolume.DataReadOnly = false;
            this.TxtNormalVolume.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtNormalVolume.DataTextSize = new System.Drawing.Size(139, 30);
            this.TxtNormalVolume.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtNormalVolume.Id = "";
            this.TxtNormalVolume.Label = "";
            this.TxtNormalVolume.Location = new System.Drawing.Point(9, 149);
            this.TxtNormalVolume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNormalVolume.MaxByteLength = 65535;
            this.TxtNormalVolume.MaxLength = 0;
            this.TxtNormalVolume.Name = "TxtNormalVolume";
            this.TxtNormalVolume.Size = new System.Drawing.Size(293, 30);
            this.TxtNormalVolume.TabIndex = 5;
            this.TxtNormalVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtNormalVolume.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtNormalVolume.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtNormalVolume.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtNormalVolume.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtNormalVolume.Title = "通常容量[ml](&W)";
            this.TxtNormalVolume.TitleControlName = "lblTitle";
            this.TxtNormalVolume.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtNormalVolume.Value = "";
            // 
            // TxtCanType
            // 
            this.TxtCanType.DatabaseColumnName = "Can_Type";
            this.TxtCanType.DataControlName = "txtData";
            this.TxtCanType.DataEnabled = true;
            this.TxtCanType.DataReadOnly = false;
            this.TxtCanType.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtCanType.DataTextSize = new System.Drawing.Size(139, 30);
            this.TxtCanType.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtCanType.Id = "";
            this.TxtCanType.Label = "";
            this.TxtCanType.Location = new System.Drawing.Point(9, 9);
            this.TxtCanType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCanType.MaxByteLength = 65535;
            this.TxtCanType.MaxLength = 0;
            this.TxtCanType.Name = "TxtCanType";
            this.TxtCanType.Size = new System.Drawing.Size(293, 30);
            this.TxtCanType.TabIndex = 19;
            this.TxtCanType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCanType.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtCanType.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtCanType.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtCanType.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtCanType.Title = "缶タイプ(&T)";
            this.TxtCanType.TitleControlName = "lblTitle";
            this.TxtCanType.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtCanType.Value = "";
            // 
            // dialogEditButtons
            // 
            this.dialogEditButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dialogEditButtons.EditMode = NipponPaint.NpCommon.FormControls.DialogEditButtons.Mode.View;
            this.dialogEditButtons.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dialogEditButtons.InsertMethod = null;
            this.dialogEditButtons.Location = new System.Drawing.Point(736, 9);
            this.dialogEditButtons.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dialogEditButtons.MsgMethod = null;
            this.dialogEditButtons.Name = "dialogEditButtons";
            this.dialogEditButtons.Size = new System.Drawing.Size(230, 243);
            this.dialogEditButtons.TabIndex = 17;
            this.dialogEditButtons.UpdateMethod = null;
            this.dialogEditButtons.ValidationMethod = null;
            // 
            // TxtHoleSize
            // 
            this.TxtHoleSize.DatabaseColumnName = "Hole_Size";
            this.TxtHoleSize.DataControlName = "txtData";
            this.TxtHoleSize.DataEnabled = true;
            this.TxtHoleSize.DataReadOnly = false;
            this.TxtHoleSize.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtHoleSize.DataTextSize = new System.Drawing.Size(139, 30);
            this.TxtHoleSize.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtHoleSize.Id = "";
            this.TxtHoleSize.Label = "";
            this.TxtHoleSize.Location = new System.Drawing.Point(9, 79);
            this.TxtHoleSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtHoleSize.MaxByteLength = 65535;
            this.TxtHoleSize.MaxLength = 0;
            this.TxtHoleSize.Name = "TxtHoleSize";
            this.TxtHoleSize.Size = new System.Drawing.Size(293, 30);
            this.TxtHoleSize.TabIndex = 8;
            this.TxtHoleSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtHoleSize.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtHoleSize.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtHoleSize.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtHoleSize.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtHoleSize.Title = "穴サイズ[mm](&S)";
            this.TxtHoleSize.TitleControlName = "lblTitle";
            this.TxtHoleSize.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtHoleSize.Value = "";
            // 
            // TxtCanDescription
            // 
            this.TxtCanDescription.DatabaseColumnName = "Can_Description";
            this.TxtCanDescription.DataControlName = "txtData";
            this.TxtCanDescription.DataEnabled = true;
            this.TxtCanDescription.DataReadOnly = false;
            this.TxtCanDescription.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtCanDescription.DataTextSize = new System.Drawing.Size(565, 30);
            this.TxtCanDescription.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtCanDescription.Id = "";
            this.TxtCanDescription.Label = "";
            this.TxtCanDescription.Location = new System.Drawing.Point(9, 44);
            this.TxtCanDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCanDescription.MaxByteLength = 65535;
            this.TxtCanDescription.MaxLength = 0;
            this.TxtCanDescription.Name = "TxtCanDescription";
            this.TxtCanDescription.Size = new System.Drawing.Size(719, 30);
            this.TxtCanDescription.TabIndex = 16;
            this.TxtCanDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtCanDescription.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtCanDescription.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtCanDescription.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtCanDescription.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtCanDescription.Title = "缶詳細(&D)";
            this.TxtCanDescription.TitleControlName = "lblTitle";
            this.TxtCanDescription.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtCanDescription.Value = "";
            // 
            // FrmCanType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 514);
            this.ControlBox = false;
            this.Controls.Add(this.DgvList);
            this.Controls.Add(this.PnlControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmCanType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "缶タイプ";
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).EndInit();
            this.PnlControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvList;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtNormalVolume;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtMaxVolume;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtEmptyCanWeight;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtHoleSize;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtCanDescription;
        private NipponPaint.NpCommon.FormControls.DialogEditButtons dialogEditButtons;
        private System.Windows.Forms.Panel PnlControl;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtCanType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CanType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CanDescription;
        private NpCommon.FormControls.LabelNumericUpDown NumMaxVolume;
        private NpCommon.FormControls.LabelNumericUpDown NumNormalVolume;
        private NpCommon.FormControls.LabelNumericUpDown NumEmptyCanWeight;
        private NpCommon.FormControls.LabelDropDown DrpHoleSize;
    }
}