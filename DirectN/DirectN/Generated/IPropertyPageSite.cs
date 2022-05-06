﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ocidl.h(2197,5)
using System;
using System.Runtime.InteropServices;
using LCID = System.UInt32;
using MSG = DirectN.tagMSG;

namespace DirectN
{
    [ComImport, Guid("b196b28c-bab4-101a-b69c-00aa00341d07"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPropertyPageSite
    {
        [PreserveSig]
        HRESULT OnStatusChange(/* [in] */ uint dwFlags);
        
        [PreserveSig]
        HRESULT GetLocaleID(/* [out] __RPC__out */ out LCID pLocaleID);
        
        [PreserveSig]
        HRESULT GetPageContainer(/* [out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppUnk);
        
        [PreserveSig]
        HRESULT TranslateAcceleratorW(/* [in] __RPC__in */ ref MSG pMsg);
    }
}
