﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dmemmgr.h(100,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _VMEML
    {
        public IntPtr next;
        public ulong ptr;
        public uint size;
        public bool bDiscardable;
    }
}
