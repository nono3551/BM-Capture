﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12video.h(329,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_DECODER_HEAP_DESC
    {
        public uint NodeMask;
        public D3D12_VIDEO_DECODE_CONFIGURATION Configuration;
        public uint DecodeWidth;
        public uint DecodeHeight;
        public DXGI_FORMAT Format;
        public DXGI_RATIONAL FrameRate;
        public uint BitRate;
        public uint MaxDecodePictureBufferCount;
    }
}
