﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wingdi.h(5580,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMRRESIZEPALETTE
    {
        public tagEMR emr;
        public uint ihPal;
        public uint cEntries;
    }
}
