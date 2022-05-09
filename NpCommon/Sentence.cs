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
using System.ComponentModel.DataAnnotations;
#endregion

namespace NipponPaint.NpCommon
{
    public class Sentence
    {
        public enum Messages
        {
            /// <summary>
            /// 例外
            /// </summary>
            [Display(Order = (int)Log.LogType.Critical, Description = "例外が発生しました（内容：{0}）")]
            Exception,

            /// <summary>
            /// ダイアログを開きました
            /// </summary>
            [Display(Order = (int)Log.LogType.Info, Description = "ダイアログを開きました")]
            OpenDialog,

            /// <summary>
            /// 主画面の初期化を完了しました
            /// </summary>
            [Display(Order = (int)Log.LogType.Info, Description = "主画面の初期化を完了しました")]
            InitializedMainForm,

            /// <summary>
            /// 一覧を更新しました
            /// </summary>
            [Display(Order = (int)Log.LogType.Info, Description = "一覧を更新しました")]
            PreviewData,

            /// <summary>
            /// 主画面を開きました
            /// </summary>
            [Display(Order = (int)Log.LogType.Info, Description = "主画面を開きました")]
            OpenMainForm,

            /// <summary>
            /// データベースの読み込みを実行しました
            /// </summary>
            [Display(Order = (int)Log.LogType.Info, Description = "データベースの読み込みを実行しました（SQL：{0}）")]
            SelectedDatabase,

            /// <summary>
            /// データベースへの登録を実行しました
            /// </summary>
            [Display(Order = (int)Log.LogType.Info, Description = "データベースへの登録を実行しました（SQL：{0}）")]
            RegistedDatabase,

            /// <summary>
            /// ボタンクリック
            /// </summary>
            [Display(Order = (int)Log.LogType.Info, Description = "ボタンをクリックしました（機能：{0}）")]
            ButtonClicked,

            /// <summary>
            /// 保存完了
            /// </summary>
            [Display(Order = (int)Log.LogType.Info, Description = "設定内容を保存しました")]
            SaveComplate,

            /// <summary>
            /// 存在チェックエラー
            /// </summary>
            [Display(Order = (int)Log.LogType.Error, Description = "指定した処理No（{0}）は存在しません")]
            NotExistsDataNumber,

            /// <summary>
            /// 未入力エラー
            /// </summary>
            [Display(Order = (int)Log.LogType.Error, Description = "{0}が未入力です")]
            NotEntryData,
        }
    }
}
