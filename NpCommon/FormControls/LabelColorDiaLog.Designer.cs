namespace NipponPaint.NpCommon.FormControls
{
    partial class LabelColorDiaLog
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.BtnColor = new System.Windows.Forms.Button();
            this.LblCode = new System.Windows.Forms.Label();
            this.LblColorCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnColor
            // 
            this.BtnColor.BackColor = System.Drawing.Color.Black;
            this.BtnColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnColor.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnColor.Location = new System.Drawing.Point(38, 0);
            this.BtnColor.Margin = new System.Windows.Forms.Padding(0);
            this.BtnColor.Name = "BtnColor";
            this.BtnColor.Size = new System.Drawing.Size(274, 30);
            this.BtnColor.TabIndex = 44;
            this.BtnColor.Text = "TEXT";
            this.BtnColor.UseVisualStyleBackColor = false;
            // 
            // LblCode
            // 
            this.LblCode.BackColor = System.Drawing.Color.Navy;
            this.LblCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblCode.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.LblCode.ForeColor = System.Drawing.Color.White;
            this.LblCode.Location = new System.Drawing.Point(0, 0);
            this.LblCode.Name = "LblCode";
            this.LblCode.Size = new System.Drawing.Size(38, 28);
            this.LblCode.TabIndex = 47;
            this.LblCode.Text = "0";
            this.LblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblColorCode
            // 
            this.LblColorCode.BackColor = System.Drawing.Color.Navy;
            this.LblColorCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblColorCode.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.LblColorCode.ForeColor = System.Drawing.SystemColors.Window;
            this.LblColorCode.Location = new System.Drawing.Point(315, 0);
            this.LblColorCode.Name = "LblColorCode";
            this.LblColorCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblColorCode.Size = new System.Drawing.Size(215, 30);
            this.LblColorCode.TabIndex = 46;
            this.LblColorCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelColorDiaLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblCode);
            this.Controls.Add(this.LblColorCode);
            this.Controls.Add(this.BtnColor);
            this.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "LabelColorDiaLog";
            this.Size = new System.Drawing.Size(530, 30);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button BtnColor;
        private System.Windows.Forms.Label LblCode;
        private System.Windows.Forms.Label LblColorCode;
    }
}
