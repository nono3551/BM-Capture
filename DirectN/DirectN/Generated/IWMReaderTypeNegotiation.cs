﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsdkidl.h(14104,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("fdbe5592-81a1-41ea-93bd-735cad1adc05"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMReaderTypeNegotiation
    {
        [PreserveSig]
        HRESULT TryOutputProps(/* [in] */ uint dwOutputNum, /* [in] */ IWMOutputMediaProps pOutput);
    }
}
