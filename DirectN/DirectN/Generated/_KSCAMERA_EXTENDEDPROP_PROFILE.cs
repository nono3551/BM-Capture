﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(6612,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _KSCAMERA_EXTENDEDPROP_PROFILE
    {
        public Guid ProfileId;
        public uint Index;
        public uint Reserved;
    }
}
