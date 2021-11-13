using System;

namespace nsIOperations
{
    public class Sqrt : IOperations
    {
        public double Compute(double firstNumber, double secondNumber = 2d)
        {
            return Math.Sqrt(firstNumber);
        }
    }
}
