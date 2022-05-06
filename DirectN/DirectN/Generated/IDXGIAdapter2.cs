﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\dxgi1_2.h(2137,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("0aa1ae0a-fa0e-4b84-8644-e05ff8e5acb5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGIAdapter2 : IDXGIAdapter1
    {
        // IDXGIObject
        [PreserveSig]
        new HRESULT SetPrivateData(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid Name, /* [in] */ uint DataSize, /* [annotation][in] _In_reads_bytes_(DataSize) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid Name, /* optional(IUnknown) */ IntPtr pUnknown);
        
        [PreserveSig]
        new HRESULT GetPrivateData(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid Name, /* [annotation][out][in] _Inout_ */ ref uint pDataSize, /* [annotation][out] _Out_writes_bytes_(*pDataSize) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT GetParent(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][retval][out] _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppParent);
        
        // IDXGIAdapter
        [PreserveSig]
        new HRESULT EnumOutputs(/* [in] */ uint Output, /* [annotation][out][in] _COM_Outptr_ */ out IDXGIOutput ppOutput);
        
        [PreserveSig]
        new HRESULT GetDesc(/* [annotation][out] _Out_ */ out DXGI_ADAPTER_DESC pDesc);
        
        [PreserveSig]
        new HRESULT CheckInterfaceSupport(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid InterfaceName, /* [annotation][out] _Out_ */ out long pUMDVersion);
        
        // IDXGIAdapter1
        [PreserveSig]
        new HRESULT GetDesc1(/* [annotation][out] _Out_ */ out DXGI_ADAPTER_DESC1 pDesc);
        
        // IDXGIAdapter2
        [PreserveSig]
        HRESULT GetDesc2(/* [annotation][out] _Out_ */ out DXGI_ADAPTER_DESC2 pDesc);
    }
}
