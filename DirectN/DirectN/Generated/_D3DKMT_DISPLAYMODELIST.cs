﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(286,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_DISPLAYMODELIST
    {
        public uint VidPnSourceId;
        public uint ModeCount;
        [MarshalAs(UnmanagedType.ByValArray)] 
        public _D3DKMT_DISPLAYMODE[] pModeList;
    }
}
