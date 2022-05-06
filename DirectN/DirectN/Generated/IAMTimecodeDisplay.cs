﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(14563,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("9b496ce2-811b-11cf-8c77-00aa006b6814"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMTimecodeDisplay
    {
        [PreserveSig]
        HRESULT GetTCDisplayEnable(/* [annotation][out] _Out_ */ out long pState);
        
        [PreserveSig]
        HRESULT SetTCDisplayEnable(/* [in] */ int State);
        
        [PreserveSig]
        HRESULT GetTCDisplay(/* [in] */ int Param, /* [annotation][out] _Out_ */ out long pValue);
        
        [PreserveSig]
        HRESULT SetTCDisplay(/* [in] */ int Param, /* [in] */ int Value);
    }
}
