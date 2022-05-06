﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmpservices.h(514,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("5fca444c-7ad1-479d-a4ef-40566a5309d6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPPluginEnable
    {
        [PreserveSig]
        HRESULT SetEnable(/* [in] */ bool fEnable);
        
        [PreserveSig]
        HRESULT GetEnable(/* [out] */ out bool pfEnable);
    }
}
