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
using System.Collections.Generic;
using NipponPaint.NpCommon.Database;
#endregion

namespace NipponPaint.NpCommon.FormControls
{
    public partial class LabelDropDown : UserControl
    {
        public ComboBox DropDown
        {
            get { return DropDownData; }
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
        public string DisplayMemberField { get; set; } = string.Empty;
        public string ValueMemberField { get; set; } = string.Empty;
        public string TableName { get; set; } = string.Empty;

        public object SelectedValue
        {
            get { return DropDownData.SelectedValue; }
        }

        public object SelectedText
        {
            get { return DropDownData.SelectedText; }
        }
        public Color TextBackColor
        {
            get { return DropDownData.BackColor; }
            set { DropDownData.BackColor = value; }
        }
        public Color TextForeColor
        {
            get { return DropDownData.ForeColor; }
            set { DropDownData.ForeColor = value; }
        }
        public string Id { get; set; }
        public string DatabaseColumnName { get; set; } = string.Empty;

        //public int MaxDropDownItems
        //{
        //    get { return DropDownData.MaxDropDownItems; }
        //    set { DropDownData.MaxDropDownItems = value; }
        //}
        public LabelDropDown()
        {
            InitializeComponent();
        }

        public void InitializeDropdownItems(SqlBase.DatabaseKind databaseKind, Log.ApplicationType applicationType)
        {
            using (var db = new SqlBase(databaseKind, SqlBase.TransactionUse.No, applicationType))
            {
                if (!string.IsNullOrEmpty(DisplayMemberField))
                {
                    if (!string.IsNullOrEmpty(ValueMemberField))
                    {
                        var recs = db.Select($"SELECT {ValueMemberField}, CONVERT(varchar,{ValueMemberField}) + ' - ' + {DisplayMemberField} As {DisplayMemberField} FROM {TableName} Order by {ValueMemberField}");
                        DropDownData.DataSource = recs;
                        DropDownData.DisplayMember = DisplayMemberField;
                        DropDownData.ValueMember = ValueMemberField;
                        DropDownData.MaxDropDownItems = 8;
                    }
                    else
                    {
                        var recs = db.Select($"SELECT {DisplayMemberField} FROM {TableName}");
                        DropDownData.DataSource = recs;
                        DropDownData.DisplayMember = DisplayMemberField;
                        DropDownData.ValueMember = DisplayMemberField;
                        DropDownData.MaxDropDownItems = 8;
                    }
                }
                   
            }
        }

    }
}
