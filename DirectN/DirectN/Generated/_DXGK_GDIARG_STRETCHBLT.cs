﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(516,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_GDIARG_STRETCHBLT
    {
        public tagRECT SrcRect;
        public tagRECT DstRect;
        public uint DstAllocationIndex;
        public uint SrcAllocationIndex;
        public uint NumSubRects;
        public IntPtr pSubRects;
        public _DXGK_GDIARG_STRETCHBLT__union_0 __union_6;
        public uint SrcPitch;
    }
}
