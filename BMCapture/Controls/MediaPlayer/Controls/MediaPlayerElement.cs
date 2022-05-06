// © 2022 KlearTouch, Pierre Henri KT. Licensed under the MIT license. See the LICENSE.txt file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using Windows.Media;
using BMCapture.Controls.MediaPlayer.Playback;
using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Media;
using UwpMediaPlayer = Windows.Media.Playback.MediaPlayer;

#pragma warning disable CS0618 // 'UwpMediaPlayer' is obsolete

namespace BMCapture.Controls.MediaPlayer.Controls;

/// <summary>Represents an object that uses a MediaPlayer to render audio and video to the display.</summary>
public class MediaPlayerElement : UserControl, IMediaPlayerElement
{
    private SwapChainPanel SwapChainPanel { get; }
    private SwapChainSurface? SwapChainSurface { get; set; }

    /// <summary>Gets the UWP MediaPlayer.</summary>
    [Obsolete("Access the full UWP API at your own risk. The MediaPlayer API may be different in the future WinUI version.")]
    public UwpMediaPlayer? UwpMediaPlayer => MediaPlayer?.UwpInstance;

    /// <inheritdoc />
    public Playback.MediaPlayer? MediaPlayer
    {
        get => TransportControls.MediaPlayer;
        private set => TransportControls.MediaPlayer = value;
    }

    /// <inheritdoc />
    public MediaTransportControls TransportControls { get; }

    /// <summary>Identifies the AreTransportControlsEnabled dependency property.</summary>
    /// <returns>The identifier for the AreTransportControlsEnabled dependency property.</returns>
    public static DependencyProperty AreTransportControlsEnabledProperty { get; } =
        DependencyProperty.Register(nameof(AreTransportControlsEnabled), typeof(bool), typeof(MediaPlayerElement), new(false))!;

    /// <inheritdoc />
    public bool AreTransportControlsEnabled
    {
        get => (bool)GetValue(AreTransportControlsEnabledProperty);
        set => SetValue(AreTransportControlsEnabledProperty, value);
    }


    /// <summary>Initializes a new instance of the MediaPlayerElement class.</summary>
    public MediaPlayerElement()
    {
        HorizontalAlignment = HorizontalAlignment.Stretch;
        VerticalAlignment = VerticalAlignment.Stretch;
        IsTabStop = false;

        Grid layoutRoot = new() { Background = new SolidColorBrush(Colors.Transparent) };

        layoutRoot.Children!.Add(SwapChainPanel = new());

        Border transportControlsPresenter = new();
        layoutRoot.Children.Add(transportControlsPresenter);
        transportControlsPresenter.SetBinding(VisibilityProperty!, new Binding { Source = this, Path = new(nameof(AreTransportControlsEnabled)) });
        transportControlsPresenter.Child = TransportControls = new();

        Content = layoutRoot;
    }

    private List<SwapChainPanel>? SwapChainPanels { get; set; }
    private List<SwapChainSurface>? SwapChainSurfaces { get; set; }
    private List<Playback.MediaPlayer>? MediaPlayers { get; set; }
    public MediaTimelineController? MediaTimelineController { get; set; }

    public void SetSources(List<IMediaPlaybackSource> sources)
    {
        if (SwapChainSurfaces != null)
        {
            foreach (var swapChainSurface in SwapChainSurfaces)
            {
                swapChainSurface.Dispose();
            }

            SwapChainSurfaces = null;
        }

        if (MediaPlayers != null)
        {
            foreach (Playback.MediaPlayer mediaPlayer in MediaPlayers)
            {
                mediaPlayer.UwpInstance.VideoFrameAvailable -= OnVideoFrameAvailable;
                mediaPlayer.UwpInstance.Dispose();
            }

            MediaPlayers = null;
        }

        SwapChainPanels = new();
        SwapChainSurfaces = new();
        MediaPlayers = new();

        foreach (var source in sources)
        {
            Playback.MediaPlayer mediaPlayer = new();
            SwapChainPanel swapChainPanel= new()
            {
                Width = 300,
                Height = 300
            };
            SwapChainSurface swapChainSurface = new(swapChainPanel, OnResize);
            SwapChainPanels.Add(swapChainPanel);
            SwapChainSurfaces.Add(swapChainSurface);

            mediaPlayer.UwpInstance.IsVideoFrameServerEnabled = true;

            if (!MediaPlayers.Any())
            {
                mediaPlayer.UwpInstance.VideoFrameAvailable += OnVideoFrameAvailable;
            }

            mediaPlayer.Source = source;
            mediaPlayer.UwpInstance.TimelineController = MediaTimelineController;

            MediaPlayers.Add(mediaPlayer);
        }


        var layoutRoot = new StackPanel { Orientation = Orientation.Vertical, HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Top, Background = new SolidColorBrush(Colors.Transparent) };
        

        foreach (var swapChainPanel in SwapChainPanels)
        {
            layoutRoot.Children!.Add(swapChainPanel);
        }

        Content = layoutRoot;
    }


    /// <inheritdoc />
    public void SetMediaPlayer(Playback.MediaPlayer? mediaPlayer)
    {
        if (MediaPlayer == mediaPlayer)
            return;
        if (MediaPlayer is not null) // Dispose the previous one
        {
            SwapChainSurface?.Dispose();
            SwapChainSurface = null;
            UwpMediaPlayer!.VideoFrameAvailable -= OnVideoFrameAvailable;
            UwpMediaPlayer.Dispose();
        }
        MediaPlayer = mediaPlayer;
        if (MediaPlayer is not null)
        {
            SwapChainSurface = new(SwapChainPanel, OnResize);
            UwpMediaPlayer!.IsVideoFrameServerEnabled = true;
            UwpMediaPlayer.VideoFrameAvailable += OnVideoFrameAvailable;
        }
    }

    private void OnResize() // if (MediaPlayer is paused) we need to ask it to re-render a frame // TODO: Find a better solution
    {
        if (UwpMediaPlayer?.CurrentState is not global::Windows.Media.Playback.MediaPlayerState.Paused) return;
        var duration = UwpMediaPlayer.PlaybackSession!.NaturalDuration;
        if (duration > TimeSpan.Zero && UwpMediaPlayer.PlaybackSession.Position + TimeSpan.FromSeconds(0.042 * 2) < duration)
            UwpMediaPlayer.StepForwardOneFrame();
        else
            UwpMediaPlayer.StepBackwardOneFrame();
    }
    
    private void OnVideoFrameAvailable(UwpMediaPlayer sender, object? args)
    {
        SwapChainPanel.DispatcherQueue?.TryEnqueue(() =>
        {
            for (int i = 0; i < SwapChainSurfaces!.Count; i++)
            {
                SwapChainSurfaces[i]?.OnNewSurfaceAvailable(MediaPlayers![i].UwpInstance.CopyFrameToVideoSurface);
            }
        });
    }
}