﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(5175,9)
using System;
using System.Runtime.InteropServices;
using LUID = DirectN._LUID;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_GETPROCESSDEVICEREMOVALSUPPORT
    {
        public IntPtr hProcess;
        public LUID AdapterLuid;
        public byte Support;
    }
}
