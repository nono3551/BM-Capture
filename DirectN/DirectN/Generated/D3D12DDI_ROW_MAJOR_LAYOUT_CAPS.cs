﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(273,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_ROW_MAJOR_LAYOUT_CAPS
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public D3D12DDI_ROW_MAJOR_LAYOUT_SUB_CAPS[] SubCaps;
        public D3D12DDI_ROW_MAJOR_LAYOUT_FLAGS Flags;
    }
}
