using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinTrust_Library.Enums
{
    public enum VerifyResult
    {
        SIGNATURE_MISSING,
        SIGNATURE_VALID,
        SIGNATURE_INVALID
    }

    public enum WinTrustDataUIChoice : uint
    {
        All = 1,
        None = 2,
        NoBad = 3,
        NoGood = 4
    }

    public enum WinTrustDataRevocationChecks : uint
    {
        None = 0x00000000,
        WholeChain = 0x00000001
    }

    public enum WinTrustDataChoice : uint
    {
        File = 1,
        Catalog = 2,
        Blob = 3,
        Signer = 4,
        Certificate = 5
    }

    public enum WinTrustDataStateAction : uint
    {
        Ignore = 0x00000000,
        Verify = 0x00000001,
        Close = 0x00000002,
        AutoCache = 0x00000003,
        AutoCacheFlush = 0x00000004
    }

    [Flags]
    public enum WinTrustDataProvFlags : uint
    {
        UseIe4TrustFlag = 0x00000001,
        NoIe4ChainFlag = 0x00000002,
        NoPolicyUsageFlag = 0x00000004,
        RevocationCheckNone = 0x00000010,
        RevocationCheckEndCert = 0x00000020,
        RevocationCheckChain = 0x00000040,
        RevocationCheckChainExcludeRoot = 0x00000080,
        SaferFlag = 0x00000100,
        HashOnlyFlag = 0x00000200,
        UseDefaultOsverCheck = 0x00000400,
        LifetimeSigningFlag = 0x00000800,
        CacheOnlyUrlRetrieval = 0x00001000,
        DisableMD2andMD4 = 0x00002000      // Win7 SP1+: Disallows use of MD2 or MD4 in the chain except for the root 
    }
    public enum WinTrustDataUIContext : uint
    {
        Execute = 0,
        Install = 1
    }
    public enum WinVerifyTrustResult : uint
    {
        TRUST_SUCCESS = 0u,
        TRUST_E_NOSIGNATURE = 0x800B0100u,
        TRUST_E_SUBJECT_NOT_TRUSTED = 0x800B0004u,
        TRUST_E_PROVIDER_UNKNOWN = 0x800B0001u,
        TRUST_E_ACTION_UNKNOWN = 0x800B0002u,
        TRUST_E_SUBJECT_FORM_UNKNOWN = 0x800B0003u,
        CRYPT_E_SECURITY_SETTINGS = 0x80092026u,
        CRYPT_E_FILE_ERROR = 0x80092003u
    };
}
