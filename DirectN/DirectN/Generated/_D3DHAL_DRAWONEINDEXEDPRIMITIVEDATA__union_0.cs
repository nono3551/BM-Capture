﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dhal.h(725,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_DRAWONEINDEXEDPRIMITIVEDATA__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DVERTEXTYPE VertexType { get => InteropRuntime.Get<_D3DVERTEXTYPE>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_D3DVERTEXTYPE>(value, __bits, 0, 32); } }
        public uint dwFVFControl { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
    }
}
