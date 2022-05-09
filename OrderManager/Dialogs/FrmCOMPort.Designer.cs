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
    partial class FrmCOMPort
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
            this.PnlBtns = new System.Windows.Forms.Panel();
            this.BtnColorNameLabel = new System.Windows.Forms.Button();
            this.BtnNifudaLabel = new System.Windows.Forms.Button();
            this.BtnCCMSystem = new System.Windows.Forms.Button();
            this.LblCOMPort = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PnlBtn = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.PnlChk = new System.Windows.Forms.Panel();
            this.ChkLabelConnect = new System.Windows.Forms.CheckBox();
            this.PnlCOMPort = new System.Windows.Forms.Panel();
            this.PnlCOMPortTitle = new System.Windows.Forms.Panel();
            this.PnlProductLabelTitle = new System.Windows.Forms.Panel();
            this.LblProduct = new System.Windows.Forms.Label();
            this.PnlProductLabel = new System.Windows.Forms.Panel();
            this.PnlBtns.SuspendLayout();
            this.PnlBtn.SuspendLayout();
            this.PnlChk.SuspendLayout();
            this.PnlCOMPort.SuspendLayout();
            this.PnlCOMPortTitle.SuspendLayout();
            this.PnlProductLabelTitle.SuspendLayout();
            this.PnlProductLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBtns
            // 
            this.PnlBtns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlBtns.Controls.Add(this.BtnColorNameLabel);
            this.PnlBtns.Controls.Add(this.BtnNifudaLabel);
            this.PnlBtns.Controls.Add(this.BtnCCMSystem);
            this.PnlBtns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBtns.Location = new System.Drawing.Point(0, 34);
            this.PnlBtns.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PnlBtns.Name = "PnlBtns";
            this.PnlBtns.Size = new System.Drawing.Size(233, 189);
            this.PnlBtns.TabIndex = 94;
            // 
            // BtnColorNameLabel
            // 
            this.BtnColorNameLabel.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnColorNameLabel.Location = new System.Drawing.Point(5, 127);
            this.BtnColorNameLabel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnColorNameLabel.Name = "BtnColorNameLabel";
            this.BtnColorNameLabel.Size = new System.Drawing.Size(220, 54);
            this.BtnColorNameLabel.TabIndex = 4;
            this.BtnColorNameLabel.Text = "色名ラベル(&F7)";
            this.BtnColorNameLabel.UseVisualStyleBackColor = true;
            // 
            // BtnNifudaLabel
            // 
            this.BtnNifudaLabel.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnNifudaLabel.Location = new System.Drawing.Point(5, 67);
            this.BtnNifudaLabel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnNifudaLabel.Name = "BtnNifudaLabel";
            this.BtnNifudaLabel.Size = new System.Drawing.Size(220, 54);
            this.BtnNifudaLabel.TabIndex = 3;
            this.BtnNifudaLabel.Text = "荷札ラベル(&F6)";
            this.BtnNifudaLabel.UseVisualStyleBackColor = true;
            // 
            // BtnCCMSystem
            // 
            this.BtnCCMSystem.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnCCMSystem.Location = new System.Drawing.Point(5, 7);
            this.BtnCCMSystem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnCCMSystem.Name = "BtnCCMSystem";
            this.BtnCCMSystem.Size = new System.Drawing.Size(220, 54);
            this.BtnCCMSystem.TabIndex = 2;
            this.BtnCCMSystem.Text = "CCMシステム(&F5)";
            this.BtnCCMSystem.UseVisualStyleBackColor = true;
            // 
            // LblCOMPort
            // 
            this.LblCOMPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblCOMPort.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblCOMPort.Location = new System.Drawing.Point(-2, -2);
            this.LblCOMPort.Name = "LblCOMPort";
            this.LblCOMPort.Size = new System.Drawing.Size(235, 35);
            this.LblCOMPort.TabIndex = 95;
            this.LblCOMPort.Text = "COMポート";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(115, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 33);
            this.label2.TabIndex = 96;
            this.label2.Text = "製品ラベル";
            // 
            // PnlBtn
            // 
            this.PnlBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlBtn.Controls.Add(this.BtnClose);
            this.PnlBtn.Location = new System.Drawing.Point(12, 319);
            this.PnlBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PnlBtn.Name = "PnlBtn";
            this.PnlBtn.Size = new System.Drawing.Size(235, 71);
            this.PnlBtn.TabIndex = 95;
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnClose.Location = new System.Drawing.Point(6, 7);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(220, 54);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "閉じる";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // PnlChk
            // 
            this.PnlChk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlChk.Controls.Add(this.ChkLabelConnect);
            this.PnlChk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlChk.Location = new System.Drawing.Point(0, 34);
            this.PnlChk.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PnlChk.Name = "PnlChk";
            this.PnlChk.Size = new System.Drawing.Size(233, 34);
            this.PnlChk.TabIndex = 96;
            // 
            // ChkLabelConnect
            // 
            this.ChkLabelConnect.AutoSize = true;
            this.ChkLabelConnect.Font = new System.Drawing.Font("游ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ChkLabelConnect.Location = new System.Drawing.Point(5, 5);
            this.ChkLabelConnect.Name = "ChkLabelConnect";
            this.ChkLabelConnect.Size = new System.Drawing.Size(170, 24);
            this.ChkLabelConnect.TabIndex = 0;
            this.ChkLabelConnect.Text = "ラベル接続(XML)(&X)";
            this.ChkLabelConnect.UseVisualStyleBackColor = true;
            // 
            // PnlCOMPort
            // 
            this.PnlCOMPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlCOMPort.Controls.Add(this.PnlBtns);
            this.PnlCOMPort.Controls.Add(this.PnlCOMPortTitle);
            this.PnlCOMPort.Location = new System.Drawing.Point(12, 12);
            this.PnlCOMPort.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PnlCOMPort.Name = "PnlCOMPort";
            this.PnlCOMPort.Size = new System.Drawing.Size(235, 225);
            this.PnlCOMPort.TabIndex = 95;
            // 
            // PnlCOMPortTitle
            // 
            this.PnlCOMPortTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlCOMPortTitle.Controls.Add(this.LblCOMPort);
            this.PnlCOMPortTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlCOMPortTitle.Location = new System.Drawing.Point(0, 0);
            this.PnlCOMPortTitle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PnlCOMPortTitle.Name = "PnlCOMPortTitle";
            this.PnlCOMPortTitle.Size = new System.Drawing.Size(233, 34);
            this.PnlCOMPortTitle.TabIndex = 96;
            // 
            // PnlProductLabelTitle
            // 
            this.PnlProductLabelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlProductLabelTitle.Controls.Add(this.LblProduct);
            this.PnlProductLabelTitle.Controls.Add(this.label2);
            this.PnlProductLabelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlProductLabelTitle.Location = new System.Drawing.Point(0, 0);
            this.PnlProductLabelTitle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PnlProductLabelTitle.Name = "PnlProductLabelTitle";
            this.PnlProductLabelTitle.Size = new System.Drawing.Size(233, 34);
            this.PnlProductLabelTitle.TabIndex = 97;
            // 
            // LblProduct
            // 
            this.LblProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblProduct.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblProduct.Location = new System.Drawing.Point(-2, -1);
            this.LblProduct.Name = "LblProduct";
            this.LblProduct.Size = new System.Drawing.Size(235, 34);
            this.LblProduct.TabIndex = 96;
            this.LblProduct.Text = "製品ラベル";
            // 
            // PnlProductLabel
            // 
            this.PnlProductLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlProductLabel.Controls.Add(this.PnlChk);
            this.PnlProductLabel.Controls.Add(this.PnlProductLabelTitle);
            this.PnlProductLabel.Location = new System.Drawing.Point(12, 243);
            this.PnlProductLabel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PnlProductLabel.Name = "PnlProductLabel";
            this.PnlProductLabel.Size = new System.Drawing.Size(235, 70);
            this.PnlProductLabel.TabIndex = 98;
            // 
            // FrmCOMPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(260, 401);
            this.ControlBox = false;
            this.Controls.Add(this.PnlBtn);
            this.Controls.Add(this.PnlCOMPort);
            this.Controls.Add(this.PnlProductLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmCOMPort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "COMポート";
            this.PnlBtns.ResumeLayout(false);
            this.PnlBtn.ResumeLayout(false);
            this.PnlChk.ResumeLayout(false);
            this.PnlChk.PerformLayout();
            this.PnlCOMPort.ResumeLayout(false);
            this.PnlCOMPortTitle.ResumeLayout(false);
            this.PnlProductLabelTitle.ResumeLayout(false);
            this.PnlProductLabel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlBtns;
        private System.Windows.Forms.Button BtnCCMSystem;
        private System.Windows.Forms.Label LblCOMPort;
        private System.Windows.Forms.Button BtnColorNameLabel;
        private System.Windows.Forms.Button BtnNifudaLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PnlBtn;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Panel PnlChk;
        private System.Windows.Forms.CheckBox ChkLabelConnect;
        private System.Windows.Forms.Panel PnlCOMPort;
        private System.Windows.Forms.Panel PnlCOMPortTitle;
        private System.Windows.Forms.Panel PnlProductLabelTitle;
        private System.Windows.Forms.Label LblProduct;
        private System.Windows.Forms.Panel PnlProductLabel;
    }
}