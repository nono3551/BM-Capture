﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(3483,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_ALLOCATIONUSAGEHINT
    {
        public uint Version;
        public _DXGK_ALLOCATIONUSAGEINFO1 v1;
    }
}
