﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(3383,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_1DDI_VIDEO_PROCESSOR_FILTER_RANGE
    {
        public int Minimum;
        public int Maximum;
        public int Default;
        public float Multiplier;
    }
}
