﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dtypes.h(924,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DINSTRUCTION
    {
        public byte bOpcode;
        public byte bSize;
        public ushort wCount;
    }
}
