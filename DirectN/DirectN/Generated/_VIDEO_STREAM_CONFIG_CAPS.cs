﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(9182,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _VIDEO_STREAM_CONFIG_CAPS
    {
        public Guid guid;
        public uint VideoStandard;
        public tagSIZE InputSize;
        public tagSIZE MinCroppingSize;
        public tagSIZE MaxCroppingSize;
        public int CropGranularityX;
        public int CropGranularityY;
        public int CropAlignX;
        public int CropAlignY;
        public tagSIZE MinOutputSize;
        public tagSIZE MaxOutputSize;
        public int OutputGranularityX;
        public int OutputGranularityY;
        public int StretchTapsX;
        public int StretchTapsY;
        public int ShrinkTapsX;
        public int ShrinkTapsY;
        public long MinFrameInterval;
        public long MaxFrameInterval;
        public int MinBitsPerSecond;
        public int MaxBitsPerSecond;
    }
}
