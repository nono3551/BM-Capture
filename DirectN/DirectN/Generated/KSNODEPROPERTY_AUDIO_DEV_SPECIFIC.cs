﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(2906,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSNODEPROPERTY_AUDIO_DEV_SPECIFIC
    {
        public KSNODEPROPERTY NodeProperty;
        public uint DevSpecificId;
        public uint DeviceInfo;
        public uint Length;
    }
}
