﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\mmreg.h(2731,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct g723_adpcmwaveformat_tag
    {
        public tWAVEFORMATEX wfx;
        public ushort cbExtraSize;
        public ushort nAuxBlockSize;
    }
}
