using System;
using nsIOperations;

namespace nsOperations
{
    public class Sqrt : IOperations
    {
        public double Compute(double firstNumber, double secondNumber = 2d)
        {
            return Math.Pow(firstNumber, 1/secondNumber);
        }
    }
}
