﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxva.h(2245,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_DeinterlaceQueryModeCaps
    {
        public uint Size;
        public Guid Guid;
        public _DXVA_VideoDesc VideoDesc;
    }
}
