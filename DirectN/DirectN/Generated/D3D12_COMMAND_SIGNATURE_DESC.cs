﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(4121,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_COMMAND_SIGNATURE_DESC
    {
        public uint ByteStride;
        public uint NumArgumentDescs;
        public IntPtr pArgumentDescs;
        public uint NodeMask;
    }
}
