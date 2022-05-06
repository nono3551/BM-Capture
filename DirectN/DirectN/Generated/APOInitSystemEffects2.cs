﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\audioenginebaseapo.h(1429,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct APOInitSystemEffects2
    {
        public APOInitBaseStruct APOInit;
        public IntPtr pAPOEndpointProperties;
        public IntPtr pAPOSystemEffectsProperties;
        public IntPtr pReserved;
        public IntPtr pDeviceCollection;
        public uint nSoftwareIoDeviceInCollection;
        public uint nSoftwareIoConnectorIndex;
        public Guid AudioProcessingMode;
        public bool InitializeForDiscoveryOnly;
    }
}
