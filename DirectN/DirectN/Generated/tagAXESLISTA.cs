﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wingdi.h(4452,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagAXESLISTA
    {
        public uint axlReserved;
        public uint axlNumAxes;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public tagAXISINFOA[] axlAxisInfo;
    }
}
