﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mftransform.h(1354,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFT_STREAM_STATE_PARAM
    {
        public uint StreamId;
        public _MF_STREAM_STATE State;
    }
}
