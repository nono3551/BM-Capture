﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfplay.h(1193,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct MFP_MF_EVENT
    {
        public MFP_EVENT_HEADER header;
        public uint MFEventType;
        public IntPtr pMFMediaEvent;
        public IntPtr pMediaItem;
    }
}
