﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfmediaengine.h(8709,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("db639199-c809-4c89-bfca-d0bbb9729d6e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFTimedTextStyle2
    {
        [PreserveSig]
        HRESULT GetRuby(/* [annotation][out] _COM_Outptr_result_maybenull_ */ out IMFTimedTextRuby ruby);
        
        [PreserveSig]
        HRESULT GetBouten(/* [annotation][out] _COM_Outptr_result_maybenull_ */ out IMFTimedTextBouten bouten);
        
        [PreserveSig]
        HRESULT IsTextCombined(/* [annotation][out] _Out_ */ out bool value);
        
        [PreserveSig]
        HRESULT GetFontAngleInDegrees(/* [annotation][out] _Out_ */ out double value);
    }
}
