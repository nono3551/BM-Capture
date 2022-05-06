using DeckLinkAPI;
using System;

namespace BMCapture.OldWpf
{
    public class Bgra32VideoFrame : IDeckLinkVideoFrame
    {
        public int m_width;
        public int m_height;
        private _BMDFrameFlags m_flags;
        public IntPtr m_pixelBuffer;
        public IntPtr m_unmanagedBuffer = IntPtr.Zero;
        private int m_pixelBufferBytes;

        // Constructor generates empty pixel buffer
        public Bgra32VideoFrame(int width, int height, _BMDFrameFlags flags)
        {
            m_width = width;
            m_height = height;
            m_flags = flags;
            m_pixelBufferBytes = m_width * m_height * 4;

            // Allocate pixel buffer from unmanaged memory
            m_unmanagedBuffer = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(m_pixelBufferBytes);
            m_pixelBuffer = m_unmanagedBuffer;

            GC.AddMemoryPressure(m_pixelBufferBytes);
        }

        // Copy constructor
        public Bgra32VideoFrame(IDeckLinkVideoFrame frame)
        {
            m_width = frame.GetWidth();
            m_height = frame.GetHeight();
            m_flags = frame.GetFlags();

            frame.GetBytes(out m_pixelBuffer);
        }

        ~Bgra32VideoFrame()
        {
            // Free pixel buffer from unmanaged memory
            if (m_unmanagedBuffer != null)
            {
                System.Runtime.InteropServices.Marshal.FreeCoTaskMem(m_unmanagedBuffer);
                GC.RemoveMemoryPressure(m_pixelBufferBytes);
            }
        }

        int IDeckLinkVideoFrame.GetWidth()
        {
            return m_width;
        }

        int IDeckLinkVideoFrame.GetHeight()
        {
            return m_height;
        }

        int IDeckLinkVideoFrame.GetRowBytes()
        {
            return m_width * 4;
        }

        _BMDFrameFlags IDeckLinkVideoFrame.GetFlags()
        {
            return m_flags;
        }

        _BMDPixelFormat IDeckLinkVideoFrame.GetPixelFormat()
        {
            return _BMDPixelFormat.bmdFormat8BitBGRA;
        }

        void IDeckLinkVideoFrame.GetBytes(out IntPtr buffer)
        {
            buffer = m_pixelBuffer;
        }

        // Dummy implementations of remaining methods
        void IDeckLinkVideoFrame.GetAncillaryData(out IDeckLinkVideoFrameAncillary ancillary)
        {
            throw new NotImplementedException();
        }

        void IDeckLinkVideoFrame.GetTimecode(_BMDTimecodeFormat format, out IDeckLinkTimecode timecode)
        {
            throw new NotImplementedException();
        }
    }

    // Actual converter class
    public sealed class Bgra32FrameConverter
    {
        private IDeckLinkVideoConversion m_deckLinkConversion;

        public Bgra32FrameConverter()
        {
            m_deckLinkConversion = new CDeckLinkVideoConversion();
        }

        public Bgra32VideoFrame ConvertFrame(IDeckLinkVideoFrame srcFrame)
        {
            Bgra32VideoFrame dstFrame;

            // Check whether srcFrame is already bmdFormat8BitBGRA
            if (srcFrame.GetPixelFormat() == _BMDPixelFormat.bmdFormat8BitBGRA)
            {
                dstFrame = new Bgra32VideoFrame(srcFrame);
            }
            else
            {
                dstFrame = new Bgra32VideoFrame(srcFrame.GetWidth(), srcFrame.GetHeight(), srcFrame.GetFlags());
                m_deckLinkConversion.ConvertFrame(srcFrame, dstFrame);
            }
            return dstFrame;
        }
    }
}
