﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxgiddi.h(402,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_DDI_MULTIPLANE_OVERLAY_ATTRIBUTES
    {
        public uint Flags;
        public tagRECT SrcRect;
        public tagRECT DstRect;
        public tagRECT ClipRect;
        public DXGI_DDI_MODE_ROTATION Rotation;
        public DXGI_DDI_MULTIPLANE_OVERLAY_BLEND Blend;
        public uint DirtyRectCount;
        public IntPtr pDirtyRects;
        public DXGI_DDI_MULTIPLANE_OVERLAY_VIDEO_FRAME_FORMAT VideoFrameFormat;
        public uint YCbCrFlags;
        public DXGI_DDI_MULTIPLANE_OVERLAY_STEREO_FORMAT StereoFormat;
        public bool StereoLeftViewFrame0;
        public bool StereoBaseViewFrame0;
        public DXGI_DDI_MULTIPLANE_OVERLAY_STEREO_FLIP_MODE StereoFlipMode;
        public DXGI_DDI_MULTIPLANE_OVERLAY_STRETCH_QUALITY StretchQuality;
    }
}
