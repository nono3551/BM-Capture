﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(6750,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _KSCAMERA_PROFILE_CONCURRENCYINFO
    {
        public Guid ReferenceGuid;
        public uint Reserved;
        public uint ProfileCount;
        public IntPtr Profiles;
    }
}
