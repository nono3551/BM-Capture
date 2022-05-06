﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11shadertracing.h(190,1)
using System;

namespace DirectN
{
    [Flags]
    public enum D3D11_TRACE_REGISTER_TYPE
    {
        D3D11_TRACE_OUTPUT_NULL_REGISTER = 0x00000000,
        D3D11_TRACE_INPUT_REGISTER = 0x00000001,
        D3D11_TRACE_INPUT_PRIMITIVE_ID_REGISTER = 0x00000002,
        D3D11_TRACE_IMMEDIATE_CONSTANT_BUFFER = 0x00000003,
        D3D11_TRACE_TEMP_REGISTER = 0x00000004,
        D3D11_TRACE_INDEXABLE_TEMP_REGISTER = 0x00000005,
        D3D11_TRACE_OUTPUT_REGISTER = 0x00000006,
        D3D11_TRACE_OUTPUT_DEPTH_REGISTER = 0x00000007,
        D3D11_TRACE_CONSTANT_BUFFER = 0x00000008,
        D3D11_TRACE_IMMEDIATE32 = 0x00000009,
        D3D11_TRACE_SAMPLER = 0x0000000A,
        D3D11_TRACE_RESOURCE = 0x0000000B,
        D3D11_TRACE_RASTERIZER = 0x0000000C,
        D3D11_TRACE_OUTPUT_COVERAGE_MASK = 0x0000000D,
        D3D11_TRACE_STREAM = 0x0000000E,
        D3D11_TRACE_THIS_POINTER = 0x0000000F,
        D3D11_TRACE_OUTPUT_CONTROL_POINT_ID_REGISTER = 0x00000010,
        D3D11_TRACE_INPUT_FORK_INSTANCE_ID_REGISTER = 0x00000011,
        D3D11_TRACE_INPUT_JOIN_INSTANCE_ID_REGISTER = 0x00000012,
        D3D11_TRACE_INPUT_CONTROL_POINT_REGISTER = 0x00000013,
        D3D11_TRACE_OUTPUT_CONTROL_POINT_REGISTER = 0x00000014,
        D3D11_TRACE_INPUT_PATCH_CONSTANT_REGISTER = 0x00000015,
        D3D11_TRACE_INPUT_DOMAIN_POINT_REGISTER = 0x00000016,
        D3D11_TRACE_UNORDERED_ACCESS_VIEW = 0x00000017,
        D3D11_TRACE_THREAD_GROUP_SHARED_MEMORY = 0x00000018,
        D3D11_TRACE_INPUT_THREAD_ID_REGISTER = 0x00000019,
        D3D11_TRACE_INPUT_THREAD_GROUP_ID_REGISTER = 0x0000001A,
        D3D11_TRACE_INPUT_THREAD_ID_IN_GROUP_REGISTER = 0x0000001B,
        D3D11_TRACE_INPUT_COVERAGE_MASK_REGISTER = 0x0000001C,
        D3D11_TRACE_INPUT_THREAD_ID_IN_GROUP_FLATTENED_REGISTER = 0x0000001D,
        D3D11_TRACE_INPUT_GS_INSTANCE_ID_REGISTER = 0x0000001E,
        D3D11_TRACE_OUTPUT_DEPTH_GREATER_EQUAL_REGISTER = 0x0000001F,
        D3D11_TRACE_OUTPUT_DEPTH_LESS_EQUAL_REGISTER = 0x00000020,
        D3D11_TRACE_IMMEDIATE64 = 0x00000021,
        D3D11_TRACE_INPUT_CYCLE_COUNTER_REGISTER = 0x00000022,
        D3D11_TRACE_INTERFACE_POINTER = 0x00000023,
    }
}