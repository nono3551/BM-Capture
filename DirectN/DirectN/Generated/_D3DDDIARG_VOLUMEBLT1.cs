﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(2032,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_VOLUMEBLT1
    {
        public IntPtr hDstResource;
        public IntPtr hSrcResource;
        public uint DstX;
        public uint DstY;
        public uint DstZ;
        public _D3DDDIBOX SrcBox;
        public uint CopyFlags;
    }
}
