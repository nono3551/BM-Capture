﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\devicetopology.h(3510,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("a09513ed-c709-4d21-bd7b-5f34c47f3947"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IControlChangeNotify
    {
        [PreserveSig]
        HRESULT OnNotify(/* [annotation][in] _In_ */ uint dwSenderProcessId, /* optional(LPCGUID) */ IntPtr pguidEventContext);
    }
}
