﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11.h(11236,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_AUTHENTICATED_QUERY_PROTECTION_OUTPUT
    {
        public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;
        public D3D11_AUTHENTICATED_PROTECTION_FLAGS ProtectionFlags;
    }
}
