﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(1476,9)
using System;

namespace DirectN
{
    [Flags]
    public enum D3D12DDI_RESOURCE_BARRIER_FLAGS
    {
        D3D12DDI_RESOURCE_BARRIER_FLAG_NONE = 0x00000000,
        D3D12DDI_RESOURCE_BARRIER_FLAG_BEGIN_ONLY = 0x00000001,
        D3D12DDI_RESOURCE_BARRIER_FLAG_END_ONLY = 0x00000002,
        D3D12DDI_RESOURCE_BARRIER_FLAG_0022_ATOMIC_COPY = 0x00000004,
        D3D12DDI_RESOURCE_BARRIER_FLAG_0022_ALIASING = 0x00000008,
    }
}