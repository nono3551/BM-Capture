﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfmediacapture.h(101,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("3de21209-8ba6-4f2a-a577-2819b56ff14d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAdvancedMediaCaptureInitializationSettings
    {
        [PreserveSig]
        HRESULT SetDirectxDeviceManager(/* [in] */ IMFDXGIDeviceManager value);
    }
}
