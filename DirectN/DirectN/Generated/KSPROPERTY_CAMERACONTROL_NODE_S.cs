﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(5734,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_CAMERACONTROL_NODE_S
    {
        public KSP_NODE NodeProperty;
        public int Value;
        public uint Flags;
        public uint Capabilities;
    }
}
