﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(6453,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSCAMERA_PERFRAMESETTING_HEADER
    {
        public uint Size;
        public uint FrameCount;
        public Guid Id;
        public ulong Flags;
        public uint LoopCount;
        public uint Reserved;
    }
}
