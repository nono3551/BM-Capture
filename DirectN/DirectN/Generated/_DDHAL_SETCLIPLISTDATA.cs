﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddrawi.h(2187,9)
using System;
using System.Runtime.InteropServices;
using LPDDHALSURFCB_SETCLIPLIST = System.IntPtr;
using LPDDRAWI_DDRAWSURFACE_LCL = DirectN._DDRAWI_DDRAWSURFACE_LCL;
using LPDDRAWI_DIRECTDRAW_GBL = DirectN._DDRAWI_DIRECTDRAW_GBL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_SETCLIPLISTDATA
    {
        public IntPtr lpDD;
        public IntPtr lpDDSurface;
        public HRESULT ddRVal;
        public IntPtr SetClipList;
    }
}
