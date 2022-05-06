﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(1381,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_OVERLAYINFO
    {
        public IntPtr hResource;
        public uint SubResourceIndex;
        public tagRECT DstRect;
        public tagRECT SrcRect;
        public uint DstColorKeyLow;
        public uint DstColorKeyHigh;
        public uint SrcColorKeyLow;
        public uint SrcColorKeyHigh;
        public _D3DDDI_OVERLAYINFOFLAGS Flags;
    }
}
