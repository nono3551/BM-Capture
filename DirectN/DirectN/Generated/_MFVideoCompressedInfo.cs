﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfobjects.h(3058,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFVideoCompressedInfo
    {
        public long AvgBitrate;
        public long AvgBitErrorRate;
        public uint MaxKeyFrameSpacing;
    }
}
