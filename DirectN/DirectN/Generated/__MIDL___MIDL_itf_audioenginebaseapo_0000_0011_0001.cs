﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\audioenginebaseapo.h(1442,24)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct __MIDL___MIDL_itf_audioenginebaseapo_0000_0011_0001
    {
        public long AddPageParam;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string pwstrEndpointID;
        public IntPtr pFxProperties;
    }
}
