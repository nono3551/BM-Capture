﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(3364,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("20bc074b-7a8d-4609-8c3b-64a0a3b5d7ce"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFDXGIDeviceManagerSource
    {
        [PreserveSig]
        HRESULT GetManager(/* [out] __RPC__deref_out_opt */ out IMFDXGIDeviceManager ppManager);
    }
}
