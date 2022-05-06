﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3d9.h(197,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("794950f2-adfc-458a-905e-10a10b0b503b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DSwapChain9
    {
        [PreserveSig]
        HRESULT Present(ref tagRECT pSourceRect, ref tagRECT pDestRect, IntPtr hDestWindowOverride, ref _RGNDATA pDirtyRegion, uint dwFlags);
        
        [PreserveSig]
        HRESULT GetFrontBufferData(IDirect3DSurface9 pDestSurface);
        
        [PreserveSig]
        HRESULT GetBackBuffer(uint iBackBuffer, _D3DBACKBUFFER_TYPE Type, out IDirect3DSurface9 ppBackBuffer);
        
        [PreserveSig]
        HRESULT GetRasterStatus(ref _D3DRASTER_STATUS pRasterStatus);
        
        [PreserveSig]
        HRESULT GetDisplayMode(ref _D3DDISPLAYMODE pMode);
        
        [PreserveSig]
        HRESULT GetDevice(out IDirect3DDevice9 ppDevice);
        
        [PreserveSig]
        HRESULT GetPresentParameters(ref _D3DPRESENT_PARAMETERS_ pPresentationParameters);
    }
}
