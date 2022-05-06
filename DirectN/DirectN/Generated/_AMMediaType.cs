﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(1178,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _AMMediaType
    {
        public Guid majortype;
        public Guid subtype;
        public bool bFixedSizeSamples;
        public bool bTemporalCompression;
        public uint lSampleSize;
        public Guid formattype;
        [MarshalAs(UnmanagedType.IUnknown)] 
        public object pUnk;
        public uint cbFormat;
        public IntPtr pbFormat;
    }
}
