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
    /// 注文開始ダイアログ
    /// </summary>
    public partial class FrmKeyPad : BaseForm
    {
        #region コンストラクタ
        public FrmKeyPad()
        {
            InitializeComponent();
            InitializeForm();
        }
        #endregion

        #region イベント
        private void BtnInput0Click(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
            }
            catch(Exception ex)
            {
                PutLog(ex);
            }
        }
        private void BtnInput1Click(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
            }
            catch(Exception ex)
            {
                PutLog(ex);
            }
        }
        private void BtnInput2Click(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
            }
            catch(Exception ex)
            {
                PutLog(ex);
            }
        }
        private void BtnInput3Click(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
            }
            catch(Exception ex)
            {
                PutLog(ex);
            }
        }
        private void BtnInput4Click(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
            }
            catch(Exception ex)
            {
                PutLog(ex);
            }
        }
        private void BtnInput5Click(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
            }
            catch(Exception ex)
            {
                PutLog(ex);
            }
        }
        private void BtnInput6Click(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
            }
            catch(Exception ex)
            {
                PutLog(ex);
            }
        }
        private void BtnInput7Click(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
            }
            catch(Exception ex)
            {
                PutLog(ex);
            }
        }
        private void BtnInput8Click(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }
        private void BtnInput9Click(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
            }
            catch(Exception ex)
            {
                PutLog(ex);
            }
        }
        private void BtnPeriodClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
            }
            catch(Exception ex)
            {
                PutLog(ex);
            }
        }
        private void BtnInputPlusMinusClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
            }
            catch(Exception ex)
            {
                PutLog(ex);
            }
        }
        private void BtnCAClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
            }
            catch(Exception ex)
            {
                PutLog(ex);
            }
        }
        private void BtnCClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
            }
            catch(Exception ex)
            {
                PutLog(ex);
            }
        }
        private void BtnOKClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                MessageBox.Show("入力を決定しました。");
                this.Close();
            }
            catch(Exception ex)
            {
                PutLog(ex);
            }
        }
        public void BtnCancelClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                this.Close();
            }
            catch(Exception ex)
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
            this.BtnInput0.Click += new EventHandler(this.BtnInput0Click);
            this.BtnInput1.Click += new EventHandler(this.BtnInput1Click);
            this.BtnInput2.Click += new EventHandler(this.BtnInput2Click);
            this.BtnInput3.Click += new EventHandler(this.BtnInput3Click);
            this.BtnInput4.Click += new EventHandler(this.BtnInput4Click);
            this.BtnInput5.Click += new EventHandler(this.BtnInput5Click);
            this.BtnInput6.Click += new EventHandler(this.BtnInput6Click);
            this.BtnInput7.Click += new EventHandler(this.BtnInput7Click);
            this.BtnInput8.Click += new EventHandler(this.BtnInput8Click);
            this.BtnInput9.Click += new EventHandler(this.BtnInput9Click);
            this.BtnInputPeriod.Click += new EventHandler(this.BtnPeriodClick);
            this.BtnInputPlusMinus.Click += new EventHandler(this.BtnInputPlusMinusClick);
            this.BtnCA.Click += new EventHandler(this.BtnCAClick);
            this.BtnC.Click += new EventHandler(this.BtnCClick);
            this.BtnOK.Click += new EventHandler(this.BtnOKClick);
            this.BtnCancel.Click += new EventHandler(this.BtnCancelClick);
        }
        #endregion
    }
}

