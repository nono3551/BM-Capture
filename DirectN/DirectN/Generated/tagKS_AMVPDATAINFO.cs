﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(7656,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKS_AMVPDATAINFO
    {
        public uint dwSize;
        public uint dwMicrosecondsPerField;
        public tagKS_AMVPDIMINFO amvpDimInfo;
        public uint dwPictAspectRatioX;
        public uint dwPictAspectRatioY;
        public bool bEnableDoubleClock;
        public bool bEnableVACT;
        public bool bDataIsInterlaced;
        public int lHalfLinesOdd;
        public bool bFieldPolarityInverted;
        public uint dwNumLinesInVREF;
        public int lHalfLinesEven;
        public uint dwReserved1;
    }
}
