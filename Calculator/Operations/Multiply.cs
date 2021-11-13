using System;
using nsIOperations;

namespace nsOperations
{
    public class Multiply : IOperations
    {
        public double Compute(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}
