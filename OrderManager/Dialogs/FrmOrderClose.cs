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
    public partial class FrmOrderClose : BaseForm
    {
        #region コンストラクタ
        public FrmOrderClose()
        {
            InitializeComponent();
            InitializeForm();
        }
        #endregion

        #region イベント
        FrmOrderCloseSelectItems frmOrderCloseSelectItems = new FrmOrderCloseSelectItems();
        private void BtnOrderCloseCCMClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                frmOrderCloseSelectItems.ShowDialog();
            }
            catch(Exception ex)
            {
                PutLog(ex);
            }
        }
        public void BtnOrderCloseTestCanClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                frmOrderCloseSelectItems.ShowDialog();
            }
            catch(Exception ex)
            {
                PutLog(ex);
            }
        }
        public void BtnOrderCloseManufacturingCanClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                frmOrderCloseSelectItems.ShowDialog();
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
            this.BtnOrderCloseCCM.Click += new EventHandler(this.BtnOrderCloseCCMClick);
            this.BtnOrderCloseTestCan.Click += new EventHandler(this.BtnOrderCloseTestCanClick);
            this.BtnOrderCloseManufacturingCan.Click += new EventHandler(this.BtnOrderCloseManufacturingCanClick);
        }
        #endregion
    }
}

