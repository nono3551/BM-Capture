﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(4582,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _VBICODECFILTERING_SCANLINES
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] 
        public uint[] DwordBitArray;
    }
}
