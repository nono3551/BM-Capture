﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\audioclient.h(207,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct AudioClientProperties
    {
        public uint cbSize;
        public bool bIsOffload;
        public _AUDIO_STREAM_CATEGORY eCategory;
        public AUDCLNT_STREAMOPTIONS Options;
    }
}
