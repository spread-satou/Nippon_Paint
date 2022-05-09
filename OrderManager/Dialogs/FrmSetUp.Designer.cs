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
    partial class FrmSetUp
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
            this.GrpBoxSetting = new System.Windows.Forms.GroupBox();
            this.DrpBaudRate = new NipponPaint.NpCommon.FormControls.LabelDropDown();
            this.DrpDataBits = new NipponPaint.NpCommon.FormControls.LabelDropDown();
            this.DrpFlowControl = new NipponPaint.NpCommon.FormControls.LabelDropDown();
            this.DrpParity = new NipponPaint.NpCommon.FormControls.LabelDropDown();
            this.DrpStopBits = new NipponPaint.NpCommon.FormControls.LabelDropDown();
            this.DrpPort = new NipponPaint.NpCommon.FormControls.LabelDropDown();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.GrpBoxSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBoxSetting
            // 
            this.GrpBoxSetting.Controls.Add(this.DrpBaudRate);
            this.GrpBoxSetting.Controls.Add(this.DrpDataBits);
            this.GrpBoxSetting.Controls.Add(this.DrpFlowControl);
            this.GrpBoxSetting.Controls.Add(this.DrpParity);
            this.GrpBoxSetting.Controls.Add(this.DrpStopBits);
            this.GrpBoxSetting.Controls.Add(this.DrpPort);
            this.GrpBoxSetting.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GrpBoxSetting.Location = new System.Drawing.Point(12, 12);
            this.GrpBoxSetting.Name = "GrpBoxSetting";
            this.GrpBoxSetting.Size = new System.Drawing.Size(444, 255);
            this.GrpBoxSetting.TabIndex = 0;
            this.GrpBoxSetting.TabStop = false;
            this.GrpBoxSetting.Text = "Settings";
            // 
            // DrpBaudRate
            // 
            this.DrpBaudRate.DatabaseColumnName = "";
            this.DrpBaudRate.DisplayMemberField = "";
            this.DrpBaudRate.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DrpBaudRate.Id = null;
            this.DrpBaudRate.Location = new System.Drawing.Point(9, 66);
            this.DrpBaudRate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DrpBaudRate.Name = "DrpBaudRate";
            this.DrpBaudRate.Size = new System.Drawing.Size(293, 31);
            this.DrpBaudRate.TabIndex = 27;
            this.DrpBaudRate.TableName = "";
            this.DrpBaudRate.Title = "Baud rate(&B)";
            this.DrpBaudRate.TitleControlName = "lblTitle";
            this.DrpBaudRate.TitleSize = new System.Drawing.Size(155, 31);
            this.DrpBaudRate.ValueMemberField = "";
            // 
            // DrpDataBits
            // 
            this.DrpDataBits.DatabaseColumnName = "";
            this.DrpDataBits.DisplayMemberField = "";
            this.DrpDataBits.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DrpDataBits.Id = null;
            this.DrpDataBits.Location = new System.Drawing.Point(9, 101);
            this.DrpDataBits.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DrpDataBits.Name = "DrpDataBits";
            this.DrpDataBits.Size = new System.Drawing.Size(293, 31);
            this.DrpDataBits.TabIndex = 26;
            this.DrpDataBits.TableName = "";
            this.DrpDataBits.Title = "Data bits(&D)";
            this.DrpDataBits.TitleControlName = "lblTitle";
            this.DrpDataBits.TitleSize = new System.Drawing.Size(155, 31);
            this.DrpDataBits.ValueMemberField = "";
            // 
            // DrpFlowControl
            // 
            this.DrpFlowControl.DatabaseColumnName = "";
            this.DrpFlowControl.DisplayMemberField = "";
            this.DrpFlowControl.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DrpFlowControl.Id = null;
            this.DrpFlowControl.Location = new System.Drawing.Point(9, 206);
            this.DrpFlowControl.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DrpFlowControl.Name = "DrpFlowControl";
            this.DrpFlowControl.Size = new System.Drawing.Size(293, 31);
            this.DrpFlowControl.TabIndex = 25;
            this.DrpFlowControl.TableName = "";
            this.DrpFlowControl.Title = "Flow control(&F)";
            this.DrpFlowControl.TitleControlName = "lblTitle";
            this.DrpFlowControl.TitleSize = new System.Drawing.Size(155, 31);
            this.DrpFlowControl.ValueMemberField = "";
            // 
            // DrpParity
            // 
            this.DrpParity.DatabaseColumnName = "";
            this.DrpParity.DisplayMemberField = "";
            this.DrpParity.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DrpParity.Id = null;
            this.DrpParity.Location = new System.Drawing.Point(9, 171);
            this.DrpParity.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DrpParity.Name = "DrpParity";
            this.DrpParity.Size = new System.Drawing.Size(293, 31);
            this.DrpParity.TabIndex = 24;
            this.DrpParity.TableName = "";
            this.DrpParity.Title = "Parity(&R)";
            this.DrpParity.TitleControlName = "lblTitle";
            this.DrpParity.TitleSize = new System.Drawing.Size(155, 31);
            this.DrpParity.ValueMemberField = "";
            // 
            // DrpStopBits
            // 
            this.DrpStopBits.DatabaseColumnName = "";
            this.DrpStopBits.DisplayMemberField = "";
            this.DrpStopBits.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DrpStopBits.Id = null;
            this.DrpStopBits.Location = new System.Drawing.Point(9, 136);
            this.DrpStopBits.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DrpStopBits.Name = "DrpStopBits";
            this.DrpStopBits.Size = new System.Drawing.Size(293, 31);
            this.DrpStopBits.TabIndex = 23;
            this.DrpStopBits.TableName = "";
            this.DrpStopBits.Title = "Stop bits(&S)";
            this.DrpStopBits.TitleControlName = "lblTitle";
            this.DrpStopBits.TitleSize = new System.Drawing.Size(155, 31);
            this.DrpStopBits.ValueMemberField = "";
            // 
            // DrpPort
            // 
            this.DrpPort.DatabaseColumnName = "";
            this.DrpPort.DisplayMemberField = "";
            this.DrpPort.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DrpPort.Id = null;
            this.DrpPort.Location = new System.Drawing.Point(9, 31);
            this.DrpPort.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DrpPort.Name = "DrpPort";
            this.DrpPort.Size = new System.Drawing.Size(293, 31);
            this.DrpPort.TabIndex = 22;
            this.DrpPort.TableName = "";
            this.DrpPort.Title = "Port(&P)";
            this.DrpPort.TitleControlName = "lblTitle";
            this.DrpPort.TitleSize = new System.Drawing.Size(155, 31);
            this.DrpPort.ValueMemberField = "";
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnCancel.Location = new System.Drawing.Point(236, 274);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(220, 54);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnOK
            // 
            this.BtnOK.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnOK.Location = new System.Drawing.Point(12, 274);
            this.BtnOK.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(220, 54);
            this.BtnOK.TabIndex = 5;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            // 
            // FrmSetUp
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(468, 338);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.GrpBoxSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmSetUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Setup";
            this.GrpBoxSetting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBoxSetting;
        private NipponPaint.NpCommon.FormControls.LabelDropDown DrpPort;
        private NipponPaint.NpCommon.FormControls.LabelDropDown DrpBaudRate;
        private NipponPaint.NpCommon.FormControls.LabelDropDown DrpDataBits;
        private NipponPaint.NpCommon.FormControls.LabelDropDown DrpFlowControl;
        private NipponPaint.NpCommon.FormControls.LabelDropDown DrpParity;
        private NipponPaint.NpCommon.FormControls.LabelDropDown DrpStopBits;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOK;
    }
}