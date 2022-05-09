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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NipponPaint.NpCommon;
#endregion

namespace DatabaseManager
{
    /// <summary>
    /// フォーム基底クラス
    /// </summary>
    public class BaseForm : Form
    {
        /// <summary>
        /// ログ出力
        /// </summary>
        /// <param name="MessageId"></param>
        public void PutLog(Sentence.Messages MessageId, object[] addtionalInfo = null, bool displayDialog = false)
        {
            Log.Write(MessageId, Log.ApplicationType.Databasemanager, addtionalInfo);
            if (displayDialog)
            {
                Messages.ShowDialog(MessageId, addtionalInfo);
            }
        }
        /// <summary>
        /// ログ出力
        /// </summary>
        /// <param name="MessageId"></param>
        public void PutLog(Sentence.Messages MessageId, string addtionalInfo, bool displayDialog = false)
        {
            Log.Write(MessageId, Log.ApplicationType.Databasemanager, addtionalInfo);
            if (displayDialog)
            {
                Messages.ShowDialog(MessageId, addtionalInfo);
            }
        }
        /// <summary>
        /// ログ出力
        /// </summary>
        /// <param name="MessageId"></param>
        public void PutLog(Exception ex, bool displayDialog = false)
        {
            Log.Write(Sentence.Messages.Exception, Log.ApplicationType.OrderManager, ex.Message);
            if (displayDialog)
            {
                Messages.ShowDialog(Sentence.Messages.Exception, ex.Message);
            }
        }
        #region DataGridViewの初期設定
        /// <summary>
        /// DataGridViewの初期設定
        /// </summary>
        /// <param name="target"></param>
        public void InitializeGridView(DataGridView target)
        {
            target.Columns.Clear();
            target.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            target.RowHeadersVisible = false;
            target.MultiSelect = false;
            target.AllowUserToAddRows = false;
            target.AllowUserToDeleteRows = false;
            target.AllowUserToResizeRows = false;
            target.ReadOnly = true;
        }
        #endregion
    }
}
