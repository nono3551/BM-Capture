﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(419,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_HRESOURCE_PLACEMENT
    {
        public D3D10DDI_HRESOURCE hResource;
        public ulong Offset;
    }
}
