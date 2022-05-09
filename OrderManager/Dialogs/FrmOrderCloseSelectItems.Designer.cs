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
    partial class FrmOrderCloseSelectItems
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
            this.PnlList = new System.Windows.Forms.Panel();
            this.PnlBtnChk = new System.Windows.Forms.Panel();
            this.ChkSelectAll = new System.Windows.Forms.CheckBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnOrderClose = new System.Windows.Forms.Button();
            this.PnlBtnChk.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlList
            // 
            this.PnlList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlList.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlList.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PnlList.Location = new System.Drawing.Point(0, 0);
            this.PnlList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PnlList.Name = "PnlList";
            this.PnlList.Size = new System.Drawing.Size(800, 476);
            this.PnlList.TabIndex = 96;
            // 
            // PnlBtnChk
            // 
            this.PnlBtnChk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlBtnChk.Controls.Add(this.ChkSelectAll);
            this.PnlBtnChk.Controls.Add(this.BtnClose);
            this.PnlBtnChk.Controls.Add(this.BtnOrderClose);
            this.PnlBtnChk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBtnChk.Location = new System.Drawing.Point(0, 475);
            this.PnlBtnChk.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PnlBtnChk.Name = "PnlBtnChk";
            this.PnlBtnChk.Size = new System.Drawing.Size(800, 68);
            this.PnlBtnChk.TabIndex = 97;
            // 
            // ChkSelectAll
            // 
            this.ChkSelectAll.AutoSize = true;
            this.ChkSelectAll.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ChkSelectAll.Location = new System.Drawing.Point(634, 21);
            this.ChkSelectAll.Name = "ChkSelectAll";
            this.ChkSelectAll.Size = new System.Drawing.Size(113, 27);
            this.ChkSelectAll.TabIndex = 5;
            this.ChkSelectAll.Text = "全て選択(&A)";
            this.ChkSelectAll.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnClose.Location = new System.Drawing.Point(233, 6);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(220, 54);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.Text = "閉じる";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnOrderClose
            // 
            this.BtnOrderClose.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnOrderClose.Location = new System.Drawing.Point(6, 6);
            this.BtnOrderClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnOrderClose.Name = "BtnOrderClose";
            this.BtnOrderClose.Size = new System.Drawing.Size(220, 54);
            this.BtnOrderClose.TabIndex = 3;
            this.BtnOrderClose.Text = "注文を閉じる";
            this.BtnOrderClose.UseVisualStyleBackColor = true;
            // 
            // FrmOrderCloseSelectItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.ControlBox = false;
            this.Controls.Add(this.PnlBtnChk);
            this.Controls.Add(this.PnlList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmOrderCloseSelectItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Orders to close";
            this.PnlBtnChk.ResumeLayout(false);
            this.PnlBtnChk.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlList;
        private System.Windows.Forms.Panel PnlBtnChk;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnOrderClose;
        private System.Windows.Forms.CheckBox ChkSelectAll;
    }
}