﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wincodecsdk.h(1406,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct WICMetadataPattern
    {
        public ulong Position;
        public uint Length;
        public IntPtr Pattern;
        public IntPtr Mask;
        public ulong DataOffset;
    }
}
