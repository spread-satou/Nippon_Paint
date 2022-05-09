
namespace DatabaseManager
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panLogo = new System.Windows.Forms.Panel();
            this.PnlClose = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.PnlManegementTool = new System.Windows.Forms.Panel();
            this.LblManegementTool = new System.Windows.Forms.Label();
            this.BtnSetting = new System.Windows.Forms.Button();
            this.BtnDBMaintenance = new System.Windows.Forms.Button();
            this.PanelLanguage = new System.Windows.Forms.Panel();
            this.LblLanguage = new System.Windows.Forms.Label();
            this.BtnChangeENG = new System.Windows.Forms.Button();
            this.BtnChangeJPN = new System.Windows.Forms.Button();
            this.PnlHGLog = new System.Windows.Forms.Panel();
            this.LblHGLog = new System.Windows.Forms.Label();
            this.BtnHGLogRecognition = new System.Windows.Forms.Button();
            this.BtnHGLogClear = new System.Windows.Forms.Button();
            this.PnlServerStatus = new System.Windows.Forms.Panel();
            this.lampText3 = new NipponPaint.NpCommon.FormControls.LampText();
            this.lampText2 = new NipponPaint.NpCommon.FormControls.LampText();
            this.lampText1 = new NipponPaint.NpCommon.FormControls.LampText();
            this.LblServerState = new System.Windows.Forms.Label();
            this.BtnHGServerStart = new System.Windows.Forms.Button();
            this.BtnHGServerStop = new System.Windows.Forms.Button();
            this.DgvList = new System.Windows.Forms.DataGridView();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.PnlClose.SuspendLayout();
            this.PnlManegementTool.SuspendLayout();
            this.PanelLanguage.SuspendLayout();
            this.PnlHGLog.SuspendLayout();
            this.PnlServerStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // panLogo
            // 
            this.panLogo.BackColor = System.Drawing.Color.Black;
            this.panLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panLogo.BackgroundImage")));
            this.panLogo.Location = new System.Drawing.Point(0, 0);
            this.panLogo.Name = "panLogo";
            this.panLogo.Size = new System.Drawing.Size(220, 72);
            this.panLogo.TabIndex = 1;
            // 
            // PnlClose
            // 
            this.PnlClose.BackColor = System.Drawing.Color.White;
            this.PnlClose.Controls.Add(this.BtnClose);
            this.PnlClose.Location = new System.Drawing.Point(15, 805);
            this.PnlClose.Name = "PnlClose";
            this.PnlClose.Size = new System.Drawing.Size(283, 70);
            this.PnlClose.TabIndex = 35;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(16, 15);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(250, 40);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "閉じる";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // PnlManegementTool
            // 
            this.PnlManegementTool.BackColor = System.Drawing.Color.White;
            this.PnlManegementTool.Controls.Add(this.LblManegementTool);
            this.PnlManegementTool.Controls.Add(this.BtnSetting);
            this.PnlManegementTool.Controls.Add(this.BtnDBMaintenance);
            this.PnlManegementTool.Location = new System.Drawing.Point(15, 607);
            this.PnlManegementTool.Name = "PnlManegementTool";
            this.PnlManegementTool.Size = new System.Drawing.Size(283, 183);
            this.PnlManegementTool.TabIndex = 34;
            // 
            // LblManegementTool
            // 
            this.LblManegementTool.BackColor = System.Drawing.Color.CadetBlue;
            this.LblManegementTool.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.LblManegementTool.ForeColor = System.Drawing.SystemColors.Control;
            this.LblManegementTool.Location = new System.Drawing.Point(0, 0);
            this.LblManegementTool.Name = "LblManegementTool";
            this.LblManegementTool.Size = new System.Drawing.Size(283, 23);
            this.LblManegementTool.TabIndex = 27;
            this.LblManegementTool.Text = "管理ツール";
            // 
            // BtnSetting
            // 
            this.BtnSetting.Location = new System.Drawing.Point(16, 34);
            this.BtnSetting.Name = "BtnSetting";
            this.BtnSetting.Size = new System.Drawing.Size(250, 40);
            this.BtnSetting.TabIndex = 3;
            this.BtnSetting.Text = "設定";
            this.BtnSetting.UseVisualStyleBackColor = true;
            // 
            // BtnDBMaintenance
            // 
            this.BtnDBMaintenance.Location = new System.Drawing.Point(16, 83);
            this.BtnDBMaintenance.Name = "BtnDBMaintenance";
            this.BtnDBMaintenance.Size = new System.Drawing.Size(250, 40);
            this.BtnDBMaintenance.TabIndex = 18;
            this.BtnDBMaintenance.Text = "データベースメンテナンス";
            this.BtnDBMaintenance.UseVisualStyleBackColor = true;
            // 
            // PanelLanguage
            // 
            this.PanelLanguage.BackColor = System.Drawing.Color.White;
            this.PanelLanguage.Controls.Add(this.LblLanguage);
            this.PanelLanguage.Controls.Add(this.BtnChangeENG);
            this.PanelLanguage.Controls.Add(this.BtnChangeJPN);
            this.PanelLanguage.Location = new System.Drawing.Point(15, 457);
            this.PanelLanguage.Name = "PanelLanguage";
            this.PanelLanguage.Size = new System.Drawing.Size(283, 135);
            this.PanelLanguage.TabIndex = 33;
            // 
            // LblLanguage
            // 
            this.LblLanguage.BackColor = System.Drawing.Color.CadetBlue;
            this.LblLanguage.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.LblLanguage.ForeColor = System.Drawing.SystemColors.Control;
            this.LblLanguage.Location = new System.Drawing.Point(0, 0);
            this.LblLanguage.Name = "LblLanguage";
            this.LblLanguage.Size = new System.Drawing.Size(283, 23);
            this.LblLanguage.TabIndex = 27;
            this.LblLanguage.Text = "言語";
            // 
            // BtnChangeENG
            // 
            this.BtnChangeENG.Location = new System.Drawing.Point(16, 34);
            this.BtnChangeENG.Name = "BtnChangeENG";
            this.BtnChangeENG.Size = new System.Drawing.Size(250, 40);
            this.BtnChangeENG.TabIndex = 3;
            this.BtnChangeENG.Text = "英語";
            this.BtnChangeENG.UseVisualStyleBackColor = true;
            // 
            // BtnChangeJPN
            // 
            this.BtnChangeJPN.Location = new System.Drawing.Point(16, 83);
            this.BtnChangeJPN.Name = "BtnChangeJPN";
            this.BtnChangeJPN.Size = new System.Drawing.Size(250, 40);
            this.BtnChangeJPN.TabIndex = 18;
            this.BtnChangeJPN.Text = "日本語";
            this.BtnChangeJPN.UseVisualStyleBackColor = true;
            // 
            // PnlHGLog
            // 
            this.PnlHGLog.BackColor = System.Drawing.Color.White;
            this.PnlHGLog.Controls.Add(this.LblHGLog);
            this.PnlHGLog.Controls.Add(this.BtnHGLogRecognition);
            this.PnlHGLog.Controls.Add(this.BtnHGLogClear);
            this.PnlHGLog.Location = new System.Drawing.Point(15, 307);
            this.PnlHGLog.Name = "PnlHGLog";
            this.PnlHGLog.Size = new System.Drawing.Size(283, 135);
            this.PnlHGLog.TabIndex = 32;
            // 
            // LblHGLog
            // 
            this.LblHGLog.BackColor = System.Drawing.Color.CadetBlue;
            this.LblHGLog.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.LblHGLog.ForeColor = System.Drawing.SystemColors.Control;
            this.LblHGLog.Location = new System.Drawing.Point(0, 0);
            this.LblHGLog.Name = "LblHGLog";
            this.LblHGLog.Size = new System.Drawing.Size(283, 23);
            this.LblHGLog.TabIndex = 27;
            this.LblHGLog.Text = "HG LOG";
            // 
            // BtnHGLogRecognition
            // 
            this.BtnHGLogRecognition.Location = new System.Drawing.Point(16, 34);
            this.BtnHGLogRecognition.Name = "BtnHGLogRecognition";
            this.BtnHGLogRecognition.Size = new System.Drawing.Size(250, 40);
            this.BtnHGLogRecognition.TabIndex = 3;
            this.BtnHGLogRecognition.Text = "認識";
            this.BtnHGLogRecognition.UseVisualStyleBackColor = true;
            // 
            // BtnHGLogClear
            // 
            this.BtnHGLogClear.Location = new System.Drawing.Point(16, 83);
            this.BtnHGLogClear.Name = "BtnHGLogClear";
            this.BtnHGLogClear.Size = new System.Drawing.Size(250, 40);
            this.BtnHGLogClear.TabIndex = 18;
            this.BtnHGLogClear.Text = "Clear";
            this.BtnHGLogClear.UseVisualStyleBackColor = true;
            // 
            // PnlServerStatus
            // 
            this.PnlServerStatus.BackColor = System.Drawing.Color.White;
            this.PnlServerStatus.Controls.Add(this.lampText3);
            this.PnlServerStatus.Controls.Add(this.lampText2);
            this.PnlServerStatus.Controls.Add(this.lampText1);
            this.PnlServerStatus.Controls.Add(this.LblServerState);
            this.PnlServerStatus.Controls.Add(this.BtnHGServerStart);
            this.PnlServerStatus.Controls.Add(this.BtnHGServerStop);
            this.PnlServerStatus.Location = new System.Drawing.Point(15, 87);
            this.PnlServerStatus.Name = "PnlServerStatus";
            this.PnlServerStatus.Size = new System.Drawing.Size(283, 205);
            this.PnlServerStatus.TabIndex = 31;
            // 
            // lampText3
            // 
            this.lampText3.BoderColor = System.Drawing.Color.DarkGreen;
            this.lampText3.Code = "実行中";
            this.lampText3.CoreColor = System.Drawing.Color.Black;
            this.lampText3.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.lampText3.Location = new System.Drawing.Point(5, 29);
            this.lampText3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lampText3.Name = "lampText3";
            this.lampText3.Size = new System.Drawing.Size(100, 27);
            this.lampText3.TabIndex = 36;
            // 
            // lampText2
            // 
            this.lampText2.BoderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lampText2.Code = "初期化中";
            this.lampText2.CoreColor = System.Drawing.Color.Black;
            this.lampText2.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.lampText2.Location = new System.Drawing.Point(5, 54);
            this.lampText2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lampText2.Name = "lampText2";
            this.lampText2.Size = new System.Drawing.Size(100, 27);
            this.lampText2.TabIndex = 35;
            // 
            // lampText1
            // 
            this.lampText1.BoderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lampText1.Code = "停止中";
            this.lampText1.CoreColor = System.Drawing.Color.Black;
            this.lampText1.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.lampText1.Location = new System.Drawing.Point(5, 79);
            this.lampText1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lampText1.Name = "lampText1";
            this.lampText1.Size = new System.Drawing.Size(100, 27);
            this.lampText1.TabIndex = 34;
            // 
            // LblServerState
            // 
            this.LblServerState.BackColor = System.Drawing.Color.CadetBlue;
            this.LblServerState.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.LblServerState.ForeColor = System.Drawing.SystemColors.Control;
            this.LblServerState.Location = new System.Drawing.Point(0, 0);
            this.LblServerState.Name = "LblServerState";
            this.LblServerState.Size = new System.Drawing.Size(283, 23);
            this.LblServerState.TabIndex = 5;
            this.LblServerState.Text = "サーバーステータス";
            // 
            // BtnHGServerStart
            // 
            this.BtnHGServerStart.Location = new System.Drawing.Point(16, 115);
            this.BtnHGServerStart.Name = "BtnHGServerStart";
            this.BtnHGServerStart.Size = new System.Drawing.Size(250, 40);
            this.BtnHGServerStart.TabIndex = 3;
            this.BtnHGServerStart.Text = "HGサーバー作動";
            this.BtnHGServerStart.UseVisualStyleBackColor = true;
            // 
            // BtnHGServerStop
            // 
            this.BtnHGServerStop.Location = new System.Drawing.Point(16, 160);
            this.BtnHGServerStop.Name = "BtnHGServerStop";
            this.BtnHGServerStop.Size = new System.Drawing.Size(250, 40);
            this.BtnHGServerStop.TabIndex = 3;
            this.BtnHGServerStop.Text = "HGサーバー停止";
            this.BtnHGServerStop.UseVisualStyleBackColor = true;
            // 
            // DgvList
            // 
            this.DgvList.AllowUserToAddRows = false;
            this.DgvList.AllowUserToDeleteRows = false;
            this.DgvList.AllowUserToResizeColumns = false;
            this.DgvList.AllowUserToResizeRows = false;
            this.DgvList.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvList.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvList.EnableHeadersVisualStyles = false;
            this.DgvList.Location = new System.Drawing.Point(298, 86);
            this.DgvList.Name = "DgvList";
            this.DgvList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvList.RowTemplate.Height = 21;
            this.DgvList.ShowCellToolTips = false;
            this.DgvList.ShowEditingIcon = false;
            this.DgvList.Size = new System.Drawing.Size(975, 789);
            this.DgvList.TabIndex = 29;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 10000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1284, 891);
            this.ControlBox = false;
            this.Controls.Add(this.DgvList);
            this.Controls.Add(this.panLogo);
            this.Controls.Add(this.PnlClose);
            this.Controls.Add(this.PnlManegementTool);
            this.Controls.Add(this.PanelLanguage);
            this.Controls.Add(this.PnlHGLog);
            this.Controls.Add(this.PnlServerStatus);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FrmMain";
            this.Text = "Database Manager";
            this.PnlClose.ResumeLayout(false);
            this.PnlManegementTool.ResumeLayout(false);
            this.PanelLanguage.ResumeLayout(false);
            this.PnlHGLog.ResumeLayout(false);
            this.PnlServerStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnHGServerStart;
        private System.Windows.Forms.Label LblServerState;
        private System.Windows.Forms.Button BtnHGServerStop;
        private System.Windows.Forms.Button BtnHGLogRecognition;
        private System.Windows.Forms.Button BtnHGLogClear;
        private System.Windows.Forms.Label LblHGLog;
        private System.Windows.Forms.Panel PnlServerStatus;
        private System.Windows.Forms.Panel PnlHGLog;
        private System.Windows.Forms.Panel PanelLanguage;
        private System.Windows.Forms.Label LblLanguage;
        private System.Windows.Forms.Button BtnChangeENG;
        private System.Windows.Forms.Button BtnChangeJPN;
        private System.Windows.Forms.Panel PnlManegementTool;
        private System.Windows.Forms.Label LblManegementTool;
        private System.Windows.Forms.Button BtnSetting;
        private System.Windows.Forms.Button BtnDBMaintenance;
        private System.Windows.Forms.Panel PnlClose;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Panel panLogo;
        private NipponPaint.NpCommon.FormControls.LampText lampText1;
        private NipponPaint.NpCommon.FormControls.LampText lampText3;
        private NipponPaint.NpCommon.FormControls.LampText lampText2;
        private System.Windows.Forms.DataGridView DgvList;
        private System.Windows.Forms.Timer Timer;
    }
}