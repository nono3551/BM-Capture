﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mftransform.h(163,1)
namespace DirectN
{
    public enum _MFT_MESSAGE_TYPE
    {
        MFT_MESSAGE_COMMAND_FLUSH = 0,
        MFT_MESSAGE_COMMAND_DRAIN = 1,
        MFT_MESSAGE_SET_D3D_MANAGER = 2,
        MFT_MESSAGE_DROP_SAMPLES = 3,
        MFT_MESSAGE_COMMAND_TICK = 4,
        MFT_MESSAGE_NOTIFY_BEGIN_STREAMING = 268435456,
        MFT_MESSAGE_NOTIFY_END_STREAMING = 268435457,
        MFT_MESSAGE_NOTIFY_END_OF_STREAM = 268435458,
        MFT_MESSAGE_NOTIFY_START_OF_STREAM = 268435459,
        MFT_MESSAGE_NOTIFY_RELEASE_RESOURCES = 268435460,
        MFT_MESSAGE_NOTIFY_REACQUIRE_RESOURCES = 268435461,
        MFT_MESSAGE_NOTIFY_EVENT = 268435462,
        MFT_MESSAGE_COMMAND_SET_OUTPUT_STREAM_STATE = 268435463,
        MFT_MESSAGE_COMMAND_FLUSH_OUTPUT_STREAM = 268435464,
        MFT_MESSAGE_COMMAND_MARKER = 536870912,
    }
}
