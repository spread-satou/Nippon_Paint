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
    partial class FrmSetting
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
        /// </summary>//
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvList = new System.Windows.Forms.DataGridView();
            this.CCMPaintName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormalPaintName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlControl = new System.Windows.Forms.Panel();
            this.DrpLabels = new NipponPaint.NpCommon.FormControls.LabelDropDown();
            this.TxtLabelType = new NipponPaint.NpCommon.FormControls.LabelCodeText();
            this.TxtFormalPaintName = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.TxtCCMPaintName = new NipponPaint.NpCommon.FormControls.LabelTextBox();
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
            this.CCMPaintName,
            this.FormalPaintName});
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
            this.DgvList.TabIndex = 25;
            // 
            // CCMPaintName
            // 
            this.CCMPaintName.HeaderText = "CCM品種名";
            this.CCMPaintName.Name = "CCMPaintName";
            this.CCMPaintName.Width = 200;
            // 
            // FormalPaintName
            // 
            this.FormalPaintName.HeaderText = "正式品種名";
            this.FormalPaintName.Name = "FormalPaintName";
            this.FormalPaintName.Width = 200;
            // 
            // PnlControl
            // 
            this.PnlControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PnlControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlControl.Controls.Add(this.DrpLabels);
            this.PnlControl.Controls.Add(this.TxtLabelType);
            this.PnlControl.Controls.Add(this.TxtFormalPaintName);
            this.PnlControl.Controls.Add(this.TxtCCMPaintName);
            this.PnlControl.Controls.Add(this.dialogEditButtons);
            this.PnlControl.Location = new System.Drawing.Point(12, 238);
            this.PnlControl.Name = "PnlControl";
            this.PnlControl.Size = new System.Drawing.Size(977, 264);
            this.PnlControl.TabIndex = 26;
            // 
            // DrpLabels
            // 
            this.DrpLabels.DatabaseColumnName = "Label_Type";
            this.DrpLabels.DisplayMemberField = "Label_Description";
            this.DrpLabels.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DrpLabels.Id = null;
            this.DrpLabels.Location = new System.Drawing.Point(9, 119);
            this.DrpLabels.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DrpLabels.Name = "DrpLabels";
            this.DrpLabels.Size = new System.Drawing.Size(511, 31);
            this.DrpLabels.TabIndex = 27;
            this.DrpLabels.TableName = "Labels";
            this.DrpLabels.TextBackColor = System.Drawing.SystemColors.Window;
            this.DrpLabels.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.DrpLabels.Title = "ラベルタイプ(L)";
            this.DrpLabels.TitleControlName = "LblTitle";
            this.DrpLabels.TitleSize = new System.Drawing.Size(154, 31);
            this.DrpLabels.ValueMemberField = "Label_Type";
            // 
            // TxtLabelType
            // 
            this.TxtLabelType.CodeControlName = "TxtLabelType";
            this.TxtLabelType.CodeReadOnly = false;
            this.TxtLabelType.CodeText = "";
            this.TxtLabelType.CodeTextSize = new System.Drawing.Size(80, 30);
            this.TxtLabelType.DatabaseColumnCode = "Label_Type";
            this.TxtLabelType.DatabaseColumnName = "Label_Description";
            this.TxtLabelType.DataControlName = "TxtLabelDescription";
            this.TxtLabelType.DataReadOnly = false;
            this.TxtLabelType.DataTextSize = new System.Drawing.Size(278, 30);
            this.TxtLabelType.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtLabelType.Location = new System.Drawing.Point(9, 79);
            this.TxtLabelType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtLabelType.Name = "TxtLabelType";
            this.TxtLabelType.Size = new System.Drawing.Size(511, 30);
            this.TxtLabelType.TabIndex = 26;
            this.TxtLabelType.TextAlignCode = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtLabelType.TextAlignData = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtLabelType.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtLabelType.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtLabelType.Title = "ラベルタイプ(&L)";
            this.TxtLabelType.TitleControlName = "LblTitle";
            this.TxtLabelType.TitleSize = new System.Drawing.Size(154, 30);
            // 
            // TxtFormalPaintName
            // 
            this.TxtFormalPaintName.DatabaseColumnName = "Formal_Name";
            this.TxtFormalPaintName.DataControlName = "txtData";
            this.TxtFormalPaintName.DataEnabled = true;
            this.TxtFormalPaintName.DataReadOnly = false;
            this.TxtFormalPaintName.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtFormalPaintName.DataTextSize = new System.Drawing.Size(565, 30);
            this.TxtFormalPaintName.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtFormalPaintName.Id = "";
            this.TxtFormalPaintName.Label = "";
            this.TxtFormalPaintName.Location = new System.Drawing.Point(9, 44);
            this.TxtFormalPaintName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtFormalPaintName.MaxByteLength = 65535;
            this.TxtFormalPaintName.MaxLength = 0;
            this.TxtFormalPaintName.Name = "TxtFormalPaintName";
            this.TxtFormalPaintName.Size = new System.Drawing.Size(719, 30);
            this.TxtFormalPaintName.TabIndex = 21;
            this.TxtFormalPaintName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtFormalPaintName.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtFormalPaintName.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtFormalPaintName.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtFormalPaintName.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtFormalPaintName.Title = "正式品種名(&F)";
            this.TxtFormalPaintName.TitleControlName = "lblTitle";
            this.TxtFormalPaintName.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtFormalPaintName.Value = "";
            // 
            // TxtCCMPaintName
            // 
            this.TxtCCMPaintName.DatabaseColumnName = "CCM_Paint_Name";
            this.TxtCCMPaintName.DataControlName = "txtData";
            this.TxtCCMPaintName.DataEnabled = true;
            this.TxtCCMPaintName.DataReadOnly = false;
            this.TxtCCMPaintName.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtCCMPaintName.DataTextSize = new System.Drawing.Size(565, 30);
            this.TxtCCMPaintName.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtCCMPaintName.Id = "";
            this.TxtCCMPaintName.Label = "";
            this.TxtCCMPaintName.Location = new System.Drawing.Point(9, 9);
            this.TxtCCMPaintName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCCMPaintName.MaxByteLength = 65535;
            this.TxtCCMPaintName.MaxLength = 0;
            this.TxtCCMPaintName.Name = "TxtCCMPaintName";
            this.TxtCCMPaintName.Size = new System.Drawing.Size(719, 30);
            this.TxtCCMPaintName.TabIndex = 20;
            this.TxtCCMPaintName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtCCMPaintName.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtCCMPaintName.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtCCMPaintName.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtCCMPaintName.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtCCMPaintName.Title = "CCM品種名(&C)";
            this.TxtCCMPaintName.TitleControlName = "lblTitle";
            this.TxtCCMPaintName.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtCCMPaintName.Value = "";
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
            // FrmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 514);
            this.ControlBox = false;
            this.Controls.Add(this.DgvList);
            this.Controls.Add(this.PnlControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "設定";
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).EndInit();
            this.PnlControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvList;
        private System.Windows.Forms.Panel PnlControl;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtFormalPaintName;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtCCMPaintName;
        private NipponPaint.NpCommon.FormControls.DialogEditButtons dialogEditButtons;
        private NipponPaint.NpCommon.FormControls.LabelCodeText TxtLabelType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCMPaintName;
        
        private NpCommon.FormControls.LabelDropDown DrpLabels;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormalPaintName;
    }
}