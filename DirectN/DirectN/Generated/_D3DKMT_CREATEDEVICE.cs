﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(44,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_CREATEDEVICE
    {
        public _D3DKMT_CREATEDEVICE__union_0 __union_0;
        public _D3DKMT_CREATEDEVICEFLAGS Flags;
        public uint hDevice;
        public IntPtr pCommandBuffer;
        public uint CommandBufferSize;
        public IntPtr pAllocationList;
        public uint AllocationListSize;
        public IntPtr pPatchLocationList;
        public uint PatchLocationListSize;
    }
}
