﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(1989,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_PAGETABLEUPDATEADDRESS__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public IntPtr CpuVirtual { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); } }
        public _D3DGPU_PHYSICAL_ADDRESS GpuPhysical { get => InteropRuntime.Get<_D3DGPU_PHYSICAL_ADDRESS>(__bits, 0, 128); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<_D3DGPU_PHYSICAL_ADDRESS>(value, __bits, 0, 128); } }
        public ulong GpuVirtual { get => InteropRuntime.GetUInt64(__bits, 0, 64); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.SetUInt64(value, __bits, 0, 64); } }
    }
}
