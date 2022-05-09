using System;
using System.Runtime.InteropServices;

// https://docs.microsoft.com/ja-jp/dotnet/standard/class-library-overview#system-namespace
// https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/arrays/using-foreach-with-arrays

// ■ ディレクトリ作成
//string[] ardir = { "LOCAL", "RF1", "RF7", "RF8", "RF9", "RF10" };
string[] ardir = { "RF1", "RF7", "RF8", "RF9", "RF10" };
foreach (string str in ardir)
{
    makeDirectory(str);
}

// ■ FTP通信 RF1～RF10
ftpParams fp;
ordParams op;

op.filename = "fullpath";
op.test  = "test";
op.test2 = "test2";

// C/C++でメンバ変数を書き換えると、PtrToStructure()コール時、メモリアクセス違反で異常終了する
ordArray array_ord;
IntPtr  buffer = Marshal.AllocCoTaskMem(Marshal.SizeOf(op));
Marshal.StructureToPtr(op, buffer, false);
array_ord.ord_ptr = buffer;

//NG
//IntPtr buffer = Marshal.AllocHGlobal(Marshal.SizeOf(op));
//Marshal.StructureToPtr(op, buffer, false);
//array_ord.ord_ptr = buffer;

//int         index;
//IntPtr    hglobal;
//ordArray array_ord;
//ordArray array_new;

//array_ord = new ordArray();
//array_ord.ord = new ordParams[3];

//for (index = 0; index < 3; index++)
//{
//    array_ord.ord[index].fullpath = "";
//    array_ord.ord[index].test = "";
//    array_ord.ord[index].test2 = "";
//}

//ordParams[] ar_ord;
//ordParams[] ord_struct;

//ar_ord = new ordParams[3];
//ord_struct = new ordParams[3];

//for (index = 0; index < 3; index++)
//{
//    ar_ord[index].fullpath = "";
//    ar_ord[index].test = "";
//    ar_ord[index].test2 = "";
//}

List<ftpParams> lifp = new List<ftpParams>
{
    new ftpParams{rfno = 0,  ip = "192.168.11.49", port ="21", user="spread", pass="spread", orders = "SND/ORDER", feedback = "SND/ANSWER", notify = "RCV/NOTIFY"},
    new ftpParams{rfno = 1,  ip = "192.168.11.49", port ="21", user="spread", pass="spread", orders = "SND/ORDER", feedback = "SND/ANSWER", notify = "RCV/NOTIFY"},
    new ftpParams{rfno = 7,  ip = "192.168.11.49", port ="21", user="spread", pass="spread", orders = "SND/ORDER", feedback = "SND/ANSWER", notify = "RCV/NOTIFY"},
    new ftpParams{rfno = 8,  ip = "192.168.11.49", port ="21", user="spread", pass="spread", orders = "SND/ORDER", feedback = "SND/ANSWER", notify = "RCV/NOTIFY"},
    new ftpParams{rfno = 9,  ip = "192.168.11.49", port ="21", user="spread", pass="spread", orders = "SND/ORDER", feedback = "SND/ANSWER", notify = "RCV/NOTIFY"},
    new ftpParams{rfno = 10, ip = "192.168.11.49", port ="21", user="spread", pass="spread", orders = "SND/ORDER", feedback = "SND/ANSWER", notify = "RCV/NOTIFY"}
};

fp = lifp[1];

//fp.rfno = 7;
//fp.ip = "192.168.11.49";
//fp.port = "21";
//fp.user = "spread";
//fp.pass = "spread";
//fp.orders = "SND/ORDER";
//fp.feedback = "SND/ANSWER";
//fp.notify = "RCV/NOTIFY";

// 文字列に対する既定のマーシャリング            https://docs.microsoft.com/ja-jp/dotnet/framework/interop/default-marshalling-for-strings
// クラス、構造体、および共用体のマーシャリング   https://docs.microsoft.com/ja-jp/dotnet/framework/interop/marshalling-classes-structures-and-unions#structures-sample
// Marshal.PtrToStructureメソッド              https://docs.microsoft.com/ja-jp/dotnet/api/system.runtime.interopservices.marshal.ptrtostructure?view=net-6.0

// アンマネージメモリ確保
//hglobal = Marshal.AllocHGlobal(Marshal.SizeOf(array_ord));

// マネージドオブジェクト => アンマネージドメモリブロック にデータをマーシャリング
//Marshal.StructureToPtr(array_ord, hglobal, false);

// FTP通信
ftpApp.NativeMethods.native_thread_launcher(ref fp, ref array_ord);

// マネージドオブジェクト <= アンマネージド メモリブロック にデータをマーシャリング
//array_new = (ordArray)Marshal.PtrToStructure(hglobal, typeof(ordArray));

// アンマネージメモリ解放
//Marshal.FreeHGlobal(hglobal);

ordParams dbg = (ordParams)Marshal.PtrToStructure(array_ord.ord_ptr, typeof(ordParams));

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


/*!
 * @file		Programs.cs
 * @fn			static void makeDirectory(string strBase)
 * @brief		作業ディレクトリ作成
 * @details		作業ディレクトリ作成
 * @return		void
 * @param[in]	strBase         基点ディレクトリ
 *                              LOCAL
 *                              RF1～RF10
 * @date		2022/3/3
 * @note		基点ディレクトリ直下
 *              \Incoming\RFORDERyyyymmmm00000.ORD
 *              \OrderLogs\RFORDERyyyymmmm00000.OKY
 *              \Processed\RFORDERyyyymmmm00000.OKY
 *              \Completed\RFORDERyyyymmmm00000.NTY
 */
// https://docs.microsoft.com/ja-jp/dotnet/api/system.io.directory.getcurrentdirectory?view=netframework-4.7.2
static void makeDirectory(string strBase)
{
    try {
        // Get the current directory.
        string path_cur = Directory.GetCurrentDirectory();
        string target   = path_cur + "\\" + strBase;
        string[] ardir= { "Completed", "Incomming", "OrderLogs", "Processed" };

        Console.WriteLine("The current directory is {0}", target);

        // まずは、引数で指定されたディレクトリ
        if (!Directory.Exists(target)) {
            Directory.CreateDirectory(target);
        }

        // TARGETのサブディレクトリ
        foreach (string str in  ardir) {
            if (!Directory.Exists(target + "\\" + str)) {
                Directory.CreateDirectory(target + "\\" + str);
            }
        }
    }
    catch (Exception e) {
        Console.WriteLine("The process failed: {0}", e.ToString());
    }

    return;
}

