﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(8824,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("56a868af-0ad4-11ce-b03a-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDistributorNotify
    {
        [PreserveSig]
        HRESULT Stop();
        
        [PreserveSig]
        HRESULT Pause();
        
        [PreserveSig]
        HRESULT Run(long tStart);
        
        [PreserveSig]
        HRESULT SetSyncSource(/* [in] */ IReferenceClock pClock);
        
        [PreserveSig]
        HRESULT NotifyGraphChange();
    }
}
