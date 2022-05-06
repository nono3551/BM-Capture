﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(21326,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("683f7a5e-4a19-43cd-b1a9-dbf4ab3f7777"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSensorActivitiesReport
    {
        [PreserveSig]
        HRESULT GetCount(/* [annotation][out] _Out_ */ out uint pcCount);
        
        [PreserveSig]
        HRESULT GetActivityReport(/* [annotation][in] _In_ */ uint Index, /* [annotation][out] _COM_Outptr_ */ out IMFSensorActivityReport sensorActivityReport);
        
        [PreserveSig]
        HRESULT GetActivityReportByDeviceName(/* [annotation][in] _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string SymbolicName, /* [annotation][out] _COM_Outptr_ */ out IMFSensorActivityReport sensorActivityReport);
    }
}
