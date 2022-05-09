namespace NipponPaint.NpCommon.FormControls
{
    partial class CheckTextButton
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
            this.TxtData = new System.Windows.Forms.TextBox();
            this.Btn = new System.Windows.Forms.Button();
            this.ChkTitle = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TxtData
            // 
            this.TxtData.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.TxtData.Location = new System.Drawing.Point(150, 0);
            this.TxtData.Name = "TxtData";
            this.TxtData.Size = new System.Drawing.Size(960, 30);
            this.TxtData.TabIndex = 8;
            // 
            // Btn
            // 
            this.Btn.Location = new System.Drawing.Point(1115, 2);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(35, 28);
            this.Btn.TabIndex = 7;
            this.Btn.Text = "…";
            this.Btn.UseVisualStyleBackColor = true;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // ChkTitle
            // 
            this.ChkTitle.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.ChkTitle.Location = new System.Drawing.Point(0, 0);
            this.ChkTitle.Name = "ChkTitle";
            this.ChkTitle.Size = new System.Drawing.Size(150, 30);
            this.ChkTitle.TabIndex = 6;
            this.ChkTitle.Text = "最終配合リリース";
            this.ChkTitle.UseVisualStyleBackColor = true;
            // 
            // CheckTextButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtData);
            this.Controls.Add(this.Btn);
            this.Controls.Add(this.ChkTitle);
            this.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "CheckTextButton";
            this.Size = new System.Drawing.Size(1150, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtData;
        private System.Windows.Forms.Button Btn;
        private System.Windows.Forms.CheckBox ChkTitle;
    }
}
