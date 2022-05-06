﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(1305,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSDS3D_ITD_PARAMS
    {
        public int Channel;
        public float VolSmoothScale;
        public float TotalDryAttenuation;
        public float TotalWetAttenuation;
        public int SmoothFrequency;
        public int Delay;
    }
}
