﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(21167,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_MEMCPY_DEST
    {
        public IntPtr pData;
        public IntPtr RowPitch;
        public IntPtr SlicePitch;
    }
}
