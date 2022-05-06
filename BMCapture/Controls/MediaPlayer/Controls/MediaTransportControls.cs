// © 2022 KlearTouch, Pierre Henri KT. Licensed under the MIT license. See the LICENSE.txt file in the project root for more information.

using System;
using System.Globalization;
using Windows.UI;
using BMCapture.Controls.MediaPlayer.Playback;
using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Media;

namespace BMCapture.Controls.MediaPlayer.Controls;

/// <summary>Represents the playback controls for a media player element.</summary>
public class MediaTransportControls : UserControl, IMediaTransportControls
{
    private Playback.MediaPlayer? mediaPlayer;

    internal Playback.MediaPlayer? MediaPlayer
    {
        get => mediaPlayer;
        set
        {
            if (ReferenceEquals(mediaPlayer, value)) return;
            if (mediaPlayer is not null)
            {
                mediaPlayer.PlaybackSession.PlaybackStateChanged -= OnPlaybackSessionOnPlaybackStateChanged;
                mediaPlayer.PlaybackSession.NaturalDurationChanged -= OnNaturalDurationChanged;
                mediaPlayer.PlaybackSession.PositionChanged -= OnPositionChanged;
            }
            mediaPlayer = value;
            Reset();
            if (mediaPlayer is not null)
            {
                mediaPlayer.PlaybackSession.PlaybackStateChanged += OnPlaybackSessionOnPlaybackStateChanged;
                mediaPlayer.PlaybackSession.NaturalDurationChanged += OnNaturalDurationChanged;
                mediaPlayer.PlaybackSession.PositionChanged += OnPositionChanged;
            }
        }
    }

    /// <summary>Identifies the IsSeekBarVisible dependency property.</summary>
    /// <returns>The identifier for the IsSeekBarVisible dependency property.</returns>
    public static DependencyProperty IsSeekBarVisibleProperty { get; } =
        DependencyProperty.Register(nameof(IsSeekBarVisible), typeof(bool), typeof(MediaTransportControls), new(true, OnIsSeekBarVisibleChanged))!;

    /// <inheritdoc />
    public bool IsSeekBarVisible
    {
        get => (bool)GetValue(IsSeekBarVisibleProperty);
        set => SetValue(IsSeekBarVisibleProperty, value);
    }

    /// <summary>Identifies the IsSeekEnabled dependency property.</summary>
    /// <returns>The identifier for the IsSeekEnabled dependency property.</returns>
    public static DependencyProperty IsSeekEnabledProperty { get; } =
        DependencyProperty.Register(nameof(IsSeekEnabled), typeof(bool), typeof(MediaTransportControls), new(true, OnIsSeekEnabledChanged))!;

    /// <inheritdoc />
    public bool IsSeekEnabled
    {
        get => (bool)GetValue(IsSeekEnabledProperty);
        set => SetValue(IsSeekEnabledProperty, value);
    }

    private static void OnIsSeekBarVisibleChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
    {
        ((MediaTransportControls)dependencyObject).TimelineBorder.Visibility = (bool)args.NewValue ? Visibility.Visible : Visibility.Collapsed;
    }

    private static void OnIsSeekEnabledChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
    {
        ((MediaTransportControls)dependencyObject).ProgressSlider.IsEnabled = (bool)args.NewValue;
    }

    /// <inheritdoc />
    public void Show()
    {
        Opacity = 1;
    }

    /// <inheritdoc />
    public void Hide()
    {
        Opacity = 0;
    }



    private Border TimelineBorder { get; }
    private Slider ProgressSlider { get; }
    private TextBlock TimeRemainingElement { get; }
    private TextBlock TimeElapsedElement { get; }
    private FontIcon PlayPauseSymbol { get; }
    private const string PlayGlyph = "\xE102";
    private const string PauseGlyph = "\xE103";

    internal MediaTransportControls()
    {
        const double buttonSize = 48;

        FlowDirection = FlowDirection.LeftToRight;
        UseSystemFocusVisuals = true;

        var rootGrid = new Grid { Background = new SolidColorBrush(Colors.Transparent) };

        var controlPanelGrid = new Grid { Background = new SolidColorBrush(Color.FromArgb(0x99, 0, 0, 0)), VerticalAlignment = VerticalAlignment.Bottom };
        rootGrid.Children!.Add(controlPanelGrid);

        controlPanelGrid.RowDefinitions!.Add(new RowDefinition { Height = new(1, GridUnitType.Star) });
        controlPanelGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

        TimelineBorder = new();
        Grid.SetRow(TimelineBorder, 0);
        controlPanelGrid.Children!.Add(TimelineBorder);

        Grid timelineGrid = new();
        TimelineBorder.Child = timelineGrid;

        timelineGrid.ColumnDefinitions!.Add(new ColumnDefinition { Width = GridLength.Auto });
        timelineGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new(1, GridUnitType.Star) });
        timelineGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });

        ProgressSlider = new Slider { Height = 32, VerticalAlignment = VerticalAlignment.Center, IsThumbToolTipEnabled = false };
        ProgressSlider.ValueChanged += OnProgressSliderValueChanged;
        Grid.SetColumn(ProgressSlider, 1);
        timelineGrid.Children!.Add(ProgressSlider);

        TimeRemainingElement = new TextBlock { VerticalAlignment = VerticalAlignment.Center, Foreground = new SolidColorBrush(Colors.White), FontSize = 12, Margin = new(12, 0, 12, 0) };
        Grid.SetColumn(TimeRemainingElement, 0);
        timelineGrid.Children.Add(TimeRemainingElement);
        TimeElapsedElement = new TextBlock { VerticalAlignment = VerticalAlignment.Center, Foreground = new SolidColorBrush(Colors.White), FontSize = 12, Margin = new(12, 0, 12, 0) };
        Grid.SetColumn(TimeElapsedElement, 2);
        timelineGrid.Children.Add(TimeElapsedElement);

        var commandBar = new Grid { Height = buttonSize, Background = new SolidColorBrush(Colors.Transparent) };
        Grid.SetRow(commandBar, 1);
        controlPanelGrid.Children.Add(commandBar);

        var playPauseButton = new AppBarButton { Width = buttonSize, Height = buttonSize, Icon = PlayPauseSymbol = new FontIcon { Glyph = PlayGlyph }, HorizontalAlignment = HorizontalAlignment.Center };
        playPauseButton.Click += OnPlayPause;
        commandBar.Children!.Add(playPauseButton);

        Content = rootGrid;

        Reset();
    }

    private void Reset()
    {
        TimeRemainingElement.Text = ToString(TimeSpan.Zero);
        TimeElapsedElement.Text = ToString(TimeSpan.Zero) + " / " + ToString(TimeSpan.Zero);
        ProgressSlider.Value = 0;
        ProgressSlider.Minimum = 0;
        ProgressSlider.Maximum = 0;
        PlayPauseSymbol.Glyph = PlayGlyph;
    }

    private void OnProgressSliderValueChanged(object sender, RangeBaseValueChangedEventArgs e)
    {
        if (mediaPlayer is null)
            return;
        var newPosition = TimeSpan.FromSeconds(e.NewValue);
        var diff = mediaPlayer.PlaybackSession.Position - newPosition;
        if (Math.Abs(diff.TotalSeconds) > 1)
            mediaPlayer.PlaybackSession.Position = newPosition;
    }

    private void OnPlayPause(object sender, RoutedEventArgs e)
    {
        if (mediaPlayer is null)
            return;
        if (mediaPlayer.PlaybackSession.PlaybackState is MediaPlaybackState.Buffering or MediaPlaybackState.Playing)
            mediaPlayer.Pause();
        else
            mediaPlayer.Play();
    }

    private void OnPlaybackSessionOnPlaybackStateChanged(MediaPlaybackSession sender, object? args)
    {
#if WINDOWS_UWP
        _ = Dispatcher?.TryRunAsync(CoreDispatcherPriority.Normal, () =>
#else
        DispatcherQueue?.TryEnqueue(() =>
#endif
        {
            PlayPauseSymbol.Glyph = sender.PlaybackState is MediaPlaybackState.None or MediaPlaybackState.Opening or MediaPlaybackState.Paused ? PlayGlyph : PauseGlyph;
        });
    }

    private void OnNaturalDurationChanged(IMediaPlaybackSession sender, object? args)
    {
#if WINDOWS_UWP
        _ = Dispatcher?.TryRunAsync(CoreDispatcherPriority.Normal, () =>
#else
        DispatcherQueue?.TryEnqueue(() =>
#endif
        {
            ProgressSlider.Minimum = 0;
            ProgressSlider.Maximum = sender.NaturalDuration.TotalSeconds;
        });
    }

    private void OnPositionChanged(IMediaPlaybackSession sender, object? args)
    {
#if WINDOWS_UWP
        _ = Dispatcher?.TryRunAsync(CoreDispatcherPriority.Normal, () =>
#else
        DispatcherQueue?.TryEnqueue(() =>
#endif
        {
            var duration = sender.NaturalDuration;
            var elapsed = sender.Position;
            var remaining = elapsed - duration;
            TimeRemainingElement.Text = ToString(remaining);
            TimeElapsedElement.Text = ToString(elapsed) + " / " + ToString(duration);
            ProgressSlider.Value = elapsed.TotalSeconds;
        });
    }

    private static string ToString(TimeSpan value)
    {
        value = new TimeSpan(value.Ticks - value.Ticks % TimeSpan.TicksPerSecond); // Remove sub-second precision
        return value.ToString("g", CultureInfo.CurrentCulture);
    }
}