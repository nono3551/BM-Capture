﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddrawi.h(1340,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDRAWI_DDRAWSURFACE_GBL
    {
        public uint dwRefCnt;
        public uint dwGlobalFlags;
        public _DDRAWI_DDRAWSURFACE_GBL__union_0 __union_2;
        public _DDRAWI_DDRAWSURFACE_GBL__union_1 __union_3;
        public _DDRAWI_DDRAWSURFACE_GBL__union_2 __union_4;
        public ulong fpVidMem;
        public _DDRAWI_DDRAWSURFACE_GBL__union_3 __union_6;
        public ushort wHeight;
        public ushort wWidth;
        public uint dwUsageCount;
        public IntPtr dwReserved1;
        public _DDPIXELFORMAT ddpfSurface;
    }
}
