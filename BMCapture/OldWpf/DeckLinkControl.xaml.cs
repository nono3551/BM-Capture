using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using BMCapture.Controls.MediaPlayer.Controls;
using BMCapture.OldWpf.Capturing;
using BMCapture.OldWpf.DeckLink;
using DeckLinkAPI;
using DirectN;
using NAudio.Dmo;

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


            var previewPanel = new SwapChainPanel();

            previewSurface = new SwapChainSurface(previewPanel, () => { });

            PreviewRoot.Children.Add(previewPanel);

            m_deckLinkDiscovery = new DeckLinkDeviceDiscovery();
            m_deckLinkDiscovery.DeviceArrived += AddDevice;
            m_deckLinkDiscovery.DeviceRemoved += RemoveDevice;

            m_deckLinkDiscovery.Enable();
        }

        void VideoFrameArrived(Bgra32VideoFrame frame)
        {
            DispatcherQueue.TryEnqueue(() =>
            {
                previewSurface.OnNewSurfaceAvailable2((device, context) =>
                {
                    var size = frame.m_height * frame.m_height * 4;

                    D3D11_TEXTURE2D_DESC td;
                    td.ArraySize = 1;
                    td.BindFlags = (uint) D3D11_BIND_FLAG.D3D11_BIND_SHADER_RESOURCE;
                    td.Usage = D3D11_USAGE.D3D11_USAGE_DYNAMIC;
                    td.CPUAccessFlags = (uint) D3D11_CPU_ACCESS_FLAG.D3D11_CPU_ACCESS_WRITE;
                    td.Format = DXGI_FORMAT.DXGI_FORMAT_B8G8R8A8_UNORM;
                    td.Height = (uint) frame.m_height;
                    td.Width = (uint) frame.m_width;
                    td.MipLevels = 1;
                    td.MiscFlags = 0;
                    td.SampleDesc.Count = 1;
                    td.SampleDesc.Quality = 0;

                    D3D11_SUBRESOURCE_DATA srd;
                    srd.pSysMem = frame.m_pixelBuffer;
                    srd.SysMemPitch = (uint) frame.m_height;
                    srd.SysMemSlicePitch = 0;

                    var texture = device.CreateTexture2D<ID3D11Texture2D>(td, new []{srd});

                    var mappedResource = context.Map(texture.Object, 0, D3D11_MAP.D3D11_MAP_WRITE_DISCARD);

                    var mappedData = mappedResource.pData;
                    

                    unsafe
                    {
                        Buffer.MemoryCopy(frame.m_pixelBuffer.ToPointer(), mappedData.ToPointer(), size, size);
                    }


                    var pixelsInFrame = new byte[size];
                    var pixelsInResource = new byte[size];

                    Marshal.Copy(frame.m_pixelBuffer, pixelsInFrame, 0, size);
                    Marshal.Copy(mappedResource.pData, pixelsInResource, 0, size);
                    
                    context.Unmap(texture.Object, 0);
                });
            });
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
