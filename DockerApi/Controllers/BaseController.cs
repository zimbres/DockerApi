using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace DockerApi.Controllers
{
    [ApiController]
    [Route("")]
    public class BaseController : ControllerBase
    {
        private readonly ILogger<BaseController> _logger;

        public BaseController(ILogger<BaseController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            _logger.LogInformation(DateTime.Now.ToString());
            return $"{Environment.MachineName} - Version 1.0";
        }
    }
}