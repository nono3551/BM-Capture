﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dukmdt.h(263,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DGPU_PHYSICAL_ADDRESS
    {
        public uint SegmentId;
        public ulong SegmentOffset;
    }
}
