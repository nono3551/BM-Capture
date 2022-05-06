﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ocidl.h(6233,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("376bd3aa-3845-101b-84ed-08002b2ec713"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPerPropertyBrowsing
    {
        [PreserveSig]
        HRESULT GetDisplayString(/* [in] */ int dispID, /* [out] __RPC__deref_out_opt */ out IntPtr pBstr);
        
        [PreserveSig]
        HRESULT MapPropertyToPage(/* [in] */ int dispID, /* [out] __RPC__out */ out Guid pClsid);
        
        [PreserveSig]
        HRESULT GetPredefinedStrings(/* [in] */ int dispID, /* [out] __RPC__out */ out tagCALPOLESTR pCaStringsOut, /* [out] __RPC__out */ out tagCADWORD pCaCookiesOut);
        
        [PreserveSig]
        HRESULT GetPredefinedValue(/* [in] */ int dispID, /* [in] */ uint dwCookie, /* [out] __RPC__out */ out IntPtr pVarOut);
    }
}
