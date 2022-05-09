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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using NipponPaint.NpCommon.FormControls;
using System.Drawing;
#endregion

namespace NipponPaint.NpCommon
{
    public class Funcs
    {
        private static readonly Color BACK_COLOR = Color.Black;
        private static readonly Color FORE_COLOR = Color.White;

        #region 取得値設定先のコントロールを抽出する
        /// <summary>
        /// 取得値設定先のコントロールを抽出する
        /// </summary>
        /// <param name="controls"></param>
        /// <param name="result"></param>
        public static void FindControls(Control.ControlCollection controls, List<Control> result)
        {
            foreach (Control control in controls)
            {
                switch (control)
                {
                    case LabelTextBox labelTextBox:
                        result.Add(labelTextBox);
                        break;
                    case LabelTextBoxDb labelTextBoxDb:
                        result.Add(labelTextBoxDb);
                        break;
                    case LabelNumericUpDown labelNumericUpDown:
                        result.Add(labelNumericUpDown);
                        break;
                    case LabelCheckBoxSingle labelCheckBoxSingle:
                        result.Add(labelCheckBoxSingle);
                        break;
                    case LabelNumericUpDownMulti labelNumericUpDownMulti:
                        result.Add(labelNumericUpDownMulti);
                        break;
                    case TextBox textBox:
                        result.Add(textBox);
                        break;
                    case TabPage tabPage:
                        result.Add(tabPage);
                        if (control.Controls.Count > 0)
                        {
                            FindControls(control.Controls, result);
                        }
                        break;
                    case LabelColorDiaLog labelColorDiaLog:
                        result.Add(labelColorDiaLog);
                        break;
                    case LabelCodeText labelCodeText:
                        result.Add(labelCodeText);
                        break;
                    case DeliveryClassification deliveryClassfication:
                        result.Add(deliveryClassfication);
                        break;
                    case TabCtrlPagePlants tabCtrlPagePlants:
                        result.Add(tabCtrlPagePlants);
                        break;
                    case TabCtrlPagePlantsSetting tabCtrlPagePlantsSetting:
                        result.Add(tabCtrlPagePlantsSetting);
                        break;
                    case LabelDateTimePicker labelDateTimePicker:
                        result.Add(labelDateTimePicker);
                        break;
                    case NumericUpDown numericUpDown:
                        result.Add(numericUpDown);
                        break;
                    case DateTimePicker dateTimePicker:
                        result.Add(dateTimePicker);
                        break;
                    case LabelDropDown labelDropDown:
                        result.Add(labelDropDown);
                        break;
                    case LabelTextButton labelTextButton:
                        result.Add(labelTextButton);
                        break;
                    default:
                        if (control.Controls.Count > 0)
                        {
                            FindControls(control.Controls, result);
                        }
                        break;
                }
            }
        }
        #endregion

        #region データ表示部の設定
        /// <summary>
        /// データ表示部の設定
        /// </summary>
        /// <param name="formControls"></param>
        /// <param name="readOnly"></param>
        public static void SetControlEnabled(Control.ControlCollection formControls, bool readOnly)
        {
            // iniファイルを取得する
            var settings = new IniFile.Settings();
            // フォームで定義された、取得値設定先のコントロールを抽出する
            var controls = new List<Control>();
            FindControls(formControls, controls);
            foreach (var control in controls)
            {
                switch (control)
                {
                    case LabelTextBox labelTextBox:
                        // LabelTextBoxコントロールへの設定
                        if (!string.IsNullOrEmpty(labelTextBox.DatabaseColumnName))
                        {
                            labelTextBox.DataReadOnly = readOnly;
                        }
                        
                        switch (labelTextBox.TextBackColor.Name)
                        {
                            case "Window":
                                labelTextBox.TextBackColor = BACK_COLOR;
                                labelTextBox.TextForeColor = FORE_COLOR;
                                break;
                        }
                        break;
                    case LabelCodeText labelCodeText:
                        // LabelCodeTextコントロールへの設定
                        if (!string.IsNullOrEmpty(labelCodeText.DatabaseColumnName))
                        {
                            labelCodeText.DataReadOnly = readOnly;
                        }
                        if (!string.IsNullOrEmpty(labelCodeText.DatabaseColumnCode))
                        {
                            labelCodeText.CodeReadOnly = readOnly;
                        }

                        switch (labelCodeText.TextBackColor.Name)
                        {
                            case "Window":
                                labelCodeText.TextBackColor = BACK_COLOR;
                                labelCodeText.TextForeColor = FORE_COLOR;
                                break;
                        }
                        break;
                    case LabelNumericUpDown labelNumericUpDown:
                        // LabelNumericUpDownコントロールへの設定
                        switch (labelNumericUpDown.TextBackColor.Name)
                        {
                            case "Window":
                                labelNumericUpDown.TextBackColor = BACK_COLOR;
                                labelNumericUpDown.TextForeColor = FORE_COLOR;
                                break;
                        }
                        break;
                    case LabelDropDown labelDropDown:
                        // LabelDropDownコントロールへの設定
                        switch (labelDropDown.TextBackColor.Name)
                        {
                            case "Window":
                                labelDropDown.TextBackColor = BACK_COLOR;
                                labelDropDown.TextForeColor = FORE_COLOR;
                                break;
                        }
                        break;
                    case TabPage tabPage:
                        switch (tabPage.BackColor.Name)
                        {
                            case "Control":
                                tabPage.BackColor = BACK_COLOR;
                                break;
                        }
                        break;
                    case DateTimePicker dateTimePicker:
                        //LabelDateTimePickerコントロールへの設定
                        switch (dateTimePicker.CalendarMonthBackground.Name)
                        {
                            case "Window":
                                dateTimePicker.CalendarMonthBackground = BACK_COLOR;
                                dateTimePicker.CalendarForeColor = FORE_COLOR;
                                break;
                        }
                        break;
                    //case ComboBoxEx comboBoxEx:
                    //    switch (comboBoxEx.BackColor.Name)
                    //    {
                    //        case "Window":
                    //            comboBoxEx.BackColor = BACK_COLOR;
                    //            comboBoxEx.ForeColor = FORE_COLOR;
                    //            break;
                    //    }
                    //    break;
                    case DataGridView dg:
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        #region 10数からRGB / RGBから10数
        /// <summary>
        /// RGBから10進数
        /// </summary>
        /// <param name="colorDialog"></param>
        /// <returns></returns>
        public static int RgbToInt(ColorDialog colorDialog)
        {
            //取得した色のRGBそれぞれをbyte配列から16進数へ変換　         
            var data = new byte[] { colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B };
            var val = BitConverter.ToString(data).Replace("-", string.Empty);
            //16進数から10進数へ変換
            int rgbToInt = Convert.ToInt32(val, 16);

            return rgbToInt;
        }

        /// <summary>
        /// 10数からRGBA
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Color RgbFromInt(object obj)
        {
            //DBのRGBの値(10進数)を16進数
            int intObj = int.Parse(obj.ToString());
            string rgbFromInt = "#" + intObj.ToString("X6");
            //16進数からRGBAへ変換
            Color rgb = ColorTranslator.FromHtml(rgbFromInt);

            return rgb;
        }
        #endregion

        #region データベースへの登録値に変換する
        /// <summary>
        /// データベースへの登録値に変換する
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetDatabaseValue(object value)
        {
            switch (value)
            {
                case DateTime dt:
                    return $"'{string.Format("yyyy/MM/dd HH:mm:ss.fff")}'";
                case int i:
                    return $"{i}";
                case float f:
                    return $"{f}";
                case string s:
                    return $"'{value}'";
                default:
                    return $"'{value}'";
            }
        }
        #endregion

    }
}
