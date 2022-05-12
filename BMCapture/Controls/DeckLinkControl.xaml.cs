using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using DeckLinkAPI;
using DirectN;
using NAudio.Dmo;
using BMCapture.Core.DeckLink;
using BMCapture.Core.Capturing;
using BMCapture.Core;
using BMCapture.Controls;
using DirectN.MinimalD3D11;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace BMCapture.OldWpf
{
    public sealed partial class DeckLinkControl : UserControl
    {
        private List<DeckLinkDevice> availableDeckLinks;
        
        private DeckLinkDeviceDiscovery m_deckLinkDiscovery;
        private CaptureManager? captureManager;
        private DeckLinkDevice? device;
        SwapChainSurface previewSurface;
        SwapChainPanel previewPanel;

        public DeckLinkControl()
        {
            this.InitializeComponent();

            availableDeckLinks = new();

            var inputTypes = new Dictionary<_BMDVideoConnection, string>()
            {
                {_BMDVideoConnection.bmdVideoConnectionSDI, "SDI"},
                {_BMDVideoConnection.bmdVideoConnectionHDMI, "HDMI"},
                {_BMDVideoConnection.bmdVideoConnectionOpticalSDI, "Optical SDI"},
                {_BMDVideoConnection.bmdVideoConnectionComponent, "Component"},
                {_BMDVideoConnection.bmdVideoConnectionComposite, "Composite"},
                {_BMDVideoConnection.bmdVideoConnectionSVideo, "S-Video"}
            };

            var pixelFormatMap = new Dictionary<_BMDPixelFormat, Guid>(){
                {_BMDPixelFormat.bmdFormat8BitYUV, AudioMediaSubtypes.MEDIASUBTYPE_UYVY},
                {_BMDPixelFormat.bmdFormat8BitBGRA, AudioMediaSubtypes.MEDIASUBTYPE_RGB32}
            };

            var videoInterlace = new Dictionary<_BMDFieldDominance, int>(){
                {_BMDFieldDominance.bmdUnknownFieldDominance, 0},
                {_BMDFieldDominance.bmdLowerFieldFirst, 4},
                {_BMDFieldDominance.bmdUpperFieldFirst, 3},
                {_BMDFieldDominance.bmdProgressiveFrame, 2}
            };


            previewPanel = new SwapChainPanel()
            {
                
            };

            previewSurface = new SwapChainSurface(previewPanel, () => { }, OnSwapChainSurfaceInitialized);

            PreviewRoot.Children.Add(previewPanel);

            m_deckLinkDiscovery = new DeckLinkDeviceDiscovery();
            m_deckLinkDiscovery.DeviceArrived += AddDevice;
            m_deckLinkDiscovery.DeviceRemoved += RemoveDevice;

            m_deckLinkDiscovery.Enable();
        }

        private IComObject<IDXGISwapChain1> _swapChain;
        private IComObject<ID3D11Buffer> _constantBuffer;
        private IComObject<ID3D11Buffer> _vertexBuffer;
        private IComObject<ID3D11Buffer> _indexBuffer;
        private IComObject<ID3D11RenderTargetView> _renderTargetView;
        private IComObject<ID3D11DepthStencilView> _depthBufferView;
        private IComObject<ID3D11InputLayout> _inputLayout;
        private IComObject<ID3D11VertexShader> _vertexShader;
        private IComObject<ID3D11PixelShader> _pixelShader;
        private IComObject<ID3D11DepthStencilState> _depthStencilState;
        private IComObject<ID3D11BlendState> _blendState;
        private IComObject<ID3D11SamplerState> _samplerState;
        private IComObject<ID3D11RasterizerState> _rasterizerState;
        private IComObject<ID3D11ShaderResourceView> _shaderResourceView;
        private IComObject<ID3D11Texture2D> _texture;


        private void OnSwapChainSurfaceInitialized(object? sender, IComObject<ID3D11Device>? deviceComObject)
        {
            var mt = deviceComObject.As<ID3D11Multithread>();
            mt?.SetMultithreadProtected(true);

            var desc = new DXGI_SWAP_CHAIN_DESC1();
            desc.Format = DXGI_FORMAT.DXGI_FORMAT_B8G8R8A8_UNORM_SRGB;
            desc.SampleDesc.Count = 1;
            desc.BufferUsage = Constants.DXGI_USAGE_RENDER_TARGET_OUTPUT;
            desc.BufferCount = 2;

            var vsBlob = D3D11Functions.D3DCompileFromFile("shaders.hlsl", "vs_main", "vs_5_0");
            _vertexShader = deviceComObject.CreateVertexShader(vsBlob);

            var inputElements = new D3D11_INPUT_ELEMENT_DESC[]
            {
                new D3D11_INPUT_ELEMENT_DESC
                {
                    SemanticName= "POSITION", Format =  DXGI_FORMAT.DXGI_FORMAT_R32G32B32_FLOAT, InputSlotClass = D3D11_INPUT_CLASSIFICATION.D3D11_INPUT_PER_VERTEX_DATA,
                },
                new D3D11_INPUT_ELEMENT_DESC
                {
                    SemanticName= "TEXCOORD", Format =  DXGI_FORMAT.DXGI_FORMAT_R32G32_FLOAT, InputSlotClass = D3D11_INPUT_CLASSIFICATION.D3D11_INPUT_PER_VERTEX_DATA, AlignedByteOffset = unchecked((uint)Constants.D3D11_APPEND_ALIGNED_ELEMENT)
                },

            };

            _inputLayout = deviceComObject.CreateInputLayout(inputElements, vsBlob);

            var psBlob = D3D11Functions.D3DCompileFromFile("shaders.hlsl", "ps_main", "ps_5_0");
            _pixelShader = deviceComObject.CreatePixelShader(psBlob);

            var vertexBufferDesc = new D3D11_BUFFER_DESC();
            var gc = GCHandle.Alloc(Data.VertexData, GCHandleType.Pinned);
            vertexBufferDesc.ByteWidth = (uint)Data.VertexData.SizeOf();
            vertexBufferDesc.Usage = D3D11_USAGE.D3D11_USAGE_DEFAULT;
            vertexBufferDesc.BindFlags = (uint)D3D11_BIND_FLAG.D3D11_BIND_VERTEX_BUFFER;

            var vertexData = new D3D11_SUBRESOURCE_DATA();
            vertexData.pSysMem = gc.AddrOfPinnedObject();
            _vertexBuffer = deviceComObject.CreateBuffer(vertexBufferDesc, vertexData);
            gc.Free();

            var indexBufferDesc = new D3D11_BUFFER_DESC();
            gc = GCHandle.Alloc(Data.IndexData, GCHandleType.Pinned);
            indexBufferDesc.ByteWidth = (uint)Data.IndexData.SizeOf();
            indexBufferDesc.Usage = D3D11_USAGE.D3D11_USAGE_IMMUTABLE;
            indexBufferDesc.BindFlags = (uint)D3D11_BIND_FLAG.D3D11_BIND_INDEX_BUFFER;

            var indexData = new D3D11_SUBRESOURCE_DATA();
            indexData.pSysMem = gc.AddrOfPinnedObject();
            _indexBuffer = deviceComObject.CreateBuffer(indexBufferDesc, indexData);
            gc.Free();

            var samplerDesc = new D3D11_SAMPLER_DESC();
            samplerDesc.Filter = D3D11_FILTER.D3D11_FILTER_MIN_MAG_MIP_LINEAR;
            samplerDesc.AddressU = D3D11_TEXTURE_ADDRESS_MODE.D3D11_TEXTURE_ADDRESS_WRAP;
            samplerDesc.AddressV = D3D11_TEXTURE_ADDRESS_MODE.D3D11_TEXTURE_ADDRESS_WRAP;
            samplerDesc.AddressW = D3D11_TEXTURE_ADDRESS_MODE.D3D11_TEXTURE_ADDRESS_WRAP;
            samplerDesc.MinLOD = 0;
            samplerDesc.MaxLOD = float.MaxValue;
            samplerDesc.ComparisonFunc = D3D11_COMPARISON_FUNC.D3D11_COMPARISON_NEVER;
            _samplerState = deviceComObject.CreateSamplerState(samplerDesc);
        }

        void VideoFrameArrived(Bgra32VideoFrame frame)
        {
            DispatcherQueue.TryEnqueue(() =>
            {
                previewSurface.OnNewSurfaceAvailable((d3D11Device, context) =>
                {
                    Render(frame, d3D11Device, context);
                });
            });
        }

        private void Render(Bgra32VideoFrame frame, ID3D11Device d3D11Device, ID3D11DeviceContext context)
        {
            if (_texture == null)
            {
                _texture?.Dispose();
                _shaderResourceView?.Dispose();

                var textureDesc = new D3D11_TEXTURE2D_DESC();
                textureDesc.Width = (uint) frame.m_width;
                textureDesc.Height = (uint) frame.m_height;
                textureDesc.MipLevels = 1;
                textureDesc.ArraySize = 1;
                textureDesc.Format = DXGI_FORMAT.DXGI_FORMAT_B8G8R8A8_UNORM;
                textureDesc.SampleDesc.Count = 1;
                textureDesc.Usage = D3D11_USAGE.D3D11_USAGE_DYNAMIC;
                textureDesc.BindFlags = (uint)D3D11_BIND_FLAG.D3D11_BIND_SHADER_RESOURCE;
                textureDesc.CPUAccessFlags = (uint)D3D11_CPU_ACCESS_FLAG.D3D11_CPU_ACCESS_WRITE;

                // var gc = GCHandle.Alloc(Data.TextureData, GCHandleType.Pinned);
                var textureData = new D3D11_SUBRESOURCE_DATA();
                textureData.pSysMem = frame.m_unmanagedBuffer;//gc.AddrOfPinnedObject();
                textureData.SysMemPitch = (uint) frame.m_row_bytes;
                // gc.Free();

                _texture = d3D11Device.CreateTexture2D<ID3D11Texture2D>(textureDesc, new []{ textureData });
                _shaderResourceView = d3D11Device.CreateShaderResourceView(_texture.Object);
            }

            var viewport = new D3D11_VIEWPORT();
            viewport.Width = previewSurface.PanelWidth;
            viewport.Height = previewSurface.PanelHeight;
            viewport.TopLeftX = 0;
            viewport.TopLeftY = 0;
            viewport.MaxDepth = 1;
            RenderTexture(frame, viewport, d3D11Device, context);
        }

        private void RenderTexture(Bgra32VideoFrame frame, D3D11_VIEWPORT viewport, ID3D11Device d3D11Device, ID3D11DeviceContext context)
        {
            uint stride = 5 * sizeof(float); // vertex size (12 floats: float3 position, float3 normal, float2 texcoord, float4 color)
            uint offset = 0;


            context.RSSetViewports(1, new D3D11_VIEWPORT[] { viewport });

            var mappedResource = context.Map(_texture.Object, 0, D3D11_MAP.D3D11_MAP_WRITE_DISCARD);

            uint iRowPitch = mappedResource.RowPitch;


            byte[] result = new byte[frame.m_row_bytes * frame.m_height];
            Marshal.Copy(frame.m_pixelBuffer, result, 0, result.Length);

            for (int iHeightIndex = 0; iHeightIndex < frame.m_height; iHeightIndex++)
            {
                var destination = new IntPtr(mappedResource.pData.ToInt64() + (iHeightIndex * iRowPitch));

                Marshal.Copy(result, iHeightIndex * frame.m_row_bytes, destination, frame.m_row_bytes);
            }

            context.Unmap(_texture.Object, 0);

            context.IASetPrimitiveTopology(D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_TRIANGLELIST);
            context.IASetInputLayout(_inputLayout.Object);
            context.IASetVertexBuffers(0, 1, new ID3D11Buffer[] { _vertexBuffer.Object }, new uint[] { stride }, new uint[] { offset });

            context.VSSetShader(_vertexShader.Object, null, 0);
            context.PSSetShader(_pixelShader.Object, null, 0);
            context.PSSetSamplers(0, 1, new ID3D11SamplerState[] { _samplerState.Object });
            context.PSSetShaderResources(0, 1, new[] { _shaderResourceView.Object });

            context.IASetIndexBuffer(_indexBuffer.Object, DXGI_FORMAT.DXGI_FORMAT_R32_UINT, 0);

            context.DrawIndexed((uint)Data.IndexData.Length, 0, 0);
        }



        void AddDevice(IDeckLink decklinkDevice)
        {
            DeckLinkDevice deckLink = new DeckLinkDevice(decklinkDevice);

            availableDeckLinks.Add(deckLink);

            var deviceName = deckLink.DeviceName;

            this.DispatcherQueue.TryEnqueue(() => DevicesComboBox.Items.Add(new ComboBoxItem()
            {
                Content = deviceName,
                Tag = deckLink
            }));
        }

        void RemoveDevice(IDeckLink decklinkDevice)
        {
            var device = availableDeckLinks.FirstOrDefault(x => x.DeckLink == decklinkDevice && x.IsCapturing);

            if (device != null)
            {
                device.StopCapture();
                availableDeckLinks.Remove(device);
            }
        }

        private async void OnStartCaptureClick(object sender, RoutedEventArgs e)
        {
            device = (DevicesComboBox.SelectedItem as ComboBoxItem)?.Tag as DeckLinkDevice;
            var selectedDisplayMode = (_BMDDisplayMode)((ModesComboBox.SelectedItem as ComboBoxItem)!).Tag;
            var detectFormat = AutoDetectMode.IsChecked == true;

            if (device != null)
            {
                if (captureManager != null)
                {
                    await captureManager.StopCapturing();
                }

                captureManager = new CaptureManagerBuilder()
                    .SetDetectDisplayModeAutomatically(detectFormat)
                    .SetDisplayMode(selectedDisplayMode)
                    .SetDeckLinkInputDevice(device)
                    .SetPreviewCallback(VideoFrameArrived)
                    .Build();

                captureManager?.StartCapture();
            }
        }

        private void DeviceComboBoxItemSelected(object sender, RoutedEventArgs e)
        {
            var device = (DevicesComboBox.SelectedItem as ComboBoxItem)?.Tag as DeckLinkDevice;

            string? deviceName = null;
            List<(_BMDDisplayMode displayMode, string displayModeName)>? displayModes = null;

            if (device != null)
            {
                MtaHelper.ExecuteMtaAction(() =>
                {
                    deviceName = MtaHelper.ExecuteMtaFunction(() => device?.DeviceName);
                    displayModes = MtaHelper.ExecuteMtaFunction(() => device?.DisplayModeEnum.Select(x =>
                    {
                        x.GetName(out var displayModeName);
                        var displayMode = x.GetDisplayMode();
                        return (displayMode, displayModeName);
                    }).ToList());
                });

                ModesComboBox.DispatcherQueue.TryEnqueue(() =>
                {
                    ModesComboBox.Items.Clear();

                    displayModes?.ForEach((item) =>
                    {
                        ModesComboBox.Items.Add(new ComboBoxItem()
                        {
                            Content = item.displayModeName,
                            Tag = item.displayMode
                        });
                    });
                });
            }
        }

        private void ModeComboBoxItemSelected(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AutoDetectMode_OnChecked(object sender, RoutedEventArgs e)
        {

        }

        private void AutoDetectMode_OnUnchecked(object sender, RoutedEventArgs e)
        {

        }

        private async void OnStopCaptureClick(object sender, RoutedEventArgs e)
        {
            await Task.Run(async () =>
            {
                await captureManager?.StopCapturing()!;
            });
        }
    }
}
