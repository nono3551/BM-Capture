﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(2760,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_COLORIMETRY
    {
        public _D3DKMDT_2DREGION RedPoint;
        public _D3DKMDT_2DREGION GreenPoint;
        public _D3DKMDT_2DREGION BluePoint;
        public _D3DKMDT_2DREGION WhitePoint;
        public uint MinLuminance;
        public uint MaxLuminance;
        public uint MaxFullFrameLuminance;
        public _D3DKMDT_WIRE_FORMAT_AND_PREFERENCE FormatBitDepths;
        public _DXGK_STANDARD_COLORIMETRY_FLAGS StandardColorimetryFlags;
    }
}
