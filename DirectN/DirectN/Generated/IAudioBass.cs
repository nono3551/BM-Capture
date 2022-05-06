﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\devicetopology.h(1542,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("a2b1a1d9-4db3-425d-a2b2-bd335cb3e2e5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioBass : IPerChannelDbLevel
    {
        // IPerChannelDbLevel
        [PreserveSig]
        new HRESULT GetChannelCount(/* [annotation][out] _Out_ */ out uint pcChannels);
        
        [PreserveSig]
        new HRESULT GetLevelRange(/* [annotation][in] _In_ */ uint nChannel, /* [annotation][out] _Out_ */ out float pfMinLevelDB, /* [annotation][out] _Out_ */ out float pfMaxLevelDB, /* [annotation][out] _Out_ */ out float pfStepping);
        
        [PreserveSig]
        new HRESULT GetLevel(/* [annotation][in] _In_ */ uint nChannel, /* [annotation][out] _Out_ */ out float pfLevelDB);
        
        [PreserveSig]
        new HRESULT SetLevel(/* [annotation][in] _In_ */ uint nChannel, /* [annotation][in] _In_ */ float fLevelDB, /* optional(LPCGUID) */ IntPtr pguidEventContext);
        
        [PreserveSig]
        new HRESULT SetLevelUniform(/* [annotation][in] _In_ */ float fLevelDB, /* optional(LPCGUID) */ IntPtr pguidEventContext);
        
        [PreserveSig]
        new HRESULT SetLevelAllChannels(/* [annotation][size_is][in] _In_reads_(cChannels) */ float [] aLevelsDB, /* [annotation][in] _In_ */ uint cChannels, /* optional(LPCGUID) */ IntPtr pguidEventContext);
        
        // IAudioBass
    }
}
