﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\spatialaudiometadata.h(153,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct SpatialAudioMetadataItemsInfo
    {
        public ushort FrameCount;
        public ushort ItemCount;
        public ushort MaxItemCount;
        public uint MaxValueBufferLength;
    }
}
