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
    partial class FrmOrderClose
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
            this.PnlBtn = new System.Windows.Forms.Panel();
            this.BtnOrderCloseManufacturingCan = new System.Windows.Forms.Button();
            this.BtnOrderCloseTestCan = new System.Windows.Forms.Button();
            this.BtnOrderCloseCCM = new System.Windows.Forms.Button();
            this.PnlBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBtn
            // 
            this.PnlBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlBtn.Controls.Add(this.BtnOrderCloseManufacturingCan);
            this.PnlBtn.Controls.Add(this.BtnOrderCloseTestCan);
            this.PnlBtn.Controls.Add(this.BtnOrderCloseCCM);
            this.PnlBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBtn.Location = new System.Drawing.Point(0, 0);
            this.PnlBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PnlBtn.Name = "PnlBtn";
            this.PnlBtn.Size = new System.Drawing.Size(313, 201);
            this.PnlBtn.TabIndex = 95;
            // 
            // BtnOrderCloseManufacturingCan
            // 
            this.BtnOrderCloseManufacturingCan.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnOrderCloseManufacturingCan.Location = new System.Drawing.Point(12, 132);
            this.BtnOrderCloseManufacturingCan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnOrderCloseManufacturingCan.Name = "BtnOrderCloseManufacturingCan";
            this.BtnOrderCloseManufacturingCan.Size = new System.Drawing.Size(286, 54);
            this.BtnOrderCloseManufacturingCan.TabIndex = 4;
            this.BtnOrderCloseManufacturingCan.Text = "製造缶実施中(ST4)ｵｰﾀﾞｰｸﾛｰｽﾞ(&M)";
            this.BtnOrderCloseManufacturingCan.UseVisualStyleBackColor = true;
            // 
            // BtnOrderCloseTestCan
            // 
            this.BtnOrderCloseTestCan.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnOrderCloseTestCan.Location = new System.Drawing.Point(12, 72);
            this.BtnOrderCloseTestCan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnOrderCloseTestCan.Name = "BtnOrderCloseTestCan";
            this.BtnOrderCloseTestCan.Size = new System.Drawing.Size(286, 54);
            this.BtnOrderCloseTestCan.TabIndex = 3;
            this.BtnOrderCloseTestCan.Text = "ﾃｽﾄ缶実施中(ST3)ｵｰﾀﾞｰｸﾛｰｽﾞ(&T)";
            this.BtnOrderCloseTestCan.UseVisualStyleBackColor = true;
            // 
            // BtnOrderCloseCCM
            // 
            this.BtnOrderCloseCCM.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnOrderCloseCCM.Location = new System.Drawing.Point(12, 12);
            this.BtnOrderCloseCCM.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnOrderCloseCCM.Name = "BtnOrderCloseCCM";
            this.BtnOrderCloseCCM.Size = new System.Drawing.Size(286, 54);
            this.BtnOrderCloseCCM.TabIndex = 2;
            this.BtnOrderCloseCCM.Text = "CCM配合待ち(ST1)ｵｰﾀﾞｰｸﾛｰｽﾞ(&C)";
            this.BtnOrderCloseCCM.UseVisualStyleBackColor = true;
            // 
            // FrmOrderClose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 201);
            this.Controls.Add(this.PnlBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmOrderClose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "注文を閉じる";
            this.PnlBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlBtn;
        private System.Windows.Forms.Button BtnOrderCloseManufacturingCan;
        private System.Windows.Forms.Button BtnOrderCloseTestCan;
        private System.Windows.Forms.Button BtnOrderCloseCCM;
    }
}