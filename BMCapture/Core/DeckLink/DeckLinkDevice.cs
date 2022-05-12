using DeckLinkAPI;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System;
using System.IO;
using System.Linq;
using NAudio.Wave;
using BMCapture.Core.Capturing;

namespace BMCapture.Core.DeckLink;

public class DeckLinkDevice : IDeckLinkInputCallback
{
    public event DeckLinkInputSignalHandler? InputSignalChanged;
    public event DeckLinkFormatChangedHandler? InputFormatChanged;
    public event DeckLinkVideoFrameHandler? VideoFrameHandler;
    public event DeckLinkAudioPacketHandler? AudioPacketHandler;

    public _BMDAudioSampleType sampleType { get; set; } = _BMDAudioSampleType.bmdAudioSampleType16bitInteger;
    public _BMDPixelFormat PixelFormat { get; private set; } = _BMDPixelFormat.bmdFormat10BitYUV;
    public uint ChannelCount { set; get; } = 2;
    public int SampleTypeInt { get; set; } = 16;
    public int FrameHeight { get; private set; }
    public int FrameWidth { get; private set; }
    public long TimeScale { get; private set; }
    public long FrameDuration { get; private set; }

    private BufferedWaveProvider waveProvider;
    private WaveFormat waveFormatTarget;
    private DirectSoundOut waveOut = new DirectSoundOut();
    private Queue<byte[]> audioSamplesQueue = new();

    private MemoryStream memoryStream = new();

    #region Properties

    public IDeckLink DeckLink { get; private set; }
    public IDeckLinkInput DeckLinkInput { get; private set; }
    public IDeckLinkConfiguration DeckLinkConfiguration { get; private set; }
    public IDeckLinkProfileAttributes DeckLinkAttributes { get; private set; }
    public bool IsCapturing { get; private set; }
    public bool ApplyDetectedInputMode { get; private set; } = true;
    public bool HasInputSignal { get; private set; } = false;

    public IDeckLinkDisplayMode DisplayMode { get; private set; }

    public long SynchronizedPlaybackGroupId
    {
        get
        {
            long group;
            DeckLinkConfiguration.GetInt(_BMDDeckLinkConfigurationID.bmdDeckLinkConfigCaptureGroup, out group);
            return group;
        }
        set
        {
            long group;
            DeckLinkConfiguration.GetInt(_BMDDeckLinkConfigurationID.bmdDeckLinkConfigCaptureGroup, out group);
        }
    }

    public string DeviceName
    {
        get
        {
            string deviceName;
            DeckLink.GetDisplayName(out deviceName);
            return deviceName;
        }
    }

    public bool SupportsFormatDetection
    {
        get
        {
            int flag;
            var deckLinkAttributes = (IDeckLinkProfileAttributes)DeckLink;
            deckLinkAttributes.GetFlag(_BMDDeckLinkAttributeID.BMDDeckLinkSupportsInputFormatDetection, out flag);
            return flag != 0;
        }
    }

    public bool SupportsGroupPlayback
    {
        get
        {
            int flag;
            var deckLinkAttributes = (IDeckLinkProfileAttributes)DeckLink;
            deckLinkAttributes.GetFlag(_BMDDeckLinkAttributeID.BMDDeckLinkSupportsSynchronizeToPlaybackGroup,
                out flag);
            return flag != 0;
        }
    }

    public bool SupportsGroupCapture
    {
        get
        {
            int flag;
            var deckLinkAttributes = (IDeckLinkProfileAttributes)DeckLink;
            deckLinkAttributes.GetFlag(_BMDDeckLinkAttributeID.BMDDeckLinkSupportsSynchronizeToCaptureGroup,
                out flag);
            return flag != 0;
        }
    }

    public DisplayModeEnum DisplayModeEnum
    {
        get
        {
            IDeckLinkDisplayModeIterator displayModeIterator;
            DeckLinkInput.GetDisplayModeIterator(out displayModeIterator);
            return new DisplayModeEnum(displayModeIterator);
        }
    }

    #endregion

    public DeckLinkDevice(IDeckLink deckLink)
    {
        waveFormatTarget = new WaveFormat(48000, SampleTypeInt, (int)ChannelCount);

        DeckLink = deckLink;

        DeckLinkInput = (IDeckLinkInput)DeckLink;
        DeckLinkConfiguration = (IDeckLinkConfiguration)DeckLink;
        DeckLinkAttributes = (IDeckLinkProfileAttributes)DeckLink;

        InputSignalChanged += (wii) => { };

        waveProvider = new BufferedWaveProvider(waveFormatTarget);

        waveOut.Init(waveProvider);
        waveOut.Play();
        waveOut.Volume = 1;
    }

    public void StartCapture(_BMDDisplayMode? displayModeIn, bool applyDetectedInputMode, SampleMemoryAllocator? sampleMemoryAllocator)
    {
        var displayMode = displayModeIn ?? DisplayModeEnum.First().GetDisplayMode();

        if (!IsCapturing)
        {
            var videoInputFlags = _BMDVideoInputFlags.bmdVideoInputFlagDefault;

            ApplyDetectedInputMode = applyDetectedInputMode;
            HasInputSignal = false;

            // Enable input video mode detection if the device supports it
            if (SupportsFormatDetection && ApplyDetectedInputMode)
            {
                videoInputFlags |= _BMDVideoInputFlags.bmdVideoInputEnableFormatDetection;
            }

            // DeckLinkInput.SetScreenPreviewCallback(screenPreviewCallback);

            DeckLinkInput.SetVideoInputFrameMemoryAllocator(sampleMemoryAllocator);
            DeckLinkInput.SetCallback(this);

            DeckLinkInput.EnableVideoInput(displayMode, _BMDPixelFormat.bmdFormat8BitYUV, videoInputFlags);
            DeckLinkInput.EnableAudioInput(_BMDAudioSampleRate.bmdAudioSampleRate48kHz, sampleType, ChannelCount);

            DeckLinkInput.StartStreams();

            IsCapturing = true;
        }
    }

    public void StopCapture()
    {
        if (IsCapturing)
        {
            IsCapturing = false;

            RemoveAllListeners();

            MtaHelper.ExecuteMtaAction(() =>
            {
                // Stop the capture
                DeckLinkInput.StopStreams();

                // disable callbacks
                DeckLinkInput.DisableAudioInput();
                DeckLinkInput.DisableVideoInput();
                DeckLinkInput.SetScreenPreviewCallback(null);
                DeckLinkInput.SetCallback(null);
                DeckLinkInput.SetVideoInputFrameMemoryAllocator(null);
            });
        }
    }

    private void RemoveAllListeners()
    {
        InputSignalChanged = null;
        InputFormatChanged = null;
        VideoFrameHandler = null;
        AudioPacketHandler = null;
    }

    void IDeckLinkInputCallback.VideoInputFormatChanged(_BMDVideoInputFormatChangedEvents notificationEvents, IDeckLinkDisplayMode newDisplayMode, _BMDDetectedVideoInputFormatFlags detectedSignalFlags)
    {
        // Restart capture with the new video mode if told to
        if (!ApplyDetectedInputMode)
        {
            return;
        }

        if (notificationEvents.HasFlag(_BMDVideoInputFormatChangedEvents.bmdVideoInputColorspaceChanged))
        {
            if (detectedSignalFlags.HasFlag(_BMDDetectedVideoInputFormatFlags.bmdDetectedVideoInputRGB444))
            {
                PixelFormat = _BMDPixelFormat.bmdFormat8BitBGRA;
            }
            else if (detectedSignalFlags.HasFlag(_BMDDetectedVideoInputFormatFlags.bmdDetectedVideoInputYCbCr422))
            {
                PixelFormat = _BMDPixelFormat.bmdFormat8BitYUV;
            }
        }

        if (DisplayMode == newDisplayMode)
        {
            return;
        }

        var dominance = newDisplayMode.GetFieldDominance();
        newDisplayMode.GetFrameRate(out var frameDuration, out var timeScale);
        FrameWidth = newDisplayMode.GetWidth();
        FrameHeight = newDisplayMode.GetHeight();
        FrameDuration = frameDuration;
        TimeScale = timeScale;
        DisplayMode = newDisplayMode;

        // Stop the capture
        DeckLinkInput.StopStreams();

        // Set the video input mode
        DeckLinkInput.EnableVideoInput(newDisplayMode.GetDisplayMode(), PixelFormat, _BMDVideoInputFlags.bmdVideoInputFlagDefault);
        DeckLinkInput.EnableAudioInput(_BMDAudioSampleRate.bmdAudioSampleRate48kHz, sampleType, 2);

        // Start the capture
        DeckLinkInput.StartStreams();

        InputFormatChanged?.Invoke(newDisplayMode);
    }

    void IDeckLinkInputCallback.VideoInputFrameArrived(IDeckLinkVideoInputFrame? videoInputFrame, IDeckLinkAudioInputPacket? audioPacket)
    {
        if (audioPacket != null)
        {
            audioPacket.GetBytes(out var inputAudioBuffer);

            if (inputAudioBuffer != IntPtr.Zero)
            {
                AudioPacketHandler?.Invoke(audioPacket);

                var sampleCount = audioPacket.GetSampleFrameCount();
                var bufferLength = waveFormatTarget.BitsPerSample / 8 * waveFormatTarget.Channels * sampleCount;
                var tempBuffer = new byte[bufferLength];

                audioPacket.GetPacketTime(out var packetTime, CaptureManager.TimeScale);

                Marshal.Copy(inputAudioBuffer, tempBuffer, 0, bufferLength);

                Marshal.ReleaseComObject(audioPacket);

                waveProvider.AddSamples(tempBuffer, 0, tempBuffer.Length);
            }
        }

        if (videoInputFrame != null)
        {
            var hasInputSignal = !videoInputFrame.GetFlags().HasFlag(_BMDFrameFlags.bmdFrameHasNoInputSource);
            if (hasInputSignal)
            {
                VideoFrameHandler?.Invoke(videoInputFrame);
            }

            if (hasInputSignal != HasInputSignal)
            {
                HasInputSignal = hasInputSignal;
                InputSignalChanged?.Invoke(HasInputSignal);
            }

            Marshal.ReleaseComObject(videoInputFrame);
        }
    }
}