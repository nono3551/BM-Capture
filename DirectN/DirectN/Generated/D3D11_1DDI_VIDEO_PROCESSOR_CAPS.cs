﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(3287,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_1DDI_VIDEO_PROCESSOR_CAPS
    {
        public uint DeviceCaps;
        public uint FeatureCaps;
        public uint FilterCaps;
        public uint InputFormatCaps;
        public uint AutoStreamCaps;
        public uint StereoCaps;
        public uint RateConversionCapsCount;
        public uint MaxInputStreams;
        public uint MaxStreamStates;
    }
}
