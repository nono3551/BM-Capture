using System;
using System.Collections.Generic;
using System.Linq;
using Windows.Media;
using Windows.Storage.Pickers;
using Windows.UI;
using BMCapture.Controls.MediaPlayer.Controls;
using BMCapture.Controls.MediaPlayer.Core;
using BMCapture.Controls.MediaPlayer.Playback;
using BMCapture.Native;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using WinRT;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace BMCapture
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public List<MediaPlayerElement> MediaPlayerElements = new();        

        private readonly MediaTimelineController mediaTimelineController = new();

        public MainWindow()
        {
            this.InitializeComponent();


            Title = "KlearTouch MediaPlayer for WinUI 3";

            // MediaPlayerElement1.AreTransportControlsEnabled = tre
            
            for (int i = 0; i < 1; i++)
            {
                var player = new MediaPlayerElement
                {
                    AreTransportControlsEnabled = false,
                    MediaTimelineController = mediaTimelineController
                };

                if (i % 3 == 0)
                {
                    Players4.Children.Add(player);
                }
                else if (i % 2 == 0)
                {
                    Players3.Children.Add(player);
                }
                else if (i % 1 == 0)
                {
                    Players2.Children.Add(player);
                }
                else if (i % 4 == 0)
                {
                    Players1.Children.Add(player);
                }

                MediaPlayerElements.Add(player);
            }

            var controls = new StackPanel { Orientation = Orientation.Horizontal, HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Top, Background = new SolidColorBrush(Color.FromArgb(0x99, 0, 0, 0)) };
            Root.Children.Add(controls);

            var openFile = new Button { Content = "Open File..." };
            openFile.Click += (_, _) => OpenFile();
            controls.Children!.Add(openFile);

            var openUri = new Button { Content = "Open Uri" };
            openUri.Click += (_, _) => OpenUri();
            controls.Children.Add(openUri);

            var play = new Button { Content = "Play" };
            play.Click += (_, _) => mediaTimelineController.Resume();
            controls.Children.Add(play);

            var pause = new Button { Content = "Pause" };
            pause.Click += (_, _) => mediaTimelineController.Pause();
            controls.Children.Add(pause);
        }

        private async void OpenFile()
        {
            var windowHandle = CastExtensions.As<IWindowNative>(this).WindowHandle;
            var picker = new FileOpenPicker();
            var initializeWithWindow = picker.As<IInitializeWithWindow>();
            initializeWithWindow.Initialize(windowHandle);

            picker.ViewMode = PickerViewMode.Thumbnail;
            picker.SuggestedStartLocation = PickerLocationId.VideosLibrary;
            picker.FileTypeFilter!.Add(".avi");
            picker.FileTypeFilter.Add(".mkv");
            picker.FileTypeFilter.Add(".mp4");

            var file = await picker.PickSingleFileAsync()!;
            if (file is null) return;


            var sources = new List<IMediaPlaybackSource>()
            {
                MediaSource.CreateFromStorageFile(file),
                MediaSource.CreateFromStorageFile(file),
                MediaSource.CreateFromStorageFile(file),
                MediaSource.CreateFromStorageFile(file),
                MediaSource.CreateFromStorageFile(file)
            };

            MediaPlayerElements.First()!.SetSources(sources);
            //
            // foreach (var element in MediaPlayerElements)
            // {
            //     if (element.MediaPlayer is null) element.SetMediaPlayer(new());
            //     element.MediaPlayer!.AutoPlay = false;
            //     element.MediaPlayer.Source = MediaSource.CreateFromStorageFile(file);
            //     element.UwpMediaPlayer.TimelineController = mediaTimelineController;
            // }
        }

        private void OpenUri()
        {
            var sources = new List<IMediaPlaybackSource>()
            {
                MediaSource.CreateFromUri(new("https://sec.ch9.ms/ch9/8791/ab3e65c2-619c-4d36-b7ca-abd0499a8791/WinUI.mp4", UriKind.Absolute)),
                MediaSource.CreateFromUri(new("https://sec.ch9.ms/ch9/8791/ab3e65c2-619c-4d36-b7ca-abd0499a8791/WinUI.mp4", UriKind.Absolute)),
                MediaSource.CreateFromUri(new("https://sec.ch9.ms/ch9/8791/ab3e65c2-619c-4d36-b7ca-abd0499a8791/WinUI.mp4", UriKind.Absolute))
            };

            MediaPlayerElements.First()!.SetSources(sources);

            // foreach (var element in MediaPlayerElements)
            // {
            //     if (element.MediaPlayer is null) element.SetMediaPlayer(new());
            //     element.MediaPlayer!.AutoPlay = false;
            //     element.MediaPlayer.Source = MediaSource.CreateFromUri(new("https://sec.ch9.ms/ch9/8791/ab3e65c2-619c-4d36-b7ca-abd0499a8791/WinUI.mp4", UriKind.Absolute));
            //     element.UwpMediaPlayer.TimelineController = mediaTimelineController;
            // }
        }
    }
}
