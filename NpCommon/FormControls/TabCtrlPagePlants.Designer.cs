namespace NipponPaint.NpCommon.FormControls
{
    partial class TabCtrlPagePlants
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
            this.LblDTP = new NipponPaint.NpCommon.FormControls.LabelDateTimePicker();
            this.LblNud1 = new NipponPaint.NpCommon.FormControls.LabelNumericUpDown();
            this.LblNud2 = new NipponPaint.NpCommon.FormControls.LabelNumericUpDown();
            this.LblTxtBox = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.SuspendLayout();
            // 
            // LblDTP
            // 
            this.LblDTP.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.LblDTP.Id = 1;
            this.LblDTP.Location = new System.Drawing.Point(312, 70);
            this.LblDTP.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LblDTP.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.LblDTP.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.LblDTP.Name = "LblDTP";
            this.LblDTP.Size = new System.Drawing.Size(250, 30);
            this.LblDTP.TabIndex = 13;
            this.LblDTP.Title = "最終配合リリース";
            this.LblDTP.TitleControlName = "LblTitle";
            this.LblDTP.TitleSize = new System.Drawing.Size(130, 30);
            this.LblDTP.Value = new System.DateTime(2022, 3, 16, 15, 18, 34, 109);
            // 
            // LblNud1
            // 
            this.LblNud1.DecimalPlaces = 0;
            this.LblNud1.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblNud1.Id = "1";
            this.LblNud1.Location = new System.Drawing.Point(0, 35);
            this.LblNud1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.LblNud1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.LblNud1.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.LblNud1.Name = "LblNud1";
            this.LblNud1.Size = new System.Drawing.Size(300, 30);
            this.LblNud1.TabIndex = 12;
            this.LblNud1.Title = "最終配合リリース";
            this.LblNud1.TitleControlName = "LblTitle";
            this.LblNud1.TitleSize = new System.Drawing.Size(200, 30);
            this.LblNud1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // LblNud2
            // 
            this.LblNud2.DecimalPlaces = 0;
            this.LblNud2.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblNud2.Id = "1";
            this.LblNud2.Location = new System.Drawing.Point(0, 70);
            this.LblNud2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.LblNud2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.LblNud2.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.LblNud2.Name = "LblNud2";
            this.LblNud2.Size = new System.Drawing.Size(300, 30);
            this.LblNud2.TabIndex = 11;
            this.LblNud2.Title = "最終配合リリース";
            this.LblNud2.TitleControlName = "LblTitle";
            this.LblNud2.TitleSize = new System.Drawing.Size(200, 30);
            this.LblNud2.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // LblTxtBox
            // 
            this.LblTxtBox.DatabaseColumnName = "";
            this.LblTxtBox.DataControlName = "TxtData";
            this.LblTxtBox.DataEnabled = true;
            this.LblTxtBox.DataReadOnly = false;
            this.LblTxtBox.DataTextLocation = new System.Drawing.Point(200, 0);
            this.LblTxtBox.DataTextSize = new System.Drawing.Size(180, 30);
            this.LblTxtBox.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblTxtBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblTxtBox.Id = "1";
            this.LblTxtBox.Label = "";
            this.LblTxtBox.Location = new System.Drawing.Point(0, 0);
            this.LblTxtBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LblTxtBox.Name = "LblTxtBox";
            this.LblTxtBox.Size = new System.Drawing.Size(380, 30);
            this.LblTxtBox.TabIndex = 10;
            this.LblTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LblTxtBox.TextBackColor = System.Drawing.SystemColors.Window;
            this.LblTxtBox.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblTxtBox.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.LblTxtBox.Title = "最終配合リリース";
            this.LblTxtBox.TitleControlName = "LblTitle";
            this.LblTxtBox.TitleSize = new System.Drawing.Size(200, 30);
            this.LblTxtBox.Value = "";
            // 
            // TabCtrlPagePlants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.Controls.Add(this.LblDTP);
            this.Controls.Add(this.LblNud1);
            this.Controls.Add(this.LblNud2);
            this.Controls.Add(this.LblTxtBox);
            this.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "TabCtrlPagePlants";
            this.Size = new System.Drawing.Size(562, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private LabelDateTimePicker LblDTP;
        private LabelNumericUpDown LblNud1;
        private LabelNumericUpDown LblNud2;
        private LabelTextBox LblTxtBox;
    }
}
