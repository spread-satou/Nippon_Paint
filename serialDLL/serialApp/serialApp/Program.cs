// See https://aka.ms/new-console-template for more information

// https://docs.microsoft.com/ja-jp/dotnet/standard/class-library-overview#system-namespace
// https://docs.microsoft.com/ja-jp/dotnet/framework/interop/marshalling-classes-structures-and-unions#structures-sample
// https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/arrays/using-foreach-with-arrays

// ■ ディレクトリ作成
string[] ardir = { "CCMdata", "CCMLog" };
foreach (string str in ardir)
{
    makeDirectory(str);
}

// ■ シリアル通信
serialParams sp;
List<serialParams> preset = new List<serialParams>
{
    new serialParams{msgfmt = 1/*END+α */, port = "COM4", baudrate = 9600, databites =8 , stopbits="1", parity="none", dtrFlow = 0, rtsFlow = 0, xon = 0, xoff=0},
    new serialParams{msgfmt = 0/*ENDまで*/, port = "COM4", baudrate = 9600, databites =8 , stopbits="1", parity="none", dtrFlow = 0, rtsFlow = 0, xon = 0, xoff=0},
    new serialParams{msgfmt = 2/*規定外 */, port = "COM4", baudrate = 9600, databites =8 , stopbits="1", parity="none", dtrFlow = 0, rtsFlow = 0, xon = 0, xoff=0},

    // パラメータ異常
    new serialParams{msgfmt = 0, port = "COM5", baudrate = 256001, databites =8 , stopbits="3.0", parity="ODD", dtrFlow = 0, rtsFlow = 0, xon = 0, xoff=0},
    new serialParams{msgfmt = 0, port = "COM5", baudrate = 1, databites =8 , stopbits="0", parity="EVEN", dtrFlow = 0, rtsFlow = 0, xon = 0, xoff=0},

    // 以下、デバッグ
    new serialParams{msgfmt = 0, port = "COM5", baudrate = 57600,  databites =8 , stopbits="2", parity="odd", dtrFlow = 0, rtsFlow = 0, xon = 0, xoff=0},
    new serialParams{msgfmt = 0, port = "COM5", baudrate = 19200,  databites =8 , stopbits="1.5", parity="even", dtrFlow = 0, rtsFlow = 0, xon = 0, xoff=0},
    new serialParams{msgfmt = 0, port = "COM5", baudrate = 115200, databites =8 , stopbits="1.0", parity="mark", dtrFlow = 0, rtsFlow = 0, xon = 0, xoff=0},
    new serialParams{msgfmt = 0, port = "COM5", baudrate = 256000, databites =8 , stopbits="2.0", parity="space", dtrFlow = 0, rtsFlow = 0, xon = 0, xoff=0}
};

ccmParams cp = new ccmParams();
makeParams(ref cp);

#if false
serialApp.nativeMethods.native_simulator(ref cp);

int rc;
int ii = 0;
sp = preset[0];
rc = serialApp.nativeMethods.native_thread_launcher(ref sp);


// https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/statements/iteration-statements
for (ii = 0; ii < 3; ii++)
{
    Thread.Sleep(30 * 1000);

    serialApp.nativeMethods.native_simulator(ref cp);
}

serialApp.nativeMethods.native_release();
#else
int rc;
int ii = 0;

//sp = preset[1/*ENDまで*/];
sp = preset[0];
rc = serialApp.nativeMethods.native_thread_launcher(ref sp);

//foreach (serialParams dbg_sp in preset)
//{
//    sp = dbg_sp;
//    Console.WriteLine("{0}", sp.baudrate);
//    serialApp.nativeMethods.native_thread_launcher(ref sp);
//}

for (ii = 0; ii < 2; ii++)
{
    Thread.Sleep(30 * 1000);
}
serialApp.nativeMethods.native_release();
#endif


Console.WriteLine("Hello, World!");

void makeParams(ref ccmParams rCP)
{
    // 1-5
    rCP.strKan = "9";                                   //! 缶種
    rCP.strRev = "0";                                   //! 改訂
    //rCP.strRev = "99";                                   //! 改訂
    //rCP.strRev = "999";                                   //! 改訂
    //rCP.strRev = "a";                                   //! 改訂
    //rCP.strRev = "\x0a";                                   //! 改訂
    rCP.strProdName = "DAN Light yellow";               //! 製品名
    //rCP.strProdCode = "XA";                             //! 製品コード
    //rCP.strProdCode = "YA";                             //! 製品コード
    //rCP.strProdCode = "A0";                             //! 製品コード
    //rCP.strProdCode = "aZ";                             //! 製品コード

    //rCP.strProdCode = "A1";                             //! 製品コード
    //rCP.strProdCode = "A9";                             //! 製品コード
    //rCP.strProdCode = "W1";                             //! 製品コード
    //rCP.strProdCode = "W9";                             //! 製品コード
    //rCP.strProdCode = "AA";                             //! 製品コード
    rCP.strProdCode = "AZ";                             //! 製品コード
    rCP.strPainName = "DAN Fresh";                      //! 塗料名
    // 6-7
    rCP.strWHCode = "DANFRE";                           //! ホワイトコード
    //rCP.strWHWeight = "\x01\x02\x03";                      //! ホワイト重量
    //rCP.strWHWeight = "14500.\x0a\x33";                      //! ホワイト重量
    //rCP.strWHWeight = "\x0a4500.3";                      //! ホワイト重量
    //rCP.strWHWeight = "1\x0a500.3";                      //! ホワイト重量
    //rCP.strWHWeight = "1450\x0a.3";                      //! ホワイト重量
    //rCP.strWHWeight = "14500.3000";                      //! ホワイト重量
    rCP.strWHWeight = "14500.300";                      //! ホワイト重量
    // 8-17
    rCP.strColorant01 = "RED01";                        //! 着色剤コード1
    rCP.strWeghit01   = "3.730";                        //! 重量1
    rCP.strColorant02 = "RED02";                        //! 着色剤コード
    rCP.strWeghit02   = "12.34";                        //! 重量
    rCP.strColorant03 = "RED03";                        //! 着色剤コード
    rCP.strWeghit03   = "123.4";                        //! 重量
    rCP.strColorant04 = "RED04";                        //! 着色剤コード
    rCP.strWeghit04   = "0.001";                        //! 重量
    rCP.strColorant05 = "RED05";                        //! 着色剤コード
    rCP.strWeghit05   = "10.00";                        //! 重量
    // 18-27
    rCP.strColorant06 = "RED06";                        //! 着色剤コード
    rCP.strWeghit06   = "100.0";                        //! 重量
    rCP.strColorant07 = "RED07";                        //! 着色剤コード
    rCP.strWeghit07   = "12345";                        //! 重量
    rCP.strColorant08 = "RED08";                        //! 着色剤コード
    rCP.strWeghit08   = "67890";                        //! 重量
    rCP.strColorant09 = "RED09";                        //! 着色剤コード
    rCP.strWeghit09   = "0.000";                        //! 重量
    rCP.strColorant10 = "RED10";                        //! 着色剤コード
    rCP.strWeghit10   = "0.000";                        //! 重量
    // 28-37
    rCP.strColorant11 = "RED11";                        //! 着色剤コード
    rCP.strWeghit11   = "0.0";                          //! 重量
    rCP.strColorant12 = "RED12";                        //! 着色剤コード
    rCP.strWeghit12   = "0.0";                          //! 重量
    rCP.strColorant13 = "RED13";                        //! 着色剤コード
    rCP.strWeghit13   = "0.0";                          //! 重量
    rCP.strColorant14 = "RED14";                        //! 着色剤コード
    rCP.strWeghit14   = "0.0";                          //! 重量
    rCP.strColorant15 = "RED15";                        //! 着色剤コード
    rCP.strWeghit15   = "0.0";                          //! 重量
    // 38-45
    rCP.strColorant16 = "";                             //! 着色剤コード
    rCP.strWeghit16   = "";                             //! 重量
    rCP.strColorant17 = "";                             //! 着色剤コード
    rCP.strWeghit17   = "";                             //! 重量
    rCP.strColorant18 = "";                             //! 着色剤コード
    rCP.strWeghit18   = "";                             //! 重量
    rCP.strColorant19 = "";                             //! 着色剤コード
    rCP.strWeghit19   = "";                             //! 重量
    // 46-50
    rCP.strGrossWeight = "14934.6";                     //! 総重量
    rCP.strTerm = "END";                                //! ターミネータ
    //rCP.strTerm = "eND";                                //! ターミネータ
    //rCP.strTerm = "END1";                                //! ターミネータ
    //rCP.strFilename = "A1";                             //! 既調色ファイル名
    rCP.strFilename = "aa";                             //! 既調色ファイル名
    //rCP.strFilename = "\x0a";                             //! 既調色ファイル名
    rCP.strIndex = "1234";                              //! 目次番号
    rCP.strLineName = "RF";                             //! ライン名
}

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
    try
    {
        // Get the current directory.
        string path_cur = Directory.GetCurrentDirectory();
        string target = path_cur + "\\" + strBase;

        Console.WriteLine("The current directory is {0}", target);

        // まずは、引数で指定されたディレクトリ
        if (!Directory.Exists(target))
        {
            Directory.CreateDirectory(target);
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("The process failed: {0}", e.ToString());
    }

    return;
}

