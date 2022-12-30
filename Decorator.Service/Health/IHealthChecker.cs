using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Service.Health
{
    public interface IHealthChecker
    {
        public string Ping();
    }
}
