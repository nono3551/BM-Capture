﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsdkidl.h(1620,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _WMUserText
    {
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pwszDescription;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pwszText;
    }
}
