﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(11236,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS_0041
    {
        public D3D10DDI_HRESOURCE hDrvOutputTexture2D;
        public uint OutputSubresource;
        public D3D12DDI_VIDEO_DECODE_CONVERSION_ARGUMENTS_0021 ConversionArguments;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public D3D12DDI_VIDEO_DECODE_COMPONENT_HISTOGRAM_0041[] Histograms;
    }
}
