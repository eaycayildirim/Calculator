using System;

namespace nsIOperations
{
    public class Pow : IOperations
    {
        public double Compute(double firstNumber, double secondNumber = 2d)
        {
            return Math.Pow(firstNumber, secondNumber);
        }
    }
}
