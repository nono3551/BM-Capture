﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12video.h(6858,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_H264_REFERENCE_PICTURE_LIST_MODIFICATION_OPERATION
    {
        public byte modification_of_pic_nums_idc;
        public uint abs_diff_pic_num_minus1;
        public uint long_term_pic_num;
    }
}
