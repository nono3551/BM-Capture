﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(18151,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("fff4af3a-1fc1-4ef9-a29b-d26c49e2f31a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSystemId
    {
        [PreserveSig]
        HRESULT GetData(/* [annotation] _Out_ */ out uint size, /* [annotation] _Outptr_result_bytebuffer_(*size) */ out IntPtr data);
        
        [PreserveSig]
        HRESULT Setup(uint stage, int cbIn, /* [annotation] _In_reads_bytes_(cbIn) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pbIn, /* [annotation] _Out_ */ out uint pcbOut, /* [annotation] _Outptr_result_bytebuffer_(*pcbOut) */ out IntPtr ppbOut);
    }
}
