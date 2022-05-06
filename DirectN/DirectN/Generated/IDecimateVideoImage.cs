﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(15518,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("2e5ea3e0-e924-11d2-b6da-00a0c995e8df"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDecimateVideoImage
    {
        [PreserveSig]
        HRESULT SetDecimationImageSize(/* [in] */ int lWidth, /* [in] */ int lHeight);
        
        [PreserveSig]
        HRESULT ResetDecimationImageSize();
    }
}
