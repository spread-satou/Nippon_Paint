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
    public partial class LabelCodeText : UserControl
    {
        public TextBox Code
        {
            get { return TxtCode; }
        }
        public TextBox Data
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
            set { TxtData.Size = value; }
        }

        public Size CodeTextSize
        {
            get { return TxtCode.Size; }
            set { TxtCode.Size = value; }
        }

        public string CodeControlName
        {
            get { return TxtCode.Name; }
            set { TxtCode.Name = value; }
        }

        public string CodeText
        {
            get { return TxtCode.Text; }
            set { TxtCode.Text = value; }
        }
        public bool CodeReadOnly
        {
            get { return TxtCode.ReadOnly; }
            set { TxtCode.ReadOnly = value; }
        }

        public string DataControlName
        {
            get { return TxtData.Name; }
            set { TxtData.Name = value; }
        }

        public override string Text
        {
            get { return TxtData.Text; }
            set { TxtData.Text = value; }
        }

        public bool DataReadOnly
        {
            get { return TxtData.ReadOnly; }
            set { TxtData.ReadOnly = value; }
        }

        public Color TextBackColor
        {
            get { return TxtData.BackColor; }
            set { TxtData.BackColor = value; }
        }
        public Color TextForeColor
        {
            get { return TxtData.ForeColor; }
            set { TxtData.ForeColor = value; }
        }

        public HorizontalAlignment TextAlignCode
        {
            get { return TxtCode.TextAlign; }
            set { TxtCode.TextAlign = value; }
        }

        public HorizontalAlignment TextAlignData
        {
            get { return TxtData.TextAlign; }
            set { TxtData.TextAlign = value; }
        }
        public string DatabaseColumnCode { get; set; } = string.Empty;
        public string DatabaseColumnName { get; set; } = string.Empty;

        public LabelCodeText()
        {
            InitializeComponent();
        }
    }
}
