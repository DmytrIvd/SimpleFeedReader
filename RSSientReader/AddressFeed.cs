using System;

namespace RSSientReader
{
    public class AddressFeed
    {
        public AddressFeed(string uri, bool isEnabled)
        {
            Uri = uri ?? throw new ArgumentNullException(nameof(uri));
            IsEnabled = isEnabled;
        }

        public string Uri { get; set; }
        public bool IsEnabled { get; set; }

        public override string ToString()
        {
            return Uri;
        }
    }
}
