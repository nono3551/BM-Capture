﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxvahd.h(1074,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHDETW_CREATEVIDEOPROCESSOR
    {
        public ulong pObject;
        public ulong pD3D9Ex;
        public Guid VPGuid;
    }
}
