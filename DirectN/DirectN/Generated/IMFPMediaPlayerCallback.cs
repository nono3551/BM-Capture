﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfplay.h(1259,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("766c8ffb-5fdb-4fea-a28d-b912996f51bd"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFPMediaPlayerCallback
    {
        [PreserveSig]
        void OnMediaPlayerEvent(/* [annotation][in] _In_ */ ref MFP_EVENT_HEADER pEventHeader);
    }
}
