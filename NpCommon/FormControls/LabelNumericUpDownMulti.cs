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
    public partial class LabelNumericUpDownMulti : UserControl
    {
        public int Id { get; set; }
        public NumericUpDown LeftSide
        {
            get { return NumUpDownDataLeft; }
        }

        public NumericUpDown RightSide
        {
            get { return NumUpDownDataRight; }
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

        public Size NumUpDownLeftSize
        {
            get { return NumUpDownDataLeft.Size; }
            set { NumUpDownDataLeft.Size = value; }
        }

        public string NumUpDownLeftControlName
        {
            get { return NumUpDownDataLeft.Name; }
            set { NumUpDownDataLeft.Name = value; }
        }

        public string NumUpDownRightControlName
        {
            get { return NumUpDownDataRight.Name; }
            set { NumUpDownDataRight.Name = value; }
        }

        public decimal ValueLeft
        {
            get { return NumUpDownDataLeft.Value; }
            set { NumUpDownDataLeft.Value = value; }
        }

        public decimal ValueRight
        {
            get { return NumUpDownDataRight.Value; }
            set { NumUpDownDataRight.Value = value; }
        }

        public decimal MinimumLeft
        {
            get { return NumUpDownDataLeft.Minimum; }
            set { NumUpDownDataLeft.Minimum = value; }
        }

        public decimal MinimumRight
        {
            get { return NumUpDownDataRight.Minimum; }
            set { NumUpDownDataRight.Minimum = value; }
        }

        public decimal MaximumLeft
        {
            get { return NumUpDownDataLeft.Maximum; }
            set { NumUpDownDataLeft.Maximum = value; }
        }

        public decimal MaximumRight
        {
            get { return NumUpDownDataRight.Maximum; }
            set { NumUpDownDataRight.Maximum = value; }
        }

        public string DatabaseColumnNameLeft { get; set; } = string.Empty;
        public string DatabaseColumnNameRight { get; set; } = string.Empty;

        public int DecimalPlacesLeft
        {
            get { return NumUpDownDataLeft.DecimalPlaces; }
            set { NumUpDownDataLeft.DecimalPlaces = value; }
        }

        public int DecimalPlacesRight
        {
            get { return NumUpDownDataRight.DecimalPlaces; }
            set { NumUpDownDataRight.DecimalPlaces = value; }
        }

        public HorizontalAlignment TextAlignLeft
        {
            get { return NumUpDownDataLeft.TextAlign; }
            set { NumUpDownDataLeft.TextAlign = value; }
        }

        public HorizontalAlignment TextAlignRight
        {
            get { return NumUpDownDataRight.TextAlign; }
            set { NumUpDownDataRight.TextAlign = value; }
        }

        public LabelNumericUpDownMulti()
        {
            InitializeComponent();
            InitializeForm();


        }

        public void InitializeForm()
        {
            this.NumUpDownDataLeft.ValueChanged += new System.EventHandler(this.NumUpDownDataLeft_ValueChanged);
            this.NumUpDownDataRight.ValueChanged += new System.EventHandler(this.NumUpDownDataRight_ValueChanged);
        }

        public void NumUpDownDataLeft_ValueChanged(object sender, System.EventArgs e)
        {
            if(NumUpDownDataRight.Value < NumUpDownDataLeft.Value)
            {
                NumUpDownDataRight.Value = NumUpDownDataLeft.Value;
            }
        }

        public void NumUpDownDataRight_ValueChanged(object sender, System.EventArgs e)
        {
            if(NumUpDownDataRight.Value < NumUpDownDataLeft.Value)
            {
                NumUpDownDataLeft.Value = NumUpDownDataRight.Value;
            }
        }
    }
}
