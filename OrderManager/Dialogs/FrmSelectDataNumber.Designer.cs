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
    partial class FrmSelectDataNumber
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.TxtDataNumber = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnCancel.Location = new System.Drawing.Point(236, 53);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(220, 54);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnOK
            // 
            this.BtnOK.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnOK.Location = new System.Drawing.Point(12, 53);
            this.BtnOK.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(220, 54);
            this.BtnOK.TabIndex = 1;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // TxtDataNumber
            // 
            this.TxtDataNumber.DatabaseColumnName = "HG_Tinting_Direction";
            this.TxtDataNumber.DataControlName = "txtData";
            this.TxtDataNumber.DataEnabled = true;
            this.TxtDataNumber.DataReadOnly = false;
            this.TxtDataNumber.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtDataNumber.DataTextSize = new System.Drawing.Size(290, 30);
            this.TxtDataNumber.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtDataNumber.Id = "";
            this.TxtDataNumber.Label = "";
            this.TxtDataNumber.Location = new System.Drawing.Point(12, 12);
            this.TxtDataNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDataNumber.MaxByteLength = 65535;
            this.TxtDataNumber.MaxLength = 0;
            this.TxtDataNumber.Name = "TxtDataNumber";
            this.TxtDataNumber.Size = new System.Drawing.Size(444, 30);
            this.TxtDataNumber.TabIndex = 0;
            this.TxtDataNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtDataNumber.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtDataNumber.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtDataNumber.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtDataNumber.Title = "処理No.";
            this.TxtDataNumber.TitleControlName = "lblTitle";
            this.TxtDataNumber.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtDataNumber.Value = "";
            // 
            // FrmSelectDataNumber
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(469, 119);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxtDataNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmSelectDataNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "処理No指定";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOK;
        private NpCommon.FormControls.LabelTextBox TxtDataNumber;
    }
}