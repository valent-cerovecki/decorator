using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Service.Calculator
{
    public class MyCalculator : ICalculator
    {
        private ICalculator _calculator;
        public MyCalculator(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public double Add(double left, double right)
            => _calculator.Add(left, right);

        public double Multiply(double left, double right)
            => _calculator.Multiply(left, right);

        public double Divide(double left, double right)
            => right == 0 ? 0 : _calculator.Divide(left, right);
    }
}
