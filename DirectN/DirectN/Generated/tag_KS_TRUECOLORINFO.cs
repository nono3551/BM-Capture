﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(3985,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tag_KS_TRUECOLORINFO
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)] 
        public uint[] dwBitMasks;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)] 
        public tagKS_RGBQUAD[] bmiColors;
    }
}
