﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\audioengineextensionapo.h(100,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct AUDIO_SYSTEMEFFECT
    {
        public Guid id;
        public bool canSetState;
        public AUDIO_SYSTEMEFFECT_STATE state;
    }
}
