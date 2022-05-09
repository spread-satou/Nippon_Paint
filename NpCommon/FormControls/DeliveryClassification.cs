//*****************************************************************************
//
//  システム名：調色工場用自動計量システム NpCommon
//
//  Copyright 三菱電機エンジニアリング株式会社 2022 All rights reserved.
//
//-----------------------------------------------------------------------------
//  変更履歴:
//  Ver      日付        担当       コメント
//  0.0      2022/04/30  M.Nakai    新規作成
#region 更新履歴
#endregion
//*****************************************************************************

#region using defines
using System;
using System.Drawing;
using System.Windows.Forms;
#endregion

namespace NipponPaint.NpCommon.FormControls
{

    public partial class DeliveryClassification : UserControl
    {
        #region GroupBoxコントロール
        public string GrpBoxTitleControlName
        {
            get { return GrpBox.Name; }
            set { GrpBox.Name = value; }
        }
        public string GrpBoxTitle
        {
            get { return GrpBox.Text; }
            set { GrpBox.Text = value; }
        }
        public int PanelNumber { get; set; }
        public string LblTxtBoxDBColumnName { get; set; } = string.Empty;
        public string LblChkDBColumnName { get; set; } = string.Empty;
        public string LblRbtsDBColumnName { get; set; } = string.Empty;
        public string LblDTPDBColumnName { get; set; } = string.Empty;
        #endregion

        #region LabelTextBoxコントロール
        public TextBox ValueTextBox
        {
            get { return LblTxtBox.ValueTextBox; }
        }
        public string LblTxtBoxTitleControlName
        {
            get { return LblTxtBox.TitleControlName; }
            set { LblTxtBox.TitleControlName = value; }
        }
        public string LblTxtBoxTitle
        {
            get { return LblTxtBox.Title; }
            set { LblTxtBox.Title = value; }
        }
        public string LblTxtBoxDataControlName
        {
            get { return LblTxtBox.DataControlName; }
            set { LblTxtBox.DataControlName = value; }
        }
        public string LblTxtBoxValue
        {
            get { return LblTxtBox.Value; }
            set { LblTxtBox.Value = value; }
        }
        public int LblTxtBoxMaxByteLength
        {
            get { return LblTxtBox.MaxByteLength; }
            set { LblTxtBox.MaxByteLength = value; }
        }

        #endregion

        #region LabelDateTimePickerコントロール
        public DateTimePicker ValueDateTimePicker
        {
            get { return LblDTP.ValueDateTimePicker; }
        }
        public string LblDTPTitleConrtolName
        {
            get { return LblDTP.TitleControlName; }
            set { LblDTP.TitleControlName = value; }
        }
        public string LblDTPTitle
        {
            get { return LblDTP.Title; }
            set { LblDTP.Title = value; }
        }
        public DateTime LblDTPValue
        {
            get { return LblDTP.Value; }
            set { LblDTP.Value = value; }
        } 
        
        #endregion

        #region LabelRadioButtonsコントロール
        public LabelRadioButtons labelRadioButtons
        {
            get { return LblRbts; }
        }
        public string LblRbtsTitleControlName
        {
            get { return LblRbts.TitleControlName; }
            set { LblRbts.TitleControlName = value; }
        }
        public RadioButton Rbt1CheckState
        {
            get { return LblRbts.Rbt1CheckState; }

        }
        public RadioButton Rbt2CheckState
        {
            get { return LblRbts.Rbt2CheckState; }

        }
        public RadioButton Rbt3CheckState
        {
            get { return LblRbts.Rbt3CheckState; }

        }
        public RadioButton Rbt4CheckState
        {
            get { return LblRbts.Rbt4CheckState; }

        }
        public RadioButton Rbt5CheckState
        {
            get { return LblRbts.Rbt5CheckState; }

        }
        public RadioButton Rbt6CheckState
        {
            get { return LblRbts.Rbt6CheckState; }

        }
        public RadioButton Rbt7CheckState
        {
            get { return LblRbts.Rbt7CheckState; }

        }
        public RadioButton Rbt8CheckState
        {
            get { return LblRbts.Rbt8CheckState; }

        }
        public RadioButton Rbt9CheckState
        {
            get { return LblRbts.Rbt9CheckState; }

        }
        public string LblRbtsTitle
        {
            get { return LblRbts.Title; }
            set { LblRbts.Title = value; }
        }
        #endregion

        #region LabelCheckBoxSingleコントロール
        public CheckBox CheckState
        {
            get { return LblChk.CheckState; }
        }
        public string LblChkTitleControlName
        {
            get { return LblChk.TitleControlName; }
            set { LblChk.TitleControlName = value; }
        }
        public string LblChkTitle
        {
            get { return LblChk.Title; }
            set { LblChk.Title = value; }
        }
        #endregion
        public DeliveryClassification()
        {
            InitializeComponent();
        }
    }
}
