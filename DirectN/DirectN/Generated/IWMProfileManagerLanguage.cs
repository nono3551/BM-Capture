﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsdkidl.h(6296,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("ba4dcc78-7ee0-4ab8-b27a-dbce8bc51454"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMProfileManagerLanguage
    {
        [PreserveSig]
        HRESULT GetUserLanguageID(ref ushort wLangID);
        
        [PreserveSig]
        HRESULT SetUserLanguageID(ushort wLangID);
    }
}
