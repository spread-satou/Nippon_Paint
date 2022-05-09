namespace NipponPaint.NpCommon.FormControls
{
    partial class LabelDateTimePicker
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
            this.DateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
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
            this.LblTitle.TabIndex = 3;
            this.LblTitle.Text = "最終配合リリース";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateTimePickerData
            // 
            this.DateTimePickerData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateTimePickerData.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DateTimePickerData.Location = new System.Drawing.Point(154, 0);
            this.DateTimePickerData.Name = "DateTimePickerData";
            this.DateTimePickerData.ShowUpDown = true;
            this.DateTimePickerData.Size = new System.Drawing.Size(139, 30);
            this.DateTimePickerData.TabIndex = 4;
            // 
            // LabelDateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DateTimePickerData);
            this.Controls.Add(this.LblTitle);
            this.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "LabelDateTimePicker";
            this.Size = new System.Drawing.Size(293, 30);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.DateTimePicker DateTimePickerData;
    }
}
