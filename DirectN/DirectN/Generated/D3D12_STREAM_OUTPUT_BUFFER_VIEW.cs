﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(4030,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_STREAM_OUTPUT_BUFFER_VIEW
    {
        public ulong BufferLocation;
        public ulong SizeInBytes;
        public ulong BufferFilledSizeLocation;
    }
}
