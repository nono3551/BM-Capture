﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(3422,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_GETMULTISAMPLEMETHODLIST
    {
        public uint VidPnSourceId;
        public uint Width;
        public uint Height;
        public _D3DDDIFORMAT Format;
        public IntPtr pMethodList;
        public uint MethodCount;
    }
}
