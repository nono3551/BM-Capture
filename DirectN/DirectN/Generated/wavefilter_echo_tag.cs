﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\mmreg.h(3477,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct wavefilter_echo_tag
    {
        public wavefilter_tag wfltr;
        public uint dwVolume;
        public uint dwDelay;
    }
}
