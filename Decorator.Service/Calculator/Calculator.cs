using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Service.Calculator
{
    public class Calculator : ICalculator
    {
        public double Add(double left, double right)
            => left + right;

        public double Divide(double left, double right)
            => left / right;

        public double Multiply(double left, double right)
            => left * right;
    }
}
