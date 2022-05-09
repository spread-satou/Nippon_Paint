
namespace NipponPaint.NpCommon.FormControls
{
    partial class LabelNumericUpDownMulti
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
            this.NumUpDownDataLeft = new System.Windows.Forms.NumericUpDown();
            this.LblTitle = new System.Windows.Forms.Label();
            this.NumUpDownDataRight = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownDataLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownDataRight)).BeginInit();
            this.SuspendLayout();
            // 
            // NumUpDownDataLeft
            // 
            this.NumUpDownDataLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.NumUpDownDataLeft.Location = new System.Drawing.Point(154, 0);
            this.NumUpDownDataLeft.Name = "NumUpDownDataLeft";
            this.NumUpDownDataLeft.Size = new System.Drawing.Size(139, 30);
            this.NumUpDownDataLeft.TabIndex = 5;
            this.NumUpDownDataLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblTitle
            // 
            this.LblTitle.BackColor = System.Drawing.Color.Navy;
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblTitle.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(154, 30);
            this.LblTitle.TabIndex = 4;
            this.LblTitle.Text = "最終配合リリース";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NumUpDownDataRight
            // 
            this.NumUpDownDataRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumUpDownDataRight.Location = new System.Drawing.Point(293, 0);
            this.NumUpDownDataRight.Name = "NumUpDownDataRight";
            this.NumUpDownDataRight.Size = new System.Drawing.Size(139, 30);
            this.NumUpDownDataRight.TabIndex = 6;
            this.NumUpDownDataRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelNumericUpDownMulti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NumUpDownDataRight);
            this.Controls.Add(this.NumUpDownDataLeft);
            this.Controls.Add(this.LblTitle);
            this.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "LabelNumericUpDownMulti";
            this.Size = new System.Drawing.Size(432, 30);
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownDataLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownDataRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.NumericUpDown NumUpDownDataLeft;
        internal System.Windows.Forms.NumericUpDown NumUpDownDataRight;
        internal System.Windows.Forms.Label LblTitle;
    }
}
