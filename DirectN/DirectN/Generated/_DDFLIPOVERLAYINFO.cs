﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxmini.h(225,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDFLIPOVERLAYINFO
    {
        public IntPtr lpCurrentSurface;
        public IntPtr lpTargetSurface;
        public uint dwFlags;
    }
}
