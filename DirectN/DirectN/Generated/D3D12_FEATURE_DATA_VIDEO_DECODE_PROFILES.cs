﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12video.h(923,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_VIDEO_DECODE_PROFILES
    {
        public uint NodeIndex;
        public uint ProfileCount;
        public IntPtr pProfiles;
    }
}
