﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxgiddi.h(900,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGIDDICB_PRESENT_MULTIPLANE_OVERLAY1
    {
        public IntPtr pDXGIContext;
        public uint PresentPlaneCount;
        public IntPtr ppPresentPlanes;
    }
}
