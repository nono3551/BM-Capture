﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(7131,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_CROSSBAR_PININFO_S
    {
        public KSIDENTIFIER Property;
        public KSPIN_DATAFLOW Direction;
        public uint Index;
        public uint PinType;
        public uint RelatedPinIndex;
        public KSIDENTIFIER Medium;
    }
}
