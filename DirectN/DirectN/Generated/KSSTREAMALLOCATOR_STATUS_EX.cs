﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ks.h(2015,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSSTREAMALLOCATOR_STATUS_EX
    {
        public KSALLOCATOR_FRAMING_EX Framing;
        public uint AllocatedFrames;
        public uint Reserved;
    }
}
