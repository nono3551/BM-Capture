﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(3849,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DDDICB_SIGNALSYNCHRONIZATIONOBJECTFROMCPU
    {
        public uint ObjectCount;
        public IntPtr ObjectHandleArray;
        public IntPtr FenceValueArray;
    }
}
