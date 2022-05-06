﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mmeapi.h(80,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct wavehdr_tag
    {
        [MarshalAs(UnmanagedType.LPStr)] 
        public string lpData;
        public uint dwBufferLength;
        public uint dwBytesRecorded;
        public IntPtr dwUser;
        public uint dwFlags;
        public uint dwLoops;
        public IntPtr lpNext;
        public IntPtr reserved;
    }
}
