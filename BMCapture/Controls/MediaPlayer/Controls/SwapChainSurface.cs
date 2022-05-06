// © 2022 KlearTouch, Pierre Henri KT. Licensed under the MIT license. See the LICENSE.txt file in the project root for more information.

using System;
using System.Runtime.InteropServices;
using Windows.Graphics.DirectX.Direct3D11;
using DirectN;
using Microsoft.UI.Xaml.Controls;
using WinRT;

namespace BMCapture.Controls.MediaPlayer.Controls;

internal class SwapChainSurface : IDisposable
{
    private bool rendering;
    private IComObject<IDXGISwapChain1>? swapChain;
    IDXGISwapChain1? swapChainComObject;

    private SwapChainPanel SwapChainPanel { get; }

    private uint PanelWidth => Math.Max(1, (uint)Math.Ceiling(SwapChainPanel.ActualWidth * SwapChainPanel.CompositionScaleX));
    private uint PanelHeight => Math.Max(1, (uint)Math.Ceiling(SwapChainPanel.ActualHeight * SwapChainPanel.CompositionScaleY));

    public SwapChainSurface(SwapChainPanel swapChainPanel, Action onResize)
    {
        SwapChainPanel = swapChainPanel;
        Initialize();

        void ResizeBuffers()
        {
            try
            {
                swapChain?.Object.ResizeBuffers(2, PanelWidth, PanelHeight, DXGI_FORMAT.DXGI_FORMAT_UNKNOWN, 0).ThrowOnError();
                onResize();
            }
            catch (ObjectDisposedException)
            {
                Reinitialize();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("\nException: " + ex, nameof(SwapChainSurface) + '.' + nameof(ResizeBuffers));
            }
        }

        SwapChainPanel.SizeChanged += (_, _) => ResizeBuffers();
        SwapChainPanel.CompositionScaleChanged += (_, _) => ResizeBuffers();
    }

    private void Reinitialize()
    {
        Dispose();
        Initialize();
    }

    private void Initialize()
    {
        var featureLevels = new[] { D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_11_0 };
        var flags = D3D11_CREATE_DEVICE_FLAG.D3D11_CREATE_DEVICE_BGRA_SUPPORT;

        using IComObject<ID3D11Device>? d3dDevice = D3D11Functions.D3D11CreateDevice(null, D3D_DRIVER_TYPE.D3D_DRIVER_TYPE_HARDWARE, flags, featureLevels);
        
        var swapChainDescription = new DXGI_SWAP_CHAIN_DESC1
        {
            Width = PanelWidth,
            Height = PanelHeight,
            Format = DXGI_FORMAT.DXGI_FORMAT_B8G8R8A8_UNORM,
            Stereo = false,
            SampleDesc = new DXGI_SAMPLE_DESC { Count = 1, Quality = 0 },
            BufferUsage = Constants.DXGI_USAGE_RENDER_TARGET_OUTPUT,
            BufferCount = 2,
            Scaling = DXGI_SCALING.DXGI_SCALING_STRETCH,
            SwapEffect = DXGI_SWAP_EFFECT.DXGI_SWAP_EFFECT_FLIP_SEQUENTIAL,
            AlphaMode = DXGI_ALPHA_MODE.DXGI_ALPHA_MODE_PREMULTIPLIED,
            Flags = 0
        };

        IDXGIDevice? dxgiDevice = d3dDevice.As<IDXGIDevice1>();
        using var adapter = dxgiDevice.GetAdapter();
        using var dxgiFactory = adapter.GetParent<IDXGIFactory2>();
        swapChain = dxgiFactory.CreateSwapChainForComposition<IDXGISwapChain1>(d3dDevice, swapChainDescription);

        swapChainComObject = swapChain!.Object;

        SetSwapChain(false);
    }

    public void Dispose()
    {
        SetSwapChain(true);
        if (swapChain is not null && !swapChain.IsDisposed) swapChain.Dispose();
        swapChain = null;
    }

    private void SetSwapChain(bool toNull)
    {
        var guidNativePanel = typeof(ISwapChainPanelNative).GUID;
        var swapChainPanelPtr = Marshal.GetIUnknownForObject(SwapChainPanel);
        new HRESULT(Marshal.QueryInterface(swapChainPanelPtr, ref guidNativePanel, out var pNativePanel)).ThrowOnError();
        Marshal.Release(swapChainPanelPtr);
        var nativePanel = (ISwapChainPanelNative)Marshal.GetObjectForIUnknown(pNativePanel);

        nativePanel.SetSwapChain(toNull ? null : swapChainComObject).ThrowOnError();

        Marshal.ReleaseComObject(nativePanel);
    }

    public void OnNewSurfaceAvailable(Action<IDirect3DSurface> updateSurface)
    {
        if (rendering)
        {
#if DEBUG
            System.Diagnostics.Debug.WriteLine("Warning: Still rendering the previous frame, so skipping this one", nameof(SwapChainSurface) + '.' + nameof(OnNewSurfaceAvailable));
#endif
            return;
        }

        try
        {
            if (this.swapChain is null || swapChainComObject is null)
            {
                return;
            }
            
            swapChainComObject.GetDesc(out var desc).ThrowOnError();
            
            if (desc.BufferDesc.Width != PanelWidth || desc.BufferDesc.Height != PanelHeight)
            {
                swapChainComObject.ResizeBuffers(2, PanelWidth, PanelHeight, DXGI_FORMAT.DXGI_FORMAT_UNKNOWN, 0).ThrowOnError();
            }

            using var dxgiSurface = swapChainComObject.GetBuffer<IDXGISurface>(0);
            var dxgiSurfacePtr = Marshal.GetComInterfaceForObject<IDXGISurface, IDXGISurface>(dxgiSurface.Object);
                                                   
            CreateDirect3D11SurfaceFromDXGISurface(dxgiSurfacePtr, out var graphicsSurface).ThrowOnError();
            Marshal.Release(dxgiSurfacePtr);

            using var d3DSurface = WinRT.MarshalInterface<IDirect3DSurface>.FromAbi(graphicsSurface)!;
            
            Marshal.Release(graphicsSurface);

            updateSurface(d3DSurface);
            
            swapChainComObject.Present(1, 0).ThrowOnError();
        }
        catch (ObjectDisposedException)
        {
            Reinitialize();
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine("\nException: " + ex, nameof(SwapChainSurface) + '.' + nameof(OnNewSurfaceAvailable));
        }

        rendering = false;
    }

    public void OnNewSurfaceAvailable2(Action<ID3D11Device, ID3D11DeviceContext> updateSurface)
    {
        if (rendering)
        {
            return;
        }

        try
        {
            if (this.swapChain is null || swapChainComObject is null)
            {
                return;
            }

            swapChainComObject.GetDesc(out var swapChainDesc).ThrowOnError();

            if (swapChainDesc.BufferDesc.Width != PanelWidth || swapChainDesc.BufferDesc.Height != PanelHeight)
            {
                swapChainComObject.ResizeBuffers(2, PanelWidth, PanelHeight, DXGI_FORMAT.DXGI_FORMAT_UNKNOWN, 0).ThrowOnError();
            }

            var device = swapChain.Object.GetDevice1().Object.As<ID3D11Device>();

            device.GetImmediateContext(out var context);

            // context.ClearRenderTargetView(renderTargetView.Object, new []{0f, 1f, 1f, 1f});

            updateSurface(device, context);

            swapChainComObject.Present(1, 0).ThrowOnError();
        }
        catch (ObjectDisposedException)
        {
            Reinitialize();
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine("\nException: " + ex, nameof(SwapChainSurface) + '.' + nameof(OnNewSurfaceAvailable));
        }

        rendering = false;
    }

    [DllImport("d3d11.dll", EntryPoint = nameof(CreateDirect3D11SurfaceFromDXGISurface), SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    private static extern HRESULT CreateDirect3D11SurfaceFromDXGISurface(IntPtr dxgiSurface, out IntPtr graphicsSurface);
}