using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using BMCapture.Core.DeckLink;
using BMCapture.Core.MediaFoundation;
using DeckLinkAPI;
using NAudio.Dmo;
using NAudio.MediaFoundation;

namespace BMCapture.Core.Capturing;

public class CaptureManager
{
    public const int TimeScale = 10 * 1000 * 1000;

    public bool IsCapturing { get; private set; }

    public DeckLinkDevice? DeckLinkDevice { get; init; }
    public bool DetectDisplayModeAutomatically { get; init; }
    public _BMDDisplayMode? DisplayMode { get; init; }
    public SampleMemoryAllocator? SampleMemoryAllocator { get; init; }
    public Action<Bgra32VideoFrame>? PreviewCallback { init; get; }
    public int VideoEncodedBitRate { get; init; }
    public int Interlace { get; init; }
    public uint FrameSizeWidth { get; init; }
    public uint FrameSizeHeight { get; init; }
    public uint FrameRate { get; init; }
    public uint FrameRateMultiplier { get; init; }
    public uint PixelRatioWidth { get; init; }
    public uint PixelRatioHeight { get; init; }
    public string? CaptureDestination { get; init; }

    private Queue<IMFSample>? audioSampleQueue;

    private int videoStreamIndex;
    private int audioStreamIndex;
    private CancellationTokenSource? cancellationTokenSource;
    private SemaphoreSlim audioQueueSemaphore = new(0, int.MaxValue);

    private IMFSinkWriter? sinkWriter;
    private IMFMediaType? videoMediaTypeOut;
    private IMFMediaType? videoMediaTypeIn;
    private IMFMediaType? audioMediaTypeOut;
    private IMFMediaType? audioMediaTypeIn;

    internal CaptureManager()
    {

    }

    ~CaptureManager()
    {
        if (sinkWriter != null) Marshal.ReleaseComObject(sinkWriter);
        sinkWriter = null;

        if (videoMediaTypeOut != null) Marshal.ReleaseComObject(videoMediaTypeOut);
        videoMediaTypeOut = null;

        if (videoMediaTypeIn != null) Marshal.ReleaseComObject(videoMediaTypeIn);
        videoMediaTypeIn = null;

        if (audioMediaTypeOut != null) Marshal.ReleaseComObject(audioMediaTypeOut);
        audioMediaTypeOut = null;

        if (audioMediaTypeIn != null) Marshal.ReleaseComObject(audioMediaTypeIn);
        audioMediaTypeIn = null;
    }

    public void StartCapture()
    {
        if (IsCapturing)
        {
            return;
        }

        MtaHelper.ExecuteMtaAction(() =>
        {
            MediaFoundationApi.Startup();
            MediaFoundationInterop.MFCreateSinkWriterFromURL(CaptureDestination, null, null, out sinkWriter);

            ConfigureVideoEncoder();
            ConfigureAudioEncoder();
        });

        StartCapturingThread();

        IsCapturing = true;
    }

    public async Task StopCapturing()
    {
        await Task.Run(() =>
        {
            if (DeckLinkDevice != null)
            {
                MtaHelper.ExecuteMtaAction(DeckLinkDevice.StopCapture);
            }
            cancellationTokenSource?.Cancel(false);
            IsCapturing = false;
        });
    }

    private void ConfigureVideoEncoder()
    {
        videoMediaTypeOut = MediaFoundationApi.CreateMediaType();
        videoMediaTypeOut.SetGUID(MediaFoundationAttributes.MF_MT_MAJOR_TYPE, MediaTypes.MFMediaType_Video);
        videoMediaTypeOut.SetGUID(MediaFoundationAttributes.MF_MT_SUBTYPE, MediaFoundationHelper.MEDIASUBTYPE_H264);
        videoMediaTypeOut.SetUINT32(MediaFoundationAttributes.MF_MT_AVG_BITRATE, VideoEncodedBitRate);
        videoMediaTypeOut.SetUINT32(MediaFoundationHelper.MF_MT_INTERLACE_MODE, Interlace);

        MediaFoundationHelper.MFSetAttributeSize(videoMediaTypeOut, MediaFoundationHelper.MF_MT_FRAME_SIZE, FrameSizeWidth, FrameSizeHeight);
        MediaFoundationHelper.MFSetAttributeSize(videoMediaTypeOut, MediaFoundationHelper.MF_MT_FRAME_RATE, FrameRate, FrameRateMultiplier);
        MediaFoundationHelper.MFSetAttributeSize(videoMediaTypeOut, MediaFoundationHelper.MF_MT_PIXEL_ASPECT_RATIO, PixelRatioWidth, PixelRatioHeight);

        sinkWriter?.AddStream(videoMediaTypeOut, out videoStreamIndex);

        videoMediaTypeIn = MediaFoundationApi.CreateMediaType();
        videoMediaTypeIn.SetGUID(MediaFoundationAttributes.MF_MT_MAJOR_TYPE, MediaTypes.MFMediaType_Video);
        videoMediaTypeIn.SetGUID(MediaFoundationAttributes.MF_MT_SUBTYPE, AudioMediaSubtypes.MEDIASUBTYPE_UYVY);
        videoMediaTypeIn.SetUINT32(MediaFoundationHelper.MF_MT_INTERLACE_MODE, Interlace);

        MediaFoundationHelper.MFSetAttributeSize(videoMediaTypeIn, MediaFoundationHelper.MF_MT_FRAME_SIZE, FrameSizeWidth, FrameSizeHeight);
        MediaFoundationHelper.MFSetAttributeSize(videoMediaTypeIn, MediaFoundationHelper.MF_MT_FRAME_RATE, FrameRate, FrameRateMultiplier);
        MediaFoundationHelper.MFSetAttributeSize(videoMediaTypeIn, MediaFoundationHelper.MF_MT_PIXEL_ASPECT_RATIO, PixelRatioWidth, PixelRatioHeight);

        sinkWriter?.SetInputMediaType(videoStreamIndex, videoMediaTypeIn, null);
    }

    private void ConfigureAudioEncoder()
    {
        audioMediaTypeOut = MediaFoundationApi.CreateMediaType();
        audioMediaTypeOut.SetGUID(MediaFoundationAttributes.MF_MT_MAJOR_TYPE, MediaTypes.MFMediaType_Audio);
        audioMediaTypeOut.SetGUID(MediaFoundationAttributes.MF_MT_SUBTYPE, MediaFoundationHelper.MFAudioFormat_AAC);
        audioMediaTypeOut.SetUINT32(MediaFoundationAttributes.MF_MT_AUDIO_NUM_CHANNELS, 2);
        audioMediaTypeOut.SetUINT32(MediaFoundationAttributes.MF_MT_AUDIO_SAMPLES_PER_SECOND, (int)_BMDAudioSampleRate.bmdAudioSampleRate48kHz);
        audioMediaTypeOut.SetUINT32(MediaFoundationAttributes.MF_MT_AUDIO_BITS_PER_SAMPLE, 16);
        audioMediaTypeOut.SetUINT32(MediaFoundationAttributes.MF_MT_AUDIO_AVG_BYTES_PER_SECOND, 192000 / 8);

        sinkWriter?.AddStream(audioMediaTypeOut, out audioStreamIndex);

        audioMediaTypeIn = MediaFoundationApi.CreateMediaType();
        audioMediaTypeIn.SetGUID(MediaFoundationAttributes.MF_MT_MAJOR_TYPE, MediaTypes.MFMediaType_Audio);
        audioMediaTypeIn.SetGUID(MediaFoundationAttributes.MF_MT_SUBTYPE, MediaFoundationHelper.MFAudioFormat_PCM);
        audioMediaTypeIn.SetUINT32(MediaFoundationAttributes.MF_MT_AUDIO_NUM_CHANNELS, 2);
        audioMediaTypeIn.SetUINT32(MediaFoundationAttributes.MF_MT_AUDIO_SAMPLES_PER_SECOND, (int)_BMDAudioSampleRate.bmdAudioSampleRate48kHz);
        audioMediaTypeIn.SetUINT32(MediaFoundationAttributes.MF_MT_AUDIO_BLOCK_ALIGNMENT, 4);
        audioMediaTypeIn.SetUINT32(MediaFoundationAttributes.MF_MT_AUDIO_AVG_BYTES_PER_SECOND, 192000);
        audioMediaTypeIn.SetUINT32(MediaFoundationAttributes.MF_MT_AUDIO_BITS_PER_SAMPLE, 16);
        audioMediaTypeIn.SetUINT32(MediaFoundationAttributes.MF_MT_ALL_SAMPLES_INDEPENDENT, 1);

        sinkWriter?.SetInputMediaType(audioStreamIndex, audioMediaTypeIn, null);
    }

    private void StartCapturingThread()
    {
        var oldQueue = audioSampleQueue;
        if (oldQueue != null)
        {
            while (oldQueue.TryDequeue(out var sample))
            {
                Marshal.ReleaseComObject(sample);
            }
        }

        audioSampleQueue = new Queue<IMFSample>();
        cancellationTokenSource = new CancellationTokenSource();

        if (DeckLinkDevice == null || SampleMemoryAllocator == null)
        {
            IsCapturing = false;
            return;
        }

        Task.Run(() =>
        {

            MtaHelper.ExecuteMtaAction(() =>
            {
                DeckLinkDevice.VideoFrameHandler += VideoFrameHandler;
                DeckLinkDevice.AudioPacketHandler += AudioPacketHandler;
                DeckLinkDevice.StartCapture(DisplayMode, DetectDisplayModeAutomatically, SampleMemoryAllocator);
            });

            MtaHelper.ExecuteMtaAction(() =>
            {
                sinkWriter?.BeginWriting();
            });

            try
            {
                var videoTask = Task.Run(() =>
                {
                    while (IsCapturing)
                    {
                        MtaHelper.ExecuteMtaAction(SinkVideoSample);
                    }
                });

                var audioTask = Task.Run(() =>
                {
                    while (IsCapturing)
                    {
                        MtaHelper.ExecuteMtaAction(SinkAudioSample);
                    }
                });

                videoTask.Wait();
                audioTask.Wait();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                MtaHelper.ExecuteMtaAction(() => { sinkWriter?.DoFinalize(); });
            }
        });
    }

    private void AudioPacketHandler(IDeckLinkAudioInputPacket audioInputPacket)
    {
        audioInputPacket.GetBytes(out var audioPacketBuffer);
        audioInputPacket.GetPacketTime(out var packetTime, TimeScale);
        var bufferLength = audioInputPacket.GetSampleFrameCount() * 2 * (16 / 8);

        var sampleMediaBuffer = MediaFoundationApi.CreateMemoryBuffer(bufferLength);
        sampleMediaBuffer.Lock(out var sampleBuffer, out var maxBufferLength, out var currentLength);

        MediaFoundationHelper.MemoryCopy(sampleBuffer, audioPacketBuffer, bufferLength);

        sampleMediaBuffer.Unlock();
        sampleMediaBuffer.SetCurrentLength(bufferLength);

        var audioSample = MediaFoundationApi.CreateSample();
        audioSample.AddBuffer(sampleMediaBuffer);
        audioSample.SetSampleTime(packetTime);
        audioSample.SetSampleDuration(audioInputPacket.GetSampleFrameCount() * TimeScale / (int)_BMDAudioSampleRate.bmdAudioSampleRate48kHz);

        audioSampleQueue?.Enqueue(audioSample);

        audioQueueSemaphore.Release();
    }

    private void VideoFrameHandler(IDeckLinkVideoInputFrame deckLinkVideoInputFrame)
    {
        if (PreviewCallback != null)
        {
            var frame = new Bgra32FrameConverter().ConvertFrame(deckLinkVideoInputFrame);
            PreviewCallback?.Invoke(frame);
        }

        SampleMemoryAllocator!.VideoFrameArrived(deckLinkVideoInputFrame);
    }

    private void SinkAudioSample()
    {
        IMFSample? sample = null;

        try
        {
            audioQueueSemaphore.Wait(cancellationTokenSource?.Token ?? CancellationToken.None);
            audioSampleQueue?.TryDequeue(out sample);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        if (sample != null)
        {
            sinkWriter?.WriteSample(audioStreamIndex, sample);
            Marshal.ReleaseComObject(sample);
        }
    }

    private void SinkVideoSample()
    {
        IMFSample? sample = null;

        try
        {
            SampleMemoryAllocator?.WaitForInputSample(out sample, cancellationTokenSource!.Token);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        if (sample != null)
        {
            sinkWriter?.WriteSample(videoStreamIndex, sample);
            Marshal.ReleaseComObject(sample);
        }
    }
}