﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(2904,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_BRIGHTNESS_INFO
    {
        public _D3DKMT_BRIGHTNESS_INFO_TYPE Type;
        public uint ChildUid;
        public _D3DKMT_BRIGHTNESS_INFO__union_0 __union_2;
    }
}
