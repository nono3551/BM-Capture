﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(3269,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_TEX3D_UAV
    {
        public uint MipSlice;
        public uint FirstWSlice;
        public uint WSize;
    }
}