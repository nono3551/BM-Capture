﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wingdi.h(2911,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DISPLAYCONFIG_SOURCE_MODE
    {
        public uint width;
        public uint height;
        public DISPLAYCONFIG_PIXELFORMAT pixelFormat;
        public _POINTL position;
    }
}
