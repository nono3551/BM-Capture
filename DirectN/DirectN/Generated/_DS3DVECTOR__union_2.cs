﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(1134,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DS3DVECTOR__union_2
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public float z { get => InteropRuntime.GetSingle(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetSingle(value, __bits, 0, 32); } }
        public float dvZ { get => InteropRuntime.GetSingle(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetSingle(value, __bits, 0, 32); } }
    }
}
