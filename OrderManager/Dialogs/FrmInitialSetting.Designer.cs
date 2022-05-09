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
    partial class FrmInitialSetting
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
            this.DgvList = new System.Windows.Forms.DataGridView();
            this.WhiteCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlControl = new System.Windows.Forms.Panel();
            this.DrpWhiteCode = new NipponPaint.NpCommon.FormControls.LabelDropDown();
            this.DrpCap_Type = new NipponPaint.NpCommon.FormControls.LabelDropDown();
            this.DrpCan_Type = new NipponPaint.NpCommon.FormControls.LabelDropDown();
            this.NumMixingSpeed = new NipponPaint.NpCommon.FormControls.LabelNumericUpDown();
            this.NumMixingTime = new NipponPaint.NpCommon.FormControls.LabelNumericUpDown();
            this.NumFilledWeight = new NipponPaint.NpCommon.FormControls.LabelNumericUpDown();
            this.NumOverFilling = new NipponPaint.NpCommon.FormControls.LabelNumericUpDown();
            this.TxtCapType = new NipponPaint.NpCommon.FormControls.LabelCodeText();
            this.TxtCanType = new NipponPaint.NpCommon.FormControls.LabelCodeText();
            this.TxtMixingSpeed = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.TxtMixingTime = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.TxtOverFilling = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.TxtFilledWeight = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.TxtWhiteCode = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.dialogEditButtons = new NipponPaint.NpCommon.FormControls.DialogEditButtons();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).BeginInit();
            this.PnlControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvList
            // 
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
            this.WhiteCode});
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
            this.DgvList.Name = "DgvList";
            this.DgvList.RowTemplate.Height = 21;
            this.DgvList.Size = new System.Drawing.Size(977, 216);
            this.DgvList.TabIndex = 19;
            // 
            // WhiteCode
            // 
            this.WhiteCode.HeaderText = "白コード";
            this.WhiteCode.Name = "WhiteCode";
            this.WhiteCode.Width = 200;
            // 
            // PnlControl
            // 
            this.PnlControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PnlControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlControl.Controls.Add(this.DrpWhiteCode);
            this.PnlControl.Controls.Add(this.DrpCap_Type);
            this.PnlControl.Controls.Add(this.DrpCan_Type);
            this.PnlControl.Controls.Add(this.NumMixingSpeed);
            this.PnlControl.Controls.Add(this.NumMixingTime);
            this.PnlControl.Controls.Add(this.NumFilledWeight);
            this.PnlControl.Controls.Add(this.NumOverFilling);
            this.PnlControl.Controls.Add(this.TxtCapType);
            this.PnlControl.Controls.Add(this.TxtCanType);
            this.PnlControl.Controls.Add(this.TxtMixingSpeed);
            this.PnlControl.Controls.Add(this.TxtMixingTime);
            this.PnlControl.Controls.Add(this.TxtOverFilling);
            this.PnlControl.Controls.Add(this.TxtFilledWeight);
            this.PnlControl.Controls.Add(this.TxtWhiteCode);
            this.PnlControl.Controls.Add(this.dialogEditButtons);
            this.PnlControl.Location = new System.Drawing.Point(12, 238);
            this.PnlControl.Name = "PnlControl";
            this.PnlControl.Size = new System.Drawing.Size(977, 264);
            this.PnlControl.TabIndex = 20;
            // 
            // DrpWhiteCode
            // 
            this.DrpWhiteCode.DatabaseColumnName = "White_Code";
            this.DrpWhiteCode.DisplayMemberField = "";
            this.DrpWhiteCode.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DrpWhiteCode.Id = null;
            this.DrpWhiteCode.Location = new System.Drawing.Point(341, 9);
            this.DrpWhiteCode.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DrpWhiteCode.Name = "DrpWhiteCode";
            this.DrpWhiteCode.Size = new System.Drawing.Size(293, 31);
            this.DrpWhiteCode.TabIndex = 33;
            this.DrpWhiteCode.TableName = "Defaults";
            this.DrpWhiteCode.TextBackColor = System.Drawing.SystemColors.Window;
            this.DrpWhiteCode.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.DrpWhiteCode.Title = "白コード(&W)";
            this.DrpWhiteCode.TitleControlName = "LblTitle";
            this.DrpWhiteCode.TitleSize = new System.Drawing.Size(154, 31);
            this.DrpWhiteCode.ValueMemberField = "";
            // 
            // DrpCap_Type
            // 
            this.DrpCap_Type.DatabaseColumnName = "Cap_Type";
            this.DrpCap_Type.DisplayMemberField = "Cap_Description";
            this.DrpCap_Type.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DrpCap_Type.Id = null;
            this.DrpCap_Type.Location = new System.Drawing.Point(341, 79);
            this.DrpCap_Type.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DrpCap_Type.Name = "DrpCap_Type";
            this.DrpCap_Type.Size = new System.Drawing.Size(382, 31);
            this.DrpCap_Type.TabIndex = 32;
            this.DrpCap_Type.TableName = "Cap_types";
            this.DrpCap_Type.TextBackColor = System.Drawing.SystemColors.Window;
            this.DrpCap_Type.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.DrpCap_Type.Title = "キャップタイプ(A)";
            this.DrpCap_Type.TitleControlName = "LblTitle";
            this.DrpCap_Type.TitleSize = new System.Drawing.Size(154, 31);
            this.DrpCap_Type.ValueMemberField = "Cap_Type";
            // 
            // DrpCan_Type
            // 
            this.DrpCan_Type.DatabaseColumnName = "Can_Type";
            this.DrpCan_Type.DisplayMemberField = "Can_Description";
            this.DrpCan_Type.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DrpCan_Type.Id = null;
            this.DrpCan_Type.Location = new System.Drawing.Point(341, 44);
            this.DrpCan_Type.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DrpCan_Type.Name = "DrpCan_Type";
            this.DrpCan_Type.Size = new System.Drawing.Size(382, 31);
            this.DrpCan_Type.TabIndex = 31;
            this.DrpCan_Type.TableName = "Can_types";
            this.DrpCan_Type.TextBackColor = System.Drawing.SystemColors.Window;
            this.DrpCan_Type.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.DrpCan_Type.Title = "缶タイプ(T)";
            this.DrpCan_Type.TitleControlName = "LblTitle";
            this.DrpCan_Type.TitleSize = new System.Drawing.Size(154, 31);
            this.DrpCan_Type.ValueMemberField = "Can_Type";
            // 
            // NumMixingSpeed
            // 
            this.NumMixingSpeed.DatabaseColumnName = "Mixing_Speed";
            this.NumMixingSpeed.DecimalPlaces = 0;
            this.NumMixingSpeed.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NumMixingSpeed.Id = "";
            this.NumMixingSpeed.Location = new System.Drawing.Point(341, 219);
            this.NumMixingSpeed.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NumMixingSpeed.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.NumMixingSpeed.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NumMixingSpeed.Name = "NumMixingSpeed";
            this.NumMixingSpeed.Size = new System.Drawing.Size(293, 30);
            this.NumMixingSpeed.TabIndex = 30;
            this.NumMixingSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NumMixingSpeed.TextBackColor = System.Drawing.SystemColors.Window;
            this.NumMixingSpeed.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.NumMixingSpeed.Title = "ﾐｷｼﾝｸﾞｽﾋﾟｰﾄﾞ[回/分](&K)";
            this.NumMixingSpeed.TitleControlName = "LblTitle";
            this.NumMixingSpeed.TitleSize = new System.Drawing.Size(190, 30);
            this.NumMixingSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // NumMixingTime
            // 
            this.NumMixingTime.DatabaseColumnName = "Mixing_Time";
            this.NumMixingTime.DecimalPlaces = 0;
            this.NumMixingTime.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NumMixingTime.Id = "";
            this.NumMixingTime.Location = new System.Drawing.Point(341, 184);
            this.NumMixingTime.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NumMixingTime.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.NumMixingTime.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumMixingTime.Name = "NumMixingTime";
            this.NumMixingTime.Size = new System.Drawing.Size(293, 30);
            this.NumMixingTime.TabIndex = 29;
            this.NumMixingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NumMixingTime.TextBackColor = System.Drawing.SystemColors.Window;
            this.NumMixingTime.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.NumMixingTime.Title = "ﾐｷｼﾝｸﾞﾀｲﾑ[s](&J)";
            this.NumMixingTime.TitleControlName = "LblTitle";
            this.NumMixingTime.TitleSize = new System.Drawing.Size(154, 30);
            this.NumMixingTime.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // NumFilledWeight
            // 
            this.NumFilledWeight.DatabaseColumnName = "Prefill_Amount";
            this.NumFilledWeight.DecimalPlaces = 0;
            this.NumFilledWeight.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NumFilledWeight.Id = "";
            this.NumFilledWeight.Location = new System.Drawing.Point(341, 149);
            this.NumFilledWeight.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NumFilledWeight.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.NumFilledWeight.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumFilledWeight.Name = "NumFilledWeight";
            this.NumFilledWeight.Size = new System.Drawing.Size(293, 30);
            this.NumFilledWeight.TabIndex = 28;
            this.NumFilledWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NumFilledWeight.TextBackColor = System.Drawing.SystemColors.Window;
            this.NumFilledWeight.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.NumFilledWeight.Title = "充填済み重量[g](&H)";
            this.NumFilledWeight.TitleControlName = "LblTitle";
            this.NumFilledWeight.TitleSize = new System.Drawing.Size(154, 30);
            this.NumFilledWeight.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // NumOverFilling
            // 
            this.NumOverFilling.DatabaseColumnName = "Overfilling";
            this.NumOverFilling.DecimalPlaces = 0;
            this.NumOverFilling.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NumOverFilling.Id = "";
            this.NumOverFilling.Location = new System.Drawing.Point(341, 116);
            this.NumOverFilling.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NumOverFilling.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumOverFilling.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumOverFilling.Name = "NumOverFilling";
            this.NumOverFilling.Size = new System.Drawing.Size(293, 30);
            this.NumOverFilling.TabIndex = 27;
            this.NumOverFilling.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NumOverFilling.TextBackColor = System.Drawing.SystemColors.Window;
            this.NumOverFilling.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.NumOverFilling.Title = "超過[%](&V)";
            this.NumOverFilling.TitleControlName = "LblTitle";
            this.NumOverFilling.TitleSize = new System.Drawing.Size(154, 30);
            this.NumOverFilling.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // TxtCapType
            // 
            this.TxtCapType.CodeControlName = "TxtCapType";
            this.TxtCapType.CodeReadOnly = false;
            this.TxtCapType.CodeText = "";
            this.TxtCapType.CodeTextSize = new System.Drawing.Size(60, 30);
            this.TxtCapType.DatabaseColumnCode = "Cap_Type";
            this.TxtCapType.DatabaseColumnName = "Cap_Description";
            this.TxtCapType.DataControlName = "TxtCapDescription";
            this.TxtCapType.DataReadOnly = false;
            this.TxtCapType.DataTextSize = new System.Drawing.Size(170, 30);
            this.TxtCapType.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtCapType.Location = new System.Drawing.Point(9, 79);
            this.TxtCapType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtCapType.Name = "TxtCapType";
            this.TxtCapType.Size = new System.Drawing.Size(382, 30);
            this.TxtCapType.TabIndex = 26;
            this.TxtCapType.TextAlignCode = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCapType.TextAlignData = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtCapType.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtCapType.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtCapType.Title = "キャップタイプ(&A)";
            this.TxtCapType.TitleControlName = "LblTitle";
            this.TxtCapType.TitleSize = new System.Drawing.Size(154, 30);
            // 
            // TxtCanType
            // 
            this.TxtCanType.CodeControlName = "TxtCanType";
            this.TxtCanType.CodeReadOnly = false;
            this.TxtCanType.CodeText = "";
            this.TxtCanType.CodeTextSize = new System.Drawing.Size(60, 30);
            this.TxtCanType.DatabaseColumnCode = "Can_Type";
            this.TxtCanType.DatabaseColumnName = "Can_Description";
            this.TxtCanType.DataControlName = "TxtCanDescription";
            this.TxtCanType.DataReadOnly = false;
            this.TxtCanType.DataTextSize = new System.Drawing.Size(170, 30);
            this.TxtCanType.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtCanType.Location = new System.Drawing.Point(9, 44);
            this.TxtCanType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtCanType.Name = "TxtCanType";
            this.TxtCanType.Size = new System.Drawing.Size(382, 30);
            this.TxtCanType.TabIndex = 25;
            this.TxtCanType.TextAlignCode = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCanType.TextAlignData = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtCanType.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtCanType.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtCanType.Title = "缶タイプ(&T)";
            this.TxtCanType.TitleControlName = "LblTitle";
            this.TxtCanType.TitleSize = new System.Drawing.Size(154, 30);
            // 
            // TxtMixingSpeed
            // 
            this.TxtMixingSpeed.DatabaseColumnName = "Mixing_Speed";
            this.TxtMixingSpeed.DataControlName = "txtData";
            this.TxtMixingSpeed.DataEnabled = true;
            this.TxtMixingSpeed.DataReadOnly = false;
            this.TxtMixingSpeed.DataTextLocation = new System.Drawing.Point(190, 0);
            this.TxtMixingSpeed.DataTextSize = new System.Drawing.Size(103, 30);
            this.TxtMixingSpeed.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtMixingSpeed.Id = "";
            this.TxtMixingSpeed.Label = "";
            this.TxtMixingSpeed.Location = new System.Drawing.Point(9, 219);
            this.TxtMixingSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtMixingSpeed.MaxByteLength = 65535;
            this.TxtMixingSpeed.MaxLength = 0;
            this.TxtMixingSpeed.Name = "TxtMixingSpeed";
            this.TxtMixingSpeed.Size = new System.Drawing.Size(293, 30);
            this.TxtMixingSpeed.TabIndex = 20;
            this.TxtMixingSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtMixingSpeed.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtMixingSpeed.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtMixingSpeed.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtMixingSpeed.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtMixingSpeed.Title = "ﾐｷｼﾝｸﾞｽﾋﾟｰﾄﾞ(回/分)(&K)";
            this.TxtMixingSpeed.TitleControlName = "lblTitle";
            this.TxtMixingSpeed.TitleSize = new System.Drawing.Size(190, 30);
            this.TxtMixingSpeed.Value = "";
            // 
            // TxtMixingTime
            // 
            this.TxtMixingTime.DatabaseColumnName = "Mixing_Time";
            this.TxtMixingTime.DataControlName = "txtData";
            this.TxtMixingTime.DataEnabled = true;
            this.TxtMixingTime.DataReadOnly = false;
            this.TxtMixingTime.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtMixingTime.DataTextSize = new System.Drawing.Size(139, 30);
            this.TxtMixingTime.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtMixingTime.Id = "";
            this.TxtMixingTime.Label = "";
            this.TxtMixingTime.Location = new System.Drawing.Point(9, 184);
            this.TxtMixingTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtMixingTime.MaxByteLength = 65535;
            this.TxtMixingTime.MaxLength = 0;
            this.TxtMixingTime.Name = "TxtMixingTime";
            this.TxtMixingTime.Size = new System.Drawing.Size(293, 30);
            this.TxtMixingTime.TabIndex = 6;
            this.TxtMixingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtMixingTime.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtMixingTime.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtMixingTime.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtMixingTime.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtMixingTime.Title = "ﾐｷｼﾝｸﾞﾀｲﾑ[s](&J)";
            this.TxtMixingTime.TitleControlName = "lblTitle";
            this.TxtMixingTime.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtMixingTime.Value = "";
            // 
            // TxtOverFilling
            // 
            this.TxtOverFilling.DatabaseColumnName = "Overfilling";
            this.TxtOverFilling.DataControlName = "txtData";
            this.TxtOverFilling.DataEnabled = true;
            this.TxtOverFilling.DataReadOnly = false;
            this.TxtOverFilling.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtOverFilling.DataTextSize = new System.Drawing.Size(139, 30);
            this.TxtOverFilling.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtOverFilling.Id = "";
            this.TxtOverFilling.Label = "";
            this.TxtOverFilling.Location = new System.Drawing.Point(9, 114);
            this.TxtOverFilling.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtOverFilling.MaxByteLength = 65535;
            this.TxtOverFilling.MaxLength = 0;
            this.TxtOverFilling.Name = "TxtOverFilling";
            this.TxtOverFilling.Size = new System.Drawing.Size(293, 30);
            this.TxtOverFilling.TabIndex = 7;
            this.TxtOverFilling.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtOverFilling.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtOverFilling.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtOverFilling.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtOverFilling.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtOverFilling.Title = "超過[%](&V)";
            this.TxtOverFilling.TitleControlName = "lblTitle";
            this.TxtOverFilling.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtOverFilling.Value = "";
            // 
            // TxtFilledWeight
            // 
            this.TxtFilledWeight.DatabaseColumnName = "Prefill_Amount";
            this.TxtFilledWeight.DataControlName = "txtData";
            this.TxtFilledWeight.DataEnabled = true;
            this.TxtFilledWeight.DataReadOnly = false;
            this.TxtFilledWeight.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtFilledWeight.DataTextSize = new System.Drawing.Size(139, 30);
            this.TxtFilledWeight.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtFilledWeight.Id = "";
            this.TxtFilledWeight.Label = "";
            this.TxtFilledWeight.Location = new System.Drawing.Point(9, 149);
            this.TxtFilledWeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtFilledWeight.MaxByteLength = 65535;
            this.TxtFilledWeight.MaxLength = 0;
            this.TxtFilledWeight.Name = "TxtFilledWeight";
            this.TxtFilledWeight.Size = new System.Drawing.Size(293, 30);
            this.TxtFilledWeight.TabIndex = 5;
            this.TxtFilledWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtFilledWeight.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtFilledWeight.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtFilledWeight.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtFilledWeight.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtFilledWeight.Title = "充填済み重量(g)(&H)";
            this.TxtFilledWeight.TitleControlName = "lblTitle";
            this.TxtFilledWeight.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtFilledWeight.Value = "";
            // 
            // TxtWhiteCode
            // 
            this.TxtWhiteCode.DatabaseColumnName = "White_Code";
            this.TxtWhiteCode.DataControlName = "txtData";
            this.TxtWhiteCode.DataEnabled = true;
            this.TxtWhiteCode.DataReadOnly = false;
            this.TxtWhiteCode.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtWhiteCode.DataTextSize = new System.Drawing.Size(139, 30);
            this.TxtWhiteCode.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtWhiteCode.Id = "";
            this.TxtWhiteCode.Label = "";
            this.TxtWhiteCode.Location = new System.Drawing.Point(9, 9);
            this.TxtWhiteCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtWhiteCode.MaxByteLength = 65535;
            this.TxtWhiteCode.MaxLength = 0;
            this.TxtWhiteCode.Name = "TxtWhiteCode";
            this.TxtWhiteCode.Size = new System.Drawing.Size(293, 30);
            this.TxtWhiteCode.TabIndex = 19;
            this.TxtWhiteCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtWhiteCode.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtWhiteCode.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtWhiteCode.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtWhiteCode.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtWhiteCode.Title = "白コード(&W)";
            this.TxtWhiteCode.TitleControlName = "lblTitle";
            this.TxtWhiteCode.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtWhiteCode.Value = "";
            // 
            // dialogEditButtons
            // 
            this.dialogEditButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dialogEditButtons.EditMode = NipponPaint.NpCommon.FormControls.DialogEditButtons.Mode.View;
            this.dialogEditButtons.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dialogEditButtons.InsertMethod = null;
            this.dialogEditButtons.Location = new System.Drawing.Point(735, 9);
            this.dialogEditButtons.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dialogEditButtons.MsgMethod = null;
            this.dialogEditButtons.Name = "dialogEditButtons";
            this.dialogEditButtons.Size = new System.Drawing.Size(230, 243);
            this.dialogEditButtons.TabIndex = 17;
            this.dialogEditButtons.UpdateMethod = null;
            this.dialogEditButtons.ValidationMethod = null;
            // 
            // FrmInitialSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 514);
            this.ControlBox = false;
            this.Controls.Add(this.DgvList);
            this.Controls.Add(this.PnlControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "FrmInitialSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "初期設定";
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).EndInit();
            this.PnlControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NipponPaint.NpCommon.FormControls.DialogEditButtons dialogEditButtons;
        private System.Windows.Forms.DataGridView DgvList;
        private System.Windows.Forms.Panel PnlControl;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtMixingTime;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtOverFilling;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtFilledWeight;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtWhiteCode;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtMixingSpeed;
        private NipponPaint.NpCommon.FormControls.LabelCodeText TxtCapType;
        private NipponPaint.NpCommon.FormControls.LabelCodeText TxtCanType;
        private System.Windows.Forms.DataGridViewTextBoxColumn WhiteCode;
        private NpCommon.FormControls.LabelNumericUpDown NumOverFilling;
        private NpCommon.FormControls.LabelNumericUpDown NumFilledWeight;
        private NpCommon.FormControls.LabelNumericUpDown NumMixingSpeed;
        private NpCommon.FormControls.LabelNumericUpDown NumMixingTime;
        private NpCommon.FormControls.LabelDropDown DrpCan_Type;
        private NpCommon.FormControls.LabelDropDown DrpCap_Type;
        private NpCommon.FormControls.LabelDropDown DrpWhiteCode;
    }
}