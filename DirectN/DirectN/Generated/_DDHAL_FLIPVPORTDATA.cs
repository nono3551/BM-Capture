﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddrawi.h(2439,9)
using System;
using System.Runtime.InteropServices;
using LPDDHALVPORTCB_FLIP = System.IntPtr;
using LPDDRAWI_DDRAWSURFACE_LCL = DirectN._DDRAWI_DDRAWSURFACE_LCL;
using LPDDRAWI_DDVIDEOPORT_LCL = DirectN._DDRAWI_DDVIDEOPORT_LCL;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_FLIPVPORTDATA
    {
        public IntPtr lpDD;
        public IntPtr lpVideoPort;
        public IntPtr lpSurfCurr;
        public IntPtr lpSurfTarg;
        public HRESULT ddRVal;
        public IntPtr FlipVideoPort;
    }
}
