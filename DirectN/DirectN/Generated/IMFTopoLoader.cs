﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(7571,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("de9a6157-f660-4643-b56a-df9f7998c7cd"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFTopoLoader
    {
        [PreserveSig]
        HRESULT Load(/* [in] */ IMFTopology pInputTopo, /* [annotation][out] _Outptr_ */ out IMFTopology ppOutputTopo, /* [in] */ IMFTopology pCurrentTopo);
    }
}
