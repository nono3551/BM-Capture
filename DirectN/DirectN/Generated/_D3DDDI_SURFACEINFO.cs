﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dukmdt.h(1173,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_SURFACEINFO
    {
        public uint Width;
        public uint Height;
        public uint Depth;
        public IntPtr pSysMem;
        public uint SysMemPitch;
        public uint SysMemSlicePitch;
    }
}
