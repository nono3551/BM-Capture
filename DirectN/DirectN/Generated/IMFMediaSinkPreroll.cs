﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(15556,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("5dfd4b2a-7674-4110-a4e6-8a68fd5f3688"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaSinkPreroll
    {
        [PreserveSig]
        HRESULT NotifyPreroll(/* [in] */ long hnsUpcomingStartTime);
    }
}
