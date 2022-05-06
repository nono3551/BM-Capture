﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(2365,1)
using System;

namespace DirectN
{
    [Flags]
    public enum D3D12_COMMAND_LIST_SUPPORT_FLAGS
    {
        D3D12_COMMAND_LIST_SUPPORT_FLAG_NONE = 0x00000000,
        D3D12_COMMAND_LIST_SUPPORT_FLAG_DIRECT = 0x00000001,
        D3D12_COMMAND_LIST_SUPPORT_FLAG_BUNDLE = 0x00000002,
        D3D12_COMMAND_LIST_SUPPORT_FLAG_COMPUTE = 0x00000004,
        D3D12_COMMAND_LIST_SUPPORT_FLAG_COPY = 0x00000008,
        D3D12_COMMAND_LIST_SUPPORT_FLAG_VIDEO_DECODE = 0x00000010,
        D3D12_COMMAND_LIST_SUPPORT_FLAG_VIDEO_PROCESS = 0x00000020,
        D3D12_COMMAND_LIST_SUPPORT_FLAG_VIDEO_ENCODE = 0x00000040,
    }
}
