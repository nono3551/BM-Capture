﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ks.h(1142,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct KSPIN_PHYSICALCONNECTION
    {
        public uint Size;
        public uint Pin;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)] 
        public string SymbolicLinkName;
    }
}
