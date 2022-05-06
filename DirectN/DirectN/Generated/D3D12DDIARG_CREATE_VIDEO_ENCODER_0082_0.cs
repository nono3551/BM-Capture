﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(13581,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATE_VIDEO_ENCODER_0082_0
    {
        public uint NodeMask;
        public D3D12DDI_VIDEO_ENCODER_FLAGS_0080 Flags;
        public D3D12DDI_VIDEO_ENCODER_CODEC_0080 EncodeCodec;
        public D3D12DDI_VIDEO_ENCODER_PROFILE_DESC_0080_2 EncodeProfile;
        public DXGI_FORMAT InputFormat;
        public D3D12DDI_VIDEO_ENCODER_CODEC_CONFIGURATION_0082_0 CodecConfiguration;
        public D3D12DDI_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE_0080 MaxMotionEstimationPrecision;
    }
}
