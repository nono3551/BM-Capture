﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wingdi.h(4430,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagAXISINFOA
    {
        public int axMinValue;
        public int axMaxValue;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public byte[] axAxisName;
    }
}
