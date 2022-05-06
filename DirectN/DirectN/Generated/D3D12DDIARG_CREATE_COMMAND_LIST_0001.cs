﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(1436,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATE_COMMAND_LIST_0001
    {
        public D3D12DDI_HCOMMANDLIST hDrvCommandList;
        public D3D12DDI_HRTCOMMANDLIST hRTCommandList;
        public D3D12DDI_HCOMMANDALLOCATOR hDrvCommandAllocator;
        public D3D12DDI_COMMAND_LIST_TYPE Type;
        public D3D12DDI_COMMAND_QUEUE_FLAGS QueueFlags;
        public ulong ID;
        public D3D12DDI_COMMAND_LIST_FLAGS CommandListFlags;
        public uint NodeMask;
    }
}
