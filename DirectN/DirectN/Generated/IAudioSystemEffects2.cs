﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\audioenginebaseapo.h(944,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("bafe99d2-7436-44ce-9e0e-4d89afbfff56"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioSystemEffects2 : IAudioSystemEffects
    {
        // IAudioSystemEffects
        
        // IAudioSystemEffects2
        [PreserveSig]
        HRESULT GetEffectsList(/* [annotation][out] _Outptr_result_buffer_maybenull_(*pcEffects) */ out IntPtr ppEffectsIds, /* [annotation][out] _Out_ */ out uint pcEffects, /* [annotation][in] _In_ */ IntPtr Event);
    }
}
