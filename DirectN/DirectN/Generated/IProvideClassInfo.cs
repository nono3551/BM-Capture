﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ocidl.h(1176,5)
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [ComImport, Guid("b196b283-bab4-101a-b69c-00aa00341d07"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IProvideClassInfo
    {
        [PreserveSig]
        HRESULT GetClassInfoW(/* [out] __RPC__deref_out_opt */ out ITypeInfo ppTI);
    }
}
