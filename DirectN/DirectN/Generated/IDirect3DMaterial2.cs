﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d.h(1035,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("93281503-8cf8-11d0-89ab-00a0c9054129"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DMaterial2
    {
        [PreserveSig]
        HRESULT SetMaterial(ref _D3DMATERIAL unnamed__0);
        
        [PreserveSig]
        HRESULT GetMaterial(ref _D3DMATERIAL unnamed__0);
        
        [PreserveSig]
        HRESULT GetHandle(IDirect3DDevice2 unnamed__0, ref uint unnamed__1);
    }
}
