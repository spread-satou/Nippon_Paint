using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices; // DLL Import

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
public struct ftpParams
{
    public int      rfno;
    public string   ip;
    public string   port;
    public string   user;
    public string   pass;
    public string   orders;
    public string   feedback;
    public string   notify;
};

// https://docs.microsoft.com/ja-jp/dotnet/framework/interop/default-marshalling-for-strings
// https://docs.microsoft.com/ja-jp/dotnet/api/system.runtime.interopservices.layoutkind?view=net-6.0
// https://docs.microsoft.com/ja-jp/dotnet/api/system.runtime.interopservices.structlayoutattribute.pack?view=net-6.0
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
public struct ordParams
{
    //[MarshalAs(UnmanagedType.LPStr)] public string fullpath;
    //[MarshalAs(UnmanagedType.LPStr)] public string test;
    //[MarshalAs(UnmanagedType.LPStr)] public string test2;
    public string filename;
    public string test;
    public string test2;

}
// https://docs.microsoft.com/ja-JP/dotnet/api/system.runtime.interopservices.unmanagedtype?view=net-6.0#system-runtime-interopservices-unmanagedtype-byvalarray
[StructLayout(LayoutKind.Sequential)]
public struct ordArray
{
    //[MarshalAs(UnmanagedType.LPArray, SizeConst = 1)] public IntPtr ord_ptr;
    public IntPtr ord_ptr;
}

namespace ftpApp
{
    internal static class NativeMethods
    {
        [DllImport("ftpDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int native_thread_launcher(ref ftpParams fp, IntPtr op);
        internal static extern int native_thread_launcher(ref ftpParams fp, ref ordArray op);
    }
}
