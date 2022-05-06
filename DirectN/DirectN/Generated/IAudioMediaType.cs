﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\audiomediatype.h(103,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("4e997f73-b71f-4798-873b-ed7dfcf15b4d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioMediaType
    {
        [PreserveSig]
        HRESULT IsCompressedFormat(/* [annotation][out] _Out_ */ out bool pfCompressed);
        
        [PreserveSig]
        HRESULT IsEqual(/* [annotation][in] _In_ */ IAudioMediaType pIAudioType, /* [annotation][out] _Out_ */ out uint pdwFlags);
        
        [PreserveSig]
        IntPtr GetAudioFormat();
        
        [PreserveSig]
        HRESULT GetUncompressedAudioFormat(/* [annotation][out] _Out_ */ out _UNCOMPRESSEDAUDIOFORMAT pUncompressedAudioFormat);
    }
}
