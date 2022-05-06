﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(546,9)
using System;

namespace DirectN
{
    [Flags]
    public enum D3D12DDI_RESOURCE_OPTIMIZATION_FLAGS
    {
        D3D12DDI_RESOURCE_OPTIMIZATION_FLAG_NONE = 0x00000000,
        D3D12DDI_RESOURCE_OPTIMIZATION_FLAG_SHADER_RESOURCE = 0x00000001,
        D3D12DDI_RESOURCE_OPTIMIZATION_FLAG_UNORDERED_ACCESS = 0x00000002,
        D3D12DDI_RESOURCE_OPTIMIZATION_FLAG_PRIMARY = 0x00000004,
        D3D12DDI_RESOURCE_OPTIMIZATION_FLAG_DETERMINISTIC = 0x00000008,
    }
}
