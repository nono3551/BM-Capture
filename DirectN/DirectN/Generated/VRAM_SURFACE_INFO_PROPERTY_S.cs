﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(4999,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct VRAM_SURFACE_INFO_PROPERTY_S
    {
        public KSIDENTIFIER Property;
        public IntPtr pVramSurfaceInfo;
    }
}
