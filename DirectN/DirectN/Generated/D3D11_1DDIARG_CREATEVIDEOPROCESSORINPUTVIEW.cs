﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(3068,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_1DDIARG_CREATEVIDEOPROCESSORINPUTVIEW
    {
        public D3D10DDI_HRESOURCE hDrvResource;
        public D3D11_1DDI_HVIDEOPROCESSORENUM hDrvVideoProcessorEnum;
        public uint FourCC;
        public uint MipSlice;
        public uint FirstArraySlice;
        public uint ArraySize;
    }
}
