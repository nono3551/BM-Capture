﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(2687,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSDATARANGE_MUSIC
    {
        public KSDATAFORMAT DataRange;
        public Guid Technology;
        public uint Channels;
        public uint Notes;
        public uint ChannelMask;
    }
}
