using System;
using System.Security;
using System.Runtime.InteropServices;
using WinTrust_Library.Enums;
using WinTrust_Library.Structs;

// From documentation:
//https://learn.microsoft.com/en-us/windows/win32/api/wintrust/nf-wintrust-winverifytrust

namespace WinTrust_Library
{
    public partial class WinTrust
    {

        public static WinVerifyTrustResult GetFileWinVerifyTrustResult(string fileName)
        {
            WinTrustFileInfo fileInfo = new WinTrustFileInfo(fileName);
            WinTrustData data = new WinTrustData(fileInfo);

            WinVerifyTrustResult result = SafeNativeMethods.WinVerifyTrust(IntPtr.Zero, WINTRUST_ACTION_GENERIC_VERIFY_V2, data);

            return result;
        }

        public static string ToDefinitionString (uint trustCode)
        {
            switch (trustCode)
            {
                case 0u:
                    return "Success";
                case 0x800B0100u:
                    return "No signature";
                case 0x800B0004u:
                    return "Subject not trusted";
                case 0x800B0001u:
                    return "Provider unknown";
                case 0x800B0002u:
                    return "Action unknown";
                case 0x800B0003u:
                    return "Subject form unknown";
                case 0x80092026u:
                    return "Security settings error";
                case 0x80092003u:
                    return "File error";
                default:
                    return "Unknown error code";
            }
        }

        //private static readonly Guid DRIVER_ACTION_VERIFY                   = new(0xf750e6c3, 0x38ee, 0x11d1, 0x85, 0xe5, 0x0, 0xc0, 0x4f, 0xc2, 0x95, 0xee);
        //private static readonly Guid HTTPSPROV_ACTION                       = new(0x573e31f8, 0xaaba, 0x11d0, 0x8c, 0xcb, 0x0, 0xc0, 0x4f, 0xc2, 0x95, 0xee);
        //private static readonly Guid OFFICESIGN_ACTION_VERIFY               = new(0x5555c2cd, 0x17fb, 0x11d1, 0x85, 0xc4, 0x0, 0xc0, 0x4f, 0xc2, 0x95, 0xee);
        //private static readonly Guid WINTRUST_ACTION_GENERIC_CHAIN_VERIFY   = new(0xfc451c16, 0xac75, 0x11d1, 0xb4, 0xb8, 0x0, 0xc0, 0x4f, 0xb6, 0x6e, 0xa0);
        public static readonly Guid WINTRUST_ACTION_GENERIC_VERIFY_V2 = new(0x00aac56b, 0xcd44, 0x11d0, 0x8c, 0xc2, 0x0, 0xc0, 0x4f, 0xc2, 0x95, 0xee);
        //private static readonly Guid WINTRUST_ACTION_TRUSTPROVIDER_TEST     = new(0x573e31f8, 0xddba, 0x11d0, 0x8c, 0xcb, 0x0, 0xc0, 0x4f, 0xc2, 0x95, 0xee);

        

        public static VerifyResult VerifyEmbeddedSignature(string fileName, Guid guidAction, WinTrustDataRevocationChecks revocationChecks)
        {
            using var wtd = new WinTrustData(fileName, revocationChecks);
            WinVerifyTrustResult lStatus = SafeNativeMethods.WinVerifyTrust(IntPtr.Zero, guidAction, wtd);

            // Any hWVTStateData must be released by a call with close.
            wtd.StateAction = WinTrustDataStateAction.Close;
            SafeNativeMethods.WinVerifyTrust(IntPtr.Zero, guidAction, wtd);

            switch (lStatus)
            {
                case WinVerifyTrustResult.TRUST_SUCCESS:
                    return VerifyResult.SIGNATURE_VALID;
                case WinVerifyTrustResult.CRYPT_E_FILE_ERROR:
                    return VerifyResult.SIGNATURE_MISSING;
                default:
                    uint dwLastError;
                    unchecked { dwLastError = (uint)Marshal.GetLastWin32Error(); }
                    if (((uint)WinVerifyTrustResult.TRUST_E_NOSIGNATURE == dwLastError) ||
                            ((uint)WinVerifyTrustResult.TRUST_E_SUBJECT_FORM_UNKNOWN == dwLastError) ||
                            ((uint)WinVerifyTrustResult.TRUST_E_PROVIDER_UNKNOWN == dwLastError))
                    {
                        return VerifyResult.SIGNATURE_MISSING;
                    }
                    else
                    {
                        return VerifyResult.SIGNATURE_INVALID;
                    }
            }
        }

        public static VerifyResult VerifyFileAuthenticode(string filePath)
        {
            return VerifyEmbeddedSignature(filePath, WINTRUST_ACTION_GENERIC_VERIFY_V2, WinTrustDataRevocationChecks.WholeChain);
        }
    }


}