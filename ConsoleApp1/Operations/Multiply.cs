using System;

namespace nsIOperations
{
    public class Multiply : IOperations
    {
        public double Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}
