﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(2265,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11DDIARG_CREATEUNORDEREDACCESSVIEW__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D11DDIARG_BUFFER_UNORDEREDACCESSVIEW Buffer { get => InteropRuntime.Get<D3D11DDIARG_BUFFER_UNORDEREDACCESSVIEW>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D11DDIARG_BUFFER_UNORDEREDACCESSVIEW>(value, __bits, 0, 96); } }
        public D3D11DDIARG_TEX1D_UNORDEREDACCESSVIEW Tex1D { get => InteropRuntime.Get<D3D11DDIARG_TEX1D_UNORDEREDACCESSVIEW>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D11DDIARG_TEX1D_UNORDEREDACCESSVIEW>(value, __bits, 0, 96); } }
        public D3D11DDIARG_TEX2D_UNORDEREDACCESSVIEW Tex2D { get => InteropRuntime.Get<D3D11DDIARG_TEX2D_UNORDEREDACCESSVIEW>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D11DDIARG_TEX2D_UNORDEREDACCESSVIEW>(value, __bits, 0, 96); } }
        public D3D11DDIARG_TEX3D_UNORDEREDACCESSVIEW Tex3D { get => InteropRuntime.Get<D3D11DDIARG_TEX3D_UNORDEREDACCESSVIEW>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D11DDIARG_TEX3D_UNORDEREDACCESSVIEW>(value, __bits, 0, 96); } }
    }
}
