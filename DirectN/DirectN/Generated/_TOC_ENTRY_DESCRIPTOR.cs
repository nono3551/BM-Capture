﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmcodecdsp.h(3964,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _TOC_ENTRY_DESCRIPTOR
    {
        public ulong qwStartTime;
        public ulong qwEndTime;
        public ulong qwStartPacketOffset;
        public ulong qwEndPacketOffset;
        public ulong qwRepresentativeFrameTime;
    }
}
