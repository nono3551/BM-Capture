﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dukmdt.h(573,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_DRIVERESCAPE_CPUEVENTUSAGE
    {
        public _D3DDDI_DRIVERESCAPETYPE EscapeType;
        public uint hSyncObject;
        public ulong hKmdCpuEvent;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public uint[] Usage;
    }
}
