﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ks.h(1134,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPIN_CONNECT
    {
        public KSIDENTIFIER Interface;
        public KSIDENTIFIER Medium;
        public uint PinId;
        public IntPtr PinToHandle;
        public KSPRIORITY Priority;
    }
}
