﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\devicetopology.h(2720,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c99af463-d629-4ec4-8c00-e54d68154248"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IKsJackContainerId
    {
        [PreserveSig]
        HRESULT GetJackContainerId(/* [annotation][out] _Out_ */ out Guid pJackContainerId);
    }
}
