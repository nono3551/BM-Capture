﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(1975,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11DDIARG_STREAM_OUTPUT_DECLARATION_ENTRY
    {
        public uint Stream;
        public uint OutputSlot;
        public uint RegisterIndex;
        public byte RegisterMask;
    }
}
