﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ocidl.h(1493,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagCONTROLINFO
    {
        public uint cb;
        public IntPtr hAccel;
        public ushort cAccel;
        public uint dwFlags;
    }
}
