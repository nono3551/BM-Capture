using DeckLinkAPI;

namespace BMCapture.OldWpf.DeckLink
{
    public delegate void DeckLinkInputSignalHandler(bool inputSignal);
    public delegate void DeckLinkFormatChangedHandler(IDeckLinkDisplayMode newDisplayMode);
    public delegate void DeckLinkDiscoveryHandler(IDeckLink decklinkDevice);
    public delegate void DeckLinkVideoFrameHandler(IDeckLinkVideoInputFrame videoInputFrame);
    public delegate void DeckLinkAudioPacketHandler(IDeckLinkAudioInputPacket audioInputPacket);
}
