﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11_3.h(2015,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_QUERY_DESC1
    {
        public D3D11_QUERY Query;
        public uint MiscFlags;
        public D3D11_CONTEXT_TYPE ContextType;
    }
}
