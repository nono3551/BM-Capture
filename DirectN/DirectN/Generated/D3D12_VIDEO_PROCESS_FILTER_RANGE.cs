﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12video.h(1321,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_PROCESS_FILTER_RANGE
    {
        public int Minimum;
        public int Maximum;
        public int Default;
        public float Multiplier;
    }
}
