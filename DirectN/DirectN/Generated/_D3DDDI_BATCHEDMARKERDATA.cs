﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(3554,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_BATCHEDMARKERDATA
    {
        public IntPtr hRTCommandListHandle;
        public uint FirstAPISequenceNumberHigh;
        public uint CompletedAPISequenceNumberLowSize;
        public IntPtr pCompletedAPISequenceNumberLow;
    }
}
