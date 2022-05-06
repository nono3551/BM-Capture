﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfplay.h(1128,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct MFP_EVENT_HEADER
    {
        public MFP_EVENT_TYPE eEventType;
        public HRESULT hrEvent;
        public IntPtr pMediaPlayer;
        public MFP_MEDIAPLAYER_STATE eState;
        public IntPtr pPropertyStore;
    }
}
