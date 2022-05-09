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
    partial class FrmProductCodeMaster
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
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlControl = new System.Windows.Forms.Panel();
            this.TxtProductCodeID = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.TxtProductCode = new NipponPaint.NpCommon.FormControls.LabelTextBox();
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
            this.ProductCode});
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
            this.DgvList.TabIndex = 21;
            // 
            // ProductCode
            // 
            this.ProductCode.HeaderText = "品名コード";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.Width = 200;
            // 
            // PnlControl
            // 
            this.PnlControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PnlControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlControl.Controls.Add(this.TxtProductCodeID);
            this.PnlControl.Controls.Add(this.TxtProductCode);
            this.PnlControl.Controls.Add(this.dialogEditButtons);
            this.PnlControl.Location = new System.Drawing.Point(12, 238);
            this.PnlControl.Name = "PnlControl";
            this.PnlControl.Size = new System.Drawing.Size(977, 264);
            this.PnlControl.TabIndex = 22;
            // 
            // TxtProductCodeID
            // 
            this.TxtProductCodeID.DatabaseColumnName = "PRD_ID";
            this.TxtProductCodeID.DataControlName = "txtData";
            this.TxtProductCodeID.DataEnabled = true;
            this.TxtProductCodeID.DataReadOnly = false;
            this.TxtProductCodeID.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtProductCodeID.DataTextSize = new System.Drawing.Size(154, 30);
            this.TxtProductCodeID.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtProductCodeID.Id = "";
            this.TxtProductCodeID.Label = "";
            this.TxtProductCodeID.Location = new System.Drawing.Point(9, 60);
            this.TxtProductCodeID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtProductCodeID.MaxByteLength = 65535;
            this.TxtProductCodeID.MaxLength = 32767;
            this.TxtProductCodeID.Name = "TxtProductCodeID";
            this.TxtProductCodeID.Size = new System.Drawing.Size(308, 30);
            this.TxtProductCodeID.TabIndex = 20;
            this.TxtProductCodeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtProductCodeID.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtProductCodeID.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtProductCodeID.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtProductCodeID.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtProductCodeID.Title = "品名コードID(&I)";
            this.TxtProductCodeID.TitleControlName = "lblTitle";
            this.TxtProductCodeID.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtProductCodeID.Value = "";
            // 
            // TxtProductCode
            // 
            this.TxtProductCode.DatabaseColumnName = "Product_No";
            this.TxtProductCode.DataControlName = "txtData";
            this.TxtProductCode.DataEnabled = true;
            this.TxtProductCode.DataReadOnly = false;
            this.TxtProductCode.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtProductCode.DataTextSize = new System.Drawing.Size(278, 30);
            this.TxtProductCode.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtProductCode.Id = "";
            this.TxtProductCode.Label = "";
            this.TxtProductCode.Location = new System.Drawing.Point(9, 9);
            this.TxtProductCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtProductCode.MaxByteLength = 65535;
            this.TxtProductCode.MaxLength = 32767;
            this.TxtProductCode.Name = "TxtProductCode";
            this.TxtProductCode.Size = new System.Drawing.Size(432, 30);
            this.TxtProductCode.TabIndex = 19;
            this.TxtProductCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtProductCode.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtProductCode.TextBorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TxtProductCode.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtProductCode.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtProductCode.Title = "品名コード(&P)";
            this.TxtProductCode.TitleControlName = "lblTitle";
            this.TxtProductCode.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtProductCode.Value = "";
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
            // FrmProductCodeMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 514);
            this.ControlBox = false;
            this.Controls.Add(this.DgvList);
            this.Controls.Add(this.PnlControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmProductCodeMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "商品コードマスタ";
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).EndInit();
            this.PnlControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlControl;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtProductCode;
        private NipponPaint.NpCommon.FormControls.DialogEditButtons dialogEditButtons;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridView DgvList;
        private NpCommon.FormControls.LabelTextBox TxtProductCodeID;
    }
}