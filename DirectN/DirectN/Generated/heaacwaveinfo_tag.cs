﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\mmreg.h(3156,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct heaacwaveinfo_tag
    {
        public tWAVEFORMATEX wfx;
        public ushort wPayloadType;
        public ushort wAudioProfileLevelIndication;
        public ushort wStructType;
        public ushort wReserved1;
        public uint dwReserved2;
    }
}
