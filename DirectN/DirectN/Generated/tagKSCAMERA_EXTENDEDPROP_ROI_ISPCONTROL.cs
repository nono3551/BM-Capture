﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(6356,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKSCAMERA_EXTENDEDPROP_ROI_ISPCONTROL
    {
        public uint ControlId;
        public uint ROICount;
        public uint Result;
        public uint Reserved;
    }
}
