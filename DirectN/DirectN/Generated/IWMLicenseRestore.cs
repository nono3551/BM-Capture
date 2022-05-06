﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsdkidl.h(16459,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c70b6334-a22e-4efb-a245-15e65a004a13"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMLicenseRestore
    {
        [PreserveSig]
        HRESULT RestoreLicenses(/* [in] */ uint dwFlags, /* [in] */ IWMStatusCallback pCallback);
        
        [PreserveSig]
        HRESULT CancelLicenseRestore();
    }
}
