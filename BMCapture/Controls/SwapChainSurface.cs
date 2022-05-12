// © 2022 KlearTouch, Pierre Henri KT. Licensed under the MIT license. See the LICENSE.txt file in the project root for more information.

using System;
using System.Runtime.InteropServices;
using DirectN;
using Microsoft.UI.Xaml.Controls;
using WinRT;

namespace BMCapture.Controls;

public class SwapChainSurface : IDisposable
{
    private bool rendering;
    private IComObject<IDXGISwapChain1>? swapChain;
    IDXGISwapChain1? swapChainComObject;
    private IComObject<ID3D11RenderTargetView>? _renderTargetView;

    public event EventHandler<IComObject<ID3D11Device>?> Initialized;

    private SwapChainPanel SwapChainPanel { get; }

    public uint PanelWidth => Math.Max(1, (uint)Math.Ceiling(SwapChainPanel.ActualWidth * SwapChainPanel.CompositionScaleX));
    public uint PanelHeight => Math.Max(1, (uint)Math.Ceiling(SwapChainPanel.ActualHeight * SwapChainPanel.CompositionScaleY));

    public SwapChainSurface(SwapChainPanel swapChainPanel, Action onResize, EventHandler<IComObject<ID3D11Device>?> onInitialized)
    {
        Initialized += onInitialized;

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
        var flags = D3D11_CREATE_DEVICE_FLAG.D3D11_CREATE_DEVICE_BGRA_SUPPORT | D3D11_CREATE_DEVICE_FLAG.D3D11_CREATE_DEVICE_DEBUG;

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

        Initialized?.Invoke(this, d3dDevice);
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

    public void OnNewSurfaceAvailable(Action<ID3D11Device, ID3D11DeviceContext> updateSurface)
    {
        if (rendering)
        {
            return;
        }

        try
        {
            if (swapChain is null || swapChainComObject is null)
            {
                return;
            }

            swapChainComObject.GetDesc(out var swapChainDesc).ThrowOnError();

            if (swapChainDesc.BufferDesc.Width != PanelWidth || swapChainDesc.BufferDesc.Height != PanelHeight)
            {
                _renderTargetView?.Dispose();
                swapChainComObject.ResizeBuffers(2, PanelWidth, PanelHeight, DXGI_FORMAT.DXGI_FORMAT_UNKNOWN, 0).ThrowOnError();
                _renderTargetView = null;
            }

            var device = swapChain.Object.GetDevice1().Object.As<ID3D11Device>();

            device.GetImmediateContext(out var context);


            if (_renderTargetView == null)
            {
                var frameBuffer = swapChain.Object.GetBuffer<ID3D11Texture2D>(0);
                _renderTargetView = device.CreateRenderTargetView(frameBuffer.Object);
                frameBuffer.Dispose();
            }

            var backgroundColor = new float[] { 0x64 / 255.0f, 0x95 / 255.0f, 0xED / 255.0f, 1.0f };
            context.ClearRenderTargetView(_renderTargetView.Object, backgroundColor);
            context.OMSetRenderTargets(1, new ID3D11RenderTargetView[] { _renderTargetView.Object }, null);


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