
namespace NipponPaint.NpCommon.FormControls
{
    partial class LabelTextBoxDb
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
            this.LblCode = new System.Windows.Forms.Label();
            this.TxtValue = new NipponPaint.NpCommon.FormControls.TextBoxEx();
            this.SuspendLayout();
            // 
            // LblCode
            // 
            this.LblCode.BackColor = System.Drawing.Color.Navy;
            this.LblCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblCode.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.LblCode.ForeColor = System.Drawing.Color.White;
            this.LblCode.Location = new System.Drawing.Point(3, 0);
            this.LblCode.Name = "LblCode";
            this.LblCode.Size = new System.Drawing.Size(42, 28);
            this.LblCode.TabIndex = 5;
            this.LblCode.Text = "W";
            this.LblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtValue
            // 
            this.TxtValue.DatabaseColumnName = "";
            this.TxtValue.Id = 0;
            this.TxtValue.Location = new System.Drawing.Point(45, 0);
            this.TxtValue.MaxLength = 0;
            this.TxtValue.Name = "TxtValue";
            this.TxtValue.Size = new System.Drawing.Size(330, 30);
            this.TxtValue.TabIndex = 6;
            // 
            // LabelTextBoxDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtValue);
            this.Controls.Add(this.LblCode);
            this.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "LabelTextBoxDb";
            this.Size = new System.Drawing.Size(567, 92);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblCode;
        private TextBoxEx TxtValue;
    }
}
