﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(12393,9)
using System;

namespace DirectN
{
    [Flags]
    public enum D3D12DDI_VIDEO_ENCODER_SUPPORT_FLAGS_0080
    {
        D3D12DDI_VIDEO_ENCODER_SUPPORT_FLAG_0080_NONE = 0x00000000,
        D3D12DDI_VIDEO_ENCODER_SUPPORT_FLAG_0080_GENERAL_SUPPORT_OK = 0x00000001,
        D3D12DDI_VIDEO_ENCODER_SUPPORT_FLAG_0080_RATE_CONTROL_RECONFIGURATION_AVAILABLE = 0x00000002,
        D3D12DDI_VIDEO_ENCODER_SUPPORT_FLAG_0080_RESOLUTION_RECONFIGURATION_AVAILABLE = 0x00000004,
        D3D12DDI_VIDEO_ENCODER_SUPPORT_FLAG_0080_RATE_CONTROL_VBV_SIZE_CONFIG_AVAILABLE = 0x00000008,
        D3D12DDI_VIDEO_ENCODER_SUPPORT_FLAG_0080_RATE_CONTROL_FRAME_ANALYSIS_AVAILABLE = 0x00000010,
        D3D12DDI_VIDEO_ENCODER_SUPPORT_FLAG_0080_RECONSTRUCTED_FRAMES_REQUIRE_CONTIGUOUS_TEXTURE_ARRAYS = 0x00000020,
        D3D12DDI_VIDEO_ENCODER_SUPPORT_FLAG_0080_2_RATE_CONTROL_DELTA_QP_AVAILABLE = 0x00000040,
        D3D12DDI_VIDEO_ENCODER_SUPPORT_FLAG_0080_2_SUBREGION_LAYOUT_RECONFIGURATION_AVAILABLE = 0x00000080,
        D3D12DDI_VIDEO_ENCODER_SUPPORT_FLAG_0080_2_RATE_CONTROL_ADJUSTABLE_QP_RANGE_AVAILABLE = 0x00000100,
        D3D12DDI_VIDEO_ENCODER_SUPPORT_FLAG_0080_2_RATE_CONTROL_INITIAL_QP_AVAILABLE = 0x00000200,
        D3D12DDI_VIDEO_ENCODER_SUPPORT_FLAG_0080_2_RATE_CONTROL_MAX_FRAME_SIZE_AVAILABLE = 0x00000400,
    }
}
