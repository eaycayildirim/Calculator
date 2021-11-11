using System;

namespace nsIOperations
{
    public class Substract : IOperations
    {
        public double Calculate(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}
