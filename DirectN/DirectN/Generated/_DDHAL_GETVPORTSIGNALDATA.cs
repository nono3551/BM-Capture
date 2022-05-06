﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddrawi.h(2591,9)
using System;
using System.Runtime.InteropServices;
using LPDDHALVPORTCB_GETSIGNALSTATUS = System.IntPtr;
using LPDDRAWI_DDVIDEOPORT_LCL = DirectN._DDRAWI_DDVIDEOPORT_LCL;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_GETVPORTSIGNALDATA
    {
        public IntPtr lpDD;
        public IntPtr lpVideoPort;
        public uint dwStatus;
        public HRESULT ddRVal;
        public IntPtr GetVideoSignalStatus;
    }
}
