﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mediaobj.h(155,1)
using System;

namespace DirectN
{
    [Flags]
    public enum _DMO_OUTPUT_STREAM_INFO_FLAGS
    {
        DMO_OUTPUT_STREAMF_WHOLE_SAMPLES = 0x00000001,
        DMO_OUTPUT_STREAMF_SINGLE_SAMPLE_PER_BUFFER = 0x00000002,
        DMO_OUTPUT_STREAMF_FIXED_SAMPLE_SIZE = 0x00000004,
        DMO_OUTPUT_STREAMF_DISCARDABLE = 0x00000008,
        DMO_OUTPUT_STREAMF_OPTIONAL = 0x00000010,
    }
}
