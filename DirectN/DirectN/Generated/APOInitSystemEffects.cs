﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\audioenginebaseapo.h(1420,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct APOInitSystemEffects
    {
        public APOInitBaseStruct APOInit;
        public IntPtr pAPOEndpointProperties;
        public IntPtr pAPOSystemEffectsProperties;
        public IntPtr pReserved;
        public IntPtr pDeviceCollection;
    }
}
