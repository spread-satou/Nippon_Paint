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
    partial class FrmNPProductCodeMaster
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
            this.NPProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NPProductCode2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volume2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlControl = new System.Windows.Forms.Panel();
            this.TxtNPProductCodeID = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.LblSelectBack = new System.Windows.Forms.Label();
            this.LblSelectFront = new System.Windows.Forms.Label();
            this.TxtVolumeBack = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.TxtNPProductCodeMasterBack = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.TxtVolumeFront = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.TxtNPProductCodeMasterFront = new NipponPaint.NpCommon.FormControls.LabelTextBox();
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
            this.NPProductCode,
            this.Volume,
            this.NPProductCode2,
            this.Volume2});
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
            this.DgvList.TabIndex = 23;
            // 
            // NPProductCode
            // 
            this.NPProductCode.HeaderText = "NP商品コードマスター";
            this.NPProductCode.Name = "NPProductCode";
            this.NPProductCode.Width = 200;
            // 
            // Volume
            // 
            this.Volume.HeaderText = "容量";
            this.Volume.Name = "Volume";
            this.Volume.Width = 200;
            // 
            // NPProductCode2
            // 
            this.NPProductCode2.HeaderText = "NP商品コードマスター";
            this.NPProductCode2.Name = "NPProductCode2";
            this.NPProductCode2.Width = 200;
            // 
            // Volume2
            // 
            this.Volume2.HeaderText = "容量";
            this.Volume2.Name = "Volume2";
            this.Volume2.Width = 200;
            // 
            // PnlControl
            // 
            this.PnlControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PnlControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlControl.Controls.Add(this.TxtNPProductCodeID);
            this.PnlControl.Controls.Add(this.LblSelectBack);
            this.PnlControl.Controls.Add(this.LblSelectFront);
            this.PnlControl.Controls.Add(this.TxtVolumeBack);
            this.PnlControl.Controls.Add(this.TxtNPProductCodeMasterBack);
            this.PnlControl.Controls.Add(this.TxtVolumeFront);
            this.PnlControl.Controls.Add(this.TxtNPProductCodeMasterFront);
            this.PnlControl.Controls.Add(this.dialogEditButtons);
            this.PnlControl.Location = new System.Drawing.Point(12, 238);
            this.PnlControl.Name = "PnlControl";
            this.PnlControl.Size = new System.Drawing.Size(977, 264);
            this.PnlControl.TabIndex = 24;
            // 
            // TxtNPProductCodeID
            // 
            this.TxtNPProductCodeID.DatabaseColumnName = "VAR_ID";
            this.TxtNPProductCodeID.DataControlName = "txtData";
            this.TxtNPProductCodeID.DataEnabled = true;
            this.TxtNPProductCodeID.DataReadOnly = false;
            this.TxtNPProductCodeID.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtNPProductCodeID.DataTextSize = new System.Drawing.Size(139, 30);
            this.TxtNPProductCodeID.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtNPProductCodeID.Id = "";
            this.TxtNPProductCodeID.Label = "";
            this.TxtNPProductCodeID.Location = new System.Drawing.Point(179, 160);
            this.TxtNPProductCodeID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNPProductCodeID.MaxByteLength = 65535;
            this.TxtNPProductCodeID.MaxLength = 0;
            this.TxtNPProductCodeID.Name = "TxtNPProductCodeID";
            this.TxtNPProductCodeID.Size = new System.Drawing.Size(293, 30);
            this.TxtNPProductCodeID.TabIndex = 26;
            this.TxtNPProductCodeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtNPProductCodeID.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtNPProductCodeID.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtNPProductCodeID.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtNPProductCodeID.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtNPProductCodeID.Title = "NP商品コードID(&I)";
            this.TxtNPProductCodeID.TitleControlName = "lblTitle";
            this.TxtNPProductCodeID.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtNPProductCodeID.Value = "";
            // 
            // LblSelectBack
            // 
            this.LblSelectBack.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblSelectBack.Location = new System.Drawing.Point(505, 9);
            this.LblSelectBack.Name = "LblSelectBack";
            this.LblSelectBack.Size = new System.Drawing.Size(139, 23);
            this.LblSelectBack.TabIndex = 25;
            this.LblSelectBack.Text = "後選択";
            this.LblSelectBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSelectFront
            // 
            this.LblSelectFront.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblSelectFront.Location = new System.Drawing.Point(163, 9);
            this.LblSelectFront.Name = "LblSelectFront";
            this.LblSelectFront.Size = new System.Drawing.Size(139, 23);
            this.LblSelectFront.TabIndex = 24;
            this.LblSelectFront.Text = "前選択";
            this.LblSelectFront.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtVolumeBack
            // 
            this.TxtVolumeBack.DatabaseColumnName = "Package_NEW";
            this.TxtVolumeBack.DataControlName = "txtData";
            this.TxtVolumeBack.DataEnabled = true;
            this.TxtVolumeBack.DataReadOnly = false;
            this.TxtVolumeBack.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtVolumeBack.DataTextSize = new System.Drawing.Size(139, 30);
            this.TxtVolumeBack.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtVolumeBack.Id = "";
            this.TxtVolumeBack.Label = "";
            this.TxtVolumeBack.Location = new System.Drawing.Point(351, 80);
            this.TxtVolumeBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtVolumeBack.MaxByteLength = 65535;
            this.TxtVolumeBack.MaxLength = 0;
            this.TxtVolumeBack.Name = "TxtVolumeBack";
            this.TxtVolumeBack.Size = new System.Drawing.Size(293, 30);
            this.TxtVolumeBack.TabIndex = 23;
            this.TxtVolumeBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtVolumeBack.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtVolumeBack.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtVolumeBack.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtVolumeBack.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtVolumeBack.Title = "容量(&P)";
            this.TxtVolumeBack.TitleControlName = "lblTitle";
            this.TxtVolumeBack.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtVolumeBack.Value = "";
            // 
            // TxtNPProductCodeMasterBack
            // 
            this.TxtNPProductCodeMasterBack.DatabaseColumnName = "Variety_Code_NEW";
            this.TxtNPProductCodeMasterBack.DataControlName = "txtData";
            this.TxtNPProductCodeMasterBack.DataEnabled = true;
            this.TxtNPProductCodeMasterBack.DataReadOnly = false;
            this.TxtNPProductCodeMasterBack.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtNPProductCodeMasterBack.DataTextSize = new System.Drawing.Size(139, 30);
            this.TxtNPProductCodeMasterBack.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtNPProductCodeMasterBack.Id = "";
            this.TxtNPProductCodeMasterBack.Label = "";
            this.TxtNPProductCodeMasterBack.Location = new System.Drawing.Point(351, 45);
            this.TxtNPProductCodeMasterBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNPProductCodeMasterBack.MaxByteLength = 65535;
            this.TxtNPProductCodeMasterBack.MaxLength = 0;
            this.TxtNPProductCodeMasterBack.Name = "TxtNPProductCodeMasterBack";
            this.TxtNPProductCodeMasterBack.Size = new System.Drawing.Size(293, 30);
            this.TxtNPProductCodeMasterBack.TabIndex = 22;
            this.TxtNPProductCodeMasterBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtNPProductCodeMasterBack.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtNPProductCodeMasterBack.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtNPProductCodeMasterBack.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtNPProductCodeMasterBack.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtNPProductCodeMasterBack.Title = "NP商品ｺｰﾄﾞﾏｽﾀｰ(&B)";
            this.TxtNPProductCodeMasterBack.TitleControlName = "lblTitle";
            this.TxtNPProductCodeMasterBack.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtNPProductCodeMasterBack.Value = "";
            // 
            // TxtVolumeFront
            // 
            this.TxtVolumeFront.DatabaseColumnName = "Package_OLD";
            this.TxtVolumeFront.DataControlName = "txtData";
            this.TxtVolumeFront.DataEnabled = true;
            this.TxtVolumeFront.DataReadOnly = false;
            this.TxtVolumeFront.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtVolumeFront.DataTextSize = new System.Drawing.Size(139, 30);
            this.TxtVolumeFront.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtVolumeFront.Id = "";
            this.TxtVolumeFront.Label = "";
            this.TxtVolumeFront.Location = new System.Drawing.Point(9, 80);
            this.TxtVolumeFront.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtVolumeFront.MaxByteLength = 65535;
            this.TxtVolumeFront.MaxLength = 0;
            this.TxtVolumeFront.Name = "TxtVolumeFront";
            this.TxtVolumeFront.Size = new System.Drawing.Size(293, 30);
            this.TxtVolumeFront.TabIndex = 21;
            this.TxtVolumeFront.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtVolumeFront.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtVolumeFront.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtVolumeFront.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtVolumeFront.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtVolumeFront.Title = "容量(&C)";
            this.TxtVolumeFront.TitleControlName = "lblTitle";
            this.TxtVolumeFront.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtVolumeFront.Value = "";
            // 
            // TxtNPProductCodeMasterFront
            // 
            this.TxtNPProductCodeMasterFront.DatabaseColumnName = "Variety_Code_OLD";
            this.TxtNPProductCodeMasterFront.DataControlName = "txtData";
            this.TxtNPProductCodeMasterFront.DataEnabled = true;
            this.TxtNPProductCodeMasterFront.DataReadOnly = false;
            this.TxtNPProductCodeMasterFront.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtNPProductCodeMasterFront.DataTextSize = new System.Drawing.Size(139, 30);
            this.TxtNPProductCodeMasterFront.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtNPProductCodeMasterFront.Id = "";
            this.TxtNPProductCodeMasterFront.Label = "";
            this.TxtNPProductCodeMasterFront.Location = new System.Drawing.Point(9, 45);
            this.TxtNPProductCodeMasterFront.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNPProductCodeMasterFront.MaxByteLength = 65535;
            this.TxtNPProductCodeMasterFront.MaxLength = 0;
            this.TxtNPProductCodeMasterFront.Name = "TxtNPProductCodeMasterFront";
            this.TxtNPProductCodeMasterFront.Size = new System.Drawing.Size(293, 30);
            this.TxtNPProductCodeMasterFront.TabIndex = 20;
            this.TxtNPProductCodeMasterFront.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtNPProductCodeMasterFront.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtNPProductCodeMasterFront.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtNPProductCodeMasterFront.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtNPProductCodeMasterFront.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtNPProductCodeMasterFront.Title = "NP商品ｺｰﾄﾞﾏｽﾀｰ(&F)";
            this.TxtNPProductCodeMasterFront.TitleControlName = "lblTitle";
            this.TxtNPProductCodeMasterFront.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtNPProductCodeMasterFront.Value = "";
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
            // FrmNPProductCodeMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 514);
            this.ControlBox = false;
            this.Controls.Add(this.DgvList);
            this.Controls.Add(this.PnlControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmNPProductCodeMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NP商品コードマスタ";
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).EndInit();
            this.PnlControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvList;
        private System.Windows.Forms.Panel PnlControl;
        private NipponPaint.NpCommon.FormControls.DialogEditButtons dialogEditButtons;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtVolumeBack;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtNPProductCodeMasterBack;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtVolumeFront;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtNPProductCodeMasterFront;
        private System.Windows.Forms.Label LblSelectFront;
        private System.Windows.Forms.Label LblSelectBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn NPProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn NPProductCode2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volume2;
        private NpCommon.FormControls.LabelTextBox TxtNPProductCodeID;
    }
}