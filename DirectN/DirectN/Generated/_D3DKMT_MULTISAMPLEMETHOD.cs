﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(311,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_MULTISAMPLEMETHOD
    {
        public uint NumSamples;
        public uint NumQualityLevels;
        public uint Reserved;
    }
}
