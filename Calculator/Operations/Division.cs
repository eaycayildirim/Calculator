using System;

namespace nsIOperations
{
    public class Division : IOperations
    {
        public double Compute(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}
