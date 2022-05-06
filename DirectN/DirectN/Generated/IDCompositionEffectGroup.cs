﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dcomp.h(797,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("a7929a74-e6b2-4bd6-8b95-4040119ca34d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionEffectGroup : IDCompositionEffect
    {
        // IDCompositionEffect
        
        // IDCompositionEffectGroup
        [PreserveSig]
        HRESULT SetOpacity(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetOpacity(float opacity);
        
        [PreserveSig]
        HRESULT SetTransform3D(/* THIS_ _In_opt_ */ IDCompositionTransform3D transform3D);
    }
}
