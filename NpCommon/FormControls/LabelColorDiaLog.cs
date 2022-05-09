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
    public partial class LabelColorDiaLog : UserControl
    {
        public Label ValueColorCode
        {
            get { return LblColorCode; }
        }

        public string Code
        {
            get { return LblCode.Text; }
            set { LblCode.Text = value; }
        }

        public string ColorCode
        {
            get { return LblColorCode.Text; }
            set { LblColorCode.Text = value; }
        }

        public Color ButtonColor
        {
            get { return BtnColor.BackColor; }
            set { BtnColor.BackColor = value; }
        }

        public string DatabaseColumnName { get; set; } = string.Empty;

        public LabelColorDiaLog()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //BtnColorの背景色に選択された色を設定
                BtnColor.BackColor = colorDialog1.Color;
                //LblColorCodeに表示
                LblColorCode.Text = Funcs.RgbToInt(colorDialog1).ToString();               
            }
        }

        private void InitializeForm()
        {
            // イベントの追加
            this.BtnColor.Click += new System.EventHandler(this.BtnColor_Click);

        }


    }
}
