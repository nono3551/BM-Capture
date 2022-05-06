﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(11123,9)
using System;
using System.Runtime.InteropServices;
using PFND3D12DDI_CALCPRIVATEVIDEODECODERHEAPSIZE_0033 = System.IntPtr;
using PFND3D12DDI_CALCPRIVATEVIDEODECODERSIZE_0032 = System.IntPtr;
using PFND3D12DDI_CALCPRIVATEVIDEOPROCESSORSIZE_0032 = System.IntPtr;
using PFND3D12DDI_CREATEVIDEODECODER_0032 = System.IntPtr;
using PFND3D12DDI_CREATEVIDEODECODERHEAP_0033 = System.IntPtr;
using PFND3D12DDI_CREATEVIDEOPROCESSOR_0032 = System.IntPtr;
using PFND3D12DDI_DESTROYVIDEODECODER_0021 = System.IntPtr;
using PFND3D12DDI_DESTROYVIDEODECODERHEAP_0032 = System.IntPtr;
using PFND3D12DDI_DESTROYVIDEOPROCESSOR_0021 = System.IntPtr;
using PFND3D12DDI_VIDEO_GETCAPS = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_DEVICE_FUNCS_VIDEO_0033
    {
        public IntPtr pfnGetCaps;
        public IntPtr pfnCalcPrivateVideoDecoderSize;
        public IntPtr pfnCreateVideoDecoder;
        public IntPtr pfnDestroyVideoDecoder;
        public IntPtr pfnCalcPrivateVideoDecoderHeapSize;
        public IntPtr pfnCreateVideoDecoderHeap;
        public IntPtr pfnDestroyVideoDecoderHeap;
        public IntPtr pfnCalcPrivateVideoProcessorSize;
        public IntPtr pfnCreateVideoProcessor;
        public IntPtr pfnDestroyVideoProcessor;
    }
}
