﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxva.h(1687,13)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_AV1__struct_6__union_1__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public byte alt_q { get => InteropRuntime.GetByte(__bits, 0, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 0, 1); } }
        public byte alt_lf_y_v { get => InteropRuntime.GetByte(__bits, 1, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 1, 1); } }
        public byte alt_lf_y_h { get => InteropRuntime.GetByte(__bits, 2, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 2, 1); } }
        public byte alt_lf_u { get => InteropRuntime.GetByte(__bits, 3, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 3, 1); } }
        public byte alt_lf_v { get => InteropRuntime.GetByte(__bits, 4, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 4, 1); } }
        public byte ref_frame { get => InteropRuntime.GetByte(__bits, 5, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 5, 1); } }
        public byte skip { get => InteropRuntime.GetByte(__bits, 6, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 6, 1); } }
        public byte globalmv { get => InteropRuntime.GetByte(__bits, 7, 1); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 7, 1); } }
    }
}
