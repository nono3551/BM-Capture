﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfmediaengine.h(8182,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("4ae3a412-0545-43c4-bf6f-6b97a5c6c432"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFTimedTextBinary
    {
        [PreserveSig]
        HRESULT GetData(/* [annotation][out] _Outptr_result_bytebuffer_(*length) */ out IntPtr data, /* [annotation][out] _Out_ */ out uint length);
    }
}
