﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(15833,1)
using System;

namespace DirectN
{
    [Flags]
    public enum _AM_PUSHSOURCE_FLAGS
    {
        AM_PUSHSOURCECAPS_INTERNAL_RM = 0x00000001,
        AM_PUSHSOURCECAPS_NOT_LIVE = 0x00000002,
        AM_PUSHSOURCECAPS_PRIVATE_CLOCK = 0x00000004,
        AM_PUSHSOURCEREQS_USE_STREAM_CLOCK = 0x00010000,
        AM_PUSHSOURCEREQS_USE_CLOCK_CHAIN = 0x00020000,
    }
}
