﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(16682,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("22320cb2-d41a-11d2-bf7c-d7cb9df0bf93"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMAudioRendererStats
    {
        [PreserveSig]
        HRESULT GetStatParam(/* [in] */ uint dwParam, /* [annotation][out] _Out_ */ out uint pdwParam1, /* [annotation][out] _Out_ */ out uint pdwParam2);
    }
}
