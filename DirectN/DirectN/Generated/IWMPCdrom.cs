﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmp.h(2516,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("cfab6e98-8730-11d3-b388-00c04f68574b"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public partial interface IWMPCdrom
    {
        [PreserveSig]
        HRESULT get_driveSpecifier(/* [retval][out] */ out IntPtr pbstrDrive);
        
        [PreserveSig]
        HRESULT get_playlist(/* [retval][out] */ out IWMPPlaylist ppPlaylist);
        
        [PreserveSig]
        HRESULT eject();
    }
}
