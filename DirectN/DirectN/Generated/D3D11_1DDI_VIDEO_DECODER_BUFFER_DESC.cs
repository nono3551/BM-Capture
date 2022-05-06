﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(3155,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_1DDI_VIDEO_DECODER_BUFFER_DESC
    {
        public D3D10DDI_HRESOURCE hResource;
        public D3D11_DDI_VIDEO_DECODER_BUFFER_TYPE BufferType;
        public uint BufferIndex;
        public uint DataOffset;
        public uint DataSize;
        public uint FirstMBaddress;
        public uint NumMBsInBuffer;
        public uint Width;
        public uint Height;
        public uint Stride;
        public uint ReservedBits;
        public IntPtr pIV;
        public uint IVSize;
        public bool PartialEncryption;
        public D3D11_1DDI_ENCRYPTED_BLOCK_INFO EncryptedBlockInfo;
    }
}
