﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsecure.h(455,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("94bc0598-c3d2-11d3-bedf-00c04f612986"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMGetSecureChannel
    {
        [PreserveSig]
        HRESULT GetPeerSecureChannelInterface(/* [out] */ out IWMSecureChannel ppPeer);
    }
}
