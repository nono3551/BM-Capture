﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\audioenginebaseapo.h(609,5)
using System;
using System.Runtime.InteropServices;
using HNSTIME = System.Int64;

namespace DirectN
{
    [ComImport, Guid("fd7f2b29-24d0-4b5c-b177-592c39f9ca10"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioProcessingObject
    {
        [PreserveSig]
        HRESULT Reset();
        
        [PreserveSig]
        HRESULT GetLatency(/* [out] __RPC__out */ out HNSTIME pTime);
        
        [PreserveSig]
        HRESULT GetRegistrationProperties(/* [out] __RPC__deref_out_opt */ out IntPtr ppRegProps);
        
        [PreserveSig]
        HRESULT Initialize(/* [in] */ int cbDataSize, /* [size_is][in] __RPC__in_ecount_full(cbDataSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] byte[] pbyData);
        
        [PreserveSig]
        HRESULT IsInputFormatSupported(/* [unique][in] __RPC__in_opt */ IAudioMediaType pOppositeFormat, /* [in] __RPC__in_opt */ IAudioMediaType pRequestedInputFormat, /* [out] __RPC__deref_out_opt */ out IAudioMediaType ppSupportedInputFormat);
        
        [PreserveSig]
        HRESULT IsOutputFormatSupported(/* [unique][in] __RPC__in_opt */ IAudioMediaType pOppositeFormat, /* [in] __RPC__in_opt */ IAudioMediaType pRequestedOutputFormat, /* [out] __RPC__deref_out_opt */ out IAudioMediaType ppSupportedOutputFormat);
        
        [PreserveSig]
        HRESULT GetInputChannelCount(/* [out] __RPC__out */ out uint pu32ChannelCount);
    }
}
