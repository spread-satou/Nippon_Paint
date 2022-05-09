
namespace NipponPaint.NpCommon.FormControls
{
    partial class LabelDropDown
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
            this.DropDownData = new NipponPaint.NpCommon.FormControls.ComboBoxEx();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.BackColor = System.Drawing.Color.Navy;
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblTitle.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(154, 31);
            this.LblTitle.TabIndex = 2;
            this.LblTitle.Text = "最終配合リリース";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DropDownData
            // 
            this.DropDownData.BorderColor = System.Drawing.Color.Silver;
            this.DropDownData.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.DropDownData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DropDownData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DropDownData.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DropDownData.FormattingEnabled = true;
            this.DropDownData.IntegralHeight = false;
            this.DropDownData.ItemHeight = 23;
            this.DropDownData.Location = new System.Drawing.Point(154, 0);
            this.DropDownData.Name = "DropDownData";
            this.DropDownData.Size = new System.Drawing.Size(139, 31);
            this.DropDownData.TabIndex = 4;
            // 
            // LabelDropDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DropDownData);
            this.Controls.Add(this.LblTitle);
            this.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "LabelDropDown";
            this.Size = new System.Drawing.Size(293, 31);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LblTitle;
        private ComboBoxEx DropDownData;
    }
}
