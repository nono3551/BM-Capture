﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(2747,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_MULTIPLANE_OVERLAY_ATTRIBUTES
    {
        public uint Flags;
        public tagRECT SrcRect;
        public tagRECT DstRect;
        public tagRECT ClipRect;
        public _D3DDDI_ROTATION Rotation;
        public _D3DDDI_MULTIPLANE_OVERLAY_BLEND Blend;
        public uint DirtyRectCount;
        public IntPtr pDirtyRects;
        public D3DDDI_MULTIPLANE_OVERLAY_VIDEO_FRAME_FORMAT VideoFrameFormat;
        public uint YCbCrFlags;
        public D3DDDI_MULTIPLANE_OVERLAY_STRETCH_QUALITY StretchQuality;
    }
}
