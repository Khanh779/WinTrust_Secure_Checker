using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WinTrust_Library.Enums;
using WinTrust_Library.Structs;

namespace WinTrust_Library
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public class WinTrustData : IDisposable
    {
        public uint StructSize = (uint)Marshal.SizeOf(typeof(WinTrustData));
        public IntPtr PolicyCallbackData = IntPtr.Zero;
        public IntPtr SIPClientData = IntPtr.Zero;
        public WinTrustDataUIChoice UIChoice = WinTrustDataUIChoice.None;
        public WinTrustDataRevocationChecks RevocationChecks = WinTrustDataRevocationChecks.WholeChain;
        public WinTrustDataChoice UnionChoice = WinTrustDataChoice.File;
        public IntPtr FileInfoPtr;
        public WinTrustDataStateAction StateAction = WinTrustDataStateAction.Verify;
        public IntPtr StateData = IntPtr.Zero;
        public string? URLReference;
        public WinTrustDataProvFlags ProvFlags = WinTrustDataProvFlags.CacheOnlyUrlRetrieval | WinTrustDataProvFlags.RevocationCheckChain;
        public WinTrustDataUIContext UIContext = WinTrustDataUIContext.Execute;

        public WinTrustData(string fileName, WinTrustDataRevocationChecks revocationChecks)
        {
            // On Win7SP1+, don't allow MD2 or MD4 signatures
            if ((Environment.OSVersion.Version.Major > 6) ||
                ((Environment.OSVersion.Version.Major == 6) && (Environment.OSVersion.Version.Minor > 1)) ||
                ((Environment.OSVersion.Version.Major == 6) && (Environment.OSVersion.Version.Minor == 1) && !String.IsNullOrEmpty(Environment.OSVersion.ServicePack)))
            {
                ProvFlags |= WinTrustDataProvFlags.DisableMD2andMD4;
            }

            RevocationChecks = revocationChecks;

            var wtfiData = new WinTrustFileInfo(fileName);
            FileInfoPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf(typeof(WinTrustFileInfo)));
            Marshal.StructureToPtr(wtfiData, FileInfoPtr, false);
        }

        public WinTrustData(WinTrustFileInfo fileInfo)
        {
            FileInfoPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf(typeof(WinTrustFileInfo)));
            Marshal.StructureToPtr(fileInfo, FileInfoPtr, false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (FileInfoPtr == IntPtr.Zero)
            {
                if (disposing)
                {
                    // Dispose managed state (managed objects)
                }

                Marshal.DestroyStructure(FileInfoPtr, typeof(WinTrustFileInfo));
                Marshal.FreeCoTaskMem(FileInfoPtr);
                FileInfoPtr = IntPtr.Zero;
            }
        }

        ~WinTrustData() => Dispose(disposing: false);

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
