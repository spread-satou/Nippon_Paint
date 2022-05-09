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
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NipponPaint.NpCommon.FormControls
{
    public partial class TabPageEx : TabPage
    {
        public TabPageEx()
        {
            InitializeComponent();
        }

        public string PanelNumber { get; set; } = string.Empty;

        public string DatabaseColumnName { get; set; } = string.Empty;

        public TabPageEx(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
