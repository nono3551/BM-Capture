﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(8104,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _tagKSAUDIOENGINE_DESCRIPTOR
    {
        public uint nHostPinId;
        public uint nOffloadPinId;
        public uint nLoopbackPinId;
    }
}
