using DockerApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

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
        public IEnumerable<BaseModel> Get()
        {
            _logger.LogInformation(DateTime.Now.ToString());

            var list = new List<BaseModel>();

            var baseModel = new BaseModel
            {
                Hostname = Environment.MachineName,
                DateTime = DateTime.Now,
                Version = 1.1
            };
            list.Add(baseModel);

            return list;
        }
    }
}