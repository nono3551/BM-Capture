﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wingdi.h(5609,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMREOF
    {
        public tagEMR emr;
        public uint nPalEntries;
        public uint offPalEntries;
        public uint nSizeLast;
    }
}
