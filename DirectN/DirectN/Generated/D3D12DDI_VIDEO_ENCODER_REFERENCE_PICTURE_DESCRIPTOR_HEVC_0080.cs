﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(12532,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_ENCODER_REFERENCE_PICTURE_DESCRIPTOR_HEVC_0080
    {
        public uint ReconstructedPictureResourceIndex;
        public bool IsLongTermReference;
        public uint PictureOrderCountNumber;
        public uint TemporalLayerIndex;
    }
}
