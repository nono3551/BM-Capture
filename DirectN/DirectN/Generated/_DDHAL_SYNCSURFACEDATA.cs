﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddrawi.h(2768,9)
using System;
using System.Runtime.InteropServices;
using LPDDRAWI_DDRAWSURFACE_LCL = DirectN._DDRAWI_DDRAWSURFACE_LCL;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;

namespace DirectN
{
    /// <summary>
    /// **************************************************************************
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_SYNCSURFACEDATA
    {
        public uint dwSize;
        public IntPtr lpDD;
        public IntPtr lpDDSurface;
        public uint dwSurfaceOffset;
        public IntPtr fpLockPtr;
        public int lPitch;
        public uint dwOverlayOffset;
        public uint dwOverlaySrcWidth;
        public uint dwOverlaySrcHeight;
        public uint dwOverlayDestWidth;
        public uint dwOverlayDestHeight;
        public IntPtr dwDriverReserved1;
        public IntPtr dwDriverReserved2;
        public IntPtr dwDriverReserved3;
        public HRESULT ddRVal;
    }
}
