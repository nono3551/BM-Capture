﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(999,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_1
    {
        public uint PreemptionFenceId;
        public uint LastCompletedFenceId;
        public uint NodeOrdinal;
        public uint EngineOrdinal;
    }
}
