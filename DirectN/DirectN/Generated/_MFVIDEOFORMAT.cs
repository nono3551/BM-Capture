﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfobjects.h(3065,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFVIDEOFORMAT
    {
        public uint dwSize;
        public _MFVideoInfo videoInfo;
        public Guid guidFormat;
        public _MFVideoCompressedInfo compressedInfo;
        public _MFVideoSurfaceInfo surfaceInfo;
    }
}
