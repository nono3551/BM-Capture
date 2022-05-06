﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wingdi.h(5977,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMRSTRETCHDIBITS
    {
        public tagEMR emr;
        public _RECTL rclBounds;
        public int xDest;
        public int yDest;
        public int xSrc;
        public int ySrc;
        public int cxSrc;
        public int cySrc;
        public uint offBmiSrc;
        public uint cbBmiSrc;
        public uint offBitsSrc;
        public uint cbBitsSrc;
        public uint iUsageSrc;
        public uint dwRop;
        public int cxDest;
        public int cyDest;
    }
}
