﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(13222,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("6025a880-c0d5-11d0-bd4e-00a0c911ce86"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMediaPropertyBag
    {
        [PreserveSig]
        HRESULT EnumProperty(/* [in] */ uint iProperty, /* [out][in] */ out IntPtr pvarPropertyName, /* [out][in] */ out IntPtr pvarPropertyValue);
    }
}
