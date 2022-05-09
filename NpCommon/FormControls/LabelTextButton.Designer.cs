namespace NipponPaint.NpCommon.FormControls
{
    partial class LabelTextButton
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnFontChange = new System.Windows.Forms.Button();
            this.TxtData = new NipponPaint.NpCommon.FormControls.TextBoxEx();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.BackColor = System.Drawing.Color.Navy;
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(75, 30);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "最終結合リリース";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnFontChange
            // 
            this.BtnFontChange.Location = new System.Drawing.Point(582, 0);
            this.BtnFontChange.Name = "BtnFontChange";
            this.BtnFontChange.Size = new System.Drawing.Size(100, 32);
            this.BtnFontChange.TabIndex = 2;
            this.BtnFontChange.Text = "button";
            this.BtnFontChange.UseVisualStyleBackColor = true;
            // 
            // TxtData
            // 
            this.TxtData.DatabaseColumnName = "";
            this.TxtData.Id = 0;
            this.TxtData.Location = new System.Drawing.Point(75, 0);
            this.TxtData.Name = "TxtData";
            this.TxtData.Size = new System.Drawing.Size(501, 30);
            this.TxtData.TabIndex = 1;
            // 
            // LabelTextButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnFontChange);
            this.Controls.Add(this.TxtData);
            this.Controls.Add(this.LblTitle);
            this.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "LabelTextButton";
            this.Size = new System.Drawing.Size(1090, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private TextBoxEx TxtData;
        private System.Windows.Forms.Button BtnFontChange;
    }
}
