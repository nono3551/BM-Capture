﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(1957,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_GPUMMU_CAPS
    {
        public _D3DKMT_GPUMMU_CAPS__union_0 Flags;
        public uint VirtualAddressBitCount;
    }
}
