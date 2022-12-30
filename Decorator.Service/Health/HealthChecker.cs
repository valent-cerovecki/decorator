using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Service.Health
{
    public class HealthChecker : IHealthChecker
    {
        public string Ping() => "Pong";
    }
}
