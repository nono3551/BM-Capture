﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dtypes.h(941,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DPICKRECORD
    {
        public byte bOpcode;
        public byte bPad;
        public uint dwOffset;
        public float dvZ;
    }
}
