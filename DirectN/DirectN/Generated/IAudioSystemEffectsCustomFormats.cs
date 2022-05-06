﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\audioenginebaseapo.h(1039,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("b1176e34-bb7f-4f05-bebd-1b18a534e097"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioSystemEffectsCustomFormats
    {
        [PreserveSig]
        HRESULT GetFormatCount(/* [out] __RPC__out */ out uint pcFormats);
        
        [PreserveSig]
        HRESULT GetFormat(/* [in] */ uint nFormat, /* [out] __RPC__deref_out_opt */ out IAudioMediaType ppFormat);
        
        [PreserveSig]
        HRESULT GetFormatRepresentation(/* [in] */ uint nFormat, /* [out] __RPC__deref_out_opt */ out IntPtr ppwstrFormatRep);
    }
}
