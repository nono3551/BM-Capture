﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\devicetopology.h(2634,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("d9bd72ed-290f-4581-9ff3-61027a8fe532"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IKsJackSinkInformation
    {
        [PreserveSig]
        HRESULT GetJackSinkInformation(/* [annotation][out] _Out_ */ out _tagKSJACK_SINK_INFORMATION pJackSinkInformation);
    }
}
