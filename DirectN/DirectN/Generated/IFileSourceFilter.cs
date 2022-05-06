﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(6450,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("56a868a6-0ad4-11ce-b03a-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IFileSourceFilter
    {
        [PreserveSig]
        HRESULT Load(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszFileName, /* optional(_AMMediaType) */ IntPtr pmt);
        
        [PreserveSig]
        HRESULT GetCurFile(/* [annotation][out] _Out_ */ out IntPtr ppszFileName, /* optional(_AMMediaType) */ IntPtr pmt);
    }
}
