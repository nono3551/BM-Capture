﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(3657,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_UPDATEOVERLAY
    {
        public uint hKernelOverlay;
        public _D3DDDI_KERNELOVERLAYINFO OverlayInfo;
    }
}
