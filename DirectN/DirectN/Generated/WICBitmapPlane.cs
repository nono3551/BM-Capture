﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wincodec.h(1078,24)
using System;
using System.Runtime.InteropServices;
using WICPixelFormatGUID = System.Guid;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct WICBitmapPlane
    {
        public WICPixelFormatGUID Format;
        public IntPtr pbBuffer;
        public uint cbStride;
        public uint cbBufferSize;
    }
}
