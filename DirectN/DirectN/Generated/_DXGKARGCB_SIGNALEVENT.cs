﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(9168,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_SIGNALEVENT
    {
        public IntPtr hDxgkProcess;
        public IntPtr hEvent;
        public _DXGKARGCB_SIGNALEVENT__union_0 __union_2;
    }
}
