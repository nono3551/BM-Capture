﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(20548,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("eed9c2ee-66b4-4f18-a697-ac7d3960215c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSensorTransformFactory
    {
        [PreserveSig]
        HRESULT GetFactoryAttributes(/* [annotation][out] _COM_Outptr_ */ out IMFAttributes ppAttributes);
        
        [PreserveSig]
        HRESULT InitializeFactory(/* [annotation][in] _In_ */ uint dwMaxTransformCount, /* [annotation][in] _In_ */ IMFCollection pSensorDevices, /* [annotation][in] _In_opt_ */ IMFAttributes pAttributes);
        
        [PreserveSig]
        HRESULT GetTransformCount(/* [annotation][out] _Out_ */ out uint pdwCount);
        
        [PreserveSig]
        HRESULT GetTransformInformation(/* [annotation][in] _In_ */ uint TransformIndex, /* [annotation][out] _Out_ */ out Guid pguidTransformId, /* [annotation][out] _COM_Outptr_result_maybenull_ */ out IMFAttributes ppAttributes, /* [annotation][out] _COM_Outptr_ */ out IMFCollection ppStreamInformation);
        
        [PreserveSig]
        HRESULT CreateTransform(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidSensorTransformID, /* [annotation][in] _In_opt_ */ IMFAttributes pAttributes, /* [annotation][out] _COM_Outptr_ */ out IMFDeviceTransform ppDeviceMFT);
    }
}
