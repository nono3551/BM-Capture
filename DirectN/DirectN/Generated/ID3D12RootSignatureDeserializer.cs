﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(3717,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("34ab647b-3cc8-46ac-841b-c0965645c046"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12RootSignatureDeserializer
    {
        [PreserveSig]
        void GetRootSignatureDesc(out D3D12_ROOT_SIGNATURE_DESC size);
    }
}
