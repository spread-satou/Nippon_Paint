namespace DatabaseManager.Dialogs
{
    partial class FrmDeliverySetting
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnSettingInitialize = new System.Windows.Forms.Button();
            this.BtnSettingSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.deliveryClassfication9 = new NipponPaint.NpCommon.FormControls.DeliveryClassification();
            this.deliveryClassfication8 = new NipponPaint.NpCommon.FormControls.DeliveryClassification();
            this.deliveryClassfication7 = new NipponPaint.NpCommon.FormControls.DeliveryClassification();
            this.deliveryClassfication6 = new NipponPaint.NpCommon.FormControls.DeliveryClassification();
            this.deliveryClassfication5 = new NipponPaint.NpCommon.FormControls.DeliveryClassification();
            this.deliveryClassfication4 = new NipponPaint.NpCommon.FormControls.DeliveryClassification();
            this.deliveryClassfication3 = new NipponPaint.NpCommon.FormControls.DeliveryClassification();
            this.deliveryClassfication2 = new NipponPaint.NpCommon.FormControls.DeliveryClassification();
            this.deliveryClassfication1 = new NipponPaint.NpCommon.FormControls.DeliveryClassification();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnSettingInitialize);
            this.groupBox4.Controls.Add(this.BtnSettingSave);
            this.groupBox4.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(621, 690);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(595, 76);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // BtnSettingInitialize
            // 
            this.BtnSettingInitialize.Enabled = false;
            this.BtnSettingInitialize.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.BtnSettingInitialize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSettingInitialize.Location = new System.Drawing.Point(335, 23);
            this.BtnSettingInitialize.Name = "BtnSettingInitialize";
            this.BtnSettingInitialize.Size = new System.Drawing.Size(250, 40);
            this.BtnSettingInitialize.TabIndex = 12;
            this.BtnSettingInitialize.Text = "設定を元に戻す";
            this.BtnSettingInitialize.UseVisualStyleBackColor = true;
            // 
            // BtnSettingSave
            // 
            this.BtnSettingSave.Enabled = false;
            this.BtnSettingSave.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.BtnSettingSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSettingSave.Location = new System.Drawing.Point(10, 23);
            this.BtnSettingSave.Name = "BtnSettingSave";
            this.BtnSettingSave.Size = new System.Drawing.Size(250, 40);
            this.BtnSettingSave.TabIndex = 11;
            this.BtnSettingSave.Text = "設定を保存";
            this.BtnSettingSave.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnClose);
            this.groupBox2.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(621, 774);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 76);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.BtnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnClose.Location = new System.Drawing.Point(335, 23);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(250, 40);
            this.BtnClose.TabIndex = 14;
            this.BtnClose.Text = "閉じる";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // deliveryClassfication9
            // 
            this.deliveryClassfication9.GrpBoxTitle = "運送区分9";
            this.deliveryClassfication9.GrpBoxTitleControlName = "GrpBox";
            this.deliveryClassfication9.LblChkDBColumnName = "Must_Notify";
            this.deliveryClassfication9.LblChkTitle = "ASK対象";
            this.deliveryClassfication9.LblChkTitleControlName = "LblTitle";
            this.deliveryClassfication9.LblDTPDBColumnName = "Default_Delivery_Time";
            this.deliveryClassfication9.LblDTPTitle = "出荷時間";
            this.deliveryClassfication9.LblDTPTitleConrtolName = "LblTitle";
            this.deliveryClassfication9.LblDTPValue = new System.DateTime(2022, 3, 14, 10, 54, 0, 511);
            this.deliveryClassfication9.LblRbtsDBColumnName = "Sort_Order";
            this.deliveryClassfication9.LblRbtsTitle = "ソート順";
            this.deliveryClassfication9.LblRbtsTitleControlName = "LblTitle";
            this.deliveryClassfication9.LblTxtBoxDataControlName = "TxtData";
            this.deliveryClassfication9.LblTxtBoxDBColumnName = "HG_Delivery_Kanji";
            this.deliveryClassfication9.LblTxtBoxMaxByteLength = 20;
            this.deliveryClassfication9.LblTxtBoxTitle = "配送モード";
            this.deliveryClassfication9.LblTxtBoxTitleControlName = "LblTitle";
            this.deliveryClassfication9.LblTxtBoxValue = "";
            this.deliveryClassfication9.Location = new System.Drawing.Point(621, 520);
            this.deliveryClassfication9.Name = "deliveryClassfication9";
            this.deliveryClassfication9.PanelNumber = 9;
            this.deliveryClassfication9.Size = new System.Drawing.Size(595, 160);
            this.deliveryClassfication9.TabIndex = 21;
            this.deliveryClassfication9.Tag = "9";
            // 
            // deliveryClassfication8
            // 
            this.deliveryClassfication8.GrpBoxTitle = "運送区分8";
            this.deliveryClassfication8.GrpBoxTitleControlName = "GrpBox";
            this.deliveryClassfication8.LblChkDBColumnName = "Must_Notify";
            this.deliveryClassfication8.LblChkTitle = "ASK対象";
            this.deliveryClassfication8.LblChkTitleControlName = "LblTitle";
            this.deliveryClassfication8.LblDTPDBColumnName = "Default_Delivery_Time";
            this.deliveryClassfication8.LblDTPTitle = "出荷時間";
            this.deliveryClassfication8.LblDTPTitleConrtolName = "LblTitle";
            this.deliveryClassfication8.LblDTPValue = new System.DateTime(2022, 3, 14, 10, 54, 0, 511);
            this.deliveryClassfication8.LblRbtsDBColumnName = "Sort_Order";
            this.deliveryClassfication8.LblRbtsTitle = "ソート順";
            this.deliveryClassfication8.LblRbtsTitleControlName = "LblTitle";
            this.deliveryClassfication8.LblTxtBoxDataControlName = "TxtData";
            this.deliveryClassfication8.LblTxtBoxDBColumnName = "HG_Delivery_Kanji";
            this.deliveryClassfication8.LblTxtBoxMaxByteLength = 20;
            this.deliveryClassfication8.LblTxtBoxTitle = "配送モード";
            this.deliveryClassfication8.LblTxtBoxTitleControlName = "LblTitle";
            this.deliveryClassfication8.LblTxtBoxValue = "";
            this.deliveryClassfication8.Location = new System.Drawing.Point(621, 350);
            this.deliveryClassfication8.Name = "deliveryClassfication8";
            this.deliveryClassfication8.PanelNumber = 8;
            this.deliveryClassfication8.Size = new System.Drawing.Size(595, 160);
            this.deliveryClassfication8.TabIndex = 8;
            this.deliveryClassfication8.Tag = "8";
            // 
            // deliveryClassfication7
            // 
            this.deliveryClassfication7.GrpBoxTitle = "運送区分7";
            this.deliveryClassfication7.GrpBoxTitleControlName = "GrpBox";
            this.deliveryClassfication7.LblChkDBColumnName = "Must_Notify";
            this.deliveryClassfication7.LblChkTitle = "ASK対象";
            this.deliveryClassfication7.LblChkTitleControlName = "LblTitle";
            this.deliveryClassfication7.LblDTPDBColumnName = "Default_Delivery_Time";
            this.deliveryClassfication7.LblDTPTitle = "出荷時間";
            this.deliveryClassfication7.LblDTPTitleConrtolName = "LblTitle";
            this.deliveryClassfication7.LblDTPValue = new System.DateTime(2022, 3, 14, 10, 54, 0, 511);
            this.deliveryClassfication7.LblRbtsDBColumnName = "Sort_Order";
            this.deliveryClassfication7.LblRbtsTitle = "ソート順";
            this.deliveryClassfication7.LblRbtsTitleControlName = "LblTitle";
            this.deliveryClassfication7.LblTxtBoxDataControlName = "TxtData";
            this.deliveryClassfication7.LblTxtBoxDBColumnName = "HG_Delivery_Kanji";
            this.deliveryClassfication7.LblTxtBoxMaxByteLength = 20;
            this.deliveryClassfication7.LblTxtBoxTitle = "配送モード";
            this.deliveryClassfication7.LblTxtBoxTitleControlName = "LblTitle";
            this.deliveryClassfication7.LblTxtBoxValue = "";
            this.deliveryClassfication7.Location = new System.Drawing.Point(621, 180);
            this.deliveryClassfication7.Name = "deliveryClassfication7";
            this.deliveryClassfication7.PanelNumber = 7;
            this.deliveryClassfication7.Size = new System.Drawing.Size(595, 160);
            this.deliveryClassfication7.TabIndex = 7;
            this.deliveryClassfication7.Tag = "7";
            // 
            // deliveryClassfication6
            // 
            this.deliveryClassfication6.GrpBoxTitle = "運送区分6";
            this.deliveryClassfication6.GrpBoxTitleControlName = "GrpBox";
            this.deliveryClassfication6.LblChkDBColumnName = "Must_Notify";
            this.deliveryClassfication6.LblChkTitle = "ASK対象";
            this.deliveryClassfication6.LblChkTitleControlName = "LblTitle";
            this.deliveryClassfication6.LblDTPDBColumnName = "Default_Delivery_Time";
            this.deliveryClassfication6.LblDTPTitle = "出荷時間";
            this.deliveryClassfication6.LblDTPTitleConrtolName = "LblTitle";
            this.deliveryClassfication6.LblDTPValue = new System.DateTime(2022, 3, 14, 10, 54, 0, 511);
            this.deliveryClassfication6.LblRbtsDBColumnName = "Sort_Order";
            this.deliveryClassfication6.LblRbtsTitle = "ソート順";
            this.deliveryClassfication6.LblRbtsTitleControlName = "LblTitle";
            this.deliveryClassfication6.LblTxtBoxDataControlName = "TxtData";
            this.deliveryClassfication6.LblTxtBoxDBColumnName = "HG_Delivery_Kanji";
            this.deliveryClassfication6.LblTxtBoxMaxByteLength = 20;
            this.deliveryClassfication6.LblTxtBoxTitle = "配送モード";
            this.deliveryClassfication6.LblTxtBoxTitleControlName = "LblTitle";
            this.deliveryClassfication6.LblTxtBoxValue = "";
            this.deliveryClassfication6.Location = new System.Drawing.Point(621, 10);
            this.deliveryClassfication6.Name = "deliveryClassfication6";
            this.deliveryClassfication6.PanelNumber = 6;
            this.deliveryClassfication6.Size = new System.Drawing.Size(595, 160);
            this.deliveryClassfication6.TabIndex = 6;
            this.deliveryClassfication6.Tag = "6";
            // 
            // deliveryClassfication5
            // 
            this.deliveryClassfication5.GrpBoxTitle = "運送区分5";
            this.deliveryClassfication5.GrpBoxTitleControlName = "GrpBox";
            this.deliveryClassfication5.LblChkDBColumnName = "Must_Notify";
            this.deliveryClassfication5.LblChkTitle = "ASK対象";
            this.deliveryClassfication5.LblChkTitleControlName = "LblTitle";
            this.deliveryClassfication5.LblDTPDBColumnName = "Default_Delivery_Time";
            this.deliveryClassfication5.LblDTPTitle = "出荷時間";
            this.deliveryClassfication5.LblDTPTitleConrtolName = "LblTitle";
            this.deliveryClassfication5.LblDTPValue = new System.DateTime(2022, 3, 14, 10, 54, 0, 511);
            this.deliveryClassfication5.LblRbtsDBColumnName = "Sort_Order";
            this.deliveryClassfication5.LblRbtsTitle = "ソート順";
            this.deliveryClassfication5.LblRbtsTitleControlName = "LblTitle";
            this.deliveryClassfication5.LblTxtBoxDataControlName = "TxtData";
            this.deliveryClassfication5.LblTxtBoxDBColumnName = "HG_Delivery_Kanji";
            this.deliveryClassfication5.LblTxtBoxMaxByteLength = 20;
            this.deliveryClassfication5.LblTxtBoxTitle = "配送モード";
            this.deliveryClassfication5.LblTxtBoxTitleControlName = "LblTitle";
            this.deliveryClassfication5.LblTxtBoxValue = "";
            this.deliveryClassfication5.Location = new System.Drawing.Point(10, 690);
            this.deliveryClassfication5.Name = "deliveryClassfication5";
            this.deliveryClassfication5.PanelNumber = 5;
            this.deliveryClassfication5.Size = new System.Drawing.Size(595, 160);
            this.deliveryClassfication5.TabIndex = 5;
            this.deliveryClassfication5.Tag = "5";
            // 
            // deliveryClassfication4
            // 
            this.deliveryClassfication4.GrpBoxTitle = "運送区分4";
            this.deliveryClassfication4.GrpBoxTitleControlName = "GrpBox";
            this.deliveryClassfication4.LblChkDBColumnName = "Must_Notify";
            this.deliveryClassfication4.LblChkTitle = "ASK対象";
            this.deliveryClassfication4.LblChkTitleControlName = "LblTitle";
            this.deliveryClassfication4.LblDTPDBColumnName = "Default_Delivery_Time";
            this.deliveryClassfication4.LblDTPTitle = "出荷時間";
            this.deliveryClassfication4.LblDTPTitleConrtolName = "LblTitle";
            this.deliveryClassfication4.LblDTPValue = new System.DateTime(2022, 3, 14, 10, 54, 0, 511);
            this.deliveryClassfication4.LblRbtsDBColumnName = "Sort_Order";
            this.deliveryClassfication4.LblRbtsTitle = "ソート順";
            this.deliveryClassfication4.LblRbtsTitleControlName = "LblTitle";
            this.deliveryClassfication4.LblTxtBoxDataControlName = "TxtData";
            this.deliveryClassfication4.LblTxtBoxDBColumnName = "HG_Delivery_Kanji";
            this.deliveryClassfication4.LblTxtBoxMaxByteLength = 20;
            this.deliveryClassfication4.LblTxtBoxTitle = "配送モード";
            this.deliveryClassfication4.LblTxtBoxTitleControlName = "LblTitle";
            this.deliveryClassfication4.LblTxtBoxValue = "";
            this.deliveryClassfication4.Location = new System.Drawing.Point(10, 520);
            this.deliveryClassfication4.Name = "deliveryClassfication4";
            this.deliveryClassfication4.PanelNumber = 4;
            this.deliveryClassfication4.Size = new System.Drawing.Size(595, 160);
            this.deliveryClassfication4.TabIndex = 4;
            this.deliveryClassfication4.Tag = "4";
            // 
            // deliveryClassfication3
            // 
            this.deliveryClassfication3.GrpBoxTitle = "運送区分3";
            this.deliveryClassfication3.GrpBoxTitleControlName = "GrpBox";
            this.deliveryClassfication3.LblChkDBColumnName = "Must_Notify";
            this.deliveryClassfication3.LblChkTitle = "ASK対象";
            this.deliveryClassfication3.LblChkTitleControlName = "LblTitle";
            this.deliveryClassfication3.LblDTPDBColumnName = "Default_Delivery_Time";
            this.deliveryClassfication3.LblDTPTitle = "出荷時間";
            this.deliveryClassfication3.LblDTPTitleConrtolName = "LblTitle";
            this.deliveryClassfication3.LblDTPValue = new System.DateTime(2022, 3, 14, 10, 54, 0, 511);
            this.deliveryClassfication3.LblRbtsDBColumnName = "Sort_Order";
            this.deliveryClassfication3.LblRbtsTitle = "ソート順";
            this.deliveryClassfication3.LblRbtsTitleControlName = "LblTitle";
            this.deliveryClassfication3.LblTxtBoxDataControlName = "TxtData";
            this.deliveryClassfication3.LblTxtBoxDBColumnName = "HG_Delivery_Kanji";
            this.deliveryClassfication3.LblTxtBoxMaxByteLength = 20;
            this.deliveryClassfication3.LblTxtBoxTitle = "配送モード";
            this.deliveryClassfication3.LblTxtBoxTitleControlName = "LblTitle";
            this.deliveryClassfication3.LblTxtBoxValue = "";
            this.deliveryClassfication3.Location = new System.Drawing.Point(10, 350);
            this.deliveryClassfication3.Name = "deliveryClassfication3";
            this.deliveryClassfication3.PanelNumber = 3;
            this.deliveryClassfication3.Size = new System.Drawing.Size(595, 160);
            this.deliveryClassfication3.TabIndex = 3;
            this.deliveryClassfication3.Tag = "3";
            // 
            // deliveryClassfication2
            // 
            this.deliveryClassfication2.GrpBoxTitle = "運送区分2";
            this.deliveryClassfication2.GrpBoxTitleControlName = "GrpBox";
            this.deliveryClassfication2.LblChkDBColumnName = "Must_Notify";
            this.deliveryClassfication2.LblChkTitle = "ASK対象";
            this.deliveryClassfication2.LblChkTitleControlName = "LblTitle";
            this.deliveryClassfication2.LblDTPDBColumnName = "Default_Delivery_Time";
            this.deliveryClassfication2.LblDTPTitle = "出荷時間";
            this.deliveryClassfication2.LblDTPTitleConrtolName = "LblTitle";
            this.deliveryClassfication2.LblDTPValue = new System.DateTime(2022, 3, 14, 10, 54, 0, 511);
            this.deliveryClassfication2.LblRbtsDBColumnName = "Sort_Order";
            this.deliveryClassfication2.LblRbtsTitle = "ソート順";
            this.deliveryClassfication2.LblRbtsTitleControlName = "LblTitle";
            this.deliveryClassfication2.LblTxtBoxDataControlName = "TxtData";
            this.deliveryClassfication2.LblTxtBoxDBColumnName = "HG_Delivery_Kanji";
            this.deliveryClassfication2.LblTxtBoxMaxByteLength = 20;
            this.deliveryClassfication2.LblTxtBoxTitle = "配送モード";
            this.deliveryClassfication2.LblTxtBoxTitleControlName = "LblTitle";
            this.deliveryClassfication2.LblTxtBoxValue = "";
            this.deliveryClassfication2.Location = new System.Drawing.Point(10, 180);
            this.deliveryClassfication2.Name = "deliveryClassfication2";
            this.deliveryClassfication2.PanelNumber = 2;
            this.deliveryClassfication2.Size = new System.Drawing.Size(595, 160);
            this.deliveryClassfication2.TabIndex = 2;
            this.deliveryClassfication2.Tag = "2";
            // 
            // deliveryClassfication1
            // 
            this.deliveryClassfication1.GrpBoxTitle = "運送区分1";
            this.deliveryClassfication1.GrpBoxTitleControlName = "GrpBox";
            this.deliveryClassfication1.LblChkDBColumnName = "Must_Notify";
            this.deliveryClassfication1.LblChkTitle = "ASK対象";
            this.deliveryClassfication1.LblChkTitleControlName = "LblTitle";
            this.deliveryClassfication1.LblDTPDBColumnName = "Default_Delivery_Time";
            this.deliveryClassfication1.LblDTPTitle = "出荷時間";
            this.deliveryClassfication1.LblDTPTitleConrtolName = "LblTitle";
            this.deliveryClassfication1.LblDTPValue = new System.DateTime(2022, 3, 14, 10, 54, 0, 511);
            this.deliveryClassfication1.LblRbtsDBColumnName = "Sort_Order";
            this.deliveryClassfication1.LblRbtsTitle = "ソート順";
            this.deliveryClassfication1.LblRbtsTitleControlName = "LblTitle";
            this.deliveryClassfication1.LblTxtBoxDataControlName = "TxtData";
            this.deliveryClassfication1.LblTxtBoxDBColumnName = "HG_Delivery_Kanji";
            this.deliveryClassfication1.LblTxtBoxMaxByteLength = 20;
            this.deliveryClassfication1.LblTxtBoxTitle = "配送モード";
            this.deliveryClassfication1.LblTxtBoxTitleControlName = "LblTitle";
            this.deliveryClassfication1.LblTxtBoxValue = "";
            this.deliveryClassfication1.Location = new System.Drawing.Point(10, 10);
            this.deliveryClassfication1.Name = "deliveryClassfication1";
            this.deliveryClassfication1.PanelNumber = 1;
            this.deliveryClassfication1.Size = new System.Drawing.Size(595, 160);
            this.deliveryClassfication1.TabIndex = 1;
            this.deliveryClassfication1.Tag = "1";
            // 
            // FrmDeliverySetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1229, 871);
            this.ControlBox = false;
            this.Controls.Add(this.deliveryClassfication9);
            this.Controls.Add(this.deliveryClassfication8);
            this.Controls.Add(this.deliveryClassfication7);
            this.Controls.Add(this.deliveryClassfication6);
            this.Controls.Add(this.deliveryClassfication5);
            this.Controls.Add(this.deliveryClassfication4);
            this.Controls.Add(this.deliveryClassfication3);
            this.Controls.Add(this.deliveryClassfication2);
            this.Controls.Add(this.deliveryClassfication1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FrmDeliverySetting";
            this.Text = "配送設定";
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnSettingInitialize;
        private System.Windows.Forms.Button BtnSettingSave;
        private System.Windows.Forms.Button BtnClose;
        private NipponPaint.NpCommon.FormControls.DeliveryClassification deliveryClassfication1;
        private NipponPaint.NpCommon.FormControls.DeliveryClassification deliveryClassfication2;
        private NipponPaint.NpCommon.FormControls.DeliveryClassification deliveryClassfication3;
        private NipponPaint.NpCommon.FormControls.DeliveryClassification deliveryClassfication4;
        private NipponPaint.NpCommon.FormControls.DeliveryClassification deliveryClassfication5;
        private NipponPaint.NpCommon.FormControls.DeliveryClassification deliveryClassfication6;
        private NipponPaint.NpCommon.FormControls.DeliveryClassification deliveryClassfication7;
        private NipponPaint.NpCommon.FormControls.DeliveryClassification deliveryClassfication8;
        private NipponPaint.NpCommon.FormControls.DeliveryClassification deliveryClassfication9;
        
    }
}