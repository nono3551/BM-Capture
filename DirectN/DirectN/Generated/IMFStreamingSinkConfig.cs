﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(15838,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("9db7aa41-3cc5-40d4-8509-555804ad34cc"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFStreamingSinkConfig
    {
        [PreserveSig]
        HRESULT StartStreaming(/* [in] */ bool fSeekOffsetIsByteOffset, /* [in] */ ulong qwSeekOffset);
    }
}
