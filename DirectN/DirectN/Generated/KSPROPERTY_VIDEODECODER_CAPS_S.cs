﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(5617,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_VIDEODECODER_CAPS_S
    {
        public KSIDENTIFIER Property;
        public uint StandardsSupported;
        public uint Capabilities;
        public uint SettlingTime;
        public uint HSyncPerVSync;
    }
}
