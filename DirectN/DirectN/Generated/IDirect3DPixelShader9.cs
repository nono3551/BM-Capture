﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3d9.h(185,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("6d3bdbdc-5b02-4415-b852-ce5e8bccb289"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DPixelShader9
    {
        [PreserveSig]
        HRESULT GetDevice(out IDirect3DDevice9 ppDevice);
        
        [PreserveSig]
        HRESULT GetFunction(IntPtr unnamed__0, ref uint pSizeOfData);
    }
}
