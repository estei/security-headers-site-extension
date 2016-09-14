using System;
using Microsoft.AspNetCore.Mvc;
using SecurityHeaders.HeaderConfiguration;

namespace SecurityHeaders.Controllers
{
    [Route("configuration")]
    public class ConfigurationController : Controller
    {
        private readonly HeaderConfigurationService _headerConfigurationService;

        public ConfigurationController(HeaderConfigurationService headerConfigurationService)
        {
            if (headerConfigurationService == null) throw new ArgumentNullException(nameof(headerConfigurationService));
            _headerConfigurationService = headerConfigurationService;
        }

        [HttpGet]
        public HeadersConfiguration Get()
            => _headerConfigurationService.GetConfig();
    }
}