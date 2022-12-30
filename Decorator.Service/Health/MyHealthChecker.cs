using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Service.Health
{
    public class MyHealthChecker : IHealthChecker
    {
        private IHealthChecker _healthChecker;

        public MyHealthChecker(IHealthChecker healthChecker)
        {
            _healthChecker = healthChecker;
        }
        public string Ping()
        {
            if (_healthChecker.Ping() == "Pong")
                return "OK";
            return "NOT OK";
        }
    }
}
