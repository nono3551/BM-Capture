﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dhal.h(538,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_TEXTURESWAPDATA
    {
        public IntPtr dwhContext;
        public uint dwHandle1;
        public uint dwHandle2;
        public HRESULT ddrval;
    }
}
