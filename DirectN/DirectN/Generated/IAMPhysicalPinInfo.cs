﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(13451,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("f938c991-3029-11cf-8c44-00aa006b6814"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMPhysicalPinInfo
    {
        [PreserveSig]
        HRESULT GetPhysicalType(/* [annotation][out] _Out_ */ out long pType, /* [annotation][out] _Out_ */ out IntPtr ppszType);
    }
}
