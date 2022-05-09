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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NipponPaint.NpCommon.FormControls
{
    public partial class TabCtrlPagePlants : UserControl
    {
        public int PanelNumber { get; set; }
        public string LblTxtBoxDBColumnName { get; set; } = string.Empty;
        public string LblNud1DBColumnName { get; set; } = string.Empty;
        public string LblNud2DBColumnName { get; set; } = string.Empty;
        public string LblDTPDBColumnName { get; set; } = string.Empty;

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

        #region LabelNumericUpDownコントロール (Nud1)
        public NumericUpDown LblNud1ValueNumericUpDown
        {
            get { return LblNud1.NumUpDownData; }
        }
        public string Nud1TitleControlName
        {
            get { return LblNud1.LblTitle.Name; }
            set { LblNud1.Name = value; }
        }

        public string LblNud1Title1
        {
            get { return LblNud1.LblTitle.Text; }
            set { LblNud1.LblTitle.Text = value; }
        }

        public Size LblNud1TitleSize
        {
            get { return LblNud1.LblTitle.Size; }
            set { LblNud1.LblTitle.Size = value; }
        }

        public decimal LblNud1Value
        {
            get { return LblNud1. NumUpDownData.Value; }
            set { LblNud1.NumUpDownData.Value = value; }
        }

        public decimal LblNud1Minimum
        {
            get { return LblNud1.NumUpDownData.Minimum; }
            set { LblNud1.NumUpDownData.Minimum = value; }
        }

        public decimal LblNud1Maximum
        {
            get { return LblNud1.NumUpDownData.Maximum; }
            set { LblNud1.NumUpDownData.Maximum = value; }
        }

        public int LblNud1DecimalPlaces
        {
            get { return LblNud1.NumUpDownData.DecimalPlaces; }
            set { LblNud1.NumUpDownData.DecimalPlaces = value; }
        }
        #endregion

        #region LabelNumericUpDownコントロール (Nud2)
        public NumericUpDown LblNud2ValueNumericUpDown
        {
            get { return LblNud2.NumUpDownData; }
        }
        public string LblNud2TitleControlName
        {
            get { return LblNud2.LblTitle.Name; }
            set { LblNud2.Name = value; }
        }

        public string LblNud2Title
        {
            get { return LblNud2.LblTitle.Text; }
            set { LblNud2.LblTitle.Text = value; }
        }

        public Size LblNud2TitleSize
        {
            get { return LblNud2.LblTitle.Size; }
            set { LblNud2.LblTitle.Size = value; }
        }

        public decimal LblNud2Value
        {
            get { return LblNud2.NumUpDownData.Value; }
            set { LblNud2.NumUpDownData.Value = value; }
        }

        public decimal LblNud2Minimum
        {
            get { return LblNud2.NumUpDownData.Minimum; }
            set { LblNud2.NumUpDownData.Minimum = value; }
        }

        public decimal LblNud2Maximum
        {
            get { return LblNud2.NumUpDownData.Maximum; }
            set { LblNud2.NumUpDownData.Maximum = value; }
        }

        public int LblNud2DecimalPlaces
        {
            get { return LblNud2.NumUpDownData.DecimalPlaces; }
            set { LblNud2.NumUpDownData.DecimalPlaces = value; }
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
        public TabCtrlPagePlants()
        {
            InitializeComponent();
        }
    }
}
