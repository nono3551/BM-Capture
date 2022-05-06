﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(7867,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_RAYTRACING_GEOMETRY_TRIANGLES_DESC_0054
    {
        public ulong ColumnMajorTransform3x4;
        public DXGI_FORMAT IndexFormat;
        public DXGI_FORMAT VertexFormat;
        public uint IndexCount;
        public uint VertexCount;
        public ulong IndexBuffer;
        public D3D12DDI_GPU_VIRTUAL_ADDRESS_AND_STRIDE VertexBuffer;
    }
}
