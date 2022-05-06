﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfmediaengine.h(5638,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("4d645ace-26aa-4688-9be1-df3516990b93"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaEngineClassFactory
    {
        [PreserveSig]
        HRESULT CreateInstance(/* [annotation][in] _In_ */ uint dwFlags, /* [annotation][in] _In_ */ IMFAttributes pAttr, /* [annotation][out] _Outptr_ */ out IMFMediaEngine ppPlayer);
        
        [PreserveSig]
        HRESULT CreateTimeRange(/* [annotation][out] _Outptr_ */ out IMFMediaTimeRange ppTimeRange);
        
        [PreserveSig]
        HRESULT CreateError(/* [annotation][out] _Outptr_ */ out IMFMediaError ppError);
    }
}
