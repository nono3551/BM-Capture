﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ks.h(166,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSE_NODE
    {
        public KSIDENTIFIER Event;
        public uint NodeId;
        public uint Reserved;
    }
}