﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11.h(11364,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_ENCRYPTION_GUID_INPUT
    {
        public D3D11_AUTHENTICATED_QUERY_INPUT Input;
        public uint EncryptionGuidIndex;
    }
}
