﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(13253,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER
    {
        public Guid DriverOpaqueGUID;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public byte[] DriverOpaqueVersioningData;
    }
}
