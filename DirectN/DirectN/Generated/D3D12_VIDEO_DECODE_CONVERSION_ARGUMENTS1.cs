﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12video.h(2079,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS1
    {
        public bool Enable;
        public IntPtr pReferenceTexture2D;
        public uint ReferenceSubresource;
        public DXGI_COLOR_SPACE_TYPE OutputColorSpace;
        public DXGI_COLOR_SPACE_TYPE DecodeColorSpace;
        public uint OutputWidth;
        public uint OutputHeight;
    }
}
