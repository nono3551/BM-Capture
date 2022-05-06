﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dcomp.h(606,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("71fde914-40ef-45ef-bd51-68b037c339f9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionScaleTransform : IDCompositionTransform
    {
        // IDCompositionEffect
        
        // IDCompositionTransform3D
        
        // IDCompositionTransform
        
        // IDCompositionScaleTransform
        [PreserveSig]
        HRESULT SetScaleX(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetScaleX(float scaleX);
        
        [PreserveSig]
        HRESULT SetScaleY(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetScaleY(float scaleY);
        
        [PreserveSig]
        HRESULT SetCenterX(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetCenterX(float centerX);
        
        [PreserveSig]
        HRESULT SetCenterY(/* THIS_ _In_ */ IDCompositionAnimation animation);
        
        [PreserveSig]
        HRESULT SetCenterY(float centerY);
    }
}
