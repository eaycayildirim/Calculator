using System;

namespace nsIOperations
{
    public class Substract : IOperations
    {
        public double Compute(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}
