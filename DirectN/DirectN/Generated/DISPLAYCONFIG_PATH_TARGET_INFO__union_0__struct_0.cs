﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wingdi.h(2980,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DISPLAYCONFIG_PATH_TARGET_INFO__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint desktopModeInfoIdx { get => InteropRuntime.GetUInt32(__bits, 0, 16); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 0, 16); } }
        public uint targetModeInfoIdx { get => InteropRuntime.GetUInt32(__bits, 16, 16); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetUInt32(value, __bits, 16, 16); } }
    }
}
