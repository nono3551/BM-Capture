﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(8951,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct AM_STREAM_INFO
    {
        public long tStart;
        public long tStop;
        public uint dwStartCookie;
        public uint dwStopCookie;
        public uint dwFlags;
    }
}
