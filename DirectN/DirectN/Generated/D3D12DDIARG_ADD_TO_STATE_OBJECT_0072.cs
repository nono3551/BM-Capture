﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(9072,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_ADD_TO_STATE_OBJECT_0072
    {
        public D3D12DDI_STATE_OBJECT_TYPE Type;
        public uint NumSubobjects;
        public IntPtr pSubobjects;
        public D3D12DDI_HSTATEOBJECT_0054 StateObjectToGrowFrom;
    }
}
