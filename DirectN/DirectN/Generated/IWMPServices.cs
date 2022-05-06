﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmpservices.h(147,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("afb6b76b-1e20-4198-83b3-191db6e0b149"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPServices
    {
        [PreserveSig]
        HRESULT GetStreamTime(/* [retval][out] */ out long prt);
        
        [PreserveSig]
        HRESULT GetStreamState(/* [retval][out] */ out WMPServices_StreamState pState);
    }
}
