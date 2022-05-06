﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddrawint.h(906,9)
using System;
using System.Runtime.InteropServices;
using PDD_CANCREATESURFACE = System.IntPtr;
using PDD_CREATESURFACE = System.IntPtr;
using PDD_SURFCB_DESTROYSURFACE = System.IntPtr;
using PDD_SURFCB_LOCK = System.IntPtr;
using PDD_SURFCB_UNLOCK = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_D3DBUFCALLBACKS
    {
        public uint dwSize;
        public uint dwFlags;
        public IntPtr CanCreateD3DBuffer;
        public IntPtr CreateD3DBuffer;
        public IntPtr DestroyD3DBuffer;
        public IntPtr LockD3DBuffer;
        public IntPtr UnlockD3DBuffer;
    }
}
