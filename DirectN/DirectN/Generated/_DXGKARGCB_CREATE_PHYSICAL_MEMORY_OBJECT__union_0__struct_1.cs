﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(9422,9)
using System.Runtime.InteropServices;
using PHYSICAL_ADDRESS = System.Int64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_CREATE_PHYSICAL_MEMORY_OBJECT__union_0__struct_1
    {
        public PHYSICAL_ADDRESS LowestAcceptableAddress;
        public PHYSICAL_ADDRESS HighestAcceptableAddress;
        public PHYSICAL_ADDRESS BoundaryAddressMultiple;
    }
}
