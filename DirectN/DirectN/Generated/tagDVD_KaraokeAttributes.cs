﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(22307,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagDVD_KaraokeAttributes
    {
        public byte bVersion;
        public bool fMasterOfCeremoniesInGuideVocal1;
        public bool fDuet;
        public tagDVD_KARAOKE_ASSIGNMENT ChannelAssignment;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public ushort[] wChannelContents;
    }
}
