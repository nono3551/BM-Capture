﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmlss.h(142,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("81e26927-7a7d-40a7-81d4-bddc02960e3e"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public partial interface IWindowsMediaLibrarySharingDeviceProperty
    {
        [PreserveSig]
        HRESULT get_Name(/* [retval][out] */ out IntPtr name);
        
        [PreserveSig]
        HRESULT get_Value(/* [retval][out] */ out IntPtr value);
    }
}
