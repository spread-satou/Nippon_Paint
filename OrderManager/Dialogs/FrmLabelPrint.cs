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
using System.Drawing;
using System.Windows.Forms;
using NipponPaint.NpCommon;
#endregion

namespace NipponPaint.OrderManager.Dialogs
{
    /// <summary>
    /// ラベル印刷ダイアログ
    /// </summary>
    public partial class FrmLabelPrint : BaseForm
    {
        #region コンストラクタ
        public FrmLabelPrint(ViewModels.LabelPrintData vm)
        {
            InitializeComponent();
            InitializeForm();
            NumUpDownNumberOfPrint.Value = vm.PrintNumber;
            TxtKanjiHeight.Value = vm.KanjiHeight.ToString();
            TxtKanjiWidth.Text = vm.KanjiWidth.ToString();
            TxtNormalHeight.Value = vm.NormalHeight.ToString();
            TxtNormalWidth.Text = vm.NormalWidth.ToString();
        }
        #endregion

        #region イベント

        private void FrmLabelPrintLoad(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((FrmLabelPrint)sender).Text);
                this.GrpBoxNumberOfCan.Visible = false;
                this.Height = 420;
            }
            catch(Exception ex)
            {
                PutLog(ex);
            }
        }
        private void RBtnProductLabelPrintCheckedChanged(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((RadioButton)sender).Text);
                if (RBtnProductLabelPrint.Checked == true)
                {
                    this.GrpBoxNumberOfPrint.Visible = true;
                    this.GrpBoxNumberOfCan.Visible = false;
                }
            }
            catch(Exception ex)
            {
                PutLog(ex);
            }
        }
        private void RBtnColorNameLabelPrintCheckedChanged(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((RadioButton)sender).Text);
                if (RBtnColorNameLabelPrint.Checked == true)
                {
                    this.GrpBoxNumberOfPrint.Visible = true;
                    this.GrpBoxNumberOfCan.Visible = false;
                }
            }
            catch(Exception ex)
            {
                PutLog(ex);
            }
        }
        private void RBtnReserveLabelPrintCheckedChanged(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((RadioButton)sender).Text);
                if (RBtnReserveLabelPrint.Checked == true)
                {
                    this.GrpBoxNumberOfPrint.Visible = true;
                    this.GrpBoxNumberOfCan.Visible = false;
                }
            }
            catch(Exception ex)
            {
                PutLog(ex);
            }
        }
        private void RBtnNifudaLabelPrintCheckedChanged(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((RadioButton)sender).Text);
                if (RBtnNifudaLabelPrint.Checked == true)
                {
                    this.GrpBoxNumberOfPrint.Visible = false;
                    this.GrpBoxNumberOfCan.Visible = true;
                    this.GrpBoxNumberOfCan.Location = new Point(470, 12);
                }
            }
            catch(Exception ex)
            {
                PutLog(ex);
            }
        }
        private void BtnPrintClick(object sender, EventArgs e)
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
        private void BtnCloseClick(object sender, EventArgs e)
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
            this.Load += new System.EventHandler(this.FrmLabelPrintLoad);
            this.RBtnProductLabelPrint.CheckedChanged += new EventHandler(this.RBtnProductLabelPrintCheckedChanged);
            this.RBtnColorNameLabelPrint.CheckedChanged += new EventHandler(this.RBtnColorNameLabelPrintCheckedChanged);
            this.RBtnReserveLabelPrint.CheckedChanged += new EventHandler(this.RBtnReserveLabelPrintCheckedChanged);
            this.RBtnNifudaLabelPrint.CheckedChanged += new EventHandler(this.RBtnNifudaLabelPrintCheckedChanged);
            this.BtnPrint.Click += new EventHandler(this.BtnPrintClick);
            this.BtnClose.Click += new EventHandler(this.BtnCloseClick);
        }
        #endregion

    }
}
