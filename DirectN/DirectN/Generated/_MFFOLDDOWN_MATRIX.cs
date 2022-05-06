﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfapi.h(2840,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFFOLDDOWN_MATRIX
    {
        public uint cbSize;
        public uint cSrcChannels;
        public uint cDstChannels;
        public uint dwChannelMask;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public int[] Coeff;
    }
}
