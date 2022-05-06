﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11_3.h(2059,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("631b4766-36dc-461d-8db6-c47e13e60916"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11Query1 : ID3D11Query
    {
        // ID3D11DeviceChild
        [PreserveSig]
        new void GetDevice(/* [annotation] _Outptr_ */ out ID3D11Device ppDevice);
        
        [PreserveSig]
        new HRESULT GetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _Inout_ */ ref uint pDataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _In_ */ uint DataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* optional(IUnknown) */ IntPtr pData);
        
        // ID3D11Asynchronous
        [PreserveSig]
        new uint GetDataSize();
        
        // ID3D11Query
        [PreserveSig]
        new void GetDesc(/* [annotation] _Out_ */ out D3D11_QUERY_DESC pDesc);
        
        // ID3D11Query1
        [PreserveSig]
        void GetDesc1(/* [annotation] _Out_ */ out D3D11_QUERY_DESC1 pDesc1);
    }
}
