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
    partial class FrmCapType
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
            this.CapType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlControl = new System.Windows.Forms.Panel();
            this.DrpCappingMachine = new NipponPaint.NpCommon.FormControls.LabelDropDown();
            this.ChkManualCapping = new System.Windows.Forms.CheckBox();
            this.NumCapWeight = new NipponPaint.NpCommon.FormControls.LabelNumericUpDown();
            this.DrpCapSize = new NipponPaint.NpCommon.FormControls.LabelDropDown();
            this.TxtCapWeight = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.TxtCappingMachine = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.TxtCapType = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.dialogEditButtons = new NipponPaint.NpCommon.FormControls.DialogEditButtons();
            this.TxtCapSize = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.TxtCapDescription = new NipponPaint.NpCommon.FormControls.LabelTextBox();
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
            this.CapType,
            this.CapDescription});
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
            // CapType
            // 
            this.CapType.HeaderText = "キャップタイプ";
            this.CapType.Name = "CapType";
            this.CapType.Width = 200;
            // 
            // CapDescription
            // 
            this.CapDescription.HeaderText = "キャップ詳細";
            this.CapDescription.Name = "CapDescription";
            this.CapDescription.Width = 200;
            // 
            // PnlControl
            // 
            this.PnlControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PnlControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlControl.Controls.Add(this.DrpCappingMachine);
            this.PnlControl.Controls.Add(this.ChkManualCapping);
            this.PnlControl.Controls.Add(this.NumCapWeight);
            this.PnlControl.Controls.Add(this.DrpCapSize);
            this.PnlControl.Controls.Add(this.TxtCapWeight);
            this.PnlControl.Controls.Add(this.TxtCappingMachine);
            this.PnlControl.Controls.Add(this.TxtCapType);
            this.PnlControl.Controls.Add(this.dialogEditButtons);
            this.PnlControl.Controls.Add(this.TxtCapSize);
            this.PnlControl.Controls.Add(this.TxtCapDescription);
            this.PnlControl.Location = new System.Drawing.Point(12, 238);
            this.PnlControl.Name = "PnlControl";
            this.PnlControl.Size = new System.Drawing.Size(977, 264);
            this.PnlControl.TabIndex = 20;
            // 
            // DrpCappingMachine
            // 
            this.DrpCappingMachine.DatabaseColumnName = "Capping_Machine";
            this.DrpCappingMachine.DisplayMemberField = "";
            this.DrpCappingMachine.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DrpCappingMachine.Id = null;
            this.DrpCappingMachine.Location = new System.Drawing.Point(338, 148);
            this.DrpCappingMachine.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DrpCappingMachine.Name = "DrpCappingMachine";
            this.DrpCappingMachine.Size = new System.Drawing.Size(293, 31);
            this.DrpCappingMachine.TabIndex = 28;
            this.DrpCappingMachine.TableName = "";
            this.DrpCappingMachine.TextBackColor = System.Drawing.SystemColors.Window;
            this.DrpCappingMachine.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.DrpCappingMachine.Title = "キャッパー(&M)";
            this.DrpCappingMachine.TitleControlName = "LblTitle";
            this.DrpCappingMachine.TitleSize = new System.Drawing.Size(154, 31);
            this.DrpCappingMachine.ValueMemberField = "";
            // 
            // ChkManualCapping
            // 
            this.ChkManualCapping.AutoSize = true;
            this.ChkManualCapping.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkManualCapping.Font = new System.Drawing.Font("游ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ChkManualCapping.Location = new System.Drawing.Point(9, 187);
            this.ChkManualCapping.Name = "ChkManualCapping";
            this.ChkManualCapping.Size = new System.Drawing.Size(163, 24);
            this.ChkManualCapping.TabIndex = 27;
            this.ChkManualCapping.Text = "手動キャッピング　";
            this.ChkManualCapping.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkManualCapping.UseVisualStyleBackColor = true;
            // 
            // NumCapWeight
            // 
            this.NumCapWeight.DatabaseColumnName = "Cap_Weight";
            this.NumCapWeight.DecimalPlaces = 0;
            this.NumCapWeight.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NumCapWeight.Id = "";
            this.NumCapWeight.Location = new System.Drawing.Point(338, 114);
            this.NumCapWeight.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NumCapWeight.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NumCapWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumCapWeight.Name = "NumCapWeight";
            this.NumCapWeight.Size = new System.Drawing.Size(293, 30);
            this.NumCapWeight.TabIndex = 26;
            this.NumCapWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NumCapWeight.TextBackColor = System.Drawing.SystemColors.Window;
            this.NumCapWeight.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.NumCapWeight.Title = "キャップ重量[g](&W)";
            this.NumCapWeight.TitleControlName = "LblTitle";
            this.NumCapWeight.TitleSize = new System.Drawing.Size(154, 30);
            this.NumCapWeight.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // DrpCapSize
            // 
            this.DrpCapSize.DatabaseColumnName = "Hole_Size";
            this.DrpCapSize.DisplayMemberField = "";
            this.DrpCapSize.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DrpCapSize.Id = null;
            this.DrpCapSize.Location = new System.Drawing.Point(338, 79);
            this.DrpCapSize.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DrpCapSize.Name = "DrpCapSize";
            this.DrpCapSize.Size = new System.Drawing.Size(293, 31);
            this.DrpCapSize.TabIndex = 25;
            this.DrpCapSize.TableName = "";
            this.DrpCapSize.TextBackColor = System.Drawing.SystemColors.Window;
            this.DrpCapSize.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.DrpCapSize.Title = "ｷｬｯﾌﾟｻｲｽﾞ[mm](&S)";
            this.DrpCapSize.TitleControlName = "LblTitle";
            this.DrpCapSize.TitleSize = new System.Drawing.Size(154, 31);
            this.DrpCapSize.ValueMemberField = "";
            // 
            // TxtCapWeight
            // 
            this.TxtCapWeight.DatabaseColumnName = "Cap_Weight";
            this.TxtCapWeight.DataControlName = "txtData";
            this.TxtCapWeight.DataEnabled = true;
            this.TxtCapWeight.DataReadOnly = false;
            this.TxtCapWeight.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtCapWeight.DataTextSize = new System.Drawing.Size(139, 30);
            this.TxtCapWeight.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtCapWeight.Id = "";
            this.TxtCapWeight.Label = "";
            this.TxtCapWeight.Location = new System.Drawing.Point(9, 114);
            this.TxtCapWeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCapWeight.MaxByteLength = 65535;
            this.TxtCapWeight.MaxLength = 0;
            this.TxtCapWeight.Name = "TxtCapWeight";
            this.TxtCapWeight.Size = new System.Drawing.Size(293, 30);
            this.TxtCapWeight.TabIndex = 7;
            this.TxtCapWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCapWeight.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtCapWeight.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtCapWeight.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtCapWeight.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtCapWeight.Title = "キャップ重量[g](&W)";
            this.TxtCapWeight.TitleControlName = "lblTitle";
            this.TxtCapWeight.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtCapWeight.Value = "";
            // 
            // TxtCappingMachine
            // 
            this.TxtCappingMachine.DatabaseColumnName = "Capping_Machine";
            this.TxtCappingMachine.DataControlName = "txtData";
            this.TxtCappingMachine.DataEnabled = true;
            this.TxtCappingMachine.DataReadOnly = false;
            this.TxtCappingMachine.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtCappingMachine.DataTextSize = new System.Drawing.Size(139, 30);
            this.TxtCappingMachine.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtCappingMachine.Id = "";
            this.TxtCappingMachine.Label = "";
            this.TxtCappingMachine.Location = new System.Drawing.Point(9, 149);
            this.TxtCappingMachine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCappingMachine.MaxByteLength = 65535;
            this.TxtCappingMachine.MaxLength = 0;
            this.TxtCappingMachine.Name = "TxtCappingMachine";
            this.TxtCappingMachine.Size = new System.Drawing.Size(293, 30);
            this.TxtCappingMachine.TabIndex = 5;
            this.TxtCappingMachine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCappingMachine.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtCappingMachine.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtCappingMachine.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtCappingMachine.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtCappingMachine.Title = "キャッパー(&M)";
            this.TxtCappingMachine.TitleControlName = "lblTitle";
            this.TxtCappingMachine.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtCappingMachine.Value = "";
            // 
            // TxtCapType
            // 
            this.TxtCapType.DatabaseColumnName = "Cap_Type";
            this.TxtCapType.DataControlName = "txtData";
            this.TxtCapType.DataEnabled = true;
            this.TxtCapType.DataReadOnly = false;
            this.TxtCapType.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtCapType.DataTextSize = new System.Drawing.Size(139, 30);
            this.TxtCapType.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtCapType.Id = "";
            this.TxtCapType.Label = "";
            this.TxtCapType.Location = new System.Drawing.Point(9, 9);
            this.TxtCapType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCapType.MaxByteLength = 65535;
            this.TxtCapType.MaxLength = 0;
            this.TxtCapType.Name = "TxtCapType";
            this.TxtCapType.Size = new System.Drawing.Size(293, 30);
            this.TxtCapType.TabIndex = 19;
            this.TxtCapType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCapType.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtCapType.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtCapType.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtCapType.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtCapType.Title = "キャップタイプ(&A)";
            this.TxtCapType.TitleControlName = "lblTitle";
            this.TxtCapType.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtCapType.Value = "";
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
            // TxtCapSize
            // 
            this.TxtCapSize.DatabaseColumnName = "Hole_Size";
            this.TxtCapSize.DataControlName = "txtData";
            this.TxtCapSize.DataEnabled = true;
            this.TxtCapSize.DataReadOnly = false;
            this.TxtCapSize.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtCapSize.DataTextSize = new System.Drawing.Size(139, 30);
            this.TxtCapSize.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtCapSize.Id = "";
            this.TxtCapSize.Label = "";
            this.TxtCapSize.Location = new System.Drawing.Point(9, 79);
            this.TxtCapSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCapSize.MaxByteLength = 65535;
            this.TxtCapSize.MaxLength = 0;
            this.TxtCapSize.Name = "TxtCapSize";
            this.TxtCapSize.Size = new System.Drawing.Size(293, 30);
            this.TxtCapSize.TabIndex = 8;
            this.TxtCapSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCapSize.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtCapSize.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtCapSize.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtCapSize.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtCapSize.Title = "ｷｬｯﾌﾟｻｲｽﾞ[mm](&S)";
            this.TxtCapSize.TitleControlName = "lblTitle";
            this.TxtCapSize.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtCapSize.Value = "";
            // 
            // TxtCapDescription
            // 
            this.TxtCapDescription.DatabaseColumnName = "Cap_Description";
            this.TxtCapDescription.DataControlName = "txtData";
            this.TxtCapDescription.DataEnabled = true;
            this.TxtCapDescription.DataReadOnly = false;
            this.TxtCapDescription.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtCapDescription.DataTextSize = new System.Drawing.Size(565, 30);
            this.TxtCapDescription.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtCapDescription.Id = "";
            this.TxtCapDescription.Label = "";
            this.TxtCapDescription.Location = new System.Drawing.Point(9, 44);
            this.TxtCapDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCapDescription.MaxByteLength = 65535;
            this.TxtCapDescription.MaxLength = 0;
            this.TxtCapDescription.Name = "TxtCapDescription";
            this.TxtCapDescription.Size = new System.Drawing.Size(719, 30);
            this.TxtCapDescription.TabIndex = 16;
            this.TxtCapDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtCapDescription.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtCapDescription.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtCapDescription.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtCapDescription.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtCapDescription.Title = "キャップ詳細(&D)";
            this.TxtCapDescription.TitleControlName = "lblTitle";
            this.TxtCapDescription.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtCapDescription.Value = "";
            // 
            // FrmCapType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 514);
            this.ControlBox = false;
            this.Controls.Add(this.DgvList);
            this.Controls.Add(this.PnlControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmCapType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "キャップタイプ";
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).EndInit();
            this.PnlControl.ResumeLayout(false);
            this.PnlControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvList;
        private System.Windows.Forms.Panel PnlControl;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtCapWeight;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtCappingMachine;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtCapType;
        private NipponPaint.NpCommon.FormControls.DialogEditButtons dialogEditButtons;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtCapSize;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtCapDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapDescription;
        private NpCommon.FormControls.LabelDropDown DrpCapSize;
        private NpCommon.FormControls.LabelNumericUpDown NumCapWeight;
        private System.Windows.Forms.CheckBox ChkManualCapping;
        private NpCommon.FormControls.LabelDropDown DrpCappingMachine;
    }
}