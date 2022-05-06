﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(2124,1)
using System;

namespace DirectN
{
    [Flags]
    public enum D3D12_FORMAT_SUPPORT1
    {
        D3D12_FORMAT_SUPPORT1_NONE = 0x00000000,
        D3D12_FORMAT_SUPPORT1_BUFFER = 0x00000001,
        D3D12_FORMAT_SUPPORT1_IA_VERTEX_BUFFER = 0x00000002,
        D3D12_FORMAT_SUPPORT1_IA_INDEX_BUFFER = 0x00000004,
        D3D12_FORMAT_SUPPORT1_SO_BUFFER = 0x00000008,
        D3D12_FORMAT_SUPPORT1_TEXTURE1D = 0x00000010,
        D3D12_FORMAT_SUPPORT1_TEXTURE2D = 0x00000020,
        D3D12_FORMAT_SUPPORT1_TEXTURE3D = 0x00000040,
        D3D12_FORMAT_SUPPORT1_TEXTURECUBE = 0x00000080,
        D3D12_FORMAT_SUPPORT1_SHADER_LOAD = 0x00000100,
        D3D12_FORMAT_SUPPORT1_SHADER_SAMPLE = 0x00000200,
        D3D12_FORMAT_SUPPORT1_SHADER_SAMPLE_COMPARISON = 0x00000400,
        D3D12_FORMAT_SUPPORT1_SHADER_SAMPLE_MONO_TEXT = 0x00000800,
        D3D12_FORMAT_SUPPORT1_MIP = 0x00001000,
        D3D12_FORMAT_SUPPORT1_RENDER_TARGET = 0x00004000,
        D3D12_FORMAT_SUPPORT1_BLENDABLE = 0x00008000,
        D3D12_FORMAT_SUPPORT1_DEPTH_STENCIL = 0x00010000,
        D3D12_FORMAT_SUPPORT1_MULTISAMPLE_RESOLVE = 0x00040000,
        D3D12_FORMAT_SUPPORT1_DISPLAY = 0x00080000,
        D3D12_FORMAT_SUPPORT1_CAST_WITHIN_BIT_LAYOUT = 0x00100000,
        D3D12_FORMAT_SUPPORT1_MULTISAMPLE_RENDERTARGET = 0x00200000,
        D3D12_FORMAT_SUPPORT1_MULTISAMPLE_LOAD = 0x00400000,
        D3D12_FORMAT_SUPPORT1_SHADER_GATHER = 0x00800000,
        D3D12_FORMAT_SUPPORT1_BACK_BUFFER_CAST = 0x01000000,
        D3D12_FORMAT_SUPPORT1_TYPED_UNORDERED_ACCESS_VIEW = 0x02000000,
        D3D12_FORMAT_SUPPORT1_SHADER_GATHER_COMPARISON = 0x04000000,
        D3D12_FORMAT_SUPPORT1_DECODER_OUTPUT = 0x08000000,
        D3D12_FORMAT_SUPPORT1_VIDEO_PROCESSOR_OUTPUT = 0x10000000,
        D3D12_FORMAT_SUPPORT1_VIDEO_PROCESSOR_INPUT = 0x20000000,
        D3D12_FORMAT_SUPPORT1_VIDEO_ENCODER = 0x40000000,
    }
}
