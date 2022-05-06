﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmp.h(10384,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("56e2294f-69ed-4629-a869-aea72c0dcc2c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPCdromRip
    {
        [PreserveSig]
        HRESULT get_ripState(/* [retval][out] */ out WMPRipState pwmprs);
        
        [PreserveSig]
        HRESULT get_ripProgress(/* [retval][out] */ out long plProgress);
        
        [PreserveSig]
        HRESULT startRip();
        
        [PreserveSig]
        HRESULT stopRip();
    }
}
