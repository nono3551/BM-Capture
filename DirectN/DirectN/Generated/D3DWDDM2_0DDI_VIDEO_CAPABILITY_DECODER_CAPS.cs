﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(4123,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DWDDM2_0DDI_VIDEO_CAPABILITY_DECODER_CAPS
    {
        public Guid DecodeProfile;
        public uint SampleWidth;
        public uint SampleHeight;
        public DXGI_RATIONAL FrameRate;
        public uint BitRate;
        public IntPtr pCryptoType;
        public uint Caps;
    }
}
