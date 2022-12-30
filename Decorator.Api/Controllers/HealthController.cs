using Decorator.Service.Calculator;
using Decorator.Service.Health;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Decorator.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        private IHealthChecker _healthChecker;
        public HealthController(IHealthChecker healthChecker)
        {
            _healthChecker = healthChecker;
        }

        [HttpGet]
        public string Ping()
            => _healthChecker.Ping();
    }
}
