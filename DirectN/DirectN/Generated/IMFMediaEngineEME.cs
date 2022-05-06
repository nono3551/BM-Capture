﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfmediaengine.h(4424,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("50dc93e4-ba4f-4275-ae66-83e836e57469"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaEngineEME
    {
        [PreserveSig]
        HRESULT get_Keys(/* [annotation] _COM_Outptr_result_maybenull_ */ out IMFMediaKeys keys);
        
        [PreserveSig]
        HRESULT SetMediaKeys(/* [annotation] _In_opt_ */ IMFMediaKeys keys);
    }
}
