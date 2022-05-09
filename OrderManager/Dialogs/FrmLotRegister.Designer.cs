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
    partial class FrmLotRegister
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
            this.TxtLotRegister = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtLotRegister
            // 
            this.TxtLotRegister.DatabaseColumnName = "HG_Tinting_Direction";
            this.TxtLotRegister.DataControlName = "txtData";
            this.TxtLotRegister.DataEnabled = true;
            this.TxtLotRegister.DataReadOnly = false;
            this.TxtLotRegister.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtLotRegister.DataTextSize = new System.Drawing.Size(290, 30);
            this.TxtLotRegister.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtLotRegister.Id = "";
            this.TxtLotRegister.Label = "";
            this.TxtLotRegister.Location = new System.Drawing.Point(12, 12);
            this.TxtLotRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtLotRegister.MaxByteLength = 65535;
            this.TxtLotRegister.MaxLength = 0;
            this.TxtLotRegister.Name = "TxtLotRegister";
            this.TxtLotRegister.Size = new System.Drawing.Size(444, 30);
            this.TxtLotRegister.TabIndex = 1;
            this.TxtLotRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtLotRegister.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtLotRegister.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtLotRegister.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtLotRegister.Title = "指定LOT(&L)";
            this.TxtLotRegister.TitleControlName = "lblTitle";
            this.TxtLotRegister.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtLotRegister.Value = "";
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnCancel.Location = new System.Drawing.Point(236, 53);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(220, 54);
            this.BtnCancel.TabIndex = 8;
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
            this.BtnOK.TabIndex = 7;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            // 
            // FrmLotRegister
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(469, 119);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxtLotRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmLotRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "指定ロット入力";
            this.ResumeLayout(false);

        }

        #endregion

        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtLotRegister;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOK;
    }
}