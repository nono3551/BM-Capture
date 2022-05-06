﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ocidl.h(5631,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("b3e7c340-ef97-11ce-9bc9-00aa00608e01"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IEnumOleUndoUnits
    {
        [PreserveSig]
        HRESULT Next(/* [in] */ uint cElt, /* [length_is][size_is][out] */ out IntPtr rgElt, /* [out] */ out uint pcEltFetched);
        
        [PreserveSig]
        HRESULT Skip(/* [in] */ uint cElt);
        
        [PreserveSig]
        HRESULT Reset();
        
        [PreserveSig]
        HRESULT Clone(/* [out] __RPC__deref_out_opt */ out IEnumOleUndoUnits ppEnum);
    }
}
