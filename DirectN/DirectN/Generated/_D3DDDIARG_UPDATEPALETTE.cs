﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(415,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_UPDATEPALETTE
    {
        public uint PaletteHandle;
        public uint StartIndex;
        public uint NumEntries;
    }
}
