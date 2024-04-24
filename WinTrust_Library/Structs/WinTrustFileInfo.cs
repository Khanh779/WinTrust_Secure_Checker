using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WinTrust_Library.Structs
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public  class WinTrustFileInfo
    {
        readonly uint StructSize;
        [MarshalAs(UnmanagedType.LPWStr)] readonly string pszFilePath;
        readonly IntPtr hFile;
        readonly IntPtr pgKnownSubject;

        public WinTrustFileInfo(string path)
        {
            StructSize = (uint)Marshal.SizeOf(typeof(WinTrustFileInfo));
            pszFilePath = path;
            hFile = IntPtr.Zero;
            pgKnownSubject = IntPtr.Zero;
        }
    }
}
