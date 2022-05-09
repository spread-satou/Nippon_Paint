namespace NipponPaint.NpCommon.FormControls
{
    partial class DeliveryClassification
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.GrpBox = new System.Windows.Forms.GroupBox();
            this.LblDTP = new NipponPaint.NpCommon.FormControls.LabelDateTimePicker();
            this.LblRbts = new NipponPaint.NpCommon.FormControls.LabelRadioButtons();
            this.LblChk = new NipponPaint.NpCommon.FormControls.LabelCheckBoxSingle();
            this.LblTxtBox = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.GrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBox
            // 
            this.GrpBox.BackColor = System.Drawing.Color.Navy;
            this.GrpBox.Controls.Add(this.LblDTP);
            this.GrpBox.Controls.Add(this.LblRbts);
            this.GrpBox.Controls.Add(this.LblChk);
            this.GrpBox.Controls.Add(this.LblTxtBox);
            this.GrpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrpBox.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.GrpBox.ForeColor = System.Drawing.Color.White;
            this.GrpBox.Location = new System.Drawing.Point(0, 0);
            this.GrpBox.Name = "GrpBox";
            this.GrpBox.Size = new System.Drawing.Size(595, 160);
            this.GrpBox.TabIndex = 1;
            this.GrpBox.TabStop = false;
            this.GrpBox.Text = "最終配合リリース";
            // 
            // LblDTP
            // 
            this.LblDTP.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.LblDTP.Location = new System.Drawing.Point(10, 55);
            this.LblDTP.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LblDTP.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.LblDTP.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.LblDTP.Name = "LblDTP";
            this.LblDTP.Size = new System.Drawing.Size(480, 30);
            this.LblDTP.TabIndex = 14;
            this.LblDTP.Title = "最終配合リリース";
            this.LblDTP.TitleControlName = "LblTitle";
            this.LblDTP.TitleSize = new System.Drawing.Size(195, 30);
            this.LblDTP.Value = new System.DateTime(2022, 3, 14, 0, 0, 0, 0);
            // 
            // LblRbts
            // 
            this.LblRbts.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.LblRbts.Location = new System.Drawing.Point(10, 90);
            this.LblRbts.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LblRbts.Name = "LblRbts";
            this.LblRbts.Size = new System.Drawing.Size(578, 30);
            this.LblRbts.TabIndex = 13;
            this.LblRbts.Title = "最終配合リリース";
            this.LblRbts.TitleControlName = "LblTitle";
            this.LblRbts.TitleSize = new System.Drawing.Size(195, 30);
            // 
            // LblChk
            // 
            this.LblChk.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblChk.Location = new System.Drawing.Point(10, 125);
            this.LblChk.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LblChk.Name = "LblChk";
            this.LblChk.Size = new System.Drawing.Size(245, 30);
            this.LblChk.TabIndex = 12;
            this.LblChk.Title = "最終配合リリース";
            this.LblChk.TitleControlName = "LblTitle";
            this.LblChk.TitleSize = new System.Drawing.Size(190, 30);
            // 
            // LblTxtBox
            // 
            this.LblTxtBox.DatabaseColumnName = "";
            this.LblTxtBox.DataControlName = "TxtData";
            this.LblTxtBox.DataEnabled = true;
            this.LblTxtBox.DataReadOnly = false;
            this.LblTxtBox.DataTextLocation = new System.Drawing.Point(195, 0);
            this.LblTxtBox.DataTextSize = new System.Drawing.Size(285, 30);
            this.LblTxtBox.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblTxtBox.Label = "";
            this.LblTxtBox.Location = new System.Drawing.Point(10, 20);
            this.LblTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LblTxtBox.Name = "LblTxtBox";
            this.LblTxtBox.Size = new System.Drawing.Size(480, 30);
            this.LblTxtBox.TabIndex = 0;
            this.LblTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LblTxtBox.TextBackColor = System.Drawing.SystemColors.Window;
            this.LblTxtBox.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblTxtBox.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.LblTxtBox.Title = "最終配合リリース";
            this.LblTxtBox.TitleControlName = "LblTitle";
            this.LblTxtBox.TitleSize = new System.Drawing.Size(195, 30);
            this.LblTxtBox.Value = "";
            // 
            // DeliveryClassification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GrpBox);
            this.Name = "DeliveryClassification";
            this.Size = new System.Drawing.Size(595, 160);
            this.GrpBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBox;
        private LabelCheckBoxSingle LblChk;
        private LabelTextBox LblTxtBox;
        private LabelRadioButtons LblRbts;
        private LabelDateTimePicker LblDTP;
    }
}
