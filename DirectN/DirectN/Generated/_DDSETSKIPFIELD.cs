﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddkmapi.h(199,13)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDSETSKIPFIELD
    {
        public IntPtr hDirectDraw;
        public IntPtr hVideoPort;
        public uint dwStartField;
    }
}
