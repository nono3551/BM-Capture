﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(2272,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _FilterInfo
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)] 
        public string achName;
        public IntPtr pGraph;
    }
}
