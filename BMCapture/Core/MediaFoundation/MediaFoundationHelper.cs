using System;
using System.Runtime.InteropServices;
using NAudio.MediaFoundation;

namespace BMCapture.Core.MediaFoundation;

public static class MediaFoundationHelper
{
    public static void MFSetAttributeSize(IMFAttributes attributes, Guid key, uint width, uint height)
    {
        var packed = PackUint64(width, height);
        attributes.SetUINT64(key, (long)packed);
    }

    private static ulong PackUint64(uint high, uint low)
    {
        return (ulong)high << 32 | low;
    }


    [DllImport("mfplat.dll", PreserveSig = false)]
    public static extern void MFCreateAlignedMemoryBuffer([In] uint cbMaxLength, [In] int cbAligment, out IMFMediaBuffer ppBuffer);



    [DllImport("msvcrt.dll", EntryPoint = "memcpy", SetLastError = false)]
    public static extern IntPtr MemoryCopy(IntPtr dest, IntPtr src, int count);




    public const int MF_64_BYTE_ALIGNMENT = 0x0000003f;

    public static Guid MF_MT_FRAME_SIZE = new Guid("1652c33d-d6b2-4012-b834-72030849a37d");
    public static Guid MF_MT_FRAME_RATE = new Guid("C459A2E8-3D2C-4E44-B132-FEE5156C7BB0");
    public static Guid MF_MT_INTERLACE_MODE = new Guid("e2724bb8-e676-4806-b4b2-a8d6efb44ccd");
    public static Guid MEDIASUBTYPE_H264 = new Guid("34363248-0000-0010-8000-00AA00389B71");
    public static Guid MF_MT_PIXEL_ASPECT_RATIO = new Guid("C6376A1E-8D0A-4027-BE45-6D9A0AD39BB6");
    public static Guid MFSampleExtension_Interlaced = new Guid("b1d5830a-deb8-40e3-90fa-389943716461");
    public static Guid MFAudioFormat_AAC = new Guid("00001610-0000-0010-8000-00AA00389B71");
    public static Guid MFAudioFormat_PCM = new Guid("00000001-0000-0010-8000-00AA00389B71");


    public static int WAVE_FORMAT_MPEG_HEAAC = 0x1610;
    public static int WAVE_FORMAT_PCM = 1;

    public static Guid MF_MT_AUDIO_NUM_CHANNELS = new Guid("f7e34c9a-42e8-4714-b74b-cb29d72c35e5");
    public static Guid MF_MT_AUDIO_SAMPLES_PER_SECOND = new Guid("5faeeae7-0290-4c31-9e8a-c534f68d9dba");
    public static Guid MF_MT_AUDIO_BLOCK_ALIGNMENT = new Guid("322de230-9eeb-43bd-ab7a-ff412251541d");
    public static Guid MF_MT_AUDIO_AVG_BYTES_PER_SECOND = new Guid("1aab75c8-cfef-451c-ab95-ac034b8e1731");
    public static Guid MF_MT_AUDIO_BITS_PER_SAMPLE = new Guid("f2deb57f-40fa-4764-aa33-ed4f2d1ff669");
    public static Guid MF_MT_ALL_SAMPLES_INDEPENDENT = new Guid("c9173739-5e56-461c-b713-46fb995cb95f");
}