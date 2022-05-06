﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(3194,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_1DDI_VIDEO_PROCESSOR_CONTENT_DESC
    {
        public D3D11_1DDI_VIDEO_FRAME_FORMAT InputFrameFormat;
        public DXGI_RATIONAL InputFrameRate;
        public uint InputWidth;
        public uint InputHeight;
        public DXGI_RATIONAL OutputFrameRate;
        public uint OutputWidth;
        public uint OutputHeight;
        public D3D11_1DDI_VIDEO_USAGE Usage;
    }
}
