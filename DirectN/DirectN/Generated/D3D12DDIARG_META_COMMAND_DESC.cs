﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(7316,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_META_COMMAND_DESC
    {
        public Guid Id;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string Name;
        public D3D12DDI_GRAPHICS_STATES InitializationDirtyState;
        public D3D12DDI_GRAPHICS_STATES ExecutionDirtyState;
    }
}