﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(7278,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("670d1d20-a068-11d0-b3f0-00aa003761c5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMCopyCaptureFileProgress
    {
        [PreserveSig]
        HRESULT Progress(/* [in] */ int iProgress);
    }
}
