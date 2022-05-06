﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(13116,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("e9931663-80bf-4c6e-98af-5dcf58747d1f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSaveJob
    {
        [PreserveSig]
        HRESULT BeginSave(/* [in] */ IMFByteStream pStream, /* [in] */ IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pState);
        
        [PreserveSig]
        HRESULT EndSave(/* [in] */ IMFAsyncResult pResult);
        
        [PreserveSig]
        HRESULT CancelSave();
        
        [PreserveSig]
        HRESULT GetProgress(/* [annotation][out] _Out_ */ out uint pdwPercentComplete);
    }
}
