﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddrawint.h(1550,9)
using System;
using System.Runtime.InteropServices;
using LPDDVIDEOPORTCONNECT = DirectN._DDVIDEOPORTCONNECT;
using PDD_DIRECTDRAW_LOCAL = DirectN._DD_DIRECTDRAW_LOCAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_GETVPORTCONNECTDATA
    {
        public IntPtr lpDD;
        public uint dwPortId;
        public IntPtr lpConnect;
        public uint dwNumEntries;
        public HRESULT ddRVal;
        public IntPtr GetVideoPortConnectInfo;
    }
}
