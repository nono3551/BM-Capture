﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddrawi.h(1290,9)
using System;
using System.Runtime.InteropServices;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _ACCESSRECTLIST
    {
        public IntPtr lpLink;
        public tagRECT rDest;
        public IntPtr lpOwner;
        public IntPtr lpSurfaceData;
        public uint dwFlags;
        public IntPtr lpHeapAliasInfo;
    }
}
