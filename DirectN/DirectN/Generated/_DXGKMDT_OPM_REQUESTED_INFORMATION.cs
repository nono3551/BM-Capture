﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmdt.h(1725,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXGKMDT_OPM_REQUESTED_INFORMATION
    {
        public _DXGKMDT_OPM_OMAC omac;
        public uint cbRequestedInformationSize;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4076)] 
        public byte[] abRequestedInformation;
    }
}
