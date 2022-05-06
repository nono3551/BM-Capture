﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\spatialaudioclient.h(201,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("dcdaa858-895a-4a22-a5eb-67bda506096d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioFormatEnumerator
    {
        [PreserveSig]
        HRESULT GetCount(/* [annotation][out] _Out_ */ out uint count);
        
        [PreserveSig]
        HRESULT GetFormat(/* [annotation][in] _In_ */ uint index, /* [annotation][out] _Outptr_ */ out IntPtr format);
    }
}
