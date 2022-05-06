﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\audioengineendpoint.h(1193,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("076a6922-d802-4f83-baf6-409d9ca11bfe"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioLfxControl
    {
        [PreserveSig]
        HRESULT SetLocalEffectsState(/* [in] */ bool bEnabled);
        
        [PreserveSig]
        HRESULT GetLocalEffectsState(/* [out] */ out bool pbEnabled);
    }
}
