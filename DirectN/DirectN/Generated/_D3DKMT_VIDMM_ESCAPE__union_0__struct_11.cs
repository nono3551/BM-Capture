﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(2804,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_VIDMM_ESCAPE__union_0__struct_11
    {
        public uint hPagingQueue;
        public uint PhysicalAdapterIndex;
        public uint Milliseconds;
        public ulong PagingFenceValue;
    }
}
