﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(5507,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_TUNER_SCAN_STATUS_S
    {
        public KSIDENTIFIER Property;
        public _TunerDecoderLockType LockStatus;
        public uint CurrentFrequency;
    }
}
