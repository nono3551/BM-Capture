﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(4024,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_QUERY_DATA_SO_STATISTICS
    {
        public ulong NumPrimitivesWritten;
        public ulong PrimitivesStorageNeeded;
    }
}
