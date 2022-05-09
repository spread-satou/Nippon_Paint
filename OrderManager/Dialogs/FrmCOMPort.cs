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
using System.Collections.Generic;
using NipponPaint.NpCommon;
using NipponPaint.NpCommon.Database;
using NipponPaint.NpCommon.FormControls;
using NipponPaint.NpCommon.Settings;
using Sql = NipponPaint.NpCommon.Database.Sql;
#endregion

namespace NipponPaint.OrderManager.Dialogs
{
    /// <summary>
    /// COMポートダイアログ
    /// </summary>
    public partial class FrmCOMPort : BaseForm
    {
        #region コンストラクタ
        public FrmCOMPort()
        {
            InitializeComponent();
            InitializeForm();
        }
        #endregion

        /// <summary>
        /// ボタン押下時のショートカット動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.F5:
                        // CCMシステム
                        BtnCCMSystem.PerformClick();
                        break;
                    case Keys.F6:
                        // 荷札ラベル
                        BtnNifudaLabel.PerformClick();
                        break;
                    case Keys.F7:
                        // 色名ラベル
                        BtnColorNameLabel.PerformClick();
                        break;
                }
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }
        /// <summary>
        /// CCMシステムボタン(F5)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region イベント
        private void BtnCCMSystemClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                FrmSetUp frmSetUp = new FrmSetUp();
                frmSetUp.ShowDialog();
            }
            catch(Exception ex)
            {
                PutLog(ex);
            }
        }
        /// <summary>
        /// 荷札ラベルボタン(F6)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNifudaLabelClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                FrmSetUp frmSetUp = new FrmSetUp();
                frmSetUp.ShowDialog();
            }
            catch(Exception ex)
            {
                PutLog(ex);
            }
        }
        /// <summary>
        /// 色名ラベルボタン(F7)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnColorNameLabelClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                FrmSetUp frmSetUp = new FrmSetUp();
                frmSetUp.ShowDialog();
            }
            catch(Exception ex)
            {
                PutLog(ex);
            }
        }
        /// <summary>
        /// 閉じるボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BtnCloseClick(object sender, EventArgs e)
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
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(this.FormKeyDown);
            this.BtnCCMSystem.Click += new EventHandler(this.BtnCCMSystemClick);
            this.BtnNifudaLabel.Click += new EventHandler(this.BtnNifudaLabelClick);
            this.BtnColorNameLabel.Click += new EventHandler(this.BtnColorNameLabelClick);
            this.BtnClose.Click += new EventHandler(this.BtnCloseClick);
        }
        #endregion
    }
}
