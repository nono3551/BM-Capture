﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfapi.h(3550,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFPinholeCameraIntrinsics
    {
        public uint IntrinsicModelCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public _MFPinholeCameraIntrinsic_IntrinsicModel[] IntrinsicModels;
    }
}
