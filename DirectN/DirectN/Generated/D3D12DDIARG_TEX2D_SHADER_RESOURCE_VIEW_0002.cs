﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(863,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_TEX2D_SHADER_RESOURCE_VIEW_0002
    {
        public uint MostDetailedMip;
        public uint FirstArraySlice;
        public uint MipLevels;
        public uint ArraySize;
        public uint PlaneSlice;
        public float ResourceMinLODClamp;
    }
}
