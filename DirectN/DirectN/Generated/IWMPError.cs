﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmp.h(819,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("a12dcf7d-14ab-4c1b-a8cd-63909f06025b"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public partial interface IWMPError
    {
        [PreserveSig]
        HRESULT clearErrorQueue();
        
        [PreserveSig]
        HRESULT get_errorCount(/* [retval][out] */ out long plNumErrors);
        
        [PreserveSig]
        HRESULT get_item(/* [in] */ int dwIndex, /* [retval][out] */ out IWMPErrorItem ppErrorItem);
        
        [PreserveSig]
        HRESULT webHelp();
    }
}
