﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmcodecdsp.h(4514,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("23fee831-ae96-42df-b170-25a04847a3ca"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ITocCollection
    {
        [PreserveSig]
        HRESULT GetEntryCount(/* [out] */ out uint pdwEntryCount);
        
        [PreserveSig]
        HRESULT GetEntryByIndex(/* [in] */ uint dwEntryIndex, /* [out] */ out IToc ppToc);
        
        [PreserveSig]
        HRESULT AddEntry(/* [in] */ IToc pToc, /* [out] */ out uint pdwEntryIndex);
        
        [PreserveSig]
        HRESULT AddEntryByIndex(/* [in] */ uint dwEntryIndex, /* [in] */ IToc pToc);
        
        [PreserveSig]
        HRESULT RemoveEntryByIndex(/* [in] */ uint dwEntryIndex);
    }
}
