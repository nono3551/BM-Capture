﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(13986,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS
    {
        public D3D10DDI_HRESOURCE hSrcResource;
        public D3D10DDI_HRESOURCE hDstResource;
        public uint SubresourceCount;
        public IntPtr pSubresourceParameters;
        public DXGI_FORMAT Format;
        public D3D12DDI_RESOLVE_MODE ResolveMode;
    }
}
