﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(5299,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct REGFILTERPINS2
    {
        public uint dwFlags;
        public uint cInstances;
        public uint nMediaTypes;
        public IntPtr lpMediaType;
        public uint nMediums;
        public IntPtr lpMedium;
        public IntPtr clsPinCategory;
    }
}
