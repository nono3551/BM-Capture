﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(9253,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_SAVEMEMORYFORHOTUPDATE
    {
        public uint NumDataMemoryRanges;
        public IntPtr pDataMemoryRanges;
        public IntPtr pDataMdl;
        public uint DataSize;
        public IntPtr pData;
        public uint MetaDataSize;
        public IntPtr pMetaData;
    }
}
