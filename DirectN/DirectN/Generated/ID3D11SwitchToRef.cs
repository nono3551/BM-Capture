﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11sdklayers.h(344,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("1ef337e3-58e7-4f83-a692-db221f5ed47e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11SwitchToRef
    {
        [PreserveSig]
        bool SetUseRef(bool UseRef);
        
        [PreserveSig]
        bool GetUseRef();
    }
}
