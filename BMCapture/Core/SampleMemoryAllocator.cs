using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using BMCapture.Core.Capturing;
using BMCapture.Core.MediaFoundation;
using DeckLinkAPI;
using NAudio.MediaFoundation;

namespace BMCapture.Core;

public class SampleMemoryAllocator : IDeckLinkMemoryAllocator
{
    private SemaphoreSlim semaphore = new(0, int.MaxValue);
    private Queue<IMFSample> samplesQueue = new();

    public bool VideoInterlaced { get; set; }

    private Dictionary<IntPtr, IMFMediaBuffer> allocatedBuffers = new();


    ~SampleMemoryAllocator()
    {
        while (samplesQueue.TryDequeue(out var sample))
        {
            Marshal.ReleaseComObject(sample);
        }
    }

    public void AllocateBuffer(uint bufferSize, out IntPtr allocatedBuffer)
    {
        MediaFoundationHelper.MFCreateAlignedMemoryBuffer(bufferSize, MediaFoundationHelper.MF_64_BYTE_ALIGNMENT, out IMFMediaBuffer mediaBuffer);
        mediaBuffer.Lock(out allocatedBuffer, out var maxLength, out var currentLength);
        allocatedBuffers.Add(allocatedBuffer, mediaBuffer);
    }

    public void ReleaseBuffer(IntPtr buffer)
    {
        allocatedBuffers.TryGetValue(buffer, out var allocatedBuffer);

        if (allocatedBuffer != null)
        {
            Marshal.ReleaseComObject(allocatedBuffer);
        }

        allocatedBuffers.Remove(buffer);
    }

    public void Commit() { }

    public void Decommit() { }

    public void WaitForInputSample(out IMFSample? sample, CancellationToken cancellationToken)
    {
        semaphore.Wait(cancellationToken);
        samplesQueue.TryDequeue(out sample);
    }

    public void VideoFrameArrived(IDeckLinkVideoInputFrame videoInputFrame)
    {
        videoInputFrame.GetStreamTime(out var frameTime, out var frameDuration, CaptureManager.TimeScale);
        videoInputFrame.GetBytes(out var buffer);

        var allocatedBufferFound = allocatedBuffers.TryGetValue(buffer, out var allocatedBuffer);

        if (!allocatedBufferFound || allocatedBuffer == null)
        {
            return;
        }

        allocatedBuffer.SetCurrentLength(videoInputFrame.GetRowBytes() * videoInputFrame.GetHeight());

        var videoSample = MediaFoundationApi.CreateSample();
        videoSample.AddBuffer(allocatedBuffer);
        videoSample.SetSampleTime(frameTime);
        videoSample.SetSampleDuration(frameDuration);
        videoSample.SetUINT32(MediaFoundationHelper.MFSampleExtension_Interlaced, VideoInterlaced ? 1 : 0);

        samplesQueue.Enqueue(videoSample);

        semaphore.Release();
    }
}