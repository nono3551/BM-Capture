﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10.h(1920,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10_TEXTURE1D_DESC
    {
        public uint Width;
        public uint MipLevels;
        public uint ArraySize;
        public DXGI_FORMAT Format;
        public D3D10_USAGE Usage;
        public uint BindFlags;
        public uint CPUAccessFlags;
        public uint MiscFlags;
    }
}
