﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\audioclient.h(1532,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("f6e4c0a0-46d9-4fb8-be21-57a3ef2b626c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioClockAdjustment
    {
        [PreserveSig]
        HRESULT SetSampleRate(/* [annotation][in] _In_ */ float flSampleRate);
    }
}
