﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(16975,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MF_TRANSCODE_SINK_INFO
    {
        public uint dwVideoStreamID;
        public IntPtr pVideoMediaType;
        public uint dwAudioStreamID;
        public IntPtr pAudioMediaType;
    }
}
