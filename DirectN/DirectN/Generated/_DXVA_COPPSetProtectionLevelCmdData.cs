﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxva.h(2395,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_COPPSetProtectionLevelCmdData
    {
        public uint ProtType;
        public uint ProtLevel;
        public uint ExtendedInfoChangeMask;
        public uint ExtendedInfoData;
    }
}
