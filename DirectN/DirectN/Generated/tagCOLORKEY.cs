﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(5798,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagCOLORKEY
    {
        public uint KeyType;
        public uint PaletteIndex;
        public uint LowColorValue;
        public uint HighColorValue;
    }
}
