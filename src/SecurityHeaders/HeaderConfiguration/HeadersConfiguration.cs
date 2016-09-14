using System.Collections.Generic;
using SecurityHeaders.HeaderConfiguration.HeaderValues;

namespace SecurityHeaders.HeaderConfiguration
{
    public class HeadersConfiguration
    {
        public HeaderConfiguration<XXssProtectionValue> XXssProtectionConfig { get; set; }
        public HeaderConfiguration<XContentTypeOptionsValue> XContentTypeOptions { get; set; }
        public bool RemoveServerHeader { get; set; }
        public List<CustomHeader> CustomHeaders { get; set; } = new List<CustomHeader>();
    }
}