﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mftransform.h(1348,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct MFAudioDecoderDegradationInfo
    {
        public MFT_AUDIO_DECODER_DEGRADATION_REASON eDegradationReason;
        public MFT_AUDIO_DECODER_DEGRADATION_TYPE eType;
    }
}
