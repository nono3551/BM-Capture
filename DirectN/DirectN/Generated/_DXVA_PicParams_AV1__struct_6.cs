﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxva.h(1673,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_AV1__struct_6
    {
        public _DXVA_PicParams_AV1__struct_6__union_0 __union_0;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)] 
        public byte[] Reserved24Bits;
        public _DXVA_PicParams_AV1__struct_6__union_1 __union_2;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public IntPtr[] feature_mask;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public short[] feature_data;
    }
}
