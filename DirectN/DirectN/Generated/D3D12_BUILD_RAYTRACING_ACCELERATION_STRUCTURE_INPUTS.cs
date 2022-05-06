﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(13309,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS
    {
        public D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE Type;
        public D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAGS Flags;
        public uint NumDescs;
        public D3D12_ELEMENTS_LAYOUT DescsLayout;
        public D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS__union_0 __union_4;
    }
}
