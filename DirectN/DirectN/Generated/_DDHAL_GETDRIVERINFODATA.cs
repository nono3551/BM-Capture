﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddrawi.h(2644,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// **************************************************************************
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_GETDRIVERINFODATA
    {
        public uint dwSize;
        public uint dwFlags;
        public Guid guidInfo;
        public uint dwExpectedSize;
        public IntPtr lpvData;
        public uint dwActualSize;
        public HRESULT ddRVal;
        public IntPtr dwContext;
    }
}
