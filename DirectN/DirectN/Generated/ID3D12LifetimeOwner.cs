﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(12307,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("e667af9f-cd56-4f46-83ce-032e595d70a8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12LifetimeOwner
    {
        [PreserveSig]
        void LifetimeStateUpdated(D3D12_LIFETIME_STATE NewState);
    }
}
