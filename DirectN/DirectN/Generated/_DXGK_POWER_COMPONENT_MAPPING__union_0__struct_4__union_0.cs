﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(3151,11)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_POWER_COMPONENT_MAPPING__union_0__struct_4__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXGK_POWER_COMPONENT_MAPPING__union_0__struct_4__union_0__struct_0 __field_0 { get => InteropRuntime.Get<_DXGK_POWER_COMPONENT_MAPPING__union_0__struct_4__union_0__struct_0>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_DXGK_POWER_COMPONENT_MAPPING__union_0__struct_4__union_0__struct_0>(value, __bits, 0, 32); } }
        public uint SharedType { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
    }
}
