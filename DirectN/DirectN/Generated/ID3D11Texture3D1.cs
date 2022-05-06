﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11_3.h(509,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("0c711683-2853-4846-9bb0-f3e60639e46a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11Texture3D1 : ID3D11Texture3D
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
        
        // ID3D11Resource
        [PreserveSig]
        new void GetType(/* [annotation] _Out_ */ out D3D11_RESOURCE_DIMENSION pResourceDimension);
        
        [PreserveSig]
        new void SetEvictionPriority(/* [annotation] _In_ */ uint EvictionPriority);
        
        [PreserveSig]
        new uint GetEvictionPriority();
        
        // ID3D11Texture3D
        [PreserveSig]
        new void GetDesc(/* [annotation] _Out_ */ out D3D11_TEXTURE3D_DESC pDesc);
        
        // ID3D11Texture3D1
        [PreserveSig]
        void GetDesc1(/* [annotation] _Out_ */ out D3D11_TEXTURE3D_DESC1 pDesc);
    }
}
