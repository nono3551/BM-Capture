﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(13139,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_GPU_VIRTUAL_ADDRESS_RANGE_AND_STRIDE
    {
        public ulong StartAddress;
        public ulong SizeInBytes;
        public ulong StrideInBytes;
    }
}
