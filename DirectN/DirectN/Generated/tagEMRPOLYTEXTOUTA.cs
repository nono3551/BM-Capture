﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wingdi.h(5847,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMRPOLYTEXTOUTA
    {
        public tagEMR emr;
        public _RECTL rclBounds;
        public uint iGraphicsMode;
        public float exScale;
        public float eyScale;
        public int cStrings;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public tagEMRTEXT[] aemrtext;
    }
}
