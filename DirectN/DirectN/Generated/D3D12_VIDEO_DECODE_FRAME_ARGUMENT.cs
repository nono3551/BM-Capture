﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12video.h(1048,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_DECODE_FRAME_ARGUMENT
    {
        public D3D12_VIDEO_DECODE_ARGUMENT_TYPE Type;
        public uint Size;
        public IntPtr pData;
    }
}
