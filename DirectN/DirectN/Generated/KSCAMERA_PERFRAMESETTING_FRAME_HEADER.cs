﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(6446,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSCAMERA_PERFRAMESETTING_FRAME_HEADER
    {
        public uint Size;
        public uint Id;
        public uint ItemCount;
        public uint Reserved;
    }
}
