﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxva.h(2563,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_COPPStatusHDCPKeyData
    {
        public Guid rApp;
        public uint dwFlags;
        public uint dwHDCPFlags;
        public Guid BKey;
        public Guid Reserved1;
        public Guid Reserved2;
    }
}
