﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxvahd.h(333,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHD_FILTER_RANGE_DATA
    {
        public int Minimum;
        public int Maximum;
        public int Default;
        public float Multiplier;
    }
}
