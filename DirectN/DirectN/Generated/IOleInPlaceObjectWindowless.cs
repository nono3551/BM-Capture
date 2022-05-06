﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ocidl.h(4311,5)
using System;
using System.Runtime.InteropServices;
using LRESULT = System.Int64;

namespace DirectN
{
    [ComImport, Guid("1c2056cc-5ef4-101b-8bc8-00aa003e3b29"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IOleInPlaceObjectWindowless
    {
        [PreserveSig]
        HRESULT OnWindowMessage(/* [in] */ uint msg, /* [in] */ ulong wParam, /* [in] */ long lParam, /* [out] __RPC__out */ out LRESULT plResult);
        
        [PreserveSig]
        HRESULT GetDropTarget(/* [out] __RPC__deref_out_opt */ out IntPtr ppDropTarget);
    }
}
