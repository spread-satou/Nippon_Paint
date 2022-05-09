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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NipponPaint.NpCommon;
using NipponPaint.NpCommon.Database;
using Sql = NipponPaint.NpCommon.Database.Sql;
#endregion

namespace NipponPaint.OrderManager.Dialogs
{
    public partial class FrmSelectDataNumber : BaseForm
    {
        ViewModels.SelectDataNumber _vm;
        public FrmSelectDataNumber(ViewModels.SelectDataNumber vm)
        {
            InitializeComponent();
            InitializeForm();
            _vm = vm;
            TxtDataNumber.Value = _vm.DataNumber.ToString();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
        }

        #region イベント
        private void BtnOKClick(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(TxtDataNumber.Value, out int dataNumber);
                using (var db = new SqlBase(SqlBase.DatabaseKind.NPMAIN, SqlBase.TransactionUse.No, Log.ApplicationType.OrderManager))
                {
                    var parameters = new List<ParameterItem>()
                    {
                        new ParameterItem("@dataNumber", dataNumber),
                    };
                    var rec = db.Select(Sql.NpMain.Orders.GetDetailByDataNumber(), parameters);
                    if (rec.Rows.Count > 0)
                    {
                        _vm.DataNumber = dataNumber;
                        _vm.SelectedProductCode = rec.Rows[0]["Product_Code"].ToString();
                        PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        Messages.ShowDialog(Sentence.Messages.NotExistsDataNumber, dataNumber.ToString());
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                PutLog(ex);
            }
        }
        public void BtnCancelClick(object sender, EventArgs e)
        {
            try
            {
                PutLog(Sentence.Messages.ButtonClicked, ((Button)sender).Text);
                this.DialogResult = DialogResult.Cancel;
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
        }
        #endregion

    }
}
