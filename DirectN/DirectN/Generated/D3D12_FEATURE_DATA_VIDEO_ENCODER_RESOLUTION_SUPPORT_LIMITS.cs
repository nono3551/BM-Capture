﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12video.h(6102,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_LIMITS
    {
        public uint MaxSubregionsNumber;
        public uint MaxIntraRefreshFrameDuration;
        public uint SubregionBlockPixelsSize;
        public uint QPMapRegionPixelsSize;
    }
}
