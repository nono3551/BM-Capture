﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(8375,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _KSAUDIOMODULE_PROPERTY
    {
        public int Property;
        public Guid ClassId;
        public uint InstanceId;
    }
}
