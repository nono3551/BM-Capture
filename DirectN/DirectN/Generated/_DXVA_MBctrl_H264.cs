﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxva.h(828,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_MBctrl_H264
    {
        public _DXVA_MBctrl_H264__union_0 __union_0;
        public ushort CurrMbAddr;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)] 
        public ushort[] wPatternCode;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)] 
        public byte[] bQpPrime;
        public byte bMBresidDataQuantity;
        public uint dwMBdataLocation;
        public _DXVA_MBctrl_H264__union_1 __union_6;
    }
}
