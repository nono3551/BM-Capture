﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dcomp.h(570,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("06791122-c6f0-417d-8323-269e987f5954"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionTranslateTransform : IDCompositionTransform
    {
        // IDCompositionEffect
        
        // IDCompositionTransform3D
        
        // IDCompositionTransform
        
        // IDCompositionTranslateTransform
        [PreserveSig]
        HRESULT SetOffsetX(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetOffsetX(float offsetX);
        
        [PreserveSig]
        HRESULT SetOffsetY(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetOffsetY(float offsetY);
    }
}
