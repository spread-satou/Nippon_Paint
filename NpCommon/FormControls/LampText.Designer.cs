namespace NipponPaint.NpCommon.FormControls
{
    partial class LampText
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
            this.LblText = new System.Windows.Forms.Label();
            this.BdrColor = new System.Windows.Forms.Panel();
            this.CrColor = new System.Windows.Forms.Label();
            this.BdrColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblText
            // 
            this.LblText.Location = new System.Drawing.Point(29, 3);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(71, 20);
            this.LblText.TabIndex = 32;
            this.LblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BdrColor
            // 
            this.BdrColor.BackColor = System.Drawing.Color.Green;
            this.BdrColor.Controls.Add(this.CrColor);
            this.BdrColor.Location = new System.Drawing.Point(3, 3);
            this.BdrColor.Name = "BdrColor";
            this.BdrColor.Size = new System.Drawing.Size(20, 20);
            this.BdrColor.TabIndex = 31;
            // 
            // CrColor
            // 
            this.CrColor.BackColor = System.Drawing.Color.Black;
            this.CrColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CrColor.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CrColor.Location = new System.Drawing.Point(4, 4);
            this.CrColor.Margin = new System.Windows.Forms.Padding(0);
            this.CrColor.Name = "CrColor";
            this.CrColor.Size = new System.Drawing.Size(12, 12);
            this.CrColor.TabIndex = 28;
            // 
            // LampText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblText);
            this.Controls.Add(this.BdrColor);
            this.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "LampText";
            this.Size = new System.Drawing.Size(100, 27);
            this.BdrColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblText;
        private System.Windows.Forms.Panel BdrColor;
        private System.Windows.Forms.Label CrColor;
    }
}
