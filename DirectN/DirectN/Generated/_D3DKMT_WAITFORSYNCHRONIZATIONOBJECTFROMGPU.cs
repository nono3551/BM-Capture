﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(4669,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_WAITFORSYNCHRONIZATIONOBJECTFROMGPU
    {
        public uint hContext;
        public uint ObjectCount;
        public IntPtr ObjectHandleArray;
        public _D3DKMT_WAITFORSYNCHRONIZATIONOBJECTFROMGPU__union_0 __union_3;
    }
}
