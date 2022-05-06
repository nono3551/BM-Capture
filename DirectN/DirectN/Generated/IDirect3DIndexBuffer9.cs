﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3d9.h(192,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("7c9dd65e-d3f7-4529-acee-785830acde35"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DIndexBuffer9 : IDirect3DResource9
    {
        // IDirect3DResource9
        [PreserveSig]
        new HRESULT GetDevice(out IDirect3DDevice9 ppDevice);
        
        [PreserveSig]
        new HRESULT SetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid refguid, IntPtr pData, uint SizeOfData, uint Flags);
        
        [PreserveSig]
        new HRESULT GetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid refguid, IntPtr pData, ref uint pSizeOfData);
        
        [PreserveSig]
        new HRESULT FreePrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid refguid);
        
        [PreserveSig]
        new uint SetPriority(uint PriorityNew);
        
        [PreserveSig]
        new uint GetPriority();
        
        [PreserveSig]
        new void PreLoad();
        
        [PreserveSig]
        new _D3DRESOURCETYPE GetType();
        
        // IDirect3DIndexBuffer9
        [PreserveSig]
        HRESULT Lock(uint OffsetToLock, uint SizeToLock, IntPtr ppbData, uint Flags);
        
        [PreserveSig]
        HRESULT Unlock();
        
        [PreserveSig]
        HRESULT GetDesc(ref _D3DINDEXBUFFER_DESC pDesc);
    }
}
