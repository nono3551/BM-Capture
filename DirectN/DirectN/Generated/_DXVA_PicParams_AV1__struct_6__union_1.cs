﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxva.h(1686,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_AV1__struct_6__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXVA_PicParams_AV1__struct_6__union_1__struct_0 __field_0 { get => InteropRuntime.Get<_DXVA_PicParams_AV1__struct_6__union_1__struct_0>(__bits, 0, 8); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.Set<_DXVA_PicParams_AV1__struct_6__union_1__struct_0>(value, __bits, 0, 8); } }
        public byte mask { get => InteropRuntime.GetByte(__bits, 0, 8); set { if (__bits == null) __bits = new byte[1]; InteropRuntime.SetByte(value, __bits, 0, 8); } }
    }
}
