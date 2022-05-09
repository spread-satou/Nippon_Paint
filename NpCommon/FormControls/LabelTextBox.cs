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
    public partial class LabelTextBox : UserControl
    {
        public string Id { get; set; }
        public TextBox ValueTextBox
        {
            get { return TxtData; }
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

        public Size DataTextSize
        {
            get { return TxtData.Size; }
            set { TxtData.Size = new Size(value.Width, value.Height); }
        }

        public Point DataTextLocation
        {
            get { return TxtData.Location; }
            set { TxtData.Location = value; }
        }

        public string DataControlName
        {
            get { return TxtData.Name; }
            set { TxtData.Name = value; }
        }

        public string Value
        {
            get { return TxtData.Text; }
            set { TxtData.Text = value; }
        }
        
        public string Label
        {
            get { return TxtData.Text; }
            set { TxtData.Text = value; }
        }

        public HorizontalAlignment TextAlign
        {
            get { return TxtData.TextAlign; }
            set { TxtData.TextAlign = value; }
        }

        public Font TextFont
        {
            get { return TxtData.Font; }
            set { TxtData.Font = value; }
        }

        public Color TextBackColor
        {
            get { return TxtData.BackColor; }
            set { TxtData.BackColor = value; }
        }

        public BorderStyle TextBorderStyle
        {
            get { return TxtData.BorderStyle; }
            set { TxtData.BorderStyle = value; }
        }


        public Color TextForeColor
        {
            get { return TxtData.ForeColor; }
            set { TxtData.ForeColor = value; }
        }

        public string DatabaseColumnName { get; set; } = string.Empty;

        public bool DataEnabled
        {
            get { return TxtData.Enabled; }
            set { TxtData.Enabled = value; }
        }

        public bool DataReadOnly
        {
            get { return TxtData.ReadOnly; }
            set { TxtData.ReadOnly = value; }
        }

        public int MaxLength
        {
            get { return TxtData.MaxLength; }
            set { TxtData.MaxLength = value; }
        }

        public int MaxByteLength
        {
            get { return TxtData.MaxByteLength; }
            set { TxtData.MaxByteLength = value; }
        }

        public LabelTextBox()
        {
            InitializeComponent();
        }
    }
}
