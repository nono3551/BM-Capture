﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wingdi.h(973,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagCHARSETINFO
    {
        public uint ciCharset;
        public uint ciACP;
        public tagFONTSIGNATURE fs;
    }
}
