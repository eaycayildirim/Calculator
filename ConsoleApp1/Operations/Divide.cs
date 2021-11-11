using System;

namespace nsIOperations
{
    public class Divide : IOperations
    {
        public double Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}
