﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(1982,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct _tagKSTOPOLOGY_ENDPOINTID
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)] 
        public string TopologyName;
        public uint PinId;
    }
}
