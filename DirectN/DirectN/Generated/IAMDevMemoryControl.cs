﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(14860,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c6545bf1-e76b-11d0-bd52-00a0c911ce86"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMDevMemoryControl
    {
        [PreserveSig]
        HRESULT QueryWriteSync();
        
        [PreserveSig]
        HRESULT WriteSync();
        
        [PreserveSig]
        HRESULT GetDevId(/* [annotation][out] _Out_ */ out uint pdwDevId);
    }
}
