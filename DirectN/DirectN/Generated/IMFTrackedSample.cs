﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(17745,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("245bf8e9-0755-40f7-88a5-ae0f18d55e17"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFTrackedSample
    {
        [PreserveSig]
        HRESULT SetAllocator(/* [annotation][in] _In_ */ IMFAsyncCallback pSampleAllocator, /* [unique][in] */ [MarshalAs(UnmanagedType.IUnknown)] object pUnkState);
    }
}
