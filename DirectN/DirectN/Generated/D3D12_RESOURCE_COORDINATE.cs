﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12video.h(3217,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_RESOURCE_COORDINATE
    {
        public ulong X;
        public uint Y;
        public uint Z;
        public uint SubresourceIndex;
    }
}
