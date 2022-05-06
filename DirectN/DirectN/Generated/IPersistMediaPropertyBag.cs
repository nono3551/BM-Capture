﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(13332,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("5738e040-b67f-11d0-bd4d-00a0c911ce86"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPersistMediaPropertyBag
    {
        [PreserveSig]
        HRESULT InitNew();
        
        [PreserveSig]
        HRESULT Load(/* [in] */ IMediaPropertyBag pPropBag, /* [in] */ ref IErrorLog pErrorLog);
        
        [PreserveSig]
        HRESULT Save(/* [in] */ IMediaPropertyBag pPropBag, /* [in] */ bool fClearDirty, /* [in] */ bool fSaveAllProperties);
    }
}
