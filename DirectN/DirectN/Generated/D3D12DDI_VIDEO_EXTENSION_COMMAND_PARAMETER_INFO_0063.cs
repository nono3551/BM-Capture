﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(11795,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO_0063
    {
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string Name;
        public D3D12DDI_VIDEO_EXTENSION_COMMAND_PARAMETER_TYPE_0063 Type;
        public D3D12DDI_VIDEO_EXTENSION_COMMAND_PARAMETER_FLAGS_0063 Flags;
    }
}
