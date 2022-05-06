﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmp.h(6921,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("cbb92747-741f-44fe-ab5b-f1a48f3b2a59"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPRemoteMediaServices
    {
        [PreserveSig]
        HRESULT GetServiceType(/* [out] */ out IntPtr pbstrType);
        
        [PreserveSig]
        HRESULT GetApplicationName(/* [out] */ out IntPtr pbstrName);
        
        [PreserveSig]
        HRESULT GetScriptableObject(/* [out] */ out IntPtr pbstrName, /* [out] */ [MarshalAs(UnmanagedType.IDispatch)] out object ppDispatch);
        
        [PreserveSig]
        HRESULT GetCustomUIMode(/* [out] */ out IntPtr pbstrFile);
    }
}
