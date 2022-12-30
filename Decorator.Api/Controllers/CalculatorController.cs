using Decorator.Service.Calculator;
using Microsoft.AspNetCore.Mvc;

namespace Decorator.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private ICalculator _calculator;
        public CalculatorController(ICalculator calculator)
        {
            _calculator = calculator;
        }

        [HttpGet("add")]
        public double Add([FromQuery] double left, [FromQuery] double right)
            => _calculator.Add(left, right);

        [HttpGet("multiply")]
        public double Multiply([FromQuery] double left, [FromQuery] double right)
            => _calculator.Multiply(left, right);

        [HttpGet("divide")]
        public double Divide([FromQuery] double left, [FromQuery] double right)
            => _calculator.Divide(left, right);
    }
}
