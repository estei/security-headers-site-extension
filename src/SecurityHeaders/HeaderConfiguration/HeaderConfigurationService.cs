using SecurityHeaders.HeaderConfiguration.HeaderValues;

namespace SecurityHeaders.HeaderConfiguration
{
    public class HeaderConfigurationService
    {
        public HeadersConfiguration GetConfig()
        {
            var config = new HeadersConfiguration
            {
                RemoveServerHeader = true,
                XContentTypeOptions = new HeaderConfiguration<XContentTypeOptionsValue>
                {
                    HeaderEnabled = true,
                    Value = new XContentTypeOptionsValue { Enabled = true }
                },
                XXssProtectionConfig = new HeaderConfiguration<XXssProtectionValue>
                {
                    HeaderEnabled = true,
                    Value = new XXssProtectionValue
                    {
                        Enabled = true,
                        Block = false
                    }
                }
            };
            config.CustomHeaders.Add(new CustomHeader { Name = "X-This-Is-A-Rockin-Header", Value = "Trudat" });
            return config;
        }
    }
}