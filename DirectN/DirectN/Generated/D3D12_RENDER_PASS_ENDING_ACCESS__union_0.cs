﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(18902,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_RENDER_PASS_ENDING_ACCESS__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 76)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS Resolve { get => InteropRuntime.Get<D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS>(__bits, 0, 608); set { if (__bits == null) __bits = new byte[76]; InteropRuntime.Set<D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS>(value, __bits, 0, 608); } }
    }
}
