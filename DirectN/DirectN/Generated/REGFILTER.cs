﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(4895,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct REGFILTER
    {
        public Guid Clsid;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string Name;
    }
}
