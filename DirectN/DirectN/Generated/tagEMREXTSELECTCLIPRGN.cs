﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wingdi.h(5827,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMREXTSELECTCLIPRGN
    {
        public tagEMR emr;
        public uint cbRgnData;
        public uint iMode;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public byte[] RgnData;
    }
}
