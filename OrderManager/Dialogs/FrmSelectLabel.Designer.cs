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
    partial class FrmSelectLabel
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
            this.DropDownSelectFolder = new System.Windows.Forms.ComboBox();
            this.TreeViewSelectFolder = new System.Windows.Forms.TreeView();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DropDownSelectFolder
            // 
            this.DropDownSelectFolder.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DropDownSelectFolder.FormattingEnabled = true;
            this.DropDownSelectFolder.Location = new System.Drawing.Point(12, 12);
            this.DropDownSelectFolder.Name = "DropDownSelectFolder";
            this.DropDownSelectFolder.Size = new System.Drawing.Size(522, 31);
            this.DropDownSelectFolder.TabIndex = 0;
            // 
            // TreeViewSelectFolder
            // 
            this.TreeViewSelectFolder.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TreeViewSelectFolder.Location = new System.Drawing.Point(12, 53);
            this.TreeViewSelectFolder.Name = "TreeViewSelectFolder";
            this.TreeViewSelectFolder.Size = new System.Drawing.Size(522, 254);
            this.TreeViewSelectFolder.TabIndex = 1;
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnClose.Location = new System.Drawing.Point(314, 348);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(220, 54);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.Text = "閉じる";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnSave.Location = new System.Drawing.Point(12, 348);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(220, 54);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "保存";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // Lbl
            // 
            this.Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lbl.Location = new System.Drawing.Point(12, 316);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(522, 23);
            this.Lbl.TabIndex = 6;
            // 
            // FrmSelectLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(547, 414);
            this.ControlBox = false;
            this.Controls.Add(this.Lbl);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TreeViewSelectFolder);
            this.Controls.Add(this.DropDownSelectFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmSelectLabel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ラベル";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox DropDownSelectFolder;
        private System.Windows.Forms.TreeView TreeViewSelectFolder;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label Lbl;
    }
}