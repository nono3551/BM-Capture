﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11.h(6779,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_QUERY_DATA_TIMESTAMP_DISJOINT
    {
        public ulong Frequency;
        public bool Disjoint;
    }
}
