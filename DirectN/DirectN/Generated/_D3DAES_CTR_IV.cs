﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3d9types.h(2433,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DAES_CTR_IV
    {
        public ulong IV;
        public ulong Count;
    }
}