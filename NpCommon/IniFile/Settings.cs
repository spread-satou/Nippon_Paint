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

#region using define
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
#endregion

namespace NipponPaint.NpCommon.IniFile
{
    public class Settings
    {
        #region 定数
        #endregion

        #region プロパティ
        public Sections.DatabaseSection Database { get; set; }
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Settings()
        {
            var folder = Path.GetDirectoryName(Application.ExecutablePath);
            var filePath = Path.Combine(folder, Constants.IniFiles.NP_COMMON);
            Database = new Sections.DatabaseSection(filePath);
        }
        #endregion
    }
}
