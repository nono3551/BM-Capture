﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsdkidl.h(7474,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("7688d8cb-fc0d-43bd-9459-5a8dec200cfa"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMStreamConfig2 : IWMStreamConfig
    {
        // IWMStreamConfig
        [PreserveSig]
        new HRESULT GetStreamType(/* [out] */ out Guid pguidStreamType);
        
        [PreserveSig]
        new HRESULT GetStreamNumber(/* [out] */ out ushort pwStreamNum);
        
        [PreserveSig]
        new HRESULT SetStreamNumber(/* [in] */ ushort wStreamNum);
        
        [PreserveSig]
        new HRESULT GetStreamName(/* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszStreamName, /* [out][in] */ ref ushort pcchStreamName);
        
        [PreserveSig]
        new HRESULT SetStreamName(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszStreamName);
        
        [PreserveSig]
        new HRESULT GetConnectionName(/* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszInputName, /* [out][in] */ ref ushort pcchInputName);
        
        [PreserveSig]
        new HRESULT SetConnectionName(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszInputName);
        
        [PreserveSig]
        new HRESULT GetBitrate(/* [out] */ out uint pdwBitrate);
        
        [PreserveSig]
        new HRESULT SetBitrate(/* [in] */ uint pdwBitrate);
        
        [PreserveSig]
        new HRESULT GetBufferWindow(/* [out] */ out uint pmsBufferWindow);
        
        [PreserveSig]
        new HRESULT SetBufferWindow(/* [in] */ uint msBufferWindow);
        
        // IWMStreamConfig2
        [PreserveSig]
        HRESULT GetTransportType(/* [out] */ out tagWMT_TRANSPORT_TYPE pnTransportType);
        
        [PreserveSig]
        HRESULT SetTransportType(/* [in] */ tagWMT_TRANSPORT_TYPE nTransportType);
        
        [PreserveSig]
        HRESULT AddDataUnitExtension(/* [in] */ Guid guidExtensionSystemID, /* [in] */ ushort cbExtensionDataSize, /* [size_is][in] */ [MarshalAs(UnmanagedType.LPArray)] byte[] pbExtensionSystemInfo, /* [in] */ uint cbExtensionSystemInfo);
        
        [PreserveSig]
        HRESULT GetDataUnitExtensionCount(/* [out] */ out ushort pcDataUnitExtensions);
        
        [PreserveSig]
        HRESULT GetDataUnitExtension(/* [in] */ ushort wDataUnitExtensionNumber, /* [out] */ out Guid pguidExtensionSystemID, /* [out] */ out ushort pcbExtensionDataSize, /* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] byte[] pbExtensionSystemInfo, /* [out][in] */ ref uint pcbExtensionSystemInfo);
        
        [PreserveSig]
        HRESULT RemoveAllDataUnitExtensions();
    }
}
