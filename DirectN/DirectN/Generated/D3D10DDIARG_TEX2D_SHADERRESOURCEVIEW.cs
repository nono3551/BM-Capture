﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(550,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10DDIARG_TEX2D_SHADERRESOURCEVIEW
    {
        public uint MostDetailedMip;
        public uint FirstArraySlice;
        public uint MipLevels;
        public uint ArraySize;
    }
}
