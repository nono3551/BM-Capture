﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(1421,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATECOMMANDQUEUE_0001
    {
        public D3D12DDI_HCOMMANDQUEUE hDrvCommandQueue;
        public D3D12DDI_HRTCOMMANDQUEUE hRTCommandQueue;
        public D3D12DDI_COMMAND_QUEUE_FLAGS QueueFlags;
        public uint NodeMask;
    }
}
