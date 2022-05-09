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
    class IniFileHandler
    {
        [DllImport("KERNEL32.DLL")]
        public static extern uint
          GetPrivateProfileString(string lpAppName,
          string lpKeyName, string lpDefault,
          StringBuilder lpReturnedString, uint nSize,
          string lpFileName);

        [DllImport("KERNEL32.DLL",
            EntryPoint = "GetPrivateProfileStringA")]
        public static extern uint
          GetPrivateProfileStringByByteArray(string lpAppName,
          string lpKeyName, string lpDefault,
          byte[] lpReturnedString, uint nSize,
          string lpFileName);

        [DllImport("KERNEL32.DLL")]
        public static extern uint
          GetPrivateProfileInt(string lpAppName,
          string lpKeyName, int nDefault, string lpFileName);

        [DllImport("KERNEL32.DLL")]
        public static extern uint WritePrivateProfileString(
          string lpAppName,
          string lpKeyName,
          string lpString,
          string lpFileName);
    }

    public class ReadFile
    {
        #region 定数
        #endregion

        #region プロパティ
        /// <summary>
        /// iniファイルフルパス
        /// </summary>
        private string FilePath { get; set; }
        #endregion

        #region コンストラクタ
        public ReadFile(string filePath)
        {
            FilePath = filePath;
        }
        #endregion

        #region public functions
        /// <summary>
        /// 文字列値の取得
        /// </summary>
        /// <param name="Section"></param>
        /// <param name="Key"></param>
        /// <param name="defaultVal"></param>
        /// <returns></returns>
        public string GetItem(string Section, string Key, string defaultVal = "")
        {
            var sb = new StringBuilder(1024);
            IniFileHandler.GetPrivateProfileString(Section, Key, defaultVal, sb, (uint)sb.Capacity, FilePath);
            return sb.ToString();
        }
        /// <summary>
        /// 整数値の取得
        /// </summary>
        /// <param name="Section"></param>
        /// <param name="Key"></param>
        /// <param name="defaultVal"></param>
        /// <returns></returns>
        public int GetItem(string Section, string Key, int defaultVal = 0)
        {
            var sb = new StringBuilder(1024);
            IniFileHandler.GetPrivateProfileString(Section, Key, defaultVal.ToString(), sb, (uint)sb.Capacity, FilePath);
            return int.Parse(sb.ToString());
        }
        #endregion

    }
}
