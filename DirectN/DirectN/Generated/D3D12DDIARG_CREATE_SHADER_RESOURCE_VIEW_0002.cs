﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(904,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATE_SHADER_RESOURCE_VIEW_0002
    {
        public D3D10DDI_HRESOURCE hDrvResource;
        public DXGI_FORMAT Format;
        public D3D12DDI_RESOURCE_DIMENSION ResourceDimension;
        public uint Shader4ComponentMapping;
        public D3D12DDIARG_CREATE_SHADER_RESOURCE_VIEW_0002__union_0 __union_4;
    }
}
