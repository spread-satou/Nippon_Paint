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
using System.Windows.Forms;
using NipponPaint.NpCommon;
#endregion

namespace NipponPaint.OrderManager.Dialogs
{
    /// <summary>
    /// SetUpダイアログ
    /// </summary>
    public partial class FrmSetUp : BaseForm
    {
        #region コンストラクタ
        public FrmSetUp()
        {
            InitializeComponent();
            InitializeForm();
        }
        #endregion
        /// <summary>
        /// OKボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region イベント
        private void BtnOKClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                Messages.ShowDialog(Sentence.Messages.SaveComplate);
                this.Close();
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }
        /// <summary>
        /// Cancelボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BtnCancelClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                this.Close();
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }
        #endregion

        #region private functions

        /// <summary>
        /// 画面の初期化
        /// </summary>
        private void InitializeForm()
        {
            // イベントの追加
            this.BtnOK.Click += new EventHandler(this.BtnOKClick);
            this.BtnCancel.Click += new EventHandler(this.BtnCancelClick);
            Funcs.SetControlEnabled(this.Controls, true);
            //データ表示部の設定
            /// <summary>
            /// BaudRateのドロップダウン
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            DrpBaudRate.DropDown.Items.AddRange(new object[] {
                "Custom",
                "110",
                "300",
                "600",
                "1200",
                "2400",
                "4800",
                "9600",
                "14400",
                "19200",
                "38400",
                "56000",
                "57600",
                "115200",
                "128000"
            });
            DrpBaudRate.DropDown.SelectedIndex = 7;
            /// <summary>
            /// DataBitsのドロップダウン
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            DrpDataBits.DropDown.Items.AddRange(new object[] {
                "5",
                "6",
                "7",
                "8"
            });
            DrpDataBits.DropDown.SelectedIndex = 3;
            /// <summary>
            /// StopBitsのドロップダウン
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            DrpStopBits.DropDown.Items.AddRange(new object[] {
                "1",
                "1.5",
                "2"
            });
            DrpStopBits.DropDown.SelectedIndex = 0;
            /// <summary>
            /// Parityのドロップダウン
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            DrpParity.DropDown.Items.AddRange(new object[] {
                "None",
                "Odd",
                "Even",
                "Mark",
                "Space"
            });
            DrpParity.DropDown.SelectedIndex = 0;
            /// <summary>
            /// FlowControlのドロップダウン
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            DrpFlowControl.DropDown.Items.AddRange(new object[] {
                "Hardware",
                "Software",
                "None",
                "Custom"
            });
            DrpFlowControl.DropDown.SelectedIndex = 2;
        }
        #endregion
    }
}