using DockerApi.Models;
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
        public BaseModel Get()
        {
            _logger.LogInformation(DateTime.Now.ToString());

            var model = new BaseModel
            {
                Hostname = Environment.MachineName,
                DateTime = DateTime.Now,
                Version = 1.1
            };

            return model;
        }
    }
}