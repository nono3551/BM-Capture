﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wingdi.h(3492,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _GLYPHMETRICS
    {
        public uint gmBlackBoxX;
        public uint gmBlackBoxY;
        public tagPOINT gmptGlyphOrigin;
        public short gmCellIncX;
        public short gmCellIncY;
    }
}
