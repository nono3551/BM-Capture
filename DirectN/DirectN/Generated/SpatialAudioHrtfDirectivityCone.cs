﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\spatialaudiohrtf.h(120,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct SpatialAudioHrtfDirectivityCone
    {
        public SpatialAudioHrtfDirectivity directivity;
        public float InnerAngle;
        public float OuterAngle;
    }
}
