﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12video.h(1055,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_DECODE_REFERENCE_FRAMES
    {
        public uint NumTexture2Ds;
        public IntPtr ppTexture2Ds;
        public IntPtr pSubresources;
        public IntPtr ppHeaps;
    }
}
