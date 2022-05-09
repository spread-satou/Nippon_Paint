
namespace SupervisorIfSim
{
    partial class FrmMain
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.LblPreviewTime = new System.Windows.Forms.Label();
            this.LblCycle = new System.Windows.Forms.Label();
            this.BtnPreview = new System.Windows.Forms.Button();
            this.BtnTimer = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.GvMain = new System.Windows.Forms.DataGridView();
            this.TimerPreview = new System.Windows.Forms.Timer(this.components);
            this.pnlLeft.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.LblPreviewTime);
            this.pnlLeft.Controls.Add(this.LblCycle);
            this.pnlLeft.Controls.Add(this.BtnPreview);
            this.pnlLeft.Controls.Add(this.BtnTimer);
            this.pnlLeft.Controls.Add(this.BtnEdit);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(933, 51);
            this.pnlLeft.TabIndex = 0;
            // 
            // LblPreviewTime
            // 
            this.LblPreviewTime.AutoSize = true;
            this.LblPreviewTime.Location = new System.Drawing.Point(253, 17);
            this.LblPreviewTime.Name = "LblPreviewTime";
            this.LblPreviewTime.Size = new System.Drawing.Size(248, 18);
            this.LblPreviewTime.TabIndex = 4;
            this.LblPreviewTime.Text = "秒周期で更新（最終更新時刻：hh:mm:ss）";
            this.LblPreviewTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblCycle
            // 
            this.LblCycle.AutoSize = true;
            this.LblCycle.Location = new System.Drawing.Point(236, 17);
            this.LblCycle.Name = "LblCycle";
            this.LblCycle.Size = new System.Drawing.Size(22, 18);
            this.LblCycle.TabIndex = 3;
            this.LblCycle.Text = "10";
            this.LblCycle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnPreview
            // 
            this.BtnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPreview.Location = new System.Drawing.Point(828, 8);
            this.BtnPreview.Name = "BtnPreview";
            this.BtnPreview.Size = new System.Drawing.Size(98, 35);
            this.BtnPreview.TabIndex = 2;
            this.BtnPreview.Text = "一覧更新(F5)";
            this.BtnPreview.UseVisualStyleBackColor = true;
            // 
            // BtnTimer
            // 
            this.BtnTimer.Location = new System.Drawing.Point(122, 8);
            this.BtnTimer.Name = "BtnTimer";
            this.BtnTimer.Size = new System.Drawing.Size(98, 35);
            this.BtnTimer.TabIndex = 1;
            this.BtnTimer.Text = "開始(F9)";
            this.BtnTimer.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(5, 8);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(98, 35);
            this.BtnEdit.TabIndex = 0;
            this.BtnEdit.Text = "編集(F2)";
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.GvMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 51);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(933, 624);
            this.pnlMain.TabIndex = 1;
            // 
            // GvMain
            // 
            this.GvMain.AllowUserToAddRows = false;
            this.GvMain.AllowUserToDeleteRows = false;
            this.GvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GvMain.Location = new System.Drawing.Point(0, 0);
            this.GvMain.MultiSelect = false;
            this.GvMain.Name = "GvMain";
            this.GvMain.ReadOnly = true;
            this.GvMain.RowTemplate.Height = 21;
            this.GvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GvMain.Size = new System.Drawing.Size(933, 624);
            this.GvMain.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 675);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supervisor I/F シミュレータ";
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView GvMain;
        private System.Windows.Forms.Button BtnTimer;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Timer TimerPreview;
        private System.Windows.Forms.Button BtnPreview;
        private System.Windows.Forms.Label LblPreviewTime;
        private System.Windows.Forms.Label LblCycle;
    }
}

