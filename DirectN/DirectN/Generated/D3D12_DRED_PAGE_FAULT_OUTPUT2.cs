﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(14350,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_DRED_PAGE_FAULT_OUTPUT2
    {
        public ulong PageFaultVA;
        public IntPtr pHeadExistingAllocationNode;
        public IntPtr pHeadRecentFreedAllocationNode;
        public D3D12_DRED_PAGE_FAULT_FLAGS PageFaultFlags;
    }
}
