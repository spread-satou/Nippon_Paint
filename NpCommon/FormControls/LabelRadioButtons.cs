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

using System.Drawing;
using System.Windows.Forms;

namespace NipponPaint.NpCommon.FormControls
{
    public partial class LabelRadioButtons : UserControl
    {
        public RadioButton Rbt1CheckState
        {
            get { return Rbt1; }
            
        }
        public RadioButton Rbt2CheckState
        {
            get { return Rbt2; }

        }
        public RadioButton Rbt3CheckState
        {
            get { return Rbt3; }

        }
        public RadioButton Rbt4CheckState
        {
            get { return Rbt4; }

        }
        public RadioButton Rbt5CheckState
        {
            get { return Rbt5; }

        }
        public RadioButton Rbt6CheckState
        {
            get { return Rbt6; }

        }
        public RadioButton Rbt7CheckState
        {
            get { return Rbt7; }

        }
        public RadioButton Rbt8CheckState
        {
            get { return Rbt8; }

        }
        public RadioButton Rbt9CheckState
        {
            get { return Rbt9; }

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
        public LabelRadioButtons()
        {
            InitializeComponent();
        }
    }
}
