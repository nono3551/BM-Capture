﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfapi.h(3501,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFCameraExtrinsics
    {
        public uint TransformCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public _MFCameraExtrinsic_CalibratedTransform[] CalibratedTransforms;
    }
}
