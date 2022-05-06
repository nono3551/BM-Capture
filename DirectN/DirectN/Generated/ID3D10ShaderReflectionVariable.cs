﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10shader.h(301,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("1bf63c95-2650-405d-99c1-3636bd1da0a1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D10ShaderReflectionVariable
    {
        [PreserveSig]
        HRESULT GetDesc(/* THIS_ _Out_ */ out _D3D10_SHADER_VARIABLE_DESC pDesc);
        
        [PreserveSig]
        ID3D10ShaderReflectionType GetType();
    }
}
