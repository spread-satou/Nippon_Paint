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

#region using defines
using System.Drawing;
using System.Windows.Forms;
#endregion

namespace NipponPaint.NpCommon.FormControls
{
    public partial class LabelNumericUpDown : UserControl
    {
        public string Id { get; set; }
        public NumericUpDown ValueNumericUpDown
        {
            get { return NumUpDownData; }
        }
        public string TitleControlName
        {
            get { return LblTitle.Name; }
            set { LblTitle.Name = value; }
        }

        public string Title
        {
            get { return LblTitle.Text; }
            set { LblTitle.Text = value; }
        }

        public Size TitleSize
        {
            get { return LblTitle.Size; }
            set { LblTitle.Size = value; }
        }

        public decimal Value
        {
            get { return NumUpDownData.Value; }
            set { NumUpDownData.Value = value; }
        }
        public Color TextBackColor
        {
            get { return NumUpDownData.BackColor; }
            set { NumUpDownData.BackColor = value; }
        }

        public Color TextForeColor
        {
            get { return NumUpDownData.ForeColor; }
            set { NumUpDownData.ForeColor = value; }
        }

        public decimal Minimum
        {
            get { return NumUpDownData.Minimum; }
            set { NumUpDownData.Minimum = value; }
        }

        public decimal Maximum
        {
            get { return NumUpDownData.Maximum; }
            set { NumUpDownData.Maximum = value; }
        }
        public string DatabaseColumnName { get; set; } = string.Empty;

        public int DecimalPlaces
        {
            get { return NumUpDownData.DecimalPlaces; }
            set { NumUpDownData.DecimalPlaces = value; }
        }

        public HorizontalAlignment TextAlign
        {
            get { return NumUpDownData.TextAlign; }
            set { NumUpDownData.TextAlign = value; }
        }

        public LabelNumericUpDown()
        {
            InitializeComponent();
        }
    }
}
