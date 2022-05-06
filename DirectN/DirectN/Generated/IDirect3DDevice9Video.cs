﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3d9.h(208,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("26dc4561-a1ee-4ae7-96da-118a36c0ec95"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DDevice9Video
    {
        [PreserveSig]
        HRESULT GetContentProtectionCaps([MarshalAs(UnmanagedType.LPStruct)] Guid pCryptoType, [MarshalAs(UnmanagedType.LPStruct)] Guid pDecodeProfile, ref _D3DCONTENTPROTECTIONCAPS pCaps);
        
        [PreserveSig]
        HRESULT CreateAuthenticatedChannel(_D3DAUTHENTICATEDCHANNELTYPE ChannelType, out IDirect3DAuthenticatedChannel9 ppAuthenticatedChannel, IntPtr pChannelHandle);
        
        [PreserveSig]
        HRESULT CreateCryptoSession([MarshalAs(UnmanagedType.LPStruct)] Guid pCryptoType, [MarshalAs(UnmanagedType.LPStruct)] Guid pDecodeProfile, out IDirect3DCryptoSession9 ppCryptoSession, IntPtr pCryptoHandle);
    }
}
