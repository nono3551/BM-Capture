﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(2493,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_QUERY_META_COMMAND
    {
        public Guid CommandId;
        public uint NodeMask;
        public IntPtr pQueryInputData;
        public IntPtr QueryInputDataSizeInBytes;
        public IntPtr pQueryOutputData;
        public IntPtr QueryOutputDataSizeInBytes;
    }
}
