﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(4570,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_PROCESS_REFERENCES_INFO_0020
    {
        public uint NumPastFrames;
        public IntPtr hDrvPastFrames;
        public IntPtr pPastSubresources;
        public uint NumFutureFrames;
        public IntPtr hDrvFutureFrames;
        public IntPtr pFutureSubresources;
    }
}
