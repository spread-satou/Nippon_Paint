//*****************************************************************************
//
//  システム名：調色工場用自動計量システム NpCommon
//
//  Copyright 三菱電機エンジニアリング株式会社 2022 All rights reserved.
//
//-----------------------------------------------------------------------------
//  変更履歴:
//  Ver      日付        担当       コメント
//  0.0      2022/04/30  A.Satou    新規作成
#region 更新履歴
#endregion
//*****************************************************************************

namespace NipponPaint.OrderManager.Dialogs
{
    partial class FrmOrderStart
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
            this.PnlBtn = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnOrderBack = new System.Windows.Forms.Button();
            this.BtnOrderStart = new System.Windows.Forms.Button();
            this.DropDownCapType = new NipponPaint.NpCommon.FormControls.LabelDropDown();
            this.NumUpDownQualitySample = new NipponPaint.NpCommon.FormControls.LabelNumericUpDown();
            this.NumUpDownMixingTime = new NipponPaint.NpCommon.FormControls.LabelNumericUpDown();
            this.NumUpDownMixingSpeed = new NipponPaint.NpCommon.FormControls.LabelNumericUpDown();
            this.NumUpDownWeightTolerance = new NipponPaint.NpCommon.FormControls.LabelNumericUpDownMulti();
            this.NumUpDownFilledWeight = new NipponPaint.NpCommon.FormControls.LabelNumericUpDown();
            this.NumUpDownOverfilling = new NipponPaint.NpCommon.FormControls.LabelNumericUpDown();
            this.ChkTestCan = new NipponPaint.NpCommon.FormControls.LabelCheckBoxSingle();
            this.ChkTrustableCombination = new NipponPaint.NpCommon.FormControls.LabelCheckBoxSingle();
            this.ChkHandCapping = new NipponPaint.NpCommon.FormControls.LabelCheckBoxSingle();
            this.DropDownCanType = new NipponPaint.NpCommon.FormControls.LabelDropDown();
            this.DropDownLabelType = new NipponPaint.NpCommon.FormControls.LabelDropDown();
            this.TxtWhiteCode = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.TxtRevision = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.TxtTotalWeight = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.TxtColorName = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.TxtProductCode = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.TxtNumberOfCan = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.TxtPaintName = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.TxtFormalPaintName = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.TxtOrderNumber = new NipponPaint.NpCommon.FormControls.LabelTextBox();
            this.PnlBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBtn
            // 
            this.PnlBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PnlBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlBtn.Controls.Add(this.BtnClose);
            this.PnlBtn.Controls.Add(this.BtnOrderBack);
            this.PnlBtn.Controls.Add(this.BtnOrderStart);
            this.PnlBtn.Location = new System.Drawing.Point(12, 748);
            this.PnlBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PnlBtn.Name = "PnlBtn";
            this.PnlBtn.Size = new System.Drawing.Size(719, 68);
            this.PnlBtn.TabIndex = 90;
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnClose.Location = new System.Drawing.Point(491, 6);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(220, 54);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "閉じる";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnOrderBack
            // 
            this.BtnOrderBack.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnOrderBack.Location = new System.Drawing.Point(232, 6);
            this.BtnOrderBack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnOrderBack.Name = "BtnOrderBack";
            this.BtnOrderBack.Size = new System.Drawing.Size(220, 54);
            this.BtnOrderBack.TabIndex = 1;
            this.BtnOrderBack.Text = "注文を戻す(&F9)";
            this.BtnOrderBack.UseVisualStyleBackColor = true;
            // 
            // BtnOrderStart
            // 
            this.BtnOrderStart.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnOrderStart.Location = new System.Drawing.Point(6, 6);
            this.BtnOrderStart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnOrderStart.Name = "BtnOrderStart";
            this.BtnOrderStart.Size = new System.Drawing.Size(220, 54);
            this.BtnOrderStart.TabIndex = 0;
            this.BtnOrderStart.Text = "注文開始";
            this.BtnOrderStart.UseVisualStyleBackColor = true;
            // 
            // DropDownCapType
            // 
            this.DropDownCapType.DatabaseColumnName = "";
            this.DropDownCapType.DisplayMemberField = "";
            this.DropDownCapType.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DropDownCapType.Id = null;
            this.DropDownCapType.Location = new System.Drawing.Point(12, 327);
            this.DropDownCapType.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DropDownCapType.Name = "DropDownCapType";
            this.DropDownCapType.Size = new System.Drawing.Size(719, 31);
            this.DropDownCapType.TabIndex = 22;
            this.DropDownCapType.TableName = "";
            this.DropDownCapType.Title = "キャップタイプ(&A)";
            this.DropDownCapType.TitleControlName = "lblTitle";
            this.DropDownCapType.TitleSize = new System.Drawing.Size(154, 31);
            this.DropDownCapType.ValueMemberField = "";
            // 
            // NumUpDownQualitySample
            // 
            this.NumUpDownQualitySample.DatabaseColumnName = "";
            this.NumUpDownQualitySample.DecimalPlaces = 0;
            this.NumUpDownQualitySample.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NumUpDownQualitySample.Id = null;
            this.NumUpDownQualitySample.Location = new System.Drawing.Point(12, 642);
            this.NumUpDownQualitySample.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NumUpDownQualitySample.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.NumUpDownQualitySample.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumUpDownQualitySample.Name = "NumUpDownQualitySample";
            this.NumUpDownQualitySample.Size = new System.Drawing.Size(293, 30);
            this.NumUpDownQualitySample.TabIndex = 96;
            this.NumUpDownQualitySample.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NumUpDownQualitySample.Title = "ｸｵﾘﾃｨｻﾝﾌﾟﾙ[g](&Q)";
            this.NumUpDownQualitySample.TitleControlName = "lblTitle";
            this.NumUpDownQualitySample.TitleSize = new System.Drawing.Size(154, 30);
            this.NumUpDownQualitySample.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // NumUpDownMixingTime
            // 
            this.NumUpDownMixingTime.DatabaseColumnName = "";
            this.NumUpDownMixingTime.DecimalPlaces = 0;
            this.NumUpDownMixingTime.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NumUpDownMixingTime.Id = null;
            this.NumUpDownMixingTime.Location = new System.Drawing.Point(12, 677);
            this.NumUpDownMixingTime.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NumUpDownMixingTime.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.NumUpDownMixingTime.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumUpDownMixingTime.Name = "NumUpDownMixingTime";
            this.NumUpDownMixingTime.Size = new System.Drawing.Size(293, 30);
            this.NumUpDownMixingTime.TabIndex = 95;
            this.NumUpDownMixingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NumUpDownMixingTime.Title = "ﾐｷｼﾝｸﾞﾀｲﾑ[s](&J)";
            this.NumUpDownMixingTime.TitleControlName = "lblTitle";
            this.NumUpDownMixingTime.TitleSize = new System.Drawing.Size(154, 30);
            this.NumUpDownMixingTime.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // NumUpDownMixingSpeed
            // 
            this.NumUpDownMixingSpeed.DatabaseColumnName = "";
            this.NumUpDownMixingSpeed.DecimalPlaces = 0;
            this.NumUpDownMixingSpeed.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NumUpDownMixingSpeed.Id = null;
            this.NumUpDownMixingSpeed.Location = new System.Drawing.Point(12, 712);
            this.NumUpDownMixingSpeed.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NumUpDownMixingSpeed.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.NumUpDownMixingSpeed.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumUpDownMixingSpeed.Name = "NumUpDownMixingSpeed";
            this.NumUpDownMixingSpeed.Size = new System.Drawing.Size(293, 30);
            this.NumUpDownMixingSpeed.TabIndex = 94;
            this.NumUpDownMixingSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NumUpDownMixingSpeed.Title = "ﾐｷｼﾝｸﾞｽﾋﾟｰﾄﾞ(回/分)(&K)";
            this.NumUpDownMixingSpeed.TitleControlName = "lblTitle";
            this.NumUpDownMixingSpeed.TitleSize = new System.Drawing.Size(190, 30);
            this.NumUpDownMixingSpeed.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // NumUpDownWeightTolerance
            // 
            this.NumUpDownWeightTolerance.DatabaseColumnNameLeft = "";
            this.NumUpDownWeightTolerance.DatabaseColumnNameRight = "";
            this.NumUpDownWeightTolerance.DecimalPlacesLeft = 1;
            this.NumUpDownWeightTolerance.DecimalPlacesRight = 1;
            this.NumUpDownWeightTolerance.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NumUpDownWeightTolerance.Id = 0;
            this.NumUpDownWeightTolerance.Location = new System.Drawing.Point(12, 607);
            this.NumUpDownWeightTolerance.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NumUpDownWeightTolerance.MaximumLeft = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumUpDownWeightTolerance.MaximumRight = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumUpDownWeightTolerance.MinimumLeft = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NumUpDownWeightTolerance.MinimumRight = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NumUpDownWeightTolerance.Name = "NumUpDownWeightTolerance";
            this.NumUpDownWeightTolerance.NumUpDownLeftControlName = "NumUpDownDataMin";
            this.NumUpDownWeightTolerance.NumUpDownLeftSize = new System.Drawing.Size(139, 30);
            this.NumUpDownWeightTolerance.NumUpDownRightControlName = "NumUpDownDataMax";
            this.NumUpDownWeightTolerance.Size = new System.Drawing.Size(432, 30);
            this.NumUpDownWeightTolerance.TabIndex = 93;
            this.NumUpDownWeightTolerance.TextAlignLeft = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumUpDownWeightTolerance.TextAlignRight = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumUpDownWeightTolerance.Title = "重量誤差[%](&X)";
            this.NumUpDownWeightTolerance.TitleControlName = "lblTitle";
            this.NumUpDownWeightTolerance.TitleSize = new System.Drawing.Size(154, 30);
            this.NumUpDownWeightTolerance.ValueLeft = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumUpDownWeightTolerance.ValueRight = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // NumUpDownFilledWeight
            // 
            this.NumUpDownFilledWeight.DatabaseColumnName = "";
            this.NumUpDownFilledWeight.DecimalPlaces = 0;
            this.NumUpDownFilledWeight.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NumUpDownFilledWeight.Id = null;
            this.NumUpDownFilledWeight.Location = new System.Drawing.Point(12, 572);
            this.NumUpDownFilledWeight.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NumUpDownFilledWeight.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.NumUpDownFilledWeight.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumUpDownFilledWeight.Name = "NumUpDownFilledWeight";
            this.NumUpDownFilledWeight.Size = new System.Drawing.Size(293, 30);
            this.NumUpDownFilledWeight.TabIndex = 92;
            this.NumUpDownFilledWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NumUpDownFilledWeight.Title = "充填済み重量(g)(&H)";
            this.NumUpDownFilledWeight.TitleControlName = "lblTitle";
            this.NumUpDownFilledWeight.TitleSize = new System.Drawing.Size(154, 30);
            this.NumUpDownFilledWeight.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // NumUpDownOverfilling
            // 
            this.NumUpDownOverfilling.DatabaseColumnName = "";
            this.NumUpDownOverfilling.DecimalPlaces = 1;
            this.NumUpDownOverfilling.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NumUpDownOverfilling.Id = null;
            this.NumUpDownOverfilling.Location = new System.Drawing.Point(12, 537);
            this.NumUpDownOverfilling.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NumUpDownOverfilling.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumUpDownOverfilling.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumUpDownOverfilling.Name = "NumUpDownOverfilling";
            this.NumUpDownOverfilling.Size = new System.Drawing.Size(293, 30);
            this.NumUpDownOverfilling.TabIndex = 91;
            this.NumUpDownOverfilling.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NumUpDownOverfilling.Title = "超過[%](&V)";
            this.NumUpDownOverfilling.TitleControlName = "lblTitle";
            this.NumUpDownOverfilling.TitleSize = new System.Drawing.Size(154, 30);
            this.NumUpDownOverfilling.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // ChkTestCan
            // 
            this.ChkTestCan.DatabaseColumnName = "";
            this.ChkTestCan.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ChkTestCan.Id = 0;
            this.ChkTestCan.Location = new System.Drawing.Point(12, 432);
            this.ChkTestCan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ChkTestCan.Name = "ChkTestCan";
            this.ChkTestCan.Size = new System.Drawing.Size(293, 30);
            this.ChkTestCan.TabIndex = 26;
            this.ChkTestCan.Title = "テスト缶(&S)";
            this.ChkTestCan.TitleControlName = "lblTitle";
            this.ChkTestCan.TitleSize = new System.Drawing.Size(154, 30);
            // 
            // ChkTrustableCombination
            // 
            this.ChkTrustableCombination.DatabaseColumnName = "";
            this.ChkTrustableCombination.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ChkTrustableCombination.Id = 0;
            this.ChkTrustableCombination.Location = new System.Drawing.Point(12, 467);
            this.ChkTrustableCombination.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ChkTrustableCombination.Name = "ChkTrustableCombination";
            this.ChkTrustableCombination.Size = new System.Drawing.Size(293, 30);
            this.ChkTrustableCombination.TabIndex = 25;
            this.ChkTrustableCombination.Title = "信頼できる配合(&B)";
            this.ChkTrustableCombination.TitleControlName = "lblTitle";
            this.ChkTrustableCombination.TitleSize = new System.Drawing.Size(154, 30);
            // 
            // ChkHandCapping
            // 
            this.ChkHandCapping.DatabaseColumnName = "";
            this.ChkHandCapping.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ChkHandCapping.Id = 0;
            this.ChkHandCapping.Location = new System.Drawing.Point(12, 362);
            this.ChkHandCapping.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ChkHandCapping.Name = "ChkHandCapping";
            this.ChkHandCapping.Size = new System.Drawing.Size(293, 30);
            this.ChkHandCapping.TabIndex = 24;
            this.ChkHandCapping.Title = "手動キャッピング(&I)";
            this.ChkHandCapping.TitleControlName = "lblTitle";
            this.ChkHandCapping.TitleSize = new System.Drawing.Size(154, 30);
            // 
            // DropDownCanType
            // 
            this.DropDownCanType.DatabaseColumnName = "";
            this.DropDownCanType.DisplayMemberField = "";
            this.DropDownCanType.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DropDownCanType.Id = null;
            this.DropDownCanType.Location = new System.Drawing.Point(12, 292);
            this.DropDownCanType.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DropDownCanType.Name = "DropDownCanType";
            this.DropDownCanType.Size = new System.Drawing.Size(719, 31);
            this.DropDownCanType.TabIndex = 23;
            this.DropDownCanType.TableName = "";
            this.DropDownCanType.Title = "缶タイプ(&T)";
            this.DropDownCanType.TitleControlName = "lblTitle";
            this.DropDownCanType.TitleSize = new System.Drawing.Size(154, 31);
            this.DropDownCanType.ValueMemberField = "";
            // 
            // DropDownLabelType
            // 
            this.DropDownLabelType.DatabaseColumnName = "";
            this.DropDownLabelType.DisplayMemberField = "";
            this.DropDownLabelType.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DropDownLabelType.Id = null;
            this.DropDownLabelType.Location = new System.Drawing.Point(12, 222);
            this.DropDownLabelType.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DropDownLabelType.Name = "DropDownLabelType";
            this.DropDownLabelType.Size = new System.Drawing.Size(719, 31);
            this.DropDownLabelType.TabIndex = 21;
            this.DropDownLabelType.TableName = "";
            this.DropDownLabelType.Title = "ラベルタイプ(&L)";
            this.DropDownLabelType.TitleControlName = "lblTitle";
            this.DropDownLabelType.TitleSize = new System.Drawing.Size(154, 31);
            this.DropDownLabelType.ValueMemberField = "";
            // 
            // TxtWhiteCode
            // 
            this.TxtWhiteCode.DatabaseColumnName = "";
            this.TxtWhiteCode.DataControlName = "txtData";
            this.TxtWhiteCode.DataEnabled = true;
            this.TxtWhiteCode.DataReadOnly = false;
            this.TxtWhiteCode.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtWhiteCode.DataTextSize = new System.Drawing.Size(565, 30);
            this.TxtWhiteCode.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtWhiteCode.Id = null;
            this.TxtWhiteCode.Label = "";
            this.TxtWhiteCode.Location = new System.Drawing.Point(12, 257);
            this.TxtWhiteCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtWhiteCode.MaxByteLength = 65535;
            this.TxtWhiteCode.MaxLength = 0;
            this.TxtWhiteCode.Name = "TxtWhiteCode";
            this.TxtWhiteCode.Size = new System.Drawing.Size(719, 30);
            this.TxtWhiteCode.TabIndex = 15;
            this.TxtWhiteCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtWhiteCode.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtWhiteCode.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtWhiteCode.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtWhiteCode.Title = "白コード(&W)";
            this.TxtWhiteCode.TitleControlName = "lblTitle";
            this.TxtWhiteCode.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtWhiteCode.Value = "";
            // 
            // TxtRevision
            // 
            this.TxtRevision.DatabaseColumnName = "";
            this.TxtRevision.DataControlName = "txtData";
            this.TxtRevision.DataEnabled = true;
            this.TxtRevision.DataReadOnly = false;
            this.TxtRevision.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtRevision.DataTextSize = new System.Drawing.Size(139, 30);
            this.TxtRevision.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtRevision.Id = null;
            this.TxtRevision.Label = "";
            this.TxtRevision.Location = new System.Drawing.Point(12, 397);
            this.TxtRevision.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtRevision.MaxByteLength = 65535;
            this.TxtRevision.MaxLength = 0;
            this.TxtRevision.Name = "TxtRevision";
            this.TxtRevision.Size = new System.Drawing.Size(293, 30);
            this.TxtRevision.TabIndex = 12;
            this.TxtRevision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtRevision.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtRevision.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtRevision.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtRevision.Title = "補正(&R)";
            this.TxtRevision.TitleControlName = "lblTitle";
            this.TxtRevision.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtRevision.Value = "";
            // 
            // TxtTotalWeight
            // 
            this.TxtTotalWeight.DatabaseColumnName = "";
            this.TxtTotalWeight.DataControlName = "txtData";
            this.TxtTotalWeight.DataEnabled = true;
            this.TxtTotalWeight.DataReadOnly = false;
            this.TxtTotalWeight.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtTotalWeight.DataTextSize = new System.Drawing.Size(139, 30);
            this.TxtTotalWeight.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtTotalWeight.Id = null;
            this.TxtTotalWeight.Label = "";
            this.TxtTotalWeight.Location = new System.Drawing.Point(12, 502);
            this.TxtTotalWeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTotalWeight.MaxByteLength = 65535;
            this.TxtTotalWeight.MaxLength = 0;
            this.TxtTotalWeight.Name = "TxtTotalWeight";
            this.TxtTotalWeight.Size = new System.Drawing.Size(293, 30);
            this.TxtTotalWeight.TabIndex = 9;
            this.TxtTotalWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtTotalWeight.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtTotalWeight.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtTotalWeight.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtTotalWeight.Title = "合計重量[g](&U)";
            this.TxtTotalWeight.TitleControlName = "lblTitle";
            this.TxtTotalWeight.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtTotalWeight.Value = "";
            // 
            // TxtColorName
            // 
            this.TxtColorName.DatabaseColumnName = "";
            this.TxtColorName.DataControlName = "txtData";
            this.TxtColorName.DataEnabled = true;
            this.TxtColorName.DataReadOnly = false;
            this.TxtColorName.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtColorName.DataTextSize = new System.Drawing.Size(565, 30);
            this.TxtColorName.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtColorName.Id = null;
            this.TxtColorName.Label = "";
            this.TxtColorName.Location = new System.Drawing.Point(12, 47);
            this.TxtColorName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtColorName.MaxByteLength = 65535;
            this.TxtColorName.MaxLength = 0;
            this.TxtColorName.Name = "TxtColorName";
            this.TxtColorName.Size = new System.Drawing.Size(719, 30);
            this.TxtColorName.TabIndex = 5;
            this.TxtColorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtColorName.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtColorName.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtColorName.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtColorName.Title = "色名(&C)";
            this.TxtColorName.TitleControlName = "lblTitle";
            this.TxtColorName.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtColorName.Value = "";
            // 
            // TxtProductCode
            // 
            this.TxtProductCode.DatabaseColumnName = "";
            this.TxtProductCode.DataControlName = "txtData";
            this.TxtProductCode.DataEnabled = true;
            this.TxtProductCode.DataReadOnly = false;
            this.TxtProductCode.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtProductCode.DataTextSize = new System.Drawing.Size(139, 30);
            this.TxtProductCode.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtProductCode.Id = null;
            this.TxtProductCode.Label = "";
            this.TxtProductCode.Location = new System.Drawing.Point(12, 82);
            this.TxtProductCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtProductCode.MaxByteLength = 65535;
            this.TxtProductCode.MaxLength = 0;
            this.TxtProductCode.Name = "TxtProductCode";
            this.TxtProductCode.Size = new System.Drawing.Size(293, 30);
            this.TxtProductCode.TabIndex = 4;
            this.TxtProductCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtProductCode.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtProductCode.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtProductCode.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtProductCode.Title = "製品コード(&P)";
            this.TxtProductCode.TitleControlName = "lblTitle";
            this.TxtProductCode.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtProductCode.Value = "";
            // 
            // TxtNumberOfCan
            // 
            this.TxtNumberOfCan.DatabaseColumnName = "";
            this.TxtNumberOfCan.DataControlName = "txtData";
            this.TxtNumberOfCan.DataEnabled = true;
            this.TxtNumberOfCan.DataReadOnly = false;
            this.TxtNumberOfCan.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtNumberOfCan.DataTextSize = new System.Drawing.Size(139, 30);
            this.TxtNumberOfCan.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtNumberOfCan.Id = null;
            this.TxtNumberOfCan.Label = "";
            this.TxtNumberOfCan.Location = new System.Drawing.Point(12, 117);
            this.TxtNumberOfCan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNumberOfCan.MaxByteLength = 65535;
            this.TxtNumberOfCan.MaxLength = 0;
            this.TxtNumberOfCan.Name = "TxtNumberOfCan";
            this.TxtNumberOfCan.Size = new System.Drawing.Size(293, 30);
            this.TxtNumberOfCan.TabIndex = 3;
            this.TxtNumberOfCan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtNumberOfCan.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtNumberOfCan.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtNumberOfCan.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtNumberOfCan.Title = "缶数(&N)";
            this.TxtNumberOfCan.TitleControlName = "lblTitle";
            this.TxtNumberOfCan.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtNumberOfCan.Value = "";
            // 
            // TxtPaintName
            // 
            this.TxtPaintName.DatabaseColumnName = "";
            this.TxtPaintName.DataControlName = "txtData";
            this.TxtPaintName.DataEnabled = true;
            this.TxtPaintName.DataReadOnly = false;
            this.TxtPaintName.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtPaintName.DataTextSize = new System.Drawing.Size(565, 30);
            this.TxtPaintName.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtPaintName.Id = null;
            this.TxtPaintName.Label = "";
            this.TxtPaintName.Location = new System.Drawing.Point(12, 152);
            this.TxtPaintName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPaintName.MaxByteLength = 65535;
            this.TxtPaintName.MaxLength = 0;
            this.TxtPaintName.Name = "TxtPaintName";
            this.TxtPaintName.Size = new System.Drawing.Size(719, 30);
            this.TxtPaintName.TabIndex = 2;
            this.TxtPaintName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtPaintName.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtPaintName.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtPaintName.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtPaintName.Title = "品名(&M)";
            this.TxtPaintName.TitleControlName = "lblTitle";
            this.TxtPaintName.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtPaintName.Value = "";
            // 
            // TxtFormalPaintName
            // 
            this.TxtFormalPaintName.DatabaseColumnName = "";
            this.TxtFormalPaintName.DataControlName = "txtData";
            this.TxtFormalPaintName.DataEnabled = true;
            this.TxtFormalPaintName.DataReadOnly = false;
            this.TxtFormalPaintName.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtFormalPaintName.DataTextSize = new System.Drawing.Size(565, 30);
            this.TxtFormalPaintName.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtFormalPaintName.Id = null;
            this.TxtFormalPaintName.Label = "";
            this.TxtFormalPaintName.Location = new System.Drawing.Point(12, 187);
            this.TxtFormalPaintName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtFormalPaintName.MaxByteLength = 65535;
            this.TxtFormalPaintName.MaxLength = 0;
            this.TxtFormalPaintName.Name = "TxtFormalPaintName";
            this.TxtFormalPaintName.Size = new System.Drawing.Size(719, 30);
            this.TxtFormalPaintName.TabIndex = 1;
            this.TxtFormalPaintName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtFormalPaintName.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtFormalPaintName.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtFormalPaintName.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtFormalPaintName.Title = "正式品種名(&F)";
            this.TxtFormalPaintName.TitleControlName = "lblTitle";
            this.TxtFormalPaintName.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtFormalPaintName.Value = "";
            // 
            // TxtOrderNumber
            // 
            this.TxtOrderNumber.DatabaseColumnName = "";
            this.TxtOrderNumber.DataControlName = "txtData";
            this.TxtOrderNumber.DataEnabled = true;
            this.TxtOrderNumber.DataReadOnly = false;
            this.TxtOrderNumber.DataTextLocation = new System.Drawing.Point(154, 0);
            this.TxtOrderNumber.DataTextSize = new System.Drawing.Size(278, 30);
            this.TxtOrderNumber.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtOrderNumber.Id = null;
            this.TxtOrderNumber.Label = "";
            this.TxtOrderNumber.Location = new System.Drawing.Point(12, 12);
            this.TxtOrderNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtOrderNumber.MaxByteLength = 65535;
            this.TxtOrderNumber.MaxLength = 0;
            this.TxtOrderNumber.Name = "TxtOrderNumber";
            this.TxtOrderNumber.Size = new System.Drawing.Size(432, 30);
            this.TxtOrderNumber.TabIndex = 0;
            this.TxtOrderNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtOrderNumber.TextBackColor = System.Drawing.SystemColors.Window;
            this.TxtOrderNumber.TextFont = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtOrderNumber.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtOrderNumber.Title = "注文番号(&O)";
            this.TxtOrderNumber.TitleControlName = "lblTitle";
            this.TxtOrderNumber.TitleSize = new System.Drawing.Size(154, 30);
            this.TxtOrderNumber.Value = "";
            // 
            // FrmOrderStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(742, 826);
            this.ControlBox = false;
            this.Controls.Add(this.DropDownCapType);
            this.Controls.Add(this.NumUpDownQualitySample);
            this.Controls.Add(this.NumUpDownMixingTime);
            this.Controls.Add(this.NumUpDownMixingSpeed);
            this.Controls.Add(this.NumUpDownWeightTolerance);
            this.Controls.Add(this.NumUpDownFilledWeight);
            this.Controls.Add(this.NumUpDownOverfilling);
            this.Controls.Add(this.PnlBtn);
            this.Controls.Add(this.ChkTestCan);
            this.Controls.Add(this.ChkTrustableCombination);
            this.Controls.Add(this.ChkHandCapping);
            this.Controls.Add(this.DropDownCanType);
            this.Controls.Add(this.DropDownLabelType);
            this.Controls.Add(this.TxtWhiteCode);
            this.Controls.Add(this.TxtRevision);
            this.Controls.Add(this.TxtTotalWeight);
            this.Controls.Add(this.TxtColorName);
            this.Controls.Add(this.TxtProductCode);
            this.Controls.Add(this.TxtNumberOfCan);
            this.Controls.Add(this.TxtPaintName);
            this.Controls.Add(this.TxtFormalPaintName);
            this.Controls.Add(this.TxtOrderNumber);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "FrmOrderStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "注文開始";
            this.PnlBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtOrderNumber;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtFormalPaintName;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtPaintName;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtNumberOfCan;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtProductCode;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtColorName;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtTotalWeight;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtRevision;
        private NipponPaint.NpCommon.FormControls.LabelTextBox TxtWhiteCode;
        private NipponPaint.NpCommon.FormControls.LabelDropDown DropDownLabelType;
        private NipponPaint.NpCommon.FormControls.LabelDropDown DropDownCapType;
        private NipponPaint.NpCommon.FormControls.LabelDropDown DropDownCanType;
        private NipponPaint.NpCommon.FormControls.LabelCheckBoxSingle ChkHandCapping;
        private NipponPaint.NpCommon.FormControls.LabelCheckBoxSingle ChkTrustableCombination;
        private NipponPaint.NpCommon.FormControls.LabelCheckBoxSingle ChkTestCan;
        private System.Windows.Forms.Panel PnlBtn;
        private System.Windows.Forms.Button BtnOrderStart;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnOrderBack;
        private NipponPaint.NpCommon.FormControls.LabelNumericUpDown NumUpDownOverfilling;
        private NipponPaint.NpCommon.FormControls.LabelNumericUpDown NumUpDownFilledWeight;
        private NipponPaint.NpCommon.FormControls.LabelNumericUpDownMulti NumUpDownWeightTolerance;
        private NipponPaint.NpCommon.FormControls.LabelNumericUpDown NumUpDownMixingSpeed;
        private NipponPaint.NpCommon.FormControls.LabelNumericUpDown NumUpDownMixingTime;
        private NipponPaint.NpCommon.FormControls.LabelNumericUpDown NumUpDownQualitySample;
    }
}