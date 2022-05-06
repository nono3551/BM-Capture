﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(2553,9)
using System;
using System.Runtime.InteropServices;
using PHYSICAL_ADDRESS = System.Int64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_SEGMENTDESCRIPTOR2
    {
        public _DXGK_SEGMENTFLAGS2 Flags;
        public IntPtr Size;
        public IntPtr pMdl;
        public PHYSICAL_ADDRESS BaseAddress;
        public PHYSICAL_ADDRESS CpuTranslatedAddress;
    }
}
