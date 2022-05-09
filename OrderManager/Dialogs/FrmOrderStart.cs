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
    public partial class FrmOrderStart : BaseForm
    {
        #region コンストラクタ
        public FrmOrderStart(ViewModels.OrderStartData vm)
        {
            InitializeComponent();
            InitializeForm();
            TxtOrderNumber.Value = vm.OrderNumber;
            TxtColorName.Value = vm.ColorName;
            TxtProductCode.Value = vm.ProductCode;
            TxtNumberOfCan.Value = vm.NumberOfCan.ToString();
            TxtPaintName.Value = vm.ItemName;
            TxtFormalPaintName.Value = vm.FormalItemName;
            TxtWhiteCode.Value = vm.WhiteCode;
            TxtRevision.Value = vm.Revision.ToString();
            TxtTotalWeight.Value = vm.TotalWeight.ToString();
            NumUpDownOverfilling.Value = (decimal)vm.Overfilling;
            NumUpDownFilledWeight.Value = vm.FilledWeight;
            NumUpDownWeightTolerance.LeftSide.Value = (decimal)vm.WeightToleranceMin;
            NumUpDownWeightTolerance.RightSide.Value = (decimal)vm.WeightToleranceMax;
            NumUpDownQualitySample.Value = vm.QualitySample;
            NumUpDownMixingTime.Value = vm.MixingTime;
            NumUpDownMixingSpeed.Value = vm.MixingSpeed;
        }
        #endregion

        #region イベント
        private void BtnOrderStartClick(object sender, EventArgs e)
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
        private void BtnOrderBackClick(object sender, EventArgs e)
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
            this.BtnOrderStart.Click += new EventHandler(this.BtnOrderStartClick);
            this.BtnOrderBack.Click += new EventHandler(this.BtnOrderBackClick);
            this.BtnClose.Click += new EventHandler(this.BtnCloseClick);
        }
        #endregion
    }
}
