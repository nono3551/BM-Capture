﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(2009,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_RT_FORMAT_ARRAY
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public DXGI_FORMAT[] RTFormats;
        public uint NumRenderTargets;
    }
}
