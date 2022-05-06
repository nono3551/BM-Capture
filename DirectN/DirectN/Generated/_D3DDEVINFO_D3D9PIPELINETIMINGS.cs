﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3d9types.h(1940,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DDEVINFO_D3D9PIPELINETIMINGS
    {
        public float VertexProcessingTimePercent;
        public float PixelProcessingTimePercent;
        public float OtherGPUProcessingTimePercent;
        public float GPUIdleTimePercent;
    }
}
