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
    public partial class TabCtrlPagePlantsSetting : UserControl
    {
        public int PanelNumber { get; set; }

        #region LabelTextBox1コントロール
        public TextBox ValueTextBox1
        {
            get { return LblTxtBox1.ValueTextBox; }
        }
        public string LblTxtBox1TitleControlName
        {
            get { return LblTxtBox1.TitleControlName; }
            set { LblTxtBox1.TitleControlName = value; }
        }
        public string LblTxtBox1Title
        {
            get { return LblTxtBox1.Title; }
            set { LblTxtBox1.Title = value; }
        }
        public string LblTxtBox1DataControlName
        {
            get { return LblTxtBox1.DataControlName; }
            set { LblTxtBox1.DataControlName = value; }
        }
        public string LblTxtBox1Value
        {
            get { return LblTxtBox1.Value; }
            set { LblTxtBox1.Value = value; }
        }
        public HorizontalAlignment LblTxtBox1TextAlign
        {
            get { return LblTxtBox1.TextAlign; }
            set { LblTxtBox1.TextAlign = value; }
        }

        public string LblTxtBox1DBColumnName
        {
            get { return LblTxtBox1.DatabaseColumnName; }
            set { LblTxtBox1.DatabaseColumnName = value; }
        }

        public int LblTxtBox1MaxByteLength
        {
            get { return LblTxtBox1.MaxByteLength; }
            set { LblTxtBox1.MaxByteLength = value; }
        }


        #endregion

        #region LabelTextBox2コントロール
        public TextBox ValueTextBox2
        {
            get { return LblTxtBox2.ValueTextBox; }
        }
        public string LblTxtBox2TitleControlName
        {
            get { return LblTxtBox2.TitleControlName; }
            set { LblTxtBox2.TitleControlName = value; }
        }
        public string LblTxtBox2Title
        {
            get { return LblTxtBox2.Title; }
            set { LblTxtBox2.Title = value; }
        }
        public string LblTxtBox2DataControlName
        {
            get { return LblTxtBox2.DataControlName; }
            set { LblTxtBox2.DataControlName = value; }
        }
        public string LblTxtBox2Value
        {
            get { return LblTxtBox2.Value; }
            set { LblTxtBox2.Value = value; }
        }
        public HorizontalAlignment LblTxtBox2TextAlign
        {
            get { return LblTxtBox2.TextAlign; }
            set { LblTxtBox2.TextAlign = value; }
        }

        public string LblTxtBox2DBColumnName
        {
            get { return LblTxtBox2.DatabaseColumnName; }
            set { LblTxtBox2.DatabaseColumnName = value; }
        }

        public int LblTxtBox2MaxByteLength
        {
            get { return LblTxtBox2.MaxByteLength; }
            set { LblTxtBox2.MaxByteLength = value; }
        }
        #endregion

        #region LabelTextBox3コントロール
        public TextBox ValueTextBox3
        {
            get { return LblTxtBox3.ValueTextBox; }
        }
        public string LblTxtBox3TitleControlName
        {
            get { return LblTxtBox3.TitleControlName; }
            set { LblTxtBox3.TitleControlName = value; }
        }
        public string LblTxtBox3Title
        {
            get { return LblTxtBox3.Title; }
            set { LblTxtBox3.Title = value; }
        }
        public string LblTxtBox3DataControlName
        {
            get { return LblTxtBox3.DataControlName; }
            set { LblTxtBox3.DataControlName = value; }
        }
        public string LblTxtBox3Value
        {
            get { return LblTxtBox3.Value; }
            set { LblTxtBox3.Value = value; }
        }
        public HorizontalAlignment LblTxtBox3TextAlign
        {
            get { return LblTxtBox3.TextAlign; }
            set { LblTxtBox3.TextAlign = value; }
        }

        public string LblTxtBox3DBColumnName
        {
            get { return LblTxtBox3.DatabaseColumnName; }
            set { LblTxtBox3.DatabaseColumnName = value; }
        }

        public int LblTxtBox3MaxByteLength
        {
            get { return LblTxtBox3.MaxByteLength; }
            set { LblTxtBox3.MaxByteLength = value; }
        }
        #endregion

        #region LabelTextBox4コントロール
        public TextBox ValueTextBox4
        {
            get { return LblTxtBox4.ValueTextBox; }
        }
        public string LblTxtBox4TitleControlName
        {
            get { return LblTxtBox4.TitleControlName; }
            set { LblTxtBox4.TitleControlName = value; }
        }
        public string LblTxtBox4Title
        {
            get { return LblTxtBox4.Title; }
            set { LblTxtBox4.Title = value; }
        }
        public string LblTxtBox4DataControlName
        {
            get { return LblTxtBox4.DataControlName; }
            set { LblTxtBox4.DataControlName = value; }
        }
        public string LblTxtBox4Value
        {
            get { return LblTxtBox4.Value; }
            set { LblTxtBox4.Value = value; }
        }
        public HorizontalAlignment LblTxtBox4TextAlign
        {
            get { return LblTxtBox4.TextAlign; }
            set { LblTxtBox4.TextAlign = value; }
        }

        public string LblTxtBox4DBColumnName
        {
            get { return LblTxtBox4.DatabaseColumnName; }
            set { LblTxtBox4.DatabaseColumnName = value; }
        }

        public int LblTxtBox4MaxByteLength
        {
            get { return LblTxtBox4.MaxByteLength; }
            set { LblTxtBox4.MaxByteLength = value; }
        }
        #endregion

        #region LabelTextBox5コントロール
        public TextBox ValueTextBox5
        {
            get { return LblTxtBox5.ValueTextBox; }
        }
        public string LblTxtBox5TitleControlName
        {
            get { return LblTxtBox5.TitleControlName; }
            set { LblTxtBox5.TitleControlName = value; }
        }
        public string LblTxtBox5Title
        {
            get { return LblTxtBox5.Title; }
            set { LblTxtBox5.Title = value; }
        }
        public string LblTxtBox5DataControlName
        {
            get { return LblTxtBox5.DataControlName; }
            set { LblTxtBox5.DataControlName = value; }
        }
        public string LblTxtBox5Value
        {
            get { return LblTxtBox5.Value; }
            set { LblTxtBox5.Value = value; }
        }
        public HorizontalAlignment LblTxtBox5TextAlign
        {
            get { return LblTxtBox5.TextAlign; }
            set { LblTxtBox5.TextAlign = value; }
        }

        public string LblTxtBox5DBColumnName
        {
            get { return LblTxtBox5.DatabaseColumnName; }
            set { LblTxtBox5.DatabaseColumnName = value; }
        }

        public int LblTxtBox5MaxByteLength
        {
            get { return LblTxtBox5.MaxByteLength; }
            set { LblTxtBox5.MaxByteLength = value; }
        }
        #endregion

        #region LabelTextBox6コントロール
        public TextBox ValueTextBox6
        {
            get { return LblTxtBox6.ValueTextBox; }
        }
        public string LblTxtBox6TitleControlName
        {
            get { return LblTxtBox6.TitleControlName; }
            set { LblTxtBox6.TitleControlName = value; }
        }
        public string LblTxtBox6Title
        {
            get { return LblTxtBox6.Title; }
            set { LblTxtBox6.Title = value; }
        }
        public string LblTxtBox6DataControlName
        {
            get { return LblTxtBox6.DataControlName; }
            set { LblTxtBox6.DataControlName = value; }
        }
        public string LblTxtBox6Value
        {
            get { return LblTxtBox6.Value; }
            set { LblTxtBox6.Value = value; }
        }
        public HorizontalAlignment LblTxtBox6TextAlign
        {
            get { return LblTxtBox6.TextAlign; }
            set { LblTxtBox6.TextAlign = value; }
        }

        public string LblTxtBox6DBColumnName
        {
            get { return LblTxtBox6.DatabaseColumnName; }
            set { LblTxtBox6.DatabaseColumnName = value; }
        }

        public int LblTxtBox6MaxByteLength
        {
            get { return LblTxtBox6.MaxByteLength; }
            set { LblTxtBox6.MaxByteLength = value; }
        }
        #endregion

        #region LabelTextBox7コントロール
        public TextBox ValueTextBox7
        {
            get { return LblTxtBox7.ValueTextBox; }
        }
        public string LblTxtBox7TitleControlName
        {
            get { return LblTxtBox7.TitleControlName; }
            set { LblTxtBox7.TitleControlName = value; }
        }
        public string LblTxtBox7Title
        {
            get { return LblTxtBox7.Title; }
            set { LblTxtBox7.Title = value; }
        }
        public string LblTxtBox7DataControlName
        {
            get { return LblTxtBox7.DataControlName; }
            set { LblTxtBox7.DataControlName = value; }
        }
        public string LblTxtBox7Value
        {
            get { return LblTxtBox7.Value; }
            set { LblTxtBox7.Value = value; }
        }
        public HorizontalAlignment LblTxtBox7TextAlign
        {
            get { return LblTxtBox7.TextAlign; }
            set { LblTxtBox7.TextAlign = value; }
        }

        public string LblTxtBox7DBColumnName
        {
            get { return LblTxtBox7.DatabaseColumnName; }
            set { LblTxtBox7.DatabaseColumnName = value; }
        }

        public int LblTxtBox7MaxByteLength
        {
            get { return LblTxtBox7.MaxByteLength; }
            set { LblTxtBox7.MaxByteLength = value; }
        }
        #endregion

        #region LabelTextBox8コントロール
        public TextBox ValueTextBox8
        {
            get { return LblTxtBox8.ValueTextBox; }
        }
        public string LblTxtBox8TitleControlName
        {
            get { return LblTxtBox8.TitleControlName; }
            set { LblTxtBox8.TitleControlName = value; }
        }
        public string LblTxtBox8Title
        {
            get { return LblTxtBox8.Title; }
            set { LblTxtBox8.Title = value; }
        }
        public string LblTxtBox8DataControlName
        {
            get { return LblTxtBox8.DataControlName; }
            set { LblTxtBox8.DataControlName = value; }
        }
        public string LblTxtBox8Value
        {
            get { return LblTxtBox8.Value; }
            set { LblTxtBox8.Value = value; }
        }
        public HorizontalAlignment LblTxtBox8TextAlign
        {
            get { return LblTxtBox8.TextAlign; }
            set { LblTxtBox8.TextAlign = value; }
        }

        public string LblTxtBox8DBColumnName
        {
            get { return LblTxtBox8.DatabaseColumnName; }
            set { LblTxtBox8.DatabaseColumnName = value; }
        }

        public int LblTxtBox8MaxByteLength
        {
            get { return LblTxtBox8.MaxByteLength; }
            set { LblTxtBox8.MaxByteLength = value; }
        }
        #endregion

        #region LabelTextBox9コントロール
        public TextBox ValueTextBox9
        {
            get { return LblTxtBox9.ValueTextBox; }
        }
        public string LblTxtBox9TitleControlName
        {
            get { return LblTxtBox9.TitleControlName; }
            set { LblTxtBox9.TitleControlName = value; }
        }
        public string LblTxtBox9Title
        {
            get { return LblTxtBox9.Title; }
            set { LblTxtBox9.Title = value; }
        }
        public string LblTxtBox9DataControlName
        {
            get { return LblTxtBox9.DataControlName; }
            set { LblTxtBox9.DataControlName = value; }
        }
        public string LblTxtBox9Value
        {
            get { return LblTxtBox9.Value; }
            set { LblTxtBox9.Value = value; }
        }
        public HorizontalAlignment LblTxtBox9TextAlign
        {
            get { return LblTxtBox9.TextAlign; }
            set { LblTxtBox9.TextAlign = value; }
        }

        public string LblTxtBox9DBColumnName
        {
            get { return LblTxtBox9.DatabaseColumnName; }
            set { LblTxtBox9.DatabaseColumnName = value; }
        }

        public int LblTxtBox9MaxByteLength
        {
            get { return LblTxtBox9.MaxByteLength; }
            set { LblTxtBox9.MaxByteLength = value; }
        }
        #endregion

        #region LabelTextBox10コントロール
        public TextBox ValueTextBox10
        {
            get { return LblTxtBox10.ValueTextBox; }
        }
        public string LblTxtBox10TitleControlName
        {
            get { return LblTxtBox10.TitleControlName; }
            set { LblTxtBox10.TitleControlName = value; }
        }
        public string LblTxtBox10Title
        {
            get { return LblTxtBox10.Title; }
            set { LblTxtBox10.Title = value; }
        }
        public string LblTxtBox10DataControlName
        {
            get { return LblTxtBox10.DataControlName; }
            set { LblTxtBox10.DataControlName = value; }
        }
        public string LblTxtBox10Value
        {
            get { return LblTxtBox10.Value; }
            set { LblTxtBox10.Value = value; }
        }
        public HorizontalAlignment LblTxtBox10TextAlign
        {
            get { return LblTxtBox10.TextAlign; }
            set { LblTxtBox10.TextAlign = value; }
        }

        public string LblTxtBox10DBColumnName
        {
            get { return LblTxtBox10.DatabaseColumnName; }
            set { LblTxtBox10.DatabaseColumnName = value; }
        }

        public int LblTxtBox10MaxByteLength
        {
            get { return LblTxtBox10.MaxByteLength; }
            set { LblTxtBox10.MaxByteLength = value; }
        }
        #endregion

        #region LabelTextBox11コントロール
        public TextBox ValueTextBox11
        {
            get { return LblTxtBox11.ValueTextBox; }
        }
        public string LblTxtBox11TitleControlName
        {
            get { return LblTxtBox11.TitleControlName; }
            set { LblTxtBox11.TitleControlName = value; }
        }
        public string LblTxtBox11Title
        {
            get { return LblTxtBox11.Title; }
            set { LblTxtBox11.Title = value; }
        }
        public string LblTxtBox11DataControlName
        {
            get { return LblTxtBox11.DataControlName; }
            set { LblTxtBox11.DataControlName = value; }
        }
        public string LblTxtBox11Value
        {
            get { return LblTxtBox11.Value; }
            set { LblTxtBox11.Value = value; }
        }
        public HorizontalAlignment LblTxtBox11TextAlign
        {
            get { return LblTxtBox11.TextAlign; }
            set { LblTxtBox11.TextAlign = value; }
        }

        public string LblTxtBox11DBColumnName
        {
            get { return LblTxtBox11.DatabaseColumnName; }
            set { LblTxtBox11.DatabaseColumnName = value; }
        }

        public int LblTxtBox11MaxByteLength
        {
            get { return LblTxtBox11.MaxByteLength; }
            set { LblTxtBox11.MaxByteLength = value; }
        }
        #endregion

        #region LabelTextBox12コントロール
        public TextBox ValueTextBox12
        {
            get { return LblTxtBox12.ValueTextBox; }
        }
        public string LblTxtBox12TitleControlName
        {
            get { return LblTxtBox12.TitleControlName; }
            set { LblTxtBox12.TitleControlName = value; }
        }
        public string LblTxtBox12Title
        {
            get { return LblTxtBox12.Title; }
            set { LblTxtBox12.Title = value; }
        }
        public string LblTxtBox12DataControlName
        {
            get { return LblTxtBox12.DataControlName; }
            set { LblTxtBox12.DataControlName = value; }
        }
        public string LblTxtBox12Value
        {
            get { return LblTxtBox12.Value; }
            set { LblTxtBox12.Value = value; }
        }
        public HorizontalAlignment LblTxtBox12TextAlign
        {
            get { return LblTxtBox12.TextAlign; }
            set { LblTxtBox12.TextAlign = value; }
        }       
        public string LblTxtBox12DBColumnName
        {
            get { return LblTxtBox12.DatabaseColumnName; }
            set { LblTxtBox12.DatabaseColumnName = value; }
        }
        public int LblTxtBox12MaxByteLength
        {
            get { return LblTxtBox12.MaxByteLength; }
            set { LblTxtBox12.MaxByteLength = value; }
        }
        #endregion

        #region LabelNumericUpDownコントロール
        public NumericUpDown LblNud1ValueNumericUpDown
        {
            get { return LblNud1.NumUpDownData; }
        }
        public string Nud1TitleControlName
        {
            get { return LblNud1.LblTitle.Name; }
            set { LblNud1.Name = value; }
        }

        public string LblNud1Title1
        {
            get { return LblNud1.LblTitle.Text; }
            set { LblNud1.LblTitle.Text = value; }
        }

        public Size LblNud1TitleSize
        {
            get { return LblNud1.LblTitle.Size; }
            set { LblNud1.LblTitle.Size = value; }
        }

        public decimal LblNud1Value
        {
            get { return LblNud1.NumUpDownData.Value; }
            set { LblNud1.NumUpDownData.Value = value; }
        }

        public decimal LblNud1Minimum
        {
            get { return LblNud1.NumUpDownData.Minimum; }
            set { LblNud1.NumUpDownData.Minimum = value; }
        }

        public decimal LblNud1Maximum
        {
            get { return LblNud1.NumUpDownData.Maximum; }
            set { LblNud1.NumUpDownData.Maximum = value; }
        }

        public int LblNud1DecimalPlaces
        {
            get { return LblNud1.NumUpDownData.DecimalPlaces; }
            set { LblNud1.NumUpDownData.DecimalPlaces = value; }
        }

        public HorizontalAlignment LblNud1TextAlign
        {
            get { return LblNud1.NumUpDownData.TextAlign; }
            set { LblNud1.NumUpDownData.TextAlign = value; }
        }

        public string LblNud1DBColumnName
        {
            get { return LblNud1.DatabaseColumnName; }
            set { LblNud1.DatabaseColumnName = value; }
        }
        #endregion

        #region LabelCheckBoxSingleコントロール
        public CheckBox CheckState
        {
            get { return LblChk.CheckState; }
        }
        public string LblChkTitleControlName
        {
            get { return LblChk.TitleControlName; }
            set { LblChk.TitleControlName = value; }
        }
        public string LblChkTitle
        {
            get { return LblChk.Title; }
            set { LblChk.Title = value; }
        }

        public string LblChkDBColumnName
        {
            get { return LblChk.DatabaseColumnName; }
            set { LblChk.DatabaseColumnName = value; }
        }
        #endregion
        public TabCtrlPagePlantsSetting()
        {
            InitializeComponent();
        }
    }
}
