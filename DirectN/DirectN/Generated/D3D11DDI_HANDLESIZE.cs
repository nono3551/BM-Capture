﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(2053,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11DDI_HANDLESIZE
    {
        public D3D11DDI_HANDLETYPE HandleType;
        public IntPtr DriverPrivateSize;
    }
}
