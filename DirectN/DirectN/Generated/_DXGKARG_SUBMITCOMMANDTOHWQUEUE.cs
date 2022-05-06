﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(4686,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_SUBMITCOMMANDTOHWQUEUE
    {
        public IntPtr hHwQueue;
        public ulong HwQueueProgressFenceId;
        public ulong DmaBufferVirtualAddress;
        public uint DmaBufferSize;
        public uint DmaBufferPrivateDataSize;
        public IntPtr pDmaBufferPrivateData;
        public _DXGK_SUBMITCOMMANDFLAGS Flags;
        public ulong HwQueueProgressFenceGpuVa;
        public IntPtr HwQueueProgressFenceCpuVa;
    }
}
