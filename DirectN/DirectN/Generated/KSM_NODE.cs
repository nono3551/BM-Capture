﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ks.h(160,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSM_NODE
    {
        public KSIDENTIFIER Method;
        public uint NodeId;
        public uint Reserved;
    }
}
