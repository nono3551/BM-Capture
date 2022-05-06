﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfreadwrite.h(1064,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("cf839fe6-8c2a-4dd2-b6ea-c22d6961af05"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSourceReaderCallback2 : IMFSourceReaderCallback
    {
        // IMFSourceReaderCallback
        [PreserveSig]
        new HRESULT OnReadSample(/* [annotation][in] _In_ */ HRESULT hrStatus, /* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ uint dwStreamFlags, /* [annotation][in] _In_ */ long llTimestamp, /* [annotation][in] _In_opt_ */ IMFSample pSample);
        
        [PreserveSig]
        new HRESULT OnFlush(/* [annotation][in] _In_ */ uint dwStreamIndex);
        
        [PreserveSig]
        new HRESULT OnEvent(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ IMFMediaEvent pEvent);
        
        // IMFSourceReaderCallback2
        [PreserveSig]
        HRESULT OnTransformChange();
        
        [PreserveSig]
        HRESULT OnStreamError(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ HRESULT hrStatus);
    }
}
