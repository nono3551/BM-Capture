﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfmediaengine.h(3534,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("87e47623-2ceb-45d6-9b88-d8520c4dcbbc"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSourceBufferNotify
    {
        [PreserveSig]
        void OnUpdateStart();
        
        [PreserveSig]
        void OnAbort();
        
        [PreserveSig]
        void OnError(/* [annotation][in] _In_ */ HRESULT hr);
        
        [PreserveSig]
        void OnUpdate();
        
        [PreserveSig]
        void OnUpdateEnd();
    }
}
