﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(4732,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_CREATEPAGINGQUEUE
    {
        public uint hDevice;
        public D3DDDI_PAGINGQUEUE_PRIORITY Priority;
        public uint hPagingQueue;
        public uint hSyncObject;
        public IntPtr FenceValueCPUVirtualAddress;
        public uint PhysicalAdapterIndex;
    }
}
