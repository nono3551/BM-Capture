﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(21076,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("7071e1f0-e84b-4b33-974f-12fa49de65c5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12Tools
    {
        [PreserveSig]
        void EnableShaderInstrumentation(bool bEnable);
        
        [PreserveSig]
        bool ShaderInstrumentationEnabled();
    }
}
