﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(8085,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("f88cfb8c-ef16-4991-b450-cb8c69e51704"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMetadata
    {
        [PreserveSig]
        HRESULT SetLanguage(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPWStr)] string pwszRFC1766);
        
        [PreserveSig]
        HRESULT GetLanguage(/* [out] __RPC__deref_out_opt */ out IntPtr ppwszRFC1766);
        
        [PreserveSig]
        HRESULT GetAllLanguages(/* [out] __RPC__out */ [In, Out] PropVariant ppvLanguages);
        
        [PreserveSig]
        HRESULT SetProperty(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPWStr)] string pwszName, /* [in] __RPC__in */ [In, Out] PropVariant ppvValue);
        
        [PreserveSig]
        HRESULT GetProperty(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPWStr)] string pwszName, /* [out] __RPC__out */ [In, Out] PropVariant ppvValue);
        
        [PreserveSig]
        HRESULT DeleteProperty(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPWStr)] string pwszName);
        
        [PreserveSig]
        HRESULT GetAllPropertyNames(/* [out] __RPC__out */ [In, Out] PropVariant ppvNames);
    }
}
