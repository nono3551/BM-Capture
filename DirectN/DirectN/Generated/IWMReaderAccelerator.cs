﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsdkidl.h(18523,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("bddc4d08-944d-4d52-a612-46c3fda07dd4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMReaderAccelerator
    {
        [PreserveSig]
        HRESULT GetCodecInterface(/* [in] */ uint dwOutputNum, /* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [out] */ out IntPtr ppvCodecInterface);
        
        [PreserveSig]
        HRESULT Notify(/* [in] */ uint dwOutputNum, /* [in] */ ref _WMMediaType pSubtype);
    }
}
