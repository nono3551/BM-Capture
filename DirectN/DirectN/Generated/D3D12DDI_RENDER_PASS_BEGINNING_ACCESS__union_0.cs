﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(13957,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_RENDER_PASS_BEGINNING_ACCESS__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12DDI_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS Clear { get => InteropRuntime.Get<D3D12DDI_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS>(__bits, 0, 256); set { if (__bits == null) __bits = new byte[32]; InteropRuntime.Set<D3D12DDI_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS>(value, __bits, 0, 256); } }
        public D3D12DDI_RENDER_PASS_BEGINNING_ACCESS_RESUME_LOCAL_READ_PARAMETERS ResumeLocalRead { get => InteropRuntime.Get<D3D12DDI_RENDER_PASS_BEGINNING_ACCESS_RESUME_LOCAL_READ_PARAMETERS>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[32]; InteropRuntime.Set<D3D12DDI_RENDER_PASS_BEGINNING_ACCESS_RESUME_LOCAL_READ_PARAMETERS>(value, __bits, 0, 64); } }
    }
}
