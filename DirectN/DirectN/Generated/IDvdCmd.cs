﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(23296,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("5a4a97e4-94ee-4a55-9751-74b5643aa27d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDvdCmd
    {
        [PreserveSig]
        HRESULT WaitForStart();
        
        [PreserveSig]
        HRESULT WaitForEnd();
    }
}
