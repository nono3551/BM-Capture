﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(4623,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _CC_BYTE_PAIR
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public byte[] Decoded;
        public ushort Reserved;
    }
}
