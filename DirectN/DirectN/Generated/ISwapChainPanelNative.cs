// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\windows.ui.xaml.media.dxinterop.h(854,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("63aad0b8-7c24-40ff-85a8-640d944cc325"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISwapChainPanelNative
    {
        [PreserveSig]
        HRESULT SetSwapChain(/* [annotation][in] _In_ */ IDXGISwapChain swapChain);
    }
}
