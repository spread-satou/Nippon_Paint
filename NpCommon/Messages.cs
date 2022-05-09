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
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
#endregion

namespace NipponPaint.NpCommon
{
    public static class Messages
    {
        public static DialogResult ShowDialog(Sentence.Messages messageId, object[] addtionalInfo = null)
        {
            var text = GetText(messageId, addtionalInfo);
            var info = GetInfo(messageId);
            var caption = "メッセージ";
            var buttons = MessageBoxButtons.OK;
            switch ((Log.LogType)info.Order)
            {
                case Log.LogType.Info:
                    caption = "情報";
                    break;
                case Log.LogType.Warn:
                    caption = "警告";
                    break;
                case Log.LogType.Error:
                    caption = "エラー";
                    break;
                case Log.LogType.Critical:
                    caption = "緊急";
                    break;
                case Log.LogType.Question:
                    caption = "質問";
                    buttons = MessageBoxButtons.YesNo;
                    break;
                case Log.LogType.Debug:
                    break;
            }
            return MessageBox.Show(text, caption, buttons);
        }

        public static DialogResult ShowDialog(Sentence.Messages messageId, string addtionalInfo)
        {
            if (string.IsNullOrEmpty(addtionalInfo))
            {
                return ShowDialog(messageId);
            }
            else
            {
                return ShowDialog(messageId, new string[] { addtionalInfo });
            }
        }

        public static DisplayAttribute GetInfo(Sentence.Messages messageId)
        {
            return messageId.GetApplied<DisplayAttribute>().First();
        }

        public static string GetText(Sentence.Messages messageId, object[] addtionalInfo = null)
        {
            if (addtionalInfo == null || !addtionalInfo.Any())
            {
                return GetInfo(messageId).Description;
            }
            else
            {
                return string.Format(GetInfo(messageId).Description, addtionalInfo);
            }
        }

        /// <summary>
        /// ログ種別文言の取得
        /// </summary>
        /// <param name="logType"></param>
        /// <returns></returns>
        public static string GetLogTypeText(Log.LogType logType)
        {
            return logType.GetApplied<DisplayAttribute>().First().Description;
        }
        /// <summary>
        /// アプリケーション種別文言の取得
        /// </summary>
        /// <param name="applicationType"></param>
        /// <returns></returns>
        public static string GetApplicationTypeText(Log.ApplicationType applicationType)
        {
            return applicationType.GetApplied<DisplayAttribute>().First().Description;
        }

    }
}
