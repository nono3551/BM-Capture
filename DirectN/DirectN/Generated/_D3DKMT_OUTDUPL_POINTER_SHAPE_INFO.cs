﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(4508,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_OUTDUPL_POINTER_SHAPE_INFO
    {
        public _D3DKMT_OUTDUPL_POINTER_SHAPE_TYPE Type;
        public uint Width;
        public uint Height;
        public uint Pitch;
        public tagPOINT HotSpot;
    }
}
