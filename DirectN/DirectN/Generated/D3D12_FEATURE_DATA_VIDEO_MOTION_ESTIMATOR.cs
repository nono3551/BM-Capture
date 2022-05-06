﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12video.h(2714,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_VIDEO_MOTION_ESTIMATOR
    {
        public uint NodeIndex;
        public DXGI_FORMAT InputFormat;
        public D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE_FLAGS BlockSizeFlags;
        public D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_FLAGS PrecisionFlags;
        public D3D12_VIDEO_SIZE_RANGE SizeRange;
    }
}
