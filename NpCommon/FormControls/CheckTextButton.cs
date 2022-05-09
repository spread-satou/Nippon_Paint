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
    public partial class CheckTextButton : UserControl
    {
        public string TitleControlName
        {
            get { return ChkTitle.Name; }
            set { ChkTitle.Name = value; }
        }
        public string Title
        {
            get { return ChkTitle.Text; }
            set { ChkTitle.Text = value; }
        }
        public CheckTextButton()
        {
            InitializeComponent();
        }


        private void Btn_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                filePath = openFileDialog.FileName;
                TxtData.Text = filePath;
            }

        }
    }
}
