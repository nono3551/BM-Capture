﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(3083,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_DEBUG_SNAPSHOT_ESCAPE
    {
        public uint Length;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public byte[] Buffer;
    }
}
