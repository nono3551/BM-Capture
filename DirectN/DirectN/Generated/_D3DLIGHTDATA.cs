﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dtypes.h(865,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DLIGHTDATA
    {
        public uint dwSize;
        public IntPtr lpIn;
        public uint dwInSize;
        public IntPtr lpOut;
        public uint dwOutSize;
    }
}
