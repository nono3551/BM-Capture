﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ks.h(2119,9)
using System;
using System.Runtime.InteropServices;
using KSPIN_MDL_CACHING_EVENT = DirectN.KSPIN_MDL_CACHING_NOTIFY;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPIN_MDL_CACHING_NOTIFICATION
    {
        public KSPIN_MDL_CACHING_EVENT Event;
        public IntPtr Buffer;
    }
}
