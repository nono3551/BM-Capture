﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(2556,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CALCPRIVATEDEVICESIZE
    {
        public uint Interface;
        public uint Version;
        public D3D12DDI_CREATE_DEVICE_FLAGS Flags;
    }
}
