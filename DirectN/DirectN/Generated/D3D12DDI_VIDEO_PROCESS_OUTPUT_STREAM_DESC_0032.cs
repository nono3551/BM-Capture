﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(10958,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_PROCESS_OUTPUT_STREAM_DESC_0032
    {
        public DXGI_FORMAT Format;
        public DXGI_COLOR_SPACE_TYPE ColorSpace;
        public D3D12DDI_VIDEO_PROCESS_ALPHA_FILL_MODE_0020 AlphaFillMode;
        public uint AlphaFillModeSourceStreamIndex;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public float[] BackgroundColor;
        public DXGI_RATIONAL FrameRate;
        public bool EnableStereo;
    }
}
