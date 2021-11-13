using System;

namespace nsIOperations
{
    public class Sum : IOperations
    {
        public double Compute(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
