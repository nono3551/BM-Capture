﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(1121,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_SETDECODERENDERTARGET
    {
        public IntPtr hDecode;
        public IntPtr hRenderTarget;
        public uint SubResourceIndex;
    }
}
