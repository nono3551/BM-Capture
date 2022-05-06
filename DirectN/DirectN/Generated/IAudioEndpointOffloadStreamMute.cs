﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\audioengineendpoint.h(908,5)
using System;
using System.Runtime.InteropServices;
using boolean = System.Byte;

namespace DirectN
{
    [ComImport, Guid("dfe21355-5ec2-40e0-8d6b-710ac3c00249"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioEndpointOffloadStreamMute
    {
        [PreserveSig]
        HRESULT SetMute(/* [in] */ byte bMuted);
        
        [PreserveSig]
        HRESULT GetMute(/* [out] */ out boolean pbMuted);
    }
}
