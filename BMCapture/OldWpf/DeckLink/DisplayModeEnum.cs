using System;
using System.Collections;
using DeckLinkAPI;
using System.Collections.Generic;

namespace BMCapture.OldWpf.DeckLink
{
    public class DisplayModeEnum : IEnumerator<IDeckLinkDisplayMode>, IEnumerable<IDeckLinkDisplayMode>
    {
        private IDeckLinkDisplayModeIterator m_displayModeIterator;
        private IDeckLinkDisplayMode m_displayMode;

        public DisplayModeEnum(IDeckLinkDisplayModeIterator displayModeIterator)
        {
            m_displayModeIterator = displayModeIterator;
        }

        IDeckLinkDisplayMode IEnumerator<IDeckLinkDisplayMode>.Current
        {
            get { return m_displayMode; }
        }

        bool IEnumerator.MoveNext()
        {
            m_displayModeIterator.Next(out m_displayMode);
            return m_displayMode != null;
        }

        void IDisposable.Dispose()
        {
        }

        object IEnumerator.Current
        {
            get { return m_displayMode; }
        }

        void IEnumerator.Reset()
        {
            throw new InvalidOperationException();
        }

        public IEnumerator<IDeckLinkDisplayMode> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
