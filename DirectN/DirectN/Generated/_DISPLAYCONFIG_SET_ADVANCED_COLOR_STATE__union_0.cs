﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wingdi.h(3186,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DISPLAYCONFIG_SET_ADVANCED_COLOR_STATE__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DISPLAYCONFIG_SET_ADVANCED_COLOR_STATE__union_0__struct_0 __field_0 { get => InteropRuntime.Get<_DISPLAYCONFIG_SET_ADVANCED_COLOR_STATE__union_0__struct_0>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_DISPLAYCONFIG_SET_ADVANCED_COLOR_STATE__union_0__struct_0>(value, __bits, 0, 32); } }
        public uint value { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
    }
}
