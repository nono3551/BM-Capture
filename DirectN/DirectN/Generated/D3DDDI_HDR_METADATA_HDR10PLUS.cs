﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dukmdt.h(1011,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DDDI_HDR_METADATA_HDR10PLUS
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 72)] 
        public byte[] Data;
    }
}
