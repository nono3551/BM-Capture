﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1_1.h(2371,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// A locking mechanism from a Direct2D factory that Direct2D uses to control exclusive resource access in an app that is uses multiple threads.
    /// </summary>
    [ComImport, Guid("31e6e7bc-e0ff-4d46-8c64-a0a8c41c15d3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1Multithread
    {
        [PreserveSig]
        bool GetMultithreadProtected();
        
        [PreserveSig]
        void Enter();
        
        [PreserveSig]
        void Leave();
    }
}
