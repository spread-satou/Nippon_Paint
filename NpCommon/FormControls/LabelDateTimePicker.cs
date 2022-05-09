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
    public partial class LabelDateTimePicker : UserControl
    {
        public int Id { get; set; }
        public DateTimePicker ValueDateTimePicker
        {
            get { return DateTimePickerData; }
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

        public DateTime Value
        {
            get { return DateTimePickerData.Value; }
            set { DateTimePickerData.Value = value; }
        }

        public DateTime MinDate
        {
            get { return DateTimePickerData.MinDate; }
            set { DateTimePickerData.MinDate = value; }
        }

        public DateTime MaxDate
        {
            get { return DateTimePickerData.MaxDate; }
            set { DateTimePickerData.MaxDate = value; }
        }

        public string DatabaseColumnName { get; set; } = string.Empty;

        public LabelDateTimePicker()
        {
            InitializeComponent();
        }
    }
}
