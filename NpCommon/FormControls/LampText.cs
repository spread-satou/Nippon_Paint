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
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NipponPaint.NpCommon.FormControls
{
    public partial class LampText : UserControl
    {
        public LampText()
        {
            InitializeComponent();
            
            //多角形の頂点の位置を設定
            GraphicsPath path = new GraphicsPath();
            GraphicsPath path2 = new GraphicsPath();
            path.AddEllipse(new Rectangle(0, 0, 12, 12));
            path2.AddEllipse(new Rectangle(0, 0, 20, 20));
            CrColor.Region = new Region(path);
            BdrColor.Region = new Region(path2);
        }

        public string Code
        {
            get { return LblText.Text; }
            set { LblText.Text = value; }
        }
        public Color BoderColor
        {            
            get { return BdrColor.BackColor; }
            set { BdrColor.BackColor = value; }
        }
        public Color CoreColor
        {
            get { return CrColor.BackColor; }
            set { CrColor.BackColor = value; }
        }
    }
}
