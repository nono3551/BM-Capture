using System;
using System.IO;
using BMCapture.OldWpf.DeckLink;
using DeckLinkAPI;

namespace BMCapture.OldWpf.Capturing;

public class CaptureManagerBuilder
{
    private SampleMemoryAllocator SampleMemoryAllocator { get; set; } = new();
    private DeckLinkDevice? DeckLinkDevice { get; set; }
    private _BMDDisplayMode? DisplayMode { get; set; }
    private Action<Bgra32VideoFrame>? PreviewCallback { get; set; }
    private bool DetectDisplayModeAutomatically { get; set; }
    private int VideoEncodedBitRate { get; set; } = 20 * 1000 * 1000;
    private int Interlace { get; set; } = 2;
    private uint PixelRatioWidth { get; set; } = 1;
    private uint PixelRatioHeight { get; set; } = 1;
    private uint FrameSizeWidth { get; set; } = 1920;
    private uint FrameSizeHeight { get; set; } = 1080;
    private uint FrameRate { get; set; } = 25000;
    private uint FrameRateMultiplier { get; set; } = 1000;
    private string CaptureDestination { get; set; } = Path.ChangeExtension(Path.GetTempFileName(), ".mp4");

    public CaptureManager Build()
    {
        return new CaptureManager()
        {
            SampleMemoryAllocator = SampleMemoryAllocator,
            VideoEncodedBitRate = VideoEncodedBitRate,
            FrameSizeWidth = FrameSizeWidth,
            FrameSizeHeight = FrameSizeHeight,
            FrameRate = FrameRate,
            FrameRateMultiplier = FrameRateMultiplier,
            Interlace = Interlace,
            PixelRatioWidth = PixelRatioWidth,
            PixelRatioHeight = PixelRatioHeight,
            CaptureDestination = CaptureDestination,
            DeckLinkDevice = DeckLinkDevice ?? throw new ArgumentNullException(nameof(DeckLinkDevice)),
            DisplayMode = DisplayMode,
            DetectDisplayModeAutomatically = DetectDisplayModeAutomatically,
            PreviewCallback = PreviewCallback
        };
    }

    public CaptureManagerBuilder SetFrameSize(uint width, uint height)
    {
        FrameSizeWidth = width;
        FrameSizeHeight = height;
        return this;
    }

    public CaptureManagerBuilder SetFrameRate(uint frameRate, uint multiplier)
    {
        FrameRate = frameRate;
        FrameRateMultiplier = multiplier;
        return this;
    }

    public CaptureManagerBuilder SetSampleMemoryAllocator(SampleMemoryAllocator memoryAllocator)
    {
        SampleMemoryAllocator = memoryAllocator;
        return this;
    }

    public CaptureManagerBuilder SetCaptureDestination(string captureDestination)
    {
        CaptureDestination = captureDestination;
        return this;
    }

    public CaptureManagerBuilder SetVideoEncodedBitRate(int videoEncodedBitRate)
    {
        VideoEncodedBitRate = videoEncodedBitRate;
        return this;
    }

    public CaptureManagerBuilder SetInterlace(int interlace)
    {
        Interlace = interlace;
        return this;
    }

    public CaptureManagerBuilder SetDisplayMode(_BMDDisplayMode displayMode)
    {
        DisplayMode = displayMode;
        return this;
    }

    public CaptureManagerBuilder SetDetectDisplayModeAutomatically(bool automatically)
    {
        DetectDisplayModeAutomatically = automatically;
        return this;
    }

    public CaptureManagerBuilder SetPixelRatio(uint width, uint height)
    {
        PixelRatioWidth = width;
        PixelRatioHeight = height;
        return this;
    }

    public CaptureManagerBuilder SetDeckLinkInputDevice(DeckLinkDevice deckLinkDevice)
    {
        DeckLinkDevice = deckLinkDevice;
        return this;
    }

    public CaptureManagerBuilder SetPreviewCallback(Action<Bgra32VideoFrame> previewCallback)
    {
        PreviewCallback = previewCallback;
        return this;
    }
}