﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(8528,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_SET_TIMING_PATH_INFO
    {
        public uint VidPnTargetId;
        public _DXGK_SET_TIMING_PATH_INFO__union_0 __union_1;
        public _D3DKMDT_WIRE_FORMAT_AND_PREFERENCE SelectedWireFormat;
        public _DXGK_SET_TIMING_PATH_INFO__union_1 __union_3;
        public _DXGK_SET_TIMING_PATH_INFO__union_2 __union_4;
        public _DXGK_CONNECTION_CHANGE TargetState;
        public _DXGK_SET_TIMING_PATH_INFO__union_3 __union_6;
    }
}
