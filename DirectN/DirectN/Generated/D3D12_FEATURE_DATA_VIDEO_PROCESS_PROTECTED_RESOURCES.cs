﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12video.h(3617,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_VIDEO_PROCESS_PROTECTED_RESOURCES
    {
        public uint NodeIndex;
        public D3D12_VIDEO_PROTECTED_RESOURCE_SUPPORT_FLAGS SupportFlags;
    }
}
