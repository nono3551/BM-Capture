﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsdkidl.h(1554,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _WMT_PAYLOAD_FRAGMENT
    {
        public uint dwPayloadIndex;
        public _WMT_BUFFER_SEGMENT segmentData;
    }
}
