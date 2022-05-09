using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices; // DLL Import

// https://docs.microsoft.com/ja-jp/dotnet/api/system.runtime.interopservices.charset?view=net-6.0
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
public struct serialParams
{
    // https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/builtin-types/built-in-types
    // https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/builtin-types/value-types
    // https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/keywords/reference-types
    // https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/builtin-types/integral-numeric-types

    // 仕様
    //  0: 大阪以外 END文字列がメッセージ終端
    //  1: 大阪     END文字列後に可変長メッセージが付加される
    //  2～TBD
    public int      msgfmt;

    // シリアルパラメータ
    //  マネージコードからはCharSet.Ansiで渡すので、
    //  ポート番号はアンマネージコード内でUNICODE変換が必要
    public string   port;                               // ポート番号
    public int      baudrate;                           // 通信速度
    public int      databites;                          // データビット
    public string   stopbits;                           // ストップビット
    public string   parity;                             // パリティ
    public int      dtrFlow;                            // DTR Control Flow
    public int      rtsFlow;                            // RTS Control Flow
    public byte     xon;                                // 0固定
    public byte     xoff;                               // 0固定
}

// シミュレータ用パラメータ
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
public struct ccmParams
{
    // 1-5
    public string strKan;                               //! 缶種
    public string strRev;                               //! 改訂
    public string strProdName;                          //! 製品名
    public string strProdCode;                          //! 製品コード
    public string strPainName;                          //! 塗料名
    // 6-7
    public string strWHCode;                            //! ホワイトコード
    public string strWHWeight;                          //! ホワイト重量
    // 8-17
    public string strColorant01;                        //! 着色剤コード1
    public string strWeghit01;                          //! 重量1
    public string strColorant02;                        //! 着色剤コード
    public string strWeghit02;                          //! 重量
    public string strColorant03;                        //! 着色剤コード
    public string strWeghit03;                          //! 重量
    public string strColorant04;                        //! 着色剤コード
    public string strWeghit04;                          //! 重量
    public string strColorant05;                        //! 着色剤コード
    public string strWeghit05;                          //! 重量
    // 18-27
    public string strColorant06;                        //! 着色剤コード
    public string strWeghit06;                          //! 重量
    public string strColorant07;                        //! 着色剤コード
    public string strWeghit07;                          //! 重量
    public string strColorant08;                        //! 着色剤コード
    public string strWeghit08;                          //! 重量
    public string strColorant09;                        //! 着色剤コード
    public string strWeghit09;                          //! 重量
    public string strColorant10;                        //! 着色剤コード
    public string strWeghit10;                          //! 重量
    // 28-37
    public string strColorant11;                        //! 着色剤コード
    public string strWeghit11;                          //! 重量
    public string strColorant12;                        //! 着色剤コード
    public string strWeghit12;                          //! 重量
    public string strColorant13;                        //! 着色剤コード
    public string strWeghit13;                          //! 重量
    public string strColorant14;                        //! 着色剤コード
    public string strWeghit14;                          //! 重量
    public string strColorant15;                        //! 着色剤コード
    public string strWeghit15;                          //! 重量
    // 38-45
    public string strColorant16;                        //! 着色剤コード
    public string strWeghit16;                          //! 重量
    public string strColorant17;                        //! 着色剤コード
    public string strWeghit17;                          //! 重量
    public string strColorant18;                        //! 着色剤コード
    public string strWeghit18;                          //! 重量
    public string strColorant19;                        //! 着色剤コード
    public string strWeghit19;                          //! 重量
    // 46-50
    public string strGrossWeight;                       //! 総重量
    public string strTerm;                              //! ターミネータ
    public string strFilename;                          //! 既調色ファイル名
    public string strIndex;                             //! 目次番号
    public string strLineName;                          //! ライン名
}



namespace serialApp
{
    internal class nativeMethods
    {
        [DllImport("serialDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int native_thread_launcher(ref serialParams rSp);

        [DllImport("serialDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int native_simulator(ref ccmParams rCp);

        [DllImport("serialDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int native_release();
    }
}
