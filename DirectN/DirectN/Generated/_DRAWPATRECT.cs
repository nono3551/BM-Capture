﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wingdi.h(293,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DRAWPATRECT
    {
        public tagPOINT ptPosition;
        public tagPOINT ptSize;
        public ushort wStyle;
        public ushort wPattern;
    }
}
