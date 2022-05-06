﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxgiddi.h(506,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_DDI_ARG_PRESENT1
    {
        public ulong hDevice;
        public IntPtr phSurfacesToPresent;
        public uint SurfacesToPresent;
        public ulong hDstResource;
        public uint DstSubResourceIndex;
        public IntPtr pDXGIContext;
        public DXGI_DDI_PRESENT_FLAGS Flags;
        public DXGI_DDI_FLIP_INTERVAL_TYPE FlipInterval;
        public uint Reserved;
        public IntPtr pDirtyRects;
        public uint DirtyRects;
        public uint BackBufferMultiplicity;
    }
}
