﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wingdi.h(6064,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMRFORMAT
    {
        public uint dSignature;
        public uint nVersion;
        public uint cbData;
        public uint offData;
    }
}
