namespace Decorator.Service.Calculator
{
    public interface ICalculator
    {
        public double Add(double left, double right);
        public double Multiply(double left, double right);
        public double Divide(double left, double right);
    }
}