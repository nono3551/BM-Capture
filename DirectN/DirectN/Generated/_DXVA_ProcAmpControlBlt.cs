﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxva.h(2312,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_ProcAmpControlBlt
    {
        public uint Size;
        public tagRECT DstRect;
        public tagRECT SrcRect;
        public float Alpha;
        public float Brightness;
        public float Contrast;
        public float Hue;
        public float Saturation;
    }
}
