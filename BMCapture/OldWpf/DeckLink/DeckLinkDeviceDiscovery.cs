using DeckLinkAPI;

namespace BMCapture.OldWpf.DeckLink
{
    class DeckLinkDeviceDiscovery : IDeckLinkDeviceNotificationCallback
    {
        private IDeckLinkDiscovery m_deckLinkDiscovery;

        public event DeckLinkDiscoveryHandler? DeviceArrived;
        public event DeckLinkDiscoveryHandler? DeviceRemoved;

        public DeckLinkDeviceDiscovery()
        {
            m_deckLinkDiscovery = new CDeckLinkDiscovery();
        }

        ~DeckLinkDeviceDiscovery()
        {
            Disable();
        }

        public void Enable()
        {
            m_deckLinkDiscovery.InstallDeviceNotifications(this);
        }
        public void Disable()
        {
            m_deckLinkDiscovery.UninstallDeviceNotifications();
        }

        void IDeckLinkDeviceNotificationCallback.DeckLinkDeviceArrived(IDeckLink deckLinkDevice)
        {
            DeviceArrived?.Invoke(deckLinkDevice);
        }

        void IDeckLinkDeviceNotificationCallback.DeckLinkDeviceRemoved(IDeckLink deckLinkDevice)
        {
            DeviceRemoved?.Invoke(deckLinkDevice);
        }
    }
}
