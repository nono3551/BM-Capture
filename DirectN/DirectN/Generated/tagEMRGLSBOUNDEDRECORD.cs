﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wingdi.h(6082,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMRGLSBOUNDEDRECORD
    {
        public tagEMR emr;
        public _RECTL rclBounds;
        public uint cbData;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public byte[] Data;
    }
}
