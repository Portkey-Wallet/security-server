using System.Collections.Generic;

namespace SecurityServer.Common;

public static class EncryptType
{
    public const string AesCbc = "AesCbc";
    public const string AesGcm = "AesGcm";

    public const string Default = AesGcm;
    public static List<string> All = new(){ AesCbc, AesGcm};

}

